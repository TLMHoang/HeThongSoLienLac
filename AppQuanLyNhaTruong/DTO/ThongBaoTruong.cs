using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongBaoTruong
    {
        public int STT { get; set; }
        public string NoiDung { get; set; }

        public ThongBaoTruong() { STT = -1; NoiDung = ""; }

        public ThongBaoTruong(int sTT, string noiDung)
        {
            STT = sTT;
            NoiDung = noiDung;
        }

        public ThongBaoTruong(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            NoiDung = dr["NoiDung"].ToString();
        }
    }
}
