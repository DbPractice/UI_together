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
    public partial class QlyPhong : Form
    {

        public QlyPhong()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QlyPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelSoftwareDataSet2.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter.Fill(this.hotelSoftwareDataSet2.LoaiPhong);

        }

        private void ibtXoa_Click(object sender, EventArgs e)
        {

        }
    }
}

