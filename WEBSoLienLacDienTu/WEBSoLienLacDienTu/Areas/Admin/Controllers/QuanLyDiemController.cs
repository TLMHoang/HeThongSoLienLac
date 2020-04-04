using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.Admin.Code;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    public class QuanLyDiemController : Controller
    {
        // GET: Admin/QuanLyDiem
        public ActionResult Index()
        {
            return View();
        }
    }
}