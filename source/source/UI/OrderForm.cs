using source.Models;
using source.Models.Catalog;
using source.Models.OrderModel;
using source.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static source.Common.MoneyHelper;

namespace source.UI
{
    public partial class OrderForm : Form
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly TableService _tableService = new TableService(20);

        private Order currentOrder; 
        private List<Product> menuList;

        public OrderForm()
        {
            InitializeComponent();
            InitializeDataAndUI(); 
        }
        private void InitializeDataAndUI()
        {
            menuList = _orderService.GetMenu();
            LoadMenuToGrid(menuList);
            SetupTableComboBox();
            RefreshAllTables();
        }

        private void RefreshAllTables()
        {
            var activeOrders = _orderService.GetActiveOrders();
            _tableService.UpdateTablesStatus(activeOrders);
            GenerateTables();
        }
        private void Table_Click(object sender, EventArgs e)
        {
            Control clicked = sender as Control;
            Panel panel = clicked is Panel ? (Panel)clicked : (Panel)clicked?.Parent;
            if (panel == null) return;
            int tableNumber = (int)panel.Tag;
            currentOrder = _orderService.GetOrCreateOrder(tableNumber);
            UpdateOrderDetailsPanel();
        }
        private void dgvmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (currentOrder == null)
                {
                    MessageBox.Show("Vui lòng chọn bàn trước khi thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (e.RowIndex < 0) return;
                string productName = dgvmenu.Rows[e.RowIndex].Cells[1].Value?.ToString();
                if (string.IsNullOrEmpty(productName)) return;

                using var qtyForm = new QuantityForm();
                if (qtyForm.ShowDialog() != DialogResult.OK) return;
                int quantity = qtyForm.SelectedQuantity;
                var productToAdd = menuList.FirstOrDefault(p => p.Name == productName);
                _orderService.AddItemToOrder(currentOrder, productToAdd, quantity);
                LoadOrderItemsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncreate_Click(object sender, EventArgs e) 
        {
            try
            {
                _orderService.SaveOrder(currentOrder, (int)numericUpDownguest.Value);
                MessageBox.Show("Lưu đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                Bill finalizedBill = _orderService.FinalizePaymentForOrder(currentOrder);
                using var billForm = new BillForm(finalizedBill);
                billForm.ShowDialog();
                MessageBox.Show($"Thanh toán cho bàn {currentOrder.TableNumber} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllTables();
                ResetOrderDetailsPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e) 
        {
            if (dgvorder.SelectedRows.Count == 0) return;
            string itemName = dgvorder.SelectedRows[0].Cells[0].Value?.ToString();

            _orderService.RemoveItemFromOrder(currentOrder, itemName);

            LoadOrderItemsToGrid(); 
        }
        private void GenerateTables()
        {
            flpTables.Controls.Clear();
            foreach (var table in _tableService.Tables)
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

        private void UpdateOrderDetailsPanel()
        {
            if (currentOrder == null) return;

            lblTableName.Text = $"Table {currentOrder.TableNumber}";
            cbtablenumber.SelectedIndex = currentOrder.TableNumber - 1;

            lblOrderDate.Text = currentOrder.Id > 0
                ? currentOrder.FormatDate()
                : "Date: ---"; 

            numericUpDownguest.Value = currentOrder.GuestCount > 0 ? currentOrder.GuestCount : 1;
            LoadOrderItemsToGrid();
        }

        private void ResetOrderDetailsPanel()
        {
            currentOrder = null;
            lblTableName.Text = "Table ---";
            lblOrderDate.Text = "Date: ---";
            numericUpDownguest.Value = 0;
            cbtablenumber.SelectedIndex = -1;
            dgvorder.Rows.Clear();
            lblTotal.Text = "Total: 0 VND";
            lblOrderTotal.Text = "Total: 0 VND";
        }

        private void LoadOrderItemsToGrid()
        {
            dgvorder.Rows.Clear();
            if (currentOrder != null)
            {
                foreach (var item in currentOrder.Items)
                {
                    dgvorder.Rows.Add(
                        item.Item.Name,
                        item.Quantity,
                        item.Item.Price.ToString("N0") + " VND",
                        item.TotalPrice().ToString("N0") + " VND"
                    );
                }
                decimal totalPrice = currentOrder.Total();
                lblTotal.Text = $"Total: {totalPrice:N0} VND";
                lblOrderTotal.Text = $"Total: {totalPrice:N0} VND";
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

        private void SetupTableComboBox()
        {
            cbtablenumber.Items.Clear();
            for (int i = 1; i <= 20; i++)
            {
                cbtablenumber.Items.Add($"Table {i}");
            }
        }

        private Color GetColorByStatus(string status)
        {
            return status == "Occupied" ? Color.LightSalmon : Color.LightGreen;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}