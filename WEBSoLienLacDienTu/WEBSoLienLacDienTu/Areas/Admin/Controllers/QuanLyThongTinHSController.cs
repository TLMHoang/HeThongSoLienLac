using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.Admin.Code;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    public class QuanLyThongTinHSController : Controller
    {
        // GET: Admin/QuanLyThongTinHS
        public ActionResult Index()
        {
            return View();
        }
    }
}