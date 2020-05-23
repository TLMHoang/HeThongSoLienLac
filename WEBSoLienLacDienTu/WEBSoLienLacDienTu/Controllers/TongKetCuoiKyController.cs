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

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class TongKetCuoiKyController : Controller
    {
        // GET: TongKetCuoiKy

        public async Task<ActionResult> Index()
        {
            TongKetModel tk = new TongKetModel();
            DataTable dt = await new BangDiemDAL().LayDT_DiemTongKet(TaiKhoanPhuHuynhController.ttHS.ID);
            tk = new TongKetModel(dt.Rows[0]);
            return View(tk);
        }
    }
}