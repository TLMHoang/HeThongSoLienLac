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
        DiemHeSoHaiBAL d2 = new DiemHeSoHaiBAL();
        DiemHeSoMotBAL d1 = new DiemHeSoMotBAL();
        DiemHocKyBAL dhk = new DiemHocKyBAL();
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
        }

        private async void loadhs()
        {
            bsHocSinh.SuspendBinding();
            dgvNhapDiem.SuspendLayout();
            foreach (Lop l in Program.lstLop)
            {
                cboLop.Items.Add(l.ID + "-" + l.TenLop);
            }
            dgvNhapDiem.DataSource = await new ThongTinHSBAL().LayDT();
            bsHocSinh.ResumeBinding();
            dgvNhapDiem.ResumeLayout();
        }
    }
}
