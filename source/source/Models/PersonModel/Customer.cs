using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.PersonModel
{
    public class Customer:Person
    {
        private int _LoyalPoints;
        public int LoyalPoints { get { return _LoyalPoints; } set { _LoyalPoints = value; } }
        public Customer():base() { }
        public Customer(string name, string email, string phone, int point   = 0) :base(name, email, phone) 
        {
            this._LoyalPoints = point;
        }
        ~Customer() { }
        public void AddPoints(int p)
        {
            _LoyalPoints += p;
            Touch();
        }
        public bool UsePoints(int p)
        {
            if (p <= 0 || p > LoyalPoints) return false;
            LoyalPoints -= p;
            Touch();
            return true;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"LoyaltyPoints: {LoyalPoints}");
        }
    }
}
