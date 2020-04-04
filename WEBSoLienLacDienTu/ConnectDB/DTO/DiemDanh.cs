using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.DTO
{
    [Table("nxtckedu_sa.DiemDanh")]
    class DiemDanh
    {
        public int ID { get; set; }

        public int IDHocSinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNghi { get; set; }

        public byte Phep { get; set; }

        public DiemDanh()
        {
            ID = -1;
            IDHocSinh = -1;
            NgayNghi=DateTime.Now;
            Phep = 0;
        }

        public DiemDanh(int iD, int idHocSinh, DateTime ngayNghi, byte phep)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            NgayNghi = ngayNghi;
            Phep = phep;
        }
        public DiemDanh(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            NgayNghi = Convert.ToDateTime(dr["NgayNghi"]);
            Phep = Convert.ToByte(dr["Phep"]);
        }
    }

}
