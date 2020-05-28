using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Code;
using WEBSoLienLacDienTu.Models;
using DTO;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class XemDiemController : Controller
    {
        // GET: XemDiem


        //public async Task<ActionResult> Index()
        //{

        //    List<ThongTinHSModels> lst = new List<ThongTinHSModels>();
        //    foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
        //    {
        //        lst.Add(new ThongTinHSModels(dr));
        //    }
        //    return View(lst);
        //}
        public async Task<ActionResult> BangDiem()
        {
            return View();
        }

        public async Task<JsonResult> LoadBangDiem(byte HocKy)
        {
            List<DanhSachBangDiemTheoMonModel> lst = new List<DanhSachBangDiemTheoMonModel>();
            foreach (DataRow dr in (await new BangDiemDAL().LayDanhSachDiem_ByIDHS(TaiKhoanPhuHuynhController.ttHS.ID,HocKy)).Rows)
            {
                lst.Add(new DanhSachBangDiemTheoMonModel(dr));
            }
            return Json(lst,JsonRequestBehavior.AllowGet);
        }
    }
}