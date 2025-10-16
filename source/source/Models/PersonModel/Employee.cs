using source.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.PersonModel
{
    public class Employee : Person, ISalaryCompute
    {
        private decimal _BaseSalary;
        private string _Username;
        private string _Password;
        public decimal BaseSalary { get { return _BaseSalary; } set { _BaseSalary = value; } }
        public string Username { get { return _Username; } set { _Username = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }
        public enum Role
        {
            Admin,
            Manager,
            Cashier
        }
        public Role _Role { get; set; }
        public Employee() : base() { }
        public Employee(string fullName, string email, string phone, decimal baseSalary, Role role,string username,string password) : base(fullName, email, phone)
        {
            _BaseSalary=baseSalary;
            _Role=role;
            _Username=username;
            _Password=password;
        }
        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Role: {_Role}, BaseSalary: {BaseSalary}");
        }

        ~Employee() { }
        public static void AddEmployee(List<Employee> list, Employee emp)
        {
            list.Add(emp);
        }

        public override bool Equals(object obj)
        {
            return obj is Employee other && this == other;
        }
        //overide để hỗ trợ so sánh với dùng hashset, sau này mở rộng mới dùng tới
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public static Employee operator +(Employee a, decimal TangLuong)
        {
            a.BaseSalary += TangLuong;
            return a;
        }
        public static Employee operator -(Employee a, decimal GiamLuong)
        {
            a.BaseSalary = Math.Max(0, a.BaseSalary - GiamLuong);
            return a;
        }
        public void TangLuong(decimal amount)
        {
            this.BaseSalary += amount;
        }
        public void GiamLuong(decimal amount)
        {
            this.BaseSalary -= amount;
        }
    }
}
