using source.Models.Catalog;
using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class Report : EntityBase
    {
        private DateTime _ReportDate;
        private decimal _TotalRevenue;
        private int _TotalOrders;
        private List<OrderItem> _AllItems;

        public DateTime ReportDate
        {
            get { return this._ReportDate; }
            set { this._ReportDate = value; }
        }

        public decimal TotalRevenue
        {
            get { return this._TotalRevenue; }
            set { this._TotalRevenue = value; }
        }

        public int TotalOrders
        {
            get { return this._TotalOrders; }
            set { this._TotalOrders = value; }
        }

        public List<OrderItem> AllItems
        {
            get { return this._AllItems; }
            set { this._AllItems = value; }
        }

        public Report() : base(0)
        {
            _ReportDate = DateTime.Now;
            _TotalRevenue = 0;
            _TotalOrders = 0;
            _AllItems = new List<OrderItem>();
        }

        public Report(int id, DateTime reportDate, decimal totalRevenue, int totalOrders) : base(id)
        {
            _ReportDate = reportDate;
            _TotalRevenue = totalRevenue;
            _TotalOrders = totalOrders;
            _AllItems = new List<OrderItem>();
        }

        ~Report()
        {
            // Finalizer nếu cần giải phóng tài nguyên
        }

        public void Generate(List<Order> orders)
        {
            if (orders == null || orders.Count == 0) return;

            _TotalOrders = orders.Count;
            _TotalRevenue = 0;
            _AllItems.Clear();

            foreach (var order in orders)
            {
                foreach (var item in order.Items)
                {
                    _TotalRevenue += item.Item.Price * item.Quantity;
                    _AllItems.Add(item);
                }
            }
        }

        public OrderItem GetBestSeller()
        {
            if (_AllItems.Count == 0) return null;

            List<string> names = new List<string>();
            List<int> quantities = new List<int>();
            List<Product> products = new List<Product>();

            // Gom nhóm theo tên món
            foreach (OrderItem item in _AllItems)
            {
                string name = item.Item.Name;
                int index = names.IndexOf(name);

                if (index >= 0)
                {
                    quantities[index] += item.Quantity;
                }
                else
                {
                    names.Add(name);
                    quantities.Add(item.Quantity);
                    products.Add(item.Item);
                }
            }

            // Tìm món có số lượng lớn nhất
            int maxIndex = -1;
            int maxQty = -1;
            for (int i = 0; i < quantities.Count; i++)
            {
                if (quantities[i] > maxQty)
                {
                    maxQty = quantities[i];
                    maxIndex = i;
                }
            }

            if (maxIndex >= 0)
                return new OrderItem(products[maxIndex], quantities[maxIndex]);

            return null;
        }

        public OrderItem GetLeastSeller()
        {
            if (_AllItems.Count == 0) return null;

            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (OrderItem item in _AllItems)
            {
                string name = item.Item.Name;
                if (counter.ContainsKey(name))
                    counter[name] += item.Quantity;
                else
                    counter[name] = item.Quantity;
            }

            string leastName = null;
            int minQty = int.MaxValue;
            foreach (KeyValuePair<string, int> pair in counter)
            {
                if (pair.Value < minQty)
                {
                    leastName = pair.Key;
                    minQty = pair.Value;
                }
            }

            return _AllItems.Find(i => i.Item.Name == leastName);
        }
        public List<OrderItem> GetTopSellingItems(int count)
        {
            List<OrderItem> result = new List<OrderItem>();
            List<string> names = new List<string>();
            List<int> quantities = new List<int>();
            List<Product> products = new List<Product>();

            // Gom nhóm theo tên món
            foreach (OrderItem item in _AllItems)
            {
                string name = item.Item.Name;
                int index = names.IndexOf(name);

                if (index >= 0)
                {
                    quantities[index] += item.Quantity;
                }
                else
                {
                    names.Add(name);
                    quantities.Add(item.Quantity);
                    products.Add(item.Item);
                }
            }

            // Sắp xếp theo số lượng giảm dần
            for (int i = 0; i < quantities.Count - 1; i++)
            {
                for (int j = i + 1; j < quantities.Count; j++)
                {
                    if (quantities[j] > quantities[i])
                    {
                        // Đổi chỗ
                        int tempQty = quantities[i];
                        quantities[i] = quantities[j];
                        quantities[j] = tempQty;

                        string tempName = names[i];
                        names[i] = names[j];
                        names[j] = tempName;

                        Product tempProd = products[i];
                        products[i] = products[j];
                        products[j] = tempProd;
                    }
                }
            }

            // Lấy top N
            for (int i = 0; i < count && i < names.Count; i++)
            {
                result.Add(new OrderItem(products[i], quantities[i]));
            }

            return result;
        }

        public void Xuat()
        {
            Console.WriteLine("Ngày báo cáo: " + _ReportDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Tổng đơn hàng: " + _TotalOrders);
            Console.WriteLine("Tổng doanh thu: " + _TotalRevenue.ToString("C"));

            OrderItem best = GetBestSeller();


            if (best != null)
                Console.WriteLine("Bán chạy nhất: " + best.Item.Name + " (" + best.Quantity + " món)");


        }
    }
}