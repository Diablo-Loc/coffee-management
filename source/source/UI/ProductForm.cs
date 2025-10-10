using source.Models;
using source.Models.Catalog;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace source.UI
{
    public partial class ProductForm : Form
    {
        public Product NewProduct { get; private set; }

        public ProductForm()
        {
            InitializeComponent();

            // Khởi tạo danh mục
            comboBoxcategory.Items.AddRange(new string[] { "Choose category", "Drink", "Food", "Dessert" });
            comboBoxcategory.SelectedIndex = 0;
            comboBoxcategory.DropDownStyle = ComboBoxStyle.DropDownList;
           
            // Gắn sự kiện thay đổi loại món
            comboBoxcategory.SelectedIndexChanged += comboBoxcategory_SelectedIndexChanged;

            // Ẩn panel ban đầu
            UpdatePanels();
        }

        private void comboBoxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }
        public ProductForm(Product itemToEdit) : this()
        {

            txtname.Text = itemToEdit.Name;
            txtprice.Text = itemToEdit.Price.ToString();
            txtdescription.Text = itemToEdit.Description;
            comboBoxcategory.SelectedItem = itemToEdit.Category;

            switch (itemToEdit)
            {
                case Drink d:
                    cbSize.SelectedItem = d.Size;
                    cbTemp.SelectedItem = d.IsHot ? "Hot" : "Cold";
                    break;

                case Food f:
                    cbDiet.SelectedItem = f.IsVegetarian ? "Vegetarian" : "Normal";
                    txtTopping.Text = f.Topping;
                    break;

                case Dessert ds:
                    cbTemp1.SelectedItem = ds.IsCold ? "Cold" : "Hot";
                    txtFlavor.Text = ds.Flavor;
                    txtDecoration.Text = ds.Decoration;
                    break;
            }

            UpdatePanels(); // Hiện đúng panel
        }
        private void UpdatePanels()
        {
            string selected = comboBoxcategory.SelectedItem?.ToString();

            pnlDrink.Visible = selected == "Drink";
            pnlFood.Visible = selected == "Food";
            pnlDessert.Visible = selected == "Dessert";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string description = txtdescription.Text.Trim();
            string selected = comboBoxcategory.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên món không được để trống!");
                return;
            }

            if (!decimal.TryParse(txtprice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Giá phải là số hợp lệ và lớn hơn 0!");
                return;
            }

            if (comboBoxcategory.SelectedIndex == 0 || string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Vui lòng chọn loại món!");
                return;
            }

            try
            {
                switch (selected)
                {
                    case "Drink":
                        string size = cbSize.SelectedItem?.ToString();
                        bool isHot = cbTemp.SelectedItem?.ToString() == "Hot";
                        NewProduct = new Drink(size, isHot, name, price, description);
                        break;

                    case "Food":
                        bool isVegetarian = cbDiet.SelectedItem?.ToString() == "Vegetarian";
                        string topping = txtTopping.Text.Trim();
                        NewProduct = new Food(isVegetarian, topping, name, price, description);
                        break;

                    case "Dessert":
                        bool isCold = cbTemp.SelectedItem?.ToString() == "Cold";
                        string flavor = txtFlavor.Text.Trim();
                        string decoration = txtDecoration.Text.Trim();
                        NewProduct = new Dessert(isCold, flavor, decoration, name, price, description);
                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ cho loại món đã chọn.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}