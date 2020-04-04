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
    [Table("nxtckedu_sa.LoaiThongBao")]
    public class LoaiThongBao
    {
        public int ID { get; set; }

        [StringLength(100)] public string TenThongBao { get; set; }

        public LoaiThongBao()
        {
            ID = -1;
            TenThongBao = "";
        }

        public LoaiThongBao(int iD, string tenThongBao)
        {
            ID = iD;
            TenThongBao = tenThongBao;
        }

        public LoaiThongBao(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenThongBao = dr["TenLoai"].ToString();
        }
    }
}
