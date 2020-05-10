using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class ThongTinHSLienKetModel
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public int IDLop { get; set; }
        public string TenLop { get; set; }

        public ThongTinHSLienKetModel()
        {
            ID = -1;
            Ten = "";
            IDLop = -1;
            TenLop = "";
        }

        public ThongTinHSLienKetModel(int id, string ten,int idLop, string tenLop)
        {
            ID = id;
            Ten = ten;
            IDLop = IDLop;
            TenLop = tenLop;
        }

        public ThongTinHSLienKetModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            TenLop = dr["TenLop"].ToString();
        }
    }
}