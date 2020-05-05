namespace Hotel_SoftWare2
{
    partial class QlyPhong
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtThem = new FontAwesome.Sharp.IconButton();
            this.ibtSua = new FontAwesome.Sharp.IconButton();
            this.ibtXoa = new FontAwesome.Sharp.IconButton();
            this.ibtTimKiem = new FontAwesome.Sharp.IconButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tBGia = new System.Windows.Forms.TextBox();
            this.tBTenPhong = new System.Windows.Forms.TextBox();
            this.tBDienTich = new System.Windows.Forms.TextBox();
            this.tBMaPhong = new System.Windows.Forms.TextBox();
            this.cBTinhTrang = new System.Windows.Forms.ComboBox();
            this.cBMaLoai = new System.Windows.Forms.ComboBox();
            this.loaiPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelSoftwareDataSet2 = new Hotel_SoftWare2.HotelSoftwareDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.loaiPhongTableAdapter = new Hotel_SoftWare2.HotelSoftwareDataSet2TableAdapters.LoaiPhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSoftwareDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(290, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC PHÒNG CỦA KHÁCH SẠN";
            // 
            // ibtThem
            // 
            this.ibtThem.BackColor = System.Drawing.Color.Navy;
            this.ibtThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtThem.IconColor = System.Drawing.Color.White;
            this.ibtThem.IconSize = 27;
            this.ibtThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtThem.Location = new System.Drawing.Point(24, 220);
            this.ibtThem.Name = "ibtThem";
            this.ibtThem.Rotation = 0D;
            this.ibtThem.Size = new System.Drawing.Size(119, 40);
            this.ibtThem.TabIndex = 0;
            this.ibtThem.Text = "THÊM PHÒNG";
            this.ibtThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtThem.UseVisualStyleBackColor = false;
            // 
            // ibtSua
            // 
            this.ibtSua.BackColor = System.Drawing.Color.Navy;
            this.ibtSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtSua.IconColor = System.Drawing.Color.White;
            this.ibtSua.IconSize = 27;
            this.ibtSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtSua.Location = new System.Drawing.Point(24, 289);
            this.ibtSua.Name = "ibtSua";
            this.ibtSua.Rotation = 0D;
            this.ibtSua.Size = new System.Drawing.Size(119, 40);
            this.ibtSua.TabIndex = 1;
            this.ibtSua.Text = "SỬA PHÒNG";
            this.ibtSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtSua.UseVisualStyleBackColor = false;
            // 
            // ibtXoa
            // 
            this.ibtXoa.BackColor = System.Drawing.Color.Navy;
            this.ibtXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtXoa.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.ibtXoa.IconColor = System.Drawing.Color.White;
            this.ibtXoa.IconSize = 27;
            this.ibtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtXoa.Location = new System.Drawing.Point(24, 364);
            this.ibtXoa.Name = "ibtXoa";
            this.ibtXoa.Rotation = 0D;
            this.ibtXoa.Size = new System.Drawing.Size(119, 40);
            this.ibtXoa.TabIndex = 2;
            this.ibtXoa.Text = "XÓA PHÒNG";
            this.ibtXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtXoa.UseVisualStyleBackColor = false;
            this.ibtXoa.Click += new System.EventHandler(this.ibtXoa_Click);
            // 
            // ibtTimKiem
            // 
            this.ibtTimKiem.BackColor = System.Drawing.Color.Navy;
            this.ibtTimKiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtTimKiem.IconColor = System.Drawing.Color.White;
            this.ibtTimKiem.IconSize = 27;
            this.ibtTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtTimKiem.Location = new System.Drawing.Point(24, 443);
            this.ibtTimKiem.Name = "ibtTimKiem";
            this.ibtTimKiem.Rotation = 0D;
            this.ibtTimKiem.Size = new System.Drawing.Size(119, 40);
            this.ibtTimKiem.TabIndex = 3;
            this.ibtTimKiem.Text = "TÌM KIẾM";
            this.ibtTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(168, 186);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(760, 400);
            this.dgvUsers.TabIndex = 12;
            // 
            // tBGia
            // 
            this.tBGia.Location = new System.Drawing.Point(516, 25);
            this.tBGia.Name = "tBGia";
            this.tBGia.Size = new System.Drawing.Size(200, 20);
            this.tBGia.TabIndex = 13;
            // 
            // tBTenPhong
            // 
            this.tBTenPhong.Location = new System.Drawing.Point(110, 63);
            this.tBTenPhong.Name = "tBTenPhong";
            this.tBTenPhong.Size = new System.Drawing.Size(200, 20);
            this.tBTenPhong.TabIndex = 14;
            // 
            // tBDienTich
            // 
            this.tBDienTich.Location = new System.Drawing.Point(110, 95);
            this.tBDienTich.Name = "tBDienTich";
            this.tBDienTich.Size = new System.Drawing.Size(200, 20);
            this.tBDienTich.TabIndex = 15;
            // 
            // tBMaPhong
            // 
            this.tBMaPhong.Location = new System.Drawing.Point(110, 23);
            this.tBMaPhong.Name = "tBMaPhong";
            this.tBMaPhong.Size = new System.Drawing.Size(200, 20);
            this.tBMaPhong.TabIndex = 16;
            // 
            // cBTinhTrang
            // 
            this.cBTinhTrang.FormattingEnabled = true;
            this.cBTinhTrang.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cBTinhTrang.Location = new System.Drawing.Point(517, 66);
            this.cBTinhTrang.Name = "cBTinhTrang";
            this.cBTinhTrang.Size = new System.Drawing.Size(200, 21);
            this.cBTinhTrang.TabIndex = 18;
            // 
            // cBMaLoai
            // 
            this.cBMaLoai.DataSource = this.loaiPhongBindingSource;
            this.cBMaLoai.DisplayMember = "MaLoai";
            this.cBMaLoai.FormattingEnabled = true;
            this.cBMaLoai.Location = new System.Drawing.Point(517, 98);
            this.cBMaLoai.Name = "cBMaLoai";
            this.cBMaLoai.Size = new System.Drawing.Size(200, 21);
            this.cBMaLoai.TabIndex = 17;
            this.cBMaLoai.ValueMember = "MaLoai";
            // 
            // loaiPhongBindingSource
            // 
            this.loaiPhongBindingSource.DataMember = "LoaiPhong";
            this.loaiPhongBindingSource.DataSource = this.hotelSoftwareDataSet2;
            // 
            // hotelSoftwareDataSet2
            // 
            this.hotelSoftwareDataSet2.DataSetName = "HotelSoftwareDataSet2";
            this.hotelSoftwareDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Diện Tích:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(438, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giá Thuê:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(456, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã Loại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(438, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tình Trạng:";
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.BackColor = System.Drawing.Color.Navy;
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(785, 63);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(119, 40);
            this.iconButtonSave.TabIndex = 56;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Navy;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnX.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnX.IconColor = System.Drawing.Color.White;
            this.btnX.IconSize = 30;
            this.btnX.Location = new System.Drawing.Point(25, 522);
            this.btnX.Name = "btnX";
            this.btnX.Rotation = 0D;
            this.btnX.Size = new System.Drawing.Size(119, 42);
            this.btnX.TabIndex = 57;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // loaiPhongTableAdapter
            // 
            this.loaiPhongTableAdapter.ClearBeforeFill = true;
            // 
            // QlyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBGia);
            this.Controls.Add(this.tBTenPhong);
            this.Controls.Add(this.tBDienTich);
            this.Controls.Add(this.tBMaPhong);
            this.Controls.Add(this.cBTinhTrang);
            this.Controls.Add(this.cBMaLoai);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibtTimKiem);
            this.Controls.Add(this.ibtXoa);
            this.Controls.Add(this.ibtSua);
            this.Controls.Add(this.ibtThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QlyPhong";
            this.Text = "QlyPhong";
            this.Load += new System.EventHandler(this.QlyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSoftwareDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtThem;
        private FontAwesome.Sharp.IconButton ibtSua;
        private FontAwesome.Sharp.IconButton ibtXoa;
        private FontAwesome.Sharp.IconButton ibtTimKiem;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox tBGia;
        private System.Windows.Forms.TextBox tBTenPhong;
        private System.Windows.Forms.TextBox tBDienTich;
        private System.Windows.Forms.TextBox tBMaPhong;
        private System.Windows.Forms.ComboBox cBTinhTrang;
        private System.Windows.Forms.ComboBox cBMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton btnX;
        private HotelSoftwareDataSet2 hotelSoftwareDataSet2;
        private System.Windows.Forms.BindingSource loaiPhongBindingSource;
        private HotelSoftwareDataSet2TableAdapters.LoaiPhongTableAdapter loaiPhongTableAdapter;
    }
}