using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BAL;

namespace GUI
{
    public partial class frmNhapDiem : Form
    {
        DiemHeSoMotBAL d1 = new DiemHeSoMotBAL();
        DiemHeSoHaiBAL d2 = new DiemHeSoHaiBAL();
        DiemHocKyBAL d3 = new DiemHocKyBAL();
        ThongTinHSBAL tt = new ThongTinHSBAL();
       
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có thoát không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
                this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            loadhs();
            foreach (MonHoc m in Program.lstMonHoc)
            {
                cboMonHoc.Items.Add(m.TenMon);
            }
        }

        private async void loadhs()
        {
            
            bsHocSinh.SuspendBinding();
            dgvNhapDiem.SuspendLayout();
            foreach (Lop l in Program.lstLop)
            {
                cboLop.Items.Add(l.TenLop);
            }
            dgvNhapDiem.DataSource = await new ThongTinHSBAL().LayDT();
            bsHocSinh.ResumeBinding();
            dgvNhapDiem.ResumeLayout();
            
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

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.ForeColor == Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên học sinh")
            {
                if (txt.TextLength != 0)
                {
                    bsHocSinh.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [Ten] LIKE '%{0}%'", txt.Text); 
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

        private async void cboLop_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            if (cbo.SelectedIndex != 0)
            {
                bsHocSinh.DataSource = await tt.LayDanhSach(Program.lstLop.FirstOrDefault(p => p.TenLop == cbo.Text).ID);
            }
            else
            {
                bsHocSinh.DataSource = await tt.LayDT();
            }
        }

        private async void cboMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            if (cbo.SelectedIndex != 0)
            {
                bsHocSinh.DataSource = await tt.LayDanhSach(Program.lstMonHoc.FirstOrDefault(p => p.TenMon == cbo.Text).ID);
            }
            else
            {
                bsHocSinh.DataSource = await tt.LayDT();
            }
        }

        private void dgvNhapDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
            if (drv == null)
            {
                return;
            }
        }

        private void dgvNhapDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
        }

        private async void radDiemMieng_CheckedChanged(object sender, EventArgs e)
        {
            //if (radDiemMieng.Checked)
            //{
            //    await d1.CapNhap(new DiemHeSoMot(())
            //}
            //if (rad15p.Checked)
            //{
            //    await d1.CapNhap(new DiemHeSoMot)
            //}
            //if (rad1tiet.Checked)
            //{
            //    await d2.CapNhap(new DiemHeSoHai)
            //}
            //if (radHocKy.Checked)
            //{
            //    await d3.CapNhap(new DiemHocKy)
            //}
        }
    }
}
