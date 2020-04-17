using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Home;
using DTO;
using DAL;
using System.Data;
using System.Threading.Tasks;
using WEBSoLienLacDienTu.Models;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class ChiTietDiemDanhController : Controller
    {
        public static TaiKhoanPH tk = new TaiKhoanPH();
        ThongTinHSDAL tt = new ThongTinHSDAL();
        // GET: ChiTietDiemDanh
        public async Task<ActionResult> Index(LKPHvsHS lk)
        {
            lk.IDTaiKhoan = 0;
            return View(await tt.LayLst());                                           
        }
     

        public async Task<ActionResult> ChiTiet(int IDTaiKhoan)
        {
            List<DiemDanh> lst = new List<DiemDanh>();
            foreach (DataRow dr in (await new DiemDanhDAL().DanhSachDiemDanhPH(IDTaiKhoan)).Rows)
            {
                lst.Add(new DiemDanh(dr));
            }
            return View(lst);
        }

    }
}