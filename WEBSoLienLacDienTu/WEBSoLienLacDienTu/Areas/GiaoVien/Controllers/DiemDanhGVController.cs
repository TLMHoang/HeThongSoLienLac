using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    public class DiemDanhGVController : Controller
    {
        // GET: GiaoVien/DiemDanhGV
        public async Task<ActionResult> Index()
        {
            List<ThongTinHS> lst = new List<ThongTinHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDLop(HomeGiaoVienController.TK.IDLop)).Rows)
            {
                lst.Add(new ThongTinHS(dr));
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
        public async Task<JsonResult> ThemVang(DiemDanh dd)
        {
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
            ThongTinHS tt = new ThongTinHS();
            DataTable dt = await new ThongTinHSDAL().LayDT(ID);
            tt = new ThongTinHS(dt.Rows[0]);
            return Json(tt, JsonRequestBehavior.AllowGet);
        }
    }
}