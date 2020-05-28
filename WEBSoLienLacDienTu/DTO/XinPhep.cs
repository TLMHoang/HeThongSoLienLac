using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.XinPhep")]
    public class XinPhep
    {
        public int ID { get; set; }

        public int IDHocSinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NghiTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NghiDen { get; set; }

        public int TrangThai { get; set; }
        
        public string LyDo { get; set; }

        public XinPhep()
        {
            ID = -1;
            IDHocSinh = -1;
            NghiTu = DateTime.Now;
            NghiDen = DateTime.Now;
            TrangThai = -1;
            LyDo = "";
        }
        public XinPhep(int iD, int idHocSinh, DateTime nghiTu, DateTime nghiDen, int trangThai,string lyDo)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            NghiTu = nghiTu;
            NghiDen = nghiDen;
            TrangThai = trangThai;
            LyDo = lyDo;
        }

        public XinPhep(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            NghiTu = Convert.ToDateTime(dr["NghiTu"]);
            NghiDen = Convert.ToDateTime(dr["NghiDen"]);
            TrangThai = Convert.IsDBNull(dr["TrangThai"]) ? -1 : Convert.ToInt32(dr["TrangThai"]);
            LyDo = dr["LyDo"].ToString();
        }
    }
}
