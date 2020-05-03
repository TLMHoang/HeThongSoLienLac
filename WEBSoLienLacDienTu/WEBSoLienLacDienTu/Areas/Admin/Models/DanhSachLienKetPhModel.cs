using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class DanhSachLienKetPhModel
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string TaiKhoan { get; set; }

        public DanhSachLienKetPhModel()
        {
            ID = -1;
            Ten = "";
            TaiKhoan = "";
        }

        public DanhSachLienKetPhModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            TaiKhoan = dr["TaiKhoan"].ToString();
        }
    }
}