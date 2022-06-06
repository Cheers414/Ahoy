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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiBtnReset = new Sunny.UI.UIButton();
            this.uiBtnSave = new Sunny.UI.UIButton();
            this.uiTabControlShift = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.dtpShiftDatetime = new System.Windows.Forms.DateTimePicker();
            this.labelShiftDatetime = new System.Windows.Forms.Label();
            this.labelShiftStore = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbShiftTypeEndTime = new System.Windows.Forms.ComboBox();
            this.cbShiftTypeStartTime = new System.Windows.Forms.ComboBox();
            this.labelShiftStartTime = new System.Windows.Forms.Label();
            this.labelShiftEndTime = new System.Windows.Forms.Label();
            this.labelShiftRuleType = new System.Windows.Forms.Label();
            this.cbShiftRuleType = new System.Windows.Forms.ComboBox();
            this.txtReason = new Sunny.UI.UIRichTextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiTabControlShift.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiBtnReset
            // 
            this.uiBtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.uiBtnReset.Location = new System.Drawing.Point(929, 521);
            this.uiBtnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnReset.Name = "uiBtnReset";
            this.uiBtnReset.Radius = 12;
            this.uiBtnReset.Size = new System.Drawing.Size(120, 39);
            this.uiBtnReset.TabIndex = 11;
            this.uiBtnReset.Text = "重置";
            this.uiBtnReset.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiBtnSave
            // 
            this.uiBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiBtnSave.Location = new System.Drawing.Point(793, 521);
            this.uiBtnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnSave.Name = "uiBtnSave";
            this.uiBtnSave.Radius = 12;
            this.uiBtnSave.Size = new System.Drawing.Size(120, 39);
            this.uiBtnSave.TabIndex = 10;
            this.uiBtnSave.Text = "儲存";
            this.uiBtnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTabControlShift
            // 
            this.uiTabControlShift.Controls.Add(this.tabPage1);
            this.uiTabControlShift.Controls.Add(this.tabPage2);
            this.uiTabControlShift.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlShift.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiTabControlShift.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControlShift.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlShift.MainPage = "";
            this.uiTabControlShift.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlShift.Name = "uiTabControlShift";
            this.uiTabControlShift.SelectedIndex = 0;
            this.uiTabControlShift.Size = new System.Drawing.Size(1064, 617);
            this.uiTabControlShift.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlShift.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControlShift.TabBackColor = System.Drawing.Color.White;
            this.uiTabControlShift.TabIndex = 12;
            this.uiTabControlShift.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControlShift.TabSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControlShift.TabUnSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControlShift.TipsFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiTabControlShift.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiButton1);
            this.tabPage1.Controls.Add(this.uiButton2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvShift);
            this.tabPage1.Controls.Add(this.dtpShiftDatetime);
            this.tabPage1.Controls.Add(this.labelShiftDatetime);
            this.tabPage1.Controls.Add(this.labelShiftStore);
            this.tabPage1.Controls.Add(this.cbStore);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1064, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "排班";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(86, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "點兩下列表即可修改";
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.AllowUserToResizeColumns = false;
            this.dgvShift.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShift.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvShift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.GridColor = System.Drawing.Color.White;
            this.dgvShift.Location = new System.Drawing.Point(90, 107);
            this.dgvShift.MultiSelect = false;
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.ReadOnly = true;
            this.dgvShift.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvShift.RowHeadersVisible = false;
            this.dgvShift.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvShift.RowTemplate.Height = 24;
            this.dgvShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShift.Size = new System.Drawing.Size(914, 333);
            this.dgvShift.TabIndex = 19;
            this.dgvShift.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShift_CellDoubleClick);
            this.dgvShift.DoubleClick += new System.EventHandler(this.uiBtnSave_Click);
            this.dgvShift.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvShift_MouseDoubleClick);
            // 
            // dtpShiftDatetime
            // 
            this.dtpShiftDatetime.Location = new System.Drawing.Point(498, 45);
            this.dtpShiftDatetime.Name = "dtpShiftDatetime";
            this.dtpShiftDatetime.Size = new System.Drawing.Size(200, 29);
            this.dtpShiftDatetime.TabIndex = 18;
            this.dtpShiftDatetime.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpShiftDatetime.ValueChanged += new System.EventHandler(this.dtpShiftDatetime_ValueChanged);
            // 
            // labelShiftDatetime
            // 
            this.labelShiftDatetime.AutoSize = true;
            this.labelShiftDatetime.Location = new System.Drawing.Point(405, 50);
            this.labelShiftDatetime.Name = "labelShiftDatetime";
            this.labelShiftDatetime.Size = new System.Drawing.Size(41, 20);
            this.labelShiftDatetime.TabIndex = 17;
            this.labelShiftDatetime.Text = "日期";
            // 
            // labelShiftStore
            // 
            this.labelShiftStore.AutoSize = true;
            this.labelShiftStore.Location = new System.Drawing.Point(60, 50);
            this.labelShiftStore.Name = "labelShiftStore";
            this.labelShiftStore.Size = new System.Drawing.Size(41, 20);
            this.labelShiftStore.TabIndex = 16;
            this.labelShiftStore.Text = "店家";
            // 
            // cbStore
            // 
            this.cbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(153, 45);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(200, 28);
            this.cbStore.TabIndex = 15;
            this.cbStore.SelectedIndexChanged += new System.EventHandler(this.dtpShiftDatetime_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbShiftTypeEndTime);
            this.tabPage2.Controls.Add(this.uiBtnReset);
            this.tabPage2.Controls.Add(this.cbShiftTypeStartTime);
            this.tabPage2.Controls.Add(this.uiBtnSave);
            this.tabPage2.Controls.Add(this.labelShiftStartTime);
            this.tabPage2.Controls.Add(this.labelShiftEndTime);
            this.tabPage2.Controls.Add(this.labelShiftRuleType);
            this.tabPage2.Controls.Add(this.cbShiftRuleType);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1064, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "排班規則";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbShiftTypeEndTime
            // 
            this.cbShiftTypeEndTime.FormattingEnabled = true;
            this.cbShiftTypeEndTime.Location = new System.Drawing.Point(230, 351);
            this.cbShiftTypeEndTime.Name = "cbShiftTypeEndTime";
            this.cbShiftTypeEndTime.Size = new System.Drawing.Size(250, 28);
            this.cbShiftTypeEndTime.TabIndex = 27;
            // 
            // cbShiftTypeStartTime
            // 
            this.cbShiftTypeStartTime.FormattingEnabled = true;
            this.cbShiftTypeStartTime.Location = new System.Drawing.Point(230, 199);
            this.cbShiftTypeStartTime.Name = "cbShiftTypeStartTime";
            this.cbShiftTypeStartTime.Size = new System.Drawing.Size(250, 28);
            this.cbShiftTypeStartTime.TabIndex = 26;
            // 
            // labelShiftStartTime
            // 
            this.labelShiftStartTime.AutoSize = true;
            this.labelShiftStartTime.Location = new System.Drawing.Point(104, 202);
            this.labelShiftStartTime.Name = "labelShiftStartTime";
            this.labelShiftStartTime.Size = new System.Drawing.Size(73, 20);
            this.labelShiftStartTime.TabIndex = 25;
            this.labelShiftStartTime.Text = "上班時間";
            // 
            // labelShiftEndTime
            // 
            this.labelShiftEndTime.AutoSize = true;
            this.labelShiftEndTime.Location = new System.Drawing.Point(104, 354);
            this.labelShiftEndTime.Name = "labelShiftEndTime";
            this.labelShiftEndTime.Size = new System.Drawing.Size(73, 20);
            this.labelShiftEndTime.TabIndex = 24;
            this.labelShiftEndTime.Text = "下班時間";
            // 
            // labelShiftRuleType
            // 
            this.labelShiftRuleType.AutoSize = true;
            this.labelShiftRuleType.Location = new System.Drawing.Point(60, 53);
            this.labelShiftRuleType.Name = "labelShiftRuleType";
            this.labelShiftRuleType.Size = new System.Drawing.Size(41, 20);
            this.labelShiftRuleType.TabIndex = 23;
            this.labelShiftRuleType.Text = "班別";
            // 
            // cbShiftRuleType
            // 
            this.cbShiftRuleType.FormattingEnabled = true;
            this.cbShiftRuleType.Location = new System.Drawing.Point(151, 50);
            this.cbShiftRuleType.Name = "cbShiftRuleType";
            this.cbShiftRuleType.Size = new System.Drawing.Size(250, 28);
            this.cbShiftRuleType.TabIndex = 22;
            this.cbShiftRuleType.SelectedIndexChanged += new System.EventHandler(this.cbShiftRuleType_SelectedIndexChanged);
            // 
            // txtReason
            // 
            this.txtReason.FillColor = System.Drawing.Color.White;
            this.txtReason.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtReason.Location = new System.Drawing.Point(173, 308);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReason.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new System.Windows.Forms.Padding(2);
            this.txtReason.RectColor = System.Drawing.Color.Gray;
            this.txtReason.ScrollBarColor = System.Drawing.Color.Gray;
            this.txtReason.ShowText = false;
            this.txtReason.Size = new System.Drawing.Size(711, 160);
            this.txtReason.Style = Sunny.UI.UIStyle.Custom;
            this.txtReason.TabIndex = 15;
            this.txtReason.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtReason.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.uiButton1.Location = new System.Drawing.Point(925, 520);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 12;
            this.uiButton1.Size = new System.Drawing.Size(120, 39);
            this.uiButton1.TabIndex = 22;
            this.uiButton1.Text = "重置";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Location = new System.Drawing.Point(782, 520);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 12;
            this.uiButton2.Size = new System.Drawing.Size(120, 39);
            this.uiButton2.TabIndex = 21;
            this.uiButton2.Text = "儲存";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserControlShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiTabControlShift);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlShift";
            this.Size = new System.Drawing.Size(1064, 620);
            this.uiTabControlShift.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton uiBtnReset;
        private Sunny.UI.UIButton uiBtnSave;
        private Sunny.UI.UITabControl uiTabControlShift;
        private Sunny.UI.UIRichTextBox txtReason;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvShift;
        private System.Windows.Forms.DateTimePicker dtpShiftDatetime;
        private System.Windows.Forms.Label labelShiftDatetime;
        private System.Windows.Forms.Label labelShiftStore;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbShiftTypeEndTime;
        private System.Windows.Forms.ComboBox cbShiftTypeStartTime;
        private System.Windows.Forms.Label labelShiftStartTime;
        private System.Windows.Forms.Label labelShiftEndTime;
        private System.Windows.Forms.Label labelShiftRuleType;
        private System.Windows.Forms.ComboBox cbShiftRuleType;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
    }
}
