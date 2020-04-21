using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    [SessionAuthorize]
    public class PhanCongDayController : Controller
    {
        // GET: Admin/PhanCongDay
        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        public async Task<ActionResult> PhanCong(int id)
        {
            List<LopPhanCongDayModel> lst = new List<LopPhanCongDayModel>();
            foreach (DataRow dr in (await new PhanCongDayDAL().LayDTPhanCongDay_ByIDLop(id)).Rows)
            {
                lst.Add(new LopPhanCongDayModel(dr));
            }
            return View(lst);
        }
        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }
        
    }
}