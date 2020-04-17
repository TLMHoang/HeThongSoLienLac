using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using WEBSoLienLacDienTu.Areas.GiaoVien.Code;


namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{

    [SessionAuthorize]
    public class ThongBaoCaNhanGVController : Controller
    {
        // GET: GiaoVien/ThongBaoCaNhan
        public async Task<ActionResult> Index()
        {
            List<ThongBaoLop> lst = new List<ThongBaoLop>();
            foreach (DataRow dr in (await new ThongBaoLopDAL().LayDT_TheoLop(HomeGiaoVienController.TK.IDLop)).Rows)
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
    }
}