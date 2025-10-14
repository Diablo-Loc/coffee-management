using ScottPlot;
using ScottPlot.Colormaps;
using source.Data;
using source.Models;
using source.Models.OrderModel;
using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source.UI
{
    public partial class ReportForm : Form
    {
        private Report report;
        public ReportForm()
        {
            InitializeComponent(); 
            GenerateClassReport();
            LoadReportData();
            RenderChart();
        }
        private void GenerateClassReport()
        {
            var repo = new OrderRepository();
            var orders = repo.GetAllOrders();
            report = new Report();
            report.Generate(orders);
        }
        private void LoadReportData()
        {
            // Tổng đơn hàng
            textBox_TotalOrder.Text = report.TotalOrders.ToString();

            // Doanh thu
            label5.Text = $"Revenue: {report.TotalRevenue:N0}đ";

            // Món bán chạy nhất
            var best = report.GetBestSeller();
            if (best != null)
            {
                textBox_BestSellerName.Text = best.Item.Name;
                Textbox_BestSellerQuantity.Text = best.Quantity.ToString();
            }

            // Top 3 món bán chạy
            var top3 = report.GetTopSellingItems(3);
            lbl_BestSellingRank1.Text = top3.Count > 0 ? $"1. {top3[0].Item.Name}: {top3[0].Quantity}" : "1. None: 0";
            lbl_BestSellingRank2.Text = top3.Count > 1 ? $"2. {top3[1].Item.Name}: {top3[1].Quantity}" : "2. None: 0";
            lbl_BestSellingRank3.Text = top3.Count > 2 ? $"3. {top3[2].Item.Name}: {top3[2].Quantity}" : "3. None: 0";
        }

      
        private void RenderChart()
        {
            // Đếm số lượng món ăn
            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (OrderItem item in report.AllItems)
            {
                string name = item.Item.Name;
                if (counter.ContainsKey(name))
                    counter[name] += item.Quantity;
                else
                    counter[name] = item.Quantity;
            }

            // Dữ liệu
            string[] labels = counter.Keys.ToArray();
            double[] values = counter.Values.Select(v => (double)v).ToArray();

            // Xóa biểu đồ cũ
            formsPlot1.Plot.Clear();

            // Thêm biểu đồ cột
            var bars = formsPlot1.Plot.Add.Bars(values);

            // Màu ngẫu nhiên cho từng cột (ScottPlot 5)
            var palette = new ScottPlot.Palettes.Category10();
            for (int i = 0; i < bars.Bars.Count; i++)
                bars.Bars[i].FillColor = palette.GetColor(i);

            // Hiển thị số lượng trên đầu cột
            foreach (var bar in bars.Bars)
            {
                bar.Label = bar.Value.ToString("0");
            }

            // Nhãn trục X
         
            var tickPositions = Enumerable.Range(0, labels.Length).Select(i => (double)i).ToArray();
            var tickLabels = labels;
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                tickPositions.Zip(tickLabels, (pos, label) => new ScottPlot.Tick(pos, label)).ToArray()
            );

            // Tiêu đề và nhãn trục
            formsPlot1.Plot.Title("Thống kê món ăn bán ra");

            formsPlot1.Plot.Axes.Bottom.Label.Text = "Tên món";
            formsPlot1.Plot.Axes.Bottom.Label.FontSize = 16;
            formsPlot1.Plot.Axes.Bottom.Label.Bold = true;

            formsPlot1.Plot.Axes.Left.Label.Text = "Số lượng";
            formsPlot1.Plot.Axes.Left.Label.FontSize = 16;
            formsPlot1.Plot.Axes.Left.Label.Bold = true;

            // Giới hạn trục Y
            double max = values.Length > 0 ? values.Max() : 1;
            formsPlot1.Plot.Axes.SetLimitsY(0, max + 1);

            // Làm mới hiển thị
            formsPlot1.Refresh();
          
        }
        private void btnResetReport_Click(object sender, EventArgs e)
        {
            report = new Report(); 
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();

            textBox_TotalOrder.Text = "0";
            label5.Text = "Revenue: 0đ";
            textBox_BestSellerName.Text = "None";
            Textbox_BestSellerQuantity.Text = "0";
            lbl_BestSellingRank1.Text = "1. None: 0";
            lbl_BestSellingRank2.Text = "2. None: 0";
            lbl_BestSellingRank3.Text = "3. None: 0";
        }

    }

}
