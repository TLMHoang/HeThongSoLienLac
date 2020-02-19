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


namespace AppQuanLyNhaTruong
{
    public partial class frmHocSinh : Form
    {
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
        

        private async void btnThem_Click(object sender, EventArgs e)
        {


            //ThongTinHS hs = new ThongTinHS(-1, txtTen.Text, txtNgaySinh.Text, radNam.Checked ? "0" : "1", txtNoiSinh.Text, txtTonGiao.Text, txtDanToc.Text, -1, -1, txtTenBa.Text, txtSDTBa.Text, txtTenMe.Text, txtSDTMe.Text);

            //await new ThongTinHSBAL().Them(hs);

            //MessageBox.Show("Thêm thành công");
            //loadHS();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            radNam.Checked = true;
            txtNoiSinh.Text = "";
            txtNgaySinh.Text = "";
            txtDanToc.Text = "";
            txtTonGiao.Text = "";
            txtTenBa.Text = "";
            txtSDTMe.Text = "";
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
            bsThongTinHS.DataSource = await new ThongTinHSBAL().LayDT();
            bsThongTinHS.ResumeBinding();
            dgvHocSinh.ResumeLayout();
        }

        private void dgvHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            txtMa.Text = dgvHocSinh.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dgvHocSinh.Rows[i].Cells[1].Value.ToString();
            string GioiTinh;
            GioiTinh = dgvHocSinh.Rows[i].Cells[3].Value.ToString();
            if (GioiTinh == "Nữ")
            {
                radNu.Checked = true;
            }
            else
            {
                radNam.Checked = true;
            }
            txtNoiSinh.Text = dgvHocSinh.Rows[i].Cells[4].Value.ToString();
            dgvHocSinh.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy" ;
            txtDanToc.Text = dgvHocSinh.Rows[i].Cells[5].Value.ToString();
            txtTonGiao.Text = dgvHocSinh.Rows[i].Cells[6].Value.ToString();
            txtTenBa.Text = dgvHocSinh.Rows[i].Cells[9].Value.ToString();
            txtSDTBa.Text = dgvHocSinh.Rows[i].Cells[10].Value.ToString();
            txtTenMe.Text = dgvHocSinh.Rows[i].Cells[7].Value.ToString();
            txtSDTMe.Text = dgvHocSinh.Rows[i].Cells[8].Value.ToString();

        }
    }
}
