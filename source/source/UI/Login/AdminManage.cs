using source.Data;
using source.Models.Catalog;
using source.Models.PersonModel;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEmployeeForm(currentUser, employees, LoadEmployees);
            addForm.StartPosition = FormStartPosition.CenterParent;
            addForm.ShowDialog(this);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                var selected = (Employee)dgvEmployee.SelectedRows[0].DataBoundItem;

                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {selected.Name}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    EmployeeAccount.DeleteEmployee(selected.Id); // Xóa khỏi SQLite
                    LoadEmployees();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                var selected = (Employee)dgvEmployee.SelectedRows[0].DataBoundItem;
                var editForm = new AddEmployeeForm(currentUser, employees, LoadEmployees, selected);
                editForm.ShowDialog();
            }
            
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void LoadEmployees()
        {
            employees = EmployeeAccount.GetAllEmployees(); // Lấy từ SQLite

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
