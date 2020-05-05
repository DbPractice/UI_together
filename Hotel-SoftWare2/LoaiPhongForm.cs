using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SoftWare2
{
    public partial class LoaiPhongForm : Form
    {
        htEntities TypeRoom = new htEntities();
        public LoaiPhongForm()
        {
            InitializeComponent();
        }

        private void ShowTypeRoom(DataGridView dgv)
        {
            dgv.DataSource = TypeRoom.DSLoaiPhong();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoaiPhongForm_Load(object sender, EventArgs e)
        {
            ShowTypeRoom(dgvLoaiPhong);
            lockText();
        }
        private void TypeRoomID()
        {
            int count = 0;
            count = dgvLoaiPhong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvLoaiPhong.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
                textBoxMaLoaiPhong.Text = "MLP0" + (chuoi2 + 1).ToString();
            else
                textBoxMaLoaiPhong.Text = "MLP" + (chuoi2 + 1).ToString();
        }

        bool status;

        private void clearText()
        {
            textBoxTenLoaiPhong.Text = textBoxSoNguoiMax.Text = textBoxGhiChu.Text = "";
        }

        private void lockText()
        {
            textBoxMaLoaiPhong.Enabled = textBoxTenLoaiPhong.Enabled = textBoxGhiChu.Enabled = textBoxSoNguoiMax.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenLoaiPhong.Enabled = textBoxGhiChu.Enabled = textBoxSoNguoiMax.Enabled = true;
        }

        private void dgvTypeRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLoaiPhong.Rows[e.RowIndex];
                textBoxMaLoaiPhong.Text = row.Cells[0].Value.ToString();
                textBoxTenLoaiPhong.Text = row.Cells[1].Value.ToString();
                textBoxSoNguoiMax.Text = row.Cells[2].Value.ToString();
                textBoxGhiChu.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TypeRoomID();
            unlockText();
            status = true;
            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
            textBoxMaLoaiPhong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Loại Phòng Này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TypeRoom.delTypeRoom(textBoxMaLoaiPhong.Text);
                try
                {
                    MessageBox.Show("Xóa Loại Phòng Thành Công");
                    TypeRoom.SaveChanges();
                    ShowTypeRoom(dgvLoaiPhong);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
                textBoxMaLoaiPhong.Text = "";
            }
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                TypeRoom.addTypeRoom(textBoxMaLoaiPhong.Text, textBoxTenLoaiPhong.Text, Convert.ToByte(textBoxSoNguoiMax.Text), textBoxGhiChu.Text);
                try
                {
                    MessageBox.Show("Thêm Loại Phòng Thành Công");
                    TypeRoom.SaveChanges();
                    ShowTypeRoom(dgvLoaiPhong);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                TypeRoom.updateTypeRoom(textBoxMaLoaiPhong.Text, textBoxTenLoaiPhong.Text, Convert.ToByte(textBoxSoNguoiMax.Text), textBoxGhiChu.Text);
                try
                {
                    MessageBox.Show("Cập Nhật Loại Phòng Thành Công!");
                    TypeRoom.SaveChanges();
                    ShowTypeRoom(dgvLoaiPhong);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
            TypeRoomID();
        }
    }
}
