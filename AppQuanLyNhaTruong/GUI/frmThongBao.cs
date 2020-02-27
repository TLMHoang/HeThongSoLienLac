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
        int id = -1;
        int idLop = -1;
        public frmThongBao()
        {
            InitializeComponent();
        }

        private void frmThongBao_Load(object sender, EventArgs e)
        {
            lblThongTinLop.Visible = false;
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
                cboChonLop.Visible = true;
            }
            else
            {
                LoadDGVTruong();
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

        }
        public async void LoadCBOChonLop()
        {
            cboChonLop.DataSource = await new LopBAL().LayDT();
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "ID";
        }
        public void XoaRTB()
        {
            rtbNhapNoiDung.Clear();
            id = -1;
            idLop = -1;
        }


        #endregion


        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                {
                    if (cboChonLoaiTB.SelectedIndex != 1)
                    {
                        if((await tbt.CapNhap(new ThongBaoTruong(id, rtbNhapNoiDung.Text))) != 0)
                        {
                            MessageBox.Show("Cập Nhật Thành Công !");
                            cboChonLoaiTB.Enabled = true;
                            LoadDGVTruong();
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Thất Bại !");
                            cboChonLoaiTB.Enabled = true;
                            LoadDGVTruong();
                            XoaRTB();
                        }
                        
                    }
                    else
                    {
                        if((await tbl.CapNhap(new ThongBaoLop(id, idLop, rtbNhapNoiDung.Text))) != 0)
                        {
                            MessageBox.Show("Cập Nhật Thành Công !");
                            cboChonLoaiTB.Enabled = true;
                            cboChonLop.Visible = true;
                            lblThongTinLop.Visible = false;
                            LoadDGVLop();
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Thất Bại !");
                            cboChonLoaiTB.Enabled = true;
                            cboChonLop.Visible = true;
                            lblThongTinLop.Visible = false;
                            LoadDGVLop();
                            XoaRTB();
                        }                        
                    }
                }
                else
                {
                    if (cboChonLoaiTB.SelectedIndex != 1)
                    {
                        if((await tbt.Them(new ThongBaoTruong(-1, rtbNhapNoiDung.Text))) != 0)
                        {
                            MessageBox.Show("Thêm Thành Công !");
                            LoadDGVTruong();
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại !");
                            LoadDGVTruong();
                            XoaRTB();
                        }                        
                    }
                    else
                    {
                        if((await tbl.Them(new ThongBaoLop(-1, int.Parse(cboChonLop.SelectedValue.ToString()), rtbNhapNoiDung.Text))) != 0)
                        {
                            MessageBox.Show("Thêm Thành Công !");
                            LoadDGVLop();
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại !");
                            LoadDGVLop();
                            XoaRTB();
                        }                       
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi !\n" + ex.Message);
            }
        }

        private async void dgvDSTB_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (cboChonLoaiTB.SelectedIndex != 1)
                    {
                        if((await tbt.Xoa(id)) != 0)
                        {
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Thất Bại !");
                            XoaRTB();
                        }                       
                    }

                    else
                    {
                        if((await tbl.Xoa(id)) != 0)
                        {
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Thất Bại");
                            XoaRTB();
                        }                        
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi !\n" + ex.Message);
            }
        }

        private void dgvDSTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvDSTB.Rows[e.RowIndex];
            if (row.Cells[0].Value.ToString() != "")
            {
                if (cboChonLoaiTB.SelectedIndex != 1)
                {
                    if (e.RowIndex >= 0)
                    {
                        id = int.Parse(row.Cells[0].Value.ToString());
                        rtbNhapNoiDung.Text = row.Cells[1].Value.ToString();
                        cboChonLoaiTB.Enabled = false;
                    }
                }
                else
                {
                    if (e.RowIndex >= 0)
                    {
                        id = int.Parse(row.Cells[0].Value.ToString());
                        idLop = int.Parse(row.Cells[1].Value.ToString());
                        rtbNhapNoiDung.Text = row.Cells[2].Value.ToString();
                        lblThongTinLop.Visible = true;
                        cboChonLop.Visible = false;
                        lblThongTinLop.Text = "Lớp Đang Chọn : "  + Program.lstLop.FirstOrDefault(p => p.ID == idLop).TenLop;
                        cboChonLoaiTB.Enabled = false;
                    }
                }
            }
        }
    }
}
