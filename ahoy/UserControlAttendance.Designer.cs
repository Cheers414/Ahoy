namespace ahoy
{
    partial class UserControlAttendance
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlAttendance = new System.Windows.Forms.TabControl();
            this.tabPageSignIn = new System.Windows.Forms.TabPage();
            this.labelShiftStore = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coSignIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coSignOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coOvertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabNowTime = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlAttendance.SuspendLayout();
            this.tabPageSignIn.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAttendance
            // 
            this.tabControlAttendance.Controls.Add(this.tabPageSignIn);
            this.tabControlAttendance.Controls.Add(this.tabPageSearch);
            this.tabControlAttendance.Location = new System.Drawing.Point(3, 3);
            this.tabControlAttendance.Name = "tabControlAttendance";
            this.tabControlAttendance.SelectedIndex = 0;
            this.tabControlAttendance.Size = new System.Drawing.Size(1058, 614);
            this.tabControlAttendance.TabIndex = 13;
            // 
            // tabPageSignIn
            // 
            this.tabPageSignIn.Controls.Add(this.labelShiftStore);
            this.tabPageSignIn.Controls.Add(this.cbStore);
            this.tabPageSignIn.Controls.Add(this.listView1);
            this.tabPageSignIn.Controls.Add(this.LabNowTime);
            this.tabPageSignIn.Controls.Add(this.btnSignOut);
            this.tabPageSignIn.Controls.Add(this.btnSignIn);
            this.tabPageSignIn.Location = new System.Drawing.Point(4, 30);
            this.tabPageSignIn.Name = "tabPageSignIn";
            this.tabPageSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignIn.Size = new System.Drawing.Size(1050, 580);
            this.tabPageSignIn.TabIndex = 2;
            this.tabPageSignIn.Text = "簽到";
            this.tabPageSignIn.UseVisualStyleBackColor = true;
            // 
            // labelShiftStore
            // 
            this.labelShiftStore.AutoSize = true;
            this.labelShiftStore.Location = new System.Drawing.Point(157, 38);
            this.labelShiftStore.Name = "labelShiftStore";
            this.labelShiftStore.Size = new System.Drawing.Size(42, 21);
            this.labelShiftStore.TabIndex = 26;
            this.labelShiftStore.Text = "店家";
            // 
            // cbStore
            // 
            this.cbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(434, 35);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(200, 29);
            this.cbStore.TabIndex = 25;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.coSignIn,
            this.coSignOut,
            this.coOvertime,
            this.columnHeader7});
            this.listView1.Enabled = false;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(147, 222);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 279);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "店家";
            // 
            // coSignIn
            // 
            this.coSignIn.Text = "打卡上班";
            this.coSignIn.Width = 171;
            // 
            // coSignOut
            // 
            this.coSignOut.Text = "打卡下班";
            this.coSignOut.Width = 170;
            // 
            // coOvertime
            // 
            this.coOvertime.Text = "加班時間";
            this.coOvertime.Width = 243;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "帳號";
            // 
            // LabNowTime
            // 
            this.LabNowTime.AutoSize = true;
            this.LabNowTime.Location = new System.Drawing.Point(157, 79);
            this.LabNowTime.Name = "LabNowTime";
            this.LabNowTime.Size = new System.Drawing.Size(82, 21);
            this.LabNowTime.TabIndex = 23;
            this.LabNowTime.Text = "現在時間 :";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Enabled = false;
            this.btnSignOut.Location = new System.Drawing.Point(434, 121);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(149, 41);
            this.btnSignOut.TabIndex = 22;
            this.btnSignOut.Text = "下班簽退";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(238, 121);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(149, 41);
            this.btnSignIn.TabIndex = 21;
            this.btnSignIn.Text = "上班簽到";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.listView2);
            this.tabPageSearch.Controls.Add(this.txtboxName);
            this.tabPageSearch.Controls.Add(this.btnName);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 30);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1050, 580);
            this.tabPageSearch.TabIndex = 3;
            this.tabPageSearch.Text = "請假記錄查詢";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.ch});
            this.listView2.Enabled = false;
            this.listView2.HideSelection = false;
            this.listView2.HoverSelection = true;
            this.listView2.Location = new System.Drawing.Point(28, 199);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1006, 347);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "假別";
            this.columnHeader2.Width = 171;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "請假開始時間";
            this.columnHeader3.Width = 182;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "請假結束時間";
            this.columnHeader4.Width = 243;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "審核狀況";
            this.columnHeader5.Width = 150;
            // 
            // ch
            // 
            this.ch.Text = "審核日期";
            this.ch.Width = 100;
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxName.Location = new System.Drawing.Point(401, 128);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(131, 32);
            this.txtboxName.TabIndex = 2;
            // 
            // btnName
            // 
            this.btnName.AutoSize = true;
            this.btnName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnName.Location = new System.Drawing.Point(261, 131);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(91, 24);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "員工姓名:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(593, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 37);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAttendance);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(1064, 620);
            this.Load += new System.EventHandler(this.UserControlAttendance_Load);
            this.tabControlAttendance.ResumeLayout(false);
            this.tabPageSignIn.ResumeLayout(false);
            this.tabPageSignIn.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAttendance;
        private System.Windows.Forms.TabPage tabPageSignIn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader coSignIn;
        private System.Windows.Forms.ColumnHeader coSignOut;
        private System.Windows.Forms.ColumnHeader coOvertime;
        private System.Windows.Forms.Label LabNowTime;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader ch;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label btnName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelShiftStore;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Timer timer1;
    }
}
