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

namespace AppQuanLyNhaTruong
{
    public partial class frmTaiKhoanGiaoVien : Form
    {
        public frmTaiKhoanGiaoVien()
        {
            InitializeComponent();
        }
        private void frmTaiKhoanGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadCBOMonHoc();
            LoadCBOLopHoc();
        }
        public async void LoadDGV()
        {
            bsDSGV.SuspendBinding();
            dgvDSGV.SuspendLayout();
            dgvDSGV.DataSource = await new ThongTinGVBAL().LayDT();
            dgvDSGV.ResumeLayout();
            bsDSGV.ResumeBinding();
        }
        public async void ThemTK()
        {
            int IDTKT = int.Parse(txtNhapID.Text);
            string Ten = txtNhapTenGV.Text;
            string SDT = txtSDT.Text;
            int IDMon = int.Parse(cboMonHoc.SelectedValue.ToString());
            int IDLop = int.Parse(cboLopPhuTrach.SelectedValue.ToString());
            byte GVCN = chkGVCN.Checked ? (byte)1 : (byte)0;
            await new ThongTinGVBAL().ThemThongTin(IDTKT, Ten, SDT, IDMon, IDLop, GVCN);
        }
        public async void CapNhatTK()
        {
            int IDTKT = int.Parse(txtNhapID.Text);
            string Ten = txtNhapTenGV.Text;
            string SDT = txtSDT.Text;
            int IDMon = int.Parse(cboMonHoc.SelectedValue.ToString());
            int IDLop = int.Parse(cboLopPhuTrach.SelectedValue.ToString());
            byte GVCN = chkGVCN.Checked ? (byte)1 : (byte)0;
            await new ThongTinGVBAL().SuaThongTin(IDTKT, Ten, SDT, IDMon, IDLop, GVCN);
        }
        public async void XoaTK()
        {
            int IDTKT = int.Parse(txtNhapID.Text);
            await new ThongTinGVBAL().Xoa(IDTKT);
        }
        public async void LoadCBOMonHoc()
        {
            cboMonHoc.DataSource = await new MonHocBAL().LayDT();
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "ID";
        }
        public async void LoadCBOLopHoc()
        {
            cboLopPhuTrach.DataSource = await new LopBAL().LayDT();
            cboLopPhuTrach.DisplayMember = "TenLop";
            cboLopPhuTrach.ValueMember = "ID";
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if(await new ThongTinGVBAL().KiemTraID(int.Parse(txtNhapID.Text))==null)
                try {
                        ThemTK();
                        MessageBox.Show("Thêm Thành Công !");
                    } catch (Exception) { MessageBox.Show("Lỗi !"); }
            else
            {
                MessageBox.Show("TK Đã Tồn Tại");
            }
        }
    }
}
