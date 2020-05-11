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
    public class XinPhep1Controller : Controller
    {
        // GET: XinPhep1

        public async Task<ActionResult> Index()
        {
             
            List<XinPhep> lst = new List<XinPhep>();
            foreach (DataRow dr in (await new XinPhepDAL().LayDT_ID(TaiKhoanPhuHuynhController.ttHS.ID)).Rows)
            {
                lst.Add(new XinPhep(dr));
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
            if (await new XinPhepDAL().XinPhepV2(xp.NghiTu, xp.NghiDen, xp.LyDo) != 0)
            {
                return RedirectToAction("Index", "XinPhep1", new { id = TaiKhoanPhuHuynhController.ttHS.ID });
            }
            else
            {
                ModelState.AddModelError("", "Gửi Thất Bại,Vui Lòng Nhập Đủ Thông Tin !");

            }

            return View();
        }


    }
}