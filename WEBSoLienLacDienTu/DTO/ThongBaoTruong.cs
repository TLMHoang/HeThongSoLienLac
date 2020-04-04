using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.ThongBaoTruong")]
    public class ThongBaoTruong
    {
        public int ID { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int IDLoaiThongBao { get; set; }
        public ThongBaoTruong()
        {
            ID = -1;
            NoiDung = "";
            Ngay = DateTime.Now;
            IDLoaiThongBao = -1;
        }
        public ThongBaoTruong(int iD, string noiDung, DateTime ngay, int idLoaiThongBao)
        {
            ID = iD;
            NoiDung = noiDung;
            Ngay = ngay;
            IDLoaiThongBao = idLoaiThongBao;
        }

        public ThongBaoTruong(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            NoiDung = dr["NoiDung"].ToString();
            Ngay = Convert.ToDateTime(dr["Ngay"]);
            IDLoaiThongBao = Convert.IsDBNull(dr["IDLoaiThongBao"]) ? -1 : Convert.ToInt32(dr["IDLoaiThongBao"]);
        }
    }
}
