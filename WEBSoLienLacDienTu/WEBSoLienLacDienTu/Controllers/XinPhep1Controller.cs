using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Home;
using WEBSoLienLacDienTu.Models;
using DTO;


namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class XinPhep1Controller : Controller
    {
        // GET: XinPhep1
        public async Task<ActionResult> Index()
        {
            List<LKPHvsHS> lst = new List<LKPHvsHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new LKPHvsHS(dr));
            }
            return View(lst);
        }
        public async Task<ActionResult> XinPhep()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> XinPhep(XinPhep xp)
        {
            //if (await new XinPhepDAL().XinPhepV2(xp.ID, xp.IDHocSinh, xp.NghiTu, xp.NghiDen, xp.LyDo) != 0)
            //{
            //    return RedirectToAction("LoadTable", "QuanLyThongTinHS");
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Thêm Không Thành Công,Vui Lòng Nhập Đủ Thông Tin !");

            //}

            return View();
        }


    }
}