﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class ThongTinHS_API
    {

        public int ID { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        public byte GioiTinh { get; set; }

        [StringLength(250)]
        public string NoiSinh { get; set; }

        [StringLength(100)]
        public string DanToc { get; set; }

        [StringLength(100)]
        public string TonGiao { get; set; }

        public int IDLop { get; set; }

        public int IDLoaiHocSinh { get; set; }

        public int? HKI { get; set; }

        public int? HKII { get; set; }

        public int? CaNam { get; set; }
        public string Lop { get; set; }

        public ThongTinHS_API(ThongTinHS hs,string lop)
        {
            ID = hs.ID;
            Ten = hs.Ten;
            NgaySinh = hs.NgaySinh;
            GioiTinh = hs.GioiTinh;
            NoiSinh = hs.NoiSinh;
            DanToc = hs.DanToc;
            TonGiao = hs.TonGiao;
            IDLop = hs.IDLop;
            IDLoaiHocSinh = hs.IDLoaiHocSinh;
            HKI = hs.HKI;
            HKII = hs.HKII;
            CaNam = hs.CaNam;
            Lop = lop;
        }

        public ThongTinHS_API()
        {
            ID = -1;
            Ten = "";
            NgaySinh = DateTime.Now;
            GioiTinh = 0;
            NoiSinh = "";
            DanToc = "";
            TonGiao = "";
            IDLop = -1;
            IDLoaiHocSinh = -1;
            HKI = -1;
            HKII = -1;
            CaNam = -1;
        }
        public ThongTinHS_API(int iD, string ten, DateTime ngaySinh, byte gioiTinh, string noiSinh, string danToc, string tonGiao, int idLop, int idLoaiHocSinh, int? hki, int? hkii, int? caNam)
        {
            ID = iD;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            NoiSinh = noiSinh;
            DanToc = danToc;
            TonGiao = tonGiao;
            IDLop = idLop;
            IDLoaiHocSinh = idLoaiHocSinh;
            HKI = hki;
            HKII = hkii;
            CaNam = caNam;
        }

        public ThongTinHS_API(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
            GioiTinh = Convert.ToByte(dr["GioiTinh"]);
            NoiSinh = dr["NoiSinh"].ToString();
            DanToc = dr["DanToc"].ToString();
            TonGiao = dr["TonGiao"].ToString();
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            IDLoaiHocSinh = Convert.IsDBNull(dr["IDLoaiHocSinh"]) ? -1 : Convert.ToInt32(dr["IDLoaiHocSinh"]);
            HKI = Convert.IsDBNull(dr["HKI"]) ? -1 : Convert.ToInt32(dr["HKI"]);
            HKII = Convert.IsDBNull(dr["HKII"]) ? -1 : Convert.ToInt32(dr["HKII"]);
            CaNam = Convert.IsDBNull(dr["CaNam"]) ? -1 : Convert.ToInt32(dr["CaNam"]);
        }
    }
}