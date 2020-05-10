using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Code;
using DAL;
using DTO;
using System.Threading.Tasks;
using System.Data;
using WEBSoLienLacDienTu.Models;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class ThongTinHocSinh1Controller : Controller
    {
        // GET: ThongTinHocSinh1   
        

        //public async Task<ActionResult> Index()
        //{
            
        //    List<ThongTinHSModels> lst = new List<ThongTinHSModels>();
        //    foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.ttHS.ID)).Rows)
        //    {
        //        lst.Add(new ThongTinHSModels(dr));
        //    }
        //    return View(lst);
        //}     
        

        public async Task<ActionResult> Edit()
        {

            ThongTinHS tt = new ThongTinHS();
            DataTable dt = await new ThongTinHSDAL().LayDT(TaiKhoanPhuHuynhController.ttHS.ID);
            tt = new ThongTinHS(dt.Rows[0]);
            return View(tt);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(int id, ThongTinHS ttHocSinh)
        {
            if (await new ThongTinHSDAL().CapNhatTTHS_PH(ttHocSinh.ID, ttHocSinh.NoiSinh, ttHocSinh.DanToc, ttHocSinh.TonGiao) != 0)
            {
                return RedirectToAction("Edit", "ThongTinHocSinh1", new { id = TaiKhoanPhuHuynhController.TK.ID });
            }
            else
            {
                ModelState.AddModelError("", "Cập Nhật Không Thành Công !");            
            }
            return View();
        }
      
    }
}