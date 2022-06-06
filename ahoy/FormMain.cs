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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            panelWorkspace.BringToFront();
            pictureBoxLogo.Image = Properties.Resources.logo1;
        }


        private void picButtonGoToUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (new formLogin().ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
            formMain_Load(null,null);
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
           // userControlHR.BringToFront();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
           // userControlSalary.BringToFront();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            userControlShift1.BringToFront();
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            userControlApproval1.BringToFront();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
           userControlAttendance1.BringToFront();
        }
    }
}
