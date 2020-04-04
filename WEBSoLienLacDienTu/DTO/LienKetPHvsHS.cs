using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.LienKetPHvsHS")]
        public class LienKetPHvsHS
        {
            public int IDHocSinh { get; set; }

            public int IDTaiKhoan { get; set; }

            public LienKetPHvsHS()
            {
                IDHocSinh = -1;
                IDTaiKhoan = -1;
            }

            public LienKetPHvsHS(int idHocSinh, int idTaiKhoan)
            {
                IDHocSinh = idHocSinh;
                IDTaiKhoan = idTaiKhoan;
            }

            public LienKetPHvsHS(DataRow dr)
            {
                IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
                IDTaiKhoan = Convert.IsDBNull(dr["IDTaiKhoan"]) ? -1 : Convert.ToInt32(dr["IDTaiKhoan"]);
            }
        }
}
