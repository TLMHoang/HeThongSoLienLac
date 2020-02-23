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
        DiemDanhBAL ddBAL = new DiemDanhBAL();
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

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            
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

        private async void dgvDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                                //await ddBAL.Them(new DiemDanh(-1, Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), DateTime.Today, 1));
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
                                //await ddBAL.Them(new DiemDanh(-1, Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), DateTime.Today, 0));
                            }
                            else
                            {
                                dgvVangK.Rows.Add(ID, dgv.Rows[e.RowIndex].Cells["Ten"].Value, cbxLop.Text);
                                //await ddBAL.Them(new DiemDanh(-1, Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), DateTime.Today, 0));
                            }
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

        private async void dgvVangP_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
