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
    public class QuanLyMonHocController : Controller
    {
        MonHocDAL mh = new MonHocDAL();
        // GET: Admin/QuanLyMonHoc
        public async Task<ActionResult> Index()
        {
            return View(await mh.LayLst());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(FormCollection f)
        {
            var tenMon = f["TenMH"];
            var loaiDiem = Convert.ToByte(f["HeSo10"]);
            try
            {
                if (await mh.Them(new MonHoc(-1, tenMon, loaiDiem)) != 0)
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
        public async Task<ActionResult> Update(int id)
        {
            try
            {
                DataTable dt = await mh.LayDT(id);
                MonHoc monhoc = new MonHoc(dt.Rows[0]);
                return View(monhoc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        [HttpPost]
        public async Task<ActionResult> Update(int id,MonHoc monHoc)
        {
            try
            {
                if (await mh.CapNhap(monHoc) != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("","Vui Lòng Nhập Tên Môn !");
                }
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<JsonResult> Delete(int id)
        {
            return Json(await mh.Xoa(id), JsonRequestBehavior.AllowGet);
        }
    }
}