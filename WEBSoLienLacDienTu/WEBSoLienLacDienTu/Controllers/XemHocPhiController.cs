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

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class XemHocPhiController : Controller
    {
        // GET: XemHocPhi
        public async Task<ActionResult> Index()
        {
            List<LKPHvsHS> lst = new List<LKPHvsHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new LKPHvsHS(dr));
            }
            return View(lst);
        }
    }
}