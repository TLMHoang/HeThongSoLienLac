using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Tree;
using DAL;
using DTO;
using Microsoft.Ajax.Utilities;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    [SessionAuthorize]
    public class ThoiKhoaBieuController : Controller
    {
        // GET: Admin/ThoiKhoaBieu
        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            await LoadListMonHoc();
            return View();
        }
        //[HttpPost]
        //public async Task<ActionResult> Index(FormCollection collection)
        //{
        //    LoadListKhoi();
        //    var IDLop = int.Parse(collection["LstLop"]);
        //    var IDThu = int.Parse(collection["LstThu"]);
        //    List<ThoiKhoaBieuModel> lst = new List<ThoiKhoaBieuModel>();
        //    foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_CoTenMon(IDLop, IDThu)).Rows)
        //    {
        //        lst.Add(new ThoiKhoaBieuModel(dr));
        //    }
        //    return View(lst);
        //}

        public async Task<JsonResult> LoadData(int IDLop,int IDThu)
        {
            List<ThoiKhoaBieuModel> lst = new List<ThoiKhoaBieuModel>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_CoTenMon(IDLop,IDThu)).Rows)
            {
                lst.Add(new ThoiKhoaBieuModel(dr));
            }
            await LoadListKhoi();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> UpdateTKB(ThoiKhoaBieu tkb)
        {
            return Json(await new ThoiKhoaBieuDAL().CapNhap(tkb), JsonRequestBehavior.AllowGet);
        }

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

        public async Task LoadListMonHoc()
        {
            ViewBag.LstMon = new SelectList(await new MonHocDAL().LayLst(), "ID", "TenMon");
        }

        public async Task<JsonResult> GetById(int IDLop,int Thu,int Tiet)
        {
            ThoiKhoaBieu tkb = new ThoiKhoaBieu();
            DataTable dt = await new ThoiKhoaBieuDAL().LayDT(IDLop, Thu, Tiet);
            tkb = new ThoiKhoaBieu(dt.Rows[0]);
            return Json(tkb, JsonRequestBehavior.AllowGet);
        }
    }
}