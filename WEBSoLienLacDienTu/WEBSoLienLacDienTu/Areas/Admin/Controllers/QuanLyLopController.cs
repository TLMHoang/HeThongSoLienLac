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
    public class QuanLyLopController : Controller
    {
        // GET: Admin/QuanLyLop
        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            return View();
        }
        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }
        public async Task<JsonResult> LoadData(int iDKhoi)
        {
            List<Lop> lst = new List<Lop>();
            foreach (DataRow dr in (await new LopDAL().LayDTLopTheoKhoi(iDKhoi)).Rows)
            {
                lst.Add(new Lop(dr));
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> ThemLop(Lop lop)
        {
            return Json(await new LopDAL().Them(lop), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> CapNhatLop(Lop lop)
        {
            return Json(await new LopDAL().CapNhap(lop), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> XoaLop(int ID)
        {
            return Json(await new LopDAL().Xoa(ID), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> getbyID(int ID)
        {
            Lop lop = new Lop();
            DataTable dt = await new LopDAL().LayDT(ID);
            lop = new Lop(dt.Rows[0]);
            return Json(lop, JsonRequestBehavior.AllowGet);
        }
    }
}