using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class DanhSachBangDiemTheoMonModel
    {
        public string TenMon { get; set; }
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

        public DanhSachBangDiemTheoMonModel(DataRow dr)
        {
            TenMon= dr["TenMon"].ToString();
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
        }
    }
}