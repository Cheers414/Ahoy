using Sunny.UI;
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
    public partial class UserControlApproval : UserControl
    {
        public UserControlApproval()
        {
            InitializeComponent();
        }
        ahoyCorpEntities ace = new ahoyCorpEntities();
        private void UserControlApproval_Load(object sender, EventArgs e)
        {
            
        }
        public new void BringToFront()//此處為元件初始化
        {
            base.BringToFront();
            ShowLeaveRecord(); //顯示登入員工 請假餘額一覽
            ShowVactionRecord(); //個人請假申請記錄
            Applicationform(); //個人請假申請表單


        }
        //請假資訊(VactionInfo Pages)
        private void ShowLeaveRecord() //顯示登入員工 請假餘額一覽
        {
            int i=1;
            String accounte = "11001";//測試用
            var loginAccount = ace.Account.Where(x => x.account == accounte).FirstOrDefault();
            //var loginEmployeeId = loginAccount.EmployeeID;//取得登入帳號 員工編號(EmployeeID)
            String holidaySum;
            for ( i = 1; i < 7; i++)
            {
                var approvalVactionType = ace.VacationType.Where(x => x.VacationTypeID == i).FirstOrDefault();
                if (approvalVactionType == null)//判斷是否有資料
                {
                    MessageBox.Show("找不到'請假配額'資料", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var holidayLimit = approvalVactionType.vacationLimit; //假別配額變數
                var approvaVacionRecord = ace.VacationRecord.Where(x => x.ApplicantEmployeeID == loginAccount.EmployeeID && x.VacationTypeID == i).ToList();
                if(approvaVacionRecord == null && !approvaVacionRecord.Any()) // 如果沒有該假別請假紀錄 已用天數(holidaySum) 為 "0"
                {
                    holidaySum = "0";
                }
                else // 否則，計算請假時長
                {
                    int totalDays = 0;
                    approvaVacionRecord.ForEach(record => {
                        totalDays += (record.vacationEndDateTime - record.vacationStartDateTime).Value.Days;
                    });
                    holidaySum = totalDays.ToString(); //時長轉型為String 代入天數加總(holidaySum)
                }
                 ((UIAvatar)this.Controls.Find("LabHolidayValue" + i, true)[0]).Text = holidaySum + " 天 / " + holidayLimit.ToString() + " 天"; // 顯示 已用天數加總(holidaySum)和 假別配額(holidayLimit)
            }
        }
        private void LabHolidayShow_Click(object sender, EventArgs e) //開啟請假餘額總覽表
        {
            UserHolidaytotal userHolidaytotal = new UserHolidaytotal();
            userHolidaytotal.Show();
        }

        private void ShowVactionRecord() //個人請假申請記錄
        {
            ace.VacationRecord.Where(x => x.ApplicantEmployeeID == 1).ForEach(x => {
                var manager = ace.Employee.Find(x.Employee.mangerEmployeeIdID);
                var item = new ListViewItem() { Text = x.VacationRecordID.ToString() };
                item.SubItems.Add(ace.VacationType.Find(x.VacationTypeID).vacationTypeName);
                item.SubItems.Add(x.Employee.employeeName);
                item.SubItems.Add(x.vacationReason.ToString());
                item.SubItems.Add(x.vacationStartDateTime.ToString("yyyy/MM/dd HH:mm"));
                item.SubItems.Add(x.vacationEndDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                item.SubItems.Add(manager.employeeName);

                if (x.ApplyChanged.HasValue)
                {
                    item.SubItems.Add(x.ApplyChanged.Value.ToString("yyyy/MM/dd HH:mm"));
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.SubItems.Add(x.ApplyStatus.status);
                listView1.Items.Add(item);
            });
        }

        private void btnKeyWord_Click(object sender, EventArgs e) //個人請假申請記錄查詢
        {
            listView1.Items.Clear();
            var result = ace.VacationRecord.Where(x => x.ApplicantEmployeeID == 1 && (x.vacationReason.Contains(txtkeyWord.Text) 
            || x.ApplyStatus.status.Contains(txtkeyWord.Text) || x.VacationType.vacationTypeName.Contains(txtkeyWord.Text)));
            result.ForEach(x => {
                var manager = ace.Employee.Find(x.Employee.mangerEmployeeIdID);
                var item = new ListViewItem() { Text = x.VacationRecordID.ToString() };
                item.SubItems.Add(x.VacationType.vacationTypeName);
                item.SubItems.Add(x.Employee.employeeName);
                item.SubItems.Add(x.vacationReason.ToString());
                item.SubItems.Add(x.vacationStartDateTime.ToString("yyyy/MM/dd HH:mm"));
                item.SubItems.Add(x.vacationEndDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                item.SubItems.Add(manager.employeeName);

                if (x.ApplyChanged.HasValue)
                {
                    item.SubItems.Add(x.ApplyChanged.Value.ToString("yyyy/MM/dd HH:mm"));
                }
                else
                {
                    item.SubItems.Add("");
                }
                
                item.SubItems.Add(x.ApplyStatus.status);
                listView1.Items.Add(item);
            });
        }
        //申請表單 (VactionApply Pages)


        private void Applicationform() //個人請假申請表單
        {
            String accounte = "11001";//測試用
            var loginAccount = ace.Account.Where(x => x.account == accounte).FirstOrDefault();
            var loginEmployee = ace.Employee.Where(x => x.EmployeeID == loginAccount.EmployeeID).FirstOrDefault();
            txtDepartmentalID.Text = ace.Departmental.Find(loginEmployee.DepartmentalID).departmentalName;
            txtApplicantEmployeeID.Text = loginEmployee.employeeName;
        }

        private void UiButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtReason.Text))
            {
                MessageBox.Show("事由不得為空!", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String accounte = "11001";//測試用
            var loginAccount = ace.Account.Where(x => x.account == accounte).FirstOrDefault();
            var status = ace.ApplyStatus.Where(x => x.status == "待審核").FirstOrDefault();
            var applicationformace = new VacationRecord
            {
                VacationRecordID = ace.VacationRecord.Count() + 1,
                //SecondID = Guid.NewGuid().ToString()
                VacationTypeID = ace.VacationType.Where(x => x.vacationTypeName == cmbVacationType.Text).FirstOrDefault().VacationTypeID,
                DepartmentalID = ace.Employee.Find(loginAccount.EmployeeID).DepartmentalID,
                ApplicantEmployeeID = loginAccount.EmployeeID.Value,
                vacationStartDateTime = dtpStartTime.Value,
                vacationEndDateTime = dtpEndTime.Value,
                vacationReason = txtReason.Text,
                attachedFilesName = null,
                ApplyStatusID = status.ApplyStatusID,
                ApplyChanged = null,
            };

            ace.VacationRecord.Add(applicationformace);
            if(ace.SaveChanges() > 0)
            {
                MessageBox.Show("新增成功", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReason.Clear();
            }
            else
                MessageBox.Show("新增失敗", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void uiLabel18_Click(object sender, EventArgs e)
        {

        }

        private void LabHolidayBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
