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
            pictureBoxLogo.Image = Image.FromFile(AppContext.BaseDirectory + @"Images\Logo.png");
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
            //UserControlHR.BringToFront();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            //UserControlSalary.BringToFront();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            //UserControlShift.BringToFront();
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            //UserControlApproval.BringToFront();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            //UserControlAttendance.BringToFront();
        }
    }
}
