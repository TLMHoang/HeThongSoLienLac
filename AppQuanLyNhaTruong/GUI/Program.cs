using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        //Value 
        public static TaiKhoanTruong TK = new TaiKhoanTruong();
        public static ThongTinGV gV = new ThongTinGV();
        public static GVCN gvcn = new GVCN();

        //List
        public static List<Lop> lstLop = new List<Lop>();
        public static List<MonHoc> lstMonHoc = new List<MonHoc>();
        public static List<PhanCong> lstLopQL = new List<PhanCong>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
