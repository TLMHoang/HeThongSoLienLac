using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.DTO
{
    [Table("nxtckedu_sa.BHYT")]
    class BHYT
    {
        public int IDHocSinh { get; set; }

        public byte DangKy { get; set; }

        public byte BHQD { get; set; }

        public BHYT()
        {
            IDHocSinh = -1;
            DangKy = 0;
            BHQD = 0;
        }

        public BHYT(int idHocSinh,byte dangKy,byte bHQD)
        {
            IDHocSinh = idHocSinh;
            DangKy = dangKy;
            BHQD = bHQD;
        }

        public BHYT(DataRow dr)
        {
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            DangKy = Convert.ToByte(dr["DangKy"]);
            BHQD = Convert.ToByte(dr["BHQD"]);
        }
    }
}
