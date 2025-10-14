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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnltopbar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnExit = new Button();
            pnlMenu = new Panel();
            btnReport = new Button();
            btnMenuForManager = new Button();
            btnManageCashier = new Button();
            btnEmployee = new Button();
            btnCreatOrder = new Button();
            btnMenu = new Button();
            btnHome = new Button();
            pnlNameGroup = new Panel();
            lblmain = new Label();
            panel2 = new Panel();
            lblUserInfo = new Label();
            namebar = new Label();
            pnlHienThi = new Panel();
            pictureBox1 = new PictureBox();
            pnltopbar.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlNameGroup.SuspendLayout();
            panel2.SuspendLayout();
            pnlHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnltopbar
            // 
            pnltopbar.BackColor = Color.FromArgb(64, 64, 64);
            pnltopbar.Controls.Add(btnMinimize);
            pnltopbar.Controls.Add(btnMaximize);
            pnltopbar.Controls.Add(btnExit);
            pnltopbar.Dock = DockStyle.Top;
            pnltopbar.Location = new Point(0, 0);
            pnltopbar.Margin = new Padding(1);
            pnltopbar.Name = "pnltopbar";
            pnltopbar.Size = new Size(1197, 33);
            pnltopbar.TabIndex = 0;
            pnltopbar.MouseDown += pnlTopBar_MouseDown;
            pnltopbar.MouseMove += pnlTopBar_MouseDown;
            pnltopbar.MouseUp += pnlTopBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1098, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(33, 33);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "--";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btn_MouseEnter;
            btnMinimize.MouseLeave += btn_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(1131, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(33, 33);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btn_MouseEnter;
            btnMaximize.MouseLeave += btn_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(1164, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 33);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btn_MouseEnter;
            btnExit.MouseLeave += btn_MouseLeave;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DimGray;
            pnlMenu.Controls.Add(btnReport);
            pnlMenu.Controls.Add(btnMenuForManager);
            pnlMenu.Controls.Add(btnManageCashier);
            pnlMenu.Controls.Add(btnEmployee);
            pnlMenu.Controls.Add(btnCreatOrder);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(pnlNameGroup);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 33);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 759);
            pnlMenu.TabIndex = 1;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.Location = new Point(0, 562);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(200, 75);
            btnReport.TabIndex = 9;
            btnReport.Text = "Manage Order";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnMenuForManager
            // 
            btnMenuForManager.Dock = DockStyle.Top;
            btnMenuForManager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuForManager.Location = new Point(0, 487);
            btnMenuForManager.Name = "btnMenuForManager";
            btnMenuForManager.Size = new Size(200, 75);
            btnMenuForManager.TabIndex = 8;
            btnMenuForManager.Text = "Menu";
            btnMenuForManager.UseVisualStyleBackColor = true;
            btnMenuForManager.Click += btnMenuForManager_Click;
            // 
            // btnManageCashier
            // 
            btnManageCashier.Dock = DockStyle.Top;
            btnManageCashier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageCashier.Location = new Point(0, 412);
            btnManageCashier.Name = "btnManageCashier";
            btnManageCashier.Size = new Size(200, 75);
            btnManageCashier.TabIndex = 7;
            btnManageCashier.Text = "Manage Cashier";
            btnManageCashier.UseVisualStyleBackColor = true;
            btnManageCashier.Click += btnManageCashier_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployee.Location = new Point(0, 337);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(200, 75);
            btnEmployee.TabIndex = 6;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCreatOrder
            // 
            btnCreatOrder.Dock = DockStyle.Top;
            btnCreatOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreatOrder.Location = new Point(0, 262);
            btnCreatOrder.Name = "btnCreatOrder";
            btnCreatOrder.Size = new Size(200, 75);
            btnCreatOrder.TabIndex = 1;
            btnCreatOrder.Text = "Create Order";
            btnCreatOrder.UseVisualStyleBackColor = true;
            btnCreatOrder.Click += btnOrderForm_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(0, 187);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(200, 75);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenuForm_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(0, 112);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 75);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlNameGroup
            // 
            pnlNameGroup.BackColor = Color.DarkGray;
            pnlNameGroup.Controls.Add(lblmain);
            pnlNameGroup.Dock = DockStyle.Top;
            pnlNameGroup.Location = new Point(0, 0);
            pnlNameGroup.Name = "pnlNameGroup";
            pnlNameGroup.Size = new Size(200, 112);
            pnlNameGroup.TabIndex = 0;
            // 
            // lblmain
            // 
            lblmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblmain.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblmain.ForeColor = Color.Cyan;
            lblmain.Location = new Point(12, 24);
            lblmain.Name = "lblmain";
            lblmain.Size = new Size(167, 50);
            lblmain.TabIndex = 0;
            lblmain.Text = "GROUP 3";
            lblmain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(lblUserInfo);
            panel2.Controls.Add(namebar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 88);
            panel2.TabIndex = 2;
            // 
            // lblUserInfo
            // 
            lblUserInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserInfo.Location = new Point(889, 46);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(96, 28);
            lblUserInfo.TabIndex = 3;
            lblUserInfo.Text = "User Info";
            lblUserInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // namebar
            // 
            namebar.Anchor = AnchorStyles.Top;
            namebar.AutoSize = true;
            namebar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namebar.ForeColor = Color.Red;
            namebar.Location = new Point(318, 25);
            namebar.Name = "namebar";
            namebar.Size = new Size(360, 38);
            namebar.TabIndex = 2;
            namebar.Text = "Coffee Shop management";
            namebar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHienThi
            // 
            pnlHienThi.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHienThi.BorderStyle = BorderStyle.FixedSingle;
            pnlHienThi.Controls.Add(pictureBox1);
            pnlHienThi.Dock = DockStyle.Fill;
            pnlHienThi.Location = new Point(200, 121);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(997, 671);
            pnlHienThi.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(995, 669);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 792);
            Controls.Add(pnlHienThi);
            Controls.Add(panel2);
            Controls.Add(pnlMenu);
            Controls.Add(pnltopbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            pnltopbar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlNameGroup.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltopbar;
        private Panel pnlMenu;
        private Button btnHome;
        private Panel pnlNameGroup;
        private Panel panel2;
        private Button btnMenu;
        private Label lblmain;
        private Panel pnlHienThi;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnCreatOrder;
        private Label namebar;
        private Button btnEmployee;
        private Label lblUserInfo;
        private Button btnManageCashier;
        private Button btnMenuForManager;
        private Button btnReport;
    }
}