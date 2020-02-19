using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace GUI
{
    public partial class uctTimTiemHS : UserControl
    {
        class DanhSachHocSinh
        {
            public int ID { get; set; }
            public string TenHS { get; set; }
            public DateTime NgaySinh { get; set; }
            public string Lop { get; set; }

            public DanhSachHocSinh() { }

            public DanhSachHocSinh(int iD, string tenHS, DateTime ngaySinh, string lop)
            {
                ID = iD;
                TenHS = tenHS;
                NgaySinh = ngaySinh;
                Lop = lop;
            }

        }
        private BindingSource bsHS = new BindingSource();
        public int IDHS;

        public uctTimTiemHS()
        {
            InitializeComponent();
        }

        private async void uctTimTiemHS_Load(object sender, EventArgs e)
        {
            List<DanhSachHocSinh> lsths = new List<DanhSachHocSinh>();
            List<ThongTinHS> lstTTHS = await new ThongTinHSBAL().LayLst();

            foreach (ThongTinHS i in lstTTHS)
            {
                lsths.Add(new DanhSachHocSinh(i.ID, i.Ten, i.NgaySinh, Program.lstLop.FirstOrDefault(p => p.ID == i.IDLop).TenLop));
            }

            foreach (Lop i in Program.lstLop)
            {
                cbxLop.Items.Add(i.TenLop);
            }

            bsHS.SuspendBinding();
            dgvDSHS.SuspendLayout();

            bsHS.DataSource = lsths;
            dgvDSHS.DataSource = bsHS.DataSource;

            dgvDSHS.ResumeLayout();
            bsHS.ResumeBinding();
        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLop.Text == "")
            {
                bsHS.RemoveFilter();
            }
            else
            {
            bsHS.Filter = String.Format("[Lop] LIKE '%{0}%'", cbxLop.Text);
            }
        }

        public void dgvDSHS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDHS = Convert.ToInt32(dgvDSHS.Rows[dgvDSHS.CurrentCell.RowIndex].Cells["ID"].Value);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
            {
                bsHS.RemoveFilter();
            }
            else
            {
                bsHS.Filter = String.Format("CCONVERT([ID], System.String)='{0}' OR [TenHS] LIKE '%{0}%'", txtTimKiem.Text);
            }
        }
    }
}
