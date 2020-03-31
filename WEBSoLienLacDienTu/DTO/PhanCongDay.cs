using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.PhanCongDay")]
    public class PhanCongDay
    {
        public int ID { get; set; }

        public int IDGiaoVien { get; set; }

        public int IDLop { get; set; }

        public int IDMonHoc { get; set; }

        public PhanCongDay()
        {
            ID = -1;
            IDGiaoVien = -1;
            IDMonHoc = -1;
            IDLop = -1;
        }

        public PhanCongDay(int iD, int idGiaoVien, int idLop, int idMonHoc)
        {
            ID = iD;
            IDGiaoVien = idGiaoVien;
            IDLop = idLop;
            IDMonHoc = idMonHoc;
        }

        public PhanCongDay(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDGiaoVien = Convert.IsDBNull(dr["IDGiaoVien"]) ? -1 : Convert.ToInt32(dr["IDGiaoVien"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
        }
    }
}
