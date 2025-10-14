namespace source.UI
{
    partial class ProductFormForManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblname = new Label();
            txtname = new TextBox();
            lblprice = new Label();
            lbldescription = new Label();
            lblcategory = new Label();
            txtprice = new TextBox();
            txtdescription = new TextBox();
            btnOK = new Button();
            btncancel = new Button();
            comboBoxcategory = new ComboBox();
            lblTemp = new Label();
            lblSize = new Label();
            pnlDrink = new Panel();
            cbTemp = new ComboBox();
            cbSize = new ComboBox();
            pnlFood = new Panel();
            cbDiet = new ComboBox();
            txtTopping = new TextBox();
            lblDiet = new Label();
            lblTopping = new Label();
            pnlDessert = new Panel();
            txtDecoration = new TextBox();
            lblDecoration = new Label();
            cbTemp1 = new ComboBox();
            txtFlavor = new TextBox();
            lblTemp1 = new Label();
            lblFlavor = new Label();
            pnlDrink.SuspendLayout();
            pnlFood.SuspendLayout();
            pnlDessert.SuspendLayout();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblname.Location = new Point(21, 143);
            lblname.Name = "lblname";
            lblname.Size = new Size(68, 28);
            lblname.TabIndex = 0;
            lblname.Text = "Name:";
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(146, 140);
            txtname.Name = "txtname";
            txtname.ReadOnly = true;
            txtname.Size = new Size(248, 34);
            txtname.TabIndex = 1;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprice.Location = new Point(21, 200);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(58, 28);
            lblprice.TabIndex = 2;
            lblprice.Text = "Price:";
            lblprice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldescription.Location = new Point(21, 255);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new Size(116, 28);
            lbldescription.TabIndex = 3;
            lbldescription.Text = "Description:";
            lbldescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblcategory
            // 
            lblcategory.AutoSize = true;
            lblcategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcategory.Location = new Point(443, 79);
            lblcategory.Name = "lblcategory";
            lblcategory.Size = new Size(96, 28);
            lblcategory.TabIndex = 4;
            lblcategory.Text = "Category:";
            lblcategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Location = new Point(146, 200);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(248, 34);
            txtprice.TabIndex = 5;
            // 
            // txtdescription
            // 
            txtdescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescription.Location = new Point(146, 255);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(248, 34);
            txtdescription.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(284, 342);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 35);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancel.Location = new Point(429, 342);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(82, 35);
            btncancel.TabIndex = 9;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btnCancel_Click;
            // 
            // comboBoxcategory
            // 
            comboBoxcategory.FormattingEnabled = true;
            comboBoxcategory.Location = new Point(568, 79);
            comboBoxcategory.Name = "comboBoxcategory";
            comboBoxcategory.Size = new Size(185, 28);
            comboBoxcategory.TabIndex = 10;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemp.Location = new Point(25, 114);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(59, 28);
            lblTemp.TabIndex = 12;
            lblTemp.Text = "Temp";
            lblTemp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(25, 34);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 28);
            lblSize.TabIndex = 16;
            lblSize.Text = "Size";
            lblSize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDrink
            // 
            pnlDrink.Controls.Add(cbTemp);
            pnlDrink.Controls.Add(cbSize);
            pnlDrink.Controls.Add(lblSize);
            pnlDrink.Controls.Add(lblTemp);
            pnlDrink.Location = new Point(413, 110);
            pnlDrink.Name = "pnlDrink";
            pnlDrink.Size = new Size(360, 221);
            pnlDrink.TabIndex = 17;
            pnlDrink.Visible = false;
            // 
            // cbTemp
            // 
            cbTemp.FormattingEnabled = true;
            cbTemp.Items.AddRange(new object[] { "Hot", "Cold" });
            cbTemp.Location = new Point(155, 121);
            cbTemp.Name = "cbTemp";
            cbTemp.Size = new Size(185, 28);
            cbTemp.TabIndex = 22;
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Items.AddRange(new object[] { "To", "Nhỏ" });
            cbSize.Location = new Point(155, 38);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(185, 28);
            cbSize.TabIndex = 21;
            // 
            // pnlFood
            // 
            pnlFood.Anchor = AnchorStyles.None;
            pnlFood.Controls.Add(cbDiet);
            pnlFood.Controls.Add(txtTopping);
            pnlFood.Controls.Add(lblDiet);
            pnlFood.Controls.Add(lblTopping);
            pnlFood.Location = new Point(400, 113);
            pnlFood.Name = "pnlFood";
            pnlFood.Size = new Size(373, 215);
            pnlFood.TabIndex = 19;
            pnlFood.Visible = false;
            // 
            // cbDiet
            // 
            cbDiet.FormattingEnabled = true;
            cbDiet.Items.AddRange(new object[] { "Vegetarian", "Normal" });
            cbDiet.Location = new Point(168, 35);
            cbDiet.Name = "cbDiet";
            cbDiet.Size = new Size(185, 28);
            cbDiet.TabIndex = 17;
            // 
            // txtTopping
            // 
            txtTopping.Location = new Point(168, 118);
            txtTopping.Name = "txtTopping";
            txtTopping.Size = new Size(185, 27);
            txtTopping.TabIndex = 11;
            // 
            // lblDiet
            // 
            lblDiet.AutoSize = true;
            lblDiet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiet.Location = new Point(34, 31);
            lblDiet.Name = "lblDiet";
            lblDiet.Size = new Size(48, 28);
            lblDiet.TabIndex = 16;
            lblDiet.Text = "Diet";
            lblDiet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopping
            // 
            lblTopping.AutoSize = true;
            lblTopping.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTopping.Location = new Point(34, 111);
            lblTopping.Name = "lblTopping";
            lblTopping.Size = new Size(84, 28);
            lblTopping.TabIndex = 12;
            lblTopping.Text = "Topping";
            lblTopping.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDessert
            // 
            pnlDessert.Anchor = AnchorStyles.None;
            pnlDessert.Controls.Add(txtDecoration);
            pnlDessert.Controls.Add(lblDecoration);
            pnlDessert.Controls.Add(cbTemp1);
            pnlDessert.Controls.Add(txtFlavor);
            pnlDessert.Controls.Add(lblTemp1);
            pnlDessert.Controls.Add(lblFlavor);
            pnlDessert.Location = new Point(400, 110);
            pnlDessert.Name = "pnlDessert";
            pnlDessert.Size = new Size(370, 223);
            pnlDessert.TabIndex = 20;
            pnlDessert.Visible = false;
            // 
            // txtDecoration
            // 
            txtDecoration.Location = new Point(168, 157);
            txtDecoration.Name = "txtDecoration";
            txtDecoration.Size = new Size(185, 27);
            txtDecoration.TabIndex = 18;
            // 
            // lblDecoration
            // 
            lblDecoration.AutoSize = true;
            lblDecoration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecoration.Location = new Point(29, 153);
            lblDecoration.Name = "lblDecoration";
            lblDecoration.Size = new Size(109, 28);
            lblDecoration.TabIndex = 19;
            lblDecoration.Text = "Decoration";
            lblDecoration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbTemp1
            // 
            cbTemp1.FormattingEnabled = true;
            cbTemp1.Items.AddRange(new object[] { "Hot", "Cold" });
            cbTemp1.Location = new Point(168, 36);
            cbTemp1.Name = "cbTemp1";
            cbTemp1.Size = new Size(185, 28);
            cbTemp1.TabIndex = 17;
            // 
            // txtFlavor
            // 
            txtFlavor.Location = new Point(168, 99);
            txtFlavor.Name = "txtFlavor";
            txtFlavor.Size = new Size(185, 27);
            txtFlavor.TabIndex = 11;
            // 
            // lblTemp1
            // 
            lblTemp1.AutoSize = true;
            lblTemp1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemp1.Location = new Point(25, 34);
            lblTemp1.Name = "lblTemp1";
            lblTemp1.Size = new Size(59, 28);
            lblTemp1.TabIndex = 16;
            lblTemp1.Text = "Temp";
            lblTemp1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFlavor
            // 
            lblFlavor.AutoSize = true;
            lblFlavor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlavor.Location = new Point(29, 95);
            lblFlavor.Name = "lblFlavor";
            lblFlavor.Size = new Size(66, 28);
            lblFlavor.TabIndex = 12;
            lblFlavor.Text = "Flavor";
            lblFlavor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductFormForManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 422);
            Controls.Add(pnlDessert);
            Controls.Add(pnlFood);
            Controls.Add(pnlDrink);
            Controls.Add(comboBoxcategory);
            Controls.Add(btncancel);
            Controls.Add(btnOK);
            Controls.Add(txtdescription);
            Controls.Add(txtprice);
            Controls.Add(lblcategory);
            Controls.Add(lbldescription);
            Controls.Add(lblprice);
            Controls.Add(txtname);
            Controls.Add(lblname);
            Name = "ProductFormForManager";
            Text = "MenuItemsForm";
            pnlDrink.ResumeLayout(false);
            pnlDrink.PerformLayout();
            pnlFood.ResumeLayout(false);
            pnlFood.PerformLayout();
            pnlDessert.ResumeLayout(false);
            pnlDessert.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private TextBox txtname;
        private Label lblprice;
        private Label lbldescription;
        private Label lblcategory;
        private TextBox txtprice;
        private TextBox txtdescription;
        private Button btnOK;
        private Button btncancel;
        private ComboBox comboBoxcategory;
        private Label lblTemp;
        private Label lblSize;
        private Panel pnlDrink;
        private Panel pnlFood;
        private TextBox txtTopping;
        private Label lblDiet;
        private Label lblTopping;
        private Panel pnlDessert;
        private TextBox txtDecoration;
        private Label lblDecoration;
        private ComboBox cbTemp1;
        private TextBox txtFlavor;
        private Label lblTemp1;
        private Label lblFlavor;
        private ComboBox cbDiet;
        private ComboBox cbTemp;
        private ComboBox cbSize;
    }
}