namespace ahoy
{
    partial class UserControlApproval
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
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LabHolidayBox = new Sunny.UI.UIGroupBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.LabHolidayText6 = new Sunny.UI.UILabel();
            this.LabHolidayText5 = new Sunny.UI.UILabel();
            this.LabHolidayText4 = new Sunny.UI.UILabel();
            this.LabHolidayText3 = new Sunny.UI.UILabel();
            this.LabHolidayText2 = new Sunny.UI.UILabel();
            this.LabHolidayText1 = new Sunny.UI.UILabel();
            this.LabHolidayValue6 = new Sunny.UI.UIAvatar();
            this.LabHolidayValue5 = new Sunny.UI.UIAvatar();
            this.LabHolidayValue4 = new Sunny.UI.UIAvatar();
            this.LabHolidayValue3 = new Sunny.UI.UIAvatar();
            this.LabHolidayValue2 = new Sunny.UI.UIAvatar();
            this.LabHolidayValue1 = new Sunny.UI.UIAvatar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ahoyCorpDataSet = new ahoy.ahoyCorpDataSet();
            this.vacationRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationRecordTableAdapter = new ahoy.ahoyCorpDataSetTableAdapters.VacationRecordTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.LabHolidayBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ahoyCorpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1064, 620);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.LabHolidayBox);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1064, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "請假資訊";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // LabHolidayBox
            // 
            this.LabHolidayBox.Controls.Add(this.uiLabel6);
            this.LabHolidayBox.Controls.Add(this.uiLabel5);
            this.LabHolidayBox.Controls.Add(this.uiLabel4);
            this.LabHolidayBox.Controls.Add(this.uiLabel3);
            this.LabHolidayBox.Controls.Add(this.uiLabel2);
            this.LabHolidayBox.Controls.Add(this.uiLabel1);
            this.LabHolidayBox.Controls.Add(this.LabHolidayText6);
            this.LabHolidayBox.Controls.Add(this.LabHolidayText5);
            this.LabHolidayBox.Controls.Add(this.LabHolidayText4);
            this.LabHolidayBox.Controls.Add(this.LabHolidayText3);
            this.LabHolidayBox.Controls.Add(this.LabHolidayText2);
            this.LabHolidayBox.Controls.Add(this.LabHolidayText1);
            this.LabHolidayBox.Controls.Add(this.LabHolidayValue6);
            this.LabHolidayBox.Controls.Add(this.LabHolidayValue5);
            this.LabHolidayBox.Controls.Add(this.LabHolidayValue4);
            this.LabHolidayBox.Controls.Add(this.LabHolidayValue3);
            this.LabHolidayBox.Controls.Add(this.LabHolidayValue2);
            this.LabHolidayBox.Controls.Add(this.LabHolidayValue1);
            this.LabHolidayBox.FillColor = System.Drawing.Color.White;
            this.LabHolidayBox.FillColor2 = System.Drawing.Color.White;
            this.LabHolidayBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LabHolidayBox.ForeDisableColor = System.Drawing.Color.White;
            this.LabHolidayBox.Location = new System.Drawing.Point(30, 16);
            this.LabHolidayBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabHolidayBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabHolidayBox.Name = "LabHolidayBox";
            this.LabHolidayBox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.LabHolidayBox.Size = new System.Drawing.Size(998, 237);
            this.LabHolidayBox.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayBox.TabIndex = 3;
            this.LabHolidayBox.Text = "休 假 餘 額 一 覽";
            this.LabHolidayBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabHolidayBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(851, 180);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(68, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 32;
            this.uiLabel6.Text = "特休假";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(699, 180);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(55, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 31;
            this.uiLabel5.Text = "喪  假";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(537, 180);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(80, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 20;
            this.uiLabel4.Text = "公傷病假";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(399, 180);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(54, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 30;
            this.uiLabel3.Text = "病  假";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(245, 180);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(55, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "公  假";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(94, 180);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(55, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "事  假";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayText6
            // 
            this.LabHolidayText6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayText6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabHolidayText6.ForeColor = System.Drawing.Color.White;
            this.LabHolidayText6.Location = new System.Drawing.Point(838, 125);
            this.LabHolidayText6.Name = "LabHolidayText6";
            this.LabHolidayText6.Size = new System.Drawing.Size(81, 23);
            this.LabHolidayText6.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayText6.TabIndex = 28;
            this.LabHolidayText6.Text = "已用 / 可用";
            this.LabHolidayText6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabHolidayText6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayText5
            // 
            this.LabHolidayText5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayText5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabHolidayText5.ForeColor = System.Drawing.Color.White;
            this.LabHolidayText5.Location = new System.Drawing.Point(687, 125);
            this.LabHolidayText5.Name = "LabHolidayText5";
            this.LabHolidayText5.Size = new System.Drawing.Size(81, 23);
            this.LabHolidayText5.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayText5.TabIndex = 27;
            this.LabHolidayText5.Text = "已用 / 可用";
            this.LabHolidayText5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabHolidayText5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayText4
            // 
            this.LabHolidayText4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayText4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabHolidayText4.ForeColor = System.Drawing.Color.White;
            this.LabHolidayText4.Location = new System.Drawing.Point(536, 125);
            this.LabHolidayText4.Name = "LabHolidayText4";
            this.LabHolidayText4.Size = new System.Drawing.Size(81, 23);
            this.LabHolidayText4.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayText4.TabIndex = 26;
            this.LabHolidayText4.Text = "已用 / 可用";
            this.LabHolidayText4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabHolidayText4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayText3
            // 
            this.LabHolidayText3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayText3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabHolidayText3.ForeColor = System.Drawing.Color.White;
            this.LabHolidayText3.Location = new System.Drawing.Point(385, 125);
            this.LabHolidayText3.Name = "LabHolidayText3";
            this.LabHolidayText3.Size = new System.Drawing.Size(81, 23);
            this.LabHolidayText3.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayText3.TabIndex = 25;
            this.LabHolidayText3.Text = "已用 / 可用";
            this.LabHolidayText3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabHolidayText3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayText2
            // 
            this.LabHolidayText2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayText2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabHolidayText2.ForeColor = System.Drawing.Color.White;
            this.LabHolidayText2.Location = new System.Drawing.Point(235, 125);
            this.LabHolidayText2.Name = "LabHolidayText2";
            this.LabHolidayText2.Size = new System.Drawing.Size(81, 23);
            this.LabHolidayText2.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayText2.TabIndex = 24;
            this.LabHolidayText2.Text = "已用 / 可用";
            this.LabHolidayText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabHolidayText2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayText1
            // 
            this.LabHolidayText1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayText1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabHolidayText1.ForeColor = System.Drawing.Color.White;
            this.LabHolidayText1.Location = new System.Drawing.Point(85, 125);
            this.LabHolidayText1.Name = "LabHolidayText1";
            this.LabHolidayText1.Size = new System.Drawing.Size(81, 23);
            this.LabHolidayText1.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayText1.TabIndex = 19;
            this.LabHolidayText1.Text = "已用 / 可用";
            this.LabHolidayText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabHolidayText1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayValue6
            // 
            this.LabHolidayValue6.AvatarSize = 125;
            this.LabHolidayValue6.FillColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayValue6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LabHolidayValue6.ForeColor = System.Drawing.Color.White;
            this.LabHolidayValue6.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.LabHolidayValue6.Location = new System.Drawing.Point(789, 33);
            this.LabHolidayValue6.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabHolidayValue6.Name = "LabHolidayValue6";
            this.LabHolidayValue6.Size = new System.Drawing.Size(173, 144);
            this.LabHolidayValue6.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayValue6.TabIndex = 23;
            this.LabHolidayValue6.Text = "  - 天/ - 天";
            this.LabHolidayValue6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayValue5
            // 
            this.LabHolidayValue5.AvatarSize = 125;
            this.LabHolidayValue5.FillColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayValue5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LabHolidayValue5.ForeColor = System.Drawing.Color.White;
            this.LabHolidayValue5.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.LabHolidayValue5.Location = new System.Drawing.Point(638, 33);
            this.LabHolidayValue5.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabHolidayValue5.Name = "LabHolidayValue5";
            this.LabHolidayValue5.Size = new System.Drawing.Size(173, 144);
            this.LabHolidayValue5.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayValue5.TabIndex = 22;
            this.LabHolidayValue5.Text = "  - 天/ - 天";
            this.LabHolidayValue5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayValue4
            // 
            this.LabHolidayValue4.AvatarSize = 125;
            this.LabHolidayValue4.FillColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayValue4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LabHolidayValue4.ForeColor = System.Drawing.Color.White;
            this.LabHolidayValue4.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.LabHolidayValue4.Location = new System.Drawing.Point(489, 33);
            this.LabHolidayValue4.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabHolidayValue4.Name = "LabHolidayValue4";
            this.LabHolidayValue4.Size = new System.Drawing.Size(173, 144);
            this.LabHolidayValue4.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayValue4.TabIndex = 21;
            this.LabHolidayValue4.Text = "  - 天/ - 天";
            this.LabHolidayValue4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayValue3
            // 
            this.LabHolidayValue3.AvatarSize = 125;
            this.LabHolidayValue3.FillColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayValue3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LabHolidayValue3.ForeColor = System.Drawing.Color.White;
            this.LabHolidayValue3.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.LabHolidayValue3.Location = new System.Drawing.Point(338, 33);
            this.LabHolidayValue3.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabHolidayValue3.Name = "LabHolidayValue3";
            this.LabHolidayValue3.Size = new System.Drawing.Size(173, 144);
            this.LabHolidayValue3.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayValue3.TabIndex = 17;
            this.LabHolidayValue3.Text = "  - 天/ - 天";
            this.LabHolidayValue3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayValue2
            // 
            this.LabHolidayValue2.AvatarSize = 125;
            this.LabHolidayValue2.FillColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayValue2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LabHolidayValue2.ForeColor = System.Drawing.Color.White;
            this.LabHolidayValue2.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.LabHolidayValue2.Location = new System.Drawing.Point(187, 33);
            this.LabHolidayValue2.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabHolidayValue2.Name = "LabHolidayValue2";
            this.LabHolidayValue2.Size = new System.Drawing.Size(173, 144);
            this.LabHolidayValue2.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayValue2.TabIndex = 16;
            this.LabHolidayValue2.Text = "  - 天/ - 天";
            this.LabHolidayValue2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LabHolidayValue1
            // 
            this.LabHolidayValue1.AvatarSize = 125;
            this.LabHolidayValue1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.LabHolidayValue1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LabHolidayValue1.ForeColor = System.Drawing.Color.White;
            this.LabHolidayValue1.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.LabHolidayValue1.Location = new System.Drawing.Point(37, 33);
            this.LabHolidayValue1.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabHolidayValue1.Name = "LabHolidayValue1";
            this.LabHolidayValue1.Size = new System.Drawing.Size(173, 144);
            this.LabHolidayValue1.Style = Sunny.UI.UIStyle.Custom;
            this.LabHolidayValue1.TabIndex = 15;
            this.LabHolidayValue1.Text = "  - 天/ - 天";
            this.LabHolidayValue1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabHolidayValue1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1064, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ahoyCorpDataSet
            // 
            this.ahoyCorpDataSet.DataSetName = "ahoyCorpDataSet";
            this.ahoyCorpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationRecordBindingSource
            // 
            this.vacationRecordBindingSource.DataMember = "VacationRecord";
            this.vacationRecordBindingSource.DataSource = this.ahoyCorpDataSet;
            // 
            // vacationRecordTableAdapter
            // 
            this.vacationRecordTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 283);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(845, 221);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "請假編號";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "請假類型";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "事由";
            this.columnHeader3.Width = 198;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "時間(起)";
            this.columnHeader4.Width = 214;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "時間(迄)";
            this.columnHeader5.Width = 192;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "狀態";
            this.columnHeader6.Width = 104;
            // 
            // UserControlApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiTabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlApproval";
            this.Size = new System.Drawing.Size(1064, 620);
            this.Load += new System.EventHandler(this.UserControlApproval_Load);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.LabHolidayBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ahoyCorpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIGroupBox LabHolidayBox;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel LabHolidayText6;
        private Sunny.UI.UILabel LabHolidayText5;
        private Sunny.UI.UILabel LabHolidayText4;
        private Sunny.UI.UILabel LabHolidayText3;
        private Sunny.UI.UILabel LabHolidayText2;
        private Sunny.UI.UILabel LabHolidayText1;
        private Sunny.UI.UIAvatar LabHolidayValue6;
        private Sunny.UI.UIAvatar LabHolidayValue5;
        private Sunny.UI.UIAvatar LabHolidayValue4;
        private Sunny.UI.UIAvatar LabHolidayValue3;
        private Sunny.UI.UIAvatar LabHolidayValue2;
        private Sunny.UI.UIAvatar LabHolidayValue1;
        private System.Windows.Forms.BindingSource vacationRecordBindingSource;
        private ahoyCorpDataSet ahoyCorpDataSet;
        private ahoyCorpDataSetTableAdapters.VacationRecordTableAdapter vacationRecordTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
