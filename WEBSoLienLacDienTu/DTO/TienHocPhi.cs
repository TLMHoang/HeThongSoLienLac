using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.TienHocPhi")]
    public class TienHocPhi
    {
        public int ID { get; set; }

        public int Thang { get; set; }

        public int IDLoaiHocSinh { get; set; }

        public int IDKhoi { get; set; }

        public int SoNgayHoc { get; set; }

        public int TienHoc { get; set; }

        public int TienAn { get; set; }

        public int TienDien { get; set; }

        public int TienNuoc { get; set; }

        public int TienVeSinh { get; set; }

        public int TienTrangThietBi { get; set; }

        public int TienTaiLieu { get; set; }

        public TienHocPhi()
        {
            ID = -1;
            Thang = -1;
            IDLoaiHocSinh = -1;
            IDKhoi = -1;
            SoNgayHoc = -1;
            TienHoc = -1;
            TienAn = -1;
            TienDien = -1;
            TienNuoc = -1;
            TienVeSinh = -1;
            TienTrangThietBi = -1;
            TienTaiLieu = -1;
        }
        public TienHocPhi(int iD, int thang, int idLoaiHocSinh, int idKhoi, int soNgayHoc, int tienHoc, int tienAn, int tienDien, int tienNuoc, int tienVeSinh, int tienTrangThietBi, int tienTaiLieu)
        {
            ID = iD;
            Thang = thang;
            IDLoaiHocSinh = idLoaiHocSinh;
            IDKhoi = idKhoi;
            SoNgayHoc = soNgayHoc;
            TienHoc = tienHoc;
            TienAn = tienAn;
            TienDien = tienDien;
            TienNuoc = tienNuoc;
            TienVeSinh = tienVeSinh;
            TienTrangThietBi = tienTrangThietBi;
            TienTaiLieu = tienTaiLieu;
        }

        public TienHocPhi(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Thang = Convert.IsDBNull(dr["Thang"]) ? -1 : Convert.ToInt32(dr["Thang"]);
            IDLoaiHocSinh = Convert.IsDBNull(dr["IDLoaiHocSinh"]) ? -1 : Convert.ToInt32(dr["IDLoaiHocSinh"]);
            IDKhoi = Convert.IsDBNull(dr["IDKhoi"]) ? -1 : Convert.ToInt32(dr["IDKhoi"]);
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
