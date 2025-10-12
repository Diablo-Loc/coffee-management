namespace source.UI
{
    partial class AdminManage
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
            btndelete = new Button();
            btnedit = new Button();
            btnadd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(21, 77);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(938, 407);
            dgvEmployee.TabIndex = 0;
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btndelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(323, 523);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(72, 38);
            btndelete.TabIndex = 10;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btnDelete_Click;
            // 
            // btnedit
            // 
            btnedit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnedit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.Location = new Point(206, 523);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(72, 38);
            btnedit.TabIndex = 9;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnEdit_Click;
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnadd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(82, 523);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(72, 38);
            btnadd.TabIndex = 8;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnAdd_Click;
            // 
            // AdminManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 592);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(dgvEmployee);
            Name = "AdminManage";
            Text = "AdminManage";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployee;
        private Button btndelete;
        private Button btnedit;
        private Button btnadd;
    }
}