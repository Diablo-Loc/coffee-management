using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.DiscountModel
{
    public abstract class Discount
    {
        private string _Name;
        private string _Type;//% or fixed,..
        private decimal _Percent;
        private bool _IsActive;
        public string Name { get { return _Name; }set { _Name = value; } }
        public string Type { get { return _Type; } set { _Type = value; } }
        public decimal Percent { get { return _Percent; } set { _Percent = value; } }
        public bool IsActive { get { return _IsActive; } set { _IsActive = value; } }
        protected Discount() { }
        protected Discount(string name, string type, decimal value)
        {
            _Name = name;
            _Type = type;
            _Percent = value;
            _IsActive = true;
        }
        public abstract decimal Apply(Order order);
        public virtual void Xuat()
        {
            Console.WriteLine($"{Name} ({Type}) - Value: {Percent} - Active: {_IsActive}");
        }
    }
}
