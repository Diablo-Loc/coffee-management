using source.Data;
using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static source.Data.EmployeeAccount;

namespace source.Services
{
    internal class XácThực
    {
        // XácThực.cs
        public static Employee Authenticate(string username, string password)
        {
            string hashed = SecurityHelper.HashPassword(password);
            return EmployeeAccount.Authenticate(username, hashed); // đã mã hóa rồi
        }

    }
}
