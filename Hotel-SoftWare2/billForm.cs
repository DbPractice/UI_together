using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SoftWare2
{
    
    public partial class billForm : Form
    {
        public billForm()
        {
            InitializeComponent();
        }

        private void FillComboboxMPT()
        {
            htEntities context = new htEntities();
            var getIdMptList = from PhieuThuePhong in context.PhieuThuePhongs
                               select PhieuThuePhong;
            comboBoxMaPT.DataSource = getIdMptList.ToList();
            comboBoxMaPT.DisplayMember = "MaPhieuThuePhong";
            //comboBoxMaPT.ValueMember = "MaSD";
            //    comboBoxMaPT.Items.Add("select one");
            //    foreach (var item in getIdMptList)
            //    {
            //        comboBoxMaPT.Items.Add(Contains(item));
            //    }
            //}
        }

        private void FillComboboxHTTT()
        {
            htEntities context = new htEntities();
            comboBoxHTTT.DataSource = context.getHTTT();
        }

        private void billForm_Load(object sender, EventArgs e)
        {
            FillComboboxMPT();
            FillComboboxHTTT();
            labelIdHD.Text = "MHD11";
        }

        private void showtienphongDetail(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.tienphongDetail(comboBoxMaPT.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void showtienDvDetail(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.tienDvDetail(comboBoxMaPT.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showtienphongDetail(dgvTienPhongDetail);
            showtienDvDetail(dgvTienDvDetail);
            showTien();
            htEntities context = new htEntities();
            //string mpt = Convert.ToString(comboBoxMaPT.Text);
            //var result = context.KhachHangs.Select(p => p.MaKH).FirstOrDefault();
            //labelmaKH.Text = result;
            var result = from c in context.PhieuThuePhongs
                         where c.MaPhieuThuePhong == comboBoxMaPT.Text
                         select c.MaKH;
            var result1 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == comboBoxMaPT.Text
                          select new { c.NhanVien.HoTen };
            var result2 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == comboBoxMaPT.Text
                          select new { c.KhachHang.TenKH };
            var result3 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == comboBoxMaPT.Text
                          select new { c.KhachHang.SoCMND };
            var result4 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == comboBoxMaPT.Text
                          select new { c.KhachHang.DiaChi };
            var result5 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == comboBoxMaPT.Text
                          select new { c.KhachHang.SDT };
            labelmaKH.Text = result.FirstOrDefault();

            string nvlap = result1.FirstOrDefault().ToString();
            string nvlap2 = nvlap.Substring(10);
            string[] arr = nvlap2.Split(new char[] { '}' });
            labelnvLap.Text = arr[0];

            string tenkh = result2.FirstOrDefault().ToString();
            string tenkh2 = tenkh.Substring(10);
            string[] arr2 = tenkh2.Split(new char[] { '}' });
            labeltenKH.Text = arr2[0];

            string soCM = result3.FirstOrDefault().ToString();
            string soCM2 = soCM.Substring(11);
            string[] arr3 = soCM2.Split(new char[] { '}' });
            labelsoCMND.Text = arr3[0];

            string dc = result4.FirstOrDefault().ToString();
            string dc2 = dc.Substring(11);
            string[] arr4 = dc2.Split(new char[] { '}' });
            labelDiaChi.Text = arr4[0];

            string sdt = result5.FirstOrDefault().ToString();
            string sdt2 = sdt.Substring(8);
            string[] arr5 = sdt2.Split(new char[] { '}' });
            labelSDT.Text = arr5[0];
        }

        private void showTien()
        {
            int sumtienDV = 0, sumtienPhong = 0, i;
            for (i = 0; i < dgvTienDvDetail.Rows.Count; i++)
            {
                sumtienDV += Convert.ToInt32(dgvTienDvDetail.Rows[i].Cells[4].Value);
            }

            for (i = 0; i < dgvTienPhongDetail.Rows.Count; i++)
            {
                sumtienPhong += Convert.ToInt32(dgvTienPhongDetail.Rows[i].Cells[4].Value);
            }

            labelTDV.Text = sumtienDV.ToString();
            labelTP.Text = sumtienPhong.ToString();
            labeltongT.Text = (sumtienDV + sumtienPhong).ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            htEntities context = new htEntities();
            if (comboBoxHTTT.Text == "Thẻ")
            {
                comboBoxHTTT.Text = "True";
            }
            else comboBoxHTTT.Text = "False";
            context.creatBill(labelIdHD.Text, Convert.ToInt32(labelTP.Text), Convert.ToInt32(labelTDV.Text), Convert.ToInt32(labeltongT.Text), Convert.ToBoolean(comboBoxHTTT.Text), dateTimePickerNgayTT.Value, textBoxghiChu.Text, comboBoxMaPT.Text);
            try
            {
                MessageBox.Show("thanh toan hoa don thanh cong");
                comboBoxHTTT.Text = "";
                btnThanhToan.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
