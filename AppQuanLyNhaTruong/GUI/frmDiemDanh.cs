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
        private ThongTinHSBAL hSBAL = new ThongTinHSBAL();
        private DiemDanhBAL ddBAL = new DiemDanhBAL();
        private CupHocBAL cupBAL = new CupHocBAL();
        private frmChiTiet f = new frmChiTiet();
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
                cbxLop.Text = cbxLopC.Text = Program.lstLop.FirstOrDefault(p => p.ID == Program.gvcn.IDLop).TenLop;
                bsHocSinh.DataSource = await hSBAL.LayDanhSach(Program.gvcn.IDLop);

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

        private void txtTimKiem_TextChanged(object sender, EventArgs e) //Tìm kiếm tab vắng học
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

        private async void txtFindC_TextChanged(object sender, EventArgs e) // Tìm kiếm tab Cup hoc
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên học sinh")
            {
                if (txt.TextLength != 0)
                {
                    bsHocSinh.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [Ten] LIKE '%{0}%'", txt.Text);
                    if (dgvDSHSC.RowCount > 0)
                    {
                        int y = dgvDSHSC.CurrentCell.RowIndex;
                        txtID.Text = dgvDSHSC.Rows[y].Cells["IDC"].Value.ToString();
                        txtTen.Text = dgvDSHSC.Rows[y].Cells["TenC"].Value.ToString();
                        if (cbxLopC.SelectedIndex == 0)
                        {
                            txtLop.Text = await Lop(int.Parse(txtID.Text));
                        }
                        else
                        {
                            txtLop.Text = dgvDSHSC.Rows[y].Cells["IDC"].Value.ToString();
                        }
                    }
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


        public Task<bool> CheckToDelete(DataGridView dgv, int ID)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (Convert.ToInt32(dgv.Rows[i].Cells[0].Value) == ID)
                {
                    dgv.Rows.RemoveAt(i);
                    return Task.FromResult(false);
                }
            }
            return Task.FromResult(true);
        }

        public Task<bool> CheckToAdd(DataGridView dgv, int ID)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (Convert.ToInt32(dr.Cells[0].Value) == ID)
                {
                    return Task.FromResult(false);
                }
            }
            return Task.FromResult(true);
        }

        private async Task<string> Lop(int IDHS)
        {
            ThongTinHS h = new ThongTinHS((await hSBAL.LayID(IDHS)).Rows[0]);
            return Program.lstLop.FirstOrDefault(p => p.ID == h.IDLop).TenLop;
        }

        private async void dgvDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e) // event click DataGridViewButtonColumn
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int ID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ID"].Value);
                if (dgv.Columns[e.ColumnIndex].Name.Equals("Vangp")) // button Phep here
                {
                    if (await CheckToDelete(dgvVangK, ID))
                    {
                        if (await CheckToAdd(dgvVangP, ID))
                        {
                            if (cbxLop.SelectedIndex == 0)
                            {
                                dgvVangP.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, await Lop(ID));
                            }
                            else
                            {
                                dgvVangP.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, cbxLop.Text);
                            }
                            await ddBAL.Them(new DiemDanh(-1, ID, DateTime.Today, 1));
                        }
                    }
                    else
                    {
                        if (cbxLop.SelectedIndex == 0)
                        {
                            dgvVangP.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, await Lop(ID));
                        }
                        else
                        {
                            dgvVangP.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, cbxLop.Text);
                        }
                        await ddBAL.CapNhap(new DiemDanh(await ddBAL.LaySTT(ID, DateTime.Today), ID, DateTime.Today, 1));

                    }


                }
                else if (dgv.Columns[e.ColumnIndex].Name.Equals("VangK")) //button Khong here
                {
                    if (await CheckToDelete(dgvVangP, ID))
                    {
                        if (await CheckToAdd(dgvVangK, ID))
                        {
                            if (cbxLop.SelectedIndex == 0)
                            {
                                dgvVangK.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, await Lop(ID));
                            }
                            else
                            {
                                dgvVangK.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, cbxLop.Text);
                            }
                            await ddBAL.Them(new DiemDanh(-1, ID, DateTime.Today, 0));
                        }
                    }
                    else
                    {
                        if (cbxLop.SelectedIndex == 0)
                        {
                            dgvVangK.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, await Lop(ID));
                        }
                        else
                        {
                            dgvVangK.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, cbxLop.Text);
                        }
                        await ddBAL.CapNhap(new DiemDanh(await ddBAL.LaySTT(ID, DateTime.Today), ID, DateTime.Today, 0));
                    }

                }
            }
        }

        private async void dgvVangP_CellContentClick(object sender, DataGridViewCellEventArgs e) // event click DataGridViewButtonColumn xóa
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                await ddBAL.Xoa(await ddBAL.LaySTT(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value), DateTime.Today));
                dgv.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiemDanh_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Font = new Font("Microsoft Sans Serif", (float)9.75);
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.Font = new Font("Microsoft Sans Serif", (float)14);
                this.Size = new Size(1024, 635);
                dgvDSHS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void numtTu_ValueChanged(object sender, EventArgs e)
        {
            numDen.Minimum = numTu.Value;
        }

        private async void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            bsCupHoc.SuspendBinding();
            dgvChiTiet.SuspendLayout();

            if (txtID.Text == "")
            {
                MessageBox.Show("Vui Lòng chọn học sinh");
            }
            else
            { 
            bsCupHoc.DataSource = await cupBAL.LayID(int.Parse(txtID.Text));
            }

            dgvChiTiet.ResumeLayout();
            bsCupHoc.ResumeBinding();
        }

        private async void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui Lòng chọn học sinh");
            }
            else
            {
                CupHoc c = new CupHoc(-1, int.Parse(txtID.Text), DateTime.Today, -1);
                for (int i = (int)numTu.Value; i <= (int)numDen.Value; i++)
                {
                    c.Tiet = i;
                    await cupBAL.Them(c);
                }
            }
        }

        private async void dgvDSHSC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = dgvDSHSC.CurrentCell.RowIndex;
            txtID.Text = dgvDSHSC.Rows[y].Cells["IDC"].Value.ToString();
            txtTen.Text = dgvDSHSC.Rows[y].Cells["TenC"].Value.ToString();
            if (cbxLopC.SelectedIndex == 0)
            {
                txtLop.Text = await Lop(int.Parse(txtID.Text));
            }
            else
            {
                txtLop.Text = dgvDSHSC.Rows[y].Cells["IDC"].Value.ToString();
            }
        }

        private async void dgvChiTiet_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    await cupBAL.Xoa(Convert.ToInt32(dgvChiTiet.Rows[dgvChiTiet.CurrentCell.RowIndex].Cells["STT"].Value));
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

        private async void btnChiTiet_Click(object sender, EventArgs e)
        {
            f.IDHS = Convert.ToInt32(dgvDSHS.Rows[dgvDSHS.CurrentCell.RowIndex].Cells["ID"].Value);
            if (cbxLop.SelectedIndex == 0)
            {
                f.TenH = dgvDSHS.Rows[dgvDSHS.CurrentCell.RowIndex].Cells["Ten"].Value.ToString() + " - Lớp " + (await Lop(f.IDHS));
            }
            else
            {
                f.TenH = dgvDSHS.Rows[dgvDSHS.CurrentCell.RowIndex].Cells["Ten"].Value.ToString() + " - Lớp " + cbxLop.Text;
            }
            f.frmChiTiet_Load(null, null);
            if (!f.Visible)
            {
                f.Visible = true;
            }
            f.Focus();
        }

        private async void dgvChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int y = dgvChiTiet.CurrentCell.RowIndex;
            if (await cupBAL.CapNhap(new CupHoc(Convert.ToInt32(dgvChiTiet.Rows[y].Cells["STT"].Value), int.Parse(txtID.Text), Convert.ToDateTime(dgvChiTiet.Rows[y].Cells["Ngay"].Value), Convert.ToInt32(dgvChiTiet.Rows[y].Cells["Tiet"].Value))) == 0)
            {
                btnXemChiTiet_Click(null, null);
            }
        }
    }
}
