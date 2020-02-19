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

namespace GUI
{
    public partial class frmTaiKhoanGiaoVien : Form
    {
        ThongTinGVBAL tt = new ThongTinGVBAL();
        public frmTaiKhoanGiaoVien()
        {
            InitializeComponent();
        }
        private void frmTaiKhoanGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadCBOMonHoc();
            LoadCBOLopHoc();
        }              

        private void txtNhapID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)Keys.Back)
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;                    
                    MessageBox.Show("Chỉ Nhập Số !");
                }
            }           
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            if(txtNhapTen.Text != "Nhập ID Hoặc Tên Để Tìm")
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

        private void txtNhapTen_Leave(object sender, EventArgs e)
        {
            if(txtNhapTen.TextLength == 0)
            {
                txtNhapTen.Text = "Nhập ID Hoặc Tên Để Tìm";
                txtNhapTen.ForeColor = Color.Gray;
            }
        }

        private void txtNhapTen_Enter(object sender, EventArgs e)
        {
            if(txtNhapTen.Text == "Nhập ID Hoặc Tên Để Tìm")
            {
                txtNhapTen.Text = "";
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (await new ThongTinGVBAL().KiemTraID(int.Parse(txtNhapID.Text)) == null)
                try
                {
                    ThemTK();
                    MessageBox.Show("Thêm Thành Công !");
                    XoaTextBox();
                    LoadDGV();
                }
                catch (Exception) { MessageBox.Show("Lỗi !"); }
            else
            {
                MessageBox.Show("TK Đã Tồn Tại");
            }
        }
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (await new ThongTinGVBAL().KiemTraID(int.Parse(txtNhapID.Text)) == null)
                MessageBox.Show("TK Không Tồn Tại");
            else
            {
                try
                {
                    CapNhatTK();
                    MessageBox.Show("Cập Nhật Thành Công !");
                    XoaTextBox();
                    LoadDGV();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa ?", "Notification !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    XoaTK();
                    MessageBox.Show("Xóa Thành Công");
                    XoaTextBox();
                    LoadDGV();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !");
                }
            }
        }
        #region Ham
        public async void LoadDGV()
        {
            bsDSGV.SuspendBinding();
            dgvDSGV.SuspendLayout();
            dgvDSGV.DataSource = await new ThongTinGVBAL().LayDT();
            dgvDSGV.ResumeLayout();
            bsDSGV.ResumeBinding();
        }
        public async void ThemTK()
        {            
            await tt.Them(new DTO.ThongTinGV(
                int.Parse(txtNhapID.Text),
                txtNhapTenGV.Text,
                txtSDT.Text,
                int.Parse(cboMonHoc.SelectedValue.ToString()),
                int.Parse(cboLopPhuTrach.SelectedValue.ToString()),
                chkGVCN.Checked ? (byte)1 : (byte)0
                ));

        }
        public async void CapNhatTK()
        {
            await tt.CapNhap(new DTO.ThongTinGV(
                int.Parse(txtNhapID.Text),
                txtNhapTenGV.Text,
                txtSDT.Text,
                int.Parse(cboMonHoc.SelectedValue.ToString()),
                int.Parse(cboLopPhuTrach.SelectedValue.ToString()),
                chkGVCN.Checked ? (byte)1 : (byte)0
                ));
        }
        public async void XoaTK()
        {
            int IDTKT = int.Parse(txtNhapID.Text);
            await new ThongTinGVBAL().Xoa(IDTKT);
        }
        public async void LoadCBOMonHoc()
        {
            cboMonHoc.DataSource = await new MonHocBAL().LayDT();
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "ID";
        }
        public async void LoadCBOLopHoc()
        {
            cboLopPhuTrach.DataSource = await new LopBAL().LayDT();
            cboLopPhuTrach.DisplayMember = "TenLop";
            cboLopPhuTrach.ValueMember = "ID";
        }
        public void XoaTextBox()
        {
            txtNhapID.Clear();
            txtNhapTenGV.Clear();
            txtSDT.Clear();
            chkGVCN.Checked = false;
            txtNhapID.Focus();
        }




        #endregion

        
    }
}
