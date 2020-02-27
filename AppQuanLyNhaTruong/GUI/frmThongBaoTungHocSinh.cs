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
    public partial class frmThongBaoTungHocSinh : Form
    {
        ThongBaoHSBAL tb = new ThongBaoHSBAL();
        ThongTinHSBAL tt = new ThongTinHSBAL();
        int id = -1;
        int idTB = -1;
        public frmThongBaoTungHocSinh()
        {
            InitializeComponent();
        }
        private void frmThongBaoTungHocSinh_Load(object sender, EventArgs e)
        {
            LoadDGV();
            
        }
        private void txtTimKiemID_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemID.Text == "Nhập ID Hoặc Tên Để Tìm")
            {
                txtTimKiemID.Text = "";
                txtTimKiemID.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemID_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemID.TextLength == 0)
            {
                txtTimKiemID.Text = "Nhập ID Hoặc Tên Để Tìm";
                txtTimKiemID.ForeColor = Color.Gray;
            }
        }
        public async void LoadDGV()
        {
            bsHS.SuspendBinding();
            bsThongBao.SuspendBinding();
            dgvDSHS.SuspendLayout();
            dgvDSTB.SuspendLayout();

            bsHS.DataSource = await tt.LayDT();
            bsThongBao.DataSource = await tb.LayDT();

            dgvDSHS.ResumeLayout();
            dgvDSTB.ResumeLayout();
            bsHS.ResumeBinding();
            bsThongBao.ResumeBinding();

        }
        public void XoaRTB()
        {
            rtbNhapNoiDung.Clear();
            id = -1;
            idTB = -1;
        }
        private void txtTimKiemID_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID Hoặc Tên Để Tìm")
            {
                if (txtTimKiemID.TextLength > 0)
                    bsHS.Filter = String.Format("CONVERT(ID,System.String)='{0}' OR [Ten] LIKE '%{0}%'",txt.Text);
                else
                    bsHS.RemoveFilter();
            }
            else
                bsHS.RemoveFilter();
        }

        

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                {
                    if (idTB != -1)
                    {
                        if((await tb.CapNhap(new ThongBaoHS(idTB, id, rtbNhapNoiDung.Text))) != 0)
                        {
                            MessageBox.Show("Cập Nhật Thành Công ! ");
                            dgvDSTB.DataSource = await tb.LayDT();
                            bsHS.RemoveFilter();
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Thất Bại ! ");
                            dgvDSTB.DataSource = await tb.LayDT();
                            bsHS.RemoveFilter();
                            XoaRTB();
                        }                       
                    }
                    else
                    {
                        if((await tb.Them(new ThongBaoHS(-1, id, rtbNhapNoiDung.Text))) != 0)
                        {
                            MessageBox.Show("Thêm Thành Công !");
                            dgvDSTB.DataSource = await tb.LayDT();
                            bsThongBao.RemoveFilter();
                            XoaRTB();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại !");
                            dgvDSTB.DataSource = await tb.LayDT();
                            bsThongBao.RemoveFilter();
                            XoaRTB();
                        }                       
                    }
                }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn Học Sinh !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi !\n"+ex.Message);
            }
        }

        private void dgvDSTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSTB.Rows[e.RowIndex];
            if(row.Cells[0].Value.ToString() != "")
            {
                idTB = int.Parse(row.Cells[0].Value.ToString());
                id = int.Parse(row.Cells[1].Value.ToString());
                rtbNhapNoiDung.Text = row.Cells[2].Value.ToString();
                bsHS.Filter = String.Format("CONVERT(ID,System.String)='{0}'", id);
            }
        }
        private void dgvDSHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSHS.Rows[e.RowIndex];
            if (row.Cells[0].Value.ToString() != "")
                id = int.Parse(row.Cells[0].Value.ToString());
            bsThongBao.Filter = String.Format("CONVERT(IDHocSinh,System.String)='{0}'", id);
        }
        private async void dgvDSTB_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    if ((await tb.Xoa(idTB)) != 0)
                    {
                        XoaRTB();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại !");
                        XoaRTB();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !\n" + ex.Message);
                }              
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
