using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Home;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class XinPhep1Controller : Controller
    {
        // GET: XinPhep1
        public ActionResult Index()
        {
            return View();
        }
    }
}