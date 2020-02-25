using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GVCN
    {
        public int IDGiaoVien { get; set; }
        public int IDLop { get; set; }

        public GVCN()
        {
            IDGiaoVien = -1;
            IDLop = -1;
        }

        public GVCN(int iDGiaoVien, int iDLop)
        {
            IDGiaoVien = iDGiaoVien;
            IDLop = iDLop;
        }

        public GVCN(DataRow dr)
        {
            IDGiaoVien = Convert.IsDBNull(dr["IDGiaoVien"]) ? -1 : Convert.ToInt32(dr["IDGiaoVien"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
        }
    }
}
