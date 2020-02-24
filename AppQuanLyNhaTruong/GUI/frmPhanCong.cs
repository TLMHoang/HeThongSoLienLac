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
            loadDataMonHoc();
            loadDataPhanCong();
        }
        #region tabPhanCong
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

        #region PhanCong
        int idGV = -1;
        int idMon = -1;
        int idLop = -1;
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


        #endregion

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            {
                idGV = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                idMon = int.Parse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void dgvDSLop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["col_Day"].Value) == true)
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
                        await pcBAL.Them(new PhanCong(-1, idGV, idLop, idMon));
                         bsView.DataSource = await pcBAL.LayDT();
                        MessageBox.Show("Thêm Thành Công !");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("lỗi !"); }
        }
    }
}
