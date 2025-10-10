using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.Catalog
{
    public class Drink:Product
    {
        private string _Size;
        private bool _IsHot;
        public string Size { get { return _Size; } set { _Size = value; } }
        public bool IsHot { get { return _IsHot; } set { _IsHot = value; } }
        public Drink() : base() { }
        public Drink(string size, bool isHot, string Name, decimal Price, string Description) : base(Name, Price, "Drink", Description)
        {
            this._Size = size;
            this._IsHot = isHot;
        }
        ~Drink() { }
        public override decimal GetPrice()
        {
            return Size.ToLower() switch
            {
                "Nhỏ" => Price,
                "To" => Price + 5000m,
                _ => Price
            };
        }
        public override string Describe()
        {
            return $"{Name} - {Size} - {(IsHot ? "Hot" : "Iced")} - {GetPrice():N0} đ";
        }
    }
}
