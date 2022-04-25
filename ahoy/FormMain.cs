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
    }
}
