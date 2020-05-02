using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;
using PagedList;
using WEBSoLienLacDienTu.Areas.Admin.Code;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    [SessionAuthorize]
    public class TaiKhoanPHController : Controller
    {
        TaiKhoanPhDal tkphDal = new TaiKhoanPhDal();
        // GET: Admin/TaiKhoanPH
        [HttpGet]
        public async Task<ActionResult> Index(int? page)
        {
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            IPagedList<TaiKhoanPH> pLstTKPH = null;
            List<TaiKhoanPH> LstTKPH = await tkphDal.LayLst();
            pLstTKPH = LstTKPH.ToPagedList(pageIndex, pageSize);
            return View(pLstTKPH);
        }

        public ActionResult ThemTaiKhoanPH()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ThemTaiKhoanPH(FormCollection f)
        {
            string taiKhoan = f["TenTk"];
            string tenMe = f["TenMe"];
            string sdtMe = f["SDTMe"];
            string tenBo = f["TenBo"];
            string sdtBo = f["SDTBo"];
            try
            {
                if (await tkphDal.CheckExist(taiKhoan) == 1)
                {
                    ModelState.AddModelError("","Tài Khoản Đã Tồn Tại !");
                }
                else
                {
                    if (await tkphDal.Them(new TaiKhoanPH(-1, taiKhoan, taiKhoan, tenMe, sdtMe, tenBo, sdtBo)) != 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Tạo Mới Thất Bại !");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }

        public async Task<ActionResult> CapNhatTKPH(int id)
        {
            TaiKhoanPH tk = new TaiKhoanPH();
            DataTable dt = await tkphDal.LayDT(id);
            tk = new TaiKhoanPH(dt.Rows[0]);
            return View(tk);
        }

        [HttpPost]
        public async Task<ActionResult> CapNhatTKPH(int id, TaiKhoanPH tkph)
        {
            try
            {
                if (await tkphDal.CapNhapTT(tkph) != 0)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }

        public async Task<JsonResult> XoaTKPH(int id)
        {
            return Json(await tkphDal.Xoa(id), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> ResetPass(int ID)
        {
            return Json(await tkphDal.ResetPass(ID), JsonRequestBehavior.AllowGet);
        }
    }
}