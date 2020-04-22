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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelHeThong.Visible = false;
            panelChucNang.Visible = false;
            panelQuanLy.Visible = false;

        }

        private void HideMenu()
        {
            if (panelHeThong.Visible == true) panelHeThong.Visible = false;
            if (panelChucNang.Visible == true) panelChucNang.Visible = false;
            if (panelQuanLy.Visible == true) panelQuanLy.Visible = false;
        }

        private void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowMenu(panelHeThong);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            ShowMenu(panelChucNang);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowMenu(panelQuanLy);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new DatPhong());
            HideMenu();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnDichVuPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new DichVuPhongForm());
            HideMenu();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomersForm());
            HideMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void bntDichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new QLDichVuForm());
            HideMenu();
        }

        private void btnThongKeHoaDon_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBotChildForm.Controls.Add(childForm);
            panelBotChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
