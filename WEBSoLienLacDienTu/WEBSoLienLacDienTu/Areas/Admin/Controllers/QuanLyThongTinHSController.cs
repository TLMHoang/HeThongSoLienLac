using System;
using System.Collections.Generic;
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
    public class QuanLyThongTinHSController : Controller
    {
        // GET: Admin/QuanLyThongTinHS

        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            
            await LoadListLop();
            return View();
        }
        public async Task LoadListKhoi()
        {
            ViewData["lstKhoi"] = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }
        public async Task LoadListLop()
        {
            int ID = int.Parse(Request.Form["lstKhoi"].ToString());
            List<Lop> lstLop = new List<Lop>();
            lstLop = await new LopDAL().LayLst();
            lstLop.FirstOrDefault(p => p.ID == ID);
            ViewData["lstLop"] = new SelectList(lstLop, "ID", "TenLop");
        }
    }
}