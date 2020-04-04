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
    [Table("nxtckedu_sa.LoaiHanhKiem")]
    public class LoaiHanhKiem
    {
        public int ID { get; set; }

        [StringLength(60)]
        public string TenHanhKiem { get; set; }

        public LoaiHanhKiem()
        {
            ID = -1;
            TenHanhKiem = "";
        }

        public LoaiHanhKiem(int iD, string tenHanhKiem)
        {
            ID = iD;
            TenHanhKiem = tenHanhKiem;
        }

        public LoaiHanhKiem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenHanhKiem = dr["TenHanhKiem"].ToString();
        }
    }
}
