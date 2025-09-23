using source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace source.UI
{
    public partial class MenuItemForm : Form
    {
        public MenuItemForm()
        {
            InitializeComponent();
            comboBoxcategory.Items.Add("Choose category");
            comboBoxcategory.Items.Add("Drink");
            comboBoxcategory.Items.Add("Food");
            comboBoxcategory.Items.Add("Dessert");
            comboBoxcategory.SelectedIndex = 0;
            comboBoxcategory.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public MenuItem NewItem { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string name = txtname.Text;
            if (!decimal.TryParse(txtprice.Text, out var price) || price <= 0)
            {
                MessageBox.Show("Price must be valid and greater than 0!!!");
                return;
            }
            string description = txtdescription.Text;
            string category = comboBoxcategory.SelectedItem.ToString();
            if (comboBoxcategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose category!");
                return;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Item name cannot be blank!");
                return;
            }
            NewItem = new MenuItem(name, price, category, description);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public MenuItemForm(MenuItem itemToEdit) : this()
        {
            txtname.Text = itemToEdit.Name;
            txtprice.Text = itemToEdit.Price.ToString();
            txtdescription.Text = itemToEdit.Description;
            comboBoxcategory.SelectedItem = itemToEdit.Category;
        }
    }
}
