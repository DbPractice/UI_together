using System.Drawing;

namespace Hotel_SoftWare2
{
    partial class DatPhongForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnDkyThue = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.labelmpt = new System.Windows.Forms.Label();
            this.labelkh = new System.Windows.Forms.Label();
            this.lableIdPT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSphieuThue = new System.Windows.Forms.DataGridView();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.groupBoxNote = new System.Windows.Forms.GroupBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.panelChildFormPhieuThue = new System.Windows.Forms.Panel();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSphieuThue)).BeginInit();
            this.groupBoxNote.SuspendLayout();
            this.panelChildFormPhieuThue.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 18;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(473, 331);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 14);
            this.label30.TabIndex = 43;
            this.label30.Text = "...";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconSize = 22;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(216, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "     TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDkyThue
            // 
            this.btnDkyThue.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDkyThue.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDkyThue.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDkyThue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDkyThue.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnDkyThue.IconColor = System.Drawing.Color.White;
            this.btnDkyThue.IconSize = 25;
            this.btnDkyThue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDkyThue.Location = new System.Drawing.Point(345, 506);
            this.btnDkyThue.Name = "btnDkyThue";
            this.btnDkyThue.Rotation = 0D;
            this.btnDkyThue.Size = new System.Drawing.Size(150, 41);
            this.btnDkyThue.TabIndex = 29;
            this.btnDkyThue.Text = "ĐĂNG KÝ THUÊ";
            this.btnDkyThue.UseVisualStyleBackColor = false;
            this.btnDkyThue.Click += new System.EventHandler(this.btnDkyThue_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconSize = 25;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(800, 506);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0D;
            this.btnThoat.Size = new System.Drawing.Size(111, 41);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "   THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelmpt
            // 
            this.labelmpt.AutoSize = true;
            this.labelmpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmpt.ForeColor = System.Drawing.Color.White;
            this.labelmpt.Location = new System.Drawing.Point(5, 14);
            this.labelmpt.Name = "labelmpt";
            this.labelmpt.Size = new System.Drawing.Size(115, 20);
            this.labelmpt.TabIndex = 44;
            this.labelmpt.Text = "Mã Phiếu Thuê";
            // 
            // labelkh
            // 
            this.labelkh.AutoSize = true;
            this.labelkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkh.ForeColor = System.Drawing.Color.White;
            this.labelkh.Location = new System.Drawing.Point(5, 49);
            this.labelkh.Name = "labelkh";
            this.labelkh.Size = new System.Drawing.Size(123, 20);
            this.labelkh.TabIndex = 45;
            this.labelkh.Text = "Mã Khách Hàng";
            // 
            // lableIdPT
            // 
            this.lableIdPT.AutoSize = true;
            this.lableIdPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdPT.ForeColor = System.Drawing.Color.White;
            this.lableIdPT.Location = new System.Drawing.Point(135, 10);
            this.lableIdPT.Name = "lableIdPT";
            this.lableIdPT.Size = new System.Drawing.Size(25, 24);
            this.lableIdPT.TabIndex = 46;
            this.lableIdPT.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.dgvDSphieuThue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(341, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 263);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Thuê";
            // 
            // dgvDSphieuThue
            // 
            this.dgvDSphieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSphieuThue.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSphieuThue.Location = new System.Drawing.Point(6, 25);
            this.dgvDSphieuThue.Name = "dgvDSphieuThue";
            this.dgvDSphieuThue.Size = new System.Drawing.Size(558, 232);
            this.dgvDSphieuThue.TabIndex = 0;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(139, 49);
            this.textBoxMaKH.Multiline = true;
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(71, 24);
            this.textBoxMaKH.TabIndex = 75;
            // 
            // groupBoxNote
            // 
            this.groupBoxNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxNote.Controls.Add(this.textBoxNote);
            this.groupBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNote.ForeColor = System.Drawing.Color.White;
            this.groupBoxNote.Location = new System.Drawing.Point(341, 294);
            this.groupBoxNote.Name = "groupBoxNote";
            this.groupBoxNote.Size = new System.Drawing.Size(570, 172);
            this.groupBoxNote.TabIndex = 78;
            this.groupBoxNote.TabStop = false;
            this.groupBoxNote.Text = "Ghi Chú";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(6, 25);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(558, 141);
            this.textBoxNote.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(139, 85);
            this.textBoxMaNV.Multiline = true;
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(71, 24);
            this.textBoxMaNV.TabIndex = 80;
            // 
            // panelChildFormPhieuThue
            // 
            this.panelChildFormPhieuThue.BackColor = System.Drawing.Color.Transparent;
            this.panelChildFormPhieuThue.Controls.Add(this.btnUpdate);
            this.panelChildFormPhieuThue.Controls.Add(this.labelmpt);
            this.panelChildFormPhieuThue.Controls.Add(this.groupBoxNote);
            this.panelChildFormPhieuThue.Controls.Add(this.textBoxMaNV);
            this.panelChildFormPhieuThue.Controls.Add(this.groupBox1);
            this.panelChildFormPhieuThue.Controls.Add(this.labelkh);
            this.panelChildFormPhieuThue.Controls.Add(this.btnThoat);
            this.panelChildFormPhieuThue.Controls.Add(this.label3);
            this.panelChildFormPhieuThue.Controls.Add(this.btnDkyThue);
            this.panelChildFormPhieuThue.Controls.Add(this.textBoxMaKH);
            this.panelChildFormPhieuThue.Controls.Add(this.lableIdPT);
            this.panelChildFormPhieuThue.Controls.Add(this.btnSearch);
            this.panelChildFormPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormPhieuThue.Location = new System.Drawing.Point(0, 0);
            this.panelChildFormPhieuThue.Name = "panelChildFormPhieuThue";
            this.panelChildFormPhieuThue.Size = new System.Drawing.Size(940, 600);
            this.panelChildFormPhieuThue.TabIndex = 81;
            this.panelChildFormPhieuThue.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildFormPhieuThue_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconSize = 30;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(590, 507);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(119, 40);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DatPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.panelChildFormPhieuThue);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatPhongForm";
            this.Text = "DatPhongForm";
            this.Load += new System.EventHandler(this.DatPhongForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSphieuThue)).EndInit();
            this.groupBoxNote.ResumeLayout(false);
            this.groupBoxNote.PerformLayout();
            this.panelChildFormPhieuThue.ResumeLayout(false);
            this.panelChildFormPhieuThue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label label30;
        private FontAwesome.Sharp.IconButton btnDkyThue;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Label labelmpt;
        private System.Windows.Forms.Label labelkh;
        private System.Windows.Forms.Label lableIdPT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSphieuThue;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.GroupBox groupBoxNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Panel panelChildFormPhieuThue;
        private FontAwesome.Sharp.IconButton btnUpdate;
    }
}