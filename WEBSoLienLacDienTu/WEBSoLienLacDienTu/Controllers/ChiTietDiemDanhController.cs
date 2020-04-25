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
        // GET: ChiTietDiemDanh
        LienKetPHvsHS lk = new LienKetPHvsHS();
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
        public async Task<ActionResult> ChiTiet()
        {

            List<DiemDanh> lst = new List<DiemDanh>();
            foreach (DataRow dr in (await new DiemDanhDAL().DanhSachDiemDanhPH(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new DiemDanh(dr));
            }
            return View(lst);
        }
        
        


    }
}