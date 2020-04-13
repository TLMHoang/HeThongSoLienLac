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
    public class ThongBaoCaNhanController : Controller
    {
        public static Lop lop = new Lop();
        // GET: Admin/ThongBaoCaNhan
        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(GetClassModel lop)
        {
            if (lop.ID == -10 || lop.IDKhoi == 0)
            {
                await LoadListKhoi();
                ViewData["Loi"] = "Vui Lòng Chọn Đầy Đủ Thông Tin !";
            }
            else
            {
                return RedirectToAction("ThongBaoHocSinh", "ThongBaoCaNhan", new { id = lop.ID });
            }
            return View();
        }
        public async Task<ActionResult> Index2()
        {
            await LoadListKhoi();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index2(GetClassModel lop)
        {
            if (lop.ID == -10 || lop.IDKhoi == 0)
            {
                await LoadListKhoi();
                ViewData["Loi"] = "Vui Lòng Chọn Đầy Đủ Thông Tin !";
            }
            else
            {
                return RedirectToAction("ThongBaoLop", "ThongBaoCaNhan", new { id = lop.ID });
            }
            return View();
        }
        public async Task<ActionResult> ThongBaoLop(int id)
        {
            List<ThongBaoLop> lst = new List<ThongBaoLop>();
            foreach (DataRow dr in (await new ThongBaoLopDAL().LayDT_TheoLop(id)).Rows)
            {
                lst.Add(new ThongBaoLop(dr));
            }
            return View(lst);
        }

        public async Task<ActionResult> ThongBaoHocSinh(int id)
        {
            lop.ID = id;
            List<ThongTinHS> lst = new List<ThongTinHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDLop(id)).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }
            return View(lst);
        }

        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }

        public async Task<JsonResult> LoadListLop(int IdKhoi)
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "Vui Lòng Chọn Lớp", Value = "-10" });
            foreach (DataRow dr in (await new LopDAL().LayDTLopTheoKhoi(IdKhoi)).Rows)
            {
                li.Add(new SelectListItem { Text = dr["TenLop"].ToString(), Value = dr["ID"].ToString() });
            }
            return Json(li, JsonRequestBehavior.AllowGet);
        }
    }
}