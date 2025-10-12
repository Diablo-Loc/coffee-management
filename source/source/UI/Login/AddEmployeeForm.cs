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

        public AddEmployeeForm(Employee user, List<Employee> empList, Action reload)
        {
            InitializeComponent();
            currentUser = user;
            employees = empList;
            reloadCallback = reload;

            cboRole.DataSource = Enum.GetValues(typeof(Role));
            this.StartPosition = FormStartPosition.CenterScreen;
            // Kiểm tra quyền
            if (currentUser._Role != Role.Admin)
            {
                MessageBox.Show("Bạn không có quyền thêm nhân viên.");
                this.Close();
            }
        }

        public AddEmployeeForm(Employee user, List<Employee> empList, Action reload, Employee toEdit)
            : this(user, empList, reload)
        {
            isEditMode = true;
            editingEmployee = toEdit;

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
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Lương phải là số hợp lệ và lớn hơn 0!");
                return;
            }
            if (!isEditMode && EmployeeAccount.UsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }
            if (isEditMode && editingEmployee != null)
            {
                editingEmployee.Name = name;
                editingEmployee.Email = email;
                editingEmployee.Phone = phone;
                editingEmployee.BaseSalary = salary;
                editingEmployee._Role = selectedRole;

                MessageBox.Show("Cập nhật nhân viên thành công!");
            }
            else
            {
                // Kiểm tra trùng username
                var exists = employees.Find(e => e.Username == username);
                if (exists != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    return;
                }

                string hashedPassword = SecurityHelper.HashPassword(password);
                var emp = new Employee(name, email, phone, salary, selectedRole, username, hashedPassword);

                employees.Add(emp); // danh sách tạm
                EmployeeAccount.AddEmployee(emp); // lưu vào SQLite

                MessageBox.Show("Thêm nhân viên thành công!");
            }

            reloadCallback?.Invoke();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}