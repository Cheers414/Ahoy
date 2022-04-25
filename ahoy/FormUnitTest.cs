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
    public partial class FormUnitTest : Form
    {
        public FormUnitTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formMain().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControlApproval1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new formLogin().ShowDialog();
        }

        private void FormUnitTest_Load(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControlAttendance1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControlHR1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControlSalary1.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            userControlShift1.BringToFront();
        }
    }
}
