using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace AppQuanLyNhaTruong
{
    public partial class frmLogin : Form
    {
        TaiKhoangTruongBAL account = new TaiKhoangTruongBAL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassWord_Leave(null, null);
            txtUserName_Leave(null, null);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //string userName = txtUserName.Text;
            //string passWord = txtPassWord.Text;
            //if (await account.DangNhap(userName, passWord) != null)
            //{
            //    frmMain f = new frmMain();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu !", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (!CheckNull(txtUserName) && !CheckNull(txtPassWord))
            {
                if (await account.DangNhap(txtUserName.Text, txtPassWord.Text) != null)
                {
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu !", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin_Load(null, null);
                    TrangThai(true);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập Tên Đăng Nhập Hoặc Mật Khẩu !", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TrangThai(true);
            }
        }

        private void TrangThai(bool b)
        {
            txtUserName.Enabled = txtPassWord.Enabled = btnLogin.Enabled = b;
        }

        private bool CheckNull(TextBox txt)
        {
            TrangThai(false);
            if (txt.ForeColor == Color.Gray)
            {
                return true;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Vui Lòng Liên Hệ US Team Để Lấy Lại Mật Khẩu !", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Hieu ứng cho txt dn

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Nhập tài khoản"))
            {
                txtUserName.ForeColor = Color.Black;
                txtUserName.Text = "";
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            if (txtPassWord.Text.Equals("Nhập mật khẩu"))
            {
                txtPassWord.ForeColor = Color.Black;
                txtPassWord.Text = "";
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.ForeColor = Color.Gray;
                txtUserName.Text = "Nhập tài khoản";
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "")
            {
                txtPassWord.ForeColor = Color.Gray;
                txtPassWord.Text = "Nhập mật khẩu";
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        #endregion

    }
}
/*
 link lay lai mk
 https://docs.google.com/forms/d/1FsFsaOEpQdpSLa9VPqIGX4FxQNNXiR1bayBNj-Q-5-o/edit
     */
