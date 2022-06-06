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
        ahoyCorpEntities ace = new ahoyCorpEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
#if DEBUG
            // TO DO: 接上資料庫的Account : done

            try
            {
                var UserAccount = ace.Account.ToList().SingleOrDefault(x => x.account == txtInputAccount.Text && x.password == txtInputPassword.Text&&x.isEnable == true);
                globalVariable.user = UserAccount;
            }
            catch
            {
                MessageBox.Show("帳號或密碼有誤", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                globalVariable.user = null;
                return;
            }
            if (globalVariable.user == null)
            {
                MessageBox.Show("找不到此帳號", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("登入成功", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;

#else
             try
            {
                  var UserAccount = ace.Account.ToList().SingleOrDefault(x => x.account == txtInputAccount.Text && x.password == txtInputPassword.Text&&x.isEnable == true);
                globalVariable.user = UserAccount;
            }
            catch
            {
                MessageBox.Show("帳號或密碼有誤", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                globalVariable.user = null;
                return;
            }
            if (globalVariable.user == null)
            {
                MessageBox.Show("找不到此帳號", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("登入成功", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
#endif

            Close();

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            globalVariable.user = null;
            DialogResult = DialogResult.None;
            txtInputAccount.Text = "";
            txtInputPassword.Text = "";
        }
        public new void Close()
        {
            if (DialogResult == DialogResult.None)
            {
                DialogResult = DialogResult.Cancel;
            }
            base.Close();
        }
    }
}
