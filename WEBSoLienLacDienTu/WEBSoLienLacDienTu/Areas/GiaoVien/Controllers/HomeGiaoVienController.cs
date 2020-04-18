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
        public static TaiKhoanTruong TK = new TaiKhoanTruong();

        public async Task<ActionResult> GetTKTruong(string tenTaiKhoan, string matKhauTaiKhoan)
        {
            DataTable dt = await new TaiKhoanTruongDAL().DangNhap(tenTaiKhoan, matKhauTaiKhoan);
            if (dt.Rows.Count != 0)
            {
                TK = new TaiKhoanTruong(dt.Rows[0]);
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