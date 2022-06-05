using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahoy
{
    public partial class FormApproval : Form
    {

        string Id;
        ahoyCorpEntities ace = new ahoyCorpEntities();
        public FormApproval(string id)
        {
            InitializeComponent();
            Id = id;
            var record = ace.VacationRecord.Find(int.Parse(id));
            lblAppName.Text = record.Employee.employeeName;
            lblAppId.Text = id;
            lblAppType.Text = record.VacationType.vacationTypeName;
            lblAppdep.Text = record.Employee.Departmental.departmentalName;
            lblAppStart.Text = record.vacationStartDateTime.ToString();
            lblAppEnd.Text = record.vacationEndDateTime.ToString();
            txtAppReason.Text = record.vacationReason;
            }

        private void btnAppok_Click(object sender, EventArgs e)
        {
            VacationRecord record = ace.VacationRecord.Find(int.Parse(Id));
            record.ApplyStatusID = 1;
            record.ApplyChangedDatetime = DateTime.Now;
            ace.Entry(record).State = EntityState.Modified;
            ace.SaveChanges();
            MessageBox.Show($"簽核成功! 請假編號：{Id}", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                
        }

        private void lblAppOverrule_Click(object sender, EventArgs e)
        {
            VacationRecord record = ace.VacationRecord.Find(int.Parse(Id));
            record.ApplyStatusID = 2;
            record.ApplyChangedDatetime = DateTime.Now;
            ace.Entry(record).State = EntityState.Modified;
            ace.SaveChanges();
             MessageBox.Show($"駁回完成! 請假編號：{Id}", Properties.Resources.systemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormApproval_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
