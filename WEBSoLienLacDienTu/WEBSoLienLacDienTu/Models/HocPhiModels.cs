using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class HocPhiModels
    {
        //public int ID { get; set; }
        //public string Ten { get; set; }
        public int Thang { get; set; }
        public int LoaiHocSinh { get; set; }
        public int SoNgayHoc { get; set; }
        public int TienHoc { get; set; }

        public int TienAn { get; set; }

        public int TienDien { get; set; }

        public int TienNuoc { get; set; }

        public int TienVeSinh { get; set; }

        public int TienTrangThietBi { get; set; }

        public int TienTaiLieu { get; set; }
        
        public HocPhiModels(DataRow dr)
        {
            //ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);           
            //Ten = dr["Ten"].ToString();
            Thang = Convert.IsDBNull(dr["Thang"]) ? -1 : Convert.ToInt32(dr["Thang"]);
            LoaiHocSinh = Convert.IsDBNull(dr["IDLoaiHocSinh"]) ? -1 : Convert.ToInt32(dr["IDLoaiHocSinh"]);
            SoNgayHoc = Convert.IsDBNull(dr["SoNgayHoc"]) ? -1 : Convert.ToInt32(dr["SoNgayHoc"]);
            TienHoc = Convert.IsDBNull(dr["TienHoc"]) ? -1 : Convert.ToInt32(dr["TienHoc"]);
            TienAn = Convert.IsDBNull(dr["TienAn"]) ? -1 : Convert.ToInt32(dr["TienAn"]);
            TienDien = Convert.IsDBNull(dr["TienDien"]) ? -1 : Convert.ToInt32(dr["TienDien"]);
            TienNuoc = Convert.IsDBNull(dr["TienNuoc"]) ? -1 : Convert.ToInt32(dr["TienNuoc"]);
            TienVeSinh = Convert.IsDBNull(dr["TienVeSinh"]) ? -1 : Convert.ToInt32(dr["TienVeSinh"]);
            TienTrangThietBi = Convert.IsDBNull(dr["TienTrangThietBi"]) ? -1 : Convert.ToInt32(dr["TienTrangThietBi"]);
            TienTaiLieu = Convert.IsDBNull(dr["TienTaiLieu"]) ? -1 : Convert.ToInt32(dr["TienTaiLieu"]);
        }

    }
}