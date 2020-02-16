using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class PhanCong
    {
        public int STT { get; set; }
        public int IDGiaoVien { get; set; }
        public int IDLop { get; set; }
        public int IDMon { get; set; }

        public PhanCong()
        {
            STT = -1;
            IDGiaoVien = -1;
            IDLop = -1;
            IDMon = -1;
        }

        public PhanCong(int stt , int idGiaoVien , int idLop , int idMon)
        {
            STT = stt;
            IDGiaoVien = idGiaoVien;
            IDLop = idLop;
            IDMon = IDMon;
        }
        public PhanCong(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            IDGiaoVien = Convert.IsDBNull(dr["IDGiaoVien"]) ? -1 : Convert.ToInt32(dr["IDGiaoVien"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            IDMon = Convert.IsDBNull(dr["IDMon"]) ? -1 : Convert.ToInt32(dr["IDMon"]);
        }
    }
}
