using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HanhKiem
    {
        public int IDHocSinh { get; set; }
        public string Loai { get; set; }
        public byte HocKy { get; set; }

        public HanhKiem()
        {
            IDHocSinh = -1;
            Loai = "";
            HocKy = 0;
        }

        public HanhKiem(int iDHocSinh, string loai, byte hocKy)
        {
            IDHocSinh = iDHocSinh;
            Loai = Loai;
            HocKy = hocKy;
        }

        public HanhKiem(DataRow dr)
        {
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            Loai = dr["Loai"].ToString();
            HocKy = Convert.ToByte(dr["HocKy"]);
        }
    }
}
