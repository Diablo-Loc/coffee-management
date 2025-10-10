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

        public DateTime ReportDate { get { return this._ReportDate; } set { this._ReportDate = value; } }
        public decimal TotalRevenue { get { return this._TotalRevenue; } set { this._TotalRevenue = value; } }
        public int TotalOrders { get { return this._TotalOrders; } set { this._TotalOrders = value; } }

        public Report() {
            ReportDate = DateTime.Now;
            TotalRevenue = 0;
            TotalOrders = 0;
        }
        public Report(int id, DateTime reportDate, decimal totalRevenue, int totalOrders) : base(id)
        {
            ReportDate = reportDate;
            TotalRevenue = totalRevenue;
            TotalOrders = totalOrders;
        }
        ~Report() { }

        public void Generate(List<Order> orders)
        {
            TotalOrders = orders.Count;

            foreach (var order in orders)
            {
                TotalRevenue += order.Total();
            }
        }

        // Xuất báo cáo ra console
        public void Xuat()
        {
           
        }
    }
}
