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
    public class AuthService
    {
        public static Employee Authenticate(string username, string password)
        {
            return EmployeeAccount.Authenticate(username, password);
        }
        //lấy dữ liệu từ database giống với lên của nó
        public void InitialDataforLogin()
        {
            EmployeeAccount.InitializeDatabase();
        }
       //xác thực người dùng
       public Employee Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new System.Exception("Tên đăng nhập và mật khẩu không được để trống.");
            }

            var user = Authenticate(username, password);

            if (user == null)
            {
                throw new System.Exception("Sai tài khoản hoặc mật khẩu!");
            }

            return user;
        }
    }
}
