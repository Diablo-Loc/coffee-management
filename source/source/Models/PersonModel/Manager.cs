using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static source.Models.PersonModel.Employee;

namespace source.Models.PersonModel
{
    internal class Manager:Employee
    {
        private decimal _Allowance;
        private decimal _ReponsibleRate; //tỉ lệ cống hiến
        public decimal Allowance { get { return _Allowance; } set { _Allowance = value; } }
        public decimal ReponsibleRate { get { return _ReponsibleRate; } set { _ReponsibleRate = value; } }
        public Manager():base() { } 
        public Manager(string name, string email, string phone, decimal baseSalary, Role role, string username, string password,
            decimal allowance, decimal reponsibleRate): base(name, email, phone, baseSalary, Role.Manager, username, password)
        {
            _Allowance = allowance;
            _ReponsibleRate= reponsibleRate;
        }
        ~Manager() { }
        public override decimal CalculateSalary()
        {
            return BaseSalary + Allowance * ReponsibleRate;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Allowance: {Allowance}, ResponsibilityRate: {ReponsibleRate}");
        }
    }
}
