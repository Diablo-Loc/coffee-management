using source.Data;
using source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source.UI
{
    public partial class MenuForm : Form
    {
        private List<MenuItem> menuList = new List<MenuItem>();
        private MenuItemInSQLite repo = new MenuItemInSQLite();

        public MenuForm()
        {
            InitializeComponent();

            // Khởi tạo database
            repo.CreateTable();
            menuList = repo.GetAll();
            comboBox.Items.Clear();
            comboBox.Items.Add("All");

            var categories = menuList.Select(item => item.Category).Distinct();
            foreach (var category in categories)
            {
                comboBox.Items.Add(category);
            }

            comboBox.SelectedIndex = 0;
            // Hiển thị dữ liệu ban đầu
            LoadMenuToGrid(menuList);

            // Sự kiện tìm kiếm
            btnsearch.Click += (s, e) =>
            {
                string keyword = txtsearch.Text.ToLower();
                var filtered = repo.Search(keyword);
                LoadMenuToGrid(filtered);
            };

            // Sự kiện lọc theo danh mục
            comboBox.SelectedIndexChanged += (s, e) =>
            {
                string selected = comboBox.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selected) || selected == "All")
                {
                    LoadMenuToGrid(menuList);
                }
                else
                {
                    var filtered = menuList.FindAll(item => item.Category == selected);
                    LoadMenuToGrid(filtered);
                }
            };

            // Thêm món
            btnadd.Click += (s, e) =>
            {
                var form = new MenuItemForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repo.Add(form.NewItem);
                    menuList.Add(form.NewItem);
                    LoadMenuToGrid(menuList);
                }
            };

            // Sửa món
            btnedit.Click += (s, e) =>
            {
                if (dgvMenu.SelectedRows.Count > 0)
                {
                    int index = dgvMenu.SelectedRows[0].Index;
                    MenuItem selected = menuList[index];
                    var form = new MenuItemForm(selected);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        repo.Update(selected, form.NewItem);
                        menuList[index] = form.NewItem;
                        LoadMenuToGrid(menuList);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to edit.");
                }
            };

            // Xóa món(cần cải tiến do bị lỗi khi xóa dòng trắng cuối cùng)
            btndelete.Click += (s, e) =>
            {
                if (dgvMenu.SelectedRows.Count > 0)
                {
                    int index = dgvMenu.SelectedRows[0].Index;
                    var result = MessageBox.Show("Are you sure???", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        repo.Delete(menuList[index]);
                        menuList.RemoveAt(index);
                        LoadMenuToGrid(menuList);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.");
                }
            };
        }

        private void LoadMenuToGrid(List<MenuItem> items)
        {
            dgvMenu.Rows.Clear();
            foreach (var item in items)
            {
                dgvMenu.Rows.Add(item.Name, item.Price.ToString("N0") + "VND", item.Description);
            }
        }
    }
}
