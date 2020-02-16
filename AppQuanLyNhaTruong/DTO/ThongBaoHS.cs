using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongBaoHS
    {
        public int STT { get; set; }
        public int IDHocSinh { get; set; }
        public string NoiDung { get; set; }

        public ThongBaoHS() { STT = -1; IDHocSinh = -1; NoiDung = ""; }

        public ThongBaoHS(int sTT, int iDHocSinh, string noiDung)
        {
            STT = sTT;
            IDHocSinh = iDHocSinh;
            NoiDung = noiDung;
        }

        public ThongBaoHS(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            NoiDung = dr["NoiDung"].ToString();
        }
    }
}
