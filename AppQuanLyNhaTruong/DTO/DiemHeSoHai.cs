using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemHeSoHai
    {
        public int STT { get; set; }
        public int IDHocSinh { get; set; }
        public int IDMon { get; set; }
        public float? Diem { get; set; }
        public int CotThu { get; set; }
        public byte? Loai { get; set; }
        public byte? HocKy { get; set; }

        public DiemHeSoHai()
        {
            STT = -1;
            IDHocSinh = -1;
            IDMon = -1;
            Diem = (float)0.0;
            CotThu = 1;
            Loai = 0;
            HocKy = 0;
        }

        public DiemHeSoHai(int sTT, int iDHocSinh, int iDMon, float diem, int cotThu, byte loai, byte hocKy)
        {
            STT = sTT;
            IDHocSinh = iDHocSinh;
            IDMon = iDMon;
            Diem = diem;
            CotThu = cotThu;
            Loai = loai;
            HocKy = hocKy;
        }

        public DiemHeSoHai(DataRow dr)
        {
            STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            IDMon = Convert.IsDBNull(dr["IDMon"]) ? -1 : Convert.ToInt32(dr["IDMon"]);
            Diem = (float)Convert.ToDouble(dr["Diem"]);
            CotThu = Convert.IsDBNull(dr["CotThu"]) ? 0 : Convert.ToInt32(dr["CotThu"]);
            Loai = Convert.ToByte(dr["Loai"]);
            HocKy = Convert.ToByte(dr["HocKy"]);
        }
    }
}
