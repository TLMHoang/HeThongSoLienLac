using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.Khoi")]
    public class Khoi
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string TenKhoi { get; set; }

        public Khoi()
        {
            ID = -1;
            TenKhoi = "";
        }
        public Khoi(int iD, string tenKhoi)
        {
            ID = iD;
            TenKhoi = tenKhoi;
        }

        public Khoi(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenKhoi = dr["TenKhoi"].ToString();
        }
    }
}
