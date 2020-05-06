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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (htEntities context = new htEntities())
            {
                if (textBoxMkCu.Text == LoginForm.password && textBoxMkMoi.Text == textBoxMkMoiR.Text)
                {
                    string idEmp = context.getIdNV(LoginForm.username, LoginForm.password).FirstOrDefault();
                    context.changePass(textBoxMkMoi.Text, idEmp);
                    try
                    {
                        MessageBox.Show("doi mk thanh cong");
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    textBoxMkCu.Text = textBoxMkMoi.Text = textBoxMkMoiR.Text = "";
                }
                else if (textBoxMkCu.Text == "")
                {
                    MessageBox.Show("vui long nhap mk cu");
                }
                else if (textBoxMkMoi.Text == "")
                {
                    MessageBox.Show("vui long nhap mk moi");
                }
                else if (textBoxMkMoi.Text != textBoxMkMoiR.Text)
                {
                    MessageBox.Show("mk khong khop");
                }
                else
                {
                    MessageBox.Show("mk cu khong chinh xac");
                }
            }
        }
    }
}
