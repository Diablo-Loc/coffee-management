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
            components = new System.ComponentModel.Container();
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
            txtHour = new TextBox();
            txtWorkinghours = new TextBox();
            blbHour = new Label();
            lblWorkhour = new Label();
            btnOk = new Button();
            txtsalarycompute = new TextBox();
            label1 = new Label();
            tooltip = new ToolTip(components);
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Location = new Point(169, 75);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(165, 27);
            txtUserName.TabIndex = 30;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(57, 75);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 23);
            lblUserName.TabIndex = 29;
            lblUserName.Text = "UserName";
            // 
            // btncancel
            // 
            btncancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btncancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancel.Location = new Point(497, 355);
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
            txtSalary.Location = new Point(169, 223);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(165, 27);
            txtSalary.TabIndex = 25;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(169, 176);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(165, 27);
            txtPhone.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(169, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(165, 27);
            txtEmail.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(169, 27);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(165, 27);
            txtName.TabIndex = 22;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(57, 272);
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
            lblSalary.Location = new Point(57, 223);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(95, 23);
            lblSalary.TabIndex = 20;
            lblSalary.Text = "Base Salary";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(57, 177);
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
            lblEmail.Location = new Point(57, 126);
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
            lblName.Location = new Point(57, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 17;
            lblName.Text = "Name";
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRole.Location = new Point(169, 272);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(165, 27);
            txtRole.TabIndex = 31;
            // 
            // txtHour
            // 
            txtHour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHour.Location = new Point(547, 177);
            txtHour.Name = "txtHour";
            txtHour.PlaceholderText = "Amount worked in 1 hour";
            txtHour.Size = new Size(165, 27);
            txtHour.TabIndex = 39;
            tooltip.SetToolTip(txtHour, "Amount worked in 1 hour");
            // 
            // txtWorkinghours
            // 
            txtWorkinghours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtWorkinghours.Location = new Point(547, 126);
            txtWorkinghours.Name = "txtWorkinghours";
            txtWorkinghours.PlaceholderText = "number of hours * working days";
            txtWorkinghours.Size = new Size(165, 27);
            txtWorkinghours.TabIndex = 38;
            tooltip.SetToolTip(txtWorkinghours, "number of hours * working days");
            // 
            // blbHour
            // 
            blbHour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            blbHour.AutoSize = true;
            blbHour.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            blbHour.Location = new Point(398, 176);
            blbHour.Name = "blbHour";
            blbHour.Size = new Size(55, 23);
            blbHour.TabIndex = 37;
            blbHour.Text = "Hours";
            // 
            // lblWorkhour
            // 
            lblWorkhour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWorkhour.AutoSize = true;
            lblWorkhour.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorkhour.Location = new Point(398, 127);
            lblWorkhour.Name = "lblWorkhour";
            lblWorkhour.Size = new Size(121, 23);
            lblWorkhour.TabIndex = 36;
            lblWorkhour.Text = "Working hours";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(222, 355);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 35);
            btnOk.TabIndex = 40;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtsalarycompute
            // 
            txtsalarycompute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtsalarycompute.Location = new Point(547, 223);
            txtsalarycompute.Name = "txtsalarycompute";
            txtsalarycompute.ReadOnly = true;
            txtsalarycompute.Size = new Size(165, 27);
            txtsalarycompute.TabIndex = 42;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 223);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 41;
            label1.Text = "Salary";
            // 
            // EmployeeDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 402);
            Controls.Add(txtsalarycompute);
            Controls.Add(label1);
            Controls.Add(btnOk);
            Controls.Add(txtHour);
            Controls.Add(txtWorkinghours);
            Controls.Add(blbHour);
            Controls.Add(lblWorkhour);
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
        private TextBox txtHour;
        private TextBox txtWorkinghours;
        private Label blbHour;
        private Label lblWorkhour;
        private Button btnOk;
        private TextBox txtsalarycompute;
        private Label label1;
        private ToolTip tooltip;
    }
}