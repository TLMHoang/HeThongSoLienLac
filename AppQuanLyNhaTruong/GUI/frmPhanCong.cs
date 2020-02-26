using BAL;
using DTO;
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
    public partial class frmPhanCong : Form
    {
        ThongTinGVBAL gvBAL = new ThongTinGVBAL();
        MonHocBAL monBAL = new MonHocBAL();
        PhanCongBAL pcBAL = new PhanCongBAL();
        LopBAL lopBAL = new LopBAL();
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private async void frmPhanCong_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            loadDataMonHoc();
            loadDataPhanCong();
            LoadDataGVCN();
        }
        #region tabMonHoc
        private void dgvMon_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }
        public async void loadDataMonHoc()
        {
            bsDSGV.SuspendBinding();
            bsMon.SuspendBinding();
            bsView.SuspendBinding();
            dgvDSGV.SuspendLayout();
            dgvMon.SuspendLayout();
            dgvView.SuspendLayout();

            bsDSGV.DataSource = await gvBAL.LayDT();
            bsMon.DataSource = await monBAL.LayDT();
            bsView.DataSource = await pcBAL.LayDT();

            Col_Loai.TrueValue = Convert.ToByte(1);
            Col_Loai.FalseValue = Convert.ToByte(0);

            dgvDSGV.ResumeLayout();
            dgvMon.ResumeLayout();
            dgvView.ResumeLayout();
            bsDSGV.ResumeBinding();
            bsMon.ResumeBinding();
            bsView.ResumeBinding();
        }
        private async void dgvMon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Rows[e.RowIndex].Cells["Col_TenMon"].Value.ToString() == "")
            {
                return;
            }
            byte loaiMon = Convert.IsDBNull(dgv.Rows[e.RowIndex].Cells["Col_Loai"].Value) ? Convert.ToByte(0) : Convert.ToByte(dgv.Rows[e.RowIndex].Cells["Col_Loai"].Value);
            if (Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value) == -1)
            {
                // add row here
                await monBAL.Them(new MonHoc(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value), dgv.Rows[e.RowIndex].Cells["Col_TenMon"].Value.ToString(), loaiMon));
                bsMon.DataSource = await monBAL.LayDT();
            }
            else
            {
                //Update here
                await monBAL.CapNhap(new MonHoc(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value), dgv.Rows[e.RowIndex].Cells["Col_TenMon"].Value.ToString(), loaiMon));
            }
        }

        private void frmPhanCong_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtTimMoi.Focus();

        }

        private void txtTimMoi_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên môn học")
            {
                if (txt.TextLength != 0)
                {
                    bsMon.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenMON] LIKE '%{0}%'", txt.Text);
                }
                else
                {
                    bsMon.RemoveFilter();
                }
            }
            else
            {
                bsMon.RemoveFilter();

            }
        }
        private void txtTimMoi_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == "")
            {
                txt.Text = "Nhập ID hoặc Tên môn học";
                txt.ForeColor = Color.Gray;
            }
        }

        private void txtTimMoi_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.ForeColor == Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }
        #endregion

        #region tabPhanCong
        int idGV = -1;
        int idMon = -1;
        int idLop = -1;
        int stt = -1;
        public async void loadDataPhanCong()
        {

            bsView.SuspendBinding();
            bsLop.SuspendBinding();
            bsDSGV.SuspendBinding();
            dgvDSGV.SuspendLayout();
            dgvDSLop.SuspendLayout();
            dgvView.SuspendLayout();

            bsLop.DataSource = await lopBAL.LayDT();
            bsDSGV.DataSource = await gvBAL.LayDT();
            bsView.DataSource = await pcBAL.LayDT();

            dgvView.ResumeLayout();
            dgvDSLop.ResumeLayout();
            dgvDSGV.ResumeLayout();
            bsDSGV.ResumeBinding();
            bsLop.ResumeBinding();
            bsView.ResumeBinding();
        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            {
                idGV = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                idMon = int.Parse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void dgvDSLop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["col_Day"].Value) == true)
            {
                idLop = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (idGV != -1 && idLop != -1)
                {
                    if ((await pcBAL.KiemTra(idLop, idMon)) > 0)
                    {
                        MessageBox.Show("Lớp Đã Có Người Dạy Môn Này !");
                    }
                    else
                    {
                        await pcBAL.Them(new PhanCong(stt, idGV, idLop, idMon));
                        bsView.DataSource = await pcBAL.LayDT();
                        MessageBox.Show("Thêm Thành Công !");
                        idGV = -1;
                        idMon = -1;
                        idLop = -1;
                    }
                }
            }
            catch (Exception) { MessageBox.Show("lỗi !"); }
        }

        private async void dgvView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    PhanCong pc = new PhanCong((e.Row.DataBoundItem as DataRowView).Row);
                    await pcBAL.Xoa(pc.STT);
                    bsView.DataSource = await pcBAL.LayDT();
                }
                else
                    e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Bạn không thể xóa được nhiều dòng !");
                e.Cancel = true;
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (idGV != -1 && idLop != -1)
                {
                    await pcBAL.CapNhap(new PhanCong(stt, idGV, idLop, -1));
                    MessageBox.Show("Cập Nhật Thành Công !");
                    btnXacNhan.Enabled = true;
                    btnSua.Enabled = false;
                    bsView.DataSource = await pcBAL.LayDT();
                }
                else
                {
                    MessageBox.Show("Bạn Vui Lòng Chọn Giáo Viên Và Lớp !");
                    dgvDSGV.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (MessageBox.Show("Bạn Có Muốn Sửa", "Notification !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                stt = int.Parse(dgvView.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnXacNhan.Enabled = false;
                btnSua.Enabled = true;
            }
        }

        private void txtTimKiemGV_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemGV.Text == "Nhập ID hoặc Tên GV")
            {
                txtTimKiemGV.Text = "";
                txtTimKiemGV.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemGV_Leave(object sender, EventArgs e)
        {
            if (txtTimLop.TextLength == 0)
            {
                txtTimLop.Text = "Nhập ID hoặc Tên GV";
                txtTimLop.ForeColor = Color.Gray;
            }
        }

        private void txtTimLop_Leave(object sender, EventArgs e)
        {
            if (txtTimLop.TextLength == 0)
            {
                txtTimLop.Text = "Nhập ID hoặc Tên Lớp";
                txtTimLop.ForeColor = Color.Gray;
            }
        }

        private void txtTimLop_Enter(object sender, EventArgs e)
        {
            if (txtTimLop.Text == "Nhập ID hoặc Tên Lớp")
            {
                txtTimLop.Text = "";
                txtTimLop.ForeColor = Color.Black;
            }
        }

        private void txtTimLop_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên Lớp")
            {
                if (txt.TextLength > 0)
                    bsLop.Filter = String.Format("CONVERT(ID,System.String)='{0}' OR [TenLop] LIKE '%{0}%'", txt.Text);
                else
                    bsLop.RemoveFilter();
            }
            else
                bsLop.RemoveFilter();
        }

        private void txtTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên GV")
            {
                if (txt.TextLength > 0)
                    bsDSGV.Filter = String.Format("CONVERT(IDTKT,System.String)='{0}' OR [TenGV] LIKE '%{0}%'", txt.Text);
                else
                    bsDSGV.RemoveFilter();
            }
            else
                bsDSGV.RemoveFilter();
        }

        #endregion

        #region tabGVCN



        
        GVCNBAL gvcn = new GVCNBAL();
        int idGVCN = -1;
        public async void LoadDataGVCN()
        {
            btnSuaGVCN.Enabled = false;
            bsGVCN.SuspendBinding();
            bsDSGVCN.SuspendBinding();
            dgvGVCN.SuspendLayout();
            dgvChonGVCN.SuspendLayout();
            bsGVCN.DataSource = await gvcn.LayDT();
            bsDSGVCN.DataSource = await gvBAL.LayDT();
            dgvChonGVCN.ResumeLayout();
            dgvGVCN.ResumeLayout();
            bsGVCN.ResumeBinding();
            bsDSGVCN.ResumeBinding();

            cboChonLop.DataSource = await lopBAL.LayDT();
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "ID";
        }
        private void txtTimGVCN_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên GV")
            {
                if (txt.TextLength > 0)
                    bsDSGVCN.Filter = String.Format("CONVERT(IDTKT,System.String)='{0}' OR [TenGV] LIKE '%{0}%'", txt.Text);
                else
                    bsDSGVCN.RemoveFilter();
            }
            else
                bsDSGVCN.RemoveFilter();
        }

        private void txtTimGVCN_Leave(object sender, EventArgs e)
        {
            if (txtTimGVCN.TextLength == 0)
            {
                txtTimGVCN.Text = "Nhập ID hoặc Tên GV";
                txtTimGVCN.ForeColor = Color.Gray;
            }
        }

        private void txtTimGVCN_Enter(object sender, EventArgs e)
        {
            if (txtTimGVCN.Text == "Nhập ID hoặc Tên GV")
            {
                txtTimGVCN.Text = "";
                txtTimGVCN.ForeColor = Color.Black;
            }
        }

        private void dgvChonGVCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            idGVCN = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private async void btnLuuGVCN_Click(object sender, EventArgs e)
        {
            try
            {
                if (idGVCN != -1)
                {
                    await gvcn.Them(new GVCN(idGVCN, int.Parse(cboChonLop.SelectedValue.ToString())));
                    MessageBox.Show("Thêm Thành Công !");
                    bsGVCN.DataSource = await gvcn.LayDT();
                    idGVCN = -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private async void btnSuaGVCN_Click(object sender, EventArgs e)
        {
            try
            {
                if (idGVCN != -1)
                {
                    await gvcn.CapNhap(new GVCN(idGVCN, int.Parse(cboChonLop.SelectedValue.ToString())));
                    MessageBox.Show("Cập Nhật Thành Công !");
                    bsDSGVCN.RemoveFilter();
                    bsGVCN.DataSource = await gvcn.LayDT();
                    btnLuuGVCN.Enabled = true;
                    btnSuaGVCN.Enabled = false;
                    idGVCN = -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private async void dgvGVCN_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    GVCN g = new GVCN((e.Row.DataBoundItem as DataRowView).Row);
                    await gvcn.Xoa(g);
                    bsGVCN.DataSource = await gvcn.LayDT();
                }
                else
                    e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Bạn không thể xóa được nhiều dòng !");
                e.Cancel = true;
            }
        }

        private void dgvGVCN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            MessageBox.Show("Vui Lòng Chọn Lại Lớp Giáo Viên Chủ Nhiệm");
            idGVCN = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            bsDSGVCN.Filter = String.Format("CONVERT(IDTKT,System.String)='{0}' ", idGVCN);
            btnSuaGVCN.Enabled = true;
            btnLuuGVCN.Enabled = false;
        }
        #endregion
    }
}
