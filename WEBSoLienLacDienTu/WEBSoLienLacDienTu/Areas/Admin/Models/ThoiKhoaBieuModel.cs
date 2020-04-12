using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class ThoiKhoaBieuModel
    {
        public int IDLop { get; set; }
        public int Thu { get; set; }
        public int Tiet { get; set; }
        public int IDMonHoc { get; set; }
        public string TenMon { get; set; }

        public ThoiKhoaBieuModel(DataRow dr)
        {
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            Thu = Convert.IsDBNull(dr["Thu"]) ? -1 : Convert.ToInt32(dr["Thu"]);
            Tiet = Convert.IsDBNull(dr["Tiet"]) ? -1 : Convert.ToInt32(dr["Tiet"]);
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
            TenMon = dr["TenMon"].ToString();
        }
    }
}