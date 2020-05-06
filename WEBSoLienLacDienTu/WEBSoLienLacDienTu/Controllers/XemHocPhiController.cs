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
    public class XemHocPhiController : Controller
    {
        // GET: XemHocPhi
        ThongTinHS tt = new ThongTinHS();
        public async Task<ActionResult> Index()
        {

            List<ThongTinHSModels> lst = new List<ThongTinHSModels>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new ThongTinHSModels(dr));
            }
            return View(lst);
        }
        public async Task<ActionResult> HocPhi(int id)
        {
            id = tt.ID;
            List<TienHocPhi> lst = new List<TienHocPhi>();
            foreach (DataRow dr in (await new ThongTinHocPhiDAL().LayDT(id)).Rows)
            {
                lst.Add(new TienHocPhi(dr));
            }
            return View(lst);
        }
    }
}