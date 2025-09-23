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
            Thanhbentrai.BackColor = Color.White;
            Thanhbentrai.Controls.Add(listorderbutton);
            Thanhbentrai.Controls.Add(creatorderbutton);
            Thanhbentrai.Controls.Add(Menubutton);
            Thanhbentrai.Controls.Add(panelLogo);
            Thanhbentrai.Dock = DockStyle.Left;
            Thanhbentrai.Location = new Point(0, 0);
            Thanhbentrai.Name = "Thanhbentrai";
            Thanhbentrai.Size = new Size(176, 450);
            Thanhbentrai.TabIndex = 0;
            // 
            // listorderbutton
            // 
            listorderbutton.Dock = DockStyle.Top;
            listorderbutton.ForeColor = Color.Black;
            listorderbutton.Image = (Image)resources.GetObject("listorderbutton.Image");
            listorderbutton.ImageAlign = ContentAlignment.MiddleLeft;
            listorderbutton.Location = new Point(0, 166);
            listorderbutton.Name = "listorderbutton";
            listorderbutton.Size = new Size(176, 50);
            listorderbutton.TabIndex = 3;
            listorderbutton.Text = "List Order";
            listorderbutton.UseVisualStyleBackColor = true;
            // 
            // creatorderbutton
            // 
            creatorderbutton.Dock = DockStyle.Top;
            creatorderbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creatorderbutton.ForeColor = Color.Black;
            creatorderbutton.Image = (Image)resources.GetObject("creatorderbutton.Image");
            creatorderbutton.ImageAlign = ContentAlignment.MiddleLeft;
            creatorderbutton.Location = new Point(0, 116);
            creatorderbutton.Name = "creatorderbutton";
            creatorderbutton.Size = new Size(176, 50);
            creatorderbutton.TabIndex = 2;
            creatorderbutton.Text = "Create Order";
            creatorderbutton.UseVisualStyleBackColor = true;
            creatorderbutton.Click += creatorder_Click;
            // 
            // Menubutton
            // 
            Menubutton.Dock = DockStyle.Top;
            Menubutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menubutton.ForeColor = Color.Black;
            Menubutton.Image = (Image)resources.GetObject("Menubutton.Image");
            Menubutton.ImageAlign = ContentAlignment.MiddleLeft;
            Menubutton.Location = new Point(0, 66);
            Menubutton.Name = "Menubutton";
            Menubutton.Size = new Size(176, 50);
            Menubutton.TabIndex = 1;
            Menubutton.Text = "Menu";
            Menubutton.UseVisualStyleBackColor = true;
            Menubutton.Click += Menubutton_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.Control;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(176, 66);
            panelLogo.TabIndex = 0;
            // 
            // paneltitlebar
            // 
            paneltitlebar.BackColor = Color.FromArgb(54, 69, 97);
            paneltitlebar.Controls.Add(minimizebutton);
            paneltitlebar.Controls.Add(zoombutton);
            paneltitlebar.Controls.Add(exitbutton);
            paneltitlebar.Controls.Add(btnclosechildform);
            paneltitlebar.Controls.Add(namebar);
            paneltitlebar.Dock = DockStyle.Top;
            paneltitlebar.Location = new Point(176, 0);
            paneltitlebar.Name = "paneltitlebar";
            paneltitlebar.Size = new Size(624, 69);
            paneltitlebar.TabIndex = 1;
            paneltitlebar.MouseDown += panelTitle_MouseDown;
            paneltitlebar.MouseMove += panelTitle_MouseMove;
            paneltitlebar.MouseUp += panelTitle_MouseUp;
            // 
            // minimizebutton
            // 
            minimizebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizebutton.FlatAppearance.BorderSize = 0;
            minimizebutton.FlatStyle = FlatStyle.Flat;
            minimizebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimizebutton.Location = new Point(544, 0);
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
            zoombutton.Location = new Point(572, 0);
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
            exitbutton.Location = new Point(601, 0);
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
            btnclosechildform.ForeColor = Color.LightCoral;
            btnclosechildform.Location = new Point(0, 0);
            btnclosechildform.Name = "btnclosechildform";
            btnclosechildform.Size = new Size(53, 69);
            btnclosechildform.TabIndex = 1;
            btnclosechildform.Text = "X";
            btnclosechildform.UseVisualStyleBackColor = true;
            btnclosechildform.Click += btnclosechildform_Click;
            // 
            // namebar
            // 
            namebar.Anchor = AnchorStyles.Top;
            namebar.AutoSize = true;
            namebar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namebar.ForeColor = Color.FromArgb(180, 255, 105, 180);
            namebar.Location = new Point(136, 9);
            namebar.Name = "namebar";
            namebar.Size = new Size(360, 38);
            namebar.TabIndex = 0;
            namebar.Text = "Coffee Shop management";
            namebar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // control
            // 
            control.BackgroundImageLayout = ImageLayout.Stretch;
            control.Controls.Add(pictureBox1);
            control.Dock = DockStyle.Fill;
            control.ForeColor = Color.Black;
            control.Location = new Point(176, 69);
            control.Name = "control";
            control.Size = new Size(624, 381);
            control.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 381);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
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
            Name = "MainForm";
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