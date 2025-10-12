using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.PersonModel
{
    public class Administrator : Employee
    {
        public Administrator(): base(){ }
        public Administrator (string fullName, string email, string phone,Role role,string username, string password) : base(fullName, "","",0,Role.Admin,username,password)
        {
            
        }
        public void AddEmployee(List<Employee> employees, Employee newE)
        {
            employees.Add(newE);
        }
        public void RemoveEmployee(List<Employee> employees, string username)
        {
            employees.RemoveAll(e => e.Username == username);
            Touch();
        }


    }
}
