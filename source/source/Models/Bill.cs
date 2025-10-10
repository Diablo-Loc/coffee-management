using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    public class Bill
    {
        private static int pIdCounter = 1; // auto tăng ID
        private int pID;
        private int pTableNumber;
        private DateTime pCreatedAt;
        private List<OrderItem> pItems;
        private decimal pTotalAmount;

        public int ID { get { return this.pID; } set { this.pID = value; } }
        public int TableNumber { get { return this.pTableNumber; } set { this.pTableNumber = value; } }
        public DateTime CreatedAt { get { return this.pCreatedAt; } set { this.pCreatedAt = value; } }
        public  List<OrderItem> Items { get { return this.pItems; } set { this.pItems = value; } }
        public decimal TotalAmount {get { return this.pTotalAmount; } set { this.pTotalAmount = value; } }

        public Bill(Order order)
        {

            pID = pIdCounter++;
            pTableNumber = order.TableNumber;
            pCreatedAt = DateTime.Now;
            pItems = new List<OrderItem>(order.Items);
            pTotalAmount = order.Total();
        }

        // In ra console
        public void PrintBillInConsole()
        {
            Console.WriteLine($"========= BILL #{pID} =========");
            Console.WriteLine($"Table: {pTableNumber}");
            Console.WriteLine($"Date: {pCreatedAt}");
            Console.WriteLine("----------------------------");

            foreach (var item in pItems)
            {
                Console.WriteLine($"{item.Item.Name} x{item.Quantity} = {item.TotalPrice()}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total: {pTotalAmount}");
            Console.WriteLine("============================");
        }
    }
}

