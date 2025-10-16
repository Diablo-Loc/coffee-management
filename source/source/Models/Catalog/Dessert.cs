using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace source.Models.Catalog
{
    public class Dessert:Product
    {
        private bool _isCold;
        private string _flavor;
        private string _decoration;

        public bool IsCold { get { return _isCold; } set { _isCold = value; } }
        public string Flavor { get { return _flavor; } set { _flavor = value; } }
        public string Decoration { get { return _decoration; } set { _decoration = value; } }
        public Dessert() : base() { }

        public Dessert(bool isCold, string flavor, string decoration, string name, decimal price, string description): base(name, price, "Dessert", description)
        {
            _isCold = isCold;
            _flavor = flavor;
            _decoration = decoration;
        }
        public override decimal GetPrice()
        {
            decimal extra = 0m;
            if (IsCold) extra += 3000m;
            if (!string.IsNullOrWhiteSpace(Decoration)) extra += 2000m;
            return Price + extra;
        }
        public override string Describe()
        {
            return $"{Name} -{Flavor} - {(IsCold ? "Cold" : "Warm")}-{Decoration} - {GetPrice():N0} đ";
        }
        public static Dessert Create(string Name, decimal Price)
        {
            return new Dessert(true, "", "", Name, Price, "");
        }
    }
}
