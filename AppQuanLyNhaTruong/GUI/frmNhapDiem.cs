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

        MonHoc mh = new MonHoc();
        DiemHeSoMot dhm = new DiemHeSoMot();
        DiemHeSoHai dhh = new DiemHeSoHai();
        DiemHocKy dhk = new DiemHocKy();

        int LoaiDiem = 1;
       
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private async void frmNhapDiem_Load(object sender, EventArgs e)
        {
            bsHocSinh.SuspendBinding();
            dgvDanhSachHS.SuspendLayout();

            //load cbxLop, Mon là admin
            if (Program.TK.Loai == 1)
            {

                bsHocSinh.DataSource = await tt.LayDT();
                foreach (Lop l in Program.lstLop)
                {
                    cbxLop.Items.Add(l.TenLop);
                }
                foreach (MonHoc mh in Program.lstMonHoc)
                {
                    cbxMon.Items.Add(mh.TenMon);
                }
            }
            else
            {
                //load cbxLop, Mon là GV
                foreach (PhanCong pc in await new PhanCongBAL().LayLst(Program.TK.ID))
                {
                    cbxLop.Items.Add(Program.lstLop.FirstOrDefault(p => p.ID == pc.IDLop).TenLop);
                }
                cbxMon.Enabled = false;
                cbxMon_SelectedIndexChanged(null, null);
                cbxMon.Text = Program.lstMonHoc.FirstOrDefault(p => p.ID == Program.gV.IDMonHoc).TenMon;
            }

            dgvDanhSachHS.ResumeLayout();
            bsHocSinh.ResumeBinding();
            //load diểm khi có ds hs
            if (dgvDanhSachHS.Rows.Count != 0)
            {
                await LoadDiemHS(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value));
            }
        }

        private async Task LoadDiemHS(int IDHS)
        {
            bsDiemHeSoMot.SuspendBinding();
            bsDiemHeSoHai.SuspendBinding();
            bsDiemHocKy.SuspendBinding();
            dgvDiemHeSoMot.SuspendLayout();
            dgvDiemHeSoHai.SuspendLayout();
            dgvDiemHocKy.SuspendLayout();

            try
            {
                if (cbxLop.SelectedIndex <= 0)
                {
                    string ClassName = await GetClassName(IDHS);
                    bsDiemHeSoMot.DataSource = await d1.LayID(ClassName, IDHS);
                    bsDiemHeSoHai.DataSource = await d2.LayID(ClassName, IDHS);
                    bsDiemHocKy.DataSource = await d3.LayID(ClassName, IDHS);
                }
                else
                {
                    bsDiemHeSoMot.DataSource = await d1.LayID(cbxLop.Text, IDHS);
                    bsDiemHeSoHai.DataSource = await d2.LayID(cbxLop.Text, IDHS);
                    bsDiemHocKy.DataSource = await d3.LayID(cbxLop.Text, IDHS);
                }

                IDMon1.DataSource = Program.lstMonHoc;
                IDMon1.DisplayMember = "TenMon";
                IDMon1.ValueMember = "ID";

                IDMon2.DataSource = Program.lstMonHoc;
                IDMon2.DisplayMember = "TenMon";
                IDMon2.ValueMember = "ID";

                IDMonHK.DataSource = Program.lstMonHoc;
                IDMonHK.DisplayMember = "TenMon";
                IDMonHK.ValueMember = "ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            bsDiemHeSoMot.ResumeBinding();
            bsDiemHeSoHai.ResumeBinding();
            bsDiemHocKy.ResumeBinding();
            dgvDiemHeSoMot.ResumeLayout();
            dgvDiemHeSoHai.ResumeLayout();
            dgvDiemHocKy.ResumeLayout();
            
        }

        public async Task<string> GetClassName(int IDHS)
        {
            DataRow dr = (await tt.LayID(IDHS)).Rows[0];
            int IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            return Program.lstLop.FirstOrDefault(p => p.ID == IDLop).TenLop;
        }

        private async void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx.SelectedIndex != 0)
            {
                bsHocSinh.DataSource = await tt.LayDanhSach(Program.lstLop.FirstOrDefault(p => p.TenLop == cbx.Text).ID);
                if (dgvDanhSachHS.Rows.Count != 0)
                {
                    await LoadDiemHS(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value));
                }
            }
            else
            {
                bsHocSinh.DataSource = await tt.LayDT();
                if (dgvDanhSachHS.Rows.Count != 0)
                {
                    await LoadDiemHS(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value));
                }
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

        private void radDiemMieng_CheckedChanged(object sender, EventArgs e)
        {
            if (radDiem15.Checked)
            {
                dhm.DiemMieng = 0;
                LoaiDiem = 1;
                return;
            }
            if (radDiemMieng.Checked)
            {
                dhm.DiemMieng = 1;
                LoaiDiem = 1;
                return;
            }
            if (radDiemHK.Checked)
            {
                LoaiDiem = 3;
                return;
            }
            if (radDiemMT.Checked)
            {
                LoaiDiem = 2;
                return;
            }
        }

        private void cbxMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMon.SelectedIndex <= 0)
            {
                chbxDat.Enabled = false;
                numDiem.Enabled = false;
                btnLuu.Enabled = false;
                return;
            }
            mh = Program.lstMonHoc.FirstOrDefault(p => p.TenMon == cbxMon.Text);
            if (mh.LoaiDiem == 1)
            {
                chbxDat.Enabled = false;
                numDiem.Enabled = true;
                btnLuu.Enabled = true;
                numDiem.Value = (decimal)0.0;
                dhm.Diem = dhh.Diem = dhk.Diem = (float)0.0;
                dhm.Loai = dhh.Loai = dhk.Loai = 0;
            }
            else
            {
                chbxDat.Enabled = true;
                numDiem.Enabled = false;
                btnLuu.Enabled = true;
                dhm.Diem = dhh.Diem = dhk.Diem = -1;
                dhm.Loai = dhh.Loai = dhk.Loai = Convert.ToByte(chbxDat.Checked);
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!numDiem.Enabled && !chbxDat.Enabled)
                {
                    MessageBox.Show("Chưa chọn môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dhm.IDHocSinh == -1 || dhh.IDHocSinh == -1 || dhk.IDHocSinh == -1)
                {
                    MessageBox.Show("Chưa chọn học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int IDHS = Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value);
                string ClassName = cbxLop.Text;
                if (cbxLop.SelectedIndex <= 0)
                {
                    ClassName = await GetClassName(IDHS);
                }
                switch (LoaiDiem)
                {
                    case 2:
                        dhh.IDMon = mh.ID;
                        await d2.Them(ClassName, dhh);
                        break;
                    case 3:
                        dhk.IDMon = mh.ID;
                        await d3.Them(ClassName, dhk);
                        break;
                    default:
                        dhm.IDMon = mh.ID;
                        await d1.Them(ClassName, dhm);
                        break;
                }

                await LoadDiemHS(IDHS);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void numDiem_ValueChanged(object sender, EventArgs e)
        {
            dhm.Diem = dhh.Diem = dhk.Diem = (float)numDiem.Value;
        }

        private void chbxDat_CheckedChanged(object sender, EventArgs e)
        {
            dhm.Loai = dhh.Loai = dhk.Loai = Convert.ToByte(chbxDat.Checked);
        }

        private async void dgvDanhSachHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dhm.IDHocSinh = dhh.IDHocSinh = dhk.IDHocSinh = Convert.ToInt32(dgvDanhSachHS.Rows[e.RowIndex].Cells["ID"].Value);
                await LoadDiemHS(dhm.IDHocSinh);
            }
        }

        private void radHK2_CheckedChanged(object sender, EventArgs e)
        {
            if (radHK1.Checked)
            {
                dhm.HocKy = dhh.HocKy = dhk.HocKy = 0;
                return;
            }
            if (radHK2.Checked)
            {
                dhm.HocKy = dhh.HocKy = dhk.HocKy = 1;
                return;
            }
        }

        private void dgvDiemHeSoMot_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvDiemHeSoMot.Columns[e.ColumnIndex].Name.Equals("Diem1"))
            {
                if (Convert.ToInt32(dgvDiemHeSoMot.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == -1)
                {
                    MessageBox.Show("Môn này không thuộc loại hê số 10.\nNó thuộc loại Đạt hoặc Không Đạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (dgvDiemHeSoMot.Columns[e.ColumnIndex].Name.Equals("Loai1"))
            {
                if (Convert.ToInt32(dgvDiemHeSoMot.Rows[e.RowIndex].Cells["Diem1"].Value) != -1)
                {
                    MessageBox.Show("Môn này không thuộc loại Đạt hoặc Không Đạt.\nNó thuộc loại hê số 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void dgvDiemHeSoHai_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvDiemHeSoHai.Columns[e.ColumnIndex].Name.Equals("Diem2"))
            {
                if (Convert.ToInt32(dgvDiemHeSoHai.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == -1)
                {
                    MessageBox.Show("Môn này không thuộc loại hê số 10.\nNó thuộc loại Đạt hoặc Không Đạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (dgvDiemHeSoHai.Columns[e.ColumnIndex].Name.Equals("Loai2"))
            {
                if (Convert.ToInt32(dgvDiemHeSoHai.Rows[e.RowIndex].Cells["Diem2"].Value) != -1)
                {
                    MessageBox.Show("Môn này không thuộc loại Đạt hoặc Không Đạt.\nNó thuộc loại hê số 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void dgvDiemHocKy_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvDiemHocKy.Columns[e.ColumnIndex].Name.Equals("Diem3"))
            {
                if (Convert.ToInt32(dgvDiemHocKy.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == -1)
                {
                    MessageBox.Show("Môn này không thuộc loại hê số 10.\nNó thuộc loại Đạt hoặc Không Đạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (dgvDiemHocKy.Columns[e.ColumnIndex].Name.Equals("LoaiHK"))
            {
                if (Convert.ToInt32(dgvDiemHocKy.Rows[e.RowIndex].Cells["DiemHK"].Value) != -1)
                {
                    MessageBox.Show("Môn này không thuộc loại Đạt hoặc Không Đạt.\nNó thuộc loại hê số 10.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private async void dgvDiemHeSoMot_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbxLop.SelectedIndex == 0)
                {
                    await d1.Xoa(await GetClassName(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value)), Convert.ToInt32(dgvDiemHeSoMot.Rows[dgvDiemHeSoMot.CurrentCell.RowIndex].Cells["STT1"].Value));
                }
                else
                {
                    await d1.Xoa(cbxLop.Text, Convert.ToInt32(dgvDiemHeSoMot.Rows[dgvDiemHeSoMot.CurrentCell.RowIndex].Cells["STT1"].Value));
                }
                
            }
        }

        private async void dgvDiemHeSoHai_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbxLop.SelectedIndex == 0)
                {
                    await d2.Xoa(await GetClassName(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value)), Convert.ToInt32(dgvDiemHeSoHai.Rows[dgvDiemHeSoHai.CurrentCell.RowIndex].Cells["STT2"].Value));
                }
                else
                {
                    await d2.Xoa(cbxLop.Text, Convert.ToInt32(dgvDiemHeSoHai.Rows[dgvDiemHeSoHai.CurrentCell.RowIndex].Cells["STT2"].Value));
                }

            }
        }

        private async void dgvDiemHocKy_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbxLop.SelectedIndex == 0)
                {
                    await d3.Xoa(await GetClassName(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value)), Convert.ToInt32(dgvDiemHocKy.Rows[dgvDiemHocKy.CurrentCell.RowIndex].Cells["STTHK"].Value));
                }
                else
                {
                    await d3.Xoa(cbxLop.Text, Convert.ToInt32(dgvDiemHocKy.Rows[dgvDiemHocKy.CurrentCell.RowIndex].Cells["STTHK"].Value));
                }

            }
        }

        private async void dgvDiemHeSoMot_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView drv = dgvDiemHeSoMot.Rows[dgvDiemHeSoMot.CurrentCell.RowIndex].DataBoundItem as DataRowView;

                if (cbxLop.SelectedIndex == 0)
                {
                    await d1.CapNhap(await GetClassName(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDiemHeSoMot.CurrentCell.RowIndex].Cells["ID"].Value)), new DiemHeSoMot(drv.Row));
                }
                else
                {
                    await d1.CapNhap(cbxLop.Text, new DiemHeSoMot(drv.Row));
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvDiemHeSoHai_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView drv = dgvDiemHeSoHai.Rows[dgvDiemHeSoHai.CurrentCell.RowIndex].DataBoundItem as DataRowView;

                if (cbxLop.SelectedIndex == 0)
                {
                    await d2.CapNhap(await GetClassName(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value)), new DiemHeSoHai(drv.Row));
                }
                else
                {
                    await d2.CapNhap(cbxLop.Text, new DiemHeSoHai(drv.Row));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvDiemHocKy_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView drv = dgvDiemHocKy.Rows[dgvDiemHocKy.CurrentCell.RowIndex].DataBoundItem as DataRowView;

                if (cbxLop.SelectedIndex == 0)
                {
                    await d3.CapNhap(await GetClassName(Convert.ToInt32(dgvDanhSachHS.Rows[dgvDanhSachHS.CurrentCell.RowIndex].Cells["ID"].Value)), new DiemHocKy(drv.Row));
                }
                else
                {
                    await d3.CapNhap(cbxLop.Text, new DiemHocKy(drv.Row));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
