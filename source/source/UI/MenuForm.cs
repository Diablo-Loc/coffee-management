using source.Data;
using source.Models;
using source.Models.Catalog;
using source.Services;
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
        private ProductService service = new ProductService();
        private List<Product> currentList = new List<Product>();

        public MenuForm()
        {
            InitializeComponent();

            // Khởi tạo danh mục
            comboBox.Items.Clear();
            comboBox.Items.Add("All");
            foreach (var category in service.GetCategories())
            {
                comboBox.Items.Add(category);
            }
            comboBox.SelectedIndex = 0;

            // Hiển thị danh sách ban đầu
            LoadMenuToGrid(service.GetAll());

            // Tìm kiếm
            btnsearch.Click += (s, e) =>
            {
                string keyword = txtsearch.Text.ToLower();
                var filtered = service.Search(keyword);
                LoadMenuToGrid(filtered);
            };

            // Lọc theo danh mục
            comboBox.SelectedIndexChanged += (s, e) =>
            {
                string selected = comboBox.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selected) || selected == "All")
                {
                    LoadMenuToGrid(service.GetAll());
                }
                else
                {
                    var filtered = service.GetAll().FindAll(p => p.Category == selected);
                    LoadMenuToGrid(filtered);
                }
            };

            // Thêm món
            btnadd.Click += (s, e) =>
            {
                var form = new ProductForm(); // Form mới dùng Product
                if (form.ShowDialog() == DialogResult.OK)
                {
                    service.Add(form.NewProduct);
                    LoadMenuToGrid(service.GetAll());
                }
            };

            // Sửa món
            btnedit.Click += (s, e) =>
            {
                if (dgvMenu.SelectedRows.Count > 0)
                {
                    int index = dgvMenu.SelectedRows[0].Index;
                    Product selected = currentList[index];
                    var form = new ProductForm(selected);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        service.Update(selected, form.NewProduct);
                        LoadMenuToGrid(service.GetAll());
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn món để sửa.");
                }
            };

            // Xóa món
            btndelete.Click += (s, e) =>
            {
                if (dgvMenu.SelectedRows.Count > 0)
                {
                    int index = dgvMenu.SelectedRows[0].Index;
                    Product selected = currentList[index];
                    var result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        service.Delete(selected);
                        LoadMenuToGrid(service.GetAll());
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn món để xóa.");
                }
            };
        }

        private void LoadMenuToGrid(List<Product> items)
        {
            currentList = items;
            dgvMenu.Rows.Clear();
            dgvMenu.Columns.Clear();

            // Tạo cột
            dgvMenu.Columns.Add("Name", "Tên món");
            dgvMenu.Columns.Add("Price", "Giá");
            dgvMenu.Columns.Add("Category", "Loại");
            dgvMenu.Columns.Add("Description", "Mô tả");
            dgvMenu.Columns.Add("Size", "Size");
            dgvMenu.Columns.Add("IsHot", "Nóng?");
            dgvMenu.Columns.Add("IsVegetarian", "Chay?");
            dgvMenu.Columns.Add("Topping", "Topping");
            dgvMenu.Columns.Add("IsCold", "Lạnh?");
            dgvMenu.Columns.Add("Flavor", "Hương vị");
            dgvMenu.Columns.Add("Decoration", "Trang trí");

            foreach (var item in items)
            {
                var vm = ToViewModel(item);
                dgvMenu.Rows.Add(
                    vm.Name,
                    vm.Price.ToString("N0") + " VND",
                    vm.Category,
                    vm.Description,
                    vm.Size,
                    vm.IsHot?.ToString(),
                    vm.IsVegetarian?.ToString(),
                    vm.Topping,
                    vm.IsCold?.ToString(),
                    vm.Flavor,
                    vm.Decoration
                );
            }
        }
        public class ProductViewModel
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }

            public string Size { get; set; }
            public bool? IsHot { get; set; }
            public bool? IsVegetarian { get; set; }
            public string Topping { get; set; }
            public bool? IsCold { get; set; }
            public string Flavor { get; set; }
            public string Decoration { get; set; }
        }
        private ProductViewModel ToViewModel(Product p)
        {
            var vm = new ProductViewModel
            {
                Name = p.Name,
                Price = p.Price,
                Category = p.Category,
                Description = p.Description
            };

            if (p is Drink d)
            {
                vm.Size = d.Size;
                vm.IsHot = d.IsHot;
            }
            else if (p is Food f)
            {
                vm.IsVegetarian = f.IsVegetarian;
                vm.Topping = f.Topping;
            }
            else if (p is Dessert ds)
            {
                vm.IsCold = ds.IsCold;
                vm.Flavor = ds.Flavor;
                vm.Decoration = ds.Decoration;
            }

            return vm;
        }
    }
}

