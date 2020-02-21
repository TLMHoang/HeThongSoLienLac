using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanTruongBAL tkBAL = new TaiKhoanTruongBAL();
        public frmDoiMatKhau()
        {
            InitializeComponent();
            btnCapNhatThongTin.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDuLieuTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private async void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            if ((await tkBAL.DangNhap(Program.TK.TaiKhoan, txtMatKhau.Text)).Rows.Count == 1)
            {
                Program.TK.MatKhau = txtNhapLaiMatKhau.Text;
                if (await tkBAL.CapNhap(Program.TK) != -1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công.\n Vui lòng thử lại.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác.\n Vui lòng thử lại.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == txtMatKhauMoi.Text)
            {
                lblMKM.Visible = true;
            }
            else
            {
                lblMKM.Visible = false;
            }


            if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
            {
                lblNLMK.Visible = false;
            }
            else
            {
                lblNLMK.Visible = true;
            }
            if (txtMatKhauMoi.TextLength > 0 && txtNhapLaiMatKhau.TextLength > 0 && !lblMKM.Visible && !lblNLMK.Visible && txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
            {
                btnCapNhatThongTin.Enabled = true;
            }
            else
            {
                btnCapNhatThongTin.Enabled = false;
            }

        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.Text != "")
            {
                if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
                {
                    lblNLMK.Visible = false;
                }
                else
                {
                    lblNLMK.Visible = true;
                }
            }
            else
            {
                lblNLMK.Visible = false;
            }

            if (txtMatKhauMoi.TextLength > 0 && txtNhapLaiMatKhau.TextLength > 0 && !lblMKM.Visible && !lblNLMK.Visible && txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
            {
                btnCapNhatThongTin.Enabled = true;
            }
            else
            {
                btnCapNhatThongTin.Enabled = false;
            }
        }
    }
}
