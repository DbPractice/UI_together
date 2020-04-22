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
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MMRLS5F;Initial Catalog=HotelSofwware;Integrated Security=True");
        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
           
        }

        private void datphong_click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt phòng thành công ! Nhân viên của chúng tôi sẽ liên hệ với quý khách sớm nhất !");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void timkiem_click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                textBoxMaP.Text = row.Cells[0].Value.ToString();
                textBoxTenP.Text = row.Cells[1].Value.ToString();
               

            }
            catch (Exception)
            {


            }

        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("select * from LoaiPhong", conn);
            var table = new DataTable();
            dap.Fill(table);
            comboBoxloaiP.DisplayMember = "TenLoai";
            comboBoxloaiP.ValueMember = "MaLoai";
            comboBoxloaiP.DataSource = table;
           

        }

        private void comboBoxloaiP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxloaiP.SelectedValue);
            var dap = new SqlDataAdapter("select * from Phong where MaLoai = "+id+"", conn);
            var table = new DataTable();
            dap.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void textBoxMaP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void labeltb_Click(object sender, EventArgs e)
        {
            
        } 
    }
}

