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
    [Table("nxtckedu_sa.MonHoc")]
    public class MonHoc
    {
        public int ID { get; set; }

        [StringLength(200)] public string TenMon { get; set; }

        public byte LoaiDiem { get; set; }

        public MonHoc()
        {
            ID = -1;
            TenMon = "";
            LoaiDiem = 0;
        }

        public MonHoc(int iD, string tenMon, byte loaiDiem)
        {
            ID = iD;
            TenMon = tenMon;
            LoaiDiem = loaiDiem;
        }

        public MonHoc(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenMon = dr["TenMon"].ToString();
            LoaiDiem = Convert.ToByte(dr["LoaiDiem"]);
        }
    }
}
