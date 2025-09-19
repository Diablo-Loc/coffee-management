namespace source.UI
{
    partial class MainForm
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
            panelMenu = new Panel();
            buttonOrderList = new Button();
            buttonCreatOrder = new Button();
            buttonMenuManagement = new Button();
            panelLogo = new Panel();
            labelHome = new Label();
            labelCoffeeManagement = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(buttonOrderList);
            panelMenu.Controls.Add(buttonCreatOrder);
            panelMenu.Controls.Add(buttonMenuManagement);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(191, 513);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panel1_Paint;
            // 
            // buttonOrderList
            // 
            buttonOrderList.Dock = DockStyle.Top;
            buttonOrderList.FlatStyle = FlatStyle.Flat;
            buttonOrderList.ForeColor = SystemColors.ButtonHighlight;
            buttonOrderList.Location = new Point(0, 144);
            buttonOrderList.Name = "buttonOrderList";
            buttonOrderList.Size = new Size(191, 45);
            buttonOrderList.TabIndex = 5;
            buttonOrderList.Text = "Order List";
            buttonOrderList.UseVisualStyleBackColor = true;
            buttonOrderList.Click += buttonOrderList_Click;
            // 
            // buttonCreatOrder
            // 
            buttonCreatOrder.Dock = DockStyle.Top;
            buttonCreatOrder.FlatStyle = FlatStyle.Flat;
            buttonCreatOrder.ForeColor = SystemColors.ButtonHighlight;
            buttonCreatOrder.Location = new Point(0, 99);
            buttonCreatOrder.Name = "buttonCreatOrder";
            buttonCreatOrder.Size = new Size(191, 45);
            buttonCreatOrder.TabIndex = 4;
            buttonCreatOrder.Text = "Create Order";
            buttonCreatOrder.UseVisualStyleBackColor = true;
            buttonCreatOrder.Click += buttonCreatOrder_Click;
            // 
            // buttonMenuManagement
            // 
            buttonMenuManagement.BackColor = Color.Transparent;
            buttonMenuManagement.Dock = DockStyle.Top;
            buttonMenuManagement.FlatStyle = FlatStyle.Flat;
            buttonMenuManagement.ForeColor = SystemColors.ButtonHighlight;
            buttonMenuManagement.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMenuManagement.Location = new Point(0, 54);
            buttonMenuManagement.Name = "buttonMenuManagement";
            buttonMenuManagement.Size = new Size(191, 45);
            buttonMenuManagement.TabIndex = 3;
            buttonMenuManagement.Text = "Menu Management";
            buttonMenuManagement.UseVisualStyleBackColor = false;
            buttonMenuManagement.Click += buttonShowMenuForm_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.Controls.Add(labelHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ForeColor = SystemColors.ActiveBorder;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(191, 54);
            panelLogo.TabIndex = 2;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 15F);
            labelHome.ForeColor = SystemColors.ButtonHighlight;
            labelHome.Location = new Point(47, 3);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(104, 41);
            labelHome.TabIndex = 0;
            labelHome.Text = "HOME";
            labelHome.Click += label1_Click_1;
            // 
            // labelCoffeeManagement
            // 
            labelCoffeeManagement.AutoSize = true;
            labelCoffeeManagement.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoffeeManagement.ForeColor = Color.Chocolate;
            labelCoffeeManagement.Location = new Point(168, -1);
            labelCoffeeManagement.Name = "labelCoffeeManagement";
            labelCoffeeManagement.Size = new Size(325, 45);
            labelCoffeeManagement.TabIndex = 0;
            labelCoffeeManagement.Text = "Coffee Management";
            labelCoffeeManagement.TextAlign = ContentAlignment.MiddleCenter;
            labelCoffeeManagement.Click += labelCoffeeManagement_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelCoffeeManagement);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(191, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 54);
            panel1.TabIndex = 2;
            panel1.MouseDown += panelTitle_MouseDown;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonShadow;
            button3.Location = new Point(670, 1);
            button3.Name = "button3";
            button3.Size = new Size(40, 34);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnClose_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonShadow;
            button2.Location = new Point(629, 1);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(40, 34);
            button2.TabIndex = 5;
            button2.Text = "▢";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonShadow;
            button1.Location = new Point(589, 1);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(40, 34);
            button1.TabIndex = 4;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnMin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainMenuBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 513);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Font = new Font("Segoe MDL2 Assets", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button buttonMenuManagement;
        private Panel panelLogo;
        private Button buttonOrderList;
        private Button buttonCreatOrder;
        private Panel panel1;
        private Label labelHome;
        private Label labelCoffeeManagement;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}