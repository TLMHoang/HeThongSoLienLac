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
    public partial class frmChiTiet : Form
    {
        public int IDHS;
        public string TenH = "";
        DiemDanhBAL ddBAL = new DiemDanhBAL();
        public frmChiTiet()
        {
            InitializeComponent();
        }

        public async void frmChiTiet_Load(object sender, EventArgs e)
        {
            lblThongTin.Text = TenH;
            bsDiemDanh.SuspendBinding();
            dgvData.SuspendLayout();

            bsDiemDanh.DataSource = await ddBAL.LayID(IDHS);

            Phep.TrueValue = Convert.ToByte(1);
            Phep.FalseValue = Convert.ToByte(0);

            dgvData.ResumeLayout();
            bsDiemDanh.ResumeBinding();
        }

        private void frmChiTiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private async void dgvData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    await ddBAL.Xoa(Convert.ToInt32(dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["STT"].Value));
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa nhiều");
                e.Cancel = true;
            }
        }

        private async void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int y = dgvData.CurrentCell.RowIndex;
            await ddBAL.CapNhap(new DiemDanh(Convert.ToInt32(dgvData.Rows[y].Cells["STT"].Value), IDHS, Convert.ToDateTime(dgvData.Rows[y].Cells["NgayNghi"].Value), Convert.ToByte(dgvData.Rows[y].Cells["Phep"].Value)));
        }
    }
}