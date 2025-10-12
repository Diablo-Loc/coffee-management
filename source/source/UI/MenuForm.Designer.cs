namespace source.UI
{
    partial class MenuForm
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
            txtsearch = new TextBox();
            btnsearch = new Button();
            comboBox = new ComboBox();
            dgvMenu = new DataGridView();
            colname1 = new DataGridViewTextBoxColumn();
            colname3 = new DataGridViewTextBoxColumn();
            colname2 = new DataGridViewTextBoxColumn();
            IsHot = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            IsVegetarian = new DataGridViewTextBoxColumn();
            Topping = new DataGridViewTextBoxColumn();
            IsCold = new DataGridViewTextBoxColumn();
            Flavor = new DataGridViewTextBoxColumn();
            Decoration = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnadd = new Button();
            btnedit = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(29, 31);
            txtsearch.Margin = new Padding(5);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(202, 27);
            txtsearch.TabIndex = 0;
            // 
            // btnsearch
            // 
            btnsearch.AutoSize = true;
            btnsearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(255, 25);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(76, 36);
            btnsearch.TabIndex = 1;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(377, 28);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(142, 31);
            comboBox.TabIndex = 2;
            comboBox.Text = "All";
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colname1, colname3, colname2, IsHot, Size, IsVegetarian, Topping, IsCold, Flavor, Decoration });
            dgvMenu.Dock = DockStyle.Fill;
            dgvMenu.Location = new Point(0, 0);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.Size = new Size(1025, 487);
            dgvMenu.TabIndex = 3;
            // 
            // colname1
            // 
            colname1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colname1.HeaderText = "Tên món";
            colname1.MinimumWidth = 6;
            colname1.Name = "colname1";
            colname1.ReadOnly = true;
            // 
            // colname3
            // 
            colname3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colname3.HeaderText = "Mô tả";
            colname3.MinimumWidth = 6;
            colname3.Name = "colname3";
            colname3.ReadOnly = true;
            colname3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colname2
            // 
            colname2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colname2.HeaderText = "Giá";
            colname2.MinimumWidth = 6;
            colname2.Name = "colname2";
            colname2.ReadOnly = true;
            // 
            // IsHot
            // 
            IsHot.HeaderText = "IsHot";
            IsHot.MinimumWidth = 6;
            IsHot.Name = "IsHot";
            IsHot.ReadOnly = true;
            // 
            // Size
            // 
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            // 
            // IsVegetarian
            // 
            IsVegetarian.HeaderText = "IsVegetarian";
            IsVegetarian.MinimumWidth = 6;
            IsVegetarian.Name = "IsVegetarian";
            IsVegetarian.ReadOnly = true;
            // 
            // Topping
            // 
            Topping.HeaderText = "Topping";
            Topping.MinimumWidth = 6;
            Topping.Name = "Topping";
            Topping.ReadOnly = true;
            // 
            // IsCold
            // 
            IsCold.HeaderText = "IsCold";
            IsCold.MinimumWidth = 6;
            IsCold.Name = "IsCold";
            IsCold.ReadOnly = true;
            // 
            // Flavor
            // 
            Flavor.HeaderText = "Flavor";
            Flavor.MinimumWidth = 6;
            Flavor.Name = "Flavor";
            Flavor.ReadOnly = true;
            // 
            // Decoration
            // 
            Decoration.HeaderText = "Decoration";
            Decoration.MinimumWidth = 6;
            Decoration.Name = "Decoration";
            Decoration.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(dgvMenu);
            panel1.Location = new Point(29, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 487);
            panel1.TabIndex = 4;
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnadd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(92, 578);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(72, 38);
            btnadd.TabIndex = 5;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            btnedit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnedit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.Location = new Point(216, 578);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(72, 38);
            btnedit.TabIndex = 6;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btndelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(333, 578);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(72, 38);
            btndelete.TabIndex = 7;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 638);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(panel1);
            Controls.Add(comboBox);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Margin = new Padding(2);
            Name = "MenuForm";
            Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsearch;
        private Button btnsearch;
        private ComboBox comboBox;
        private DataGridView dgvMenu;
        private Panel panel1;
        private Button btnadd;
        private Button btnedit;
        private Button btndelete;
        private DataGridViewTextBoxColumn colname1;
        private DataGridViewTextBoxColumn colname3;
        private DataGridViewTextBoxColumn colname2;
        private DataGridViewTextBoxColumn IsHot;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn IsVegetarian;
        private DataGridViewTextBoxColumn Topping;
        private DataGridViewTextBoxColumn IsCold;
        private DataGridViewTextBoxColumn Flavor;
        private DataGridViewTextBoxColumn Decoration;
    }
}