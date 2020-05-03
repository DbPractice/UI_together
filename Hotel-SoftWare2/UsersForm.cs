using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Hotel_SoftWare2
{
    public partial class UsersForm : Form
    {
        htEntities user = new htEntities();
        public UsersForm()
        {
            InitializeComponent();
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            
            
            showUsers(dgvUsers);
            //transData();
            lockText();
        }

        private void lockText()
        {
            textBoxMaNV.Enabled = textBoxTenTK.Enabled = textBoxMK.Enabled = textBoxNhapLaiMK.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
            checkBoxQuanLy.Enabled = checkBoxLeTan.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenTK.Enabled = textBoxMK.Enabled = true;
            checkBoxQuanLy.Enabled = checkBoxLeTan.Enabled = textBoxNhapLaiMK.Enabled = true;
        }

        private void showUsers(DataGridView dgv)
        {
            dgv.DataSource = user.getAccount();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            unlockText();
            check();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("xoa khach hang nay?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                user.delEmp(textBoxMaNV.Text);
                try
                {
                    MessageBox.Show("xoa tai khoan thành công");
                    user.SaveChanges();
                    showUsers(dgvUsers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
                //textBoxMaKH.Text = "";
            }
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxNhapLaiMK.Text == textBoxMK.Text)
            {
                user.updateAcc(textBoxMaNV.Text, textBoxTenTK.Text, textBoxMK.Text, checkBoxLeTan.Checked);
                try
                {
                    MessageBox.Show("cap nhat thong tin tai khoan cho nhan vien");
                    user.SaveChanges();
                    showUsers(dgvUsers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                lockText();
            }
            else
            {
                MessageBox.Show("mk nhap lai phai giong voi mk dat");
            }
        }
        private void clearText()
        {
            textBoxMaNV.Text = textBoxTenTK.Text = textBoxMK.Text = textBoxNhapLaiMK.Text = "";
            checkBoxLeTan.Checked = checkBoxQuanLy.Checked = false;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvUsers.Rows[e.RowIndex];
                if (row.Cells[2].Value is null && row.Cells[3].Value is null && row.Cells[4].Value is null)
                {
                    textBoxMaNV.Text = row.Cells[0].Value.ToString();
                    textBoxTenTK.Text = textBoxMK.Text =  string.Empty;
                    checkBoxLeTan.Checked = checkBoxQuanLy.Checked = false;
                }
                else
                {
                    textBoxMaNV.Text = row.Cells[0].Value.ToString();
                    textBoxTenTK.Text = row.Cells[2].Value.ToString();
                    textBoxMK.Text = row.Cells[3].Value.ToString();
                    if (row.Cells[4].Value.ToString() == "True")
                    {
                        checkBoxQuanLy.Checked = true;
                        checkBoxLeTan.Checked = false;
                    }
                    else
                    {
                        checkBoxLeTan.Checked = true;
                        checkBoxQuanLy.Checked = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void checkBoxQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxQuanLy.Checked == true)
            {
                checkBoxLeTan.Enabled = false;
            }
            else
            {
                checkBoxLeTan.Enabled = true;
            }
        }

        private void checkBoxLeTan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeTan.Checked == true)
            {
                checkBoxQuanLy.Enabled = false;
            }
            else
            {
                checkBoxQuanLy.Enabled = true;
            }
        }

        private void check()
        {
            if (checkBoxQuanLy.Checked == true)
            {
                checkBoxLeTan.Enabled = false;
            }
            else if (checkBoxLeTan.Checked == true)
            {
                checkBoxQuanLy.Enabled = false;
            }
        }

        /*private void transData()
        {
            //DataGridViewCellEventArgs e = new DataGridViewCellEventArgs();
            //DataGridViewRow row = new DataGridViewRow();
            //row = dgvUsers.Rows[e.RowIndex];
            //if (row.Cells[4].Value.ToString() == "True")
            //{
            //    row.Cells[4].Value = "Admin";
            //}
            //else
            //{
            //    row.Cells[4].Value = "Lễ tân";
            //}
            DataGridViewRow row = dgvUsers.Rows[2];
            row.Cells[4].Value = "test";

        }*/
    }
}
