using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemHocKy
    {
        public int STT { get; set; }
        public int IDHocSinh { get; set; }
        public int IDMon { get; set; }
        public double Diem { get; set; }
        public byte? Loai { get; set; }
        public byte? HocKy { get; set; }

        public DiemHocKy()
        {
            STT = -1;
            IDHocSinh = -1;
            IDMon = -1;
            Diem = 0.0;
            Loai = null;
            HocKy = 0;
        }

        public DiemHocKy(int sTT, int iDHocSinh, int iDMon, float diem, byte loai, byte hocKy)
        {
            STT = sTT;
            IDHocSinh = iDHocSinh;
            IDMon = iDMon;
            Diem = diem;
            Loai = loai;
            HocKy = hocKy;
        }

        public DiemHocKy(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            IDMon = Convert.IsDBNull(dr["IDMon"]) ? -1 : Convert.ToInt32(dr["IDMon"]);
            Diem = Convert.ToDouble(dr["Diem"]);
            Loai = Convert.ToByte(dr["Loai"]);
            HocKy = Convert.ToByte(dr["HocKy"]);
        }
    }
}
