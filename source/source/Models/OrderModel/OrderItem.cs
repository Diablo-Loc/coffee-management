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
        private Product _Item;
        private int _Quantity;

        public Product Item
        {
            get { return _Item; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(Item));
                _Item = value;
            }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set
            {
                if (value <= 0) throw new ArgumentException("ERROR! Quantity must be > 0!");
                _Quantity = value;
            }
        }

        public OrderItem()
        {

        }
        public OrderItem(Product item, int quanity)
        {
            this._Item = item;
            this._Quantity = quanity;
        }
        ~OrderItem() { }
        //method
        //Tổng tiền sp order
        public decimal TotalPrice()
        {
            if (_Item == null) return 0;
            return _Item.Price * this._Quantity;
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
