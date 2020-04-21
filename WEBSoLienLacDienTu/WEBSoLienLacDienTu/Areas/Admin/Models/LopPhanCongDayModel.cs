using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class LopPhanCongDayModel
    {
        public string TenMon { get; set; }
        public string TenGV { get; set; }

        public LopPhanCongDayModel()
        {
            TenMon = "";
            TenGV = "";
        }

        public LopPhanCongDayModel(string tenMon, string tenGv)
        {
            TenMon = tenMon;
            TenGV = tenGv;
        }

        public LopPhanCongDayModel(DataRow dr)
        {
            TenMon = dr["TenMon"].ToString();
            TenGV = dr["TenGV"].ToString();
        }
    }
}