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

    [Code.SessionAuthorize]
    public class ThongBaoCaNhanGVController : Controller
    {
        // GET: GiaoVien/ThongBaoCaNhan
        public static int idhs;
        public static int User_Ph;
        #region ThongBaoHocSinh

        public async Task<ActionResult> Index2()
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
        public async Task<ActionResult> DanhSachChiTiet(int id,int idPH)
        {
            idhs = id;
            User_Ph = idPH;
            List<ThongBaoHS> lst = new List<ThongBaoHS>();
            foreach (DataRow dr in (await new ThongBaoHSDAL().LayDT_TheoIDHS(id)).Rows)
            {
                lst.Add(new ThongBaoHS(dr));
            }
            return View(lst);
        }
        public ActionResult ThemThongBaoHS(int id)
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ThemThongBaoHS(int id, FormCollection f)
        {
            ThongBaoHS hs = new ThongBaoHS();
            var noidung = f["text"];
            if (noidung.Length == 0)
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Nội Dung !");
            }
            else
            {
                try
                {
                    hs.IDHocSinh = id;
                    hs.NoiDung = noidung;
                    hs.Ngay = DateTime.Now;
                    hs.IDLoaiThongBao = 1;
                    
                    if (await new ThongBaoHSDAL().Them(hs) != 0)
                    {
                        var postNotification = new PostNotification(User_Ph.ToString(), "Notification !", "New Notification!", "Thông Báo Mới !",
                            "Bạn Có 1 Thông Báo Mới !");
                        return RedirectToAction("DanhSachChiTiet", "ThongBaoCaNhanGV", new { id = idhs });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return View();
        }

        public async Task<ActionResult> CapNhatThongBaoHS(int id)
        {
            ThongBaoHS tbhs = new ThongBaoHS();
            DataTable dt = await new ThongBaoHSDAL().LayDT(id);
            tbhs = new ThongBaoHS(dt.Rows[0]);
            return View(tbhs);
        }
        [HttpPost]
        public async Task<ActionResult> CapNhatThongBaoHS(int id, ThongBaoHS tbhs)
        {
            if (tbhs.NoiDung.Length == 0)
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Nội Dung!");
            }
            else
            {
                try
                {
                    if (await new ThongBaoHSDAL().CapNhap(tbhs) != 0)
                    {
                        return RedirectToAction("DanhSachChiTiet", "ThongBaoCaNhanGV", new { id = idhs });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return View();
        }
        public async Task<JsonResult> XoaThongBaoHS(int id)
        {
            return Json(await new ThongBaoHSDAL().Xoa(id), JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> getById(int ID)
        {
            ThongTinHS tt = new ThongTinHS();
            DataTable dt = await new ThongTinHSDAL().LayDT(ID);
            tt = new ThongTinHS(dt.Rows[0]);
            return Json(tt, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region ThongBaoLop
        public async Task<ActionResult> Index()
        {
            List<ThongBaoLop> lst = new List<ThongBaoLop>();
            if (HomeGiaoVienController.TK.IDLop == -1)
            {
                ViewBag.ThongBao = "Xin Lỗi Bạn Không Phải GVCN !";
                return View();
            }
            else
            {
                foreach (DataRow dr in (await new ThongBaoLopDAL().LayDT_TheoLop(HomeGiaoVienController.TK.IDLop)).Rows)
                {
                    lst.Add(new ThongBaoLop(dr));
                }
                return View(lst);
            }
        }
        public ActionResult ThemThongBaoLop()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ThemThongBaoLop(FormCollection f)
        {
            var noidung = f["text"];
            if (noidung.Length == 0)
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Nội Dung Thông Báo !");
            }
            else
            {
                if (await new ThongBaoLopDAL().Them(HomeGiaoVienController.TK.IDLop, noidung, DateTime.Now, 1) != 0)
                {
                    return RedirectToAction("Index", "ThongBaoCaNhanGV", new { area="GiaoVien" });
                }
            }
            return View();
        }

        public async Task<ActionResult> CapNhatThongBaoLop(int id)
        {
            ThongBaoLop tbl = new ThongBaoLop();
            DataTable dt = await new ThongBaoLopDAL().LayDT(id);
            tbl = new ThongBaoLop(dt.Rows[0]);
            return View(tbl);
        }
        [HttpPost]
        public async Task<ActionResult> CapNhatThongBaoLop(int id, ThongBaoLop tbl)
        {
            if (tbl.NoiDung.Length == 0)
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Nội Dung!");
            }
            else
            {
                try
                {
                    if (await new ThongBaoLopDAL().CapNhap(tbl) != 0)
                    {
                        return RedirectToAction("Index", "ThongBaoCaNhanGV");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return View();
        }

        public async Task<JsonResult> XoaThongBaoLopGV(int id)
        {
            return Json(await new ThongBaoLopDAL().Xoa(id), JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> LoadTenLopByID()
        {
            GetNameClassModel tt = new GetNameClassModel();
            DataTable dt = await new LopDAL().LayTenLop(HomeGiaoVienController.TK.IDLop);
            tt = new GetNameClassModel(dt.Rows[0]);
            return Json(tt, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}