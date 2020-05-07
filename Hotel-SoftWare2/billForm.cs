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
    
    public partial class billForm : Form
    {
        
        public billForm()
        {
            InitializeComponent();
        }

        private void FillCombobox()
        {
            using (htEntities bill = new htEntities())
            {
                var getIdMptList = from PhieuThuePhong in bill.PhieuThuePhongs
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
        }
        private void billForm_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (htEntities context = new htEntities())
            {
                //string mpt = Convert.ToString(comboBoxMaPT.Text);
                //var result = context.KhachHangs.Select(p => p.MaKH).FirstOrDefault();
                //labelmaKH.Text = result;
                var result = from c in context.PhieuThuePhongs
                             where c.MaPhieuThuePhong == comboBoxMaPT.Text
                             select c.MaKH;
                var result1 = from c in context.PhieuThuePhongs
                              where c.MaPhieuThuePhong == comboBoxMaPT.Text
                             select new { c.NhanVien.HoTen };
                //var result2 = from c in context.PhieuThuePhongs
                //             where c.MaPhieuThuePhong == comboBoxMaPT.Text
                //             select c.te;
                //var result3 = from c in context.PhieuThuePhongs
                //             where c.MaPhieuThuePhong == comboBoxMaPT.Text
                //             select c.MaKH;
                //var result4 = from c in context.PhieuThuePhongs
                //             where c.MaPhieuThuePhong == comboBoxMaPT.Text
                //             select c.MaKH;
                //var result5 = from c in context.PhieuThuePhongs
                //             where c.MaPhieuThuePhong == comboBoxMaPT.Text
                //             select c.MaKH;
                labelmaKH.Text = result.FirstOrDefault();
                labelnvLap.Text = result1.FirstOrDefault().ToString();
            }
        }

        //private void autoIdBill()
        //{
        //    using (htEntities bill = new htEntities())
        //    {

        //    }
        //}
    }
}
