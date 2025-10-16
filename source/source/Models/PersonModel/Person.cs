using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.PersonModel
{
    public abstract class Person:EntityBase
    {
        private string _Name;
        private string _Email;
        private string _Phone;
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        protected Person():base() { }
        protected Person(string fullName, string email, string phone) : base()
        {
            _Name = fullName;
            _Email = email;
            _Phone = phone;
        }
        ~Person() { }
        public virtual void InputInfo(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Touch();
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"{Name} | {Email} | {Phone}");
        }
    }
}
