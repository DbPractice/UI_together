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
    public partial class CustomersForm : Form
    {
        htEntities cus = new htEntities();
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            implementID();
            status = true;
            unlockText();
            clearText();
            btnSua.Enabled = false;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ShowCus(dgvCustomers);
            lockText();
        }

        private void ShowCus(DataGridView dgv)
        {
            dgv.DataSource = cus.getallCus();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        
        private void lockText()
        {
            textBoxMaKH.Enabled = textBoxDiaChi.Enabled = textBoxSDT.Enabled = textBoxSoCMND.Enabled = textBoxTenKH.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxDiaChi.Enabled = textBoxSDT.Enabled = textBoxSoCMND.Enabled = textBoxTenKH.Enabled = true;
        }

        bool status;
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if(status == true)
            {
                cus.addCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Them KH thanh cong");
                    cus.SaveChanges();
                    ShowCus(dgvCustomers);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("cap nhat thong tin khach hang thanh cong");
                    cus.SaveChanges();
                    ShowCus(dgvCustomers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
            implementID();
        }

        private void clearText()
        {
            textBoxTenKH.Text = textBoxSoCMND.Text = textBoxDiaChi.Text = textBoxSDT.Text = "";
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCustomers.Rows[e.RowIndex];
                textBoxMaKH.Text = row.Cells[0].Value.ToString();
                textBoxTenKH.Text = row.Cells[1].Value.ToString();
                textBoxSoCMND.Text = row.Cells[2].Value.ToString();
                textBoxDiaChi.Text = row.Cells[3].Value.ToString();
                textBoxSDT.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
            textBoxMaKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("xoa khach hang nay?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("xoa khach hàng thành công");
                    cus.SaveChanges();
                    ShowCus(dgvCustomers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
                textBoxMaKH.Text = "";
            }
        }

        private void implementID()
        {
            int count = 0;
            count = dgvCustomers.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvCustomers.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
                textBoxMaKH.Text = "MKH0" + (chuoi2 + 1).ToString();
            else 
                textBoxMaKH.Text = "MKH" + (chuoi2 + 1).ToString();
        }
    }
}
