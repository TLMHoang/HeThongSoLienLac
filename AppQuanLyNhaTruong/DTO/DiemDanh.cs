using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDanh
    {
		public int STT { get; set; }
		public int IDHocSinh { get; set; }
		public DateTime NgayNghi { get; set; }
		public byte Phep { get; set; }

		public DiemDanh()
		{
			STT = -1;
			IDHocSinh = -1;
			NgayNghi = DateTime.Now;
			Phep = 0;
		}

		public DiemDanh(int sTT, int iDHocSinh, DateTime ngayNghi, byte phep)
		{
			STT = sTT;
			IDHocSinh = iDHocSinh;
			NgayNghi = ngayNghi;
			Phep = phep;
		}

		public DiemDanh(DataRow dr)
		{
			STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
			IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			NgayNghi = Convert.ToDateTime(dr["NgayNghi"]);
			Phep = Convert.ToByte(dr["Phep"]);
		}
	}
}
