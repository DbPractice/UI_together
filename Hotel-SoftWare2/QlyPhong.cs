using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Hotel_SoftWare2
{
    public partial class QlyPhong : Form
    {
        htEntities room = new htEntities();
        public QlyPhong()
        {
            InitializeComponent();
        }

        private void ShowRoom(DataGridView dgv)
        {
            dgv.DataSource = room.DSPhong();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhongForm_Load(object sender, EventArgs e)
        {
            ShowRoom(dgvRoom);
            lockText();
        }
        private void RoomID()
        {
            int count = 0;
            count = dgvRoom.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvRoom.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));
            if (chuoi2 + 1 < 10)
                textBoxMaPhong.Text = "MP0" + (chuoi2 + 1).ToString();
            else
                textBoxMaPhong.Text = "MP" + (chuoi2 + 1).ToString();
        }

        bool status;

        private void clearText()
        {
            textBoxTenPhong.Text = comboBoxTTphong.Text = textBoxDienTich.Text = textBoxGia.Text = comboBoxMaLoai.Text = textBoxTimKiem.Text = "";
        }

        private void lockText()
        {
            textBoxMaPhong.Enabled = textBoxTenPhong.Enabled = comboBoxTTphong.Enabled = textBoxDienTich.Enabled = textBoxGia.Enabled = comboBoxMaLoai.Enabled = false;
            iBtSua.Enabled = iBtXoa.Enabled = iBtTimKiem.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenPhong.Enabled = comboBoxTTphong.Enabled = textBoxDienTich.Enabled = textBoxGia.Enabled = comboBoxMaLoai.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            RoomID();
            unlockText();
            status = true;
            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
            textBoxMaPhong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Loại Phòng Này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                room.delRoom(textBoxMaPhong.Text);
                try
                {
                    MessageBox.Show("Xóa Phòng Thành Công");
                    room.SaveChanges();
                    ShowRoom(dgvRoom);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                iBtXoa.Enabled = false;
                textBoxMaPhong.Text = "";
            }
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                room.addRoom(textBoxMaPhong.Text, textBoxTenPhong.Text, Convert.ToByte(comboBoxTTphong.Text), Convert.ToInt32(textBoxDienTich.Text), Convert.ToInt32(textBoxGia.Text), comboBoxMaLoai.Text);
                try
                {
                    MessageBox.Show("Thêm Phòng Thành Công");
                    room.SaveChanges();
                    ShowRoom(dgvRoom);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                room.updateRoom(textBoxMaPhong.Text, textBoxTenPhong.Text, Convert.ToByte(comboBoxTTphong.Text), Convert.ToInt32(textBoxDienTich.Text), Convert.ToInt32(textBoxGia.Text), comboBoxMaLoai.Text);
                try
                {
                    MessageBox.Show("Cập Nhật Phòng Thành Công!");
                    room.SaveChanges();
                    ShowRoom(dgvRoom);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
            RoomID();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iBtSua.Enabled = iBtXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvRoom.Rows[e.RowIndex];
                textBoxMaPhong.Text = row.Cells[0].Value.ToString();
                textBoxTenPhong.Text = row.Cells[1].Value.ToString();
                comboBoxTTphong.Text = row.Cells[2].Value.ToString();
                textBoxDienTich.Text = row.Cells[3].Value.ToString();
                textBoxGia.Text = row.Cells[4].Value.ToString();
                comboBoxMaLoai.Text = row.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            iBtTimKiem.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvRoom.DataSource = room.TKPhong(textBoxTimKiem.Text);
            if (textBoxTimKiem.Text == "")
            {
                dgvRoom.DataSource = room.DSPhong();
            }
            clearText();
           iBtTimKiem.Enabled = false;
        }
    }
}

