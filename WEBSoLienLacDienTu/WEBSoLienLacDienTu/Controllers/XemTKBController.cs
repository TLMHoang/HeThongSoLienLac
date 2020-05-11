using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using WEBSoLienLacDienTu.Areas.GiaoVien.Controllers;
using WEBSoLienLacDienTu.Code;
using WEBSoLienLacDienTu.Models;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class XemTKBController : Controller
    {
        // GET: XemTKB
        public async Task<ActionResult> Index()
        {

            await LoadT2();
            await LoadT3();
            await LoadT4();
            await LoadT5();
            await LoadT6();
            await LoadT7();
            await LoadCN();
            return View();
        }
        public async Task<JsonResult> LoadData(int IDThu)
        {
            List<ThoiKhoaBieuModel> lst = new List<ThoiKhoaBieuModel>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_CoTenMon(TaiKhoanPhuHuynhController.ttHS.IDLop, IDThu)).Rows)
            {
                lst.Add(new ThoiKhoaBieuModel(dr));
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        public async Task LoadT2()
        {
            List<string> lst = new List<string>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID,2)).Rows)
            {
                lst.Add( dr["TenMon"].ToString());
            }
            ViewBag.LstT2 = lst;
        }
        public async Task LoadT3()
        {
            List<string> lst = new List<string>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID, 3)).Rows)
            {
                lst.Add(dr["TenMon"].ToString());
            }
            ViewBag.LstT3 = lst;
        }
        public async Task LoadT4()
        {
            List<string> lst = new List<string>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID, 4)).Rows)
            {
                lst.Add(dr["TenMon"].ToString());
            }
            ViewBag.LstT4 = lst;
        }
        public async Task LoadT5()
        {
            List<string> lst = new List<string>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID, 5)).Rows)
            {
                lst.Add(dr["TenMon"].ToString());
            }
            ViewBag.LstT5 = lst;
        }
        public async Task LoadT6()
        {
            List<string> lst = new List<string>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID, 6)).Rows)
            {
                lst.Add(dr["TenMon"].ToString());
            }
            ViewBag.LstT6 = lst;
        }
        public async Task LoadT7()
        {
            List<string> lst = new List<string>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID, 7)).Rows)
            {
                lst.Add(dr["TenMon"].ToString());
            }
            ViewBag.LstT7 = lst;
        }
        public async Task LoadCN()
        {
            List<string> lst = new List<string>();
            foreach (DataRow dr in (await new ThoiKhoaBieuDAL().LayDT_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID, 1)).Rows)
            {
                lst.Add(dr["TenMon"].ToString());
            }
            ViewBag.LstCN = lst;
        }
    }
}