namespace Hotel_SoftWare2
{
    partial class billForm
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
            this.labelMaHD = new System.Windows.Forms.Label();
            this.labelIdHD = new System.Windows.Forms.Label();
            this.labelPhieuThue = new System.Windows.Forms.Label();
            this.textBoxMaPhieuThue = new System.Windows.Forms.TextBox();
            this.groupBoxTien = new System.Windows.Forms.GroupBox();
            this.labeltongT = new System.Windows.Forms.Label();
            this.labelTDV = new System.Windows.Forms.Label();
            this.labelTP = new System.Windows.Forms.Label();
            this.labelTienDV = new System.Windows.Forms.Label();
            this.labelTienPhong = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.groupBoxBillDetail = new System.Windows.Forms.GroupBox();
            this.groupBoxTienDVDetail = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBoxTienPhongDetail = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxCusInfor = new System.Windows.Forms.GroupBox();
            this.labelnvLap = new System.Windows.Forms.Label();
            this.labelnv = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelsodienthoai = new System.Windows.Forms.Label();
            this.labeldc = new System.Windows.Forms.Label();
            this.labelsoCMND = new System.Windows.Forms.Label();
            this.labeltenKH = new System.Windows.Forms.Label();
            this.labelmaKH = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelma = new System.Windows.Forms.Label();
            this.labelscmnd = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.groupBoxTien.SuspendLayout();
            this.groupBoxBillDetail.SuspendLayout();
            this.groupBoxTienDVDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxTienPhongDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxCusInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaHD
            // 
            this.labelMaHD.AutoSize = true;
            this.labelMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaHD.ForeColor = System.Drawing.Color.White;
            this.labelMaHD.Location = new System.Drawing.Point(12, 37);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(87, 17);
            this.labelMaHD.TabIndex = 1;
            this.labelMaHD.Text = "Mã Hóa Đơn\r\n";
            // 
            // labelIdHD
            // 
            this.labelIdHD.AutoSize = true;
            this.labelIdHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdHD.ForeColor = System.Drawing.Color.White;
            this.labelIdHD.Location = new System.Drawing.Point(143, 30);
            this.labelIdHD.Name = "labelIdHD";
            this.labelIdHD.Size = new System.Drawing.Size(25, 24);
            this.labelIdHD.TabIndex = 2;
            this.labelIdHD.Text = "...";
            // 
            // labelPhieuThue
            // 
            this.labelPhieuThue.AutoSize = true;
            this.labelPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhieuThue.ForeColor = System.Drawing.Color.White;
            this.labelPhieuThue.Location = new System.Drawing.Point(12, 84);
            this.labelPhieuThue.Name = "labelPhieuThue";
            this.labelPhieuThue.Size = new System.Drawing.Size(104, 17);
            this.labelPhieuThue.TabIndex = 3;
            this.labelPhieuThue.Text = "Mã Phiếu Thuê";
            // 
            // textBoxMaPhieuThue
            // 
            this.textBoxMaPhieuThue.Location = new System.Drawing.Point(147, 77);
            this.textBoxMaPhieuThue.Multiline = true;
            this.textBoxMaPhieuThue.Name = "textBoxMaPhieuThue";
            this.textBoxMaPhieuThue.Size = new System.Drawing.Size(88, 24);
            this.textBoxMaPhieuThue.TabIndex = 6;
            // 
            // groupBoxTien
            // 
            this.groupBoxTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTien.Controls.Add(this.labeltongT);
            this.groupBoxTien.Controls.Add(this.labelTDV);
            this.groupBoxTien.Controls.Add(this.labelTP);
            this.groupBoxTien.Controls.Add(this.labelTienDV);
            this.groupBoxTien.Controls.Add(this.labelTienPhong);
            this.groupBoxTien.Controls.Add(this.labelTongTien);
            this.groupBoxTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTien.ForeColor = System.Drawing.Color.White;
            this.groupBoxTien.Location = new System.Drawing.Point(12, 211);
            this.groupBoxTien.Name = "groupBoxTien";
            this.groupBoxTien.Size = new System.Drawing.Size(307, 282);
            this.groupBoxTien.TabIndex = 28;
            this.groupBoxTien.TabStop = false;
            this.groupBoxTien.Text = "Tiền";
            // 
            // labeltongT
            // 
            this.labeltongT.AutoSize = true;
            this.labeltongT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltongT.Location = new System.Drawing.Point(156, 201);
            this.labeltongT.Name = "labeltongT";
            this.labeltongT.Size = new System.Drawing.Size(25, 24);
            this.labeltongT.TabIndex = 14;
            this.labeltongT.Text = "...";
            // 
            // labelTDV
            // 
            this.labelTDV.AutoSize = true;
            this.labelTDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTDV.Location = new System.Drawing.Point(156, 125);
            this.labelTDV.Name = "labelTDV";
            this.labelTDV.Size = new System.Drawing.Size(25, 24);
            this.labelTDV.TabIndex = 13;
            this.labelTDV.Text = "...";
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTP.Location = new System.Drawing.Point(156, 49);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(25, 24);
            this.labelTP.TabIndex = 12;
            this.labelTP.Text = "...";
            // 
            // labelTienDV
            // 
            this.labelTienDV.AutoSize = true;
            this.labelTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienDV.Location = new System.Drawing.Point(40, 129);
            this.labelTienDV.Name = "labelTienDV";
            this.labelTienDV.Size = new System.Drawing.Size(99, 20);
            this.labelTienDV.TabIndex = 4;
            this.labelTienDV.Text = "Tiền Dịch Vụ";
            // 
            // labelTienPhong
            // 
            this.labelTienPhong.AutoSize = true;
            this.labelTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhong.Location = new System.Drawing.Point(40, 53);
            this.labelTienPhong.Name = "labelTienPhong";
            this.labelTienPhong.Size = new System.Drawing.Size(89, 20);
            this.labelTienPhong.TabIndex = 0;
            this.labelTienPhong.Text = "Tiền Phòng\r\n";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(40, 205);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(79, 20);
            this.labelTongTien.TabIndex = 3;
            this.labelTongTien.Text = "Tổng Tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnThanhToan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnThanhToan.IconColor = System.Drawing.Color.White;
            this.btnThanhToan.IconSize = 30;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(103, 516);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Rotation = 0D;
            this.btnThanhToan.Size = new System.Drawing.Size(119, 40);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // groupBoxBillDetail
            // 
            this.groupBoxBillDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBillDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxBillDetail.Controls.Add(this.groupBoxTienDVDetail);
            this.groupBoxBillDetail.Controls.Add(this.groupBoxTienPhongDetail);
            this.groupBoxBillDetail.Controls.Add(this.groupBoxCusInfor);
            this.groupBoxBillDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBillDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxBillDetail.Location = new System.Drawing.Point(325, 50);
            this.groupBoxBillDetail.Name = "groupBoxBillDetail";
            this.groupBoxBillDetail.Size = new System.Drawing.Size(602, 525);
            this.groupBoxBillDetail.TabIndex = 29;
            this.groupBoxBillDetail.TabStop = false;
            this.groupBoxBillDetail.Text = "Chi Tiết Hóa Đơn";
            // 
            // groupBoxTienDVDetail
            // 
            this.groupBoxTienDVDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTienDVDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTienDVDetail.Controls.Add(this.dataGridView2);
            this.groupBoxTienDVDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTienDVDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxTienDVDetail.Location = new System.Drawing.Point(6, 344);
            this.groupBoxTienDVDetail.Name = "groupBoxTienDVDetail";
            this.groupBoxTienDVDetail.Size = new System.Drawing.Size(590, 177);
            this.groupBoxTienDVDetail.TabIndex = 32;
            this.groupBoxTienDVDetail.TabStop = false;
            this.groupBoxTienDVDetail.Text = "Chi Tiết Tiền Dịch Vụ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBoxTienPhongDetail
            // 
            this.groupBoxTienPhongDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTienPhongDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTienPhongDetail.Controls.Add(this.dataGridView1);
            this.groupBoxTienPhongDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTienPhongDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxTienPhongDetail.Location = new System.Drawing.Point(6, 161);
            this.groupBoxTienPhongDetail.Name = "groupBoxTienPhongDetail";
            this.groupBoxTienPhongDetail.Size = new System.Drawing.Size(590, 177);
            this.groupBoxTienPhongDetail.TabIndex = 31;
            this.groupBoxTienPhongDetail.TabStop = false;
            this.groupBoxTienPhongDetail.Text = "Chi Tiết Tiền Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxCusInfor
            // 
            this.groupBoxCusInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCusInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxCusInfor.Controls.Add(this.labelnvLap);
            this.groupBoxCusInfor.Controls.Add(this.labelnv);
            this.groupBoxCusInfor.Controls.Add(this.labelSDT);
            this.groupBoxCusInfor.Controls.Add(this.labelDiaChi);
            this.groupBoxCusInfor.Controls.Add(this.labelsodienthoai);
            this.groupBoxCusInfor.Controls.Add(this.labeldc);
            this.groupBoxCusInfor.Controls.Add(this.labelsoCMND);
            this.groupBoxCusInfor.Controls.Add(this.labeltenKH);
            this.groupBoxCusInfor.Controls.Add(this.labelmaKH);
            this.groupBoxCusInfor.Controls.Add(this.labelname);
            this.groupBoxCusInfor.Controls.Add(this.labelma);
            this.groupBoxCusInfor.Controls.Add(this.labelscmnd);
            this.groupBoxCusInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCusInfor.ForeColor = System.Drawing.Color.White;
            this.groupBoxCusInfor.Location = new System.Drawing.Point(6, 28);
            this.groupBoxCusInfor.Name = "groupBoxCusInfor";
            this.groupBoxCusInfor.Size = new System.Drawing.Size(590, 127);
            this.groupBoxCusInfor.TabIndex = 30;
            this.groupBoxCusInfor.TabStop = false;
            this.groupBoxCusInfor.Text = "Thông Tin Khách Hàng";
            // 
            // labelnvLap
            // 
            this.labelnvLap.AutoSize = true;
            this.labelnvLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnvLap.Location = new System.Drawing.Point(456, 90);
            this.labelnvLap.Name = "labelnvLap";
            this.labelnvLap.Size = new System.Drawing.Size(25, 24);
            this.labelnvLap.TabIndex = 20;
            this.labelnvLap.Text = "...";
            // 
            // labelnv
            // 
            this.labelnv.AutoSize = true;
            this.labelnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnv.Location = new System.Drawing.Point(330, 96);
            this.labelnv.Name = "labelnv";
            this.labelnv.Size = new System.Drawing.Size(102, 17);
            this.labelnv.TabIndex = 19;
            this.labelnv.Text = "Nhân Viên Lập";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.Location = new System.Drawing.Point(456, 58);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(25, 24);
            this.labelSDT.TabIndex = 18;
            this.labelSDT.Text = "...";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.Location = new System.Drawing.Point(456, 29);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(25, 24);
            this.labelDiaChi.TabIndex = 17;
            this.labelDiaChi.Text = "...";
            // 
            // labelsodienthoai
            // 
            this.labelsodienthoai.AutoSize = true;
            this.labelsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsodienthoai.Location = new System.Drawing.Point(330, 65);
            this.labelsodienthoai.Name = "labelsodienthoai";
            this.labelsodienthoai.Size = new System.Drawing.Size(98, 17);
            this.labelsodienthoai.TabIndex = 16;
            this.labelsodienthoai.Text = "Số Điện Thoại";
            // 
            // labeldc
            // 
            this.labeldc.AutoSize = true;
            this.labeldc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldc.Location = new System.Drawing.Point(330, 34);
            this.labeldc.Name = "labeldc";
            this.labeldc.Size = new System.Drawing.Size(53, 17);
            this.labeldc.TabIndex = 15;
            this.labeldc.Text = "Địa Chỉ\r\n";
            // 
            // labelsoCMND
            // 
            this.labelsoCMND.AutoSize = true;
            this.labelsoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsoCMND.Location = new System.Drawing.Point(179, 89);
            this.labelsoCMND.Name = "labelsoCMND";
            this.labelsoCMND.Size = new System.Drawing.Size(25, 24);
            this.labelsoCMND.TabIndex = 14;
            this.labelsoCMND.Text = "...";
            // 
            // labeltenKH
            // 
            this.labeltenKH.AutoSize = true;
            this.labeltenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltenKH.Location = new System.Drawing.Point(179, 58);
            this.labeltenKH.Name = "labeltenKH";
            this.labeltenKH.Size = new System.Drawing.Size(25, 24);
            this.labeltenKH.TabIndex = 13;
            this.labeltenKH.Text = "...";
            // 
            // labelmaKH
            // 
            this.labelmaKH.AutoSize = true;
            this.labelmaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmaKH.Location = new System.Drawing.Point(179, 28);
            this.labelmaKH.Name = "labelmaKH";
            this.labelmaKH.Size = new System.Drawing.Size(25, 24);
            this.labelmaKH.TabIndex = 12;
            this.labelmaKH.Text = "...";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(50, 65);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(55, 17);
            this.labelname.TabIndex = 4;
            this.labelname.Text = "Họ Tên";
            // 
            // labelma
            // 
            this.labelma.AutoSize = true;
            this.labelma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelma.Location = new System.Drawing.Point(50, 35);
            this.labelma.Name = "labelma";
            this.labelma.Size = new System.Drawing.Size(109, 17);
            this.labelma.TabIndex = 0;
            this.labelma.Text = "Mã Khách Hàng";
            // 
            // labelscmnd
            // 
            this.labelscmnd.AutoSize = true;
            this.labelscmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelscmnd.Location = new System.Drawing.Point(50, 96);
            this.labelscmnd.Name = "labelscmnd";
            this.labelscmnd.Size = new System.Drawing.Size(69, 17);
            this.labelscmnd.TabIndex = 3;
            this.labelscmnd.Text = "Số CMND";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconSize = 30;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(147, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(101, 43);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // billForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBoxBillDetail);
            this.Controls.Add(this.groupBoxTien);
            this.Controls.Add(this.textBoxMaPhieuThue);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.labelPhieuThue);
            this.Controls.Add(this.labelIdHD);
            this.Controls.Add(this.labelMaHD);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billForm";
            this.Text = "billForm";
            this.groupBoxTien.ResumeLayout(false);
            this.groupBoxTien.PerformLayout();
            this.groupBoxBillDetail.ResumeLayout(false);
            this.groupBoxTienDVDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxTienPhongDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxCusInfor.ResumeLayout(false);
            this.groupBoxCusInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaHD;
        private System.Windows.Forms.Label labelIdHD;
        private System.Windows.Forms.Label labelPhieuThue;
        private System.Windows.Forms.TextBox textBoxMaPhieuThue;
        private System.Windows.Forms.GroupBox groupBoxTien;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private System.Windows.Forms.Label labelTienDV;
        private System.Windows.Forms.Label labelTienPhong;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label labeltongT;
        private System.Windows.Forms.Label labelTDV;
        private System.Windows.Forms.Label labelTP;
        private System.Windows.Forms.GroupBox groupBoxBillDetail;
        private System.Windows.Forms.GroupBox groupBoxTienDVDetail;
        private System.Windows.Forms.GroupBox groupBoxTienPhongDetail;
        private System.Windows.Forms.GroupBox groupBoxCusInfor;
        private System.Windows.Forms.Label labelsoCMND;
        private System.Windows.Forms.Label labeltenKH;
        private System.Windows.Forms.Label labelmaKH;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelma;
        private System.Windows.Forms.Label labelscmnd;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelsodienthoai;
        private System.Windows.Forms.Label labeldc;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelnvLap;
        private System.Windows.Forms.Label labelnv;
    }
}