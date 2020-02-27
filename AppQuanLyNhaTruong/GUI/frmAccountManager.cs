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
    public partial class frmAccountManager : Form
    {
        TaiKhoanTruongBAL tkTruong = new TaiKhoanTruongBAL();
        ThongTinGVBAL ttGV = new ThongTinGVBAL();
        TaiKhoanPHBAL tkPH = new TaiKhoanPHBAL();
        ThongTinHSBAL ttHS = new ThongTinHSBAL();
        
        public frmAccountManager()
        {
            InitializeComponent();
        }

        private async void frmAccountManager_Load(object sender, EventArgs e)
        {
            
            await LoadDGVDSHS();
            await LoadDGVTKPH();
            await LoadDGVGV();
            await LoadDGVTruong();
            await loadCBOMon();
        }
        #region TabTaiKhoanPH
        int id = -1;
        string tenTK = "";
        int idTKPH = -1;
        int idHS = -1;
        public async Task LoadDGVTKPH()
        {
            bsTKPH.SuspendBinding();
            dgvTKPH.SuspendLayout();
            bsTKPH.DataSource =await tkPH.LayDT();
            dgvTKPH.ResumeLayout();
            bsTKPH.ResumeBinding();
        }
        public async Task LoadDGVDSHS()
        {
            bsTTHS.SuspendBinding();
            dgvDSHS.SuspendLayout();
            bsTTHS.DataSource = await ttHS.LayDT();
            dgvDSHS.ResumeLayout();
            bsTTHS.ResumeBinding();
        }
        private void dgvTKPH_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvTKPH.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }

        private async void dgvTKPH_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    TaiKhoanPH tk = new TaiKhoanPH((e.Row.DataBoundItem as DataRowView).Row);
                    try
                    {
                        if((await tkPH.Xoa(tk.ID)) == 1)
                        {
                            return;
                        }
                            else
                        {
                            MessageBox.Show("Xóa Thất Bại !");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi !\n" + ex.Message);
                    }                   
                }
                else
                    e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Bạn không thể xóa được nhiều dòng !");
                e.Cancel = true;
            }
        }
        private async void dgvTKPH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
            try
            {
                if (drv == null)
                {
                    return;
                }
                TaiKhoanPH ph = new TaiKhoanPH(-1, drv.Row.ItemArray[1].ToString(), drv.Row.ItemArray[1].ToString());
                if (ph.ID == -1 && drv.Row.ItemArray[1].ToString() != "")
                {
                    await tkPH.Them(ph);
                    LoadDGVTKPH();
                    MessageBox.Show("Vui lòng chọn học sinh và nhấn lưu ;");                    
                    dgvTKPH.ReadOnly = true;
                    idTKPH = Convert.ToInt32(dgvTKPH.Rows[dgvTKPH.RowCount - 2].Cells[0].Value.ToString());
                    dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
                }
                else
                {
                    MessageBox.Show("Chưa có thông tin tài khoản !");
                    dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 2].Cells[1];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private async void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {                
                if (idHS != -1)
                {
                    if (await CheckIDHS(idHS, idTKPH) == 1)
                    {
                        if ((await new QuanLyHSBAL().CapNhap(new QuanLyHS(idHS, idTKPH))) != 0)
                        {
                            MessageBox.Show("Cập Nhật Liên Kết Thành Công");
                            idTKPH = -1;
                            idHS = -1;
                            dgvTKPH.ReadOnly = false;
                            LoadDGVDSHS();
                            dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Liên Kết Thất Bại");
                            idTKPH = -1;
                            idHS = -1;
                            dgvTKPH.ReadOnly = false;
                            LoadDGVDSHS();
                            dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
                        }
                    }
                    else
                    {
                        if ((await new QuanLyHSBAL().Them(new QuanLyHS(idHS, idTKPH))) != 0)
                        {
                            MessageBox.Show("Liên Kết Thành Công");
                            idTKPH = -1;
                            idHS = -1;
                            dgvTKPH.ReadOnly = false;
                            LoadDGVDSHS();
                            dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
                        }
                        else
                        {
                            MessageBox.Show("Liên Kết Thất Bại");
                            idTKPH = -1;
                            idHS = -1;
                            dgvTKPH.ReadOnly = false;
                            LoadDGVDSHS();
                            dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn Tài Khoản Học Sinh Liên Kết !");
                }
            }catch(Exception)
            {
                MessageBox.Show("Lỗi !");
            }

        }

        private void dgvTKPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTKPH.Rows[e.RowIndex];
            if (row.Cells[0].Value.ToString() != "")
            {
                if (int.Parse(row.Cells[0].Value.ToString()) != -1)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    idTKPH = int.Parse(row.Cells[0].Value.ToString());
                    tenTK = row.Cells[1].Value.ToString();
                }
            }
        }
        private void dgvDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell btn = dgvDSHS.Rows[e.RowIndex].Cells[0] as DataGridViewButtonCell;
            if(MessageBox.Show("Chọn Học Sinh  " + dgvDSHS.CurrentRow.Cells[2].Value.ToString(),"Notification !",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)== DialogResult.OK)
            {
                btn.Style.BackColor = Color.DarkOrange;
                idHS = Convert.ToInt32(dgvDSHS.CurrentRow.Cells[1].Value.ToString());
            }
        }
        private async void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                {
                    if((await tkPH.CapNhap(new TaiKhoanPH(id, tenTK, tenTK))) != 0)
                    {
                        LoadDGVTKPH();
                        id = -1;
                        tenTK = "";
                        MessageBox.Show("MK đã được đặt lại (Tên TK là MK)!");
                    }
                    else
                    {
                        MessageBox.Show("Đăt Lại Mật Khẩu Thất Bại !");
                        LoadDGVTKPH();
                        id = -1;
                        tenTK = "";
                    }                    
                }
                else
                {
                    MessageBox.Show("Chưa Chọn Tài Khoản reset MK !");
                }
            }
            catch (Exception) { MessageBox.Show("Lỗi !"); }
        }
        private void txtTimTK_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên Tài Khoản")
            {
                if (txt.TextLength != 0)
                {
                    bsTKPH.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TaiKhoan] LIKE '%{0}%'", txt.Text);
                }
                else
                {
                    bsTKPH.RemoveFilter();
                }
            }
            else
            {
                bsTKPH.RemoveFilter();

            }
        }
        private void txtTimTK_Leave(object sender, EventArgs e)
        {
            if (txtTimTK.Text == "")
            {
                txtTimTK.Text = "Nhập ID hoặc Tên Tài Khoản";
                txtTimTK.ForeColor = Color.Gray;
            }
        }

        private void txtTimTK_Enter(object sender, EventArgs e)
        {
            if (txtTimTK.ForeColor == Color.Gray)
            {
                txtTimTK.Text = "";
                txtTimTK.ForeColor = Color.Black;
            }
        }

        private void txtTimHocSinh_TextChanged(object sender, EventArgs e)//timm hoc sinh
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên Tài Khoản")
            {
                if (txt.TextLength != 0)
                {
                    bsTTHS.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [Ten] LIKE '%{0}%'", txt.Text);
                }
                else
                {
                    bsTTHS.RemoveFilter();
                }
            }
            else
            {
                bsTTHS.RemoveFilter();

            }
        }

        private void txtTimHocSinh_Enter(object sender, EventArgs e)
        {
            if (txtTimHocSinh.ForeColor == Color.Gray)
            {
                txtTimHocSinh.Text = "";
                txtTimHocSinh.ForeColor = Color.Black;
            }
        }

        private void txtTimHocSinh_Leave(object sender, EventArgs e)
        {
            if (txtTimHocSinh.Text == "")
            {
                txtTimHocSinh.Text = "Nhập ID hoặc Tên Tài Khoản";
                txtTimHocSinh.ForeColor = Color.Gray;
            }
        }
        private async Task<int> CheckIDHS(int id,int tk)
        {
            DataTable dt = await new QuanLyHSBAL().LayDT();
            foreach (DataRow item in dt.Rows )
            {
                if(int.Parse(item.ItemArray[0].ToString()).Equals(id) && int.Parse(item.ItemArray[1].ToString()).Equals(tk))
                {
                    return 1;
                }
            }
            return 0;
        }
        #endregion

        #region TabTaiKhoanTruong
        int idTruong = -1;
        byte loaiAdmin;   
        string text;
        public async Task LoadDGVTruong()
        {
            bsTaiKhoanTruong.SuspendBinding();
            dgvTaiKhoanTruong.SuspendLayout();
            bsTaiKhoanTruong.DataSource = await tkTruong.LayDT();

            col_Loai.TrueValue = Convert.ToByte(1);
            col_Loai.FalseValue = Convert.ToByte(0);

            bsTaiKhoanTruong.ResumeBinding();
            dgvTaiKhoanTruong.ResumeLayout();
        }
        public async Task LoadDGVGV()
        {
            bsDSGV.SuspendBinding();
            dgvThongTinGV.SuspendLayout();
            bsDSGV.DataSource = await ttGV.LayDT();
            bsDSGV.ResumeBinding();
            dgvThongTinGV.ResumeLayout();
        }

        public async Task loadCBOMon()
        {
            DataGridViewComboBoxColumn cbo = dgvThongTinGV.Columns[3] as DataGridViewComboBoxColumn;
            cbo.DataSource = Program.lstMonHoc;
            cbo.DisplayMember = "TenMon";
            cbo.ValueMember = "ID";
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {                       
            try
            {
                if (dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 1].Cells[0].Value == null)
                {                    
                    DataGridViewRow dvr = dgvTaiKhoanTruong.CurrentRow;
                    if((await tkTruong.Them(new TaiKhoanTruong(
                        idTruong,
                        dvr.Cells[1].Value.ToString(),
                        dvr.Cells[1].Value.ToString(),
                        loaiAdmin))) != 0)
                    {
                        bsTaiKhoanTruong.DataSource = await tkTruong.LayDT();
                        text = dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 2].Cells[0].Value.ToString();
                        dgvThongTinGV.DataSource = await ttGV.LayDT();
                        MessageBox.Show("Thêm Thành Công , Nhập Thông Tin Ở bảng bên và nhấn lưu !");

                        DataTable dataTable = (DataTable)dgvThongTinGV.DataSource;
                        DataRow drToAdd = dataTable.NewRow();
                        drToAdd["IDTKT"] = text;
                        dataTable.Rows.Add(drToAdd);
                        dataTable.AcceptChanges();

                        dgvThongTinGV.CurrentCell = dgvThongTinGV.Rows[dgvThongTinGV.RowCount - 2].Cells[1];
                        dgvTaiKhoanTruong.ReadOnly = true;
                        btnThemTaiKhoan.Enabled = false;
                    }
                    else
                    {
                        bsTaiKhoanTruong.DataSource = await tkTruong.LayDT();
                    }                    
                }
            }
            catch(Exception ex) { MessageBox.Show("Lỗi ! \n" + ex.Message); }
        }
       
        private async void btnLuuTTGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinGV.CurrentRow.Cells[0] != null && text != "")
                {
                    DataGridViewRow dvr = dgvThongTinGV.CurrentRow;
                    if((await ttGV.Them(new ThongTinGV(
                        int.Parse(dvr.Cells[0].Value.ToString()),
                        dvr.Cells[1].Value.ToString(),
                        dvr.Cells[2].Value.ToString(),
                        Convert.ToInt32(dvr.Cells[3].Value))
                        )) != 0)
                    {
                        bsDSGV.DataSource = await ttGV.LayDT();
                        MessageBox.Show("Thêm Thông Tin Thành Công !");
                        dgvTaiKhoanTruong.ReadOnly = false;
                        text = "";
                        btnThemTaiKhoan.Enabled = true;
                        dgvTaiKhoanTruong.CurrentCell = dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 1].Cells[1];
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại !");
                        bsDSGV.DataSource = await ttGV.LayDT();
                        dgvTaiKhoanTruong.ReadOnly = false;
                        text = "";
                        btnThemTaiKhoan.Enabled = true;
                        dgvTaiKhoanTruong.CurrentCell = dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 1].Cells[1];
                    }
                    
                }else if(dgvThongTinGV.CurrentRow.Cells[0] != null && text == "")
                {
                    if (dgvThongTinGV.CurrentRow != null)
                    {
                        DataGridViewRow dvr = dgvThongTinGV.CurrentRow;
                        if((await ttGV.CapNhap(new ThongTinGV(
                            int.Parse(dvr.Cells[0].Value.ToString()),
                            dvr.Cells[1].Value.ToString(),
                            dvr.Cells[2].Value.ToString(),
                            Convert.ToInt32(dvr.Cells[3].Value)
                            ))) != 0)
                        {
                            bsDSGV.DataSource = await ttGV.LayDT();
                            MessageBox.Show("Cập Nhật Thông Tin Thành Công !");
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Thất Bại !");
                            bsDSGV.DataSource = await ttGV.LayDT();
                        }                        
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi ! \n"+ ex.Message); }
        }

        private void txtTimTKTruong_TextChanged(object sender, EventArgs e) // Tim kiem tai Khoan truong
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên Tài Khoản")
            {
                if (txt.TextLength != 0)
                {
                    bsTaiKhoanTruong.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TaiKhoan] LIKE '%{0}%'", txt.Text);
                }
                else
                {
                    bsTaiKhoanTruong.RemoveFilter();
                }
            }
            else
            {
                bsTaiKhoanTruong.RemoveFilter();

            }
        }

        private void txtTimGV_TextChanged(object sender, EventArgs e)//tim kiem giao vien
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != "Nhập ID hoặc Tên GV")
            {
                if (txt.TextLength != 0)
                {
                    bsDSGV.Filter = String.Format("CONVERT(IDTKT, System.String)='{0}' OR [TenGV] LIKE '%{0}%'", txt.Text);
                }
                else
                {
                    bsDSGV.RemoveFilter();
                }
            }
            else
            {
                bsDSGV.RemoveFilter();
            }
        }


        private void txtTimTKTruong_Leave(object sender, EventArgs e)
        {
            if (txtTimTKTruong.Text == "")
            {
                txtTimTKTruong.Text = "Nhập ID hoặc Tên Tài Khoản";
                txtTimTKTruong.ForeColor = Color.Gray;
            }
        }

        private void txtTimTKTruong_Enter(object sender, EventArgs e)
        {
            if (txtTimTKTruong.ForeColor == Color.Gray)
            {
                txtTimTKTruong.Text = "";
                txtTimTKTruong.ForeColor = Color.Black;
            }
        }

        private void txtTimGV_Leave(object sender, EventArgs e)
        {            
            if (txtTimGV.Text == "")
            {
                txtTimGV.Text = "Nhập ID hoặc Tên GV";
                txtTimGV.ForeColor = Color.Gray;
            }
        }

        private void txtTimGV_Enter(object sender, EventArgs e)
        {           
            if (txtTimGV.ForeColor == Color.Gray)
            {
                txtTimGV.Text = "";
                txtTimGV.ForeColor = Color.Black;
            }
        }
        private async void dgvTaiKhoanTruong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.Rows[e.RowIndex].Cells["col_ID"].Value.ToString() == "")
            {
                loaiAdmin = Convert.IsDBNull(dgv.Rows[e.RowIndex].Cells["col_Loai"].Value) ? Convert.ToByte(0) : Convert.ToByte(dgv.Rows[e.RowIndex].Cells["col_Loai"].Value);
            }
            else
            {                                   
                    if((await tkTruong.CapNhap(new TaiKhoanTruong(int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        dgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        dgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Convert.IsDBNull(dgv.Rows[e.RowIndex].Cells["col_Loai"].Value) ? Convert.ToByte(0) : Convert.ToByte(dgv.Rows[e.RowIndex].Cells["col_Loai"].Value
                        )))) != 0)
                    {
                        bsTaiKhoanTruong.DataSource = await tkTruong.LayDT();
                        dgvTaiKhoanTruong.CurrentCell = dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 1].Cells[1];
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại!");
                    }                
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !\n" + ex.Message);
            }
        }


        #endregion


    }
}
