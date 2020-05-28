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
    public class XemHocPhiController : Controller
    {
        // GET: XemHocPhi
        
        public async Task<ActionResult> Index()
        {
          
            return View();
        }
        public async Task<ActionResult> LoadHocPhi(int Thang)
        {

            List<HocPhiModels> lst = new List<HocPhiModels>();
            foreach (DataRow dr in (await new ThongTinHocPhiDAL().LayDT_ByID_Thang(TaiKhoanPhuHuynhController.ttHS.ID, Thang)).Rows)
            {
                lst.Add(new HocPhiModels(dr));
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

    }
}