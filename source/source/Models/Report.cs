using source.Models.Catalog;
using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
   public class Report : EntityBase
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
        public OrderItem BestSeller { get; set; }
        public List<OrderItem> TopSelling { get; set; }
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
           
        }
        public void Xuat()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Ngày báo cáo: {ReportDate:dd/MM/yyyy}");
            builder.AppendLine($"Tổng đơn hàng: {TotalOrders}");
            builder.AppendLine($"Tổng doanh thu: {TotalRevenue:N0} VND");

            if (BestSeller != null)
            {
                builder.AppendLine($"Bán chạy nhất: {BestSeller.Item.Name} ({BestSeller.Quantity} món)");
            }
            Console.WriteLine(builder.ToString());
        }
    }
}