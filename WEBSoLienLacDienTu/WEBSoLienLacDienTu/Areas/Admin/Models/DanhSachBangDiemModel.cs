using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class DanhSachBangDiemModel
    {
        public string Ten { get; set; }
        public double DiemMieng1 { get; set; }
        public double DiemMieng2 { get; set; }
        public double DiemMieng3 { get; set; }
        public double DiemMieng4 { get; set; }
        public double DiemMieng5 { get; set; }

        public double _15p_1 { get; set; }
        public double _15p_2 { get; set; }
        public double _15p_3 { get; set; }
        public double _15p_4 { get; set; }
        public double _15p_5 { get; set; }
        public double _1t_1 { get; set; }
        public double _1t_2 { get; set; }
        public double _1t_3 { get; set; }
        public double _1t_4 { get; set; }
        public double _1t_5 { get; set; }
        public double HocKy { get; set; }
        public double TBM1 { get; set; }
        public double TBM2 { get; set; }

        public DanhSachBangDiemModel()
        {
            Ten = "";
            DiemMieng1 = -1;
            DiemMieng2 = -1;
            DiemMieng3 = -1;
            DiemMieng4 = -1;
            DiemMieng5 = -1;
            _15p_1 = -1;
            _15p_2 = -1;
            _15p_3 = -1;
            _15p_4 = -1;
            _15p_5 = -1;
            _1t_1 = -1;
            _1t_2 = -1;
            _1t_3 = -1;
            _1t_4 = -1;
            _1t_5 = -1;
            HocKy = -1;
            TBM1 = -1;
            TBM2 = -1;
        }

        public DanhSachBangDiemModel(string ten, double diemMieng1, double diemMieng2, double diemMieng3, double diemMieng4, double diemMieng5, double diem15_1, double diem15_2, double diem15_3, double diem15_4, double diem15_5, double diem1t_1,
            double diem1t_2, double diem1t_3, double diem1t_4, double diem1t_5, double hocKy,double tbm1,double tbm2)
        {
            Ten = ten;
            DiemMieng1 = diemMieng1;
            DiemMieng2 = diemMieng2;
            DiemMieng3 = diemMieng3;
            DiemMieng4 = diemMieng4;
            DiemMieng5 = diemMieng5;
            _15p_1 = diem15_1;
            _15p_2 = diem15_2;
            _15p_3 = diem15_3;
            _15p_4 = diem15_4;
            _15p_5 = diem15_5;
            _1t_1 = diem1t_1;
            _1t_2 = diem1t_2;
            _1t_3 = diem1t_3;
            _1t_4 = diem1t_4;
            _1t_5 = diem1t_5;
            HocKy = hocKy;
            TBM1 = tbm1;
            TBM2 = tbm2;
        }

        public DanhSachBangDiemModel(DataRow dr)
        {
            Ten = dr["Ten"].ToString();
            DiemMieng1 = Convert.IsDBNull(dr["DM1"]) ? -1 : Convert.ToDouble(dr["DM1"]);
            DiemMieng2 = Convert.IsDBNull(dr["DM2"]) ? -1 : Convert.ToDouble(dr["DM2"]);
            DiemMieng3 = Convert.IsDBNull(dr["DM3"]) ? -1 : Convert.ToDouble(dr["DM3"]);
            DiemMieng4 = Convert.IsDBNull(dr["DM4"]) ? -1 : Convert.ToDouble(dr["DM4"]);
            DiemMieng5 = Convert.IsDBNull(dr["DM5"]) ? -1 : Convert.ToDouble(dr["DM5"]);
            _15p_1 = Convert.IsDBNull(dr["15p_1"]) ? -1 : Convert.ToDouble(dr["15p_1"]);
            _15p_2 = Convert.IsDBNull(dr["15p_2"]) ? -1 : Convert.ToDouble(dr["15p_2"]);
            _15p_3 = Convert.IsDBNull(dr["15p_3"]) ? -1 : Convert.ToDouble(dr["15p_3"]);
            _15p_4 = Convert.IsDBNull(dr["15p_4"]) ? -1 : Convert.ToDouble(dr["15p_4"]);
            _15p_5 = Convert.IsDBNull(dr["15p_5"]) ? -1 : Convert.ToDouble(dr["15p_5"]);
            _1t_1 = Convert.IsDBNull(dr["1t_1"]) ? -1 : Convert.ToDouble(dr["1t_1"]);
            _1t_2 = Convert.IsDBNull(dr["1t_2"]) ? -1 : Convert.ToDouble(dr["1t_2"]);
            _1t_3 = Convert.IsDBNull(dr["1t_3"]) ? -1 : Convert.ToDouble(dr["1t_3"]);
            _1t_4 = Convert.IsDBNull(dr["1t_4"]) ? -1 : Convert.ToDouble(dr["1t_4"]);
            _1t_5 = Convert.IsDBNull(dr["1t_5"]) ? -1 : Convert.ToDouble(dr["1t_5"]);
            HocKy = Convert.IsDBNull(dr["HocKy"]) ? -1 : Convert.ToDouble(dr["HocKy"]);
            TBM1 = Convert.IsDBNull(dr["HK1"]) ? -1 : Convert.ToDouble(dr["HK1"]);
            TBM2 = Convert.IsDBNull(dr["HK2"]) ? -1 : Convert.ToDouble(dr["HK2"]);
        }
    }
}