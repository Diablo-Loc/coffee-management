using source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source.UI
{
    public partial class BillForm : Form
    {
        [DllImport("user32.dll")]       // Code này dùng để thực hiện cầm vào thanh tiêu đề và kéo thả form
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private Bill currentBill;

        public BillForm(Bill bill)
        {
            InitializeComponent();
            currentBill = bill; // giữ lại bill truyền từ ngoài vào
            LoadBillData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            LoadBillToUI();
        }

        private void LoadBillToUI()
        {
            // set thông tin bill
            lblBillID.Text = $"BILL #{currentBill.ID}";
            lblTable.Text = $"Table: {currentBill.TableNumber}";
            lblDate.Text = $"Date: {currentBill.CreatedAt}";
            lblTotal.Text = $"Total: {currentBill.TotalAmount}";

            // clear list trước khi load
            listViewItem.Items.Clear();

            // add item từ bill.Items
            foreach (var item in currentBill.Items)
            {
                var row = new ListViewItem(item.Item.Name); // cột 1: Tên món
                row.SubItems.Add(item.Quantity.ToString());  // cột 2: Số lượng
                row.SubItems.Add(item.Item.Price.ToString()); // cột 3: Đơn giá
                row.SubItems.Add(item.TotalPrice().ToString()); // cột 4: Thành tiền

                listViewItem.Items.Add(row);
            }
        }

        private void lblBillID_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)  // Sự kiện in
        {
            // Lấy graphics từ e
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 14);
            float lineHeight = font.GetHeight() + 5;
            float x = 50;
            float y = 50;

            // In Bill ID
            g.DrawString(lblBillID.Text, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight + 10;

            // In Table Number
            g.DrawString(lblTable.Text, font, Brushes.Black, x, y);
            y += lineHeight;

            // In Date
            g.DrawString(lblDate.Text, font, Brushes.Black, x, y);
            y += lineHeight + 10;

            // In các item trong ListView
            foreach (ListViewItem item in listViewItem.Items)
            {
                string line = $"{item.SubItems[0].Text} - {item.SubItems[1].Text} x {item.SubItems[2].Text} = {item.SubItems[3].Text}";
                g.DrawString(line, font, Brushes.Black, x, y);
                y += lineHeight;
            }

            y += 20;
            g.DrawString(lblTotal.Text, new Font("Arial", 16, FontStyle.Bold), Brushes.Red, x, y);
        }
        private void btnPrint_Click(object sender, EventArgs e) // Sự kiện nút in
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        // Cầm panel kéo thả form
        private void panelTitle_MouseDown(object sender, MouseEventArgs e) 
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void listViewItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTable_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
        private void LoadBillData()
        {
            lblBillID.Text = $"Bill #{currentBill.ID}";
            lblTable.Text = $"Table Number: {currentBill.TableNumber}";
            lblDate.Text = $"Date: {currentBill.CreatedAt:dd/MM/yyyy HH:mm}";
            lblTotal.Text = $"Total: {currentBill.TotalAmount:N0} VND";

            listViewItem.Items.Clear();
            foreach (var item in currentBill.Items)
            {
                var row = new ListViewItem(item.Item.Name);
                row.SubItems.Add(item.Item.Price.ToString("N0") + " VND");
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add(item.TotalPrice().ToString("N0") + " VND");
                listViewItem.Items.Add(row);
            }
        }

    }





}
