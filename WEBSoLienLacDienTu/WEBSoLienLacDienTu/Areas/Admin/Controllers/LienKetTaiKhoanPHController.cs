using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    [SessionAuthorize]
    public class LienKetTaiKhoanPHController : Controller
    {
        // GET: Admin/LienKetTaiKhoanPH
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
                return RedirectToAction("LoadTable", "LienKetTaiKhoanPH", new { id = lop.ID });
            }
            return View();
        }

        public async Task<ActionResult> LoadTable(int id)
        {
            List<DanhSachLienKetPhModel> lst = new List<DanhSachLienKetPhModel>();
            foreach (DataRow dr in (await new LienKetPhDAL().LayDT_DanhSach(id)).Rows)
            {
                lst.Add(new DanhSachLienKetPhModel(dr));
            }
            return View(lst);
        }
        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }
    }
}