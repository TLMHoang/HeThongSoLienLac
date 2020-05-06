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
    public class XemDiemController : Controller
    {
        // GET: XemDiem
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
        public async Task<ActionResult> BangDiem()
        {
            List<BangDiemModels> lst = new List<BangDiemModels>();
            foreach (DataRow dr in (await new BangDiemDAL().LayDanhSachDiem_ID(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new BangDiemModels(dr));
            }
            return View(lst);
        }
    }
}