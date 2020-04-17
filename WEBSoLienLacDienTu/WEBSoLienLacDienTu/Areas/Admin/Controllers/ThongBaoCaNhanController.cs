using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public class ThongBaoCaNhanController : Controller
    {
        public static int idhs;
        public static Lop lop = new Lop();
        public static Lop lop2 = new Lop();
        // GET: Admin/ThongBaoCaNhan

        #region ThongBaoHocSinh

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
        public async Task<ActionResult> DanhSachChiTiet(int id)
        {
            idhs = id;
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
        public async Task<ActionResult> ThemThongBaoHS(int id,FormCollection f)
        {
            ThongBaoHS hs = new ThongBaoHS();
            var noidung = f["text"];
            if (noidung.Length == 0)
            {
                ModelState.AddModelError("","Vui Lòng Nhập Nội Dung !");
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
                        return RedirectToAction("DanhSachChiTiet", "ThongBaoCaNhan", new {id = idhs});
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
        public async Task<ActionResult> CapNhatThongBaoHS(int id,ThongBaoHS tbhs)
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
                        return RedirectToAction("DanhSachChiTiet", "ThongBaoCaNhan", new { id = idhs });
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
            lop2.ID = id;
            List<ThongBaoLop> lst = new List<ThongBaoLop>();
            foreach (DataRow dr in (await new ThongBaoLopDAL().LayDT_TheoLop(id)).Rows)
            {
                lst.Add(new ThongBaoLop(dr));
            }
            return View(lst);
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
                ModelState.AddModelError("","Vui Lòng Nhập Nội Dung Thông Báo !");
            }
            else
            {
                if (await new ThongBaoLopDAL().Them(lop2.ID, noidung, DateTime.Now, 1) != 0)
                {
                    return RedirectToAction("ThongBaoLop", "ThongBaoCaNhan", new { id = lop2.ID });
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
        public async Task<ActionResult> CapNhatThongBaoLop(int id,ThongBaoLop tbl)
        {
            if (tbl.NoiDung.Length == 0)
            {
                ModelState.AddModelError("","Vui Lòng Nhập Nội Dung!");
            }
            else
            {
                try
                {
                    if (await new ThongBaoLopDAL().CapNhap(tbl) != 0)
                    {
                        return RedirectToAction("ThongBaoLop", "ThongBaoCaNhan", new { id = lop2.ID });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return View();
        }

        public async Task<JsonResult> XoaThongBaoLop(int id)
        {
            return Json(await new ThongBaoLopDAL().Xoa(id), JsonRequestBehavior.AllowGet);
        }
        

        #endregion

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

        public async Task<JsonResult> LoadTenLopByID(int ID)
        {
            GetNameClassModel tt = new GetNameClassModel();
            DataTable dt = await new LopDAL().LayTenLop(ID);
            tt = new GetNameClassModel(dt.Rows[0]);
            return Json(tt, JsonRequestBehavior.AllowGet);
        }
    }
}