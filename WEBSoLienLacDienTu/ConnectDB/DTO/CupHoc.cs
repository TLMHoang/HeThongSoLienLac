using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.DTO
{
    [Table("nxtckedu_sa.CupHoc")]
    class CupHoc
    {
        public int ID { get; set; }

        public int IDHocSinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int Tiet { get; set; }

        public CupHoc()
        {
            ID = -1;
            IDHocSinh = -1;
            Ngay = DateTime.Now;
            Tiet = -1;
        }

        public CupHoc(int iD,int idHocSinh,DateTime ngay,int tiet)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            Ngay = ngay;
            Tiet = tiet;
        }

        public CupHoc(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            Ngay = Convert.ToDateTime(dr["Ngay"]);
            Tiet = Convert.IsDBNull(dr["Tiet"]) ? -1 : Convert.ToInt32(dr["Tiet"]);
        }
    }
}
