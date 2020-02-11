using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XinPhep
    {
		public int STT { get; set; }
		public int IDHocSinh { get; set; }
		public DateTime NghiTu { get; set; }
		public DateTime NghiDen { get; set; }
		public int SoNgayNghi { get; set; }

		public XinPhep()
		{
			STT = -1;
			IDHocSinh = -1;
			NghiTu = DateTime.Now;
			NghiDen = DateTime.Now;
			SoNgayNghi = -1;
		}

		public XinPhep(int sTT, int iDHocSinh, DateTime nghiTu, DateTime nghiDen, int soNgayNghi, byte phep)
		{
			STT = sTT;
			IDHocSinh = iDHocSinh;
			NghiTu = nghiTu;
			NghiDen = nghiDen;
			SoNgayNghi = soNgayNghi;
		}

		public XinPhep(DataRow dr)
		{
			STT = Convert.IsDBNull(dr["STT"]) ? -1 : Convert.ToInt32(dr["STT"]);
			IDHocSinh = Convert.IsDBNull(dr["IDHocSinh"]) ? -1 : Convert.ToInt32(dr["IDHocSinh"]);
			NghiTu = Convert.ToDateTime(dr["NghiTu"]);
			NghiDen = Convert.ToDateTime(dr["NghiDen"]);
			SoNgayNghi = Convert.IsDBNull(dr["SoNgayNghi"]) ? -1 : Convert.ToInt32(dr["SoNgayNghi"]);
		}
	}
}
