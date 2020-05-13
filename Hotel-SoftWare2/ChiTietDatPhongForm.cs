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
    public partial class ChiTietDatPhongForm : Form
    {
        htEntities context = new htEntities();
        public ChiTietDatPhongForm()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void showFreeRoom(DataGridView dgv)
        {
            dgv.DataSource = context.getFreeRoom();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void showCTPT(DataGridView dgv)
        {
            dgv.DataSource = context.getAllCTPT();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void ChiTietDatPhongForm_Load(object sender, EventArgs e)
        {
            showFreeRoom(dgvFreeRoom);
            showCTPT(dgvDSCTPT);
            lockText();
            btnSua.Enabled = false;
            labelIdPT.Text = DatPhongForm.mapt;
            implementID();
        }

        private void dgvDSCTPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSCTPT.Rows[e.RowIndex];
                lableIdCTPT.Text = row.Cells[0].Value.ToString();
                dtpNgayVao.Text = row.Cells[1].Value.ToString();
                dtpNgayRa.Text = row.Cells[2].Value.ToString();
                comboBoxhtt.Text = row.Cells[3].Value.ToString();
                textBoxSoNguoi.Text = row.Cells[4].Value.ToString();
                textBoxMaPhong.Text = row.Cells[5].Value.ToString();
                labelIdPT.Text = row.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void lockText()
        {
            textBoxSoNguoi.Enabled = comboBoxhtt.Enabled = dtpNgayVao.Enabled = dtpNgayRa.Enabled = textBoxMaPhong.Enabled = false;
        }

        private void unlockText()
        {
            textBoxSoNguoi.Enabled = comboBoxhtt.Enabled = dtpNgayVao.Enabled = dtpNgayRa.Enabled = textBoxMaPhong.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
        }

        bool status;
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxhtt.Text == "Online")
            {
                comboBoxhtt.Text = "True";
            }
            else comboBoxhtt.Text = "False";
            if (status == true)
            {
                context.addCTPT(lableIdCTPT.Text, dtpNgayVao.Value, dtpNgayRa.Value, Convert.ToBoolean(comboBoxhtt.Text), Convert.ToByte(textBoxSoNguoi.Text), textBoxMaPhong.Text, labelIdPT.Text);
                try
                {
                    MessageBox.Show("Them ctpt thanh cong");
                    context.SaveChanges();
                    showCTPT(dgvDSCTPT);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                context.updateCTPT(lableIdCTPT.Text, dtpNgayVao.Value, dtpNgayRa.Value, Convert.ToBoolean(comboBoxhtt.Text), Convert.ToByte(textBoxSoNguoi.Text), textBoxMaPhong.Text, labelIdPT.Text);
                try
                {
                    MessageBox.Show("cap nhat chi tiet phieu thue thanh cong");
                    context.SaveChanges();
                    showCTPT(dgvDSCTPT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = true;
            unlockText();
        }

        private void implementID()
        {
            int count = 0;
            count = dgvDSCTPT.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSCTPT.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 5));
            if (chuoi2 + 1 < 10)
                lableIdCTPT.Text = "MCTPT0" + (chuoi2 + 1).ToString();
            else
                lableIdCTPT.Text = "MCTPT" + (chuoi2 + 1).ToString();
        }

        private void clearText()
        {
            lableIdCTPT.Text = dtpNgayVao.Text = dtpNgayRa.Text = textBoxSoNguoi.Text = textBoxMaPhong.Text = comboBoxhtt.Text = "";
        }

        private void dgvFreeRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvFreeRoom.Rows[e.RowIndex];
                textBoxMaPhong.Text = row.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showCTPT_Search(dgvDSCTPT);
        }

        private void showCTPT_Search(DataGridView dgv)
        {
            if(textBoxMptSearch.Text == "")
            {
                showCTPT(dgvDSCTPT);
            }
            else
            {
                dgv.DataSource = context.getCTPT_FrIdPT(textBoxMptSearch.Text);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }
    }
}
