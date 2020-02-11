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



        public TaiKhoanTruong()
        {
            ID = -1;
            TaiKhoan = "";
            MatKhau = "";
        }

        public TaiKhoanTruong(int iD, string taiKhoan, string pass)
        {
            ID = iD;
            TaiKhoan = taiKhoan;
            MatKhau = pass;
        }

        public TaiKhoanTruong(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TaiKhoan = dr["TaiKhoan"].ToString();
            MatKhau = dr["MatKhau"].ToString(); ;
        }
    }
}
