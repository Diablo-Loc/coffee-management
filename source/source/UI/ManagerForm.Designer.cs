namespace source.UI
{
    partial class ManagerForm
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
            dgvEmployee = new DataGridView();
            cbSapXep = new ComboBox();
            btnTangLuong = new Button();
            btnGiamLuong = new Button();
            btnXemChiTiet = new Button();
            btnSort = new Button();
            lblSapXep = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(16, 68);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(1030, 480);
            dgvEmployee.TabIndex = 0;
            // 
            // cbSapXep
            // 
            cbSapXep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbSapXep.FormattingEnabled = true;
            cbSapXep.Items.AddRange(new object[] { "Name", "Salary" });
            cbSapXep.Location = new Point(818, 34);
            cbSapXep.Name = "cbSapXep";
            cbSapXep.Size = new Size(151, 28);
            cbSapXep.TabIndex = 1;
            // 
            // btnTangLuong
            // 
            btnTangLuong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTangLuong.Location = new Point(89, 574);
            btnTangLuong.Name = "btnTangLuong";
            btnTangLuong.Size = new Size(140, 29);
            btnTangLuong.TabIndex = 4;
            btnTangLuong.Text = "Increase Salary";
            btnTangLuong.UseVisualStyleBackColor = true;
            btnTangLuong.Click += btnTangLuong_Click;
            // 
            // btnGiamLuong
            // 
            btnGiamLuong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGiamLuong.Location = new Point(272, 574);
            btnGiamLuong.Name = "btnGiamLuong";
            btnGiamLuong.Size = new Size(127, 29);
            btnGiamLuong.TabIndex = 5;
            btnGiamLuong.Text = "Decrease Salary";
            btnGiamLuong.UseVisualStyleBackColor = true;
            btnGiamLuong.Click += btnGiamLuong_Click;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXemChiTiet.Location = new Point(467, 574);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(94, 29);
            btnXemChiTiet.TabIndex = 6;
            btnXemChiTiet.Text = "See details";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // btnSort
            // 
            btnSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSort.Location = new Point(987, 34);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(59, 29);
            btnSort.TabIndex = 7;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblSapXep
            // 
            lblSapXep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSapXep.AutoSize = true;
            lblSapXep.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSapXep.Location = new Point(752, 33);
            lblSapXep.Name = "lblSapXep";
            lblSapXep.Size = new Size(49, 25);
            lblSapXep.TabIndex = 2;
            lblSapXep.Text = "Sort:";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 627);
            Controls.Add(btnSort);
            Controls.Add(btnXemChiTiet);
            Controls.Add(btnGiamLuong);
            Controls.Add(btnTangLuong);
            Controls.Add(lblSapXep);
            Controls.Add(cbSapXep);
            Controls.Add(dgvEmployee);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private ComboBox cbSapXep;
        private Button btnTangLuong;
        private Button btnGiamLuong;
        private Button btnXemChiTiet;
        private Button btnSort;
        private Label lblSapXep;
    }
}