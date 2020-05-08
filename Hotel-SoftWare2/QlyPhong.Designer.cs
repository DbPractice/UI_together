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
            this.label1 = new System.Windows.Forms.Label();
            this.iBtThem = new FontAwesome.Sharp.IconButton();
            this.iBtSua = new FontAwesome.Sharp.IconButton();
            this.iBtXoa = new FontAwesome.Sharp.IconButton();
            this.iBtTimKiem = new FontAwesome.Sharp.IconButton();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.textBoxDienTich = new System.Windows.Forms.TextBox();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.comboBoxTTphong = new System.Windows.Forms.ComboBox();
            this.comboBoxMaLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.labelTim = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
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
            // iBtThem
            // 
            this.iBtThem.BackColor = System.Drawing.Color.Navy;
            this.iBtThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtThem.IconColor = System.Drawing.Color.White;
            this.iBtThem.IconSize = 27;
            this.iBtThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtThem.Location = new System.Drawing.Point(24, 220);
            this.iBtThem.Name = "iBtThem";
            this.iBtThem.Rotation = 0D;
            this.iBtThem.Size = new System.Drawing.Size(119, 40);
            this.iBtThem.TabIndex = 0;
            this.iBtThem.Text = "THÊM PHÒNG";
            this.iBtThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtThem.UseVisualStyleBackColor = false;
            this.iBtThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // iBtSua
            // 
            this.iBtSua.BackColor = System.Drawing.Color.Navy;
            this.iBtSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBtSua.IconColor = System.Drawing.Color.White;
            this.iBtSua.IconSize = 27;
            this.iBtSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtSua.Location = new System.Drawing.Point(24, 289);
            this.iBtSua.Name = "iBtSua";
            this.iBtSua.Rotation = 0D;
            this.iBtSua.Size = new System.Drawing.Size(119, 40);
            this.iBtSua.TabIndex = 1;
            this.iBtSua.Text = "SỬA PHÒNG";
            this.iBtSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtSua.UseVisualStyleBackColor = false;
            this.iBtSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // iBtXoa
            // 
            this.iBtXoa.BackColor = System.Drawing.Color.Navy;
            this.iBtXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtXoa.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.iBtXoa.IconColor = System.Drawing.Color.White;
            this.iBtXoa.IconSize = 27;
            this.iBtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtXoa.Location = new System.Drawing.Point(24, 364);
            this.iBtXoa.Name = "iBtXoa";
            this.iBtXoa.Rotation = 0D;
            this.iBtXoa.Size = new System.Drawing.Size(119, 40);
            this.iBtXoa.TabIndex = 2;
            this.iBtXoa.Text = "XÓA PHÒNG";
            this.iBtXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtXoa.UseVisualStyleBackColor = false;
            this.iBtXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // iBtTimKiem
            // 
            this.iBtTimKiem.BackColor = System.Drawing.Color.Navy;
            this.iBtTimKiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtTimKiem.IconColor = System.Drawing.Color.White;
            this.iBtTimKiem.IconSize = 27;
            this.iBtTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtTimKiem.Location = new System.Drawing.Point(24, 443);
            this.iBtTimKiem.Name = "iBtTimKiem";
            this.iBtTimKiem.Rotation = 0D;
            this.iBtTimKiem.Size = new System.Drawing.Size(119, 40);
            this.iBtTimKiem.TabIndex = 3;
            this.iBtTimKiem.Text = "TÌM KIẾM";
            this.iBtTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvRoom
            // 
            this.dgvRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(168, 186);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.Size = new System.Drawing.Size(760, 400);
            this.dgvRoom.TabIndex = 12;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(516, 25);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(200, 20);
            this.textBoxGia.TabIndex = 13;
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.Location = new System.Drawing.Point(110, 63);
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.Size = new System.Drawing.Size(200, 20);
            this.textBoxTenPhong.TabIndex = 14;
            // 
            // textBoxDienTich
            // 
            this.textBoxDienTich.Location = new System.Drawing.Point(110, 95);
            this.textBoxDienTich.Name = "textBoxDienTich";
            this.textBoxDienTich.Size = new System.Drawing.Size(200, 20);
            this.textBoxDienTich.TabIndex = 15;
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Location = new System.Drawing.Point(110, 23);
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(200, 20);
            this.textBoxMaPhong.TabIndex = 16;
            // 
            // comboBoxTTphong
            // 
            this.comboBoxTTphong.FormattingEnabled = true;
            this.comboBoxTTphong.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBoxTTphong.Location = new System.Drawing.Point(517, 66);
            this.comboBoxTTphong.Name = "comboBoxTTphong";
            this.comboBoxTTphong.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTTphong.TabIndex = 18;
            // 
            // comboBoxMaLoai
            // 
            this.comboBoxMaLoai.FormattingEnabled = true;
            this.comboBoxMaLoai.Location = new System.Drawing.Point(517, 98);
            this.comboBoxMaLoai.Name = "comboBoxMaLoai";
            this.comboBoxMaLoai.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMaLoai.TabIndex = 17;
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
            this.iconButtonSave.Location = new System.Drawing.Point(774, 55);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(119, 40);
            this.iconButtonSave.TabIndex = 25;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
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
            this.btnX.Location = new System.Drawing.Point(24, 518);
            this.btnX.Name = "btnX";
            this.btnX.Rotation = 0D;
            this.btnX.Size = new System.Drawing.Size(119, 42);
            this.btnX.TabIndex = 61;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // labelTim
            // 
            this.labelTim.AutoSize = true;
            this.labelTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTim.ForeColor = System.Drawing.Color.Transparent;
            this.labelTim.Location = new System.Drawing.Point(22, 134);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(65, 15);
            this.labelTim.TabIndex = 63;
            this.labelTim.Text = "Tìm Kiếm:";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(110, 132);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(200, 20);
            this.textBoxTimKiem.TabIndex = 62;
            this.textBoxTimKiem.Click += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            // 
            // QlyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.textBoxTenPhong);
            this.Controls.Add(this.textBoxDienTich);
            this.Controls.Add(this.textBoxMaPhong);
            this.Controls.Add(this.comboBoxTTphong);
            this.Controls.Add(this.comboBoxMaLoai);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iBtTimKiem);
            this.Controls.Add(this.iBtXoa);
            this.Controls.Add(this.iBtSua);
            this.Controls.Add(this.iBtThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QlyPhong";
            this.Text = "QlyPhong";
            this.Load += new System.EventHandler(this.PhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iBtThem;
        private FontAwesome.Sharp.IconButton iBtSua;
        private FontAwesome.Sharp.IconButton iBtXoa;
        private FontAwesome.Sharp.IconButton iBtTimKiem;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.TextBox textBoxDienTich;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.ComboBox comboBoxTTphong;
        private System.Windows.Forms.ComboBox comboBoxMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton btnX;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.TextBox textBoxTimKiem;
    }
}