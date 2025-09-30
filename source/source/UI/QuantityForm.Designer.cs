namespace source.UI
{
    partial class QuantityForm
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
            lblQuantity = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            nduquantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nduquantity).BeginInit();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.FlatStyle = FlatStyle.Flat;
            lblQuantity.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(98, 31);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(123, 38);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Quantity";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(38, 212);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(193, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // nduquantity
            // 
            nduquantity.Location = new Point(73, 120);
            nduquantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nduquantity.Name = "nduquantity";
            nduquantity.Size = new Size(165, 27);
            nduquantity.TabIndex = 4;
            nduquantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // QuantityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 283);
            Controls.Add(nduquantity);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblQuantity);
            Name = "QuantityForm";
            Text = "QuantityForm";
            ((System.ComponentModel.ISupportInitialize)nduquantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuantity;
        private Button btnOk;
        private Button btnCancel;
        private NumericUpDown nduquantity;
    }
}