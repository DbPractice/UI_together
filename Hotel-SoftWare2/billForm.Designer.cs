using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlBill = new System.Windows.Forms.TabControl();
            this.tabPageTaoHoaDon = new System.Windows.Forms.TabPage();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.textBoxMaPhieuThue = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayTT = new System.Windows.Forms.DateTimePicker();
            this.labelngayTT = new System.Windows.Forms.Label();
            this.groupBoxGhiChu = new System.Windows.Forms.GroupBox();
            this.textBoxghiChu = new System.Windows.Forms.TextBox();
            this.comboBoxHTTT = new System.Windows.Forms.ComboBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.groupBoxBillDetail = new System.Windows.Forms.GroupBox();
            this.groupBoxTienDVDetail = new System.Windows.Forms.GroupBox();
            this.dgvTienDvDetail = new System.Windows.Forms.DataGridView();
            this.groupBoxTienPhongDetail = new System.Windows.Forms.GroupBox();
            this.dgvTienPhongDetail = new System.Windows.Forms.DataGridView();
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
            this.groupBoxTien = new System.Windows.Forms.GroupBox();
            this.labeltongT = new System.Windows.Forms.Label();
            this.labelTDV = new System.Windows.Forms.Label();
            this.labelTP = new System.Windows.Forms.Label();
            this.labelTienDV = new System.Windows.Forms.Label();
            this.labelTienPhong = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.btncreateBill = new FontAwesome.Sharp.IconButton();
            this.labelPhieuThue = new System.Windows.Forms.Label();
            this.labelIdHD = new System.Windows.Forms.Label();
            this.labelMaHD = new System.Windows.Forms.Label();
            this.tabPageListHoaDon = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListBill = new System.Windows.Forms.DataGridView();
            this.tabControlBill.SuspendLayout();
            this.tabPageTaoHoaDon.SuspendLayout();
            this.groupBoxGhiChu.SuspendLayout();
            this.groupBoxBillDetail.SuspendLayout();
            this.groupBoxTienDVDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDvDetail)).BeginInit();
            this.groupBoxTienPhongDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienPhongDetail)).BeginInit();
            this.groupBoxCusInfor.SuspendLayout();
            this.groupBoxTien.SuspendLayout();
            this.tabPageListHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBill
            // 
            this.tabControlBill.Controls.Add(this.tabPageTaoHoaDon);
            this.tabControlBill.Controls.Add(this.tabPageListHoaDon);
            this.tabControlBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBill.Location = new System.Drawing.Point(0, 0);
            this.tabControlBill.Name = "tabControlBill";
            this.tabControlBill.SelectedIndex = 0;
            this.tabControlBill.Size = new System.Drawing.Size(940, 600);
            this.tabControlBill.TabIndex = 37;
            // 
            // tabPageTaoHoaDon
            // 
            this.tabPageTaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPageTaoHoaDon.Controls.Add(this.textBoxMaPhong);
            this.tabPageTaoHoaDon.Controls.Add(this.textBoxMaPhieuThue);
            this.tabPageTaoHoaDon.Controls.Add(this.dateTimePickerNgayTT);
            this.tabPageTaoHoaDon.Controls.Add(this.labelngayTT);
            this.tabPageTaoHoaDon.Controls.Add(this.groupBoxGhiChu);
            this.tabPageTaoHoaDon.Controls.Add(this.comboBoxHTTT);
            this.tabPageTaoHoaDon.Controls.Add(this.btnSearch);
            this.tabPageTaoHoaDon.Controls.Add(this.groupBoxBillDetail);
            this.tabPageTaoHoaDon.Controls.Add(this.groupBoxTien);
            this.tabPageTaoHoaDon.Controls.Add(this.btncreateBill);
            this.tabPageTaoHoaDon.Controls.Add(this.labelPhieuThue);
            this.tabPageTaoHoaDon.Controls.Add(this.labelIdHD);
            this.tabPageTaoHoaDon.Controls.Add(this.labelMaHD);
            this.tabPageTaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.tabPageTaoHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaoHoaDon.Name = "tabPageTaoHoaDon";
            this.tabPageTaoHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaoHoaDon.Size = new System.Drawing.Size(932, 574);
            this.tabPageTaoHoaDon.TabIndex = 0;
            this.tabPageTaoHoaDon.Text = "Tạo hóa đơn";
            this.tabPageTaoHoaDon.Click += new System.EventHandler(this.tabPageTaoHoaDon_Click);
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaPhong.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxMaPhong.Location = new System.Drawing.Point(11, 20);
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(105, 23);
            this.textBoxMaPhong.TabIndex = 50;
            this.textBoxMaPhong.Text = "Nhập mã phòng";
            this.textBoxMaPhong.Enter += new System.EventHandler(this.textBoxSoDT_Enter);
            this.textBoxMaPhong.Leave += new System.EventHandler(this.textBoxMaPhong_Leave);
            // 
            // textBoxMaPhieuThue
            // 
            this.textBoxMaPhieuThue.Location = new System.Drawing.Point(144, 94);
            this.textBoxMaPhieuThue.Name = "textBoxMaPhieuThue";
            this.textBoxMaPhieuThue.Size = new System.Drawing.Size(86, 20);
            this.textBoxMaPhieuThue.TabIndex = 49;
            this.textBoxMaPhieuThue.TextChanged += new System.EventHandler(this.textBoxMaPhieuThue_TextChanged);
            // 
            // dateTimePickerNgayTT
            // 
            this.dateTimePickerNgayTT.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayTT.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerNgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTT.Location = new System.Drawing.Point(144, 121);
            this.dateTimePickerNgayTT.Name = "dateTimePickerNgayTT";
            this.dateTimePickerNgayTT.Size = new System.Drawing.Size(128, 24);
            this.dateTimePickerNgayTT.TabIndex = 48;
            // 
            // labelngayTT
            // 
            this.labelngayTT.AutoSize = true;
            this.labelngayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelngayTT.ForeColor = System.Drawing.Color.White;
            this.labelngayTT.Location = new System.Drawing.Point(8, 128);
            this.labelngayTT.Name = "labelngayTT";
            this.labelngayTT.Size = new System.Drawing.Size(123, 17);
            this.labelngayTT.TabIndex = 47;
            this.labelngayTT.Text = "Ngày Thanh Toán";
            // 
            // groupBoxGhiChu
            // 
            this.groupBoxGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxGhiChu.Controls.Add(this.textBoxghiChu);
            this.groupBoxGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGhiChu.ForeColor = System.Drawing.Color.White;
            this.groupBoxGhiChu.Location = new System.Drawing.Point(9, 326);
            this.groupBoxGhiChu.Name = "groupBoxGhiChu";
            this.groupBoxGhiChu.Size = new System.Drawing.Size(307, 147);
            this.groupBoxGhiChu.TabIndex = 46;
            this.groupBoxGhiChu.TabStop = false;
            this.groupBoxGhiChu.Text = "Ghi Chú";
            // 
            // textBoxghiChu
            // 
            this.textBoxghiChu.Location = new System.Drawing.Point(6, 17);
            this.textBoxghiChu.Multiline = true;
            this.textBoxghiChu.Name = "textBoxghiChu";
            this.textBoxghiChu.Size = new System.Drawing.Size(295, 124);
            this.textBoxghiChu.TabIndex = 0;
            // 
            // comboBoxHTTT
            // 
            this.comboBoxHTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHTTT.FormattingEnabled = true;
            this.comboBoxHTTT.Location = new System.Drawing.Point(189, 501);
            this.comboBoxHTTT.Name = "comboBoxHTTT";
            this.comboBoxHTTT.Size = new System.Drawing.Size(121, 33);
            this.comboBoxHTTT.TabIndex = 45;
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
            this.btnSearch.Location = new System.Drawing.Point(144, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(121, 30);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.groupBoxBillDetail.Location = new System.Drawing.Point(322, 35);
            this.groupBoxBillDetail.Name = "groupBoxBillDetail";
            this.groupBoxBillDetail.Size = new System.Drawing.Size(602, 525);
            this.groupBoxBillDetail.TabIndex = 42;
            this.groupBoxBillDetail.TabStop = false;
            this.groupBoxBillDetail.Text = "Chi Tiết Hóa Đơn";
            // 
            // groupBoxTienDVDetail
            // 
            this.groupBoxTienDVDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTienDVDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTienDVDetail.Controls.Add(this.dgvTienDvDetail);
            this.groupBoxTienDVDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTienDVDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxTienDVDetail.Location = new System.Drawing.Point(6, 344);
            this.groupBoxTienDVDetail.Name = "groupBoxTienDVDetail";
            this.groupBoxTienDVDetail.Size = new System.Drawing.Size(590, 177);
            this.groupBoxTienDVDetail.TabIndex = 32;
            this.groupBoxTienDVDetail.TabStop = false;
            this.groupBoxTienDVDetail.Text = "Chi Tiết Tiền Dịch Vụ";
            // 
            // dgvTienDvDetail
            // 
            this.dgvTienDvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienDvDetail.Location = new System.Drawing.Point(22, 21);
            this.dgvTienDvDetail.Name = "dgvTienDvDetail";
            this.dgvTienDvDetail.Size = new System.Drawing.Size(546, 150);
            this.dgvTienDvDetail.TabIndex = 1;
            // 
            // groupBoxTienPhongDetail
            // 
            this.groupBoxTienPhongDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTienPhongDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTienPhongDetail.Controls.Add(this.dgvTienPhongDetail);
            this.groupBoxTienPhongDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTienPhongDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxTienPhongDetail.Location = new System.Drawing.Point(6, 161);
            this.groupBoxTienPhongDetail.Name = "groupBoxTienPhongDetail";
            this.groupBoxTienPhongDetail.Size = new System.Drawing.Size(590, 177);
            this.groupBoxTienPhongDetail.TabIndex = 31;
            this.groupBoxTienPhongDetail.TabStop = false;
            this.groupBoxTienPhongDetail.Text = "Chi Tiết Tiền Phòng";
            // 
            // dgvTienPhongDetail
            // 
            this.dgvTienPhongDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienPhongDetail.Location = new System.Drawing.Point(22, 21);
            this.dgvTienPhongDetail.Name = "dgvTienPhongDetail";
            this.dgvTienPhongDetail.Size = new System.Drawing.Size(546, 150);
            this.dgvTienPhongDetail.TabIndex = 0;
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
            this.labelnvLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnvLap.Location = new System.Drawing.Point(456, 96);
            this.labelnvLap.Name = "labelnvLap";
            this.labelnvLap.Size = new System.Drawing.Size(20, 17);
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
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.Location = new System.Drawing.Point(456, 65);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(20, 17);
            this.labelSDT.TabIndex = 18;
            this.labelSDT.Text = "...";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.Location = new System.Drawing.Point(456, 34);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(20, 17);
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
            this.labelsoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsoCMND.Location = new System.Drawing.Point(179, 96);
            this.labelsoCMND.Name = "labelsoCMND";
            this.labelsoCMND.Size = new System.Drawing.Size(20, 17);
            this.labelsoCMND.TabIndex = 14;
            this.labelsoCMND.Text = "...";
            // 
            // labeltenKH
            // 
            this.labeltenKH.AutoSize = true;
            this.labeltenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltenKH.Location = new System.Drawing.Point(179, 65);
            this.labeltenKH.Name = "labeltenKH";
            this.labeltenKH.Size = new System.Drawing.Size(20, 17);
            this.labeltenKH.TabIndex = 13;
            this.labeltenKH.Text = "...";
            // 
            // labelmaKH
            // 
            this.labelmaKH.AutoSize = true;
            this.labelmaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmaKH.Location = new System.Drawing.Point(179, 35);
            this.labelmaKH.Name = "labelmaKH";
            this.labelmaKH.Size = new System.Drawing.Size(20, 17);
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
            this.groupBoxTien.Location = new System.Drawing.Point(9, 162);
            this.groupBoxTien.Name = "groupBoxTien";
            this.groupBoxTien.Size = new System.Drawing.Size(307, 147);
            this.groupBoxTien.TabIndex = 41;
            this.groupBoxTien.TabStop = false;
            this.groupBoxTien.Text = "Tiền";
            // 
            // labeltongT
            // 
            this.labeltongT.AutoSize = true;
            this.labeltongT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltongT.Location = new System.Drawing.Point(114, 106);
            this.labeltongT.Name = "labeltongT";
            this.labeltongT.Size = new System.Drawing.Size(25, 24);
            this.labeltongT.TabIndex = 14;
            this.labeltongT.Text = "...";
            // 
            // labelTDV
            // 
            this.labelTDV.AutoSize = true;
            this.labelTDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTDV.Location = new System.Drawing.Point(114, 73);
            this.labelTDV.Name = "labelTDV";
            this.labelTDV.Size = new System.Drawing.Size(25, 24);
            this.labelTDV.TabIndex = 13;
            this.labelTDV.Text = "...";
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTP.Location = new System.Drawing.Point(114, 33);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(25, 24);
            this.labelTP.TabIndex = 12;
            this.labelTP.Text = "...";
            // 
            // labelTienDV
            // 
            this.labelTienDV.AutoSize = true;
            this.labelTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienDV.Location = new System.Drawing.Point(6, 73);
            this.labelTienDV.Name = "labelTienDV";
            this.labelTienDV.Size = new System.Drawing.Size(99, 20);
            this.labelTienDV.TabIndex = 4;
            this.labelTienDV.Text = "Tiền Dịch Vụ";
            // 
            // labelTienPhong
            // 
            this.labelTienPhong.AutoSize = true;
            this.labelTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhong.Location = new System.Drawing.Point(6, 33);
            this.labelTienPhong.Name = "labelTienPhong";
            this.labelTienPhong.Size = new System.Drawing.Size(89, 20);
            this.labelTienPhong.TabIndex = 0;
            this.labelTienPhong.Text = "Tiền Phòng\r\n";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(8, 110);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(79, 20);
            this.labelTongTien.TabIndex = 3;
            this.labelTongTien.Text = "Tổng Tiền";
            // 
            // btncreateBill
            // 
            this.btncreateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btncreateBill.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateBill.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncreateBill.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btncreateBill.IconColor = System.Drawing.Color.White;
            this.btncreateBill.IconSize = 30;
            this.btncreateBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreateBill.Location = new System.Drawing.Point(9, 501);
            this.btncreateBill.Name = "btncreateBill";
            this.btncreateBill.Rotation = 0D;
            this.btncreateBill.Size = new System.Drawing.Size(139, 40);
            this.btncreateBill.TabIndex = 40;
            this.btncreateBill.Text = "Tạo Hóa Đơn";
            this.btncreateBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreateBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncreateBill.UseVisualStyleBackColor = false;
            this.btncreateBill.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // labelPhieuThue
            // 
            this.labelPhieuThue.AutoSize = true;
            this.labelPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhieuThue.ForeColor = System.Drawing.Color.White;
            this.labelPhieuThue.Location = new System.Drawing.Point(10, 94);
            this.labelPhieuThue.Name = "labelPhieuThue";
            this.labelPhieuThue.Size = new System.Drawing.Size(104, 17);
            this.labelPhieuThue.TabIndex = 39;
            this.labelPhieuThue.Text = "Mã Phiếu Thuê";
            // 
            // labelIdHD
            // 
            this.labelIdHD.AutoSize = true;
            this.labelIdHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdHD.ForeColor = System.Drawing.Color.White;
            this.labelIdHD.Location = new System.Drawing.Point(140, 56);
            this.labelIdHD.Name = "labelIdHD";
            this.labelIdHD.Size = new System.Drawing.Size(25, 24);
            this.labelIdHD.TabIndex = 38;
            this.labelIdHD.Text = "...";
            // 
            // labelMaHD
            // 
            this.labelMaHD.AutoSize = true;
            this.labelMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaHD.ForeColor = System.Drawing.Color.White;
            this.labelMaHD.Location = new System.Drawing.Point(10, 63);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(87, 17);
            this.labelMaHD.TabIndex = 37;
            this.labelMaHD.Text = "Mã Hóa Đơn\r\n";
            // 
            // tabPageListHoaDon
            // 
            this.tabPageListHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPageListHoaDon.Controls.Add(this.label1);
            this.tabPageListHoaDon.Controls.Add(this.dgvListBill);
            this.tabPageListHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabPageListHoaDon.Name = "tabPageListHoaDon";
            this.tabPageListHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListHoaDon.Size = new System.Drawing.Size(932, 574);
            this.tabPageListHoaDon.TabIndex = 1;
            this.tabPageListHoaDon.Text = "Danh sách hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Danh sách hóa đơn khách sạn";
            // 
            // dgvListBill
            // 
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListBill.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListBill.Location = new System.Drawing.Point(8, 64);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.Size = new System.Drawing.Size(916, 482);
            this.dgvListBill.TabIndex = 1;
            this.dgvListBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBill_CellClick);
            // 
            // billForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.tabControlBill);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billForm";
            this.Text = "billForm";
            this.Load += new System.EventHandler(this.billForm_Load);
            this.tabControlBill.ResumeLayout(false);
            this.tabPageTaoHoaDon.ResumeLayout(false);
            this.tabPageTaoHoaDon.PerformLayout();
            this.groupBoxGhiChu.ResumeLayout(false);
            this.groupBoxGhiChu.PerformLayout();
            this.groupBoxBillDetail.ResumeLayout(false);
            this.groupBoxTienDVDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDvDetail)).EndInit();
            this.groupBoxTienPhongDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienPhongDetail)).EndInit();
            this.groupBoxCusInfor.ResumeLayout(false);
            this.groupBoxCusInfor.PerformLayout();
            this.groupBoxTien.ResumeLayout(false);
            this.groupBoxTien.PerformLayout();
            this.tabPageListHoaDon.ResumeLayout(false);
            this.tabPageListHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBill;
        private System.Windows.Forms.TabPage tabPageTaoHoaDon;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTT;
        private System.Windows.Forms.Label labelngayTT;
        private System.Windows.Forms.GroupBox groupBoxGhiChu;
        private System.Windows.Forms.TextBox textBoxghiChu;
        private System.Windows.Forms.ComboBox comboBoxHTTT;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.GroupBox groupBoxBillDetail;
        private System.Windows.Forms.GroupBox groupBoxTienDVDetail;
        private System.Windows.Forms.DataGridView dgvTienDvDetail;
        private System.Windows.Forms.GroupBox groupBoxTienPhongDetail;
        private System.Windows.Forms.DataGridView dgvTienPhongDetail;
        private System.Windows.Forms.GroupBox groupBoxCusInfor;
        private System.Windows.Forms.Label labelnvLap;
        private System.Windows.Forms.Label labelnv;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelsodienthoai;
        private System.Windows.Forms.Label labeldc;
        private System.Windows.Forms.Label labelsoCMND;
        private System.Windows.Forms.Label labeltenKH;
        private System.Windows.Forms.Label labelmaKH;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelma;
        private System.Windows.Forms.Label labelscmnd;
        private System.Windows.Forms.GroupBox groupBoxTien;
        private System.Windows.Forms.Label labeltongT;
        private System.Windows.Forms.Label labelTDV;
        private System.Windows.Forms.Label labelTP;
        private System.Windows.Forms.Label labelTienDV;
        private System.Windows.Forms.Label labelTienPhong;
        private System.Windows.Forms.Label labelTongTien;
        private FontAwesome.Sharp.IconButton btncreateBill;
        private System.Windows.Forms.Label labelPhieuThue;
        private System.Windows.Forms.Label labelIdHD;
        private System.Windows.Forms.Label labelMaHD;
        private System.Windows.Forms.TabPage tabPageListHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListBill;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.TextBox textBoxMaPhieuThue;
    }
}