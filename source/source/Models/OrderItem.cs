using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    public class OrderItem
    {
        private MenuItem sItem;
        private int sQuantity;

        public MenuItem Item {  
            get { return sItem; }
            set 
            {
                if (value == null) throw new ArgumentNullException(nameof(Item));
                sItem = value; 
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
            this.sItem = item;
            this.sQuantity = quanity;
        }
        //method
        //Tổng tiền sp order
        public decimal TotalPrice()
        {
            if (sItem == null) return 0;
            return sItem.Price * this.sQuantity;
        }
        //Tăng-giảm số lượng order
    }

}
