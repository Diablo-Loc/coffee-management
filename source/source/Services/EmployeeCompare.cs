using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static source.Models.PersonModel.Employee;

namespace source.Services
{
    public class EmployeeCompare
    {
        public class ByName : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }

        public class BySalaryDescending : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return y.BaseSalary.CompareTo(x.BaseSalary);
            }
        }
    }
}
