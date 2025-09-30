namespace source.UI
{
    partial class MenuItemForm
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
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblname.Location = new Point(47, 40);
            lblname.Name = "lblname";
            lblname.Size = new Size(68, 28);
            lblname.TabIndex = 0;
            lblname.Text = "Name:";
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(172, 37);
            txtname.Name = "txtname";
            txtname.Size = new Size(248, 34);
            txtname.TabIndex = 1;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprice.Location = new Point(47, 97);
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
            lbldescription.Location = new Point(47, 152);
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
            lblcategory.Location = new Point(47, 216);
            lblcategory.Name = "lblcategory";
            lblcategory.Size = new Size(96, 28);
            lblcategory.TabIndex = 4;
            lblcategory.Text = "Category:";
            lblcategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Location = new Point(172, 97);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(248, 34);
            txtprice.TabIndex = 5;
            // 
            // txtdescription
            // 
            txtdescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescription.Location = new Point(172, 152);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(248, 34);
            txtdescription.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(122, 286);
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
            btncancel.Location = new Point(267, 286);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(82, 35);
            btncancel.TabIndex = 9;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click_1;
            // 
            // comboBoxcategory
            // 
            comboBoxcategory.FormattingEnabled = true;
            comboBoxcategory.Location = new Point(172, 216);
            comboBoxcategory.Name = "comboBoxcategory";
            comboBoxcategory.Size = new Size(248, 28);
            comboBoxcategory.TabIndex = 10;
            // 
            // MenuItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "MenuItemForm";
            Text = "MenuItemsForm";
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
    }
}