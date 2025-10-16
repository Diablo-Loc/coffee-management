using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.Catalog
{
    public abstract class Product:EntityBase
    {
        private string _Name;
        private decimal _Price;
        private string _Category;
        private string _Description;

        public string Name { get { return _Name; } set { _Name = value; } }
        public decimal Price { get { return _Price; } set { _Price = value; } }
        public string Category { get { return _Category; } set { _Category = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public Product() { }
        public Product(string name, decimal price, string category, string description)
        {
            this._Name = name;
            this._Price = price;
            this._Category = category;
            this._Description = description;
        }
        ~Product() { }
        public abstract decimal GetPrice();
        public virtual string Describe()
        {
            return $"{Name} ({Category}) - {Price}đ";
        }        
    }
}
