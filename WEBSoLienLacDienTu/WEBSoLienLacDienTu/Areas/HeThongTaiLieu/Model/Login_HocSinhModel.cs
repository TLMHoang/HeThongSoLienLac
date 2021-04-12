using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model
{
    public class Login_HocSinhModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Login_HocSinhModel()
        {

        }
        public Login_HocSinhModel(int iD,string userName,string passWord)
        {
            ID = iD;
            UserName = userName;
            PassWord = passWord;
        }
        public Login_HocSinhModel(DataRow data)
        {
            
        }
    }
}