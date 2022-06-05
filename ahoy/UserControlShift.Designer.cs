namespace ahoy
{
    partial class UserControlShift
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shiftTab = new System.Windows.Forms.TabControl();
            this.shiftTabpage = new System.Windows.Forms.TabPage();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dtpShiftDatetime = new System.Windows.Forms.DateTimePicker();
            this.labelShiftDatetime = new System.Windows.Forms.Label();
            this.labelShiftStore = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.shiftRuletabPage = new System.Windows.Forms.TabPage();
            this.cbShiftTypeEndTime = new System.Windows.Forms.ComboBox();
            this.cbShiftTypeStartTime = new System.Windows.Forms.ComboBox();
            this.labelShiftStartTime = new System.Windows.Forms.Label();
            this.labelShiftEndTime = new System.Windows.Forms.Label();
            this.labelShiftRuleType = new System.Windows.Forms.Label();
            this.cbShiftRuleType = new System.Windows.Forms.ComboBox();
            this.uiBtnReset = new Sunny.UI.UIButton();
            this.uiBtnSave = new Sunny.UI.UIButton();
            this.shiftTab.SuspendLayout();
            this.shiftTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.shiftRuletabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // shiftTab
            // 
            this.shiftTab.Controls.Add(this.shiftTabpage);
            this.shiftTab.Controls.Add(this.shiftRuletabPage);
            this.shiftTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.shiftTab.Location = new System.Drawing.Point(0, 0);
            this.shiftTab.Name = "shiftTab";
            this.shiftTab.SelectedIndex = 0;
            this.shiftTab.Size = new System.Drawing.Size(1064, 535);
            this.shiftTab.TabIndex = 0;
            // 
            // shiftTabpage
            // 
            this.shiftTabpage.Controls.Add(this.dgv1);
            this.shiftTabpage.Controls.Add(this.dtpShiftDatetime);
            this.shiftTabpage.Controls.Add(this.labelShiftDatetime);
            this.shiftTabpage.Controls.Add(this.labelShiftStore);
            this.shiftTabpage.Controls.Add(this.cbStore);
            this.shiftTabpage.Location = new System.Drawing.Point(4, 30);
            this.shiftTabpage.Name = "shiftTabpage";
            this.shiftTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.shiftTabpage.Size = new System.Drawing.Size(1056, 501);
            this.shiftTabpage.TabIndex = 0;
            this.shiftTabpage.Text = "排班";
            this.shiftTabpage.UseVisualStyleBackColor = true;
            this.shiftTabpage.Click += new System.EventHandler(this.shiftTabpage_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.GridColor = System.Drawing.Color.White;
            this.dgv1.Location = new System.Drawing.Point(70, 119);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(914, 333);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // dtpShiftDatetime
            // 
            this.dtpShiftDatetime.Location = new System.Drawing.Point(472, 57);
            this.dtpShiftDatetime.MaxDate = new System.DateTime(2022, 5, 31, 0, 0, 0, 0);
            this.dtpShiftDatetime.Name = "dtpShiftDatetime";
            this.dtpShiftDatetime.Size = new System.Drawing.Size(200, 29);
            this.dtpShiftDatetime.TabIndex = 8;
            this.dtpShiftDatetime.Value = new System.DateTime(2022, 5, 31, 0, 0, 0, 0);
            this.dtpShiftDatetime.ValueChanged += new System.EventHandler(this.dtpShiftDatetime_ValueChanged);
            // 
            // labelShiftDatetime
            // 
            this.labelShiftDatetime.AutoSize = true;
            this.labelShiftDatetime.Location = new System.Drawing.Point(391, 60);
            this.labelShiftDatetime.Name = "labelShiftDatetime";
            this.labelShiftDatetime.Size = new System.Drawing.Size(42, 21);
            this.labelShiftDatetime.TabIndex = 7;
            this.labelShiftDatetime.Text = "日期";
            // 
            // labelShiftStore
            // 
            this.labelShiftStore.AutoSize = true;
            this.labelShiftStore.Location = new System.Drawing.Point(40, 60);
            this.labelShiftStore.Name = "labelShiftStore";
            this.labelShiftStore.Size = new System.Drawing.Size(42, 21);
            this.labelShiftStore.TabIndex = 2;
            this.labelShiftStore.Text = "店家";
            // 
            // cbStore
            // 
            this.cbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(121, 57);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(200, 29);
            this.cbStore.TabIndex = 0;
            // 
            // shiftRuletabPage
            // 
            this.shiftRuletabPage.Controls.Add(this.cbShiftTypeEndTime);
            this.shiftRuletabPage.Controls.Add(this.cbShiftTypeStartTime);
            this.shiftRuletabPage.Controls.Add(this.labelShiftStartTime);
            this.shiftRuletabPage.Controls.Add(this.labelShiftEndTime);
            this.shiftRuletabPage.Controls.Add(this.labelShiftRuleType);
            this.shiftRuletabPage.Controls.Add(this.cbShiftRuleType);
            this.shiftRuletabPage.Location = new System.Drawing.Point(4, 30);
            this.shiftRuletabPage.Name = "shiftRuletabPage";
            this.shiftRuletabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shiftRuletabPage.Size = new System.Drawing.Size(1056, 501);
            this.shiftRuletabPage.TabIndex = 1;
            this.shiftRuletabPage.Text = "排班規則";
            this.shiftRuletabPage.UseVisualStyleBackColor = true;
            // 
            // cbShiftTypeEndTime
            // 
            this.cbShiftTypeEndTime.FormattingEnabled = true;
            this.cbShiftTypeEndTime.Location = new System.Drawing.Point(210, 358);
            this.cbShiftTypeEndTime.Name = "cbShiftTypeEndTime";
            this.cbShiftTypeEndTime.Size = new System.Drawing.Size(250, 29);
            this.cbShiftTypeEndTime.TabIndex = 15;
            // 
            // cbShiftTypeStartTime
            // 
            this.cbShiftTypeStartTime.FormattingEnabled = true;
            this.cbShiftTypeStartTime.Location = new System.Drawing.Point(210, 206);
            this.cbShiftTypeStartTime.Name = "cbShiftTypeStartTime";
            this.cbShiftTypeStartTime.Size = new System.Drawing.Size(250, 29);
            this.cbShiftTypeStartTime.TabIndex = 14;
            // 
            // labelShiftStartTime
            // 
            this.labelShiftStartTime.AutoSize = true;
            this.labelShiftStartTime.Location = new System.Drawing.Point(84, 209);
            this.labelShiftStartTime.Name = "labelShiftStartTime";
            this.labelShiftStartTime.Size = new System.Drawing.Size(74, 21);
            this.labelShiftStartTime.TabIndex = 13;
            this.labelShiftStartTime.Text = "上班時間";
            // 
            // labelShiftEndTime
            // 
            this.labelShiftEndTime.AutoSize = true;
            this.labelShiftEndTime.Location = new System.Drawing.Point(84, 361);
            this.labelShiftEndTime.Name = "labelShiftEndTime";
            this.labelShiftEndTime.Size = new System.Drawing.Size(74, 21);
            this.labelShiftEndTime.TabIndex = 11;
            this.labelShiftEndTime.Text = "下班時間";
            // 
            // labelShiftRuleType
            // 
            this.labelShiftRuleType.AutoSize = true;
            this.labelShiftRuleType.Location = new System.Drawing.Point(40, 60);
            this.labelShiftRuleType.Name = "labelShiftRuleType";
            this.labelShiftRuleType.Size = new System.Drawing.Size(42, 21);
            this.labelShiftRuleType.TabIndex = 10;
            this.labelShiftRuleType.Text = "班別";
            // 
            // cbShiftRuleType
            // 
            this.cbShiftRuleType.FormattingEnabled = true;
            this.cbShiftRuleType.Location = new System.Drawing.Point(131, 57);
            this.cbShiftRuleType.Name = "cbShiftRuleType";
            this.cbShiftRuleType.Size = new System.Drawing.Size(250, 29);
            this.cbShiftRuleType.TabIndex = 8;
            // 
            // uiBtnReset
            // 
            this.uiBtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.uiBtnReset.Location = new System.Drawing.Point(931, 561);
            this.uiBtnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnReset.Name = "uiBtnReset";
            this.uiBtnReset.Radius = 12;
            this.uiBtnReset.Size = new System.Drawing.Size(120, 39);
            this.uiBtnReset.TabIndex = 11;
            this.uiBtnReset.Text = "重置";
            this.uiBtnReset.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiBtnReset.Click += new System.EventHandler(this.uiBtnReset_Click);
            // 
            // uiBtnSave
            // 
            this.uiBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiBtnSave.Location = new System.Drawing.Point(790, 561);
            this.uiBtnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnSave.Name = "uiBtnSave";
            this.uiBtnSave.Radius = 12;
            this.uiBtnSave.Size = new System.Drawing.Size(120, 39);
            this.uiBtnSave.TabIndex = 10;
            this.uiBtnSave.Text = "儲存";
            this.uiBtnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiBtnSave.Click += new System.EventHandler(this.uiBtnSave_Click);
            // 
            // UserControlShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiBtnReset);
            this.Controls.Add(this.uiBtnSave);
            this.Controls.Add(this.shiftTab);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlShift";
            this.Size = new System.Drawing.Size(1064, 620);
            this.shiftTab.ResumeLayout(false);
            this.shiftTabpage.ResumeLayout(false);
            this.shiftTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.shiftRuletabPage.ResumeLayout(false);
            this.shiftRuletabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl shiftTab;
        private System.Windows.Forms.TabPage shiftTabpage;
        private System.Windows.Forms.TabPage shiftRuletabPage;
        private System.Windows.Forms.Label labelShiftDatetime;
        private System.Windows.Forms.Label labelShiftStore;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.Label labelShiftStartTime;
        private System.Windows.Forms.Label labelShiftEndTime;
        private System.Windows.Forms.Label labelShiftRuleType;
        private System.Windows.Forms.ComboBox cbShiftRuleType;
        private System.Windows.Forms.ComboBox cbShiftTypeEndTime;
        private System.Windows.Forms.ComboBox cbShiftTypeStartTime;
        private Sunny.UI.UIButton uiBtnReset;
        private Sunny.UI.UIButton uiBtnSave;
        private System.Windows.Forms.DateTimePicker dtpShiftDatetime;
        private System.Windows.Forms.DataGridView dgv1;
    }
}
