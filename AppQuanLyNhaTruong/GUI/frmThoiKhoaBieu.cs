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
        public frmThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }
        public void LoadCBO()
        {
            foreach(Lop l in Program.lstLop)
            {
                cboChonLop.Items.Add(l.TenLop);
            }
        }
    }
}
