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
    public partial class UserControlAttendance : UserControl
    {
        public UserControlAttendance()
        {
            InitializeComponent();
        }
        ahoyCorpEntities ace = new ahoyCorpEntities();

        public new void BringToFront()//此處為元件初始化
        {
            cbStore.DataSource = ace.Store.ToList();
            cbStore.DisplayMember = "storeName";

            btnSignIn.Enabled = true;
            btnSignIn.Text = "上班簽到";
            btnSignOut.Enabled = false;
            btnSignOut.Text = "下班簽退";

            insert();

            listView2.Items.Clear();
            base.BringToFront();
        }
        void insert()
        {
            try
            {
                listView1.Items.Clear();
                var userData = ace.Attendance.ToList().Where(x => x.Employee.Account == globalVariable.user).ToList();
                userData.ToList().ForEach(x =>
                {
                    ListViewItem listViewItemSignin = new ListViewItem();
                    listViewItemSignin.SubItems.Add(globalVariable.user.account);
                    listViewItemSignin.SubItems.Add(x.Store.storeName);
                    listViewItemSignin.SubItems.Add(x.attendanceStartDateTime.ToString("yyyy/MM/dd HH:mm"));
                    if (x.attendanceEndDateTime.HasValue)
                    {
                        listViewItemSignin.SubItems.Add(x.attendanceEndDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                    }
                    else
                    {
                        listViewItemSignin.SubItems.Add("");
                    }
                    if (x.overTimeEndDateTime.HasValue && x.overTimeStartDateTime.HasValue)
                    {
                        listViewItemSignin.SubItems.Add((x.overTimeEndDateTime.Value - x.overTimeStartDateTime.Value).ToString("yyyy/MM/dd HH:mm"));
                    }
                    else
                    {
                        listViewItemSignin.SubItems.Add("");

                    }
                    listView1.Items.Add(listViewItemSignin);
                });

            }
            catch
            {
                MessageBox.Show("出現例外狀況!", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void UserControlAttendance_Load(object sender, EventArgs e)
        {
            LabNowTime.Text = "目前時間為:" + DateTime.Now;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                var vacationEmployee = ace.VacationRecord.ToList().Where(x => x.Employee.employeeName == txtboxName.Text).ToList();
                if (vacationEmployee == null)
                {
                    MessageBox.Show("查無此人!", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listView2.Items.Clear();
                vacationEmployee.ForEach(x =>
                {   
                    ListViewItem listViewItemVancationRecord = new ListViewItem();
                    listViewItemVancationRecord.SubItems.Add(x.VacationRecordID.ToString());
                    listViewItemVancationRecord.SubItems.Add(x.VacationType.vacationTypeName);
                    listViewItemVancationRecord.SubItems.Add(x.vacationStartDateTime.ToString("yyyy/MM/dd HH:mm"));
                    if (x.vacationEndDateTime.HasValue)
                    {
                        listViewItemVancationRecord.SubItems.Add(x.vacationEndDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                    }
                    else
                    {
                        listViewItemVancationRecord.SubItems.Add("");
                    }

                    listViewItemVancationRecord.SubItems.Add(x.ApplyStatus.status);

                    if (x.ApplyChangedDatetime.HasValue)
                    {
                        listViewItemVancationRecord.SubItems.Add(x.ApplyChangedDatetime.Value.ToString("yyyy/MM/dd HH:mm"));
                    }
                    else
                    {
                        listViewItemVancationRecord.SubItems.Add("");
                    }

                    listView2.Items.Add(listViewItemVancationRecord);
                });
            }
            catch
            {
                MessageBox.Show("出現例外狀況!", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            insert();
            if (btnSignIn.Text != "開始加班")
            {
                btnSignOut.Enabled = true;
                return;
            }
                btnSignOut.Text = "結束加班";
            btnSignOut.Enabled = true;
            btnSignIn.Enabled = false;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (btnSignOut.Text != "結束加班")
            {
                btnSignIn.Text = "開始加班";
                btnSignIn.Enabled = true;
                return;
            }

            btnSignIn.Enabled = true;
            btnSignIn.Text = "上班簽到";

            btnSignOut.Enabled = false;
            btnSignOut.Text = "下班簽退";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabNowTime.Text = "目前時間為:" + DateTime.Now;
        }
    }
}
