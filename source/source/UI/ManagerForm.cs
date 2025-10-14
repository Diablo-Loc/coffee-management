using source.Data;
using source.Models.PersonModel;
using source.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace source.UI
{
    public partial class ManagerForm : Form
    {
        private List<Employee> employeeList;
        public ManagerForm()
        {
            InitializeComponent();
            employeeList = EmployeeAccount.GetAllEmployees()
                .Where(emp => emp._Role != Employee.Role.Admin)
                .Where(emp => emp._Role != Employee.Role.Manager)
                .ToList();
            UpdateGrid(employeeList);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            string criteria = cbSapXep.SelectedItem.ToString();
            if (criteria == "Tên") employeeList.Sort(new EmployeeCompare.ByName());
            else if (criteria == "Lương") employeeList.Sort(new EmployeeCompare.BySalaryDescending());

            UpdateGrid(employeeList);
        }

        private void btnTangLuong_Click(object sender, EventArgs e)
        {
            var select = GetSelectedEmployee();
            if (select == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập số tiền cần tăng:",
                "Giảm lương",
                "1000000 VND"
            );
            if (!decimal.TryParse(input.Replace(" VND", "").Replace(",", "").Trim(), out decimal amount))
            {
                MessageBox.Show("Giá trị nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TangLuong(select, amount);
        }
        private void btnGiamLuong_Click(object sender, EventArgs e)
        {
            var select = GetSelectedEmployee();
            if (select == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập số tiền cần giảm:",
                "Giảm lương",
                "1000000 VND"
            );
            if (!decimal.TryParse(input.Replace(" VND", "").Replace(",", "").Trim(), out decimal amount))
            {
                MessageBox.Show("Giá trị nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiamLuong(select, amount);
        }
        private void TangLuong(Employee e, decimal amount)
        {
            e += amount;
            UpdateGrid(employeeList);
            EmployeeAccount.UpdateEmployee(e);
        }
        private void GiamLuong(Employee e, decimal amount)
        {
            e -= amount;
            UpdateGrid(employeeList);
            EmployeeAccount.UpdateEmployee(e);
        }
        private void UpdateGrid(List<Employee> list)
        {
            dgvEmployee.Rows.Clear();

            if (dgvEmployee.Columns.Count == 0)
            {
                dgvEmployee.Columns.Add("Id", "ID");
                dgvEmployee.Columns.Add("Name", "Họ tên");
                dgvEmployee.Columns.Add("Username", "Tài khoản");
                dgvEmployee.Columns.Add("Role", "Vai trò");
                dgvEmployee.Columns.Add("BaseSalary", "Lương cơ bản");
                foreach (DataGridViewColumn column in dgvEmployee.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }

            foreach (var emp in list)
            {
                dgvEmployee.Rows.Add(
                    emp.Id,
                    emp.Name,
                    emp.Username,
                    emp._Role.ToString(),
                    emp.BaseSalary.ToString("N0") + " VND"
                );
            }
        }
        private Employee GetSelectedEmployee()
        {
            if (dgvEmployee.SelectedRows.Count == 0)
                return null;

            int id = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["Id"].Value);
            return employeeList.FirstOrDefault(e => e.Id == id);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedEmployee();
            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var detailForm = new EmployeeDetailForm(selected);
            detailForm.ShowDialog();
        }
    }
}
