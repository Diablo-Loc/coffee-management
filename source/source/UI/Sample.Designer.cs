namespace source.UI
{
    partial class Sample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sample));
            Thanhbentrai = new Panel();
            listorderbutton = new Button();
            creatorderbutton = new Button();
            Menubutton = new Button();
            panelLogo = new Panel();
            paneltitlebar = new Panel();
            minimizebutton = new Button();
            zoombutton = new Button();
            exitbutton = new Button();
            btnclosechildform = new Button();
            namebar = new Label();
            control = new Panel();
            pictureBox1 = new PictureBox();
            Thanhbentrai.SuspendLayout();
            paneltitlebar.SuspendLayout();
            control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Thanhbentrai
            // 
            Thanhbentrai.BackColor = SystemColors.ControlDarkDark;
            Thanhbentrai.Controls.Add(listorderbutton);
            Thanhbentrai.Controls.Add(creatorderbutton);
            Thanhbentrai.Controls.Add(Menubutton);
            Thanhbentrai.Controls.Add(panelLogo);
            Thanhbentrai.Dock = DockStyle.Left;
            Thanhbentrai.Location = new Point(0, 0);
            Thanhbentrai.Name = "Thanhbentrai";
            Thanhbentrai.Size = new Size(143, 450);
            Thanhbentrai.TabIndex = 0;
            // 
            // listorderbutton
            // 
            listorderbutton.Dock = DockStyle.Top;
            listorderbutton.ForeColor = Color.Red;
            listorderbutton.Image = (Image)resources.GetObject("listorderbutton.Image");
            listorderbutton.ImageAlign = ContentAlignment.MiddleLeft;
            listorderbutton.Location = new Point(0, 169);
            listorderbutton.Name = "listorderbutton";
            listorderbutton.Size = new Size(143, 50);
            listorderbutton.TabIndex = 3;
            listorderbutton.Text = "List Order";
            listorderbutton.UseVisualStyleBackColor = true;
            listorderbutton.Click += listorderbutton_Click;
            // 
            // creatorderbutton
            // 
            creatorderbutton.Dock = DockStyle.Top;
            creatorderbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creatorderbutton.ForeColor = Color.Red;
            creatorderbutton.Image = (Image)resources.GetObject("creatorderbutton.Image");
            creatorderbutton.ImageAlign = ContentAlignment.MiddleLeft;
            creatorderbutton.Location = new Point(0, 119);
            creatorderbutton.Name = "creatorderbutton";
            creatorderbutton.Size = new Size(143, 50);
            creatorderbutton.TabIndex = 2;
            creatorderbutton.Text = "Creat Order";
            creatorderbutton.UseVisualStyleBackColor = true;
            creatorderbutton.Click += creatorder_Click;
            // 
            // Menubutton
            // 
            Menubutton.Dock = DockStyle.Top;
            Menubutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menubutton.ForeColor = Color.Red;
            Menubutton.Image = (Image)resources.GetObject("Menubutton.Image");
            Menubutton.ImageAlign = ContentAlignment.MiddleLeft;
            Menubutton.Location = new Point(0, 69);
            Menubutton.Name = "Menubutton";
            Menubutton.Size = new Size(143, 50);
            Menubutton.TabIndex = 1;
            Menubutton.Text = "Menu";
            Menubutton.UseVisualStyleBackColor = true;
            Menubutton.Click += Menubutton_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.ActiveCaptionText;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(143, 69);
            panelLogo.TabIndex = 0;
            // 
            // paneltitlebar
            // 
            paneltitlebar.BackColor = SystemColors.ActiveCaption;
            paneltitlebar.Controls.Add(minimizebutton);
            paneltitlebar.Controls.Add(zoombutton);
            paneltitlebar.Controls.Add(exitbutton);
            paneltitlebar.Controls.Add(btnclosechildform);
            paneltitlebar.Controls.Add(namebar);
            paneltitlebar.Dock = DockStyle.Top;
            paneltitlebar.Location = new Point(143, 0);
            paneltitlebar.Name = "paneltitlebar";
            paneltitlebar.Size = new Size(657, 69);
            paneltitlebar.TabIndex = 1;
            // 
            // minimizebutton
            // 
            minimizebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizebutton.FlatAppearance.BorderSize = 0;
            minimizebutton.FlatStyle = FlatStyle.Flat;
            minimizebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimizebutton.Location = new Point(577, 0);
            minimizebutton.Name = "minimizebutton";
            minimizebutton.Size = new Size(22, 35);
            minimizebutton.TabIndex = 3;
            minimizebutton.Text = "O";
            minimizebutton.UseVisualStyleBackColor = true;
            minimizebutton.Click += minimizebutton_Click;
            // 
            // zoombutton
            // 
            zoombutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            zoombutton.FlatAppearance.BorderSize = 0;
            zoombutton.FlatStyle = FlatStyle.Flat;
            zoombutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zoombutton.Location = new Point(605, 0);
            zoombutton.Name = "zoombutton";
            zoombutton.Size = new Size(23, 35);
            zoombutton.TabIndex = 4;
            zoombutton.Text = "O";
            zoombutton.UseVisualStyleBackColor = true;
            zoombutton.Click += zoombutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitbutton.FlatAppearance.BorderSize = 0;
            exitbutton.FlatStyle = FlatStyle.Flat;
            exitbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(634, 0);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(23, 35);
            exitbutton.TabIndex = 2;
            exitbutton.Text = "O";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // btnclosechildform
            // 
            btnclosechildform.Dock = DockStyle.Left;
            btnclosechildform.FlatAppearance.BorderSize = 0;
            btnclosechildform.FlatStyle = FlatStyle.Flat;
            btnclosechildform.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclosechildform.ForeColor = Color.Red;
            btnclosechildform.Location = new Point(0, 0);
            btnclosechildform.Name = "btnclosechildform";
            btnclosechildform.Size = new Size(89, 69);
            btnclosechildform.TabIndex = 1;
            btnclosechildform.Text = "X";
            btnclosechildform.UseVisualStyleBackColor = true;
            btnclosechildform.Click += btnclosechildform_Click;
            // 
            // namebar
            // 
            namebar.Anchor = AnchorStyles.Top;
            namebar.AutoSize = true;
            namebar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namebar.ForeColor = Color.Crimson;
            namebar.Location = new Point(95, 9);
            namebar.Name = "namebar";
            namebar.Size = new Size(513, 54);
            namebar.TabIndex = 0;
            namebar.Text = "Coffee Shop management";
            namebar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // control
            // 
            control.BackgroundImageLayout = ImageLayout.Stretch;
            control.Controls.Add(pictureBox1);
            control.Dock = DockStyle.Fill;
            control.Location = new Point(143, 69);
            control.Name = "control";
            control.Size = new Size(657, 381);
            control.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(657, 381);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(control);
            Controls.Add(paneltitlebar);
            Controls.Add(Thanhbentrai);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sample";
            Text = "Sample";
            Thanhbentrai.ResumeLayout(false);
            paneltitlebar.ResumeLayout(false);
            paneltitlebar.PerformLayout();
            control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Thanhbentrai;
        private Button Menubutton;
        private Panel panelLogo;
        private Panel paneltitlebar;
        private Button listorderbutton;
        private Button creatorderbutton;
        private Label namebar;
        private Panel control;
        private Button btnclosechildform;
        private PictureBox pictureBox1;
        private Button exitbutton;
        private Button minimizebutton;
        private Button zoombutton;
    }
}