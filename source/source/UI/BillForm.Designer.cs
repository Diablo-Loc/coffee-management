namespace source.UI
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            lblBillID = new Label();
            lblTable = new Label();
            lblDate = new Label();
            lblTotal = new Label();
            listViewItem = new ListView();
            NameItem = new ColumnHeader();
            Price = new ColumnHeader();
            Quantity = new ColumnHeader();
            Total = new ColumnHeader();
            button4 = new Button();
            button5 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            SuspendLayout();
            // 
            // lblBillID
            // 
            lblBillID.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillID.ForeColor = Color.Navy;
            lblBillID.Location = new Point(273, 75);
            lblBillID.Name = "lblBillID";
            lblBillID.Size = new Size(300, 40);
            lblBillID.TabIndex = 1;
            lblBillID.Text = "Bill #000";
            lblBillID.TextAlign = ContentAlignment.MiddleCenter;
            lblBillID.Click += lblBillID_Click;
            // 
            // lblTable
            // 
            lblTable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTable.ForeColor = Color.Black;
            lblTable.Location = new Point(21, 170);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(250, 30);
            lblTable.TabIndex = 2;
            lblTable.Text = "Table Number: 01";
            lblTable.Click += lblTable_Click;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(21, 210);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(250, 30);
            lblDate.TabIndex = 3;
            lblDate.Text = "Ngày: 23/09/2025";
            lblDate.Click += lblDate_Click;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(503, 691);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(300, 40);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: 0";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // listViewItem
            // 
            listViewItem.Columns.AddRange(new ColumnHeader[] { NameItem, Price, Quantity, Total });
            listViewItem.Location = new Point(3, 259);
            listViewItem.Name = "listViewItem";
            listViewItem.Size = new Size(800, 400);
            listViewItem.TabIndex = 5;
            listViewItem.UseCompatibleStateImageBehavior = false;
            listViewItem.View = View.Details;
            listViewItem.SelectedIndexChanged += listViewItem_SelectedIndexChanged;
            // 
            // NameItem
            // 
            NameItem.Text = "Name Item";
            NameItem.Width = 200;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 200;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 200;
            // 
            // Total
            // 
            Total.Text = "Total";
            Total.Width = 200;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(547, 835);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "Print ";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnPrint_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(683, 835);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 7;
            button5.Text = "Close";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnClose_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 1000);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listViewItem);
            Controls.Add(lblTotal);
            Controls.Add(lblDate);
            Controls.Add(lblTable);
            Controls.Add(lblBillID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += BillForm_Load;
            MouseDown += panelTitle_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private Label lblBillID;
        private Label lblTable;
        private Label lblDate;
        private Label lblTotal;
        private ListView listViewItem;
        private ColumnHeader NameItem;
        private ColumnHeader Price;
        private ColumnHeader Quantity;
        private ColumnHeader Total;
        private Button button4;
        private Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}