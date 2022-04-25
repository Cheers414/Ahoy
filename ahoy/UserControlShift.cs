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
        public new void BringToFront()//此處為元件初始化
        {


            base.BringToFront();
        }
    }
}
