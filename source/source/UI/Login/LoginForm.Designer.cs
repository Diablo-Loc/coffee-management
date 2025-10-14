namespace source.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblError = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            DoubleBuffered = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(94, 106);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(94, 160);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 42);
            label3.Name = "label3";
            label3.Size = new Size(74, 31);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(194, 105);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(214, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = SystemColors.ButtonHighlight;
            lblError.Location = new Point(228, 201);
            lblError.Name = "lblError";
            lblError.Size = new Size(52, 23);
            lblError.TabIndex = 5;
            lblError.Text = "Error!";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Location = new Point(112, 247);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(306, 247);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(44, 299);
            label4.Name = "label4";
            label4.Size = new Size(436, 23);
            label4.TabIndex = 8;
            label4.Text = "If you don't have an account, please contact to Admin...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 255, 255, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(106, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 364);
            panel1.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(729, 500);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblError;
        private Button btnLogin;
        private Button btnCancel;
        private Label label4;
        private Panel panel1;
    }
}