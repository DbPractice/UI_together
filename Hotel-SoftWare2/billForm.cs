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

        //private void autoIdBill()
        //{
        //    using (htEntities bill = new htEntities())
        //    {

        //    }
        //}
    }
}
