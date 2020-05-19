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
        ThongTinHS tt = new ThongTinHS();
        public async Task<ActionResult> Index(int id)
        {

            List<HocPhiModels> lst = new List<HocPhiModels>();
            foreach (DataRow dr in (await new ThongTinHocPhiDAL().LayDT(id)).Rows)
            {
                lst.Add(new HocPhiModels(dr));
            }
            return View(lst);
        }
       
    }
}