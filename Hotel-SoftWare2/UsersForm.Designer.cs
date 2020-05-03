namespace Hotel_SoftWare2
{
    partial class UsersForm
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
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.textBoxTenTK = new System.Windows.Forms.TextBox();
            this.groupBoxQuyen = new System.Windows.Forms.GroupBox();
            this.checkBoxLeTan = new System.Windows.Forms.CheckBox();
            this.checkBoxQuanLy = new System.Windows.Forms.CheckBox();
            this.textBoxNhapLaiMK = new System.Windows.Forms.TextBox();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.labelTenTK = new System.Windows.Forms.Label();
            this.labelMK = new System.Windows.Forms.Label();
            this.labelNhapLaiMK = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBoxQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnX.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnX.IconColor = System.Drawing.Color.White;
            this.btnX.IconSize = 30;
            this.btnX.Location = new System.Drawing.Point(24, 500);
            this.btnX.Name = "btnX";
            this.btnX.Rotation = 0D;
            this.btnX.Size = new System.Drawing.Size(119, 42);
            this.btnX.TabIndex = 16;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnTimKiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(24, 435);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Rotation = 0D;
            this.btnTimKiem.Size = new System.Drawing.Size(119, 40);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(24, 363);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Rotation = 0D;
            this.btnXoa.Size = new System.Drawing.Size(119, 40);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(24, 301);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(119, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(170, 190);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(760, 400);
            this.dgvUsers.TabIndex = 11;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // textBoxTenTK
            // 
            this.textBoxTenTK.Location = new System.Drawing.Point(214, 32);
            this.textBoxTenTK.Multiline = true;
            this.textBoxTenTK.Name = "textBoxTenTK";
            this.textBoxTenTK.Size = new System.Drawing.Size(200, 24);
            this.textBoxTenTK.TabIndex = 40;
            // 
            // groupBoxQuyen
            // 
            this.groupBoxQuyen.Controls.Add(this.checkBoxLeTan);
            this.groupBoxQuyen.Controls.Add(this.checkBoxQuanLy);
            this.groupBoxQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuyen.ForeColor = System.Drawing.Color.White;
            this.groupBoxQuyen.Location = new System.Drawing.Point(438, 72);
            this.groupBoxQuyen.Name = "groupBoxQuyen";
            this.groupBoxQuyen.Size = new System.Drawing.Size(380, 100);
            this.groupBoxQuyen.TabIndex = 45;
            this.groupBoxQuyen.TabStop = false;
            this.groupBoxQuyen.Text = "Quyền";
            // 
            // checkBoxLeTan
            // 
            this.checkBoxLeTan.AutoSize = true;
            this.checkBoxLeTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLeTan.ForeColor = System.Drawing.Color.Transparent;
            this.checkBoxLeTan.Location = new System.Drawing.Point(216, 28);
            this.checkBoxLeTan.Name = "checkBoxLeTan";
            this.checkBoxLeTan.Size = new System.Drawing.Size(77, 24);
            this.checkBoxLeTan.TabIndex = 1;
            this.checkBoxLeTan.Text = "Lễ Tân";
            this.checkBoxLeTan.UseVisualStyleBackColor = true;
            this.checkBoxLeTan.CheckedChanged += new System.EventHandler(this.checkBoxLeTan_CheckedChanged);
            // 
            // checkBoxQuanLy
            // 
            this.checkBoxQuanLy.AutoSize = true;
            this.checkBoxQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxQuanLy.ForeColor = System.Drawing.Color.Transparent;
            this.checkBoxQuanLy.Location = new System.Drawing.Point(6, 28);
            this.checkBoxQuanLy.Name = "checkBoxQuanLy";
            this.checkBoxQuanLy.Size = new System.Drawing.Size(87, 24);
            this.checkBoxQuanLy.TabIndex = 0;
            this.checkBoxQuanLy.Text = "Quản Lý";
            this.checkBoxQuanLy.UseVisualStyleBackColor = true;
            this.checkBoxQuanLy.CheckedChanged += new System.EventHandler(this.checkBoxQuanLy_CheckedChanged);
            // 
            // textBoxNhapLaiMK
            // 
            this.textBoxNhapLaiMK.Location = new System.Drawing.Point(214, 138);
            this.textBoxNhapLaiMK.Multiline = true;
            this.textBoxNhapLaiMK.Name = "textBoxNhapLaiMK";
            this.textBoxNhapLaiMK.Size = new System.Drawing.Size(200, 24);
            this.textBoxNhapLaiMK.TabIndex = 41;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(214, 89);
            this.textBoxMK.Multiline = true;
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(200, 24);
            this.textBoxMK.TabIndex = 42;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(850, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelTenTK
            // 
            this.labelTenTK.AutoSize = true;
            this.labelTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTK.ForeColor = System.Drawing.Color.Transparent;
            this.labelTenTK.Location = new System.Drawing.Point(20, 27);
            this.labelTenTK.Name = "labelTenTK";
            this.labelTenTK.Size = new System.Drawing.Size(135, 24);
            this.labelTenTK.TabIndex = 37;
            this.labelTenTK.Text = "Tên Tài Khoản";
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMK.ForeColor = System.Drawing.Color.Transparent;
            this.labelMK.Location = new System.Drawing.Point(20, 84);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(89, 24);
            this.labelMK.TabIndex = 39;
            this.labelMK.Text = "Mật Khẩu";
            // 
            // labelNhapLaiMK
            // 
            this.labelNhapLaiMK.AutoSize = true;
            this.labelNhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapLaiMK.ForeColor = System.Drawing.Color.Transparent;
            this.labelNhapLaiMK.Location = new System.Drawing.Point(20, 138);
            this.labelNhapLaiMK.Name = "labelNhapLaiMK";
            this.labelNhapLaiMK.Size = new System.Drawing.Size(169, 24);
            this.labelNhapLaiMK.TabIndex = 38;
            this.labelNhapLaiMK.Text = "Nhập Lại Mật Khẩu";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.ForeColor = System.Drawing.Color.Transparent;
            this.labelMaNV.Location = new System.Drawing.Point(434, 32);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(131, 24);
            this.labelMaNV.TabIndex = 46;
            this.labelMaNV.Text = "Mã Nhân Viên";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(571, 32);
            this.textBoxMaNV.Multiline = true;
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(200, 24);
            this.textBoxMaNV.TabIndex = 47;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.labelMaNV);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.textBoxTenTK);
            this.Controls.Add(this.groupBoxQuyen);
            this.Controls.Add(this.textBoxNhapLaiMK);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelTenTK);
            this.Controls.Add(this.labelMK);
            this.Controls.Add(this.labelNhapLaiMK);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBoxQuyen.ResumeLayout(false);
            this.groupBoxQuyen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox textBoxTenTK;
        private System.Windows.Forms.GroupBox groupBoxQuyen;
        private System.Windows.Forms.CheckBox checkBoxLeTan;
        private System.Windows.Forms.CheckBox checkBoxQuanLy;
        private System.Windows.Forms.TextBox textBoxNhapLaiMK;
        private System.Windows.Forms.TextBox textBoxMK;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label labelTenTK;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Label labelNhapLaiMK;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.TextBox textBoxMaNV;
    }
}