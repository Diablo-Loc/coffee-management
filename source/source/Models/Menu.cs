using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class Menu
    {
        private List<MenuItem> Items;

        public List<MenuItem> items {  get; set; }

        public Menu()
        {
            Items =new List<MenuItem>();
        }
        public Menu(List<MenuItem> i)
        {
            this.Items =i;
        }
        //method(các chức năng...)

    }
}
