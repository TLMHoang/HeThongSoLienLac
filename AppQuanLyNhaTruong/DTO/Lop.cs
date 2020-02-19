using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        public int ID { get; set; }
        public string TenLop { get; set; }
        //public int IDGiaoVien { get; set; }

        public Lop() { ID = -1; TenLop = ""; }

        public Lop(int iD, string tenLop, int iDGiaoVien)
        {
            ID = iD;
            TenLop = tenLop;
            //IDGiaoVien = iDGiaoVien;
        }

        public Lop(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]); 
            TenLop = dr["Lop"].ToString();
            //IDGiaoVien = Convert.IsDBNull(dr["IDGiaoVien"]) ? -1 : Convert.ToInt32(dr["IDGiaoVien"]);
        }
    }
}
