using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using source.Models.Catalog;

namespace source.Models.OrderModel
{
    public class OrderItem
    {
        private Product sItem;
        private int sQuantity;

        public Product Item
        {
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
                sQuantity = value;
            }
        }

        public OrderItem()
        {

        }
        public OrderItem(Product item, int quanity)
        {
            this.sItem = item;
            this.sQuantity = quanity;
        }
        ~OrderItem() { }
        //method
        //Tổng tiền sp order
        public decimal TotalPrice()
        {
            if (sItem == null) return 0;
            return sItem.Price * this.sQuantity;
        }
        public void Increase(int add = 1)
        {
            Quantity += add;
        }
        public void Decrease(int de = 1)
        {
            Quantity = Math.Max(0, Quantity - de);
        }
        public void PrintItem()
        {
            Console.WriteLine($"{Item?.Name} x{Quantity} = {TotalPrice()}đ");
        }
        public static bool operator >(OrderItem a, OrderItem b)
        {
            return a.Quantity > b.Quantity;
        }

        public static bool operator <(OrderItem a, OrderItem b)
        {
            return a.Quantity < b.Quantity;
        }
    }
}
