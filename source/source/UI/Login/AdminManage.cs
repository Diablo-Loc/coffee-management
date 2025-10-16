using source.Data;
using source.Models.Catalog;
using source.Models.PersonModel;
using source.Services;
using source.UI.Login;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace source.UI
{
    public partial class AdminManage : Form
    {
        private Employee currentUser;
        private List<Employee> employees = new List<Employee>();
        private bool isEditMode = false;
        private Employee editingEmployee;
        private readonly AdminService adminService=new AdminService();
        public AdminManage(Employee user)
        {
            InitializeComponent();
            currentUser = user;
            if (currentUser._Role != Employee.Role.Admin)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
                this.Close();
                return;
            }
            LoadEmployees();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                var selected = (Employee)dgvEmployee.SelectedRows[0].DataBoundItem;

                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {selected.Name}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        adminService.DeleteEmploy(selected.Id);
                        MessageBox.Show("Xóa thành công!");
                        LoadEmployees();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddEmployeeForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Employee newEmployee = addForm.ResultEmployee;

                        // Ra lệnh cho Service xử lý nghiệp vụ
                        adminService.AddEmploy(newEmployee);

                        MessageBox.Show("Thêm nhân viên thành công!");
                        LoadEmployees();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                var selected = (Employee)dgvEmployee.SelectedRows[0].DataBoundItem;

                using (var editForm = new AddEmployeeForm(selected))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Employee updatedEmployee = editForm.ResultEmployee;
                            adminService.UpdateEmploy(updatedEmployee);

                            MessageBox.Show("Cập nhật thành công!");
                            LoadEmployees();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void LoadEmployees()
        {
            employees = adminService.GetAllEmployeesForAdmin();
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = employees;

            dgvEmployee.Columns["Name"].DisplayIndex = 0;
            dgvEmployee.Columns["Email"].DisplayIndex = 1;
            dgvEmployee.Columns["Phone"].DisplayIndex = 2;
            dgvEmployee.Columns["BaseSalary"].DisplayIndex = 3;

            if (!dgvEmployee.Columns.Contains("Role"))
                dgvEmployee.Columns.Add("Role", "Vai trò");

            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                var emp = row.DataBoundItem as Employee;
                if (emp != null)
                    row.Cells["Role"].Value = emp._Role.ToString();
            }
        }
    }
}
