using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.ThoiKhoaBieu")]
    public class ThoiKhoaBieu
    {
        public int IDLop { get; set; }
        public int Thu { get; set; }
        public int Tiet { get; set; }
        public int IDMonHoc { get; set; }

        public ThoiKhoaBieu()
        {
            IDLop = -1;
            Thu = -1;
            Tiet = -1;
            IDMonHoc = -1;
        }
        public ThoiKhoaBieu(int idLop, int thu, int tiet, int idMonHoc)
        {
            IDLop = idLop;
            Thu = thu;
            Tiet = tiet;
            IDMonHoc = idMonHoc;
        }

        public ThoiKhoaBieu(DataRow dr)
        {
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            Thu = Convert.IsDBNull(dr["Thu"]) ? -1 : Convert.ToInt32(dr["Thu"]);
            Tiet = Convert.IsDBNull(dr["Tiet"]) ? -1 : Convert.ToInt32(dr["Tiet"]);
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
        }
    }
}
