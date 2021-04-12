using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model;

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
        [HttpPost]
        public ActionResult Login_TaiLieuONL(Login_HocSinhModel hs)
        {
            return RedirectToAction("Index");

        public ActionResult Selected_Subject_Student()
        {
            return View();
        }
        public ActionResult Test_Student()
        {
            return View();
        }
    }
}