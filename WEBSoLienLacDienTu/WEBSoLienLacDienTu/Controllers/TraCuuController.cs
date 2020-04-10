using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Home;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class TraCuuController : Controller
    {
        // GET: TraCuu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GVBM()
        {
            return View();
        }
    }
}