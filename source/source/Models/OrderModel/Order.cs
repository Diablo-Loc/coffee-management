using source.Models.Catalog;
using source.Models.PersonModel;
using source.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.OrderModel
{
    public class Order : EntityBase
    {
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public Customer Buyer { get; set; }
        public Employee Staff { get; set; }
        public int TableNumber { get; set; }
        public int GuestCount { get; set; } = 0;
        public string Status { get; set; } = "New";
        public DateTime CreatedAtOrder { get; private set; }

        public Order()
        {
            CreatedAtOrder = DateTime.Now;
        }
        ~Order() { }
        public void AddItem(Product product, int quantity)
        {
            if (product == null || quantity <= 0) return;

            var existing = Items.FirstOrDefault(i => i.Item.Name == product.Name);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                Items.Add(new OrderItem(product, quantity));
            }

            Touch();
        }

        public void RemoveItem(OrderItem item)
        {
            if (item == null) return;
            Items.RemoveAll(i => i.Item.Name == item.Item.Name);
            Touch();
        }

        public decimal GetSubtotal()
        {
            return Items.Sum(i => i.TotalPrice());
        }

        public void ChangeStatus(string newStatus)
        {
            Status = newStatus;
            Touch();
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order {Id} - Table {TableNumber} - Status: {Status}");
            foreach (var it in Items) it.PrintItem();
            Console.WriteLine($"Subtotal: {GetSubtotal()}đ");
        }
        public decimal Total()
        {
            decimal total = 0;
            foreach (var i in Items)
            {
                total += i.TotalPrice();
            }
            return total;
        }
        
    }
}
