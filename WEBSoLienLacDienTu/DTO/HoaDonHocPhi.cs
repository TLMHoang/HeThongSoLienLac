using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonHocPhi
    {
        public int ID { get; set; }

        public int IDHocPhi { get; set; }

        public DateTime NgayTao { get; set; }

        public int IDHocSinh { get; set; }

        public byte ThanhToan { get; set; }

        public HoaDonHocPhi()
        {
            ID = -1;
            IDHocPhi = -1;
            NgayTao = DateTime.Now;
            IDHocSinh = -1;
            ThanhToan = 0;
        }
        public HoaDonHocPhi(int id,int idHocPhi,DateTime ngayTao,int idHocSinh,byte thanhToan)
        {
            ID =id;
            IDHocPhi = idHocPhi;
            NgayTao = ngayTao;
            IDHocSinh = idHocSinh;
            ThanhToan = thanhToan;
        }
        public HoaDonHocPhi(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocPhi = Convert.IsDBNull(dr["IDHocPhi"]) ? -1 : Convert.ToInt32(dr["IDHocPhi"]);
            NgayTao = Convert.ToDateTime(dr["NgayTao"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            ThanhToan = Convert.ToByte(dr["ThanhToan"]);
        }
    }
}
