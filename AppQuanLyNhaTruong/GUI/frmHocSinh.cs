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
using DTO;


namespace GUI
{
    public partial class frmHocSinh : Form
    {
       ThongTinHSBAL tt = new ThongTinHSBAL();
        ThongTinHS tTHS = new ThongTinHS();
        int IDLopChuNhiem = -1;

        public frmHocSinh()
        {
            InitializeComponent();
        }

        public frmHocSinh(TaiKhoanTruong tK, GVCN gV)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (tK.Loai == 1)
            {
                lblNameFrom.Text += "toàn trường";
            }
            else
            {
                lblNameFrom.Text += "lớp " + Program.lstLop.FirstOrDefault(p => p.ID == gV.IDLop).TenLop;
                cbxLop.Enabled = false;
            }

            IDLopChuNhiem = gV.IDLop; 
        }

        private void frmHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Task<int> CheckNullText(DataRowView drv)
        {
            int dem = 0;
            foreach (var i in drv.Row.ItemArray)
            {
                if (i.ToString().Equals(""))
                {
                    dem++;
                }
            }
            return Task.FromResult(dem);
        }

        private int CheckTTHS(params ThongTinHS[] obj)
        {
            int dem = 0;
            if (obj[0].ID != obj[1].ID)
            {
                dem++;
            }
            if (obj[0].Ten != obj[1].Ten)
            {
                dem++;
            }
            if (obj[0].IDLop != obj[1].IDLop)
            {
                dem++;
            }
            if (obj[0].NgaySinh != obj[1].NgaySinh)
            {
                dem++;
            }
            if (obj[0].NoiSinh != obj[1].NoiSinh)
            {
                dem++;
            }
            if (obj[0].SDTBo != obj[1].SDTBo)
            {
                dem++;
            }
            if (obj[0].SDTMe != obj[1].SDTMe)
            {
                dem++;
            }
            if (obj[0].TenBo != obj[1].TenBo)
            {
                dem++;
            }
            if (obj[0].TenMe != obj[1].TenMe)
            {
                dem++;
            }
            if (obj[0].TonGiao != obj[1].TonGiao)
            {
                dem++;
            }
            if (obj[0].DanToc != obj[1].DanToc)
            {
                dem++;
            }
            if (obj[0].GioiTinh != obj[1].GioiTinh)
            {
                dem++;
            }
            return dem;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                DataRowView drv = dgvHocSinh.Rows[dgvHocSinh.CurrentCell.RowIndex].DataBoundItem as DataRowView;
                tTHS.ID = int.Parse(txtID.Text);
                dgvHocSinh.Focus();
                if (dgvHocSinh.CurrentCell.RowIndex == dgvHocSinh.RowCount - 2 && dgvHocSinh.Rows[dgvHocSinh.CurrentCell.RowIndex].Cells["ID"].Value.ToString().Equals(""))
                {
                    if (await CheckNullText(drv) > 0)
                    {
                        if (MessageBox.Show("Bạn có dữ liêu nhập chưa xong hoặc chưa lưu.\nBạn có muốn tiếp tục tạo mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            dgvHocSinh.Rows.RemoveAt(dgvHocSinh.CurrentCell.RowIndex);
                            await ReNew();
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    await ReNew();
                }
                else
                {
                    if (await CheckNullText(drv) > 0)
                    {
                        await ReNew();
                    }
                    else
                    {
                        
                        if (CheckTTHS(tTHS, new ThongTinHS(drv.Row)) > 0)
                        {
                            if (MessageBox.Show("Bạn có thay đổi cột nhưng chưa lưu.\nYes để lưu và tạo mới.\nNo để tạo mới Không lưu.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                await tt.CapNhap(tTHS);
                                await ReNew();
                            }
                        }
                        else
                        {
                            await ReNew();
                        }
                    }
                }
            }
            else
            {
                await ReNew();
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (tTHS.ID == -1)
            {
                dgvHocSinh.Rows.RemoveAt(dgvHocSinh.CurrentCell.RowIndex);
                return;
            }
            string strTTHS = tTHS.Ten + " - Lớp " + Program.lstLop.FirstOrDefault(p => p.ID == tTHS.IDLop).TenLop;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa " +  strTTHS + " Không?", "Hỏi xóa !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (await tt.Xoa(int.Parse(txtID.Text)) == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        bsThongTinHS.DataSource = await tt.LayDT();
                        dgvHocSinh.Invalidate();
                        dgvHocSinh_CellClick(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !\n" + ex.Message);
                }
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            txtID.Focus();
            dgvHocSinh.Focus();
            DataRowView drv = dgvHocSinh.Rows[dgvHocSinh.CurrentCell.RowIndex].DataBoundItem as DataRowView;
            if (drv == null)
            {
                return;
            }
            if (await CheckNullText(drv) > 0)
            {
                MessageBox.Show("Nhập đầy đủ thông tin học sinh mới có thể lưu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ThongTinHS hs = new ThongTinHS(drv.Row);
            if (hs.ID == -1)
            {
                // add here
                await tt.Them(hs);
            }
            else
            {
                // update here
                await tt.CapNhap(hs);
            }

            bsThongTinHS.DataSource = await tt.LayDT();
            dgvHocSinh.Invalidate();
        }

        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            await loadHS();
        }
        private async Task ReNew()
        {
            dgvHocSinh.CurrentCell = dgvHocSinh.Rows[dgvHocSinh.RowCount - 1].Cells["ID"];
            bsThongTinHS.AddNew();
            txtID.Text = "-1";
            tTHS = new ThongTinHS();
            dgvHocSinh.Rows[dgvHocSinh.CurrentCell.RowIndex].Cells["ID"].Value = -1;
            if (IDLopChuNhiem != -1)
            {
                dgvHocSinh.Rows[dgvHocSinh.CurrentCell.RowIndex].Cells["IDLop"].Value = IDLopChuNhiem;
            }
            if (dgvHocSinh.RowCount != 3)
            {
                for (int i = dgvHocSinh.RowCount - 2; i >= dgvHocSinh.RowCount - 3; i--)
                {
                    DataRowView drv = dgvHocSinh.Rows[i].DataBoundItem as DataRowView;
                    if (drv == null)
                    {
                        dgvHocSinh.Rows.RemoveAt(i);
                        i--;
                    }
                    else if (await CheckNullText(drv) == 12)
                    {
                        dgvHocSinh.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            txtTen.Focus();
        }

        
        private async void frmHocSinh_Load(object sender, EventArgs e)
        {
            await loadHS();
        }

        private async Task loadHS()
        {
            if (IDLopChuNhiem == -1)
            {
                cbxLop.DataSource = Program.lstLop;
                cbxLop.DisplayMember = "TenLop";
                cbxLop.ValueMember = "ID";

                bsThongTinHS.SuspendBinding();
                dgvHocSinh.SuspendLayout();

                bsThongTinHS.DataSource = await tt.LayDT();

                IDLop.DataSource = Program.lstLop;
                IDLop.DisplayMember = "TenLop";
                IDLop.ValueMember = "ID";

                dgvHocSinh.ResumeLayout();
                bsThongTinHS.ResumeBinding();

                dgvHocSinh_CellClick(null, null);
            }
            else
            {
                //cbxLop.DataSource = Program.lstLop;
                //cbxLop.DisplayMember = "TenLop";
                //cbxLop.ValueMember = "ID";
                //cbxLop.Enabled = false;

                bsThongTinHS.SuspendBinding();
                dgvHocSinh.SuspendLayout();

                bsThongTinHS.DataSource = await tt.LayDanhSach(IDLopChuNhiem);


                cbxLop.Text = Program.lstLop.FirstOrDefault(p => p.ID == IDLopChuNhiem).TenLop;
                IDLop.DataSource = Program.lstLop;
                IDLop.DisplayMember = "TenLop";
                IDLop.ValueMember = "ID";

                dgvHocSinh.ResumeLayout();
                bsThongTinHS.ResumeBinding();

                dgvHocSinh_CellClick(null, null);
            }
        }

        private void frmHocSinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    //Event save
                    btnLuu_Click(null, null);
                    return;
                }
                if (e.KeyCode == Keys.N)
                {
                    //event new
                    btnThem_Click(null, null);
                    return;
                }
                if (e.KeyCode == Keys.Delete)
                {
                    //event delete
                    btnXoa_Click(null, null);
                    return;
                }
                if (e.KeyCode == Keys.F)
                {
                    //event Find
                    MessageBox.Show(e.KeyCode.ToString());
                    return;
                }
            }
        }

        private void txtSDTMe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back) 
            {
                e.Handled = !char.IsDigit(e.KeyChar);//  Cancel key not number
            }
        }

        private async void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvHocSinh.CurrentCell == null)
            {
                return;
            }
            if (dgvHocSinh.CurrentCell.RowIndex == -1)
            {
                return;
            }
            DataRowView drv = dgvHocSinh.Rows[dgvHocSinh.CurrentCell.RowIndex].DataBoundItem as DataRowView;
            if (drv == null)
            {
                tTHS = new ThongTinHS();
                return;
            }
            else
            {
                if (await CheckNullText(drv) > 0)
                {
                    tTHS = new ThongTinHS();
                    return;
                }
            }
            if (Convert.ToInt32(drv.Row["ID"]) != -1 && !drv.Row["ID"].ToString().Equals(""))
            {
                tTHS = new ThongTinHS(drv.Row);
            }
        }

        private async void dgvHocSinh_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (tTHS.ID == -1)
            {
                dgvHocSinh.Rows.RemoveAt(dgvHocSinh.CurrentCell.RowIndex);
                return;
            }
            string strTTHS = tTHS.Ten + " - Lớp " + Program.lstLop.FirstOrDefault(p => p.ID == tTHS.IDLop).TenLop;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + strTTHS + " Không?", "Hỏi xóa !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (await tt.Xoa(int.Parse(txtID.Text)) == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        bsThongTinHS.DataSource = await tt.LayDT();
                        dgvHocSinh.Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !\n" + ex.Message);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string[] s = txt.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string Ten = "";
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].ToLower();
                char[] a = s[i].ToArray();
                a[0] = char.ToUpper(a[0]);
                Ten += new string(a) + " ";
            }
            txt.Text = Ten.Trim();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Equals("Nhập ID hoặc Tên học sinh"))
            {
                bsThongTinHS.RemoveFilter();
            }
            else
            {
                if (txt.TextLength > 0)
                {
                    bsThongTinHS.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [Ten] LIKE '%{0}%'", txt.Text);
                }
                else
                {
                    bsThongTinHS.RemoveFilter();
                }
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
