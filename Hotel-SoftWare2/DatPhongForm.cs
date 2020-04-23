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
    public partial class DatPhongForm : Form
    {
        public DatPhongForm()
        {
            InitializeComponent();
        }
       
        private void DatPhongForm_Load(object sender, EventArgs e)
        {
          

        }

        private void comboBoxloaiP_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void DatPhongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show ("Bạn có chắc chắn thoát?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt phòng thành công !");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
