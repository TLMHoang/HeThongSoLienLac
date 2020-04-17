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


namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class ChiTietDiemDanhController : Controller
    {        
        // GET: ChiTietDiemDanh
        public async Task<ActionResult> Index()
        {
            List<ThongTinHS> lst = new List<ThongTinHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }
            return View(lst);
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