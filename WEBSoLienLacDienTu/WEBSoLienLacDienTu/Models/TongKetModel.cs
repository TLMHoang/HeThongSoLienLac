using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class TongKetModel
    {
        public int ID { get; set; }
        public int IDHanhKiem { get; set; }
        public string TenHanhKiem { get; set; }
        public double DiemCaNam { get; set; }
        public double HKI { get; set; }
        public double HKII { get; set; }

        public TongKetModel()
        {
            ID = -1;
            IDHanhKiem = -1;
            TenHanhKiem = "";
            DiemCaNam = -1;
            HKI = -1;
            HKII = -1;
        }

        public TongKetModel(int id, int idHanhKiem, string tenHanhKiem, double diemCaNam,double hki,double hkii)
        {
            ID = id;
            IDHanhKiem = idHanhKiem;
            TenHanhKiem = tenHanhKiem;
            DiemCaNam = diemCaNam;
            HKI = hki;
            HKII = hkii;
        }
        public TongKetModel(DataRow dr)
        {
            TenHanhKiem = dr["TenHanhKiem"].ToString();
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHanhKiem = Convert.IsDBNull(dr["IDHanhKiem"]) ? -1 : Convert.ToInt32(dr["IDHanhKiem"]);
            DiemCaNam = Convert.IsDBNull(dr["CaNam"]) ? -1 : Convert.ToDouble(dr["CaNam"]);
            HKI = Convert.IsDBNull(dr["HKI"]) ? -1 : Convert.ToDouble(dr["HKI"]);
            HKII = Convert.IsDBNull(dr["HKII"]) ? -1 : Convert.ToDouble(dr["HKII"]);
        }
    }
}