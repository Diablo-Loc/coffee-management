using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class ItemBase
    {
        private string sname;
        private decimal sprice;

        public string Name { get { return sname; } set { sname = value; } }
        public decimal Price { get { return sprice; } set { sprice = value; } }

        public ItemBase()
        {

        }

        public ItemBase(string name,decimal price)
        {
            this.sname = name;
            this.sprice = price;
        }

        //method

    }
}
