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
    [Table("nxtckedu_sa.LoaiDiem")]
    public class LoaiDiem
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenLoaiDiem { get; set; }

        public int HeSo { get; set; }
        public int TongCot { get; set; }
        public LoaiDiem()
        {
            ID = -1;
            TenLoaiDiem = "";
            HeSo = -1;
            TongCot = -1;
        }

        public LoaiDiem(int iD, string tenLoaiDiem,int heSo,int tongCot)
        {
            ID = iD;
            TenLoaiDiem = tenLoaiDiem;
            HeSo = heSo;
            TongCot = tongCot;

        }

        public LoaiDiem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenLoaiDiem = dr["TenLoaiDiem"].ToString();
            HeSo = Convert.IsDBNull(dr["HeSo"]) ? -1 : Convert.ToInt32(dr["HeSo"]);
            TongCot = Convert.IsDBNull(dr["TongCot"]) ? -1 : Convert.ToInt32(dr["TongCot"]);
        }
    }
}
