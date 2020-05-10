using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class ThongTinGVBMModel
    {
        public string TenMon { get; set; }
        public string TenGV { get; set; }
        public string SDT { get; set; }

        public ThongTinGVBMModel(DataRow dr)
        {
            TenMon = dr["TenMon"].ToString();
            TenGV = dr["TenGV"].ToString();
            SDT = dr["SDT"].ToString();
        }
    }
}