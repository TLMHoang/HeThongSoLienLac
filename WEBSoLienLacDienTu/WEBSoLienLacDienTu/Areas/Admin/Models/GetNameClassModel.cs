using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class GetNameClassModel
    {
        public int ID { get; set; }
        public string TenKhoi { get; set; }
        public string TenLop { get; set; }
        public string TenDayDu { get; set; }

        public GetNameClassModel()
        {
            ID = -1;
            TenKhoi = "";
            TenLop = "";
            TenDayDu = "";
        }

        public GetNameClassModel(int iD,string tenKhoi,string tenLop,string tenDayDu)
        {
            ID = iD;
            TenKhoi = tenKhoi;
            TenLop = tenLop;
            TenDayDu = tenDayDu;
        }
        public GetNameClassModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenKhoi = dr["TenKhoi"].ToString();
            TenLop = dr["TenLop"].ToString();
            TenDayDu = dr["TenDayDu"].ToString();
        }
    }
}