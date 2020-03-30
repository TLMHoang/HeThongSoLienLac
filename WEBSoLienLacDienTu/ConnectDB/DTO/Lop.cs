using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.DTO
{
    [Table("nxtckedu_sa.Lop")]
    class Lop
    {
        public int ID { get; set; }

        public int IDKhoi { get; set; }

        [StringLength(50)]
        public string TenLop { get; set; }

        public Lop()
        {
            ID = -1;
            IDKhoi = -1;
            TenLop = "";
        }

        public Lop(int iD,int idKhoi ,string tenLop)
        {
            ID = iD;
            IDKhoi = idKhoi;
            TenLop = tenLop;
        }

        public Lop(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDKhoi = Convert.IsDBNull(dr["IDKhoi"]) ? -1 : Convert.ToInt32(dr["IDKhoi"]);
            TenLop = dr["TenLop"].ToString();
        }

    }
}
