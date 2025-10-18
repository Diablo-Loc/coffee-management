namespace source.UI
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            panelTop = new Panel();
            label1 = new Label();
            panelRight = new Panel();
            btnReset_Click = new Button();
            panel_Sales = new Panel();
            label5 = new Label();
            panel_Staff = new Panel();
            lbl_BestSellnigRank = new Label();
            lbl_BestSellingRank1 = new Label();
            lbl_BestSellingRank2 = new Label();
            lbl_BestSellingRank3 = new Label();
            panel_TotalOrder = new Panel();
            textBox_TotalOrder = new TextBox();
            label_TotalOrder = new Label();
            pictureBox_TotalOrder = new PictureBox();
            panel_Content = new Panel();
            panel_BestSeller = new Panel();
            Textbox_BestSellerQuantity = new TextBox();
            textBox_BestSellerName = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            lbl_Dashboard = new Label();
            panel_ContentDashboard = new Panel();
            panel_ContentHeader = new Panel();
            panelTop.SuspendLayout();
            panelRight.SuspendLayout();
            panel_Sales.SuspendLayout();
            panel_Staff.SuspendLayout();
            panel_TotalOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TotalOrder).BeginInit();
            panel_BestSeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_ContentDashboard.SuspendLayout();
            panel_ContentHeader.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.BackColor = Color.Transparent;
            formsPlot1.DisplayScale = 1.5F;
            formsPlot1.Location = new Point(0, 53);
            formsPlot1.Margin = new Padding(2, 2, 2, 2);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(782, 379);
            formsPlot1.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(2, 2, 2, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1081, 71);
            panelTop.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 46);
            label1.TabIndex = 7;
            label1.Text = "Report";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(btnReset_Click);
            panelRight.Controls.Add(panel_Sales);
            panelRight.Controls.Add(panel_Staff);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(787, 71);
            panelRight.Margin = new Padding(2, 2, 2, 2);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(294, 567);
            panelRight.TabIndex = 0;
            // 
            // btnReset_Click
            // 
            btnReset_Click.Location = new Point(16, 461);
            btnReset_Click.Name = "btnReset_Click";
            btnReset_Click.Size = new Size(109, 36);
            btnReset_Click.TabIndex = 12;
            btnReset_Click.Text = "Reset ";
            btnReset_Click.UseVisualStyleBackColor = true;
            btnReset_Click.Click += btnResetReport_Click;
            // 
            // panel_Sales
            // 
            panel_Sales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Sales.Controls.Add(label5);
            panel_Sales.Location = new Point(0, 318);
            panel_Sales.Margin = new Padding(2, 2, 2, 2);
            panel_Sales.Name = "panel_Sales";
            panel_Sales.Size = new Size(294, 120);
            panel_Sales.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 10);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(180, 37);
            label5.TabIndex = 10;
            label5.Text = "Revenue:  0đ";
            // 
            // panel_Staff
            // 
            panel_Staff.Controls.Add(lbl_BestSellnigRank);
            panel_Staff.Controls.Add(lbl_BestSellingRank1);
            panel_Staff.Controls.Add(lbl_BestSellingRank2);
            panel_Staff.Controls.Add(lbl_BestSellingRank3);
            panel_Staff.Dock = DockStyle.Top;
            panel_Staff.Location = new Point(0, 0);
            panel_Staff.Margin = new Padding(2, 2, 2, 2);
            panel_Staff.Name = "panel_Staff";
            panel_Staff.Size = new Size(294, 325);
            panel_Staff.TabIndex = 0;
            // 
            // lbl_BestSellnigRank
            // 
            lbl_BestSellnigRank.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_BestSellnigRank.AutoSize = true;
            lbl_BestSellnigRank.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BestSellnigRank.Location = new Point(14, 34);
            lbl_BestSellnigRank.Margin = new Padding(2, 0, 2, 0);
            lbl_BestSellnigRank.Name = "lbl_BestSellnigRank";
            lbl_BestSellnigRank.Size = new Size(234, 37);
            lbl_BestSellnigRank.TabIndex = 3;
            lbl_BestSellnigRank.Text = "Top selling items";
            // 
            // lbl_BestSellingRank1
            // 
            lbl_BestSellingRank1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_BestSellingRank1.AutoSize = true;
            lbl_BestSellingRank1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BestSellingRank1.Location = new Point(14, 115);
            lbl_BestSellingRank1.Margin = new Padding(2, 0, 2, 0);
            lbl_BestSellingRank1.Name = "lbl_BestSellingRank1";
            lbl_BestSellingRank1.Size = new Size(109, 28);
            lbl_BestSellingRank1.TabIndex = 2;
            lbl_BestSellingRank1.Text = "1. None: 0";
            // 
            // lbl_BestSellingRank2
            // 
            lbl_BestSellingRank2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_BestSellingRank2.AutoSize = true;
            lbl_BestSellingRank2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BestSellingRank2.Location = new Point(14, 188);
            lbl_BestSellingRank2.Margin = new Padding(2, 0, 2, 0);
            lbl_BestSellingRank2.Name = "lbl_BestSellingRank2";
            lbl_BestSellingRank2.Size = new Size(115, 28);
            lbl_BestSellingRank2.TabIndex = 1;
            lbl_BestSellingRank2.Text = "2. None : 0";
            // 
            // lbl_BestSellingRank3
            // 
            lbl_BestSellingRank3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_BestSellingRank3.AutoSize = true;
            lbl_BestSellingRank3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BestSellingRank3.Location = new Point(14, 254);
            lbl_BestSellingRank3.Margin = new Padding(2, 0, 2, 0);
            lbl_BestSellingRank3.Name = "lbl_BestSellingRank3";
            lbl_BestSellingRank3.Size = new Size(109, 28);
            lbl_BestSellingRank3.TabIndex = 0;
            lbl_BestSellingRank3.Text = "3. None: 0";
            // 
            // panel_TotalOrder
            // 
            panel_TotalOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_TotalOrder.BorderStyle = BorderStyle.FixedSingle;
            panel_TotalOrder.Controls.Add(textBox_TotalOrder);
            panel_TotalOrder.Controls.Add(label_TotalOrder);
            panel_TotalOrder.Controls.Add(pictureBox_TotalOrder);
            panel_TotalOrder.Location = new Point(9, 0);
            panel_TotalOrder.Margin = new Padding(2, 2, 2, 2);
            panel_TotalOrder.Name = "panel_TotalOrder";
            panel_TotalOrder.Size = new Size(340, 118);
            panel_TotalOrder.TabIndex = 2;
            // 
            // textBox_TotalOrder
            // 
            textBox_TotalOrder.BackColor = SystemColors.Control;
            textBox_TotalOrder.BorderStyle = BorderStyle.None;
            textBox_TotalOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_TotalOrder.Location = new Point(125, 44);
            textBox_TotalOrder.Margin = new Padding(2, 2, 2, 2);
            textBox_TotalOrder.Name = "textBox_TotalOrder";
            textBox_TotalOrder.Size = new Size(38, 27);
            textBox_TotalOrder.TabIndex = 11;
            textBox_TotalOrder.Text = "0";
            // 
            // label_TotalOrder
            // 
            label_TotalOrder.AutoSize = true;
            label_TotalOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TotalOrder.Location = new Point(121, 4);
            label_TotalOrder.Margin = new Padding(2, 0, 2, 0);
            label_TotalOrder.Name = "label_TotalOrder";
            label_TotalOrder.Size = new Size(132, 28);
            label_TotalOrder.TabIndex = 6;
            label_TotalOrder.Text = "Active Order";
            // 
            // pictureBox_TotalOrder
            // 
            pictureBox_TotalOrder.BackColor = Color.FromArgb(128, 255, 128);
            pictureBox_TotalOrder.Image = (Image)resources.GetObject("pictureBox_TotalOrder.Image");
            pictureBox_TotalOrder.Location = new Point(0, -1);
            pictureBox_TotalOrder.Margin = new Padding(2, 2, 2, 2);
            pictureBox_TotalOrder.Name = "pictureBox_TotalOrder";
            pictureBox_TotalOrder.Size = new Size(118, 125);
            pictureBox_TotalOrder.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_TotalOrder.TabIndex = 4;
            pictureBox_TotalOrder.TabStop = false;
            // 
            // panel_Content
            // 
            panel_Content.Location = new Point(0, 71);
            panel_Content.Margin = new Padding(2, 2, 2, 2);
            panel_Content.Name = "panel_Content";
            panel_Content.Size = new Size(782, 567);
            panel_Content.TabIndex = 10;
            // 
            // panel_BestSeller
            // 
            panel_BestSeller.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel_BestSeller.BorderStyle = BorderStyle.FixedSingle;
            panel_BestSeller.Controls.Add(Textbox_BestSellerQuantity);
            panel_BestSeller.Controls.Add(textBox_BestSellerName);
            panel_BestSeller.Controls.Add(label2);
            panel_BestSeller.Controls.Add(pictureBox2);
            panel_BestSeller.Location = new Point(437, 0);
            panel_BestSeller.Margin = new Padding(2, 2, 2, 2);
            panel_BestSeller.Name = "panel_BestSeller";
            panel_BestSeller.Size = new Size(345, 118);
            panel_BestSeller.TabIndex = 3;
            // 
            // Textbox_BestSellerQuantity
            // 
            Textbox_BestSellerQuantity.BackColor = SystemColors.Control;
            Textbox_BestSellerQuantity.BorderStyle = BorderStyle.None;
            Textbox_BestSellerQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Textbox_BestSellerQuantity.Location = new Point(125, 61);
            Textbox_BestSellerQuantity.Margin = new Padding(2, 2, 2, 2);
            Textbox_BestSellerQuantity.Name = "Textbox_BestSellerQuantity";
            Textbox_BestSellerQuantity.Size = new Size(38, 27);
            Textbox_BestSellerQuantity.TabIndex = 13;
            Textbox_BestSellerQuantity.Text = "0";
            // 
            // textBox_BestSellerName
            // 
            textBox_BestSellerName.BackColor = SystemColors.Control;
            textBox_BestSellerName.BorderStyle = BorderStyle.None;
            textBox_BestSellerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_BestSellerName.Location = new Point(125, 30);
            textBox_BestSellerName.Margin = new Padding(2, 2, 2, 2);
            textBox_BestSellerName.Name = "textBox_BestSellerName";
            textBox_BestSellerName.Size = new Size(175, 27);
            textBox_BestSellerName.TabIndex = 12;
            textBox_BestSellerName.Text = "None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 7;
            label2.Text = "Best Seller Now";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 192);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lbl_Dashboard
            // 
            lbl_Dashboard.AutoSize = true;
            lbl_Dashboard.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Dashboard.Location = new Point(0, 2);
            lbl_Dashboard.Margin = new Padding(2, 0, 2, 0);
            lbl_Dashboard.Name = "lbl_Dashboard";
            lbl_Dashboard.Size = new Size(312, 37);
            lbl_Dashboard.TabIndex = 9;
            lbl_Dashboard.Text = "Selling Items Overview";
            // 
            // panel_ContentDashboard
            // 
            panel_ContentDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ContentDashboard.Controls.Add(lbl_Dashboard);
            panel_ContentDashboard.Controls.Add(formsPlot1);
            panel_ContentDashboard.Location = new Point(0, 204);
            panel_ContentDashboard.Margin = new Padding(2, 2, 2, 2);
            panel_ContentDashboard.Name = "panel_ContentDashboard";
            panel_ContentDashboard.Size = new Size(782, 434);
            panel_ContentDashboard.TabIndex = 10;
            // 
            // panel_ContentHeader
            // 
            panel_ContentHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ContentHeader.Controls.Add(panel_TotalOrder);
            panel_ContentHeader.Controls.Add(panel_BestSeller);
            panel_ContentHeader.Location = new Point(0, 71);
            panel_ContentHeader.Margin = new Padding(2, 2, 2, 2);
            panel_ContentHeader.Name = "panel_ContentHeader";
            panel_ContentHeader.Size = new Size(782, 128);
            panel_ContentHeader.TabIndex = 11;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 638);
            Controls.Add(panelRight);
            Controls.Add(panelTop);
            Controls.Add(panel_ContentDashboard);
            Controls.Add(panel_ContentHeader);
            Controls.Add(panel_Content);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ReportForm";
            Text = "Report";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelRight.ResumeLayout(false);
            panel_Sales.ResumeLayout(false);
            panel_Sales.PerformLayout();
            panel_Staff.ResumeLayout(false);
            panel_Staff.PerformLayout();
            panel_TotalOrder.ResumeLayout(false);
            panel_TotalOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TotalOrder).EndInit();
            panel_BestSeller.ResumeLayout(false);
            panel_BestSeller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_ContentDashboard.ResumeLayout(false);
            panel_ContentDashboard.PerformLayout();
            panel_ContentHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Panel panelTop;
        private Panel panelRight;
        private Panel panel_TotalOrder;
        private Panel panel_BestSeller;
        private TextBox textBox_TotalOrder;
        private PictureBox pictureBox_TotalOrder;
        private PictureBox pictureBox2;
        private Label label_TotalOrder;
        private Label label2;
        private Label label1;
        private Panel panel_Staff;
        private Label lbl_BestSellingRank1;
        private Label lbl_BestSellingRank2;
        private Label lbl_BestSellingRank3;
        private Label lbl_Dashboard;
        private Panel panel_Sales;
        private Panel panel_ContentDashboard;
        private Label label5;
        private TextBox Textbox_BestSellerQuantity;
        private TextBox textBox_BestSellerName;
        private Label lbl_BestSellnigRank;
        private Panel panel_Content;
        private Panel panel_ContentHeader;
        private Button btnReset_Click;
    }
}