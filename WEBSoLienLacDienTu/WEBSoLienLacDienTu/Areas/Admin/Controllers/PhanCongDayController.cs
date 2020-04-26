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
        public static MonHoc mh = new MonHoc();
        public static Lop lop = new Lop();
        PhanCongDayDAL pcDAL= new PhanCongDayDAL();
        public static PhanCongDay pc = new PhanCongDay();
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
            lop.ID = id;
            List<LopPhanCongDayModel> lst = new List<LopPhanCongDayModel>();
            foreach (DataRow dr in (await new PhanCongDayDAL().LayDTPhanCongDay_ByIDLop(id)).Rows)
            {
                lst.Add(new LopPhanCongDayModel(dr));
            }
            return View(lst);
        }
        public ActionResult ThemPhanCong(int id)
        {
            mh.ID = id;
            return View(lop);
        }

        public ActionResult CapNhatPhanCong(int id,int idPhanCong)
        {
            mh.ID = id;
            pc.ID = idPhanCong;
            return View(lop);
        }
        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }
        //public async Task LoadDanhSachMon()
        //{
        //    List<SelectListItem> li = new List<SelectListItem>();
        //    li.Add(new SelectListItem { Text = "Tất Cả", Value = "-1" });
        //    foreach (DataRow dr in (await mhDAL.LayDT()).Rows)
        //    {
        //        li.Add(new SelectListItem { Text = dr["TenMon"].ToString(), Value = dr["ID"].ToString() });
        //    }
        //    ViewBag.LstMon = new SelectList(li, "Value", "Text");
        //}

        public async Task<JsonResult> LoadDsgv()
        {
            List<TaiKhoanTruong> lst = new List<TaiKhoanTruong>();
            foreach (DataRow dr in (await new TaiKhoanTruongDAL().LayDT_ByIdMon(mh.ID)).Rows)
            {
                lst.Add(new TaiKhoanTruong(dr));
            }

            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> ThemMoiPhanCong(int ID)
        {
            return Json(await pcDAL.Them(new PhanCongDay(-1, ID, lop.ID)), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> CapNhatPhanCong1(int ID)
        {
            return Json(await pcDAL.CapNhap(new PhanCongDay(pc.ID, ID, -1)), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> XoaPhanCong(int ID)
        {
            return Json(await pcDAL.Xoa(ID), JsonRequestBehavior.AllowGet);
        }
    }
}