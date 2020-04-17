using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;
using WEBSoLienLacDienTu.Areas.GiaoVien.Code;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    [SessionAuthorize]
    public class HomeGiaoVienController : Controller
    {
        // GET: GiaoVien/HomeGiaoVien
        public static LienKetPHvsHS TK = new LienKetPHvsHS();

        public async Task<ActionResult> GetTKTruong(string tenTaiKhoan, string matKhauTaiKhoan)
        {
            DataTable dt = await new LienKetPhDAL().DangNhap(tenTaiKhoan, matKhauTaiKhoan);
            if (dt.Rows.Count != 0)
            {
                TK = new LienKetPHvsHS(dt.Rows[0]);
                return RedirectToAction("Index");
            }

            return new EmptyResult();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}