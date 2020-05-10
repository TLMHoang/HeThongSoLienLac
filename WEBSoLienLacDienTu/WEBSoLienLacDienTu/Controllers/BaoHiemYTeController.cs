using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DTO;
using WEBSoLienLacDienTu.Code;
using WEBSoLienLacDienTu.Models;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class BaoHiemYTeController : Controller
    {
        // GET: BaoHiemYTe

        public async Task<ActionResult> Index()
        {
            BHYT bhyt = new BHYT();
            DataTable dt = await new BHYT_DAL().LayDT(TaiKhoanPhuHuynhController.ttHS.ID);
            bhyt = new BHYT(dt.Rows[0]);
            return View(bhyt);
        }

        public async Task<JsonResult> DKBHYT()
        {
            return Json(await new BHYT_DAL().CapNhap(new BHYT(TaiKhoanPhuHuynhController.ttHS.ID, 1, 0)),
                JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> DKBHQD()
        {
            return Json(await new BHYT_DAL().CapNhap(new BHYT(TaiKhoanPhuHuynhController.ttHS.ID, 0, 1)),
                JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> HuyBHYT()
        {
            return Json(await new BHYT_DAL().CapNhap(new BHYT(TaiKhoanPhuHuynhController.ttHS.ID, 0, 0)),
                JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> CheckDateBHYT()
        {
            FunctionOrder f = new FunctionOrder();
            DataTable dt = await new BHYT_DAL().CheckDateBhyt();
            f = new FunctionOrder(dt.Rows[0]);
            int result = DateTime.Compare(DateTime.Now, f.EndDate.AddDays(1));
            if (result < 0)
            {
                result = 1;
            }
            else if(result == 0)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}