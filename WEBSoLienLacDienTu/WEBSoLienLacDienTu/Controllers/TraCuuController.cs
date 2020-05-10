using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using WEBSoLienLacDienTu.Code;
using WEBSoLienLacDienTu.Models;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class TraCuuController : Controller
    {
        PhanCongDayDAL pcDAL = new PhanCongDayDAL();
        // GET: TraCuu
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> GVBM()
        {
            List<ThongTinGVBMModel> lst = new List<ThongTinGVBMModel>();
            foreach (DataRow dr in (await pcDAL.LayDTPhanCongDay_TTGVBM(TaiKhoanPhuHuynhController.ttHS.IDLop)).Rows)
            {
                lst.Add(new ThongTinGVBMModel(dr));
            }
            return View(lst);
        }
    }
}