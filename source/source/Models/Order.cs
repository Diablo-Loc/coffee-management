using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    public class Order
    {
        private List<OrderItem> _orderItems;
        private DateTime _createdAt; // thời điểm tạo, book món đồ. Dùng kiểu dữ liệu có sẵn trong c#
        private int _tableNumber;
        private bool _isPaid; //trạng thái(đã trả chưa kiểu vậy)
        
        public int TableNumber 
        { 
            get { return _tableNumber; } 
            set {
                if (value <= 0) throw new ArgumentException("ERROR! Table number must be > 0!");
                _tableNumber = value; } 
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }
        public bool IsPaid
        {
            get { return _isPaid; }
            set { _isPaid=value; }
        }
         public List<OrderItem> OrderItem
        {
            get { return _orderItems; }
            set { _orderItems = value; }
        }
        public Order()
        {
            this._orderItems = new List<OrderItem>();
            _isPaid = false;
            _createdAt = DateTime.MinValue;
        }
        public Order(int tableNumber)
        {
            _tableNumber = tableNumber;
            _createdAt = DateTime.Now;
            _orderItems = new List<OrderItem>();
            _isPaid = false;
        }
        ~Order()
        {

        }
        //method
        //Thêm món trong order
        public void AddItem(MenuItem item, MenuItem quantity)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            //var orderItem = new OrderItem(item,quantity);
            //_orderItems.Add(orderItem);
        }
        //Xóa bớt món
        public void RemoveItem(MenuItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            var itemToRemove = _orderItems.FirstOrDefault(o => o.Item.Name == item.Name);
            if (itemToRemove != null)
                _orderItems.Remove(itemToRemove);
        }
        //cập nhật món
        public void UpdateItem(MenuItem updatedItem)
        {
            if (updatedItem == null)
                throw new ArgumentNullException(nameof(updatedItem));

            var itemToUpdate = _orderItems.FirstOrDefault(o => o.Item.Name == updatedItem.Name);
            if (itemToUpdate != null)
                itemToUpdate.Item = updatedItem;
        }
        //Tổng tiền
        public decimal Total()
        {
            decimal total = 0;
            foreach (var i in _orderItems)
            {
                total += i.TotalPrice();
            }
            return total;
        }
    }
}
