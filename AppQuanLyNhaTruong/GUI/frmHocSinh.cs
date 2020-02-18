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


namespace AppQuanLyNhaTruong
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        

        private void frmHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
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
            
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát không", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //
        }

        
        private async void frmHocSinh_Load(object sender, EventArgs e)
        {
            ThongTinHSBAL hs = new ThongTinHSBAL();
            bsThongTinHS.DataSource = await hs.LayDT();
        }
        

        
            
            
            

        
    }
}
