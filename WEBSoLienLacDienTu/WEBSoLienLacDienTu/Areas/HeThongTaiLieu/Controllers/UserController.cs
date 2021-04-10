using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Controllers
{
    public class UserController : Controller
    {
        // GET: HeThongTaiLieu/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login_TaiLieuONL()
        {
            return View();
        }
    }
}