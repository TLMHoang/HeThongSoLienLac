﻿using System;
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

        private void frmAccountManager_Load(object sender, EventArgs e)
        {
            LoadDGVDSHS();
            LoadDGVTKPH();
            LoadDGVGV();
            LoadDGVTruong();
            loadCBO();
        }
        #region TabTaiKhoanPH
        int id = -1;
        string tenTK = "";
        int idTKPH = -1;
        int idHS = -1;
        public async void LoadDGVTKPH()
        {
            bsTKPH.SuspendBinding();
            dgvTKPH.SuspendLayout();
            dgvTKPH.DataSource =await tkPH.LayDT();
            dgvTKPH.ResumeLayout();
            bsTKPH.ResumeBinding();
        }
        public async void LoadDGVDSHS()
        {
            bsTTHS.SuspendBinding();
            dgvDSHS.SuspendLayout();
            dgvDSHS.DataSource = await ttHS.LayDT();
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
                    await tkPH.Xoa(tk.ID);
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
                if (ph.ID == -1)
                {
                    await tkPH.Them(ph);
                    LoadDGVTKPH();
                    MessageBox.Show("Vui lòng chọn học sinh và nhấn lưu ;");
                    idTKPH = int.Parse(drv.Row.ItemArray[0].ToString());
                    dgvTKPH.ReadOnly = true;
                    dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private async void btnThemTK_Click(object sender, EventArgs e)
        {

            if (idHS != -1)
            {                
                await ttHS.CapNhatID(idHS,idTKPH);
                MessageBox.Show("Liên Kết Thành Công");
                idTKPH = -1;
                idHS = -1;
                dgvTKPH.ReadOnly = false;
                LoadDGVDSHS();
                dgvTKPH.CurrentCell = dgvTKPH.Rows[dgvTKPH.RowCount - 1].Cells[1];
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Tài Khoản Học Sinh Liên Kết !");
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
                    tenTK = row.Cells[1].Value.ToString();
                }
            }
        }
        private void dgvDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell btn = dgvDSHS.Rows[e.RowIndex].Cells[0] as DataGridViewButtonCell;
            if(MessageBox.Show("Chọn Học Sinh " + dgvDSHS.CurrentRow.Cells[2].Value.ToString(),"Notification !",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)== DialogResult.OK)
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
                    await tkPH.CapNhap(new TaiKhoanPH(id, tenTK, tenTK));
                    LoadDGVTKPH();
                    id = -1;
                    tenTK = "";
                    MessageBox.Show("MK đã được đặt lại (Tên TK là MK)!");
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
                    bsDSGV.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [Ten] LIKE '%{0}%'", txt.Text);
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
        #endregion

        #region TabTaiKhoanTruong
        int idTruong = -1;
        string tenTkt = "";
        string matkhauTruong = "";
        byte loai;
        string text;
        public async void LoadDGVTruong()
        {
            bsTaiKhoanTruong.SuspendBinding();
            dgvTaiKhoanTruong.SuspendLayout();
            dgvTaiKhoanTruong.DataSource = await tkTruong.LayDT();

            

            bsTaiKhoanTruong.ResumeBinding();
            dgvTaiKhoanTruong.ResumeLayout();
        }
        public async void LoadDGVGV()
        {
            bsDSGV.SuspendBinding();
            dgvThongTinGV.SuspendLayout();
            dgvThongTinGV.DataSource = await ttGV.LayDT();
            bsDSGV.ResumeBinding();
            dgvThongTinGV.ResumeLayout();
        }

        public async void loadCBO()
        {
            DataGridViewComboBoxColumn cbo = dgvThongTinGV.Columns[3] as DataGridViewComboBoxColumn;
            cbo.DataSource = await new MonHocBAL().LayDT();
            cbo.DisplayMember = "TenMon";
            cbo.ValueMember = "ID";
            DataGridViewComboBoxColumn cbo1 = dgvThongTinGV.Columns[4] as DataGridViewComboBoxColumn;
            cbo1.DataSource = await new LopBAL().LayDT();
            cbo1.DisplayMember = "TenLop";
            cbo1.ValueMember = "ID";
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            
            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 1].Cells[3];
            try
            {
                if (dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 1].Cells[0].Value == null)
                {
                    DataGridViewRow dvr = dgvTaiKhoanTruong.CurrentRow;
                    await tkTruong.Them(new TaiKhoanTruong(
                        idTruong,
                        dvr.Cells[1].Value.ToString(),
                        dvr.Cells[2].Value.ToString(),
                        chk.Value == chk.TrueValue ? (byte)1 : (byte)0));
                    dgvTaiKhoanTruong.DataSource = await tkTruong.LayDT();
                    text = dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 2].Cells[0].Value.ToString();
                    dgvThongTinGV.DataSource = await ttGV.LayDT();

                    MessageBox.Show("Thêm Thành Công , Nhập Thông Tin Ở bảng bên và nhấn lưu !");
                }

                DataTable dataTable = (DataTable)dgvThongTinGV.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["IDTKT"] = text;
                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();

                dgvThongTinGV.CurrentCell = dgvThongTinGV.Rows[dgvThongTinGV.RowCount - 2].Cells[1];
                dgvTaiKhoanTruong.ReadOnly = true;

            }
            catch(Exception) { MessageBox.Show("Lỗi !"); }
        }
       
        private async void btnLuuTTGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinGV.CurrentRow.Cells[0] != null && text != "")
                {
                    DataGridViewRow dvr = dgvThongTinGV.CurrentRow;
                    await ttGV.Them(new ThongTinGV(
                        int.Parse(dvr.Cells[0].Value.ToString()),
                        dvr.Cells[1].Value.ToString(),
                        dvr.Cells[2].Value.ToString(),
                        Convert.ToInt32(dvr.Cells[3].Value), Convert.ToInt32(dvr.Cells[4].Value)
                        ));
                    dgvThongTinGV.DataSource = await ttGV.LayDT();
                    MessageBox.Show("Thêm Thông Tin Thành Công !");
                    dgvTaiKhoanTruong.ReadOnly = false;
                    text = "";
                    dgvTaiKhoanTruong.CurrentCell = dgvTaiKhoanTruong.Rows[dgvTaiKhoanTruong.RowCount - 1].Cells[1];
                }else if(dgvThongTinGV.CurrentRow.Cells[0] != null && text == "")
                {
                    if (dgvThongTinGV.CurrentRow != null)
                    {
                        DataGridViewRow dvr = dgvThongTinGV.CurrentRow;
                        await ttGV.CapNhap(new ThongTinGV(
                            int.Parse(dvr.Cells[0].Value.ToString()),
                            dvr.Cells[1].Value.ToString(),
                            dvr.Cells[2].Value.ToString(),
                            Convert.ToInt32(dvr.Cells[3].Value), Convert.ToInt32(dvr.Cells[4].Value)
                            ));
                        dgvThongTinGV.DataSource = await ttGV.LayDT();
                        MessageBox.Show("Cập nhật Thông Tin Thành Công !");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Lỗi !"); }
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
                    bsDSGV.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenGV] LIKE '%{0}%'", txt.Text);
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
        



        #endregion

    
    }
}
