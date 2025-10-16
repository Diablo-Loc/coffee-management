using source.Data;
using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Services
{
    public class AdminService
    {
        //lấy tất cả nhân viên trong data
        public List<Employee> GetAllEmployeesForAdmin()
        {
            return EmployeeAccount.GetAllEmployees();
        }
        //xóa 1 nhân viên
        public void DeleteEmploy(int eid)
        {
            EmployeeAccount.DeleteEmployee(eid);
        }
        //cập nhật, edit nhân viên
        public void UpdateEmploy(Employee e)
        {
            EmployeeAccount.UpdateEmployee(e);
        }
        //check và thêm 
        public void AddEmploy(Employee e)
        {
            if (EmployeeAccount.UsernameExists(e.Username))
            {
                throw new Exception("Tên đăng nhập đã tồn tại!");
            }
            EmployeeAccount.AddEmployee(e);
        }
    }
}
