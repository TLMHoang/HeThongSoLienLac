using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class DanhSachXinPhepModels
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime NghiTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NghiDen { get; set; }

        public int TrangThai { get; set; }

        public string LyDo { get; set; }

        public DanhSachXinPhepModels()
        {
            ID = -1;
            NghiTu = DateTime.Now;
            NghiDen = DateTime.Now;
            TrangThai = -1;
            LyDo = "";
        }
        public DanhSachXinPhepModels(int iD, DateTime nghiTu, DateTime nghiDen, int trangThai, string lyDo)
        {
            ID = iD;

            NghiTu = nghiTu;
            NghiDen = nghiDen;
            TrangThai = trangThai;
            LyDo = lyDo;
        }

        public DanhSachXinPhepModels(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            NghiTu = Convert.ToDateTime(dr["NghiTu"]);
            NghiDen = Convert.ToDateTime(dr["NghiDen"]);
            TrangThai = Convert.IsDBNull(dr["TrangThai"]) ? -1 : Convert.ToInt32(dr["TrangThai"]);
            LyDo = dr["LyDo"].ToString();
        }
    }
}