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

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class ThongTinHocSinh1Controller : Controller
    {
        // GET: ThongTinHocSinh1             
        public async Task<ActionResult> Index()
        {
            List<ThongTinHS> lst = new List<ThongTinHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }
            return View(lst);
        }      
       
        public async Task<ActionResult> Edit(int id)
        {
            DataTable dt = new DataTable();
            dt = await new ThongTinHSDAL().LayDT(id);
            ThongTinHS tt = new ThongTinHS(dt.Rows[0]);           
            return View();
        }

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