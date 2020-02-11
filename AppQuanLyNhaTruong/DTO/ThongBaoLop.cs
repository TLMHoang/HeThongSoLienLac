using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongBaoLop
    {
        public int STT { get; set; }
        public string NoiDung { get; set; }

        public ThongBaoLop() { STT = -1; NoiDung = ""; }

        public ThongBaoLop(int sTT, string noiDung)
        {
            STT = sTT;
            NoiDung = noiDung;
        }

        public ThongBaoLop(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            NoiDung = dr["NoiDung"].ToString();
        }
    }
}
