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
    [Table("nxtckedu_sa.LoaiDiem")]
    class LoaiDiem
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenLoaiDiem { get; set; }

        public LoaiDiem()
        {
            ID = -1;
            TenLoaiDiem = "";
        }

        public LoaiDiem(int iD,string tenLoaiDiem)
        {
            ID = iD;
            TenLoaiDiem = tenLoaiDiem;
        }

        public LoaiDiem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenLoaiDiem = dr["TenLoaiDiem"].ToString();
        }
    }
}
