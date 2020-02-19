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

            bsHS.DataSource = lsths;
            dgvDSHS.DataSource = bsHS.DataSource;
        }
    }
}
