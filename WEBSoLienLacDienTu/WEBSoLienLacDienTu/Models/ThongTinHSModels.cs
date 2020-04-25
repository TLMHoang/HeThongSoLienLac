using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class ThongTinHSModels
    {
        public int ID { get; set; }
        //public int IDHocSinh { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte GioiTinh { get; set; }

        public string NoiSinh { get; set; }

        public string DanToc { get; set; }

        public string TonGiao { get; set; }
        public ThongTinHSModels()
        {
            ID = -1;
            Ten = "";
            NgaySinh = DateTime.Now;
            GioiTinh = 0;
            NoiSinh = "";
            DanToc = "";
            TonGiao = "";
            
        }
        public ThongTinHSModels(int iD, string ten, DateTime ngaySinh, byte gioiTinh, string noiSinh, string danToc, string tonGiao, int idLop, int idLoaiHocSinh, int? hki, int? hkii, int? caNam)
        {
            ID = iD;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            NoiSinh = noiSinh;
            DanToc = danToc;
            TonGiao = tonGiao;
            
        }
        public ThongTinHSModels(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            //IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            Ten = dr["Ten"].ToString();
            NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
            GioiTinh = Convert.ToByte(dr["GioiTinh"]);
            NoiSinh = dr["NoiSinh"].ToString();
            DanToc = dr["DanToc"].ToString();
            TonGiao = dr["TonGiao"].ToString();
        }
    }
}