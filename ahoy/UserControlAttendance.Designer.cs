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
            this.tabControlAttendance = new System.Windows.Forms.TabControl();
            this.tabPageSign = new System.Windows.Forms.TabPage();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.coDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coSignIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coSignOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coOvertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabNowTime = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlAttendance.SuspendLayout();
            this.tabPageSign.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAttendance
            // 
            this.tabControlAttendance.Controls.Add(this.tabPageSign);
            this.tabControlAttendance.Controls.Add(this.tabPageSearch);
            this.tabControlAttendance.Location = new System.Drawing.Point(3, 3);
            this.tabControlAttendance.Name = "tabControlAttendance";
            this.tabControlAttendance.SelectedIndex = 0;
            this.tabControlAttendance.Size = new System.Drawing.Size(1058, 614);
            this.tabControlAttendance.TabIndex = 13;
            // 
            // tabPageSign
            // 
            this.tabPageSign.BackColor = System.Drawing.Color.White;
            this.tabPageSign.Controls.Add(this.listView1);
            this.tabPageSign.Controls.Add(this.LabNowTime);
            this.tabPageSign.Controls.Add(this.btnSignOut);
            this.tabPageSign.Controls.Add(this.btnSignIn);
            this.tabPageSign.Location = new System.Drawing.Point(4, 34);
            this.tabPageSign.Name = "tabPageSign";
            this.tabPageSign.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSign.Size = new System.Drawing.Size(1050, 576);
            this.tabPageSign.TabIndex = 0;
            this.tabPageSign.Text = "打卡系統";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.listView2);
            this.tabPageSearch.Controls.Add(this.txtboxName);
            this.tabPageSearch.Controls.Add(this.btnName);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 34);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1050, 576);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "請假記錄查詢";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coDate,
            this.coSignIn,
            this.coSignOut,
            this.coOvertime});
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(147, 220);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 279);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // coDate
            // 
            this.coDate.Text = "日期";
            this.coDate.Width = 165;
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
            // LabNowTime
            // 
            this.LabNowTime.AutoSize = true;
            this.LabNowTime.Location = new System.Drawing.Point(157, 78);
            this.LabNowTime.Name = "LabNowTime";
            this.LabNowTime.Size = new System.Drawing.Size(139, 25);
            this.LabNowTime.TabIndex = 15;
            this.LabNowTime.Text = "LabNowTime";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(314, 119);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(149, 41);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "下班簽退";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(147, 119);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(149, 41);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "上班簽到";
            this.btnSignIn.UseVisualStyleBackColor = true;
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
            // btnName
            // 
            this.btnName.AutoSize = true;
            this.btnName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnName.Location = new System.Drawing.Point(261, 131);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(111, 29);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "員工姓名:";
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxName.Location = new System.Drawing.Point(401, 128);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(131, 38);
            this.txtboxName.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.HideSelection = false;
            this.listView2.HoverSelection = true;
            this.listView2.Location = new System.Drawing.Point(136, 215);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(834, 279);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日期";
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
            this.columnHeader5.Text = "審核";
            this.columnHeader5.Width = 99;
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAttendance);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(1064, 620);
            this.Load += new System.EventHandler(this.UserControlAttendance_Load);
            this.tabControlAttendance.ResumeLayout(false);
            this.tabPageSign.ResumeLayout(false);
            this.tabPageSign.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAttendance;
        private System.Windows.Forms.TabPage tabPageSign;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader coDate;
        private System.Windows.Forms.ColumnHeader coSignIn;
        private System.Windows.Forms.ColumnHeader coSignOut;
        private System.Windows.Forms.ColumnHeader coOvertime;
        private System.Windows.Forms.Label LabNowTime;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label btnName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
