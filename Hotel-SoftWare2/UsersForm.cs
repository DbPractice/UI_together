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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openChildForm2(Form childForm2)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm2;
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Fill;
            dataGridViewUsers.Controls.Add(childForm2);
            dataGridViewUsers.Tag = childForm2;
            childForm2.BringToFront();
            childForm2.Show();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            openChildForm2(new AddUsersForm());
        }
    }
}
