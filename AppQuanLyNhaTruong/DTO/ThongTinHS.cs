using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class ThongTinHS
    {
		public int ID { get; set; }
		public string Ten { get; set; }
		public DateTime NgaySinh { get; set; }
		public byte GioiTinh { get; set; }
		public string NoiSinh { get; set; }
		public string DanToc { get; set; }
		public string TonGiao { get; set; }
		public int IDLop { get; set; }
		public int IDTaiKhoan { get; set; }
		public string TenMe { get; set; }
		public string SDTMe { get; set; }
		public string TenBo { get; set; }
		public string SDTBo { get; set; }

		public ThongTinHS()
		{
			ID = -1;
			Ten = "";
			NgaySinh = DateTime.Now;
			GioiTinh = 0;
			NoiSinh = "";
			DanToc = "";
			TonGiao = "";
			IDLop = -1;
			IDTaiKhoan = -1;
			TenMe = "";
			SDTMe = "";
			TenBo = "";
			SDTBo = "";
		}

		public ThongTinHS(int iD, string ten, DateTime ngaySinh, byte gioiTinh, string noiSinh, string danToc, string tonGiao, int iDLop, int iDTaiKhoan, string tenMe, string sDTMe, string tenBo, string sDTBo)
		{
			ID = iD;
			Ten = ten;
			NgaySinh = ngaySinh;
			GioiTinh = gioiTinh;
			NoiSinh = noiSinh;
			DanToc = danToc;
			TonGiao = tonGiao;
			IDLop = iDLop;
			IDTaiKhoan = iDTaiKhoan;
			TenMe = tenMe;
			SDTMe = sDTMe;
			TenBo = tenBo;
			SDTBo = sDTBo;
		}

		public ThongTinHS(DataRow dr)
		{
			ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
			Ten = dr["Ten"].ToString();
			NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
			GioiTinh = Convert.ToByte(dr["GioiTinh"]);
			NoiSinh = dr["NoiSinh"].ToString();
			DanToc = dr["DanToc"].ToString();
			TonGiao = dr["TonGiao"].ToString();
			IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
			IDTaiKhoan = Convert.IsDBNull(dr["IDTaiKhoan"]) ? -1 : Convert.ToInt32(dr["IDTaiKhoan"]);
			TenMe = dr["TenMe"].ToString();
			SDTMe = dr["SDTMe"].ToString();
			TenBo = dr["TenBo"].ToString();
			SDTBo = dr["SDTBo"].ToString();
		}
	}
}
