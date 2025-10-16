using source.Common;
using source.Data;
using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Services
{
    public class EmployeeService
    {
        //lấy danh sách nhân viên of 1 manager quản lý
        public List<Employee> GetManagableEmployees()
        {
            return EmployeeAccount.GetAllEmployees()
                .Where(emp => emp._Role != Employee.Role.Admin && emp._Role != Employee.Role.Manager)
                .ToList();
        }
        //tăng lương
        public void IncreaseSalary(Employee employee, decimal amount)
        {
            if (employee == null || amount <= 0) return;

            employee.TangLuong(amount); 
            EmployeeAccount.UpdateEmployee(employee); 
        }
        public void DecreaseSalary(Employee employee, decimal amount)
        {
            if (employee == null || amount <= 0) return;

            employee.GiamLuong(amount); 
            EmployeeAccount.UpdateEmployee(employee);
        }
        //sắp xếp
        public List<Employee> SortEmployees(List<Employee> employees, string criteria)
        {
            if (criteria == "Name")
            {
                employees.Sort(new EmployeeCompare.ByName());
            }
            else if (criteria == "Salary")
            {
                employees.Sort(new EmployeeCompare.BySalaryDescending());
            }
            return employees;
        }
    }
}
