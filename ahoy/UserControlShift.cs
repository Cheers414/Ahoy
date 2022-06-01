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
        ahoyCorpEntities ace = new ahoyCorpEntities();
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
            //var storeDatetime = ace;
            //&& x.attendanceStartDateTime == dtpShiftDatetime.Value
            //if (storeDatetime == null)
            //{
            //    MessageBox.Show("找不到", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            
            DataTable dtShiftType = new DataTable();
            foreach (var i in ace.ShiftRule.ToList())
            {
                dtShiftType.Rows.Add(i);
            }
            
        }
    }
}
