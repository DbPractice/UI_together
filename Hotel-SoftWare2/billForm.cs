using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Hotel_SoftWare2
{
    //public class InForCus
    //{
    //    public string makh;
    //    public string tenkh;
    //    public string soCMND;
    //    public string diachi;
    //    public string sdt;
    //    public string tenNVlap;
    //}
    public partial class billForm : Form
    {
        ReportDataSource rs = new ReportDataSource();
        ReportDataSource rs2 = new ReportDataSource();
        public static string idBill, Date, maKH, hoten, soCMND, diaChi, sdt, nvLap, tienPhong, tienDV, tongTien, ghiChu, httt;
        //public static DataGridView dgvDV, dgvTP;
        public billForm()
        {
            InitializeComponent();
        }

        //private void FillComboboxMPT()
        //{
        //    htEntities context = new htEntities();
        //    var getIdMptList = from PhieuThuePhong in context.PhieuThuePhongs
        //                       select PhieuThuePhong;
        //    comboBoxMaPT.DataSource = getIdMptList.ToList();
        //    comboBoxMaPT.DisplayMember = "MaPhieuThuePhong";
            //comboBoxMaPT.ValueMember = "MaSD";
            //    comboBoxMaPT.Items.Add("select one");
            //    foreach (var item in getIdMptList)
            //    {
            //        comboBoxMaPT.Items.Add(Contains(item));
            //    }
            //}
        //}

        private void tabPageTaoHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void FillComboboxHTTT()
        {
            htEntities context = new htEntities();
            comboBoxHTTT.DataSource = context.getHTTT();
        }

        private void textBoxSoDT_Enter(object sender, EventArgs e)
        {
            if(textBoxMaPhong.Text=="Nhập mã phòng")
            {
                textBoxMaPhong.Text = "";
                textBoxMaPhong.ForeColor = Color.Black;
            }
        }

        private void dgvListBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvListBill.Rows[e.RowIndex];
            labelIdHD.Text = row.Cells[0].Value.ToString();
            textBoxMaPhieuThue.Text = row.Cells[7].Value.ToString();
            tabControlBill.SelectedTab = tabPageTaoHoaDon;
            btncreateBill.Text = "In Hóa Đơn";
        }

        private void textBoxMaPhong_Leave(object sender, EventArgs e)
        {
            if (textBoxMaPhong.Text == "")
            {
                textBoxMaPhong.Text = "Nhập mã phòng";
                textBoxMaPhong.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxMaPhieuThue_TextChanged(object sender, EventArgs e)
        {
            showtienphongDetail(dgvTienPhongDetail);
            showtienDvDetail(dgvTienDvDetail);
            showTien();
            htEntities context = new htEntities();

            //string mpt = Convert.ToString(comboBoxMaPT.Text);
            //var result = context.KhachHangs.Select(p => p.MaKH).FirstOrDefault();
            //labelmaKH.Text = result;
            var result = from c in context.PhieuThuePhongs
                         where c.MaPhieuThuePhong == textBoxMaPhieuThue.Text
                         select c.MaKH;
            var result1 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == textBoxMaPhieuThue.Text
                          select new { c.NhanVien.HoTen };
            var result2 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == textBoxMaPhieuThue.Text
                          select new { c.KhachHang.TenKH };
            var result3 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == textBoxMaPhieuThue.Text
                          select new { c.KhachHang.SoCMND };
            var result4 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == textBoxMaPhieuThue.Text
                          select new { c.KhachHang.DiaChi };
            var result5 = from c in context.PhieuThuePhongs
                          where c.MaPhieuThuePhong == textBoxMaPhieuThue.Text
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

        private void billForm_Load(object sender, EventArgs e)
        {
            //FillComboboxMPT();
            FillComboboxHTTT();
            showListBill(dgvListBill);
            implementID();
        }

        private void showtienphongDetail(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.tienphongDetail(textBoxMaPhieuThue.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void showtienDvDetail(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.tienDvDetail(textBoxMaPhieuThue.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            htEntities context = new htEntities();
            textBoxMaPhieuThue.Text = context.getIdPTFromMaPhong(textBoxMaPhong.Text).FirstOrDefault().ToString();
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
            if(btncreateBill.Text == "Tạo Hóa Đơn")
            {
                if (comboBoxHTTT.Text == "Thẻ")
                {
                    comboBoxHTTT.Text = "True";
                }
                else comboBoxHTTT.Text = "False";
                context.creatBill(labelIdHD.Text, Convert.ToInt32(labelTP.Text), Convert.ToInt32(labelTDV.Text), Convert.ToInt32(labeltongT.Text), Convert.ToBoolean(comboBoxHTTT.Text), dateTimePickerNgayTT.Value, textBoxghiChu.Text, textBoxMaPhieuThue.Text);
                try
                {
                    DialogResult result = MessageBox.Show("Tạo hóa đơn thành công, bạn có muốn in hóa đơn hay không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        passData();
                        showTableinReport();
                        //ExportBill asd = new ExportBill();
                        //asd.Show();
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                    comboBoxHTTT.Text = "";
                    //btncreateBill.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(btncreateBill.Text == "In Hóa Đơn")
            {
                passData();
                showTableinReport();
            }
        }

        private void showListBill(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.getlistBill();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void implementID()
        {
            int count = 0;
            count = dgvListBill.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvListBill.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
                labelIdHD.Text = "MHD0" + (chuoi2 + 1).ToString();
            else
                labelIdHD.Text = "MHD" + (chuoi2 + 1).ToString();
        }

        private void passData()
        {
            idBill = labelIdHD.Text;
            Date = dateTimePickerNgayTT.Text;
            maKH = labelmaKH.Text;
            hoten = labeltenKH.Text;
            soCMND = labelsoCMND.Text;
            diaChi = labelDiaChi.Text;
            sdt = labelSDT.Text;
            nvLap = labelnvLap.Text;
            tienPhong = labelTP.Text;
            tienDV = labelTDV.Text;
            tongTien = labeltongT.Text;
            ghiChu = textBoxghiChu.Text;
            httt = comboBoxHTTT.Text;
            //dgvDV = dgvTienDvDetail;
            //dgvTP = dgvTienPhongDetail;
        }

        private void showTableinReport()
        {
            int i;
            List<ChiTietTienPhong> tp = new List<ChiTietTienPhong>();
            List<ChiTietTienDV> tdv = new List<ChiTietTienDV>();
            //tp.Clear();
            for (i = 0; i < dgvTienPhongDetail.Rows.Count; i++)
            {
                ChiTietTienPhong cttp = new ChiTietTienPhong
                {
                    tenphong = dgvTienPhongDetail.Rows[i].Cells[0].Value.ToString(),
                    ngayvao = dgvTienPhongDetail.Rows[i].Cells[1].Value.ToString(),
                    ngayra = dgvTienPhongDetail.Rows[i].Cells[2].Value.ToString(),
                    songayo = dgvTienPhongDetail.Rows[i].Cells[3].Value.ToString(),
                    tienphong = dgvTienPhongDetail.Rows[i].Cells[4].Value.ToString()
                };
                tp.Add(cttp);
            }

            for (i = 0; i < dgvTienDvDetail.Rows.Count; i++)
            {
                ChiTietTienDV cttdv = new ChiTietTienDV
                {
                    tenphong = dgvTienDvDetail.Rows[i].Cells[0].Value.ToString(),
                    tendv = dgvTienDvDetail.Rows[i].Cells[1].Value.ToString(),
                    ngaysd = dgvTienDvDetail.Rows[i].Cells[2].Value.ToString(),
                    soluong = dgvTienDvDetail.Rows[i].Cells[3].Value.ToString(),
                    tienDV = dgvTienDvDetail.Rows[i].Cells[4].Value.ToString()
                };
                tdv.Add(cttdv);
            }

            rs.Name = "DataSet1"; rs2.Name = "DataSet2";
            rs.Value = tp; rs2.Value = tdv;
            ExportBill eb = new ExportBill();
            eb.reportViewer1.LocalReport.DataSources.Clear();
            eb.reportViewer1.LocalReport.DataSources.Add(rs);
            eb.reportViewer1.LocalReport.DataSources.Add(rs2);
            //eb.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportBill.rdlc";
            eb.ShowDialog();
        }
    }

    public class ChiTietTienPhong
    {
        public string tenphong { get; set; }
        public string ngayvao { get; set; }
        public string ngayra { get; set; }
        public string songayo { get; set; }
        public string tienphong { get; set; }
    }

    public class ChiTietTienDV
    {
        public string tenphong { get; set; }
        public string tendv { get; set; }
        public string ngaysd { get; set; }
        public string soluong { get; set; }
        public string tienDV { get; set; }
    }
}
