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
    public partial class UserControlAttendance : UserControl
    {
        public UserControlAttendance()
        {
            InitializeComponent();
        }
        public new void BringToFront()//此處為元件初始化
        {


            base.BringToFront();
        }

        private void UserControlAttendance_Load(object sender, EventArgs e)
        {
            LabNowTime.Text = "目前時間為:"+DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
