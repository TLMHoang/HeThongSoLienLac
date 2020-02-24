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
            cboChonLoaiTB.Text = "-----Chọn Loại Thông Báo-----";

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
            if (id != -1)
            {
                if (cboChonLoaiTB.SelectedIndex != 1)
                {
                    await tbt.CapNhap(new ThongBaoTruong(id, rtbNhapNoiDung.Text));
                    MessageBox.Show("Cập Nhật Thành Công !");
                    cboChonLoaiTB.Enabled = true;
                    LoadDGVTruong();
                    XoaRTB();
                }
                else
                {
                    await tbl.CapNhap(new ThongBaoLop(id, idLop, rtbNhapNoiDung.Text));
                    MessageBox.Show("Cập Nhật Thành Công !");
                    cboChonLoaiTB.Enabled = true;
                    LoadDGVLop();
                    XoaRTB();
                }
            }
            else
            {
                if (cboChonLoaiTB.SelectedIndex != 1)
                {
                    await tbt.Them(new ThongBaoTruong(-1, rtbNhapNoiDung.Text));
                    MessageBox.Show("Thêm Thành Công !");
                    LoadDGVTruong();
                    XoaRTB();
                }
                else
                {
                    await tbl.Them(new ThongBaoLop(-1, int.Parse(cboChonLop.SelectedValue.ToString()), rtbNhapNoiDung.Text));
                    MessageBox.Show("Thêm Thành Công !");
                    LoadDGVLop();
                    XoaRTB();
                }
            }
        }

        private async void dgvDSTB_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (cboChonLoaiTB.SelectedIndex != 1)
                {
                    await tbt.Xoa(id);
                    XoaRTB();
                }

                else
                {
                    await tbl.Xoa(id);
                    XoaRTB();
                }
            }
            else
            {
                e.Cancel = true;
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
                        cboChonLoaiTB.Enabled = false;
                    }
                }
            }
        }
    }
}
