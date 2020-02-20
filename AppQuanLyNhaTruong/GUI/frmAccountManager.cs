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
using DTO;

namespace GUI
{
    public partial class frmAccountManager : Form
    {
        ThongTinGVBAL ttgv = new ThongTinGVBAL();
        public frmAccountManager()
        {
            InitializeComponent();
        }

        private void frmAccountManager_Load(object sender, EventArgs e)
        {
            LoadDGVGiaoVien();
            LoadCBOMonHocGV();
            LoadCBOLopHocGV();
        }

        private void txtNhapTenGVCanTim_Enter(object sender, EventArgs e)
        {
            if (txtNhapTen.Text == "Nhập ID Hoặc Tên Để Tìm")
            {
                txtNhapTen.Text = "";
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        private void txtNhapTenGVCanTim_Leave(object sender, EventArgs e)
        {
            if (txtNhapTen.TextLength == 0)
            {
                txtNhapTen.Text = "Nhập ID Hoặc Tên Để Tìm";
                txtNhapTen.ForeColor = Color.Gray;
            }
        }

        private void txtNhapTenGVCanTim_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapTen.Text != "Nhập ID Hoặc Tên Để Tìm")
            {
                if (txtNhapTen.TextLength > 0)
                {
                    bsDSGV.Filter = String.Format("CONVERT(IDTKT,System.String)='{0}' OR [TenGV] LIKE '%{0}%'", txtNhapTen.Text);
                }
                else
                {
                    bsDSGV.RemoveFilter();
                }
            }
            else
            {
                bsDSGV.RemoveFilter();
            }
        }

        private async void btnThemGV_Click(object sender, EventArgs e)
        {
            if (await new ThongTinGVBAL().KiemTraID(int.Parse(txtNhapID.Text)) == null)
                try
                {
                    ThemTKGV();
                    MessageBox.Show("Thêm Thành Công !");
                    XoaTextBoxGV();
                    LoadDGVGiaoVien();
                }
                catch (Exception) { MessageBox.Show("Lỗi !"); }
            else
            {
                MessageBox.Show("TK Đã Tồn Tại");
            }
        }

        private async void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (await new ThongTinGVBAL().KiemTraID(int.Parse(txtNhapID.Text)) == null)
                MessageBox.Show("TK Không Tồn Tại");
            else
            {
                try
                {
                    CapNhatTKGV();
                    MessageBox.Show("Cập Nhật Thành Công !");
                    XoaTextBoxGV();
                    LoadDGVGiaoVien();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !");
                }
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa ?", "Notification !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    XoaTKGV();
                    MessageBox.Show("Xóa Thành Công");
                    XoaTextBoxGV();
                    LoadDGVGiaoVien();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !");
                }
            }
        }

        #region Ham
        public async void LoadDGVGiaoVien()
        {
            bsDSGV.SuspendBinding();
            dgvDSGV.SuspendLayout();
            dgvDSGV.DataSource = await new ThongTinGVBAL().LayDT();
            dgvDSGV.ResumeLayout();
            bsDSGV.ResumeBinding();
        }
        public async void ThemTKGV()
        {
            await ttgv.Them(new ThongTinGV(
                int.Parse(txtNhapID.Text),
                txtNhapTenGV.Text,
                txtSDT.Text,
                int.Parse(cboMonHoc.SelectedValue.ToString()),
                int.Parse(cboLopPhuTrach.SelectedValue.ToString())
                ));

        }
        public async void CapNhatTKGV()
        {
            await ttgv.CapNhap(new ThongTinGV(
                int.Parse(txtNhapID.Text),
                txtNhapTenGV.Text,
                txtSDT.Text,
                int.Parse(cboMonHoc.SelectedValue.ToString()),
                int.Parse(cboLopPhuTrach.SelectedValue.ToString())
                ));
        }
        public async void XoaTKGV()
        {
            int IDTKT = int.Parse(txtNhapID.Text);
            await new ThongTinGVBAL().Xoa(IDTKT);
        }
        public async void LoadCBOMonHocGV()
        {
            cboMonHoc.DataSource = await new MonHocBAL().LayDT();
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "ID";
        }
        public async void LoadCBOLopHocGV()
        {
            cboLopPhuTrach.DataSource = await new LopBAL().LayDT();
            cboLopPhuTrach.DisplayMember = "TenLop";
            cboLopPhuTrach.ValueMember = "ID";
        }
        public void XoaTextBoxGV()
        {
            txtNhapID.Clear();
            txtNhapTenGV.Clear();
            txtSDT.Clear();
            txtNhapID.Focus();
        }





        #endregion

        
    }
}
