using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.DTO
{
    [Table("nxtckedu_sa.ThongBaoLop")]
    class ThongBaoLop
    {
        public int ID { get; set; }

        public int IDLop { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int IDLoaiThongBao { get; set; }

        public ThongBaoLop()
        {
            ID = -1;
            IDLop = -1;
            NoiDung = "";
            Ngay = DateTime.Now;
            IDLoaiThongBao = -1;
        }
        public ThongBaoLop(int iD, int idLop, string noiDung, DateTime ngay, int idLoaiThongBao)
        {
            ID = iD;
            IDLop = idLop;
            NoiDung = noiDung;
            Ngay = ngay;
            IDLoaiThongBao = idLoaiThongBao;
        }

        public ThongBaoLop(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            NoiDung = dr["NoiDung"].ToString();
            Ngay = Convert.ToDateTime(dr["Ngay"]);
            IDLoaiThongBao = Convert.IsDBNull(dr["IDLoaiThongBao"]) ? -1 : Convert.ToInt32(dr["IDLoaiThongBao"]);
        }
    }
}
