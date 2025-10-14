namespace source.UI
{
    partial class EmployeeDetailForm
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
            txtUserName = new TextBox();
            lblUserName = new Label();
            btncancel = new Button();
            txtSalary = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblRole = new Label();
            lblSalary = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Location = new Point(353, 69);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(207, 27);
            txtUserName.TabIndex = 30;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(241, 69);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 23);
            lblUserName.TabIndex = 29;
            lblUserName.Text = "UserName";
            // 
            // btncancel
            // 
            btncancel.Anchor = AnchorStyles.Bottom;
            btncancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancel.Location = new Point(439, 349);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(82, 35);
            btncancel.TabIndex = 27;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btnCancel_Click;
            // 
            // txtSalary
            // 
            txtSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSalary.Location = new Point(353, 217);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(207, 27);
            txtSalary.TabIndex = 25;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(353, 170);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(207, 27);
            txtPhone.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(353, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(207, 27);
            txtEmail.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(353, 21);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 22;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(241, 266);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 23);
            lblRole.TabIndex = 21;
            lblRole.Text = "Role";
            // 
            // lblSalary
            // 
            lblSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.Location = new Point(241, 217);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(55, 23);
            lblSalary.TabIndex = 20;
            lblSalary.Text = "Salary";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(241, 171);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 23);
            lblPhone.TabIndex = 19;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(241, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(241, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 17;
            lblName.Text = "Name";
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRole.Location = new Point(353, 266);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(207, 27);
            txtRole.TabIndex = 31;
            // 
            // EmployeeDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(txtRole);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(btncancel);
            Controls.Add(txtSalary);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblRole);
            Controls.Add(lblSalary);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Name = "EmployeeDetailForm";
            Text = "EmployeeDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label lblUserName;
        private Button btncancel;
        private TextBox txtSalary;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lblRole;
        private Label lblSalary;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblName;
        private TextBox txtRole;
    }
}