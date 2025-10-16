using source.Data;
using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static source.Data.EmployeeAccount;
using static source.Models.PersonModel.Employee;

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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            Role selectedRole = (Role)cboRole.SelectedItem;

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
                MessageBox.Show("Lương phải là một số hợp lệ và lớn hơn 0!");
                return;
            }
            try
            {
                if (isEditMode)
                {
                    // Cập nhật thông tin cho đối tượng Employee đang được chỉnh sửa
                    ResultEmployee.Name = name;
                    ResultEmployee.Email = email;
                    ResultEmployee.Phone = phone;
                    ResultEmployee.BaseSalary = salary;
                    ResultEmployee._Role = selectedRole;
                    // Chỉ cập nhật mật khẩu nếu người dùng nhập mật khẩu mới
                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        ResultEmployee.Password = password;
                    }
                }
                else
                {
                    // Tạo một đối tượng Employee hoàn toàn mới
                    ResultEmployee = new Employee(name, email, phone, salary, selectedRole, username, password);
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