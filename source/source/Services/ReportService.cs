using source.Data;
using source.Models;
using source.Models.Catalog;
using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Services
{
    public class ReportService
    {
        private readonly OrderRepository orderRepo = new OrderRepository();
        public Report TotalComprehensiveReport()
        {
            var allOrders = orderRepo.GetAllOrders();
            var report = new Report();

            if (allOrders == null || !allOrders.Any())
            {
                return report;
            }

            report.TotalOrders = allOrders.Count;
            var allItems = allOrders.SelectMany(order => order.Items).ToList();
            report.AllItems = allItems;
            report.TotalRevenue = allItems.Sum(item => item.TotalPrice());

            if (allItems.Any())
            {
                var groupedItems = new Dictionary<string, OrderItem>();
                foreach (var item in allItems)
                {
                    string name = item.Item.Name;
                    if (groupedItems.ContainsKey(name))
                    {
                        groupedItems[name].Quantity += item.Quantity;
                    }
                    else
                    {
                        groupedItems[name] = new OrderItem(item.Item, item.Quantity);
                    }
                }
                // Logic tìm món bán chạy nhất (GetBestSeller)
                var best = groupedItems.Values.First();
                foreach (var item in groupedItems.Values)
                {
                    if (item > best)
                    {
                        best = item;
                    }
                }
                report.BestSeller = best;

                // Logic sắp xếp và lấy top 3 (GetTopSellingItems)
                var sortedList = groupedItems.Values.ToList();
                // Dùng vòng lặp sort
                sortedList.Sort((item1, item2) => item2.Quantity.CompareTo(item1.Quantity)); 
                report.TopSelling = sortedList.Take(3).ToList();
            }
            
            return report;
        }
        public Dictionary<string, int> ChartData(Report report)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            if (report?.AllItems == null) return count;
            foreach (var item in report.AllItems)
            {
                string name = item.Item.Name;
                if (count.ContainsKey(name))
                    count[name] += item.Quantity;
                else
                    count[name] = item.Quantity;
            }
            return count;
        }
        public void PrintReportToConsole(Report report)
        {
            if (report == null)
            {
                Console.WriteLine("Không có dữ liệu để tạo báo cáo.");
                return;
            }
            Console.WriteLine("========== BÁO CÁO KINH DOANH ==========");
            Console.WriteLine(report.ToString());
            Console.WriteLine("========================================");
        }
    }
}
