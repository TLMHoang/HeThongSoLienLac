using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    public class QRController : Controller
    {
        // GET: Admin/QR
        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            return View();
        }
        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }
    }
}