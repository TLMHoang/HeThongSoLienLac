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
        public int IDMon { get; set; }
        public int IDPhanCong { get; set; }
        public LopPhanCongDayModel()
        {
            TenMon = "";
            TenGV = "";
            IDMon = -1;
            IDPhanCong = -1;
        }

        public LopPhanCongDayModel(string tenMon, string tenGv,int idMon,int idPhanCong)
        {
            TenMon = tenMon;
            TenGV = tenGv;
            IDMon = idMon;
            IDPhanCong = idPhanCong;
        }

        public LopPhanCongDayModel(DataRow dr)
        {
            TenMon = dr["TenMon"].ToString();
            TenGV = dr["TenGV"].ToString();
            IDMon = Convert.IsDBNull(dr["IDMon"]) ? -1 : Convert.ToInt32(dr["IDMon"]);
            IDPhanCong = Convert.IsDBNull(dr["IDPhanCong"]) ? -1 : Convert.ToInt32(dr["IDPhanCong"]);
        }
    }
}