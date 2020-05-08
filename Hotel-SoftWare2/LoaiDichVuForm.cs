using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_SoftWare2
{
    public partial class LoaiDichVuForm : Form
    {
        htEntities TypeSer = new htEntities();
        public LoaiDichVuForm()
        {
            InitializeComponent();
        }

        private void ShowSer(DataGridView dgv)
        {
            dgv.DataSource = TypeSer.DSLoaiDichVu();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        bool status;

        private void clearText()
        {
            textBoxTenloaidv.Text = textBoxTimKiem.Text = "";
        }
        private void lockText()
        {
            textBoxMaloaidv.Enabled = textBoxTenloaidv.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnTimKiem.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenloaidv.Enabled = true;
        }


        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLoaiDV.Rows[e.RowIndex];
                textBoxMaloaidv.Text = row.Cells[0].Value.ToString();
                textBoxTenloaidv.Text = row.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void LoaiDichVuForm_Load(object sender, EventArgs e)
        {
            ShowSer(dgvLoaiDV);
            lockText();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            status = false;
            unlockText();
            textBoxMaloaidv.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Loại Dịch Vụ Này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TypeSer.delTypeSer(textBoxMaloaidv.Text);
                try
                {
                    MessageBox.Show("Xóa Loại Dịch Vụ Thành Công");
                    TypeSer.SaveChanges();
                    ShowSer(dgvLoaiDV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
                textBoxMaloaidv.Text = "";
            }
        }

        private void btnX_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                TypeSer.addTypeSer(textBoxMaloaidv.Text, textBoxTenloaidv.Text);
                try
                {
                    MessageBox.Show("Thêm Loại Dịch Vụ Thành Công");
                    TypeSer.SaveChanges();
                    ShowSer(dgvLoaiDV);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                TypeSer.updateTypeSer(textBoxMaloaidv.Text, textBoxTenloaidv.Text);
                try
                {
                    MessageBox.Show("Cập Nhật Loại Dịch Vụ Thành Công!");
                    TypeSer.SaveChanges();
                    ShowSer(dgvLoaiDV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
            TypeServiceID();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TypeServiceID();
            status = true;
            clearText();
        }

        private void TypeServiceID()
        {
            int count = 0;
            count = dgvLoaiDV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvLoaiDV.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 4));
            if (chuoi2 + 1 < 10)
                textBoxMaloaidv.Text = "MLDV0" + (chuoi2 + 1).ToString();
            else
                textBoxMaloaidv.Text = "MLDV" + (chuoi2 + 1).ToString();
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvLoaiDV.DataSource = TypeSer.TKtypeService(textBoxTimKiem.Text);
            if (textBoxTimKiem.Text == "")
            {
                dgvLoaiDV.DataSource = TypeSer.DSLoaiDichVu();
            }
            clearText();
            btnTimKiem.Enabled = false;
        }
    }
}
