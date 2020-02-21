using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        TaiKhoanTruongBAL account = new TaiKhoanTruongBAL();
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
                var dt = await account.DangNhap(txtUserName.Text, txtPassWord.Text);
                if (dt != null)
                {
                    //frmMain f = new frmMain();
                    //this.Hide();
                    //f.ShowDialog();
                    //this.Show();
                    Program.TK = new TaiKhoanTruong(dt.Rows[0]);
                    
                    DialogResult = DialogResult.Yes;
                    this.FormClosing -= frmLogin_FormClosing;
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

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lấy lại mật khẩu ?\nYES lây lại vui lòng điền vào mẫu\nNO lấy thông tin hỗ trợ.",
                "Thông Báo !",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process cmd = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "CMD.exe";
                startInfo.Arguments = "/c start https://docs.google.com/forms/d/1FsFsaOEpQdpSLa9VPqIGX4FxQNNXiR1bayBNj-Q-5-o/edit";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                cmd.StartInfo = startInfo;
                cmd.Start();
            }
            else
            {
                MessageBox.Show("Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát phần mềm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            DialogResult = DialogResult.No;
        }
    }
}
/*
 link lay lai mk
 https://docs.google.com/forms/d/1FsFsaOEpQdpSLa9VPqIGX4FxQNNXiR1bayBNj-Q-5-o/edit
     */
