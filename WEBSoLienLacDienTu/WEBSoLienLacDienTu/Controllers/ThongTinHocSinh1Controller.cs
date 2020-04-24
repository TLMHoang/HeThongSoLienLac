using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Home;
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
        LienKetPHvsHS lk = new LienKetPHvsHS();

        public async Task<ActionResult> Index()
        {
            //TaiKhoanPhuHuynhController.TK.ID = lk.IDTaiKhoan;
            List<LKPHvsHS> lst = new List<LKPHvsHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new LKPHvsHS(dr));
            }
            return View(lst);
        }     

        public async Task<ActionResult> Edit(int id)
        {
            lk.IDTaiKhoan = id;
            DataTable dt = new DataTable();
            dt = await new ThongTinHSDAL().LayDT(id);
            ThongTinHS tt = new ThongTinHS(dt.Rows[0]);          
            return View(tt);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(int id, ThongTinHS ttHocSinh)
        {
            if (await new ThongTinHSDAL().CapNhapTTHS(id, ttHocSinh.Ten, ttHocSinh.NgaySinh, ttHocSinh.GioiTinh, ttHocSinh.NoiSinh, ttHocSinh.DanToc, ttHocSinh.TonGiao, ttHocSinh.IDLop, ttHocSinh.IDLoaiHocSinh) != 0)
            {
                return RedirectToAction("Index", "ThongTinHocSinh1");
            }
            else
            {
                ModelState.AddModelError("", "Cập Nhật Không Thành Công !");            
            }
            return View();
        }
      
    }
}