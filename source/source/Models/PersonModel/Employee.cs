using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.PersonModel
{
    public class Employee : Person
    {
        private decimal _BaseSalary;
        private string _Role;
        public decimal BaseSalary { get { return _BaseSalary; } set { _BaseSalary = value; } }
        public string Role { get { return _Role; } set { _Role = value; } }
        public Employee() : base() { }
        public Employee(string fullName, string email, string phone, decimal baseSalary, string role) : base(fullName, email, phone)
        {
            _BaseSalary=baseSalary;
            _Role=role;
        }
        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Role: {Role}, BaseSalary: {BaseSalary}");
        }

        ~Employee() { }
    }
}
