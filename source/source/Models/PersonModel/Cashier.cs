using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.PersonModel
{
    internal class Cashier : Employee
    {
        private int _WorkingHours;
        private decimal _HourRate;
        public int WorkHours { get { return _WorkingHours; } set { _WorkingHours = value; } }
        public decimal HourRate { get { return _HourRate; } set { _HourRate = value; } }
        public Cashier() : base() { }
        public Cashier(string name, string email, string phone, decimal baseSalary, Role role, string username, string password,
            int workingHours, decimal hourlyRate) : base(name, email, phone, baseSalary, Role.Cashier, username, password)
        {
            _WorkingHours = workingHours;
            _HourRate = hourlyRate;
        }
        ~Cashier() { }
        public override decimal CalculateSalary()
        {
            return BaseSalary +(_WorkingHours * _HourRate);
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"WorkingHours: {_WorkingHours}, HourlyRate: {_HourRate}");
        }
    }
}
