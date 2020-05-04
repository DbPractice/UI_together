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
    public partial class QLServiceForm : Form
    {
        htEntities ser = new htEntities();
        public QLServiceForm()
        {
            InitializeComponent();
        }

        private void ShowSer(DataGridView dgv)
        {
            dgv.DataSource = ser.DSDichVu();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            serviceID();
            status = true;
            clearText();
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLServiceForm_Load(object sender, EventArgs e)
        {
            ShowSer(dgvServices);
        }

        private void serviceID()
        {
            int count = 0;
            count = dgvServices.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvServices.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
                tbMa.Text = "MDV0" + (chuoi2 + 1).ToString();
            else
                tbMa.Text = "MDV" + (chuoi2 + 1).ToString();
        }

        bool status;

        private void clearText()
            {
                tbTen.Text = tbGia.Text = comboBox1.Text = "";
            }

        private void iconButtonSave_Click_1(object sender, EventArgs e)
        {
            if (status == true)
            {
                ser.addSer(tbMa.Text, tbTen.Text, Convert.ToInt32(tbGia.Text), comboBox1.Text);
                try
                {
                    MessageBox.Show("Thêm Dịch Vụ Thành Công");
                    ser.SaveChanges();
                    ShowSer(dgvServices);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //else
            //{
            //    ser.(tbMa.Text, tbTen.Text, tbGia.Text, comboBox1.Text);
            //    try
            //    {
            //        MessageBox.Show("cap nhat thong tin khach hang thanh cong");
            //        ser.SaveChanges();
            //        ShowSer(dgvServices);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            clearText();
            serviceID();
        }
    }
}
