namespace source.UI
{
    partial class MainForm_bỏ
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_bỏ));
            labelCoffeeManagement = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            sideBar = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            button4 = new Button();
            imageList1 = new ImageList(components);
            panel4 = new Panel();
            button5 = new Button();
            panel5 = new Panel();
            button6 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            sideBar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // labelCoffeeManagement
            // 
            labelCoffeeManagement.Anchor = AnchorStyles.Top;
            labelCoffeeManagement.AutoSize = true;
            labelCoffeeManagement.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoffeeManagement.ForeColor = Color.FromArgb(255, 128, 0);
            labelCoffeeManagement.Location = new Point(393, 5);
            labelCoffeeManagement.Margin = new Padding(0, 0, 10, 0);
            labelCoffeeManagement.Name = "labelCoffeeManagement";
            labelCoffeeManagement.Size = new Size(448, 60);
            labelCoffeeManagement.TabIndex = 0;
            labelCoffeeManagement.Text = "Coffee Management";
            labelCoffeeManagement.TextAlign = ContentAlignment.MiddleCenter;
            labelCoffeeManagement.Click += labelCoffeeManagement_Click;
            labelCoffeeManagement.MouseDown += panelTitle_MouseDown;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelCoffeeManagement);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 117);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            panel1.MouseDown += panelTitle_MouseDown;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonShadow;
            button3.Location = new Point(1211, 2);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(65, 60);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnClose_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonShadow;
            button2.Location = new Point(1145, 2);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(65, 60);
            button2.TabIndex = 5;
            button2.Text = "▢";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnMax_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonShadow;
            button1.Location = new Point(1079, 2);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(65, 60);
            button1.TabIndex = 4;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnMin_Click;
            // 
            // sideBar
            // 
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel5);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Margin = new Padding(5);
            sideBar.MaximumSize = new Size(512, 1280);
            sideBar.MinimumSize = new Size(109, 1280);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(512, 1280);
            sideBar.TabIndex = 3;
            sideBar.Paint += sideBar_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(menuButton);
            panel3.Location = new Point(5, 5);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 158);
            panel3.TabIndex = 4;
            panel3.MouseDown += panelTitle_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 59);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            label1.Click += label1_Click_4;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.BackgroundImageLayout = ImageLayout.Center;
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(19, 39);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(82, 70);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 1;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Location = new Point(5, 173);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 113);
            panel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 3;
            button4.ImageList = imageList1;
            button4.Location = new Point(-93, 0);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Padding = new Padding(110, 0, 0, 0);
            button4.Size = new Size(591, 119);
            button4.TabIndex = 0;
            button4.Text = "    Menu Management";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonShowMenuForm_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "CreateOrderIcon.png");
            imageList1.Images.SetKeyName(1, "HomeIcon.png");
            imageList1.Images.SetKeyName(2, "ListOrderIcon.png");
            imageList1.Images.SetKeyName(3, "MenuManagementIcon.png");
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Location = new Point(5, 296);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(498, 113);
            panel4.TabIndex = 5;
            // 
            // button5
            // 
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 0;
            button5.ImageList = imageList1;
            button5.Location = new Point(-86, 0);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Padding = new Padding(110, 0, 0, 0);
            button5.Size = new Size(584, 119);
            button5.TabIndex = 5;
            button5.Text = "   Create Order";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonCreatOrder_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button6);
            panel5.Location = new Point(5, 419);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(498, 113);
            panel5.TabIndex = 6;
            // 
            // button6
            // 
            button6.ImageIndex = 2;
            button6.ImageList = imageList1;
            button6.Location = new Point(-184, -6);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Padding = new Padding(110, 0, 0, 0);
            button6.Size = new Size(682, 119);
            button6.TabIndex = 6;
            button6.Text = "    List Order";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 15;
            sidebarTimer.Tick += side;
            // 
            // MainForm_bỏ
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 720);
            Controls.Add(sideBar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "MainForm_bỏ";
            Text = "Form1";
            Load += MainForm_Load;
            MouseDown += panelTitle_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sideBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label labelCoffeeManagement;
        private Button button1;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel sideBar;
        private Panel panel3;
        private Panel panel2;
        private Button button4;
        private Button button6;
        private PictureBox menuButton;
        private Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private ImageList imageList1;
        private Button button5;
        private Panel panel4;
        private Panel panel5;
    }
}