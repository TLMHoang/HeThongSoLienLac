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
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class ThongTinHocSinh1Controller : Controller
    {
        // GET: ThongTinHocSinh1
        //public static LienKetPHvsHS lKPH = new LienKetPHvsHS();
        public async Task<ActionResult> Index()
        {
            //lKPH.IDTaiKhoan = id;
            //List<LienKetPHvsHS> lst = new List<LienKetPHvsHS>();
            //foreach (DataRow dr in (await new LienKetPhDAL().LayDT(id)).Rows)
            //{
            //    lst.Add(new LienKetPHvsHS(dr));
            //}
            return View();
        }
        public async Task<ActionResult> Edit()
        {
            //DataTable dt = new DataTable();
            //dt = await new ThongTinHSDAL().LayDT(id);
            //ThongTinHS tt = new ThongTinHS(dt.Rows[0]);
            ////await loadLKPH();
            return View();
        }
        
        //public async Task<ActionResult> Edit(int id, ThongTinHS ttHocSinh)
        //{
        //    //if (await new ThongTinHSDAL().CapNhapTTHS(id, ttHocSinh.Ten, ttHocSinh.NgaySinh, ttHocSinh.GioiTinh, ttHocSinh.NoiSinh, ttHocSinh.DanToc, ttHocSinh.TonGiao, ttHocSinh.IDLop, ttHocSinh.IDLoaiHocSinh) != 0)
        //    //{
        //    //    return RedirectToAction("LoadTable", "QuanLyThongTinHS");
        //    //}
        //    //else
        //    //{
        //    //    ModelState.AddModelError("", "Cập Không Thành Công !");
        //    //    //await loadLKPH();
        //    //}

        //    return View();
        //}

        //private Task loadLKPH()
        //{
        //    ViewBag.LstLoaiHocSinh = new SelectList(await new LoaiHocSinhDAL().LayLst(), "ID", "TenLoai");
        //}
    }
}