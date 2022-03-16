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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
#if DEBUG
            // TO DO: 接上資料庫的Account
            string account = "",
                password = "",
                errorMsg = "";
#else
            string account = "__",
            password = "__", 
            errorMsg = "";
#endif
            if (txtInputAccount.Text == account && txtInputPassword.Text == password)
            {
                MessageBox.Show("登入成功", Properties.Resources.cropName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (txtInputAccount.Text != account)
                {
                    errorMsg += "帳號\n";
                }
                if (txtInputPassword.Text != password)
                {
                    errorMsg += "密碼\n";
                }
                MessageBox.Show(errorMsg + "存在錯誤", Properties.Resources.cropName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            txtInputAccount.Text = "";
            txtInputPassword.Text = "";
        }
    }
}
