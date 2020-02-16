using System;
using System.Data;

namespace DTO
{
    public class ThongBaoLop
    {
        public int STT { get; set; }
        public int IDLop { get; set; }
        public string NoiDung { get; set; }

        public ThongBaoLop() { STT = -1; IDLop = -1; NoiDung = ""; }

        public ThongBaoLop(int sTT, int iDLop, string noiDung)
        {
            STT = sTT;
            IDLop = iDLop;
            NoiDung = noiDung;
        }

        public ThongBaoLop(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            NoiDung = dr["NoiDung"].ToString();
        }
    }
}
