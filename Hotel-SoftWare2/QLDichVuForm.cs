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
    public partial class QLDichVuForm : Form
    {
        string sql;
        string chuoiketnoi = @"Data Source=LAPTOP-4MS40IJU;Initial Catalog=Hotel_Winform;Integrated Security=True";
        SqlConnection conn;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        public QLDichVuForm()
        {
            InitializeComponent();
        }

        private void QLDichVuForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            hienthi();
        }

        public void hienthi()
        {
            listView1.Items.Clear();
            conn.Open();
            sql = @"select MaDV, TenDV, DonGia, MaLoaiDV from DichVu";
            thuchien = new SqlCommand(sql, conn);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                i++;
            }
            conn.Close();
        }

        private void btnXchangePass_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iBtnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlIn = "INSERT INTO DichVu VALUES (@MaDV, @TenDV, @DonGia, @MaLoaiDV)";
            thuchien = new SqlCommand(sqlIn, conn);
            thuchien.Parameters.AddWithValue("MaDV", textBox1.Text);
            thuchien.Parameters.AddWithValue("TenDV", textBox2.Text);
            thuchien.Parameters.AddWithValue("DonGia", textBox3.Text);
            thuchien.Parameters.AddWithValue("MaLoaiDV", textBox4.Text);
            thuchien.ExecuteNonQuery();
            conn.Close();
            hienthi();
        }

        private void iBtnSua_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlSua = "UPDATE DichVu SET TenDV =@TenDV, DonGia =@DonGia, MaLoaiDV =@MaLoaiDV WHERE MaDV =@MaDV";
            thuchien = new SqlCommand(sqlSua, conn);
            thuchien.Parameters.AddWithValue("MaDV", textBox1.Text);
            thuchien.Parameters.AddWithValue("TenDV", textBox2.Text);
            thuchien.Parameters.AddWithValue("DonGia", textBox3.Text);
            thuchien.Parameters.AddWithValue("MaLoaiDV", textBox4.Text);
            thuchien.ExecuteNonQuery();
            conn.Close();
            hienthi();
        }

        private void iBtnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlXoa = "DELETE FROM DichVu WHERE MaDV =@MaDV";
            thuchien = new SqlCommand(sqlXoa, conn);
            thuchien.Parameters.AddWithValue("MaDV", textBox1.Text);
            thuchien.Parameters.AddWithValue("TenDV", textBox2.Text);
            thuchien.Parameters.AddWithValue("DonGia", textBox3.Text);
            thuchien.Parameters.AddWithValue("MaLoaiDV", textBox4.Text);
            thuchien.ExecuteNonQuery();
            conn.Close();
            hienthi();
        }
    }


}
