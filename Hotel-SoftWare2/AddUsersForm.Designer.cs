namespace Hotel_SoftWare2
{
    partial class AddUsersForm
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
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxNhapLaiMK = new System.Windows.Forms.TextBox();
            this.textBoxTenTK = new System.Windows.Forms.TextBox();
            this.labelMK = new System.Windows.Forms.Label();
            this.labelNhapLaiMK = new System.Windows.Forms.Label();
            this.labelTenTK = new System.Windows.Forms.Label();
            this.groupBoxQuyen = new System.Windows.Forms.GroupBox();
            this.checkBoxLeTan = new System.Windows.Forms.CheckBox();
            this.checkBoxQuanLy = new System.Windows.Forms.CheckBox();
            this.groupBoxAddEmp = new System.Windows.Forms.GroupBox();
            this.groupBoxQuyen.SuspendLayout();
            this.groupBoxAddEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconSize = 30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(230, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(88, 40);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(139, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(230, 80);
            this.textBoxMK.Multiline = true;
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(200, 24);
            this.textBoxMK.TabIndex = 33;
            // 
            // textBoxNhapLaiMK
            // 
            this.textBoxNhapLaiMK.Location = new System.Drawing.Point(230, 130);
            this.textBoxNhapLaiMK.Multiline = true;
            this.textBoxNhapLaiMK.Name = "textBoxNhapLaiMK";
            this.textBoxNhapLaiMK.Size = new System.Drawing.Size(200, 24);
            this.textBoxNhapLaiMK.TabIndex = 32;
            // 
            // textBoxTenTK
            // 
            this.textBoxTenTK.Location = new System.Drawing.Point(230, 30);
            this.textBoxTenTK.Multiline = true;
            this.textBoxTenTK.Name = "textBoxTenTK";
            this.textBoxTenTK.Size = new System.Drawing.Size(200, 24);
            this.textBoxTenTK.TabIndex = 31;
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMK.Location = new System.Drawing.Point(50, 80);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(89, 24);
            this.labelMK.TabIndex = 30;
            this.labelMK.Text = "Mật Khẩu";
            // 
            // labelNhapLaiMK
            // 
            this.labelNhapLaiMK.AutoSize = true;
            this.labelNhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapLaiMK.Location = new System.Drawing.Point(50, 130);
            this.labelNhapLaiMK.Name = "labelNhapLaiMK";
            this.labelNhapLaiMK.Size = new System.Drawing.Size(169, 24);
            this.labelNhapLaiMK.TabIndex = 29;
            this.labelNhapLaiMK.Text = "Nhập Lại Mật Khẩu";
            // 
            // labelTenTK
            // 
            this.labelTenTK.AutoSize = true;
            this.labelTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTK.Location = new System.Drawing.Point(50, 30);
            this.labelTenTK.Name = "labelTenTK";
            this.labelTenTK.Size = new System.Drawing.Size(135, 24);
            this.labelTenTK.TabIndex = 27;
            this.labelTenTK.Text = "Tên Tài Khoản";
            // 
            // groupBoxQuyen
            // 
            this.groupBoxQuyen.Controls.Add(this.checkBoxLeTan);
            this.groupBoxQuyen.Controls.Add(this.checkBoxQuanLy);
            this.groupBoxQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuyen.Location = new System.Drawing.Point(50, 180);
            this.groupBoxQuyen.Name = "groupBoxQuyen";
            this.groupBoxQuyen.Size = new System.Drawing.Size(380, 100);
            this.groupBoxQuyen.TabIndex = 36;
            this.groupBoxQuyen.TabStop = false;
            this.groupBoxQuyen.Text = "Quyền";
            // 
            // checkBoxLeTan
            // 
            this.checkBoxLeTan.AutoSize = true;
            this.checkBoxLeTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLeTan.Location = new System.Drawing.Point(216, 28);
            this.checkBoxLeTan.Name = "checkBoxLeTan";
            this.checkBoxLeTan.Size = new System.Drawing.Size(77, 24);
            this.checkBoxLeTan.TabIndex = 1;
            this.checkBoxLeTan.Text = "Lễ Tân";
            this.checkBoxLeTan.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuanLy
            // 
            this.checkBoxQuanLy.AutoSize = true;
            this.checkBoxQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxQuanLy.Location = new System.Drawing.Point(6, 28);
            this.checkBoxQuanLy.Name = "checkBoxQuanLy";
            this.checkBoxQuanLy.Size = new System.Drawing.Size(87, 24);
            this.checkBoxQuanLy.TabIndex = 0;
            this.checkBoxQuanLy.Text = "Quản Lý";
            this.checkBoxQuanLy.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddEmp
            // 
            this.groupBoxAddEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAddEmp.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxAddEmp.Controls.Add(this.textBoxTenTK);
            this.groupBoxAddEmp.Controls.Add(this.btnCancel);
            this.groupBoxAddEmp.Controls.Add(this.groupBoxQuyen);
            this.groupBoxAddEmp.Controls.Add(this.textBoxNhapLaiMK);
            this.groupBoxAddEmp.Controls.Add(this.textBoxMK);
            this.groupBoxAddEmp.Controls.Add(this.btnSave);
            this.groupBoxAddEmp.Controls.Add(this.labelTenTK);
            this.groupBoxAddEmp.Controls.Add(this.labelMK);
            this.groupBoxAddEmp.Controls.Add(this.labelNhapLaiMK);
            this.groupBoxAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddEmp.Location = new System.Drawing.Point(20, 30);
            this.groupBoxAddEmp.Name = "groupBoxAddEmp";
            this.groupBoxAddEmp.Size = new System.Drawing.Size(450, 342);
            this.groupBoxAddEmp.TabIndex = 37;
            this.groupBoxAddEmp.TabStop = false;
            this.groupBoxAddEmp.Text = "Thêm Tài Khoản";
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.groupBoxAddEmp);
            this.Name = "AddUsersForm";
            this.Text = "AddUsersForm";
            this.groupBoxQuyen.ResumeLayout(false);
            this.groupBoxQuyen.PerformLayout();
            this.groupBoxAddEmp.ResumeLayout(false);
            this.groupBoxAddEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.TextBox textBoxNhapLaiMK;
        private System.Windows.Forms.TextBox textBoxTenTK;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Label labelNhapLaiMK;
        private System.Windows.Forms.Label labelTenTK;
        private System.Windows.Forms.GroupBox groupBoxQuyen;
        private System.Windows.Forms.CheckBox checkBoxLeTan;
        private System.Windows.Forms.CheckBox checkBoxQuanLy;
        private System.Windows.Forms.GroupBox groupBoxAddEmp;
    }
}