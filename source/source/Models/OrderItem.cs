using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class OrderItem
    {
        private MenuItem sItems;
        private int sQuanity;

        public MenuItem Items {  
            get { return sItems; }
            set { sItems = value; }      
        }
        public int Quanity
        {
            get { return sQuanity; }
            set { sQuanity = value; }
        }

        public OrderItem()
        {
        }
        public OrderItem(MenuItem item, int quanity)
        {
            this.sItems = item;
            this.sQuanity = quanity;
        }

        //method...
    }

}
