using BAL;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Visible = false;
            if (f.ShowDialog() == DialogResult.Yes)
            {
                UserNameToolStripMenuItem.Text += "\n" + Program.TK.TaiKhoan;
                this.Visible = true;

                bsLop.SuspendBinding();
                dgvDanhSachLop.SuspendLayout();

                bsLop.DataSource = await new LopBAL().LayDT();

                dgvDanhSachLop.ResumeLayout();
                bsLop.ResumeBinding();
            }
            else
            {
                this.Close();
            }
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            frmHocSinh f = new frmHocSinh();
            f.ShowDialog();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            GUI.frmThongBao f = new GUI.frmThongBao();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát phần mềm ?", "Notification !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnThongBaoRiengHS_Click(object sender, EventArgs e)
        {
            GUI.frmThongBaoTungHocSinh f = new GUI.frmThongBaoTungHocSinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQuanLyGV_Click(object sender, EventArgs e)
        {
            frmTaiKhoanGiaoVien f = new frmTaiKhoanGiaoVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
