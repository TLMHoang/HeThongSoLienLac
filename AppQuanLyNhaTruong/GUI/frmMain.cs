﻿using BAL;
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
    public partial class frmMain : Form
    {

        private LopBAL lopBAL = new LopBAL();
        private string OldName = "";
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
                menuToolStripMenuItem.Text += "\n" + Program.TK.TaiKhoan;
                this.Visible = true;

                await LoadValue();

                await LoadLogin();
                
            }
            else
            {
                this.FormClosing -= frmMain_FormClosing;
                this.Close();
            }
        }

        public async Task LoadLogin()
        {
            if (Program.TK.Loai == 0)
            {
                btnPCMonHoc.Enabled = false;
                btnAccountManagement.Enabled = false;
                dgvDanhSachLop.ReadOnly = true;
                Program.gV = new ThongTinGV((await new ThongTinGVBAL().LayID(Program.TK.ID)).Rows[0]);
                DataTable dt = await new GVCNBAL().LayDT(new GVCN(Program.TK.ID, -1));
                if (dt.Rows.Count > 0)
                {
                    Program.gvcn = new GVCN(dt.Rows[0]);
                }
                Program.lstLopQL = await new PhanCongBAL().LayLst(Program.TK.ID);

                if (Program.gvcn.IDLop == -1)
                {
                    btnThongBaoHS.Enabled = false;
                    btnThoiKhoaBieu.Enabled = false;
                    btnDiemDanh.Enabled = false;
                    btnStudentManagement.Enabled = false;

                }
            }
            else
            {
                dgvDanhSachLop.ReadOnly = false;
                btnStudentManagement.Enabled = true;
                btnThongBaoHS.Enabled = true;
                btnThoiKhoaBieu.Enabled = true;
                btnDiemDanh.Enabled = true;
                btnPCMonHoc.Enabled = true;
                btnAccountManagement.Enabled = true;
            }
        }


        public async Task LoadValue()
        {
            bsLop.SuspendBinding();
            dgvDanhSachLop.SuspendLayout();

            bsLop.DataSource = await lopBAL.LayDT();

            dgvDanhSachLop.ResumeLayout();
            bsLop.ResumeBinding();

            Program.lstLop = await lopBAL.LayLst();
            Program.lstMonHoc = await new MonHocBAL().LayLst();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            frmHocSinh f = new frmHocSinh(Program.TK, Program.gV);
            this.Hide();
            f.ShowDialog();
            this.Show();
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

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            frmAccountManager f = new frmAccountManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dgvDanhSachLop_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvDanhSachLop.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }

        private async void dgvDanhSachLop_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Lop l = new Lop((e.Row.DataBoundItem as DataRowView).Row);
                    await lopBAL.Xoa(l);
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

        private async void dgvDanhSachLop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
                if (drv == null)
                {
                    return;
                }
                Lop l = new Lop(Convert.ToInt32(drv.Row.ItemArray[0]), drv.Row.ItemArray[1].ToString());
                if (l.ID == -1)
                {
                    await lopBAL.Them(l);
                    bsLop.DataSource = await lopBAL.LayDT();
                    dgvDanhSachLop.CurrentCell = dgvDanhSachLop.Rows[dgvDanhSachLop.RowCount - 1].Cells[1];
                }
                else
                {
                    if (OldName != l.TenLop)
                    {
                        await lopBAL.CapNhap(OldName, l);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvDanhSachLop_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvDanhSachLop.Rows[dgvDanhSachLop.CurrentCell.RowIndex].Cells[1].Value.ToString() != "")
            {
                OldName = dgvDanhSachLop.Rows[dgvDanhSachLop.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            this.Hide();

            f.ShowDialog();

            this.Show();
        }

        private async void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Hide();

            if (f.ShowDialog() == DialogResult.No)
            {
                this.FormClosing -= frmMain_FormClosing;
                this.Close();
            }
            else
            {
                menuToolStripMenuItem.Text += "\n" + Program.TK.TaiKhoan;
                this.Visible = true;

                await LoadValue();

                await LoadLogin();
            }
            this.Show();
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            frmDiemDanh f = new frmDiemDanh();
            this.Hide();

            f.ShowDialog();

            this.Show();
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            frmThoiKhoaBieu f = new frmThoiKhoaBieu();
            this.Hide();

            f.ShowDialog();

            this.Show();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmNhapDiem f = new frmNhapDiem();
            this.Hide();

            f.ShowDialog();

            this.Show();
        }

        private void btnThongBaoChung_Click(object sender, EventArgs e)
        {
            frmThongBaoTungHocSinh f = new frmThongBaoTungHocSinh();
            this.Hide();

            f.ShowDialog();

            this.Show();
        }

        private void btnPCMonHoc_Click(object sender, EventArgs e)
        {
            frmPhanCong f = new frmPhanCong();
            this.Hide();

            f.ShowDialog();

            this.Show();
        }

        private void txtLopHoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
