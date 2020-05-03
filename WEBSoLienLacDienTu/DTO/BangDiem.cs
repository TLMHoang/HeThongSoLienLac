using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.BangDiem")]
    public class BangDiem
    {
        public int ID { get; set; }

        public int IDHocSinh { get; set; }

        public int IDMonHoc { get; set; }

        public int IDLoaiDiem { get; set; }

        
        public int CotDiem { get; set; }

        public double Diem { get; set; }

        public byte HocKyI { get; set; }

        public BangDiem()
        {
            ID = -1;
            IDHocSinh = -1;
            IDMonHoc = -1;
            IDLoaiDiem = -1;
            Diem = -1;
            HocKyI = 0;
            CotDiem = -1;
        }

        public BangDiem(int id, int idHocSinh, int idMonHoc, int idLoaiDiem, double diem,
            byte hocKyI,int cotDiem)
        {
            ID = id;
            IDHocSinh = idHocSinh;
            IDMonHoc = idMonHoc;
            IDLoaiDiem = idLoaiDiem;
            Diem = diem;
            HocKyI = hocKyI;
            CotDiem = cotDiem;
        }

        public BangDiem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
            IDLoaiDiem = Convert.IsDBNull(dr["IDLoaiDiem"]) ? -1 : Convert.ToInt32(dr["IDLoaiDiem"]);
            Diem = Convert.IsDBNull(dr["Diem"]) ? -1 : Convert.ToDouble(dr["Diem"]);
            HocKyI = Convert.ToByte(dr["HocKyI"]);
            CotDiem = Convert.IsDBNull(dr["CotDiem"]) ? -1 : Convert.ToInt32(dr["CotDiem"]);
        }
    }
}
