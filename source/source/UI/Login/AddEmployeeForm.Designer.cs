namespace source.UI.Login
{
    partial class AddEmployeeForm
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
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblSalary = new Label();
            lblRole = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtSalary = new TextBox();
            btncancel = new Button();
            btnOK = new Button();
            cboRole = new ComboBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(72, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(72, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(72, 161);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 23);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.Location = new Point(72, 207);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(55, 23);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Salary";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(72, 256);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role";
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(184, 160);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(184, 207);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(207, 27);
            txtSalary.TabIndex = 8;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancel.Location = new Point(252, 435);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(82, 35);
            btncancel.TabIndex = 11;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(107, 435);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 35);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOk_Click;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(184, 256);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(207, 28);
            cboRole.TabIndex = 12;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(184, 311);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(207, 27);
            txtUserName.TabIndex = 14;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(72, 311);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 23);
            lblUserName.TabIndex = 13;
            lblUserName.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(184, 368);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(207, 27);
            txtPassword.TabIndex = 16;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(72, 368);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 514);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(cboRole);
            Controls.Add(btncancel);
            Controls.Add(btnOK);
            Controls.Add(txtSalary);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblRole);
            Controls.Add(lblSalary);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblSalary;
        private Label lblRole;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtSalary;
        private Button btncancel;
        private Button btnOK;
        private ComboBox cboRole;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}