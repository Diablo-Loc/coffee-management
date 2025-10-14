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

namespace source.UI
{
    public partial class EmployeeDetailForm : Form
    {
        private Employee employee;
        public EmployeeDetailForm(Employee e)
        {
            InitializeComponent();
            employee = e;
            Load();
        }
        private void Load()
        {
            txtName.Text=employee.Name;
            txtUserName.Text=employee.Username;
            txtEmail.Text=employee.Email;
            txtPhone.Text=employee.Phone;
            txtSalary.Text= employee.BaseSalary.ToString("N0") + " VND";
            txtRole.Text=employee._Role.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
