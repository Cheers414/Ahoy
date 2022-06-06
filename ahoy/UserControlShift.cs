using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahoy
{
    public partial class UserControlShift : UserControl
    {
        public UserControlShift()
        {
            InitializeComponent();
        }
        ahoyCorpEntities ace = new ahoyCorpEntities();
        List<string> listTime = new List<string> { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00","17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
        public new void BringToFront()//此處為元件初始化
        {
            dtpShiftDatetime.Value = DateTime.Now;

            cbShiftRuleType.DataSource = ace.ShiftRule.ToList();
            cbStore.DataSource = ace.Store.ToList();
            cbStore.DisplayMember = "storeName";
            cbShiftRuleType.DisplayMember = "shiftRuleName";
            cbShiftTypeEndTime.DataSource = 　cbShiftTypeStartTime.DataSource = listTime.ToList();
            
            base.BringToFront();
        }

        private void uiBtnReset_Click(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void uiBtnSave_Click(object sender, EventArgs e)
        {
#if DEBUG
            if (MessageBox.Show("確定儲存?", Properties.Resources.systemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("debug");
            }
#else
            if (MessageBox.Show("確定儲存?", Properties.Resources.systemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ace.SaveChanges();
            }
#endif


        }

        private void dtpShiftDatetime_ValueChanged(object sender, EventArgs e)
        {
            var shiftAttendance = ace.Attendance.ToList().Where(x => x.attendanceStartDateTime.Date == dtpShiftDatetime.Value.Date 
            && x.Store == cbStore.SelectedItem).ToList();
            if (shiftAttendance == null)
            {
                MessageBox.Show("找不到資料", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dtShift = new DataTable("dtShift");
            dtShift.Columns.Add("ID");
            dtShift.Columns.Add("員工姓名");
            dtShift.Columns.Add("班別");
            shiftAttendance.ForEach(x =>
            {
               dtShift.Rows.Add(new object[] {

            x.AttendanceEmployeeID,x.Employee.employeeName,x.ShiftRule.shiftRuleName
            });
                
            });
            dgvShift.DataSource = RemoveDuplicateRows(dtShift,"ID");
            
        }

       
        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable Table = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            foreach (DataRow drow in dTable.Rows)
            {
                if (Table.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    Table.Add(drow[colName], string.Empty);
            }

            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            return dTable;
        }

        private void dgvShift_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtpShiftDatetime.Value <= DateTime.Now)
            {
                MessageBox.Show("過去的資料無法竄改", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormShift formShift = new FormShift();
            formShift.empolyeeId = (int)dgvShift.SelectedRows[e.RowIndex].Cells[0].Value;
            formShift.empolyeeName = (string)dgvShift.SelectedRows[e.RowIndex].Cells[1].Value;
            formShift.empolyeeType = (string)dgvShift.SelectedRows[e.RowIndex].Cells[2].Value;
            if (formShift.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var employeeShift = ace.Attendance.ToList().SingleOrDefault(x => x.Store == cbStore.SelectedItem && x.AttendanceEmployeeID == formShift.empolyeeId && x.attendanceStartDateTime == dtpShiftDatetime.Value);
            employeeShift.ShiftRule = ace.ShiftRule.ToList().SingleOrDefault(x => x.shiftRuleName == formShift.empolyeeType);
            ace.Entry(employeeShift).State = EntityState.Modified;
        }


        private void dgvShift_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void cbShiftRuleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
