#define dr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahoy
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            DialogResult dr = MessageBox.Show("啟動單元測試", Properties.Resources.cropName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (dr == DialogResult.Yes)
            {
                Application.Run(new FormUnitTest());
            }
            else
            {

                if (new formLogin().ShowDialog()== DialogResult.OK)
                {
                    //TO DO 添加Login 的 LOG
                    Application.Run(new formMain());
                }
                else
                {
                    Application.Exit();
                }
            }

            Application.ThreadException += Application_ThreadException;
#else
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new formLogin().DialogResult == DialogResult.OK)
                {
                    Application.Run(new formMain());
                }
                else
                {
                    Application.Exit();
                }
            Application.ThreadException += Application_ThreadException;
#endif
        }

        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("觸發預期外錯誤", Properties.Resources.cropName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
