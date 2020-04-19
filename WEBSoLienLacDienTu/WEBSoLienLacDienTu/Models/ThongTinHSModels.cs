using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class ThongTinHSModels
    {
        public int IDTaiKhoan { get; set; }
        public int IDHocSinh { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte GioiTinh { get; set; }

        public string NoiSinh { get; set; }

        public string DanToc { get; set; }

        public string TonGiao { get; set; }
        public ThongTinHSModels(DataRow dr)
        {
            IDTaiKhoan = Convert.IsDBNull(dr["IDTaiKhoan"]) ? -1 : Convert.ToInt32(dr["IDTaiKhoan"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            Ten = dr["Ten"].ToString();
            NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
            GioiTinh = Convert.ToByte(dr["GioiTinh"]);
            NoiSinh = dr["NoiSinh"].ToString();
            DanToc = dr["DanToc"].ToString();
            TonGiao = dr["TonGiao"].ToString();
        }
    }
}