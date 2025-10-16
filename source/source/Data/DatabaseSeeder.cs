using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static source.Data.EmployeeAccount;
using static source.Models.PersonModel.Employee;

namespace source.Data
{
    internal class DatabaseSeeder
    {
        public static void Seed()
        {
            var admin = new Employee
            {
                Name = "Admin",
                Email = "admin@email.com",
                Phone = "0123456789",
                _Role = Employee.Role.Admin,
                Username = "admin",
                Password = "123"
            };

            if (EmployeeAccount.Authenticate(admin.Username, "123") == null)
            {
                EmployeeAccount.AddEmployee(admin);
            }
        }

    }
}
