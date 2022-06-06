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
    public partial class FormShift : Form
    {
        public FormShift()
        {
            InitializeComponent();
        }

        public int empolyeeId;
        public string empolyeeName;
        public string empolyeeType;
        public bool isHistory;
        
        ahoyCorpEntities ace = new ahoyCorpEntities();
        private void FormShift_Load(object sender, EventArgs e)
        {
            comboBoxShiftTypeChange.DataSource = ace.ShiftRule.ToList();
            


            if (isHistory)
            {
                labelID.Text = empolyeeId.ToString();
                labelName.Text = empolyeeName;
                comboBoxShiftTypeChange.SelectedItem = 0;
                comboBoxName.Visible = false;
                comboBoxID.Visible = false;
            }
            else
            {
                comboBoxName.BringToFront();
                comboBoxID.BringToFront();
                comboBoxName.Visible = true;
                comboBoxID.Visible = true;

                comboBoxID.DataSource = ace.Employee.ToList();
                comboBoxID.SelectedItem = ace.Employee.ToList().SingleOrDefault(x => x.EmployeeID == empolyeeId);

                comboBoxName.DataSource = ace.Employee.ToList();
                comboBoxName.SelectedItem = ace.Employee.ToList().SingleOrDefault(x => x.employeeName == empolyeeName);

                comboBoxShiftTypeChange.SelectedItem = ace.ShiftRule.ToList().SingleOrDefault(x => x.shiftRuleName == empolyeeType);
            }
        }

        private void uiBtnSave_Click(object sender, EventArgs e)
        {

            empolyeeId = ((Employee)comboBoxID.SelectedItem).EmployeeID;
            empolyeeName = ((Employee)comboBoxName.SelectedItem).employeeName;
            empolyeeType = ((ShiftRule)comboBoxShiftTypeChange.SelectedItem).shiftRuleName;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
