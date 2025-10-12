namespace source.UI
{
    partial class MainFormvut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormvut));
            btnExit = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnltopbar = new Panel();
            Menubutton = new Button();
            creatorderbutton = new Button();
            listorderbutton = new Button();
            Thanhbentrai = new Panel();
            panelLogo = new Panel();
            namebar = new Label();
            btnclosechildform = new Button();
            paneltitlebar = new Panel();
            control = new Panel();
            pictureBox1 = new PictureBox();
            pnltopbar.SuspendLayout();
            Thanhbentrai.SuspendLayout();
            paneltitlebar.SuspendLayout();
            control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnExit.Location = new Point(1157, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 33);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btn_MouseEnter;
            btnExit.MouseLeave += btn_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(1124, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(33, 33);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btn_MouseEnter;
            btnMaximize.MouseLeave += btn_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1091, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(33, 33);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btn_MouseEnter;
            btnMinimize.MouseLeave += btn_MouseLeave;
            // 
            // pnltopbar
            // 
            pnltopbar.BackColor = Color.FromArgb(64, 64, 64);
            pnltopbar.Controls.Add(btnMinimize);
            pnltopbar.Controls.Add(btnMaximize);
            pnltopbar.Controls.Add(btnExit);
            pnltopbar.Dock = DockStyle.Top;
            pnltopbar.Location = new Point(0, 0);
            pnltopbar.Name = "pnltopbar";
            pnltopbar.Size = new Size(1190, 33);
            pnltopbar.TabIndex = 1;
            // 
            // Menubutton
            // 
            Menubutton.Dock = DockStyle.Top;
            Menubutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menubutton.ForeColor = Color.Black;
            Menubutton.Image = (Image)resources.GetObject("Menubutton.Image");
            Menubutton.ImageAlign = ContentAlignment.MiddleLeft;
            Menubutton.Location = new Point(0, 89);
            Menubutton.Name = "Menubutton";
            Menubutton.Size = new Size(176, 50);
            Menubutton.TabIndex = 1;
            Menubutton.Text = "Menu";
            Menubutton.UseVisualStyleBackColor = true;
            Menubutton.Click += Menubutton_Click;
            // 
            // creatorderbutton
            // 
            creatorderbutton.Dock = DockStyle.Top;
            creatorderbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creatorderbutton.ForeColor = Color.Black;
            creatorderbutton.Image = (Image)resources.GetObject("creatorderbutton.Image");
            creatorderbutton.ImageAlign = ContentAlignment.MiddleLeft;
            creatorderbutton.Location = new Point(0, 139);
            creatorderbutton.Name = "creatorderbutton";
            creatorderbutton.Size = new Size(176, 50);
            creatorderbutton.TabIndex = 2;
            creatorderbutton.Text = "Create Order";
            creatorderbutton.UseVisualStyleBackColor = true;
            creatorderbutton.Click += creatorder_Click;
            // 
            // listorderbutton
            // 
            listorderbutton.Dock = DockStyle.Top;
            listorderbutton.ForeColor = Color.Black;
            listorderbutton.Image = (Image)resources.GetObject("listorderbutton.Image");
            listorderbutton.ImageAlign = ContentAlignment.MiddleLeft;
            listorderbutton.Location = new Point(0, 189);
            listorderbutton.Name = "listorderbutton";
            listorderbutton.Size = new Size(176, 50);
            listorderbutton.TabIndex = 3;
            listorderbutton.Text = "List Order";
            listorderbutton.UseVisualStyleBackColor = true;
            // 
            // Thanhbentrai
            // 
            Thanhbentrai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Thanhbentrai.BackColor = Color.White;
            Thanhbentrai.Controls.Add(listorderbutton);
            Thanhbentrai.Controls.Add(creatorderbutton);
            Thanhbentrai.Controls.Add(Menubutton);
            Thanhbentrai.Controls.Add(panelLogo);
            Thanhbentrai.Location = new Point(0, 31);
            Thanhbentrai.Name = "Thanhbentrai";
            Thanhbentrai.Size = new Size(176, 648);
            Thanhbentrai.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.Control;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(176, 89);
            panelLogo.TabIndex = 0;
            // 
            // namebar
            // 
            namebar.Anchor = AnchorStyles.Top;
            namebar.AutoSize = true;
            namebar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namebar.ForeColor = Color.Red;
            namebar.Location = new Point(341, 11);
            namebar.Name = "namebar";
            namebar.Size = new Size(360, 38);
            namebar.TabIndex = 0;
            namebar.Text = "Coffee Shop management";
            namebar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnclosechildform
            // 
            btnclosechildform.Dock = DockStyle.Left;
            btnclosechildform.FlatAppearance.BorderSize = 0;
            btnclosechildform.FlatStyle = FlatStyle.Flat;
            btnclosechildform.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclosechildform.ForeColor = Color.LightCoral;
            btnclosechildform.Location = new Point(0, 0);
            btnclosechildform.Name = "btnclosechildform";
            btnclosechildform.Size = new Size(53, 71);
            btnclosechildform.TabIndex = 1;
            btnclosechildform.Text = "X";
            btnclosechildform.UseVisualStyleBackColor = true;
            btnclosechildform.Click += btnclosechildform_Click;
            // 
            // paneltitlebar
            // 
            paneltitlebar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paneltitlebar.BackColor = SystemColors.WindowFrame;
            paneltitlebar.Controls.Add(btnclosechildform);
            paneltitlebar.Controls.Add(namebar);
            paneltitlebar.ForeColor = Color.White;
            paneltitlebar.Location = new Point(176, 31);
            paneltitlebar.Name = "paneltitlebar";
            paneltitlebar.Size = new Size(1014, 71);
            paneltitlebar.TabIndex = 1;
            // 
            // control
            // 
            control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            control.BackgroundImageLayout = ImageLayout.Stretch;
            control.Controls.Add(pictureBox1);
            control.ForeColor = Color.Black;
            control.Location = new Point(176, 97);
            control.Name = "control";
            control.Size = new Size(1014, 582);
            control.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1014, 582);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainFormvut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1190, 677);
            Controls.Add(pnltopbar);
            Controls.Add(control);
            Controls.Add(paneltitlebar);
            Controls.Add(Thanhbentrai);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainFormvut";
            Text = "Sample";
            pnltopbar.ResumeLayout(false);
            Thanhbentrai.ResumeLayout(false);
            paneltitlebar.ResumeLayout(false);
            paneltitlebar.PerformLayout();
            control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnExit;
        private Button btnMaximize;
        private Button btnMinimize;
        private Panel pnltopbar;
        private Button Menubutton;
        private Button creatorderbutton;
        private Button listorderbutton;
        private Panel Thanhbentrai;
        private Panel panelLogo;
        private Label namebar;
        private Button btnclosechildform;
        private Panel paneltitlebar;
        private Panel control;
        private PictureBox pictureBox1;
    }
}