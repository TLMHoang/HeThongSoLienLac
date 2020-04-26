using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class BangDiemModels
    {
        public string Ten { get; set; }
        public double DiemMieng { get; set; }
        public double _15p_1 { get; set; }
        public double _15p_2 { get; set; }
        public double _15p_3 { get; set; }
        public double _1t_1 { get; set; }
        public double _1t_2 { get; set; }
        public double _1t_3 { get; set; }
        public double HocKy { get; set; }

        public BangDiemModels()
        {
            Ten = "";
            DiemMieng = -1;
            _15p_1 = -1;
            _15p_2 = -1;
            _15p_3 = -1;
            _1t_1 = -1;
            _1t_2 = -1;
            _1t_3 = -1;
            HocKy = -1;
        }

        public BangDiemModels(string ten, double diemMieng, double diem15_1, double diem15_2, double diem15_3, double diem1t_1,
            double diem1t_2, double diem1t_3, double hocKy)
        {
            Ten = ten;
            DiemMieng = diemMieng;
            _15p_1 = diem15_1;
            _15p_2 = diem15_2;
            _15p_3 = diem15_3;
            _1t_1 = diem1t_1;
            _1t_2 = diem1t_2;
            _1t_3 = diem1t_3;
            HocKy = hocKy;
        }

        public BangDiemModels(DataRow dr)
        {
            Ten = dr["Ten"].ToString();
            DiemMieng = Convert.IsDBNull(dr["DiemMieng"]) ? -1 : Convert.ToDouble(dr["DiemMieng"]);
            _15p_1 = Convert.IsDBNull(dr["15p_1"]) ? -1 : Convert.ToDouble(dr["15p_1"]);
            _15p_2 = Convert.IsDBNull(dr["15p_2"]) ? -1 : Convert.ToDouble(dr["15p_2"]);
            _15p_3 = Convert.IsDBNull(dr["15p_3"]) ? -1 : Convert.ToDouble(dr["15p_3"]);
            _1t_1 = Convert.IsDBNull(dr["1t_1"]) ? -1 : Convert.ToDouble(dr["1t_1"]);
            _1t_2 = Convert.IsDBNull(dr["1t_2"]) ? -1 : Convert.ToDouble(dr["1t_2"]);
            _1t_3 = Convert.IsDBNull(dr["1t_3"]) ? -1 : Convert.ToDouble(dr["1t_3"]);
            HocKy = Convert.IsDBNull(dr["HocKy"]) ? -1 : Convert.ToDouble(dr["HocKy"]);
        }
    }
}