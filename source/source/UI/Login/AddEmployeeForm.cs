using ScottPlot.Statistics;
using source.Data;
using source.Models.Catalog;
using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static source.Data.EmployeeAccount;
using static source.Models.PersonModel.Employee;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace source.UI.Login
{
    public partial class AddEmployeeForm : Form
    {
        private Employee currentUser;
        private List<Employee> employees;
        private Action reloadCallback;
        private bool isEditMode = false;
        private Employee editingEmployee;
        public Employee ResultEmployee { get; private set; }
        public AddEmployeeForm()
        {
            InitializeComponent();

            cboRole.DataSource = Enum.GetValues(typeof(Role));
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public AddEmployeeForm(Employee user, List<Employee> empList, Action reload)
        {
            InitializeComponent();
            currentUser = user;
            employees = empList;
            reloadCallback = reload;

            cboRole.DataSource = Enum.GetValues(typeof(Role));
            // Kiểm tra quyền
            if (currentUser._Role != Role.Admin)
            {
                MessageBox.Show("You do not have permission!");
                this.Close();
            }
        }

        public AddEmployeeForm(Employee toEdit) : this()
        {
            isEditMode = true;
            ResultEmployee = toEdit;

            txtName.Text = toEdit.Name;
            txtEmail.Text = toEdit.Email;
            txtPhone.Text = toEdit.Phone;
            txtSalary.Text = toEdit.BaseSalary.ToString();
            txtUserName.Text = toEdit.Username;
            txtPassword.Text = ""; // không hiển thị mật khẩu cũ
            cboRole.SelectedItem = toEdit._Role;
            if (toEdit is Manager manager)
            {

                txtAllowance.Text = manager.Allowance.ToString();
                txtReponsible.Text = manager.ReponsibleRate.ToString();
            }
        }
        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Role selected = (Role)cboRole.SelectedItem;
            if( selected == Role.Manager) {
                lblAllowance.Visible = true;
                txtAllowance.Visible = true;
                lblReponsible.Visible = true;
                txtReponsible.Visible = true;
            }
            else if (selected == Role.Admin)
            {
                lblAllowance.Visible = false;
                txtAllowance.Visible = false;
                lblReponsible.Visible = false;
                txtReponsible.Visible = false;
            }
            else if (selected == Role.Cashier)
            {
                lblAllowance.Visible = false;
                txtAllowance.Visible = false;
                lblReponsible.Visible = false;
                txtReponsible.Visible = false;
            }
            }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            Role selectedRole = (Role)cboRole.SelectedItem;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(username) ||
                (!isEditMode && string.IsNullOrWhiteSpace(password)))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc!");
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Lương phải là số hợp lệ và lớn hơn 0!");
                return;
            }

            try
            {
                if (isEditMode)
                {
                    // Cập nhật thông tin nhân viên đang chỉnh sửa
                    ResultEmployee.Name = name;
                    ResultEmployee.Email = email;
                    ResultEmployee.Phone = phone;
                    ResultEmployee.BaseSalary = salary;
                    ResultEmployee._Role = selectedRole;

                    if (!string.IsNullOrWhiteSpace(password))
                        ResultEmployee.Password = password;

                    if (ResultEmployee is Manager manager)
                    {
                        if (!decimal.TryParse(txtAllowance.Text, out decimal allowance) ||
                            !decimal.TryParse(txtReponsible.Text, out decimal rate))
                        {
                            MessageBox.Show("Allowance và Responsibility Rate phải là số hợp lệ!");
                            return;
                        }

                        manager.Allowance = allowance;
                        manager.ReponsibleRate = rate;
                    }
                }
                else
                {
                    // Tạo mới nhân viên theo Role
                    switch (selectedRole)
                    {
                        case Role.Manager:
                            if (!decimal.TryParse(txtAllowance.Text, out decimal allowance) ||
                                !decimal.TryParse(txtReponsible.Text, out decimal rate))
                            {
                                MessageBox.Show("Allowance và Responsibility Rate phải là số hợp lệ!");
                                return;
                            }

                            ResultEmployee = new Manager(name, email, phone, salary, Role.Manager, username, password, allowance, rate);
                            break;

                        default:
                            ResultEmployee = new Employee(name, email, phone, salary, selectedRole, username, password);
                            break;
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}