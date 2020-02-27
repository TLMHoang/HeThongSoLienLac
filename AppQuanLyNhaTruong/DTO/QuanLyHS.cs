using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyHS
    {
        public int IDHocSinh { get; set; }
        public int IDTaiKhoan { get; set; }

        public QuanLyHS()
        {
            IDHocSinh = -1;
            IDTaiKhoan = -1;
        }

        public QuanLyHS(int iDHocSinh, int iDTaiKhoan)
        {
            IDHocSinh = iDHocSinh;
            IDTaiKhoan = iDTaiKhoan;
        }

        public QuanLyHS(DataRow dr)
        {
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            IDTaiKhoan = Convert.IsDBNull(dr["IDTaiKhoan"]) ? -1 : Convert.ToInt32(dr["IDTaiKhoan"]);
        }
    }
}
