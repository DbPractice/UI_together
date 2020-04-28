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
        Thread th;
        public QlyPhong()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openThemsuaxoaPhong);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openThemsuaxoaPhong(object obj)
        {
            Application.Run(new ThemsuaxoaPhong());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openThemsuaxoaPhong);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Đã xóa phòng!", "Thông báo");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

