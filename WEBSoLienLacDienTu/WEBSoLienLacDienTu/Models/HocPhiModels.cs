using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class HocPhiModels
    {
        public int ID { get; set; }
        public string Ten { get; set; }
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
        public HocPhiModels()
        {
            ID = -1;
            Ten = "";
            Thang = -1;
            LoaiHocSinh = -1;
            SoNgayHoc = -1;
            TienHoc = -1;
            TienAn = -1;
            TienDien = -1;
            TienNuoc = -1;
            TienVeSinh = -1;
            TienTrangThietBi = -1;
            TienTaiLieu = -1;
        }
        public HocPhiModels(int iD, string ten,int thag, int HocSinh, int soNgayHoc, int tienHoc, int tienAn, int tienDien, int tienNuoc, int tienVeSinh, int tienTrangThietBi, int tienTaiLieu)
        {
            ID = iD;
            Ten = ten;
            Thang = thag;
            LoaiHocSinh = HocSinh;
            SoNgayHoc = soNgayHoc;          
            TienHoc = tienHoc;
            TienAn = tienAn;
            TienDien = tienDien;
            TienNuoc = tienNuoc;
            TienVeSinh = tienVeSinh;
            TienTrangThietBi = tienTrangThietBi;
            TienTaiLieu = tienTaiLieu;
        }

        public HocPhiModels(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);           
            Ten = dr["Ten"].ToString();
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