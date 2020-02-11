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
        public int IDMonHoc { get; set; }
        public int IDLop { get; set; }

        public ThongTinGV()
        {
            IDTKT = -1;
            TenGV = "";
            IDMonHoc = -1;
            IDLop = -1;
        }

        public ThongTinGV(int iDTKT, string tenGV, int iDMonHoc, int iDLop)
        {
            IDTKT = iDTKT;
            TenGV = tenGV;
            IDMonHoc = iDMonHoc;
            IDLop = iDLop;
        }

        public ThongTinGV(DataRow dr)
        {
            IDTKT = Convert.IsDBNull(dr["IDTKT"]) ? -1 : Convert.ToInt32(dr["IDTKT"]);
            TenGV = dr["TenGV"].ToString();
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
        }
    }
}
