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

        public frmPhanCong()
        {
            InitializeComponent();
        }

        private async void frmPhanCong_Load(object sender, EventArgs e)
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

        private void dgvMon_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }

        private async void dgvMon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
                if (dgv.Rows[e.RowIndex].Cells["Col_TenMon"].Value.ToString() == "")
                {
                    return;
                }
            if (Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value) == -1)
            {
                // add row here
                await monBAL.Them(new MonHoc(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value), dgv.Rows[e.RowIndex].Cells["Col_TenMon"].Value.ToString(), Convert.ToByte(dgv.Rows[e.RowIndex].Cells["Col_Loai"].Value)));
                bsMon.DataSource = await monBAL.LayDT();
            }
            else
            {
                //Update here
                await monBAL.CapNhap(new MonHoc(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value), dgv.Rows[e.RowIndex].Cells["Col_TenMon"].Value.ToString(), Convert.ToByte(dgv.Rows[e.RowIndex].Cells["Col_Loai"].Value)));
            }
        }
    }
}
