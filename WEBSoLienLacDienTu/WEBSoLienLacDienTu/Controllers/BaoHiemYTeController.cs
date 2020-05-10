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

            List<ThongTinHSModels> lst = new List<ThongTinHSModels>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new ThongTinHSModels(dr));
            }
            return View(lst);
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