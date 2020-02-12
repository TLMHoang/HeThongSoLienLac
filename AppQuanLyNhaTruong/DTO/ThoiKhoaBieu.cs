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
		public int Tiet { get; set; }
		public int IDMon { get; set; }


		public ThoiKhoaBieu() { IDLop = -1; Thu = -1; Tiet = -1; IDMon = -1; }

		public ThoiKhoaBieu(DataRow dr)
		{
			IDLop = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			Thu = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			Tiet = Convert.IsDBNull(dr["Tiet"]) ? -1 : Convert.ToInt32(dr["Tiet"]);
			IDMon = Convert.IsDBNull(dr["IDMon"]) ? -1 : Convert.ToInt32(dr["IDMon"]);
		}

		public ThoiKhoaBieu(int iDLop, int thu, int tiet, int iDMon)
		{
			IDLop = iDLop;
			Thu = thu;
			Tiet = tiet;
			IDMon = iDMon;
		}
	}
}
