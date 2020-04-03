using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
    public class QuanLyThongTinHSController : Controller
    {
        // GET: Admin/QuanLyThongTinHS

        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            return View();
        }

        public ActionResult LoadTable(int? id)
        {
            ViewBag.DropDownValue = id;
            return View();
        }

        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }

        public async Task<JsonResult> LoadListLop(int IdKhoi)
        {
            List<SelectListItem> li = new List<SelectListItem>();
            foreach (DataRow dr in (await new LopDAL().LayDTLopTheoKhoi(IdKhoi)).Rows)
            {
                li.Add(new SelectListItem {Text = dr["TenLop"].ToString(),Value = dr["ID"].ToString() });
            }
            return Json( li,JsonRequestBehavior.AllowGet);
        }

        //public async Task<JsonResult> LoadTable(int Id)
        //{
        //    List<ThongTinHS> li = new List<ThongTinHS>();
        //    foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDLop(Id)).Rows)
        //    {
        //        li.Add(new ThongTinHS(dr));
        //    }
        //    return Json(li,JsonRequestBehavior.AllowGet);
        //}
    }
}