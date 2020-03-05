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
    public partial class frmThoiKhoaBieu : Form
    {
        ThoiKhoaBieuBAL tkb = new ThoiKhoaBieuBAL();
        MonHocBAL mh = new MonHocBAL();
        public frmThoiKhoaBieu()
        {
            InitializeComponent();
        }


        private void frmThoiKhoaBieu_Load(object sender, EventArgs e)
        {           
            LoadCBO();
            LoadDGV();
            bsTKB.Filter = String.Format("CONVERT(IDLop, System.String)='{0}' ", cboChonLop.SelectedValue);
        }
        public async void LoadCBO()
        {
            cboChonLop.DataSource = await new LopBAL().LayDT();
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "ID";

            cboChonThu.DisplayMember = "Text";
            cboChonThu.ValueMember = "Value";
            var item = new[]
            {
                new {Text = "Thứ 2",Value = 2},
                new {Text = "Thứ 3", Value = 3},
                new {Text = "Thứ 4", Value = 4},
                new {Text = "Thứ 5", Value = 5},
                new {Text = "Thứ 6", Value = 6},
                new {Text = "Thứ 7", Value = 7},
                new {Text = "Chủ Nhật", Value = 1}
            };
            cboChonThu.DataSource = item;

            cboChonBuoi.DisplayMember = "Text";
            cboChonBuoi.ValueMember = "Value";
            var buoi = new[]
            {
                new {Text = "Buổi Sáng", Value = 1},
                new {Text = "Buổi Chiều", Value = 2},                
            };
            cboChonBuoi.DataSource = buoi;

            bsMonHoc.SuspendBinding();
            bsMonHoc2.SuspendBinding();
            bsMonHoc3.SuspendBinding();
            bsMonHoc4.SuspendBinding();
            bsMonHoc5.SuspendBinding();
            cboMonTiet1.SuspendLayout();
            cboMonTiet2.SuspendLayout();
            cboMonTiet3.SuspendLayout();
            cboMonTiet4.SuspendLayout();
            cboMonTiet5.SuspendLayout();

            bsMonHoc.DataSource = await mh.LayDT();
            bsMonHoc2.DataSource = await mh.LayDT();
            bsMonHoc3.DataSource = await mh.LayDT();
            bsMonHoc4.DataSource = await mh.LayDT();
            bsMonHoc5.DataSource = await mh.LayDT();

            cboMonTiet1.ResumeLayout();
            cboMonTiet2.ResumeLayout();
            cboMonTiet3.ResumeLayout();
            cboMonTiet4.ResumeLayout();
            cboMonTiet5.ResumeLayout();
            bsMonHoc.ResumeBinding();
            bsMonHoc2.ResumeBinding();
            bsMonHoc3.ResumeBinding();
            bsMonHoc4.ResumeBinding();
            bsMonHoc5.ResumeBinding();
        }
        public async void LoadDGV()
        {
            bsTKB.SuspendBinding();
            dgvTKB.SuspendLayout();
            bsTKB.DataSource = await tkb.LayDT();
            dgvTKB.ResumeLayout();
            bsTKB.ResumeBinding();
        }

        
        private void cboChonBuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonBuoi.SelectedIndex == 0)
            {
                lblTiet1.Text = "Tiết 1";
                lblTiet2.Text = "Tiết 2";
                lblTiet3.Text = "Tiết 3";
                lblTiet4.Text = "Tiết 4";
                lblTiet5.Text = "Tiết 5";
            }
            else
            {
                lblTiet1.Text = "Tiết 6";
                lblTiet2.Text = "Tiết 7";
                lblTiet3.Text = "Tiết 8";
                lblTiet4.Text = "Tiết 9";
                lblTiet5.Text = "Tiết 10";
            }
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            bsTKB.Filter = String.Format("CONVERT(IDLop, System.String)='{0}' ", cbx.SelectedValue);
        }
       
        private async void bntLuuTiet1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           1, Convert.ToInt32(cboMonTiet1.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           6, Convert.ToInt32(cboMonTiet1.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }           
        }

        private async void btnSuaTiet1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           1, Convert.ToInt32(cboMonTiet1.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           6, Convert.ToInt32(cboMonTiet1.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnLuuTiet2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           2, Convert.ToInt32(cboMonTiet2.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           7, Convert.ToInt32(cboMonTiet2.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnSuaTiet2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           2, Convert.ToInt32(cboMonTiet2.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           7, Convert.ToInt32(cboMonTiet2.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnLuuTiet3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           3, Convert.ToInt32(cboMonTiet3.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           8, Convert.ToInt32(cboMonTiet3.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnSuaTiet3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           3, Convert.ToInt32(cboMonTiet3.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           8, Convert.ToInt32(cboMonTiet3.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnLuuTiet4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           4, Convert.ToInt32(cboMonTiet4.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           9, Convert.ToInt32(cboMonTiet4.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnSuaTiet4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           4, Convert.ToInt32(cboMonTiet4.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           9, Convert.ToInt32(cboMonTiet4.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnLuuTiet5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           5, Convert.ToInt32(cboMonTiet5.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.Them(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           10, Convert.ToInt32(cboMonTiet5.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        private async void btnSuaTiet5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChonBuoi.SelectedIndex == 0)
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           5, Convert.ToInt32(cboMonTiet5.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
                else
                {
                    if ((await tkb.CapNhap(new ThoiKhoaBieu(
                           Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
                           Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
                           10, Convert.ToInt32(cboMonTiet5.SelectedValue.ToString())
                           ))) != 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại !");
                        bsTKB.DataSource = await tkb.LayDT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !" + ex.Message);
            }
        }

        //private async void btnLuu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {                
        //            if (cboChonBuoi.SelectedIndex == 0)
        //            {
        //                if((await tkb.Them(new ThoiKhoaBieu(
        //                    Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
        //                    Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
        //                    1, Convert.ToInt32(cboMonTiet1.SelectedValue.ToString())
        //                    ))) != 0)
        //            {
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    2, int.Parse(cboMonTiet2.SelectedValue.ToString())
        //                    ));//Tiet 2
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    3, int.Parse(cboMonTiet3.SelectedValue.ToString())
        //                    ));//Tiet 3
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    4, int.Parse(cboMonTiet4.SelectedValue.ToString())
        //                    ));//Tiet 4
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    5, int.Parse(cboMonTiet5.SelectedValue.ToString())
        //                    ));//Tiet 5
        //                MessageBox.Show("Thêm Thành Công !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Thêm Thất Bại !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //            }

        //            }
        //            else
        //            {
        //                if((await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    6, int.Parse(cboMonTiet1.SelectedValue.ToString())
        //                    )))!=0)//Tiet 6
        //            {
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    7, int.Parse(cboMonTiet2.SelectedValue.ToString())
        //                    ));//Tiet 7
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    8, int.Parse(cboMonTiet3.SelectedValue.ToString())
        //                    ));//Tiet 8
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    9, int.Parse(cboMonTiet4.SelectedValue.ToString())
        //                    ));//Tiet 9
        //                await tkb.Them(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    10, int.Parse(cboMonTiet5.SelectedValue.ToString())
        //                    ));//Tiet 10
        //                MessageBox.Show("Thêm Thành Công !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Thêm Thất Bại !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //            }

        //            }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private async void btnSua_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cboChonBuoi.SelectedIndex == 0)
        //        {
        //            if((await tkb.CapNhap(new ThoiKhoaBieu(
        //                Convert.ToInt32(cboChonLop.SelectedValue.ToString()),
        //                Convert.ToInt32(cboChonThu.SelectedValue.ToString()),
        //                1, Convert.ToInt32(cboMonTiet1.SelectedValue.ToString())
        //                ))) != 0)
        //            {
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                int.Parse(cboChonLop.SelectedValue.ToString()),
        //                int.Parse(cboChonThu.SelectedValue.ToString()),
        //                2, int.Parse(cboMonTiet2.SelectedValue.ToString())
        //                ));//Tiet 2
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    3, int.Parse(cboMonTiet3.SelectedValue.ToString())
        //                    ));//Tiet 3
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    4, int.Parse(cboMonTiet4.SelectedValue.ToString())
        //                    ));//Tiet 4
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    5, int.Parse(cboMonTiet5.SelectedValue.ToString())
        //                    ));//Tiet 5
        //                MessageBox.Show("Cập Nhật Thành Công !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //                btnSua.Enabled = false;
        //                btnLuu.Enabled = true;
        //                cboChonLop.Enabled = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Cập Nhật Thất Bại !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //                btnSua.Enabled = false;
        //                btnLuu.Enabled = true;
        //                cboChonLop.Enabled = true;
        //            }

        //        }
        //        else
        //        {
        //            if((await tkb.CapNhap(new ThoiKhoaBieu(
        //                int.Parse(cboChonLop.SelectedValue.ToString()),
        //                int.Parse(cboChonThu.SelectedValue.ToString()),
        //                6, int.Parse(cboMonTiet1.SelectedValue.ToString())
        //                ))) != 0)
        //            {
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                int.Parse(cboChonLop.SelectedValue.ToString()),
        //                int.Parse(cboChonThu.SelectedValue.ToString()),
        //                7, int.Parse(cboMonTiet2.SelectedValue.ToString())
        //                ));//Tiet 7
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    8, int.Parse(cboMonTiet3.SelectedValue.ToString())
        //                    ));//Tiet 8
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    9, int.Parse(cboMonTiet4.SelectedValue.ToString())
        //                    ));//Tiet 9
        //                await tkb.CapNhap(new ThoiKhoaBieu(
        //                    int.Parse(cboChonLop.SelectedValue.ToString()),
        //                    int.Parse(cboChonThu.SelectedValue.ToString()),
        //                    10, int.Parse(cboMonTiet5.SelectedValue.ToString())
        //                    ));//Tiet 10
        //                MessageBox.Show("Cập Nhật Thành Công !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //                btnSua.Enabled = false;
        //                btnLuu.Enabled = true;
        //                cboChonLop.Enabled = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Cập Nhật Thất Bại !");
        //                bsTKB.DataSource = await tkb.LayDT();
        //                btnSua.Enabled = false;
        //                btnLuu.Enabled = true;
        //                cboChonLop.Enabled = true;
        //            }                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi !\n" + ex.Message);
        //    }
        //}
        //private void dgvTKB_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    cboChonLop.Enabled = false;
        //    MessageBox.Show("Chọn Lại Môn Cần Cập Nhật !");
        //    if (int.Parse(dgvTKB.Rows[e.RowIndex].Cells[2].Value.ToString()) > 0 && int.Parse(dgvTKB.Rows[e.RowIndex].Cells[2].Value.ToString()) < 6)
        //    {
        //        cboChonBuoi.SelectedValue = 1;
        //    }
        //    else
        //    {
        //        cboChonBuoi.SelectedValue = 2;
        //    }
        //    cboChonThu.SelectedValue = int.Parse(dgvTKB.Rows[e.RowIndex].Cells[1].Value.ToString());
        //}

    }

}
