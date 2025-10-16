using source.Data;
using source.Models;
using source.Models.Catalog;
using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepo;
        private readonly ProductRepository _productRepo;
        public OrderService()
        {
            _productRepo = new ProductRepository();
            _orderRepo = new OrderRepository();
            if (!System.IO.File.Exists("Menu.db"))
                _productRepo.CreateTable();
            _orderRepo.CreateTables();
        }
        public List<Product> GetMenu()
        {
            return _productRepo.GetAllProducts() ?? new List<Product>();
        }
        public List<Order> GetActiveOrders()
        {
            return _orderRepo.GetAllActiveOrders();
        }
        public Order GetOrCreateOrder(int tableNumber)
        {
            var existingOrder = _orderRepo.GetFullOrderByTable(tableNumber);
            return new Order().PrepareOrder(existingOrder, tableNumber);
        }

        public Product CreateProduct(string category, string name, decimal price)
        {
            return category switch
            {
                "Drink" => Drink.Create(name, price),
                "Food" => Food.Create(name, price),
                "Dessert" => Dessert.Create(name, price),
                _ => throw new Exception("Invalid item type")
            };
        }
        public void AddItem(Order currentOrder, Product product, int quantity)
        {
            currentOrder.AddItem(product, quantity);
        }

        public void SaveOrder(Order order,int a)
        {
            order.Complete(a);
            _orderRepo.Save(order);
        }

        public void PayAndDelete(Order order)
        {
            _orderRepo.Delete(order.Id);
        }
        public void CompleteOrder(Order order,int a)
        {
            order.Status = "Completed";
            _orderRepo.Save(order);
        }
        public Bill FinalizePaymentForOrder(Order orderToPay)
        {
            if (orderToPay == null || !orderToPay.Items.Any() || orderToPay.Id <= 0)
            {
                throw new InvalidOperationException("Không có đơn hàng hợp lệ để thanh toán.");
            }
            var bill = new Bill(orderToPay);
            _orderRepo.Delete(orderToPay.Id);
            return bill;
        }
        public void AddItemToOrder(Order order, Product product, int quantity)
        {
            if (order == null)
                throw new Exception("Vui lòng chọn bàn trước khi thêm món.");

            if (product == null)
                throw new Exception("Sản phẩm không hợp lệ.");
            order.AddItem(product, quantity);
        }
        public void RemoveItemFromOrder(Order order, string itemName)
        {
            if (order == null)
            {
                return;
            }
            var itemToRemove = order.Items.FirstOrDefault(i => i.Item.Name == itemName);
            if (itemToRemove != null)
            {
                order.RemoveItem(itemToRemove);
            }
        }
    }
}
