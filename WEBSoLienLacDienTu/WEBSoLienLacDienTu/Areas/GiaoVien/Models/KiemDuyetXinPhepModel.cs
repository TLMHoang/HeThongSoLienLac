using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Models
{
    public class KiemDuyetXinPhepModel
    {
        public int ID { get; set; }

        public int IDHocSinh { get; set; }
        public string TenHS { get; set; }
        [Column(TypeName = "date")]
        public DateTime NghiTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NghiDen { get; set; }

        public int TrangThai { get; set; }

        public string LyDo { get; set; }

        public KiemDuyetXinPhepModel()
        {
            ID = -1;
            IDHocSinh = -1;
            TenHS = "";
            NghiTu = DateTime.Now;
            NghiDen = DateTime.Now;
            TrangThai = -1;
            LyDo = "";
        }
        public KiemDuyetXinPhepModel(int iD, int idHocSinh,string tenHs, DateTime nghiTu, DateTime nghiDen, int trangThai, string lyDo)
        {
            ID = iD;
            IDHocSinh = idHocSinh;
            TenHS = tenHs;
            NghiTu = nghiTu;
            NghiDen = nghiDen;
            TrangThai = trangThai;
            LyDo = lyDo;
        }

        public KiemDuyetXinPhepModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
            TenHS = dr["TenHS"].ToString();
            NghiTu = Convert.ToDateTime(dr["NghiTu"]);
            NghiDen = Convert.ToDateTime(dr["NghiDen"]);
            TrangThai = Convert.IsDBNull(dr["TrangThai"]) ? -1 : Convert.ToInt32(dr["TrangThai"]);
            LyDo = dr["LyDo"].ToString();
        }
    }
}