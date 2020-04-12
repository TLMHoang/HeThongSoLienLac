using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using DAL;
//using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    //[SessionTimeout]
   
    public class HocPhiController : Controller
    {
        public static Lop lop = new Lop();
        // GET: Admin/HocPhi
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
                return RedirectToAction("loadData", "HocPhi", new { id = lop.ID });
            }
            return View();
        }
        private async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }

        public async Task<ActionResult> AddHP()
        {
            await LoadLoaiHocSinh();
            return View();
        }

        private async Task LoadLoaiHocSinh()
        {
            ViewBag.LstLoaiHocSinh = new SelectList(await new LoaiHocSinhDAL().LayLst(), "ID", "TenLoai");
        }

        public async Task<ActionResult>  loadData(int id)
        {
            lop.ID = id;
            List<TienHocPhi> lst = new List<TienHocPhi>();
            foreach (DataRow dr in (await new ThongTinHocPhiDAL().LayDT(id)).Rows)
            {
                lst.Add(new TienHocPhi(dr));
            }
            return View(lst);
        }
        
        [HttpPost]
        public async Task<ActionResult> AddHP(TienHocPhi hp)
        {
            if (await new ThongTinHocPhiDAL().ThemHp(hp.Thang,hp.IDKhoi,hp.IDLoaiHocSinh, hp.SoNgayHoc, hp.TienHoc, hp.TienAn, hp.TienDien, hp.TienNuoc, hp.TienVeSinh ,hp.TienTrangThietBi,hp.TienTaiLieu) != 0)
            {
                return RedirectToAction("loadData", "HocPhi", new { id = lop.ID });
            }
            else
            {
                ModelState.AddModelError("", "Thêm Không Thành Công,Vui Lòng Nhập Đủ Thông Tin !");
                await LoadLoaiHocSinh();
            }

            return View();
        }
        public async Task<ActionResult> UpdateHP(int id)
        {
            DataTable dt = new DataTable();
            dt = await new ThongTinHocPhiDAL().LayDT(id);
            TienHocPhi tt = new TienHocPhi(dt.Rows[0]);
            await LoadLoaiHocSinh();
            return View(tt);
        }
        public async Task<ActionResult> CapNhat(int id,TienHocPhi hp)
        {
            if (await new ThongTinHocPhiDAL().CapNhatHp(hp.Thang, hp.IDKhoi, hp.IDLoaiHocSinh, hp.SoNgayHoc, hp.TienHoc, hp.TienAn, hp.TienDien, hp.TienNuoc, hp.TienVeSinh, hp.TienTrangThietBi, hp.TienTaiLieu) != 0)
            {
                return RedirectToAction("loadData", "HocPhi", new { id = lop.ID });
            }
            else
            {
                ModelState.AddModelError("", "Thêm Không Thành Công,Vui Lòng Nhập Đủ Thông Tin !");
                await LoadLoaiHocSinh();
            }

            return View();
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