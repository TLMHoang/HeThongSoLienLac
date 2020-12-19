using System;
using System.Collections.Generic;
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
        public NoiDungChat()
        {
            ID = -1;
            IDKhachHang = -1;
            ThoiGian = DateTime.Now;
            NoiDung = "";
        }
        public NoiDungChat(int iD,int idKhachHang,DateTime thoiGian,string noiDung)
        {
            ID = iD;
            IDKhachHang = idKhachHang;
            ThoiGian = thoiGian;
            NoiDung = noiDung;
        }
    }
}
