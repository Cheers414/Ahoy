using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        ahoyCorpEntities1 ace = new ahoyCorpEntities1();
        public new void BringToFront()//此處為元件初始化
        {
            dtpShiftDatetime.MaxDate = DateTime.Now;
            
            //cbShiftType.DataSource = ace.ShiftRule.ToList();
            //cbShiftEmpolyee.DataSource = ace.Employee.ToList();
            cbStore.DataSource = ace.Store.ToList();
            cbStore.DisplayMember = "storeName";
            //cbShiftType.DisplayMember = "shiftRuleName";
            //cbShiftEmpolyee.DisplayMember = "employeeName";
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
            var shiftAttendance = ace.Attendance.ToList().Where(x => x.attendanceStartDateTime.Date == dtpShiftDatetime.Value.Date&&x.Store == cbStore.SelectedItem).ToList();
            if (shiftAttendance == null)
            {
                MessageBox.Show("找不到資料", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dtShift = new DataTable("dtShift");
            dtShift.Columns.Add("ID");
            dtShift.Columns.Add("員工姓名");
            dtShift.Columns.Add("班別");
            shiftAttendance.ForEach(x => { dtShift.Rows.Add(new object[] { 
            x.AttendanceEmployeeID,x.Employee.employeeName,x.ShiftRule.shiftRuleName
            }); });
            dgv1.DataSource = dtShift;
        }

        private void shiftTabpage_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
