using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDanh_ScanQR
    {
        public int ID { get; set; }
        public int IDHocSinh { get; set; }
        public DateTime NgayGioDiemDanh { get; set; }

        public DiemDanh_ScanQR()
        {

        }
        public DiemDanh_ScanQR(int iD,int idHocSinh,DateTime ngayGioDiemDanh)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            NgayGioDiemDanh = ngayGioDiemDanh;
        }

        public DiemDanh_ScanQR(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            NgayGioDiemDanh = Convert.ToDateTime(dr["NgayGioDiemDanh"]);
        }
    }
}
