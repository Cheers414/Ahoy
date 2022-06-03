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
        ahoyCorpEntities1 ace = new ahoyCorpEntities1();
        private void UserControlApproval_Load(object sender, EventArgs e)
        {
            
        }
        public new void BringToFront()//此處為元件初始化
        {
            base.BringToFront();
            ShowLeaveRecord();
            ShowVactionRecord();
        }
        private void ShowLeaveRecord() //顯示登入員工 請假餘額一覽
        {
            int i=1;
            String accounte = "11001";//測試用
            var loginAccount = ace.Account.Where(x => x.account == accounte).FirstOrDefault();
            var loginEmployeeId = loginAccount.EmployeeID;//取得登入帳號 員工編號(EmployeeID)
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
                var approvaVacionRecord = ace.VacationRecord.Where(x => x.ApplicantEmployeeID == loginEmployeeId && x.VacationTypeID == i).ToList();
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

                    //TimeSpan holidayDay = (TimeSpan)(approvaVacionRecord.vacationEndDateTime - approvaVacionRecord.vacationStartDateTime); // 時長計算
                    holidaySum = totalDays.ToString(); //時長轉型為String 代入天數加總(holidaySum)
                }
                 ((UIAvatar)this.Controls.Find("LabHolidayValue" + i, true)[0]).Text = holidaySum + " 天 / " + holidayLimit.ToString() + " 天"; // 顯示 已用天數加總(holidaySum)和 假別配額(holidayLimit)
            }
        }
        private void ShowVactionRecord()
        {
            ace.VacationRecord.Where(x => x.ApplicantEmployeeID == 1).ForEach(x => {
                var item = new ListViewItem() { Text = x.VacationRecordID.ToString() };
                item.SubItems.Add(ace.VacationType.Find(x.VacationTypeID).vacationTypeName);
                item.SubItems.Add(x.vacationReason.ToString());
                item.SubItems.Add(x.vacationStartDateTime.ToString("yyyy/MM/dd HH:mm"));
                item.SubItems.Add(x.vacationEndDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                item.SubItems.Add(x.ApplyStatus.status);
                listView1.Items.Add(item);
            });
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
