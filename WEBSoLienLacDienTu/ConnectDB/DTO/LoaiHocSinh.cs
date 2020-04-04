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
    [Table("nxtckedu_sa.LoaiHocSinh")]
    class LoaiHocSinh
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TenLoai { get; set; }

        public LoaiHocSinh()
        {
            ID = -1;
            TenLoai = "";
        }

        public LoaiHocSinh(int iD, string tenLoai)
        {
            ID = iD;
            TenLoai = tenLoai;
        }

        public LoaiHocSinh(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenLoai = dr["TenLoai"].ToString();
        }
    }
}
