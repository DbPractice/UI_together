namespace Hotel_SoftWare2
{
    partial class QLServiceForm
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
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.LbGia = new System.Windows.Forms.Label();
            this.LbTenDV = new System.Windows.Forms.Label();
            this.LbMaDV = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_WinformDataSet = new Hotel_SoftWare2.Hotel_WinformDataSet();
            this.loaiDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelSoftwareDataSet1 = new Hotel_SoftWare2.HotelSoftwareDataSet1();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.dichVuTableAdapter = new Hotel_SoftWare2.Hotel_WinformDataSetTableAdapters.DichVuTableAdapter();
            this.loaiDichVuTableAdapter = new Hotel_SoftWare2.HotelSoftwareDataSet1TableAdapters.LoaiDichVuTableAdapter();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_WinformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSoftwareDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnX.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnX.IconColor = System.Drawing.Color.White;
            this.btnX.IconSize = 30;
            this.btnX.Location = new System.Drawing.Point(81, 453);
            this.btnX.Name = "btnX";
            this.btnX.Rotation = 0D;
            this.btnX.Size = new System.Drawing.Size(94, 42);
            this.btnX.TabIndex = 21;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTimKiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(81, 393);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Rotation = 0D;
            this.btnTimKiem.Size = new System.Drawing.Size(94, 40);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(81, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Rotation = 0D;
            this.btnXoa.Size = new System.Drawing.Size(94, 40);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(81, 273);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(94, 40);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(81, 213);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(94, 40);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(464, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã Loại DV:";
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(555, 49);
            this.tbGia.Multiline = true;
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(133, 30);
            this.tbGia.TabIndex = 51;
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(272, 93);
            this.tbTen.Multiline = true;
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(133, 30);
            this.tbTen.TabIndex = 50;
            // 
            // tbMa
            // 
            this.tbMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMa.Location = new System.Drawing.Point(272, 46);
            this.tbMa.Multiline = true;
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(133, 30);
            this.tbMa.TabIndex = 49;
            // 
            // LbGia
            // 
            this.LbGia.AutoSize = true;
            this.LbGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.LbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGia.ForeColor = System.Drawing.Color.Transparent;
            this.LbGia.Location = new System.Drawing.Point(466, 52);
            this.LbGia.Name = "LbGia";
            this.LbGia.Size = new System.Drawing.Size(64, 17);
            this.LbGia.TabIndex = 48;
            this.LbGia.Text = "Đơn Giá:";
            // 
            // LbTenDV
            // 
            this.LbTenDV.AutoSize = true;
            this.LbTenDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.LbTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenDV.ForeColor = System.Drawing.Color.Transparent;
            this.LbTenDV.Location = new System.Drawing.Point(186, 96);
            this.LbTenDV.Name = "LbTenDV";
            this.LbTenDV.Size = new System.Drawing.Size(60, 17);
            this.LbTenDV.TabIndex = 47;
            this.LbTenDV.Text = "Tên DV:";
            // 
            // LbMaDV
            // 
            this.LbMaDV.AutoSize = true;
            this.LbMaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.LbMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaDV.ForeColor = System.Drawing.Color.Transparent;
            this.LbMaDV.Location = new System.Drawing.Point(186, 49);
            this.LbMaDV.Name = "LbMaDV";
            this.LbMaDV.Size = new System.Drawing.Size(54, 17);
            this.LbMaDV.TabIndex = 46;
            this.LbMaDV.Text = "Mã DV:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dichVuBindingSource, "MaLoaiDV", true));
            this.comboBox1.DataSource = this.loaiDichVuBindingSource;
            this.comboBox1.DisplayMember = "MaLoaiDV";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.ValueMember = "MaLoaiDV";
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "DichVu";
            this.dichVuBindingSource.DataSource = this.hotel_WinformDataSet;
            // 
            // hotel_WinformDataSet
            // 
            this.hotel_WinformDataSet.DataSetName = "Hotel_WinformDataSet";
            this.hotel_WinformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiDichVuBindingSource
            // 
            this.loaiDichVuBindingSource.DataMember = "LoaiDichVu";
            this.loaiDichVuBindingSource.DataSource = this.hotelSoftwareDataSet1;
            // 
            // hotelSoftwareDataSet1
            // 
            this.hotelSoftwareDataSet1.DataSetName = "HotelSoftwareDataSet1";
            this.hotelSoftwareDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(745, 76);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(119, 40);
            this.iconButtonSave.TabIndex = 55;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click_1);
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // loaiDichVuTableAdapter
            // 
            this.loaiDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(221, 156);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.Size = new System.Drawing.Size(681, 416);
            this.dgvServices.TabIndex = 56;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // QLServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.LbGia);
            this.Controls.Add(this.LbTenDV);
            this.Controls.Add(this.LbMaDV);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLServiceForm";
            this.Text = "QLServiceForm";
            this.Load += new System.EventHandler(this.QLServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_WinformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSoftwareDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label LbGia;
        private System.Windows.Forms.Label LbTenDV;
        private System.Windows.Forms.Label LbMaDV;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private Hotel_WinformDataSet hotel_WinformDataSet;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private Hotel_WinformDataSetTableAdapters.DichVuTableAdapter dichVuTableAdapter;
        private HotelSoftwareDataSet1 hotelSoftwareDataSet1;
        private System.Windows.Forms.BindingSource loaiDichVuBindingSource;
        private HotelSoftwareDataSet1TableAdapters.LoaiDichVuTableAdapter loaiDichVuTableAdapter;
        private System.Windows.Forms.DataGridView dgvServices;
    }
}