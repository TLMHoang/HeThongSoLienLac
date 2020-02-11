using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CupHoc
    {
		public int STT { get; set; }
		public int IDHocSinh { get; set; }
		public DateTime Ngay { get; set; }
		public int NghiTu { get; set; }
		public int NghiDen { get; set; }
		public int SoTietNghi { get; set; }

		public CupHoc()
		{
			STT = -1;
			IDHocSinh = -1;
			Ngay = DateTime.Now;
			NghiTu = -1;
			NghiDen = -1;
			SoTietNghi = -1;
		}
		public CupHoc(int sTT, int iDHocSinh, DateTime ngay, int nghiTu, int nghiDen, int soTietNghi)
		{
			STT = sTT;
			IDHocSinh = iDHocSinh;
			Ngay = ngay;
			NghiTu = nghiTu;
			NghiDen = nghiDen;
			SoTietNghi = soTietNghi;
		}

		public CupHoc(DataRow dr)
		{
			STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
			IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			Ngay = Convert.ToDateTime(dr["Ngay"]);
			NghiTu = Convert.IsDBNull(dr["NghiTu"]) ? -1 : Convert.ToInt32(dr["NghiTu"]);
			NghiDen = Convert.IsDBNull(dr["NghiDen"]) ? -1 : Convert.ToInt32(dr["NghiDen"]);
			SoTietNghi = Convert.IsDBNull(dr["SoNgayNghi"]) ? -1 : Convert.ToInt32(dr["SoNgayNghi"]);
		}
	}
}
