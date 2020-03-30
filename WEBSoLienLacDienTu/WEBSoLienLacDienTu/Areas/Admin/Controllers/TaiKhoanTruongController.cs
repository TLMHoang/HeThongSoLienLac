using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    public class TaiKhoanTruongController : Controller
    {
        // GET: Admin/TaiKhoanTruong
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Login(LoginModel lg)
        {
           
            if (ModelState.IsValid)
            {
                DataTable dt = await new TaiKhoanTruongDAL().DangNhap(lg.TaiKhoan, lg.MatKhau);
                if (dt.Rows.Count == 1)
                {
                    FormsAuthentication.SetAuthCookie(lg.TaiKhoan,true);
                    Session["TaiKhoan"] = lg.TaiKhoan.ToString();
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else
                {
                   ModelState.AddModelError("","Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng !");
                }
            }

            return View();
        }
    }
}