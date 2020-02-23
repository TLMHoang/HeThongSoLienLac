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
		public int Tiet { get; set; }

		public CupHoc()
		{
			STT = -1;
			IDHocSinh = -1;
			Ngay = DateTime.Now;
			Tiet = -1;
		}
		public CupHoc(int sTT, int iDHocSinh, DateTime ngay, int tiet)
		{
			STT = sTT;
			IDHocSinh = iDHocSinh;
			Ngay = ngay;
			Tiet = tiet;

		}

		public CupHoc(DataRow dr)
		{
			STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
			IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			Ngay = Convert.ToDateTime(dr["Ngay"]);
			Tiet = Convert.IsDBNull(dr["Tiet"]) ? -1 : Convert.ToInt32(dr["Tiet"]);
		}
	}
}
