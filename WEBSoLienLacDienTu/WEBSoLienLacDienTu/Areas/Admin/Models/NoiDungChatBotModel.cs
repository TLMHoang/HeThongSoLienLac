using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class NoiDungChatBotModel
    {
        public string NoiDung { get; set; }
        public int SoLan { get; set; }
        public NoiDungChatBotModel(DataRow dr)
        {
            NoiDung = Convert.ToString(dr["noidung"]);
            SoLan = Convert.IsDBNull(dr["SoLan"]) ? -1 : Convert.ToInt32(dr["SoLan"]);
            
        }
    }
}