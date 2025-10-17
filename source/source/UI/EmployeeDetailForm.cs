using ScottPlot.Colormaps;
using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static source.Models.PersonModel.Employee;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace source.UI
{
    public partial class EmployeeDetailForm : Form
    {
        public Employee ResultEmployee { get; private set; }
        private Employee employee;
        public EmployeeDetailForm(Employee e)
        {
            InitializeComponent();
            employee = e;
            Load();
        }
        private void Load()
        {
            txtName.Text = employee.Name;
            txtUserName.Text = employee.Username;
            txtEmail.Text = employee.Email;
            txtPhone.Text = employee.Phone;
            txtSalary.Text = employee.BaseSalary.ToString("N0") + " VND";
            txtRole.Text = employee._Role.ToString();
            txtsalarycompute.Text = employee.CalculateSalary().ToString("N0") + " VND";

            if (employee is Cashier c)
            {
                txtWorkinghours.Text = c.WorkHours.ToString();
                txtHour.Text = c.HourRate.ToString("N0");
            }
            else
            {
                txtWorkinghours.Text = "";
                txtHour.Text = "";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtWorkinghours.Text.Trim(), out int workingHours) ||
                !decimal.TryParse(txtHour.Text.Trim(), out decimal hourRate))
            {
                MessageBox.Show("Working Hours và Hour Rate phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (employee is Cashier c)
            {
                c.WorkHours = workingHours;
                c.HourRate = hourRate;
                ResultEmployee = c; 
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
      }
}