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
    public partial class ttKhachHang : Form
    {
        public ttKhachHang()
        {
            InitializeComponent();
        }

        private void ttKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaP_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (textBoxDchi.Text.Length == 0 || (textBoxNameKH.Text.Length == 0) || (textBoxsdt.Text.Length == 0) || (textBoxcmnd.Text.Length == 0) || (textBoxdatcoc.Text.Length == 0) || (textBoxNameKH.Text.Length == 0) || (dateTimePickerden.Value == null) || (dateTimePickerdi.Value == null ) || (textBoxdatcoc.Text.Length == 0))
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Lỗi");
                    return;
                }
            else
            {
                MessageBox.Show("Đặt phòng thành công!");
            }    
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ttKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
