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
using FontAwesome.Sharp;

namespace Hotel_SoftWare2
{
    public partial class MainForm : Form
    {
        Thread th;
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
        }
       
        private void changeColorMenu(IconButton iconbtn)
        {
            if (iconbtn.BackColor == Color.FromArgb(31, 30, 68, 1))
            {
                returnColorMenu();
                iconbtn.BackColor = Color.CornflowerBlue;
            }
            else
                iconbtn.BackColor = Color.FromArgb(31, 30, 68, 1);
        }

        private void returnColorMenu()
        {
            if(btnHeThong.BackColor == Color.CornflowerBlue) btnHeThong.BackColor = Color.FromArgb(31,30,68,1);
            if(btnChucNang.BackColor == Color.CornflowerBlue) btnChucNang.BackColor = Color.FromArgb(31, 30, 68, 1);
            if(btnQuanLy.BackColor == Color.CornflowerBlue) btnQuanLy.BackColor = Color.FromArgb(31, 30, 68, 1);
            if(btnThongKeHoaDon.BackColor == Color.CornflowerBlue) btnThongKeHoaDon.BackColor = Color.FromArgb(31, 30, 68, 1);
        }

        private void customizeDesing()
        {
            panelHeThong.Visible = false;
            panelChucNang.Visible = false;
            panelQuanLy.Visible = false;
            btnHeThong.BackColor = Color.FromArgb(31, 30, 68, 1);
            btnChucNang.BackColor = Color.FromArgb(31, 30, 68, 1);
            btnQuanLy.BackColor = Color.FromArgb(31, 30, 68, 1);
            btnThongKeHoaDon.BackColor = Color.FromArgb(31, 30, 68, 1);
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
            textBoxTitle.Text = "Hệ Thống";
            changeColorMenu(btnHeThong);
            ShowMenu(panelHeThong);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "Chức Năng";
            changeColorMenu(btnChucNang);
            ShowMenu(panelChucNang);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "Quản Lý";
            changeColorMenu(btnQuanLy);
            ShowMenu(panelQuanLy);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "Đổi Mật Khẩu";
            openChildForm(new ChangePassForm());
            HideMenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "ĐẶT PHÒNG";
            openChildForm(new DatPhongForm());
            HideMenu();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "NHẬN PHÒNG";
            openChildForm(new NhanPhongForm());
            HideMenu();
        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "HỦY ĐẶT PHÒNG";
            openChildForm(new Huyphong());
            HideMenu();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "TRẢ PHÒNG";
            openChildForm(new TraPhong());
            HideMenu();
        }

        private void btnDichVuPhong_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "DỊCH VỤ PHÒNG";
            openChildForm(new ServiceRoomForm());
            HideMenu();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "HÓA ĐƠN";
            openChildForm(new billForm());
            HideMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "KHÁCH HÀNG";
            openChildForm(new CustomersForm());
            HideMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "NHÂN VIÊN";
            openChildForm(new EmployeesForm());
            HideMenu();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "NGƯỜI DÙNG";
            openChildForm(new UsersForm());
            HideMenu();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "PHÒNG";
            openChildForm(new QlyPhong());
            HideMenu();
        }

        private void bntDichVu_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "DỊCH VỤ";
            openChildForm(new QLServiceForm());
            HideMenu();
        }

        private void btnThongKeHoaDon_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "THỐNG KÊ DOANH THU";
            changeColorMenu(btnThongKeHoaDon);
            openChildForm(new DoanhThuForm());
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

        private void panelBotChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
