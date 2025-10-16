using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.Catalog
{
    public class Food:Product
    {
        private bool _IsVegetarian;
        private string _Topping;
        public bool IsVegetarian { get { return _IsVegetarian; }set { _IsVegetarian = value; } }
        public string Topping { get { return _Topping; } set { _Topping = value; } }
        public Food():base(){}
        public Food(bool isVegetarian, string topping, string Name, decimal Price, string Description) : base(Name, Price, "Food", Description)
        {
            this._IsVegetarian=isVegetarian;
            this._Topping=topping;
        }
        ~Food() { }
        public override decimal GetPrice()
        {
            decimal toppingFee = !string.IsNullOrEmpty(Topping) ? 5000m : 0m;
            return Price + toppingFee;
        }
        public override string Describe()
        {
            return $"{Name} {(IsVegetarian ? "(Vegan)" : "")} {(!string.IsNullOrEmpty(Topping) ? $"[Topping: {Topping}]" : "")} - {GetPrice():N0}đ";
        }
        public static Food Create(string Name, decimal Price)
        {
            return new Food(true,"",Name, Price,""); 
        }
    }
}
