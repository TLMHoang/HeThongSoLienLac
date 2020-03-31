using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.ThongBaoHS")]
    public class ThongBaoHS
    {
        public int ID { get; set; }

        public int IDHocSinh { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int IDLoaiThongBao { get; set; }

        public ThongBaoHS()
        {
            ID = -1;
            IDHocSinh = -1;
            NoiDung = "";
            Ngay = DateTime.Now;
            IDLoaiThongBao = -1;
        }
        public ThongBaoHS(int iD, int idHocSinh, string noiDung, DateTime ngay, int idLoaiThongBao)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            NoiDung = noiDung;
            Ngay = ngay;
            IDLoaiThongBao = idLoaiThongBao;
        }

        public ThongBaoHS(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            NoiDung = dr["NoiDung"].ToString();
            Ngay = Convert.ToDateTime(dr["Ngay"]);
            IDLoaiThongBao = Convert.IsDBNull(dr["IDLoaiThongBao"]) ? -1 : Convert.ToInt32(dr["IDLoaiThongBao"]);
        }
    }
}
