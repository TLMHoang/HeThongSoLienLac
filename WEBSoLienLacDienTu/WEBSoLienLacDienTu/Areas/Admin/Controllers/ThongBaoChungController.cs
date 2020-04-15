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

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    public class ThongBaoChungController : Controller
    {
        // GET: Admin/ThongBaoChung
        ThongBaoTruongDAL tbt = new ThongBaoTruongDAL();
        public async Task<ActionResult> Index()
        {

            return View(await tbt.LayLst());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(FormCollection f)
        {
            var noidung = f["text"];
            if (noidung.Length == 0)
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Nội Dung !");
            }
            else
            {
                try
                {
                    if (await tbt.Them(new ThongBaoTruong(-1, noidung, DateTime.Now, 1)) != 0)
                    {
                        return RedirectToAction("Index", "ThongBaoChung");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm Mới Thông Báo Không Thành Công !");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return View();
        }

        public async Task<ActionResult> Update(int id)
        {
            ThongBaoTruong tbtruong = new ThongBaoTruong();
            DataTable dt = await tbt.LayDT(id);
            tbtruong = new ThongBaoTruong(dt.Rows[0]);
            return View(tbtruong);
        }

        [HttpPost]
        public async Task<ActionResult> Update(int id, ThongBaoTruong tb)
        {
            if (tb.NoiDung.Length == 0)
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Nội Dung!");
            }
            else
            {
                try
                {
                    if (await tbt.CapNhap(tb) != 0)
                    {
                        return RedirectToAction("Index", "ThongBaoChung");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Cập Nhật Thông Báo Không Thành Công !");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return View();
        }

        public async Task<JsonResult> Delete(int id)
        {
            return Json(await tbt.Xoa(id), JsonRequestBehavior.AllowGet);
        }
    }
}