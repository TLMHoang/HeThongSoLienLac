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
        public string NoiDung { get; set; }

        public ThongBaoHS() { STT = -1; NoiDung = ""; }

        public ThongBaoHS(int sTT, string noiDung)
        {
            STT = sTT;
            NoiDung = noiDung;
        }

        public ThongBaoHS(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            NoiDung = dr["NoiDung"].ToString();
        }
    }
}
