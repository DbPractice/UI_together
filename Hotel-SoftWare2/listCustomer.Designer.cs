namespace Hotel_SoftWare2
{
    partial class listCustomer
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
            this.dgvlistCus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistCus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistCus
            // 
            this.dgvlistCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistCus.Location = new System.Drawing.Point(37, 114);
            this.dgvlistCus.Name = "dgvlistCus";
            this.dgvlistCus.Size = new System.Drawing.Size(861, 422);
            this.dgvlistCus.TabIndex = 1;
            this.dgvlistCus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistCus_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(338, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // listCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlistCus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 37);
            this.Name = "listCustomer";
            this.Text = "listPhieuThue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.listCustomer_FormClosed);
            this.Load += new System.EventHandler(this.listCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistCus;
        private System.Windows.Forms.Label label1;
    }
}