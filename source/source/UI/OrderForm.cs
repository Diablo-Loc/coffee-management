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


namespace source.UI
{
    public partial class OrderForm : Form
    {
        private TablesManagement tablesManager;
        private Table selectedTable;
        private MenuItemInSQLite menurepo = new MenuItemInSQLite();
        private OrderInSQLite orderrepo = new OrderInSQLite();
        private List<MenuItem> menuList = new List<MenuItem>();

        public OrderForm()
        {
            InitializeComponent();
            TaoBan();
            LaytuDataBase();
            RestoreTrangThaiDaLuu();
            GenerateTables();
            LoadTableComboBox();
            LoadMenu();
            
        }
        private void TaoBan()
        {
            tablesManager = new TablesManagement(20);
            pnlTableTemplate.Visible = false;
            GenerateTables();
        }
        private void LaytuDataBase()
        {
            if (!File.Exists("menu.db"))
                menurepo.CreateTable();

            orderrepo.CreateOrderTables();
        }
        private void RestoreTrangThaiDaLuu()
        {
            foreach (var table in tablesManager.Tables)
            {
                var order = orderrepo.GetFullOrderByTable(table.Number);
                if (order != null)
                {
                    table.CurrentOrder = order;
                    table.Status = TableStatus.Occupied;
                }
                else
                {
                    table.CurrentOrder = null;
                    table.Status = TableStatus.Free;
                }
            }
        }
        
        private void LoadTableComboBox()
        {
            cbtablenumber.Items.Clear();
            foreach (Table t in tablesManager.Tables)
            {
                cbtablenumber.Items.Add($"Table {t.Number}");
            }
        }
        private void LoadMenu()
        {
            menuList = menurepo.GetAll() ?? new List<MenuItem>();
            LoadMenuToGrid(menuList);
        }

        private void GenerateTables()
        {
            flpTables.Controls.Clear();

            foreach (Table table in tablesManager.Tables)
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
                    Label copy = new Label
                    {
                        Size = ctrl.Size,
                        Location = ctrl.Location,
                        Font = ctrl.Font,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    if (ctrl.Name == "lblTableName")
                        copy.Text = $"Table {table.Number}";
                    else if (ctrl.Name == "lblStatus")
                        copy.Text = table.Status == TableStatus.Occupied ? "Serving" : "Empty";
                    else if (ctrl.Name == "lblGuest")
                        copy.Text = $"Guest: {(table.CurrentOrder?.GuestCount ?? 0)}";
                    else if (ctrl.Name == "lblTotal")
                        copy.Text = $"Total: {(table.CurrentOrder != null ? table.CurrentOrder.Total().ToString("N0") : "0")} VND";

                    copy.Click += Table_Click;
                    newTable.Controls.Add(copy);
                }


                newTable.Click += Table_Click;
                flpTables.Controls.Add(newTable);
            }
        }

        private Color GetColorByStatus(TableStatus status)
        {
            return status switch
            {
                TableStatus.Free => Color.LightGreen,
                TableStatus.Occupied => Color.Orange,
                TableStatus.Reserved => Color.LightBlue,
                _ => Color.Gray
            };
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Control clicked = sender as Control;
            Panel panel = clicked is Panel ? (Panel)clicked : (Panel)clicked.Parent;
            if (panel == null) return;

            int tableNumber = (int)panel.Tag;
            selectedTable = tablesManager.GetTableByNumber(tableNumber);
            if (selectedTable == null) return;

            // Khôi phục đơn hàng đầy đủ từ database
            var restoredOrder = orderrepo.GetFullOrderByTable(tableNumber);
            selectedTable.CurrentOrder = restoredOrder;

            lblTableName.Text = $"Table {tableNumber}";
            cbtablenumber.SelectedItem = $"Table {tableNumber}";

            if (restoredOrder != null)
            {
                lblOrderDate.Text = $"Date: {restoredOrder.CreatedAt:dd/MM/yyyy HH:mm}";
                numericUpDownguest.Value = restoredOrder.GuestCount;
                selectedTable.Status = TableStatus.Occupied;
            }
            else
            {
                lblOrderDate.Text = "Date: ---";
                numericUpDownguest.Value = 0;
                selectedTable.Status = TableStatus.Free;
                selectedTable.CurrentOrder = new Order(tableNumber); // tạo đơn mới nếu chưa có
            }

            LoadOrder(selectedTable);
            GenerateTables();
        }

        private void LoadOrder(Table table)
        {
            dgvorder.Rows.Clear();
            if (table.CurrentOrder != null)
            {
                foreach (var item in table.CurrentOrder.OrderItem)
                {
                    string itemName = item.Item.Name;
                    int quantity = item.Quantity;
                    float price = (float)item.Item.Price;
                    float itemTotal = quantity * price;


                    dgvorder.Rows.Add(itemName, quantity, price.ToString("N0") + "VND", itemTotal.ToString("N0")+"VND");
                }
            }
            decimal totalPrice = table.CurrentOrder.Total();
            lblTotal.Text = $"Total: {totalPrice:N0} VND";
            lblOrderTotal.Text = $"Total: {totalPrice:N0} VND";
        }

        private void LoadMenuToGrid(List<MenuItem> items)
        {
            dgvmenu.Rows.Clear();
            foreach (var item in items)
            {
                dgvmenu.Rows.Add(item.Category, item.Name, item.Price.ToString("N0") + "VND");
            }
        }
        
        private void dgvmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((int)numericUpDownguest.Value < 1)
            {
                MessageBox.Show("Vui lòng nhập số khách trước khi chọn món.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvmenu.Rows[e.RowIndex];
                //lấy dữ liệu
                string category = row.Cells[0].Value?.ToString() ?? "";
                string name = row.Cells[1].Value?.ToString() ?? "";
                string rawPrice = row.Cells[2].Value?.ToString() ?? "";

                //làm sạch dữ liệu
                decimal price = ChangeIntoRawMoney.Clean(rawPrice);
                QuantityForm qtyForm = new QuantityForm();
                if (qtyForm.ShowDialog() != DialogResult.OK)
                    return;

                int quantity = qtyForm.SelectedQuantity;
                // Kiểm tra bàn đã được chọn chưa
                if (selectedTable == null)
                {
                    MessageBox.Show("Vui lòng chọn bàn trước khi thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo món và thêm vào đơn hàng
                MenuItem item = new MenuItem(name, price, category, "");


                if (selectedTable.CurrentOrder == null)
                {
                    selectedTable.CurrentOrder = new Order(selectedTable.Number);
                    selectedTable.CurrentOrder.GuestCount = (int)numericUpDownguest.Value;
                }


                selectedTable.CurrentOrder.AddItem(item, quantity);
                LoadOrder(selectedTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món vào đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (selectedTable == null || selectedTable.CurrentOrder == null)
            {
                MessageBox.Show("Vui lòng chọn bàn và thêm món trước khi xác nhận đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedTable.CurrentOrder.OrderId > 0)
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
            selectedTable.CurrentOrder.GuestCount = (int)numericUpDownguest.Value;
            orderrepo.SaveOrderToDatabase(selectedTable.CurrentOrder);
            selectedTable.Status = TableStatus.Occupied;

            MessageBox.Show("Đơn hàng đã được lưu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            selectedTable.CurrentOrder.RemoveItem(itemName);
            LoadOrder(selectedTable);
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
