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
            btnprint = new Button();
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
            panelleft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelleft.Controls.Add(lblOrderDate);
            panelleft.Controls.Add(flpTables);
            panelleft.Controls.Add(lbltablemana);
            panelleft.Location = new Point(0, 0);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(701, 621);
            panelleft.TabIndex = 0;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(12, 21);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(66, 20);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "Date: ---";
            // 
            // flpTables
            // 
            flpTables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpTables.AutoScroll = true;
            flpTables.Controls.Add(pnlTableTemplate);
            flpTables.Font = new Font("Segoe UI", 10.2F);
            flpTables.Location = new Point(3, 53);
            flpTables.Name = "flpTables";
            flpTables.Size = new Size(690, 565);
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
            pnlTableTemplate.Location = new Point(3, 3);
            pnlTableTemplate.Name = "pnlTableTemplate";
            pnlTableTemplate.Size = new Size(225, 135);
            pnlTableTemplate.TabIndex = 0;
            pnlTableTemplate.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 10.2F);
            lblTotal.Location = new Point(6, 86);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(216, 23);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: 0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuest
            // 
            lblGuest.Font = new Font("Segoe UI", 10.2F);
            lblGuest.Location = new Point(19, 63);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(188, 23);
            lblGuest.TabIndex = 2;
            lblGuest.Text = "Guests: 0";
            lblGuest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 10.2F);
            lblStatus.Location = new Point(19, 40);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(188, 23);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Empty";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTableName
            // 
            lblTableName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableName.Location = new Point(27, 12);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(180, 28);
            lblTableName.TabIndex = 0;
            lblTableName.Text = "Table 1";
            lblTableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltablemana
            // 
            lbltablemana.Anchor = AnchorStyles.Top;
            lbltablemana.AutoSize = true;
            lbltablemana.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltablemana.Location = new Point(206, 9);
            lbltablemana.Name = "lbltablemana";
            lbltablemana.Size = new Size(296, 41);
            lbltablemana.TabIndex = 0;
            lbltablemana.Text = "Table Management ";
            lbltablemana.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelright
            // 
            panelright.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            panelright.Location = new Point(699, 0);
            panelright.Name = "panelright";
            panelright.Size = new Size(415, 618);
            panelright.TabIndex = 1;
            // 
            // btnprint
            // 
            btnprint.Location = new Point(278, 574);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(109, 36);
            btnprint.TabIndex = 15;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // lblDeleteItem
            // 
            lblDeleteItem.AutoSize = true;
            lblDeleteItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeleteItem.Location = new Point(188, 291);
            lblDeleteItem.Name = "lblDeleteItem";
            lblDeleteItem.Size = new Size(99, 23);
            lblDeleteItem.TabIndex = 14;
            lblDeleteItem.Text = "Delete Item";
            // 
            // numericUpDownguest
            // 
            numericUpDownguest.Location = new Point(68, 291);
            numericUpDownguest.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownguest.Name = "numericUpDownguest";
            numericUpDownguest.Size = new Size(61, 27);
            numericUpDownguest.TabIndex = 13;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(158, 574);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(109, 36);
            btncancel.TabIndex = 12;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(33, 574);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(109, 36);
            btncreate.TabIndex = 11;
            btncreate.Text = "Create";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(293, 289);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 10;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderTotal.Location = new Point(33, 537);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(99, 23);
            lblOrderTotal.TabIndex = 7;
            lblOrderTotal.Text = "Order Total:";
            // 
            // dgvorder
            // 
            dgvorder.AllowUserToAddRows = false;
            dgvorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorder.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4 });
            dgvorder.Location = new Point(21, 376);
            dgvorder.Name = "dgvorder";
            dgvorder.ReadOnly = true;
            dgvorder.RowHeadersVisible = false;
            dgvorder.RowHeadersWidth = 51;
            dgvorder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvorder.Size = new Size(379, 148);
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
            cbtablenumber.Location = new Point(126, 332);
            cbtablenumber.Name = "cbtablenumber";
            cbtablenumber.Size = new Size(230, 28);
            cbtablenumber.TabIndex = 5;
            // 
            // lbltable
            // 
            lbltable.AutoSize = true;
            lbltable.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltable.Location = new Point(21, 332);
            lbltable.Name = "lbltable";
            lbltable.Size = new Size(53, 23);
            lbltable.TabIndex = 4;
            lbltable.Text = "Table:";
            // 
            // lbguest
            // 
            lbguest.AutoSize = true;
            lbguest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbguest.Location = new Point(8, 293);
            lbguest.Name = "lbguest";
            lbguest.Size = new Size(54, 23);
            lbguest.TabIndex = 3;
            lbguest.Text = "Guest";
            // 
            // dgvmenu
            // 
            dgvmenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmenu.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            dgvmenu.Location = new Point(21, 96);
            dgvmenu.Name = "dgvmenu";
            dgvmenu.ReadOnly = true;
            dgvmenu.RowHeadersVisible = false;
            dgvmenu.RowHeadersWidth = 51;
            dgvmenu.Size = new Size(379, 183);
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
            txtsearch.Location = new Point(33, 51);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(275, 30);
            txtsearch.TabIndex = 1;
            txtsearch.Text = "Search...";
            // 
            // lblmenu
            // 
            lblmenu.AutoSize = true;
            lblmenu.FlatStyle = FlatStyle.Flat;
            lblmenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmenu.Location = new Point(33, 14);
            lblmenu.Name = "lblmenu";
            lblmenu.Size = new Size(62, 28);
            lblmenu.TabIndex = 0;
            lblmenu.Text = "Menu";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 621);
            Controls.Add(panelright);
            Controls.Add(panelleft);
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