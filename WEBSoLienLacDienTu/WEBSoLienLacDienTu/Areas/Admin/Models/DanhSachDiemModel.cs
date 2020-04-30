using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class DanhSachDiemModel
    {
        public int MaHS { get; set; }
        public string Ten { get; set; }
        public double Diem { get; set; }

        public DanhSachDiemModel()
        {
            MaHS = -1;
            Ten = "";
            Diem = -1;
        }

        public DanhSachDiemModel(int maHs,string ten,int diem)
        {
            MaHS = maHs;
            Ten = ten;
            Diem = diem;
        }

        public DanhSachDiemModel(DataRow dr)
        {
            MaHS = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            Diem = Convert.IsDBNull(dr["Diem"]) ? -1 : Convert.ToDouble(dr["Diem"]);
        }
    }
}