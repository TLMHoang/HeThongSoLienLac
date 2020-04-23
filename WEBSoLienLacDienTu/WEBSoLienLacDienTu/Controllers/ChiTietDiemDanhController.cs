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
        public async Task<ActionResult> Index()
        {
            List<LKPHvsHS> lst = new List<LKPHvsHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDTaiKhoan(TaiKhoanPhuHuynhController.TK.ID)).Rows)
            {
                lst.Add(new LKPHvsHS(dr));
            }
            return View(lst);
        }     
        public async Task<ActionResult> ChiTiet(int id)
        {
            List<DiemDanh> lst = new List<DiemDanh>();
            foreach (DataRow dr in (await new DiemDanhDAL().DanhSachDiemDanhPH(id)).Rows)
            {
                lst.Add(new DiemDanh(dr));
            }
            return View(lst);
        }
        

    }
}