using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NoiDungChat
    {
        public int ID { get; set; }

        public int IDKhachHang { get; set; }

        public DateTime ThoiGian { get; set; }

        public string NoiDung { get; set; }
        public byte TrangThai { get; set; }
        
        public NoiDungChat()
        {
            ID = -1;
            IDKhachHang = -1;
            ThoiGian = DateTime.Now;
            NoiDung = "";
            TrangThai = 0;
        }
        
        public NoiDungChat(int iD,int idKhachHang,DateTime thoiGian,string noiDung,byte trangThai)
        {
            ID = iD;
            IDKhachHang = idKhachHang;
            ThoiGian = thoiGian;
            NoiDung = noiDung;
            TrangThai = trangThai;
        }
        public NoiDungChat(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDKhachHang = Convert.IsDBNull(dr["IDKhachHang"]) ? -1 : Convert.ToInt32(dr["IDKhachHang"]);
            ThoiGian = Convert.ToDateTime(dr["ThoiGian"]);
            NoiDung = Convert.ToString(dr["ThoiGian"]);
            TrangThai = Convert.ToByte(dr["TrangThai"]);
        }
    }
}
