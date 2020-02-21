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
    public partial class frmDiemDanh : Form
    {
        ThongTinHSBAL hSBAL = new ThongTinHSBAL();
        public frmDiemDanh()
        {
            InitializeComponent();
        }

        private async void frmDiemDanh_Load(object sender, EventArgs e)
        {
            bsHocSinh.SuspendBinding();
            dgvDSHS.SuspendLayout();
            dgvDSHSC.SuspendLayout();
            
            foreach (Lop l in Program.lstLop)
            {
                cbxLop.Items.Add(l.TenLop);
                cbxLopC.Items.Add(l.TenLop);
            }

            if (Program.TK.Loai == 1)
            {
                
                bsHocSinh.DataSource = await hSBAL.LayDT();
                
            }
            else
            {
                cbxLop.Enabled = cbxLopC.Enabled = false;
                cbxLop.Text = cbxLopC.Text = Program.lstLop.FirstOrDefault(p => p.ID == Program.gV.IDLop).TenLop;
                bsHocSinh.DataSource = await hSBAL.LayDanhSach(Program.gV.IDLop);
                
            }

            dgvDSHS.ResumeLayout();
            dgvDSHSC.ResumeLayout();
            bsHocSinh.ResumeBinding();
        }

        private async void cbxLop_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx.SelectedIndex != 0)
            {
                bsHocSinh.DataSource = await hSBAL.LayDanhSach(Program.lstLop.FirstOrDefault(p => p.TenLop == cbx.Text).ID);
            }
            else
            {
                bsHocSinh.DataSource = await hSBAL.LayDT();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên học sinh")
            {
                if (txt.TextLength != 0)
                {
                    bsHocSinh.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [Ten] LIKE '%{0}%'", txt.Text); //CONVERT(ID, System.String)='{0}' OR [TenHang] LIKE '%{0}%'
                }
                else
                {
                    bsHocSinh.RemoveFilter();
                }
            }
            else
            {
                bsHocSinh.RemoveFilter();

            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.ForeColor == Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == "")
            {
                txt.Text = "Nhập ID hoặc Tên học sinh";
                txt.ForeColor = Color.Gray;
            }
        }
    }
}
