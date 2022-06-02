<<<<<<< Updated upstream
﻿using System;
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
    public partial class UserControlApproval : UserControl
    {
        public UserControlApproval()
        {
            InitializeComponent();
        }
        public new void BringToFront()//此處為元件初始化
        {

            
            base.BringToFront();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ahoy
{
    public partial class UserControlApproval : UserControl
    {
        public UserControlApproval()
        {
            InitializeComponent();
        }
        //連線字串 "cnstr"
        String cnstr = @"Data Source = LAPTOP-6CUSQ4M2; Initial Catalog = MyDB; Integrated Security = TRUE";

        //帶入SQL命令並回傳查詢結果
        DataTable GetTable(string sqlcmd, SqlParameter[] parameters)
        {
            SqlConnection cn = new SqlConnection(cnstr);// 建立 SqlConnection 物件"cn"
            cn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, cn);// 建立 SqlDataAdapter"da"取得"sqlcmd"指令回傳
            da.SelectCommand.Parameters.AddRange(parameters);
            da.Fill(ds);//將"da" 取得資料存入"ds"
            return ds.Tables[0];//回傳DataTable 記錄
        }
        
        //Approval_Load 元件 初始化
        private void UserControlApproval_Load(object sender, EventArgs e)
        {
            ShowLeaveRecord();

            var table = accountTableAdapter.GetData();

            accountTableAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        //顯示個人請假紀錄
        private void ShowLeaveRecord()
        {
            int StaffId = 1101;// @StaffId登入員工編號
            int index = 0;
            string sqlstr = "SELECT * From Table_staff_leave_record WHERE 員工編號=@StaffId"; // sql命令
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("@StaffId", StaffId));
            var dt = GetTable(sqlstr, param.ToArray());

            LabHoliday1.Text = dt.Rows[index]["事假"].ToString() + " 天";
            LabHoliday2.Text = dt.Rows[index]["喪假"].ToString() + " 天";
            LabHoliday3.Text = dt.Rows[index]["普通傷病假"].ToString() + " 天";
            LabHoliday4.Text = dt.Rows[index]["公假"].ToString() + " 天";
            LabHoliday5.Text = dt.Rows[index]["特休假"].ToString() + " 天";
            LabHoliday6.Text = dt.Rows[index]["公傷病假"].ToString() + " 天";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
>>>>>>> Stashed changes
