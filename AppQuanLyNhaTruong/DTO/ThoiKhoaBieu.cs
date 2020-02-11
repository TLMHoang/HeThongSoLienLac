using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThoiKhoaBieu
    {
		public int IDLop { get; set; }
		public int Thu { get; set; }
		public string Tiet1 { get; set; }
		public string Tiet2 { get; set; }
		public string Tiet3 { get; set; }
		public string Tiet4 { get; set; }
		public string Tiet5 { get; set; }
		public string Tiet6 { get; set; }
		public string Tiet7 { get; set; }
		public string Tiet8 { get; set; }
		public string Tiet9 { get; set; }
		public string Tiet10 { get; set; }

		public ThoiKhoaBieu() { IDLop = -1; Thu = -1; Tiet1 = Tiet2 = Tiet3 = Tiet4 = Tiet5 = Tiet6 = Tiet7 = Tiet8 = Tiet9 = Tiet10 = ""; }

		public ThoiKhoaBieu(int iDLop, int thu, string tiet1, string tiet2, string tiet3, string tiet4, string tiet5, string tiet6, string tiet7, string tiet8, string tiet9, string tiet10)
		{
			IDLop = iDLop;
			Thu = thu;
			Tiet1 = tiet1;
			Tiet2 = tiet2;
			Tiet3 = tiet3;
			Tiet4 = tiet4;
			Tiet5 = tiet5;
			Tiet6 = tiet6;
			Tiet7 = tiet7;
			Tiet8 = tiet8;
			Tiet9 = tiet9;
			Tiet10 = tiet10;
		}

		public ThoiKhoaBieu(DataRow dr)
		{
			IDLop = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			Thu = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			Tiet1 = dr["Tiet1"].ToString();
			Tiet2 = dr["Tiet2"].ToString();
			Tiet3 = dr["Tiet3"].ToString();
			Tiet4 = dr["Tiet4"].ToString();
			Tiet5 = dr["Tiet5"].ToString();
			Tiet6 = dr["Tiet6"].ToString();
			Tiet7 = dr["Tiet7"].ToString();
			Tiet8 = dr["Tiet8"].ToString();
			Tiet9 = dr["Tiet9"].ToString();
			Tiet10 = dr["Tiet10"].ToString();
		}
	}
}
