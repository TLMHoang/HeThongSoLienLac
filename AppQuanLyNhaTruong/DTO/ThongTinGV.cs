using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinGV
    {
        public int IDTKT { get; set; }
        public string TenGV { get; set; }
        public string SDT { get; set; }
        public int IDMonHoc { get; set; }
        public int IDLop { get; set; }
        public byte? GVCN { get; set; }

        public ThongTinGV()
        {
            IDTKT = -1;
            TenGV = "";
            SDT = "";
            IDMonHoc = -1;
            IDLop = -1;
            GVCN = 0;
        }

        public ThongTinGV(int iDTKT, string tenGV, string sDT, int iDMonHoc, int iDLop, byte gVCN)
        {
            IDTKT = iDTKT;
            TenGV = tenGV;
            SDT = sDT;
            IDMonHoc = iDMonHoc;
            IDLop = iDLop;
            GVCN = gVCN;
        }

        public ThongTinGV(DataRow dr)
        {
            IDTKT = Convert.IsDBNull(dr["IDTKT"]) ? -1 : Convert.ToInt32(dr["IDTKT"]);
            TenGV = dr["TenGV"].ToString();
            SDT = dr["SDT"].ToString();
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            GVCN = Convert.ToByte(dr["GVCN"]);
        }
    }
}

