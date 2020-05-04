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
    public partial class EmployeesForm : Form
    {
        htEntities emp = new htEntities();
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            implementID();
            status = true;
            unlockText();
            clearText();
            btnSua.Enabled = false;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            ShowEmp(dgvEmp);
            lockText();
        }

        private void ShowEmp(DataGridView dgv)
        {
            dgv.DataSource = emp.getallEmp();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void lockText()
        {
            textBoxMaNV.Enabled = textBoxHoTenNV.Enabled = dateTimePickerEmp.Enabled = textBoxSDT.Enabled = false;
            dateTimePickerEmp.Text = "";
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxHoTenNV.Enabled = dateTimePickerEmp.Enabled = textBoxSDT.Enabled = true;
        }

        bool status;
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                emp.addEmp(textBoxMaNV.Text, textBoxHoTenNV.Text, dateTimePickerEmp.Value, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Them KH thanh cong");
                    emp.SaveChanges();
                    ShowEmp(dgvEmp);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                emp.updateEmp(textBoxMaNV.Text, textBoxHoTenNV.Text, dateTimePickerEmp.Value, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("cap nhat thong tin nhan vien thanh cong");
                    emp.SaveChanges();
                    ShowEmp(dgvEmp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
            implementID();
        }

        private void clearText()
        {
            textBoxHoTenNV.Text =  textBoxSDT.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
            textBoxMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("xoa nhan vien nay?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                emp.delEmp(textBoxMaNV.Text);
                try
                {
                    MessageBox.Show("xoa nhan vien thành công");
                    emp.SaveChanges();
                    ShowEmp(dgvEmp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
                textBoxMaNV.Text = "";
            }
        }

        private void implementID()
        {
            int count = 0;
            count = dgvEmp.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvEmp.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
                textBoxMaNV.Text = "MNV0" + (chuoi2 + 1).ToString();
            else
                textBoxMaNV.Text = "MNV" + (chuoi2 + 1).ToString();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvEmp.Rows[e.RowIndex];
                textBoxMaNV.Text = row.Cells[0].Value.ToString();
                textBoxHoTenNV.Text = row.Cells[1].Value.ToString();
                dateTimePickerEmp.Text = row.Cells[2].Value.ToString();
                textBoxSDT.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
