using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class LKPHvsHS
    {
        public int ID { get; set; }
        //public int IDHocSinh { get; set; }
        public string Ten { get; set; }
        
        public LKPHvsHS()
        {
            ID = -1;
            //IDHocSinh = -1;
            Ten = "";
            


        }

        public LKPHvsHS(int IDTK, string ten)
        {
            ID = IDTK;
            //IDHocSinh = IDHS;
            Ten = ten;
            

        }
        public LKPHvsHS(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);           
            Ten = dr["Ten"].ToString();
            
        }
    }
}
