using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class DanhSachTaiKhoanTruongModel
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string TaiKhoan { get; set; }

        public byte Loai { get; set; }

        [StringLength(200)]
        public string TenGV { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        public int IDMonHoc { get; set; }

        public string TenMon { get; set; }

        public int IDLop { get; set; }

        public string TenKhoi { get; set; }
        public string TenLop { get; set; }

        public DanhSachTaiKhoanTruongModel()
        {
            ID = -1;
            TaiKhoan = "";
            Loai = 0;
            TenGV = "";
            SDT = "";
            IDMonHoc = -1;
            TenMon = "";
            IDLop = -1;
            TenKhoi = "";
            TenLop = "";
        }
        public DanhSachTaiKhoanTruongModel(int iD,string taiKhoan,byte loai,string tenGv,string sdt,int idMonHoc,string tenMon,int idLop,string tenKhoi,string tenLop)
        {
            ID = -1;
            TaiKhoan = "";
            Loai = 0;
            TenGV = "";
            SDT = "";
            IDMonHoc = -1;
            TenMon = "";
            IDLop = -1;
            TenKhoi = "";
            TenLop = "";
        }
        public DanhSachTaiKhoanTruongModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TaiKhoan = dr["TaiKhoan"].ToString();
            Loai = Convert.ToByte(dr["Loai"]);
            TenGV = dr["TenGV"].ToString();
            SDT = dr["SDT"].ToString();
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
            TenMon = dr["TenMon"].ToString();
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            TenKhoi = dr["TenKhoi"].ToString();
            TenLop = dr["TenLop"].ToString();
        }
    }
}