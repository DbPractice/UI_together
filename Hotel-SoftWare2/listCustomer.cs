using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SoftWare2
{
    public partial class listCustomer : Form
    {
        public static string maKH;
        htEntities context = new htEntities();
        public listCustomer()
        {
            InitializeComponent();
        }

        private void listCustomer_Load(object sender, EventArgs e)
        {
            showCus(dgvlistCus);
        }

        private void showCus(DataGridView dgv)
        {
            dgv.DataSource = context.getallCus();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {

        }

        public void dgvlistCus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvlistCus.Rows[e.RowIndex];
            maKH = row.Cells[0].Value.ToString();
            this.Close();
        }

        private void listCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm m = new MainForm();
            m.openChildForm(new DatPhongForm());
        }
    }
}
