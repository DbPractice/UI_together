﻿namespace Hotel_SoftWare2
{
    partial class DoanhThuForm
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
            this.labelloaiTK = new System.Windows.Forms.Label();
            this.labeltuNgay = new System.Windows.Forms.Label();
            this.labeldenNgay = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEmp = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBoxTienPhongDetail = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxTienDVDetail = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBoxTien = new System.Windows.Forms.GroupBox();
            this.labelTongDT = new System.Windows.Forms.Label();
            this.labelTongTienDV = new System.Windows.Forms.Label();
            this.labelTongTienPhong = new System.Windows.Forms.Label();
            this.labelTienDV = new System.Windows.Forms.Label();
            this.labelTienPhong = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.buttonInFile = new System.Windows.Forms.Button();
            this.groupBoxTienPhongDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxTienDVDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelloaiTK
            // 
            this.labelloaiTK.AutoSize = true;
            this.labelloaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloaiTK.ForeColor = System.Drawing.Color.White;
            this.labelloaiTK.Location = new System.Drawing.Point(52, 53);
            this.labelloaiTK.Name = "labelloaiTK";
            this.labelloaiTK.Size = new System.Drawing.Size(101, 17);
            this.labelloaiTK.TabIndex = 2;
            this.labelloaiTK.Text = "Loại Thống Kê";
            // 
            // labeltuNgay
            // 
            this.labeltuNgay.AutoSize = true;
            this.labeltuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltuNgay.ForeColor = System.Drawing.Color.White;
            this.labeltuNgay.Location = new System.Drawing.Point(322, 53);
            this.labeltuNgay.Name = "labeltuNgay";
            this.labeltuNgay.Size = new System.Drawing.Size(62, 17);
            this.labeltuNgay.TabIndex = 3;
            this.labeltuNgay.Text = "Từ Ngày\r\n";
            // 
            // labeldenNgay
            // 
            this.labeldenNgay.AutoSize = true;
            this.labeldenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldenNgay.ForeColor = System.Drawing.Color.White;
            this.labeldenNgay.Location = new System.Drawing.Point(597, 53);
            this.labeldenNgay.Name = "labeldenNgay";
            this.labeldenNgay.Size = new System.Drawing.Size(71, 17);
            this.labeldenNgay.TabIndex = 4;
            this.labeldenNgay.Text = "Đến Ngày";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo Ngày",
            "Theo Tháng"});
            this.comboBox1.Location = new System.Drawing.Point(55, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePickerEmp
            // 
            this.dateTimePickerEmp.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerEmp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEmp.Location = new System.Drawing.Point(325, 85);
            this.dateTimePickerEmp.Name = "dateTimePickerEmp";
            this.dateTimePickerEmp.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerEmp.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(589, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(816, 73);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(112, 40);
            this.btnThongKe.TabIndex = 28;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // groupBoxTienPhongDetail
            // 
            this.groupBoxTienPhongDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTienPhongDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTienPhongDetail.Controls.Add(this.dataGridView1);
            this.groupBoxTienPhongDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTienPhongDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxTienPhongDetail.Location = new System.Drawing.Point(325, 119);
            this.groupBoxTienPhongDetail.Name = "groupBoxTienPhongDetail";
            this.groupBoxTienPhongDetail.Size = new System.Drawing.Size(590, 234);
            this.groupBoxTienPhongDetail.TabIndex = 32;
            this.groupBoxTienPhongDetail.TabStop = false;
            this.groupBoxTienPhongDetail.Text = "Chi Tiết Tiền Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxTienDVDetail
            // 
            this.groupBoxTienDVDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTienDVDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTienDVDetail.Controls.Add(this.dataGridView2);
            this.groupBoxTienDVDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTienDVDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxTienDVDetail.Location = new System.Drawing.Point(325, 354);
            this.groupBoxTienDVDetail.Name = "groupBoxTienDVDetail";
            this.groupBoxTienDVDetail.Size = new System.Drawing.Size(590, 234);
            this.groupBoxTienDVDetail.TabIndex = 33;
            this.groupBoxTienDVDetail.TabStop = false;
            this.groupBoxTienDVDetail.Text = "Chi Tiết Tiền Dịch Vụ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 207);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBoxTien
            // 
            this.groupBoxTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTien.Controls.Add(this.labelTongDT);
            this.groupBoxTien.Controls.Add(this.labelTongTienDV);
            this.groupBoxTien.Controls.Add(this.labelTongTienPhong);
            this.groupBoxTien.Controls.Add(this.labelTienDV);
            this.groupBoxTien.Controls.Add(this.labelTienPhong);
            this.groupBoxTien.Controls.Add(this.labelTongTien);
            this.groupBoxTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTien.ForeColor = System.Drawing.Color.White;
            this.groupBoxTien.Location = new System.Drawing.Point(12, 119);
            this.groupBoxTien.Name = "groupBoxTien";
            this.groupBoxTien.Size = new System.Drawing.Size(307, 282);
            this.groupBoxTien.TabIndex = 34;
            this.groupBoxTien.TabStop = false;
            this.groupBoxTien.Text = "Tiền";
            // 
            // labelTongDT
            // 
            this.labelTongDT.AutoSize = true;
            this.labelTongDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDT.Location = new System.Drawing.Point(156, 201);
            this.labelTongDT.Name = "labelTongDT";
            this.labelTongDT.Size = new System.Drawing.Size(25, 24);
            this.labelTongDT.TabIndex = 14;
            this.labelTongDT.Text = "...";
            // 
            // labelTongTienDV
            // 
            this.labelTongTienDV.AutoSize = true;
            this.labelTongTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTienDV.Location = new System.Drawing.Point(156, 125);
            this.labelTongTienDV.Name = "labelTongTienDV";
            this.labelTongTienDV.Size = new System.Drawing.Size(25, 24);
            this.labelTongTienDV.TabIndex = 13;
            this.labelTongTienDV.Text = "...";
            // 
            // labelTongTienPhong
            // 
            this.labelTongTienPhong.AutoSize = true;
            this.labelTongTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTienPhong.Location = new System.Drawing.Point(156, 49);
            this.labelTongTienPhong.Name = "labelTongTienPhong";
            this.labelTongTienPhong.Size = new System.Drawing.Size(25, 24);
            this.labelTongTienPhong.TabIndex = 12;
            this.labelTongTienPhong.Text = "...";
            // 
            // labelTienDV
            // 
            this.labelTienDV.AutoSize = true;
            this.labelTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienDV.Location = new System.Drawing.Point(12, 129);
            this.labelTienDV.Name = "labelTienDV";
            this.labelTienDV.Size = new System.Drawing.Size(139, 20);
            this.labelTienDV.TabIndex = 4;
            this.labelTienDV.Text = "Tổng Tiền Dịch Vụ";
            // 
            // labelTienPhong
            // 
            this.labelTienPhong.AutoSize = true;
            this.labelTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhong.Location = new System.Drawing.Point(12, 53);
            this.labelTienPhong.Name = "labelTienPhong";
            this.labelTienPhong.Size = new System.Drawing.Size(129, 20);
            this.labelTienPhong.TabIndex = 0;
            this.labelTienPhong.Text = "Tổng Tiền Phòng\r\n";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(13, 201);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(128, 20);
            this.labelTongTien.TabIndex = 3;
            this.labelTongTien.Text = "Tổng Doanh Thu";
            // 
            // buttonInFile
            // 
            this.buttonInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInFile.Location = new System.Drawing.Point(103, 470);
            this.buttonInFile.Name = "buttonInFile";
            this.buttonInFile.Size = new System.Drawing.Size(112, 40);
            this.buttonInFile.TabIndex = 35;
            this.buttonInFile.Text = "In Exel";
            this.buttonInFile.UseVisualStyleBackColor = true;
            // 
            // DoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.buttonInFile);
            this.Controls.Add(this.groupBoxTien);
            this.Controls.Add(this.groupBoxTienDVDetail);
            this.Controls.Add(this.groupBoxTienPhongDetail);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePickerEmp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labeldenNgay);
            this.Controls.Add(this.labeltuNgay);
            this.Controls.Add(this.labelloaiTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThuForm";
            this.Text = "DoanhThuForm";
            this.groupBoxTienPhongDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxTienDVDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxTien.ResumeLayout(false);
            this.groupBoxTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelloaiTK;
        private System.Windows.Forms.Label labeltuNgay;
        private System.Windows.Forms.Label labeldenNgay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBoxTienPhongDetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxTienDVDetail;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBoxTien;
        private System.Windows.Forms.Label labelTongDT;
        private System.Windows.Forms.Label labelTongTienDV;
        private System.Windows.Forms.Label labelTongTienPhong;
        private System.Windows.Forms.Label labelTienDV;
        private System.Windows.Forms.Label labelTienPhong;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Button buttonInFile;
    }
}