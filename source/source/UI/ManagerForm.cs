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
        private readonly EmployeeService employeeservice = new EmployeeService();
        private List<Employee> employeeList;
        public ManagerForm()
        {
            InitializeComponent();
            employeeList = employeeservice.GetManagableEmployees();
            UpdateGrid(employeeList);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbSapXep.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí sắp xếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string criteria = cbSapXep.SelectedItem.ToString();
            employeeList = employeeservice.SortEmployees(employeeList, criteria);
            UpdateGrid(employeeList);
        }

        private void btnTangLuong_Click(object sender, EventArgs e)
        {
            var select = GetSelectedEmployee();
            if (select == null)
            {
                MessageBox.Show("Please select an employee.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the amount to increase:",
                "Decrease salary",
                "1000000 VND"
            );
            if (!decimal.TryParse(input.Replace(" VND", "").Replace(",", "").Trim(), out decimal amount))
            {
                MessageBox.Show("Invalid input value!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employeeservice.IncreaseSalary(select, amount);
            employeeList = employeeservice.GetManagableEmployees();
            UpdateGrid(employeeList);
        }
        private void btnGiamLuong_Click(object sender, EventArgs e)
        {
            var select = GetSelectedEmployee();
            if (select == null)
            {
                MessageBox.Show("Please select an employee.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the amount to increase:",
                "Increase salary",
                "1000000 VND"
            );
            if (!decimal.TryParse(input.Replace(" VND", "").Replace(",", "").Trim(), out decimal amount))
            {
                MessageBox.Show("Please select an employee.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employeeservice.DecreaseSalary(select, amount);
            employeeList = employeeservice.GetManagableEmployees();
            UpdateGrid(employeeList);
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
                MessageBox.Show("Please select an employee.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var detailForm = new EmployeeDetailForm(selected);
            detailForm.ShowDialog();
        }
    }
}
