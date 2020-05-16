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
    public partial class TraPhong : Form
    {
        htEntities context = new htEntities();
        public TraPhong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {
            showlistRentedRoom(dgvRentedRoom);
        }

        private void TraPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TTrả phòng thành công !", "Thông báo");
        }

        private void showlistRentedRoom(DataGridView dgv)
        {
            dgv.DataSource = context.getListRentedRoom();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void showListRentedRoomSearch(DataGridView dgv)
        {
            if (textBoxMptSearch.Text == "")
            {
                showlistRentedRoom(dgvRentedRoom);
            }
            else
            {
                dgv.DataSource = context.getRentedRoomSearch(textBoxMptSearch.Text);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            showListRentedRoomSearch(dgvRentedRoom);
        }
    }
}
