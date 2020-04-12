using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Home;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class XemDiemController : Controller
    {
        // GET: XemDiem
        public ActionResult Index()
        {
            return View();
        }
    }
}