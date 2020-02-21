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
    public partial class frmHocSinh : Form
    {

       ThongTinHSBAL tt = new ThongTinHSBAL();

        public frmHocSinh()
        {
            InitializeComponent();
        }

        public frmHocSinh(TaiKhoanTruong tK, ThongTinGV gV)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (tK.Loai == 1)
            {
                lblNameFrom.Text += "toàn trường";
            }
            else
            {
                lblNameFrom.Text += "lớp " + Program.lstLop.FirstOrDefault(p => p.ID == gV.IDLop).TenLop;
            }
        }

        private void frmHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if ( await tt.Them(new ThongTinHS(
                int.Parse(txtMa.Text),
                txtTen.Text,
                dtpNgaySinh.Value,
                Convert.ToByte(radNam.Checked),
                txtNoiSinh.Text,
                txtDanToc.Text,
                txtTonGiao.Text,
                -1,
                int.Parse(cbxLop.Text),
                txtTenMe.Text,
                txtSDTMe.Text,
                txtTenBa.Text,
                txtSDTBa.Text
                )) == 1)
            {
                MessageBox.Show("Thêm Thành Công !");
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }

        }
        public async void xoa()
        {
            await new ThongTinGVBAL().Xoa(int.Parse(txtMa.Text));
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa ?", "Hỏi Xóa !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    xoa();
                    MessageBox.Show("Xóa Thành Công");
                    New();
                    loadHS();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !");
                }
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (await new ThongTinHSBAL().LayID(int.Parse(txtMa.Text)) == null)
                MessageBox.Show("TK Không Tồn Tại");
            else
            {
                try
                {
                    update();
                    MessageBox.Show("Cập Nhật Thành Công !");
                    New();
                    loadHS();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !");
                }
            }
        }

        private async void update()
        {
            await tt.CapNhap(new ThongTinHS(
                int.Parse(txtMa.Text),
                txtTen.Text,
                dtpNgaySinh.Value,
                Convert.ToByte(radNam.Checked),
                txtNoiSinh.Text,
                txtDanToc.Text,
                txtTonGiao.Text,
                -1,
                int.Parse(cbxLop.Text),
                txtTenMe.Text,
                txtSDTMe.Text,
                txtTenBa.Text,
                txtSDTBa.Text
                ));
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            New();
        }
        private void New()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            radNam.Checked = true;
            txtNoiSinh.Text = "";
            dtpNgaySinh.Text="";
            txtDanToc.Text = "";
            txtTonGiao.Text = "";
            cbxLop.SelectedItem = cbxLop.Items[0];
            txtTenBa.Text = "";
            txtSDTBa.Text = "";
            txtTenMe.Text = "";
            txtSDTMe.Text = "";
            txtTen.Focus();
        }

        
        private  void frmHocSinh_Load(object sender, EventArgs e)
        {
            bsThongTinHS.SuspendBinding();
            dgvHocSinh.SuspendLayout();

            foreach (Lop l in Program.lstLop)
            {
                cbxLop.Items.Add(l.ID + "-" + l.TenLop);
            }

            loadHS();

            dgvHocSinh.ResumeLayout();
            bsThongTinHS.ResumeBinding();
        }

        private async void loadHS()
        {
            bsThongTinHS.DataSource = await tt.LayDT();
        }

        private void dgvHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i;
            //i = e.RowIndex;
            //txtMa.Text = dgvHocSinh.Rows[i].Cells[0].Value.ToString();
            //txtTen.Text = dgvHocSinh.Rows[i].Cells[1].Value.ToString();
            //string GioiTinh;
            //GioiTinh = dgvHocSinh.Rows[i].Cells[2].Value.ToString();
            //if (GioiTinh == "Nữ")
            //{
            //    radNu.Checked = true;
            //}
            //else
            //{
            //    radNam.Checked = true;
            //}
            //txtNoiSinh.Text = dgvHocSinh.Rows[i].Cells[3].Value.ToString();
            //dtpNgaySinh.Text = dgvHocSinh.Rows[i].Cells[4].Value.ToString();

            //txtDanToc.Text = dgvHocSinh.Rows[i].Cells[5].Value.ToString();
            //txtTonGiao.Text = dgvHocSinh.Rows[i].Cells[6].Value.ToString();
            //txtMaLop.Text = dgvHocSinh.Rows[i].Cells[7].Value.ToString();
            //txtMaTK.Text = dgvHocSinh.Rows[i].Cells[8].Value.ToString();

            //txtTenBa.Text = dgvHocSinh.Rows[i].Cells[9].Value.ToString();
            //txtSDTBa.Text = dgvHocSinh.Rows[i].Cells[10].Value.ToString();
            //txtTenMe.Text = dgvHocSinh.Rows[i].Cells[11].Value.ToString();
            //txtSDTMe.Text = dgvHocSinh.Rows[i].Cells[12].Value.ToString();

        }
    }
}
