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
        

        private void frmHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            DialogResult ret = MessageBox.Show("Bạn có thoát không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát không", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                this.Close();
        }

        public async void Them()
        {
            await tt.Them(new ThongTinHS(
                int.Parse(txtMa.Text),
                txtTen.Text,
                dtpNgaySinh.Value,
                Convert.ToByte(radNam.Checked),
                txtNoiSinh.Text, 
                txtDanToc.Text,
                txtTonGiao.Text, 
                int.Parse(txtMaTK.Text), 
                int.Parse(txtMaLop.Text), 
                txtTenMe.Text, 
                txtSDTMe.Text, 
                txtTenBa.Text, 
                txtSDTBa.Text
                ));
            
            this.DialogResult = DialogResult.OK;
            this.Close();




        }
        private async void btnThem_Click(object sender, EventArgs e)
        {


            if (await tt.KiemTraID(int.Parse(txtMa.Text)) == null)
                try
                {
                    Them();
                    MessageBox.Show("Thêm Thành Công !");
                    New();
                    loadHS();
                    
                    
                }
                catch (Exception) 
                { MessageBox.Show("Lỗi !"); }
            else
            {
                MessageBox.Show("TK Đã Tồn Tại");
            }

        }
        public async void xoa()
        {
            int id = int.Parse(txtMa.Text);
            await new ThongTinGVBAL().Xoa(id);
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
            if (await new ThongTinHSBAL().KiemTraID(int.Parse(txtMa.Text)) == null)
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
                txtNoiSinh.Text, txtDanToc.Text,
                txtTonGiao.Text, int.Parse(txtMa.Text),
                int.Parse(txtMa.Text),
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
            txtMaLop.Text = "";
            txtMaTK.Text = "";
            txtTenBa.Text = "";
            txtSDTBa.Text = "";
            txtTenMe.Text = "";
            txtSDTMe.Text = "";
        }

        
        private  void frmHocSinh_Load(object sender, EventArgs e)
        {
            loadHS();
        }

        private async void loadHS()
        {
            dgvHocSinh.SuspendLayout();
            bsThongTinHS.SuspendBinding();
            bsThongTinHS.DataSource = await tt.LayDT();
            bsThongTinHS.ResumeBinding();
            dgvHocSinh.ResumeLayout();

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
