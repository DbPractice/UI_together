namespace Hotel_SoftWare2
{
    partial class AddEmpForm
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
            this.textBoxHoTenNV = new System.Windows.Forms.TextBox();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.labelHoTenNV = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.dateTimePickerEmp = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAddEmp = new System.Windows.Forms.GroupBox();
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
            this.btnCancel.Location = new System.Drawing.Point(230, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(88, 40);
            this.btnCancel.TabIndex = 24;
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
            this.btnSave.Location = new System.Drawing.Point(100, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // textBoxHoTenNV
            // 
            this.textBoxHoTenNV.Location = new System.Drawing.Point(230, 100);
            this.textBoxHoTenNV.Multiline = true;
            this.textBoxHoTenNV.Name = "textBoxHoTenNV";
            this.textBoxHoTenNV.Size = new System.Drawing.Size(200, 24);
            this.textBoxHoTenNV.TabIndex = 22;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(230, 200);
            this.textBoxSDT.Multiline = true;
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(200, 24);
            this.textBoxSDT.TabIndex = 20;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(230, 50);
            this.textBoxMaNV.Multiline = true;
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(200, 24);
            this.textBoxMaNV.TabIndex = 18;
            // 
            // labelHoTenNV
            // 
            this.labelHoTenNV.AutoSize = true;
            this.labelHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTenNV.Location = new System.Drawing.Point(50, 100);
            this.labelHoTenNV.Name = "labelHoTenNV";
            this.labelHoTenNV.Size = new System.Drawing.Size(74, 24);
            this.labelHoTenNV.TabIndex = 17;
            this.labelHoTenNV.Text = "Họ Tên";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(50, 150);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(97, 24);
            this.labelNgaySinh.TabIndex = 16;
            this.labelNgaySinh.Text = "Ngày Sinh";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.Location = new System.Drawing.Point(50, 200);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(130, 24);
            this.labelSDT.TabIndex = 14;
            this.labelSDT.Text = "Số Điện Thoại";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.Location = new System.Drawing.Point(50, 50);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(131, 24);
            this.labelMaNV.TabIndex = 13;
            this.labelMaNV.Text = "Mã Nhân Viên";
            // 
            // dateTimePickerEmp
            // 
            this.dateTimePickerEmp.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerEmp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEmp.Location = new System.Drawing.Point(230, 149);
            this.dateTimePickerEmp.Name = "dateTimePickerEmp";
            this.dateTimePickerEmp.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerEmp.TabIndex = 25;
            // 
            // groupBoxAddEmp
            // 
            this.groupBoxAddEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAddEmp.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxAddEmp.Controls.Add(this.labelMaNV);
            this.groupBoxAddEmp.Controls.Add(this.btnCancel);
            this.groupBoxAddEmp.Controls.Add(this.dateTimePickerEmp);
            this.groupBoxAddEmp.Controls.Add(this.btnSave);
            this.groupBoxAddEmp.Controls.Add(this.labelHoTenNV);
            this.groupBoxAddEmp.Controls.Add(this.textBoxSDT);
            this.groupBoxAddEmp.Controls.Add(this.labelNgaySinh);
            this.groupBoxAddEmp.Controls.Add(this.labelSDT);
            this.groupBoxAddEmp.Controls.Add(this.textBoxHoTenNV);
            this.groupBoxAddEmp.Controls.Add(this.textBoxMaNV);
            this.groupBoxAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddEmp.Location = new System.Drawing.Point(20, 30);
            this.groupBoxAddEmp.Name = "groupBoxAddEmp";
            this.groupBoxAddEmp.Size = new System.Drawing.Size(450, 342);
            this.groupBoxAddEmp.TabIndex = 26;
            this.groupBoxAddEmp.TabStop = false;
            this.groupBoxAddEmp.Text = "Thêm Nhân Viên";
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.groupBoxAddEmp);
            this.Name = "AddEmpForm";
            this.Text = "AddEmpForm";
            this.groupBoxAddEmp.ResumeLayout(false);
            this.groupBoxAddEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox textBoxHoTenNV;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label labelHoTenNV;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmp;
        private System.Windows.Forms.GroupBox groupBoxAddEmp;
    }
}