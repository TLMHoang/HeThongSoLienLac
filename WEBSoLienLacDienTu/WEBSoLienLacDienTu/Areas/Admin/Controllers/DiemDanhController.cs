using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using DAL;
using DTO;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    [SessionAuthorize]
    public class DiemDanhController : Controller
    {
        // GET: Admin/DiemDanh
        public static Lop lop = new Lop();
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
                return RedirectToAction("Vang", "DiemDanh", new { id = lop.ID });
            }
            return View();
        }

        public async Task<ActionResult> Vang(int id)
        {
            lop.ID = id;
            List<DiemDanh_PostNotificationModel> lst = new List<DiemDanh_PostNotificationModel>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_Notification(id)).Rows)
            {
                lst.Add(new DiemDanh_PostNotificationModel(dr));
            }
            return View(lst);
        }

        public async Task<ActionResult> ChiTietVang(int id)
        {
            List<DiemDanh> lst = new List<DiemDanh>();
            foreach (DataRow dr in (await new DiemDanhDAL().DanhSachDiemDanh(id)).Rows)
            {
                lst.Add(new DiemDanh(dr));
            }
            return View(lst);
        }

        public async Task<JsonResult> ThemVang(DiemDanh dd,int User_PH)
        {
            new PostNotification(User_PH.ToString(),"Notification !","New Notification!","Thông Báo Mới !","Bạn Có 1 Thông Báo Mới !");
            return Json( await new DiemDanhDAL().Them(dd), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> CapNhatVang(DiemDanh dd)
        {
            return Json(await new DiemDanhDAL().CapNhap(dd), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> XoaVang(int ID)
        {
            return Json(await new DiemDanhDAL().Xoa(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult CupHoc()
        {
            return View();
        }

        public async Task<JsonResult> getByIdDiemDanh(int ID)
        {
            DiemDanh tt = new DiemDanh();
            DataTable dt = await new DiemDanhDAL().LayDT(ID);
            tt = new DiemDanh(dt.Rows[0]);
            return Json(tt, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> getById(int ID)
        {
            DiemDanh_PostNotificationModel tt = new DiemDanh_PostNotificationModel();
            DataTable dt = await new ThongTinHSDAL().LayDTHS_Notification(ID);
            tt = new DiemDanh_PostNotificationModel(dt.Rows[0]);
            return Json(tt, JsonRequestBehavior.AllowGet);
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