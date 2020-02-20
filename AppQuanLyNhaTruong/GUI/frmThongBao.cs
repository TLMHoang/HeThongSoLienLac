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
    public partial class frmThongBao : Form
    {
        ThongBaoTruongBAL tbt = new ThongBaoTruongBAL();
        ThongBaoLopBAL tbl = new ThongBaoLopBAL();
        public frmThongBao()
        {
            InitializeComponent();            
        }

        private void frmThongBao_Load(object sender, EventArgs e)
        {
            lblChonLop.Visible = false;
            cboChonLop.Visible = false;
            LoadCBO();
            LoadDGVTruong();
        }

        private void cboChonLoaiTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvDSTB.DataSource = null;
            this.dgvDSTB.Rows.Clear();
            dgvDSTB.Refresh();
            if (cboChonLoaiTB.SelectedIndex == 1)
            {
                LoadDGVLop();
                LoadCBOChonLop();
                lblChonLop.Visible = true;
                cboChonLop.Visible = true;
            }
            else
            {
                LoadDGVTruong();
                lblChonLop.Visible = false;
                cboChonLop.Visible = false;
            }
                
        }

        #region ham
        public async void LoadDGVTruong()
        {
            bsThongBaoTruong.SuspendBinding();
            dgvDSTB.SuspendLayout();
            dgvDSTB.DataSource = await new ThongBaoTruongBAL().LayDT();
            bsThongBaoTruong.ResumeBinding();
            dgvDSTB.ResumeLayout();
            dgvDSTB.Columns[0].HeaderText = "Số Thông Báo";
            dgvDSTB.Columns[1].HeaderText = "Nội Dung";
        }
        public async void LoadDGVLop()
        {
            bsThongBaoLop.SuspendBinding();
            dgvDSTB.SuspendLayout();
            dgvDSTB.DataSource = await new ThongBaoLopBAL().LayDT();
            bsThongBaoLop.ResumeBinding();
            dgvDSTB.ResumeLayout();
            dgvDSTB.Columns[0].HeaderText = "Số Thông Báo";
            dgvDSTB.Columns[1].HeaderText = "Mã Lớp";
            dgvDSTB.Columns[2].HeaderText = "Nội Dung";
        }
        public void LoadCBO()
        {
            cboChonLoaiTB.Items.Add("Thông Báo Trường");
            cboChonLoaiTB.Items.Add("Thông Báo Lớp");
            cboChonLoaiTB.Text = "-----Chọn Loại Thông Báo-----";

        }
        public async void LoadCBOChonLop()
        {
            cboChonLop.DataSource = await new LopBAL().LayDT();
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "ID";
        }
        #endregion

        private async void btnThem_Click(object sender, EventArgs e)
        {
            //chua check ID
            try
            {
                if (cboChonLoaiTB.SelectedIndex != 1)
                {
                    await tbt.Them(new ThongBaoTruong(-1, rtbNhapNoiDung.Text));
                    MessageBox.Show("Thêm Thành Công !");
                    LoadDGVTruong();
                }
                else
                {
                    await tbl.Them(new ThongBaoLop(-1, int.Parse(cboChonLop.SelectedValue.ToString()), rtbNhapNoiDung.Text));
                    MessageBox.Show("Thêm Thành Công !");
                    LoadDGVLop();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            //chua check ID
            //try
            //{
            //    if (cboChonLoaiTB.SelectedIndex != 1)
            //    {
            //        await tbt.CapNhap(new ThongBaoTruong(-1, rtbNhapNoiDung.Text));
            //        MessageBox.Show("Cập Nhật Thành Công !");
            //        LoadDGVTruong();
            //    }
            //    else
            //    {
            //        await tbl.CapNhap(new ThongBaoLop(-1, int.Parse(cboChonLop.SelectedValue.ToString()), rtbNhapNoiDung.Text));
            //        MessageBox.Show("Cập Nhật Thành Công !");
            //        LoadDGVLop();
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Lỗi !");
            //}
        }
    }
}
