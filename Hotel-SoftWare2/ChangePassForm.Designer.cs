namespace Hotel_SoftWare2
{
    partial class ChangePassForm
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
            this.groupBoxChangePass = new System.Windows.Forms.GroupBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxSoCMND = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.labelSoCMND = new System.Windows.Forms.Label();
            this.groupBoxChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChangePass
            // 
            this.groupBoxChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxChangePass.Controls.Add(this.textBoxMaKH);
            this.groupBoxChangePass.Controls.Add(this.btnCancel);
            this.groupBoxChangePass.Controls.Add(this.textBoxTenKH);
            this.groupBoxChangePass.Controls.Add(this.textBoxSoCMND);
            this.groupBoxChangePass.Controls.Add(this.btnSave);
            this.groupBoxChangePass.Controls.Add(this.labelTenKH);
            this.groupBoxChangePass.Controls.Add(this.labelMaKH);
            this.groupBoxChangePass.Controls.Add(this.labelSoCMND);
            this.groupBoxChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChangePass.ForeColor = System.Drawing.Color.White;
            this.groupBoxChangePass.Location = new System.Drawing.Point(65, 57);
            this.groupBoxChangePass.Name = "groupBoxChangePass";
            this.groupBoxChangePass.Size = new System.Drawing.Size(822, 490);
            this.groupBoxChangePass.TabIndex = 28;
            this.groupBoxChangePass.TabStop = false;
            this.groupBoxChangePass.Text = "Đổi Mật Khẩu";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(230, 63);
            this.textBoxMaKH.Multiline = true;
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(200, 24);
            this.textBoxMaKH.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconSize = 30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(230, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(88, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(230, 140);
            this.textBoxTenKH.Multiline = true;
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(200, 24);
            this.textBoxTenKH.TabIndex = 9;
            // 
            // textBoxSoCMND
            // 
            this.textBoxSoCMND.Location = new System.Drawing.Point(230, 220);
            this.textBoxSoCMND.Multiline = true;
            this.textBoxSoCMND.Name = "textBoxSoCMND";
            this.textBoxSoCMND.Size = new System.Drawing.Size(200, 24);
            this.textBoxSoCMND.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(116, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKH.Location = new System.Drawing.Point(20, 140);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(176, 24);
            this.labelTenKH.TabIndex = 4;
            this.labelTenKH.Text = "Nhập Mật Khẩu Mới";
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKH.Location = new System.Drawing.Point(20, 60);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(169, 24);
            this.labelMaKH.TabIndex = 0;
            this.labelMaKH.Text = "Nhập Mật Khẩu Cũ";
            // 
            // labelSoCMND
            // 
            this.labelSoCMND.AutoSize = true;
            this.labelSoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoCMND.Location = new System.Drawing.Point(20, 220);
            this.labelSoCMND.Name = "labelSoCMND";
            this.labelSoCMND.Size = new System.Drawing.Size(205, 24);
            this.labelSoCMND.TabIndex = 3;
            this.labelSoCMND.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.groupBoxChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassForm";
            this.Text = "ChangePassForm";
            this.groupBoxChangePass.ResumeLayout(false);
            this.groupBoxChangePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChangePass;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxSoCMND;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.Label labelSoCMND;
    }
}