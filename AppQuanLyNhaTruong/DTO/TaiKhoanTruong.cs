using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanTruong
    {
        public int ID { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public byte? Loai { get; set; }



        public TaiKhoanTruong()
        {
            ID = -1;
            TaiKhoan = "";
            MatKhau = "";
            Loai = 0;
        }

        public TaiKhoanTruong(int iD, string taiKhoan, string pass, byte? loai)
        {
            ID = iD;
            TaiKhoan = taiKhoan;
            MatKhau = pass;
            Loai = loai;

        }

        public TaiKhoanTruong(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TaiKhoan = dr["TaiKhoan"].ToString();
            MatKhau = dr["MatKhau"].ToString(); ;
            Loai = Convert.ToByte(dr["Loai"]);
        }
    }
}
