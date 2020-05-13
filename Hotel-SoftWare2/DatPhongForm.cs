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
    public partial class DatPhongForm : Form
    {
        public static string mapt;
        htEntities context = new htEntities();
        public DatPhongForm()
        {
            InitializeComponent();
        }

        private void DatPhongForm_Load(object sender, EventArgs e)
        {
            btnDkyThue.Enabled = textBoxMaNV.Enabled = false;
            textBoxMaNV.Text = context.getIdEmpFrAcc(LoginForm.username, LoginForm.password).FirstOrDefault();
            showDsPhieuThue(dgvDSphieuThue);
            implementID();
            textBoxMaKH.Text = listCustomer.maKH;
            mapt = lableIdPT.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new listCustomer());
            btnDkyThue.Enabled = true;
        }


        private void showDsPhieuThue(DataGridView dgv)
        {
            dgv.DataSource = context.getPhieuThue2();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void implementID()
        {
            int count = 0;
            count = dgvDSphieuThue.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSphieuThue.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 4));
            if (chuoi2 + 1 < 10)
                lableIdPT.Text = "MPTP0" + (chuoi2 + 1).ToString();
            else
                lableIdPT.Text = "MPTP" + (chuoi2 + 1).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormPhieuThue.Controls.Add(childForm);
            panelChildFormPhieuThue.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDkyThue_Click(object sender, EventArgs e)
        {
            context.addPhieuThuePhong(lableIdPT.Text, textBoxNote.Text, textBoxMaKH.Text, textBoxMaNV.Text);
            try
            {
                MessageBox.Show("Them phieu thue phong thanh cong");
                context.SaveChanges();
                showDsPhieuThue(dgvDSphieuThue);
                openChildForm(new ChiTietDatPhongForm());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            openChildForm(new ChiTietDatPhongForm());
        }

        private void panelChildFormPhieuThue_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
