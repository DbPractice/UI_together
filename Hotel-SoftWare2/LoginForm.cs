using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;

namespace Hotel_SoftWare2
{
    public partial class LoginForm : Form
    {
        Thread th;
        public static string username;
        public static string password;
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
        //        public partial class NhanVien
        //{
        //    public List<NhanVien> getPass()
        //    {
        //        htEntities context = new htEntities();
        //        return context.NhanViens.ToList();
        //    }
        //}
            NhanVien obj = new NhanVien();
            List<NhanVien> list = obj.getPass();
            username = textBoxUserName.Text;
            password = textBoxPassWord.Text;
            var check = list.Where(item => item.TenTk.Equals(username)).ToList();
            if (check.Count > 0)
            {
                if (check[0].MatKhau.Equals(password))
                {
                    MessageBox.Show("dang nhap thanh cong");
                    this.Close();
                    th = new Thread(openMainForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("mat khau khong dung");
                }
            }
            else
            {
                MessageBox.Show("khong ton tai tk");
            }

            //DataGridView dt = new DataGridView();
            //dt.DataSource = account.logIn(textBoxUserName.Text, textBoxPassWord.Text);
            //if (dt.DataSource != null)
            //{
            //    MessageBox.Show("dang nhap thanh cong");
            //    this.Close();
            //    th = new Thread(openMainForm);
            //    th.SetApartmentState(ApartmentState.STA);
            //    th.Start();
            //}
            //else
            //{
            //    MessageBox.Show("ten tk hoac mk k dung");
            //}

        }
        private void openMainForm(object obj)
        {
            Application.Run(new MainForm());
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "UserName")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "UserName";
                textBoxUserName.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPassWord_Enter(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "PassWord")
            {
                textBoxPassWord.Text = "";
                textBoxPassWord.ForeColor = Color.LightGray;
                textBoxPassWord.UseSystemPasswordChar = true;
            }
            
            
        }

        private void textBoxPassWord_Leave(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "") 
            {
                textBoxPassWord.Text = "PassWord";
                textBoxPassWord.ForeColor = Color.DimGray;
                textBoxPassWord.UseSystemPasswordChar = false;
            }
            
        }
    }
}
