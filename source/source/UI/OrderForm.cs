using source.Data;
using source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using source.Models.Catalog;
using source.Models.PersonModel;
using source.Models.OrderModel;


namespace source.UI
{
    public partial class OrderForm : Form
    {
        private List<Product> menuList = new List<Product>();
        private Order currentOrder = new Order();
        private ProductRepository productRepo = new ProductRepository();
        private OrderRepository orderRepo = new OrderRepository();
        private List<(int Number, string Status, int GuestCount, decimal Total)> tableData = new();
        public OrderForm()
        {
            InitializeComponent();
            TaoBan();
            LaytuDataBase();
            RefreshAllTables();
            GenerateTables();
            LoadMenu();   
        }

        private void TaoBan()
        {
            cbtablenumber.Items.Clear();
            tableData = new List<(int Number, string Status, int GuestCount, decimal Total)>();

            for (int i = 1; i <= 20; i++)
            {
                tableData.Add((i, "Free", 0, 0));
                cbtablenumber.Items.Add($"Table {i}");

            }

            pnlTableTemplate.Visible = false;
            GenerateTables();
        }
        
        private void LaytuDataBase()
        {
            if (!File.Exists("Menu.db"))
                productRepo.CreateTable();

            orderRepo.CreateTables();
        }
        private void RefreshAllTables()
        {
            // Reset tất cả bàn về trạng thái Free
            for (int i = 0; i < tableData.Count; i++)
            {
                tableData[i] = (tableData[i].Number, "Free", 0, 0);
            }

            // Lấy tất cả đơn từ DB
            var orders = orderRepo.GetAllActiveOrders();

            foreach (var order in orders)
            {
                int index = tableData.FindIndex(t => t.Number == order.TableNumber);
                if (index >= 0)
                {
                    tableData[index] = (
                        order.TableNumber,
                        "Occupied",
                        order.GuestCount,
                        order.Total()
                    );
                }
            }
            
            GenerateTables(); // render lại bàn
        }
        
        
        private void LoadMenu()
        {
            var rawMenu = productRepo.GetAllRaw(); // trả về List<(string, decimal, string)>
            menuList = productRepo.GetAllProducts() ?? new List<Product>();
            LoadMenuToGrid(menuList);
        }
        private void GenerateTables()
        {
            flpTables.Controls.Clear();

            foreach (var table in tableData)
            {
                Panel newTable = new Panel
                {
                    Size = pnlTableTemplate.Size,
                    BackColor = GetColorByStatus(table.Status),
                    Margin = new Padding(10),
                    Tag = table.Number
                };

                foreach (Control ctrl in pnlTableTemplate.Controls)
                {
                    Label label = new Label
                    {
                        Size = ctrl.Size,
                        Location = ctrl.Location,
                        Font = ctrl.Font,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    switch (ctrl.Name)
                    {
                        case "lblTableName":
                            label.Text = $"Table {table.Number}";
                            break;
                        case "lblStatus":
                            label.Text = table.Status == "Occupied" ? "Serving" : "Empty";
                            break;
                        case "lblGuest":
                            label.Text = $"Guest: {table.GuestCount}";
                            break;
                        case "lblTotal":
                            label.Text = $"Total: {table.Total:N0} VND";
                            break;
                    }

                    label.Click += Table_Click;
                    newTable.Controls.Add(label);
                }

                newTable.Click += Table_Click;
                flpTables.Controls.Add(newTable);
            }
        }
        private Color GetColorByStatus(string status)
        {
            return status == "Occupied" ? Color.LightSalmon : Color.LightGreen;
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Control clicked = sender as Control;
            Panel panel = clicked is Panel ? (Panel)clicked : (Panel)clicked?.Parent;
            if (panel == null) return;

            int tableNumber = (int)panel.Tag;

            // Khôi phục đơn hàng từ database
            currentOrder = orderRepo.GetFullOrderByTable(tableNumber);

            lblTableName.Text = $"Table {tableNumber}";
            if (tableNumber - 1 >= 0 && tableNumber - 1 < cbtablenumber.Items.Count)
            {
                cbtablenumber.SelectedIndex = tableNumber - 1;
            }
            else
            {
                cbtablenumber.SelectedIndex = -1; // hoặc không gán gì cả
            }

            if (currentOrder != null)
            {
                lblOrderDate.Text = $"Date: {currentOrder.CreatedAt:dd/MM/yyyy HH:mm}";
                numericUpDownguest.Value = currentOrder.GuestCount;
            }
            else
            {
                lblOrderDate.Text = "Date: ---";
                numericUpDownguest.Value = 0;
                currentOrder = new Order
                {
                    TableNumber = tableNumber,
                    CreatedAt = DateTime.Now,
                    GuestCount = 0
                };
            }

            LoadOrder(); // cập nhật dgvOrder
        }

        private void LoadOrder()
        {
            dgvorder.Rows.Clear();

            if (currentOrder != null)
            {
                foreach (var item in currentOrder.Items)
                {
                    string itemName = item.Item.Name;
                    int quantity = item.Quantity;
                    decimal price = item.Item.Price;
                    decimal itemTotal = item.TotalPrice();

                    dgvorder.Rows.Add(
                        itemName,
                        quantity,
                        price.ToString("N0") + " VND",
                        itemTotal.ToString("N0") + " VND"
                    );
                }

                decimal totalPrice = currentOrder.Total();
                lblTotal.Text = $"Total: {totalPrice:N0} VND";
                lblOrderTotal.Text = $"Total: {totalPrice:N0} VND";
            }
            else
            {
                lblTotal.Text = "Total: 0 VND";
                lblOrderTotal.Text = "Total: 0 VND";
            }
        }
        private void LoadMenuToGrid(List<Product> items)
        {
            dgvmenu.Rows.Clear();
            foreach (var item in items)
            {
                dgvmenu.Rows.Add(item.Category, item.Name, item.Price.ToString("N0") + " VND");
            }
        }

        //method định dạng tiền, để lấy dữ liệu mà tính toán
        public static class ChangeIntoRawMoney
        {
            public static decimal Clean(string raw)
            {
                if (string.IsNullOrWhiteSpace(raw))
                    return 0;

                string cleaned = raw.Replace("đ", "")
                                    .Replace("VND", "")
                                    .Replace("VD", "")
                                    .Replace(",", "")
                                    .Replace(".", "")
                                    .Trim();

                return decimal.TryParse(cleaned, out decimal result) ? result : 0;
            }
        }
        
        private void dgvmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((int)numericUpDownguest.Value < 1)
            {
                MessageBox.Show("Vui lòng nhập số khách trước khi chọn món.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvmenu.Rows[e.RowIndex];

                string category = row.Cells[0].Value?.ToString() ?? "";
                string name = row.Cells[1].Value?.ToString() ?? "";
                string rawPrice = row.Cells[2].Value?.ToString() ?? "";

                decimal price = ChangeIntoRawMoney.Clean(rawPrice);

                QuantityForm qtyForm = new QuantityForm();
                if (qtyForm.ShowDialog() != DialogResult.OK)
                    return;

                int quantity = qtyForm.SelectedQuantity;

                Product product = category switch
                {
                    "Drink" => new Drink("Vừa", false, name, price, ""),
                    "Food" => new Food(true," ",name, price, ""),
                    "Dessert" => new Dessert(true,"","",name, price, ""),
                    _ => throw new Exception("Loại món không hợp lệ")
                };

                if (currentOrder == null)
                {
                    currentOrder = new Order
                    {
                        GuestCount = (int)numericUpDownguest.Value,
                        TableNumber = cbtablenumber.SelectedIndex + 1,
                        CreatedAt = DateTime.Now
                    };
                }

                currentOrder.AddItem(product, quantity);
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món vào đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        private void btncreate_Click(object sender, EventArgs e)
        {
            if (currentOrder == null || !currentOrder.Items.Any())
            {
                MessageBox.Show("Vui lòng thêm món trước khi xác nhận đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentOrder.Id > 0)
            {
                var result = MessageBox.Show(
                    "Đơn hàng đã tồn tại. Bạn có muốn cập nhật đơn này không?",
                    "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("Đơn hàng không được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            currentOrder.GuestCount = (int)numericUpDownguest.Value;
            orderRepo.Save(currentOrder);
            int index = tableData.FindIndex(t => t.Number == currentOrder.TableNumber);
            if (index >= 0)
            {
                tableData[index] = (
                    currentOrder.TableNumber,
                    "Occupied",
                    currentOrder.GuestCount,
                    currentOrder.Total()
                );
            }
            
            MessageBox.Show("Đơn hàng đã được lưu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LoadOrder();
            GenerateTables();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvorder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            string itemName = dgvorder.SelectedRows[0].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(itemName)) return;

            var itemToRemove = currentOrder.Items.FirstOrDefault(i => i.Item.Name == itemName);
            if (itemToRemove != null)
            {
                currentOrder.RemoveItem(itemToRemove);
                LoadOrder();
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
       



        private void DeleteOrder(int orderId)           // Xóa đơn hàng khỏi database
        {
            using (var conn = new SQLiteConnection("Data Source=Order.db;Version=3;"))
            {
                conn.Open();

                string deleteItems = "DELETE FROM OrderItems WHERE OrderId = @id";
                string deleteOrder = "DELETE FROM Orders WHERE Id = @id";

                var cmd1 = new SQLiteCommand(deleteItems, conn);
                cmd1.Parameters.AddWithValue("@id", orderId);
                cmd1.ExecuteNonQuery();

                var cmd2 = new SQLiteCommand(deleteOrder, conn);
                cmd2.Parameters.AddWithValue("@id", orderId);
                cmd2.ExecuteNonQuery();
            }
        }

        private void btnPrintBill_DeleteOrder()
        {
            // 1. Kiểm tra đơn hàng hợp lệ
            if (currentOrder == null || !currentOrder.Items.Any() || currentOrder.Id <= 0)
            {
                MessageBox.Show("Không có đơn hàng hoạt động để in và thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hiển thị hóa đơn
            var bill = new Bill(currentOrder);
            var billForm = new BillForm(bill);
            billForm.ShowDialog();

            // 3. Xóa đơn khỏi database
            int tableNumber = currentOrder.TableNumber;
            orderRepo.Delete(currentOrder.Id);

            // 4. Cập nhật trạng thái bàn thành Free
            int index = tableData.FindIndex(t => t.Number == tableNumber);
            if (index >= 0)
            {
                tableData[index] = (tableNumber, "Free", 0, 0);
            }

            RefreshAllTables();

            // 5. Reset đơn hàng và giao diện
            currentOrder = new Order
            {
                TableNumber = tableNumber,
                CreatedAt = DateTime.Now,
                GuestCount = 0
            };

            lblTableName.Text = $"Table ---";
            lblOrderDate.Text = "Date: ---";
            numericUpDownguest.Value = 0;
            cbtablenumber.SelectedIndex = -1;

            LoadOrder(); // 👉 xóa món khỏi bảng
            MessageBox.Show($"Thanh toán và xóa đơn hàng bàn {tableNumber} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnprint_Click(object sender, EventArgs e) // Sự kiện in hóa đơn và xóa đơn hàng
        {
            btnPrintBill_DeleteOrder();
        }
        
    }
}
