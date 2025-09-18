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
        private int sQuantity;

        public MenuItem Items {  
            get { return sItems; }
            set 
            {
                if (value == null) throw new ArgumentNullException(nameof(Items));
                sItems = value; 
            }      
        }
        public int Quantity
        {
            get { return sQuantity; }
            set 
            {
                if (value <= 0) throw new ArgumentException("ERROR! Quantity must be > 0!");
                sQuantity = value; }
        }

        public OrderItem()
        {
        }
        public OrderItem(MenuItem item, int quanity)
        {
            this.sItems = item;
            this.sQuantity = quanity;
        }
        //method
        //Tổng tiền sp order
        public decimal TotalPrice()
        {
            if (sItems == null) return 0;
            return sItems.Price * this.sQuantity;
        }
        //Tăng-giảm số lượng order
    }

}
