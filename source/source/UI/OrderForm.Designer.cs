namespace source.UI
{
    partial class OrderForm
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
            panelleft = new Panel();
            lblOrderDate = new Label();
            flpTables = new FlowLayoutPanel();
            pnlTableTemplate = new Panel();
            lblTotal = new Label();
            lblGuest = new Label();
            lblStatus = new Label();
            lblTableName = new Label();
            lbltablemana = new Label();
            panelright = new Panel();
            lblDeleteItem = new Label();
            numericUpDownguest = new NumericUpDown();
            btncancel = new Button();
            btncreate = new Button();
            btndelete = new Button();
            lblOrderTotal = new Label();
            dgvorder = new DataGridView();
            col1 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            col4 = new DataGridViewTextBoxColumn();
            cbtablenumber = new ComboBox();
            lbltable = new Label();
            lbguest = new Label();
            dgvmenu = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txtsearch = new TextBox();
            lblmenu = new Label();
            btnprint = new Button();
            panelleft.SuspendLayout();
            flpTables.SuspendLayout();
            pnlTableTemplate.SuspendLayout();
            panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownguest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvmenu).BeginInit();
            SuspendLayout();
            // 
            // panelleft
            // 
            panelleft.Controls.Add(lblOrderDate);
            panelleft.Controls.Add(flpTables);
            panelleft.Controls.Add(lbltablemana);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 0);
            panelleft.Margin = new Padding(4, 4, 4, 4);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(876, 776);
            panelleft.TabIndex = 0;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(15, 26);
            lblOrderDate.Margin = new Padding(4, 0, 4, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(79, 25);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "Date: ---";
            // 
            // flpTables
            // 
            flpTables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpTables.AutoScroll = true;
            flpTables.Controls.Add(pnlTableTemplate);
            flpTables.Font = new Font("Segoe UI", 10.2F);
            flpTables.Location = new Point(4, 66);
            flpTables.Margin = new Padding(4, 4, 4, 4);
            flpTables.Name = "flpTables";
            flpTables.Size = new Size(862, 706);
            flpTables.TabIndex = 1;
            // 
            // pnlTableTemplate
            // 
            pnlTableTemplate.BackColor = Color.LightGray;
            pnlTableTemplate.Controls.Add(lblTotal);
            pnlTableTemplate.Controls.Add(lblGuest);
            pnlTableTemplate.Controls.Add(lblStatus);
            pnlTableTemplate.Controls.Add(lblTableName);
            pnlTableTemplate.Font = new Font("Segoe UI", 10.2F);
            pnlTableTemplate.Location = new Point(4, 4);
            pnlTableTemplate.Margin = new Padding(4, 4, 4, 4);
            pnlTableTemplate.Name = "pnlTableTemplate";
            pnlTableTemplate.Size = new Size(281, 169);
            pnlTableTemplate.TabIndex = 0;
            pnlTableTemplate.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 10.2F);
            lblTotal.Location = new Point(8, 108);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(270, 29);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: 0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuest
            // 
            lblGuest.Font = new Font("Segoe UI", 10.2F);
            lblGuest.Location = new Point(24, 79);
            lblGuest.Margin = new Padding(4, 0, 4, 0);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(235, 29);
            lblGuest.TabIndex = 2;
            lblGuest.Text = "Guests: 0";
            lblGuest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 10.2F);
            lblStatus.Location = new Point(24, 50);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(235, 29);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Empty";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTableName
            // 
            lblTableName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableName.Location = new Point(34, 15);
            lblTableName.Margin = new Padding(4, 0, 4, 0);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(225, 35);
            lblTableName.TabIndex = 0;
            lblTableName.Text = "Table 1";
            lblTableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltablemana
            // 
            lbltablemana.AutoSize = true;
            lbltablemana.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltablemana.Location = new Point(258, 11);
            lbltablemana.Margin = new Padding(4, 0, 4, 0);
            lbltablemana.Name = "lbltablemana";
            lbltablemana.Size = new Size(351, 48);
            lbltablemana.TabIndex = 0;
            lbltablemana.Text = "Table Management ";
            // 
            // panelright
            // 
            panelright.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelright.Controls.Add(btnprint);
            panelright.Controls.Add(lblDeleteItem);
            panelright.Controls.Add(numericUpDownguest);
            panelright.Controls.Add(btncancel);
            panelright.Controls.Add(btncreate);
            panelright.Controls.Add(btndelete);
            panelright.Controls.Add(lblOrderTotal);
            panelright.Controls.Add(dgvorder);
            panelright.Controls.Add(cbtablenumber);
            panelright.Controls.Add(lbltable);
            panelright.Controls.Add(lbguest);
            panelright.Controls.Add(dgvmenu);
            panelright.Controls.Add(txtsearch);
            panelright.Controls.Add(lblmenu);
            panelright.Location = new Point(874, 0);
            panelright.Margin = new Padding(4, 4, 4, 4);
            panelright.Name = "panelright";
            panelright.Size = new Size(519, 772);
            panelright.TabIndex = 1;
            // 
            // lblDeleteItem
            // 
            lblDeleteItem.AutoSize = true;
            lblDeleteItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeleteItem.Location = new Point(235, 364);
            lblDeleteItem.Margin = new Padding(4, 0, 4, 0);
            lblDeleteItem.Name = "lblDeleteItem";
            lblDeleteItem.Size = new Size(121, 30);
            lblDeleteItem.TabIndex = 14;
            lblDeleteItem.Text = "Delete Item";
            // 
            // numericUpDownguest
            // 
            numericUpDownguest.Location = new Point(85, 364);
            numericUpDownguest.Margin = new Padding(4, 4, 4, 4);
            numericUpDownguest.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownguest.Name = "numericUpDownguest";
            numericUpDownguest.Size = new Size(76, 31);
            numericUpDownguest.TabIndex = 13;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(197, 718);
            btncancel.Margin = new Padding(4, 4, 4, 4);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(136, 45);
            btncancel.TabIndex = 12;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(41, 718);
            btncreate.Margin = new Padding(4, 4, 4, 4);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(136, 45);
            btncreate.TabIndex = 11;
            btncreate.Text = "Create";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(366, 361);
            btndelete.Margin = new Padding(4, 4, 4, 4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(118, 36);
            btndelete.TabIndex = 10;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderTotal.Location = new Point(41, 671);
            lblOrderTotal.Margin = new Padding(4, 0, 4, 0);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(121, 30);
            lblOrderTotal.TabIndex = 7;
            lblOrderTotal.Text = "Order Total:";
            // 
            // dgvorder
            // 
            dgvorder.AllowUserToAddRows = false;
            dgvorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorder.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4 });
            dgvorder.Location = new Point(26, 470);
            dgvorder.Margin = new Padding(4, 4, 4, 4);
            dgvorder.Name = "dgvorder";
            dgvorder.ReadOnly = true;
            dgvorder.RowHeadersVisible = false;
            dgvorder.RowHeadersWidth = 51;
            dgvorder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvorder.Size = new Size(474, 185);
            dgvorder.TabIndex = 6;
            // 
            // col1
            // 
            col1.HeaderText = "Item";
            col1.MinimumWidth = 6;
            col1.Name = "col1";
            col1.ReadOnly = true;
            col1.Width = 120;
            // 
            // col2
            // 
            col2.HeaderText = "Qty";
            col2.MinimumWidth = 6;
            col2.Name = "col2";
            col2.ReadOnly = true;
            col2.Width = 50;
            // 
            // col3
            // 
            col3.HeaderText = "Unit price";
            col3.MinimumWidth = 6;
            col3.Name = "col3";
            col3.ReadOnly = true;
            col3.Width = 110;
            // 
            // col4
            // 
            col4.HeaderText = "Total";
            col4.MinimumWidth = 6;
            col4.Name = "col4";
            col4.ReadOnly = true;
            col4.Width = 95;
            // 
            // cbtablenumber
            // 
            cbtablenumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtablenumber.FormattingEnabled = true;
            cbtablenumber.Location = new Point(158, 415);
            cbtablenumber.Margin = new Padding(4, 4, 4, 4);
            cbtablenumber.Name = "cbtablenumber";
            cbtablenumber.Size = new Size(286, 33);
            cbtablenumber.TabIndex = 5;
            // 
            // lbltable
            // 
            lbltable.AutoSize = true;
            lbltable.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltable.Location = new Point(26, 415);
            lbltable.Margin = new Padding(4, 0, 4, 0);
            lbltable.Name = "lbltable";
            lbltable.Size = new Size(66, 30);
            lbltable.TabIndex = 4;
            lbltable.Text = "Table:";
            // 
            // lbguest
            // 
            lbguest.AutoSize = true;
            lbguest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbguest.Location = new Point(10, 366);
            lbguest.Margin = new Padding(4, 0, 4, 0);
            lbguest.Name = "lbguest";
            lbguest.Size = new Size(66, 30);
            lbguest.TabIndex = 3;
            lbguest.Text = "Guest";
            // 
            // dgvmenu
            // 
            dgvmenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmenu.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            dgvmenu.Location = new Point(26, 120);
            dgvmenu.Margin = new Padding(4, 4, 4, 4);
            dgvmenu.Name = "dgvmenu";
            dgvmenu.ReadOnly = true;
            dgvmenu.RowHeadersVisible = false;
            dgvmenu.RowHeadersWidth = 51;
            dgvmenu.Size = new Size(474, 229);
            dgvmenu.TabIndex = 2;
            dgvmenu.CellClick += dgvmenu_CellClick;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cate";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(41, 64);
            txtsearch.Margin = new Padding(4, 4, 4, 4);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(343, 35);
            txtsearch.TabIndex = 1;
            txtsearch.Text = "Search...";
            // 
            // lblmenu
            // 
            lblmenu.AutoSize = true;
            lblmenu.FlatStyle = FlatStyle.Flat;
            lblmenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmenu.Location = new Point(41, 18);
            lblmenu.Margin = new Padding(4, 0, 4, 0);
            lblmenu.Name = "lblmenu";
            lblmenu.Size = new Size(77, 32);
            lblmenu.TabIndex = 0;
            lblmenu.Text = "Menu";
            // 
            // btnprint
            // 
            btnprint.Location = new Point(348, 718);
            btnprint.Margin = new Padding(4);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(136, 45);
            btnprint.TabIndex = 15;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 776);
            Controls.Add(panelright);
            Controls.Add(panelleft);
            Margin = new Padding(4, 4, 4, 4);
            Name = "OrderForm";
            Text = "OrderForm";
            panelleft.ResumeLayout(false);
            panelleft.PerformLayout();
            flpTables.ResumeLayout(false);
            pnlTableTemplate.ResumeLayout(false);
            panelright.ResumeLayout(false);
            panelright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownguest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvmenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelleft;
        private Panel panelright;
        private Label lblmenu;
        private DataGridView dgvmenu;
        private TextBox txtsearch;
        private Label lbltable;
        private Label lbguest;
        private DataGridView dgvorder;
        private ComboBox cbtablenumber;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label lblOrderTotal;
        private Button btncancel;
        private Button btncreate;
        private Button btndelete;
        private Label lbltablemana;
        private FlowLayoutPanel flpTables;
        private Panel pnlTableTemplate;
        private Label lblStatus;
        private Label lblTableName;
        private Label lblTotal;
        private Label lblGuest;
        private NumericUpDown numericUpDownguest;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col4;
        private Label lblOrderDate;
        private Label lblDeleteItem;
        private Button btnprint;
    }
}