using System;
using System.Collections.Generic;
using System.Data;
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
    [SessionAuthorize]
    public class BHYTController : Controller
    {
        // GET: Admin/BHYT
        public async Task<ActionResult> Index()
        {
            FunctionOrder f = new FunctionOrder();
            DataTable dt = await new BHYT_DAL().CheckDateBhyt();
            f = new FunctionOrder(dt.Rows[0]);
            return View(f);
        }
        [HttpPost]
        public async Task<ActionResult> Index(FunctionOrder bhyt)
        {
            if (DateTime.Compare(bhyt.StartDate, bhyt.EndDate) > 0)
            {
                ModelState.AddModelError("","Ngày Bắt Đầu Không Được Lớn Hơn Kết Thúc !");
            }
            else
            {
                if (await new BHYT_DAL().CapNhatDKBHYT(bhyt.StartDate, bhyt.EndDate) != 0)
                {
                    ViewBag.ThongBao = "Cập Nhật Ngày ĐK Thành Công !";
                }
                else
                {
                    ModelState.AddModelError("","Thất Bại !");
                }
            }
            return View();
        }
    }
}