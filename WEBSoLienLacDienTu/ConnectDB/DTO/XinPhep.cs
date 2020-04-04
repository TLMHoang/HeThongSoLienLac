using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.DTO
{
    [Table("nxtckedu_sa.XinPhep")]
    class XinPhep
    {
        public int ID { get; set; }

        public int IDHocSinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NghiTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NghiDen { get; set; }

        public int SoNgayNghi { get; set; }

        public XinPhep()
        {
            ID = -1;
            IDHocSinh = -1;
            NghiTu = DateTime.Now;
            NghiDen = DateTime.Now;
            SoNgayNghi = -1;
        }
        public XinPhep(int iD,int idHocSinh,DateTime nghiTu,DateTime nghiDen,int soNgayNghi)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            NghiTu = nghiTu;
            NghiDen = nghiDen;
            SoNgayNghi = soNgayNghi;
        }

        public XinPhep(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            NghiTu = Convert.ToDateTime(dr["NghiTu"]);
            NghiDen = Convert.ToDateTime(dr["NghiDen"]);
            SoNgayNghi = Convert.IsDBNull(dr["SoNgayNghi"]) ? -1 : Convert.ToInt32(dr["SoNgayNghi"]);
        }
    }
}
