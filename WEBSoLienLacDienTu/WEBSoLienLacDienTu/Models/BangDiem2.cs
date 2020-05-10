using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class BangDiem2
    {
        //public int MaHS { get; set; }
        public string Ten { get; set; }
        public double Diem { get; set; }

        public BangDiem2()
        {
            //MaHS = -1;
            Ten = "";
            Diem = -1;
        }

        public BangDiem2(/*int maHs,*/ string ten, int diem)
        {
            //MaHS = maHs;
            Ten = ten;
            Diem = diem;
        }

        public BangDiem2(DataRow dr)
        {
            //MaHS = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            Diem = Convert.IsDBNull(dr["Diem"]) ? -1 : Convert.ToDouble(dr["Diem"]);
        }
    }
}