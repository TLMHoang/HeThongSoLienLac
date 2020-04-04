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

        public byte TrangThai { get; set; }
        public byte ChoHuy { get; set; }
        public string LyDo { get; set; }

        public XinPhep()
        {
            ID = -1;
            IDHocSinh = -1;
            NghiTu = DateTime.Now;
            NghiDen = DateTime.Now;
            TrangThai = 0;
            ChoHuy = 0;
            LyDo = "";
        }
        public XinPhep(int iD, int idHocSinh, DateTime nghiTu, DateTime nghiDen, byte trangThai,byte choHuy,string lyDo)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            NghiTu = nghiTu;
            NghiDen = nghiDen;
            TrangThai = trangThai;
            ChoHuy = choHuy;
            LyDo = lyDo;
        }

        public XinPhep(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            NghiTu = Convert.ToDateTime(dr["NghiTu"]);
            NghiDen = Convert.ToDateTime(dr["NghiDen"]);
            TrangThai = Convert.ToByte(dr["TrangThai"]);
            ChoHuy = Convert.ToByte(dr["ChoHuy"]);
            LyDo = dr["LyDo"].ToString();
        }
    }
}
