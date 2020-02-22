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
    public partial class frmAccountManager : Form
    {
        ThongTinGVBAL ttGV = new ThongTinGVBAL();
        TaiKhoanPHBAL tkPH = new TaiKhoanPHBAL();
        ThongTinHSBAL ttHS = new ThongTinHSBAL();
        int id = -1;
        string tenTK = "";
        public frmAccountManager()
        {
            InitializeComponent();
        }

        private void frmAccountManager_Load(object sender, EventArgs e)
        {
            LoadDGVDSHS();
            LoadDGVTKPH();
        }
        #region TabTaiKhoanPH
        public async void LoadDGVTKPH()
        {
            bsTKPH.SuspendBinding();
            dgvTKPH.SuspendLayout();
            dgvTKPH.DataSource =await tkPH.LayDT();
            dgvTKPH.ResumeLayout();
            bsTKPH.ResumeBinding();
        }
        public async void LoadDGVDSHS()
        {
            bsTTHS.SuspendBinding();
            dgvDSHS.SuspendLayout();
            dgvDSHS.DataSource = await ttHS.LayDT();
            dgvDSHS.ResumeLayout();
            bsTTHS.ResumeBinding();
        }
        private void dgvTKPH_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvTKPH.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }

        private async void dgvTKPH_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    TaiKhoanPH tk = new TaiKhoanPH((e.Row.DataBoundItem as DataRowView).Row);
                    await tkPH.Xoa(tk.ID);
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
        private async void dgvTKPH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
            try
            {
                if (drv == null)
                {
                    return;
                }
                TaiKhoanPH ph = new TaiKhoanPH(-1, drv.Row.ItemArray[1].ToString(), drv.Row.ItemArray[1].ToString());
                if (ph.ID == -1)
                {
                    await tkPH.Them(ph);
                    LoadDGVTKPH();
                    MessageBox.Show("Vui lòng chọn học sinh và nhấn lưu ;");
                    dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private async void btnThemTK_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell check = dgvDSHS.CurrentRow.Cells[0] as DataGridViewCheckBoxCell;
            if ((bool)check.Value == true)
            {
                //đợi proc
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Tài Khoản Học Sinh Liên Kết !");
            }

        }

        private void dgvTKPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTKPH.Rows[e.RowIndex];
            if (int.Parse(row.Cells[0].Value.ToString()) != -1)
            {
                id = int.Parse(row.Cells[0].Value.ToString());
                tenTK = row.Cells[1].Value.ToString();
            }
        }

        private async void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                {
                    await tkPH.CapNhap(new TaiKhoanPH(id, tenTK, tenTK));
                    LoadDGVTKPH();
                    id = -1;
                    tenTK = "";
                    MessageBox.Show("MK đã được đặt lại (Tên TK là MK)!");
                }
                else
                {
                    MessageBox.Show("Chưa Chọn Tài Khoản reset MK !");
                }
            }
            catch (Exception) { MessageBox.Show("Lỗi !"); }
        }
        #endregion

        #region TabTaiKhoanTruong
        #endregion



    }
}
