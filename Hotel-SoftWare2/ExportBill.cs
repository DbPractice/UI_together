using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Hotel_SoftWare2
{
    public partial class ExportBill : Form
    { 
        public ExportBill()
        {
            InitializeComponent();
        }

        private void ExportBill_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            showData();
        }
        
        private void showData()
        {
            //List<ReportParameterCollection> rp = new List<ReportParameterCollection>();
            ReportParameterCollection rp = new ReportParameterCollection();
            rp.Add(new ReportParameter("ReportParameterIdBill", billForm.idBill));
            rp.Add(new ReportParameter("ReportParameterDate", billForm.Date));
            rp.Add(new ReportParameter("ReportParameternvLap", billForm.nvLap));
            rp.Add(new ReportParameter("ReportParametermaKH", billForm.maKH));
            rp.Add(new ReportParameter("ReportParametertenKH", billForm.hoten));
            rp.Add(new ReportParameter("ReportParametersoCMND", billForm.soCMND));
            rp.Add(new ReportParameter("ReportParameterdiaChi", billForm.diaChi));
            rp.Add(new ReportParameter("ReportParametersdt", billForm.sdt));
            rp.Add(new ReportParameter("ReportParametertienPhong", billForm.tienPhong));
            rp.Add(new ReportParameter("ReportParametertienDV", billForm.tienDV));
            rp.Add(new ReportParameter("ReportParameter1tongTien", billForm.tongTien));
            rp.Add(new ReportParameter("ReportParameterHTTT", billForm.httt));
            this.reportViewer1.LocalReport.SetParameters(rp);
            this.reportViewer1.RefreshReport();

            //int i;
            //List<ChiTietTienPhong> tp = new List<ChiTietTienPhong>();
            //tp.Clear();
            //for (i = 0; i < billForm.dgvTP.Rows.Count-1; i++)
            //{
            //    tp.Add(new ChiTietTienPhong {
            //        tenphong = billForm.dgvTP.Rows[i].Cells[0].Value.ToString(),
            //        ngayvao = billForm.dgvTP.Rows[i].Cells[1].Value.ToString(),
            //        ngayra = billForm.dgvTP.Rows[i].Cells[2].Value.ToString(),
            //        songayo = billForm.dgvTP.Rows[i].Cells[3].Value.ToString(),
            //        tienphong = billForm.dgvTP.Rows[i].Cells[4].Value.ToString()
            //    });
            //    rs.Name = "DataSet1";
            //    rs.Value = tp;
            //}
        }

        //public class ChiTietTienPhong
        //{
        //    public string tenphong { get; set; }
        //    public string ngayvao { get; set; }
        //    public string ngayra { get; set; }
        //    public string songayo { get; set; }
        //    public string tienphong { get; set; }
        //}

        //public class ChiTietTienDV
        //{
        //    public string tenphong { get; set; }
        //    public string tendv { get; set; }
        //    public string ngaysd { get; set; }
        //    public string soluong { get; set; }
        //    public string tienDV { get; set; }
        //}
    }
}
