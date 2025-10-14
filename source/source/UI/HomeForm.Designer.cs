namespace source.UI
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            lblTitle = new Label();
            panel1 = new Panel();
            lblRecommend = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Menu;
            lblTitle.Location = new Point(124, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(680, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to the coffee shop management application";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblRecommend);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 550);
            panel1.TabIndex = 1;
            // 
            // lblRecommend
            // 
            lblRecommend.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRecommend.AutoSize = true;
            lblRecommend.BackColor = Color.Transparent;
            lblRecommend.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecommend.ForeColor = SystemColors.Menu;
            lblRecommend.Location = new Point(106, 469);
            lblRecommend.Name = "lblRecommend";
            lblRecommend.Size = new Size(732, 76);
            lblRecommend.TabIndex = 1;
            lblRecommend.Text = "Do you have an account yet? If not, please contact admin!\r\nIf you have one, click here! Login";
            lblRecommend.Click += lblRecommend_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 550);
            Controls.Add(panel1);
            Name = "HomeForm";
            Text = "HomeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblRecommend;
    }
}