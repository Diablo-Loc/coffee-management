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
            labelCoffeeManagement = new Label();
            panel1 = new Panel();
            labelHome = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(buttonOrderList);
            panelMenu.Controls.Add(buttonCreatOrder);
            panelMenu.Controls.Add(buttonMenuManagement);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(172, 450);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panel1_Paint;
            // 
            // buttonOrderList
            // 
            buttonOrderList.Dock = DockStyle.Top;
            buttonOrderList.FlatStyle = FlatStyle.Flat;
            buttonOrderList.ForeColor = SystemColors.ButtonHighlight;
            buttonOrderList.Location = new Point(0, 160);
            buttonOrderList.Name = "buttonOrderList";
            buttonOrderList.Size = new Size(172, 50);
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
            buttonCreatOrder.Location = new Point(0, 110);
            buttonCreatOrder.Name = "buttonCreatOrder";
            buttonCreatOrder.Size = new Size(172, 50);
            buttonCreatOrder.TabIndex = 4;
            buttonCreatOrder.Text = "Create Order";
            buttonCreatOrder.UseVisualStyleBackColor = true;
            // 
            // buttonMenuManagement
            // 
            buttonMenuManagement.Dock = DockStyle.Top;
            buttonMenuManagement.FlatStyle = FlatStyle.Flat;
            buttonMenuManagement.ForeColor = SystemColors.ButtonHighlight;
            buttonMenuManagement.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMenuManagement.Location = new Point(0, 60);
            buttonMenuManagement.Name = "buttonMenuManagement";
            buttonMenuManagement.Size = new Size(172, 50);
            buttonMenuManagement.TabIndex = 3;
            buttonMenuManagement.Text = "Menu Management";
            buttonMenuManagement.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Controls.Add(labelCoffeeManagement);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(172, 60);
            panelLogo.TabIndex = 2;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // labelCoffeeManagement
            // 
            labelCoffeeManagement.AutoSize = true;
            labelCoffeeManagement.Font = new Font("Segoe UI", 10F);
            labelCoffeeManagement.ForeColor = Color.Red;
            labelCoffeeManagement.Location = new Point(3, 21);
            labelCoffeeManagement.Name = "labelCoffeeManagement";
            labelCoffeeManagement.Size = new Size(166, 23);
            labelCoffeeManagement.TabIndex = 0;
            labelCoffeeManagement.Text = "Coffee Management";
            labelCoffeeManagement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(labelHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(172, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 60);
            panel1.TabIndex = 2;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 15F);
            labelHome.ForeColor = SystemColors.ButtonHighlight;
            labelHome.Location = new Point(244, 9);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(87, 35);
            labelHome.TabIndex = 0;
            labelHome.Text = "HOME";
            labelHome.Click += label1_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "Form1";
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
    }
}