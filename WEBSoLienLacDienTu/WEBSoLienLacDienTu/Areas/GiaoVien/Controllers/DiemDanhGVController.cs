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

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    [SessionTimeout]
    public class DiemDanhGVController : Controller
    {
        // GET: GiaoVien/DiemDanhGV
        public async Task<ActionResult> Index()
        {
            List<DiemDanh_PostNotificationModel> lst = new List<DiemDanh_PostNotificationModel>();
            if (HomeGiaoVienController.TK.IDLop == -1)
            {
                ViewBag.ThongBao = "Xin Lỗi Bạn Không Phải GVCN !";
                return View();
            }
            else
            {
                foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_Notification(HomeGiaoVienController.TK.IDLop)).Rows)
                {
                    lst.Add(new DiemDanh_PostNotificationModel(dr));
                }
                return View(lst);
            }
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
        public async Task<JsonResult> ThemVang(DiemDanh dd, string User_PH)
        {
            var postNotification = new PostNotification(User_PH, "Notification !", "New Notification!", "Thông Báo Mới !",
                "Bạn Có 1 Thông Báo Mới !");
            return Json(await new DiemDanhDAL().Them(dd), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> CapNhatVang(DiemDanh dd)
        {
            return Json(await new DiemDanhDAL().CapNhap(dd), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> XoaVang(int ID)
        {
            return Json(await new DiemDanhDAL().Xoa(ID), JsonRequestBehavior.AllowGet);
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
    }
}