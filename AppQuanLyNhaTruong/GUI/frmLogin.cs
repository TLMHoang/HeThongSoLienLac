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

        private async void btnLogin_Click(object sender, EventArgs e)
        {            
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (await account.DangNhap(userName, passWord) == true)
            {
                frmMain f = new frmMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu !","Notification !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
