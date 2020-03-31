using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;


namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    public class TaiKhoanTruongController : Controller
    {
        private int ID;
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
                    foreach (var VARIABLE in dt.Rows)
                    {
                        ID = int.Parse(dt.Rows[0]["ID"].ToString());
                    }
                    FormsAuthentication.SetAuthCookie(lg.TaiKhoan,true);
                    Session["TaiKhoan"] = lg.TaiKhoan.ToString();
                    Session["MatKhau"] = lg.MatKhau.ToString();
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else
                {
                   ModelState.AddModelError("","Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng !");
                }
            }

            return View();
        }
        [HttpGet]
        [SessionTimeout]
        public ActionResult ChangePass()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        [SessionTimeout]
        public ActionResult ChangePass(ChangePassModel changePass)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();

        }

        public ActionResult Logout()
        {
            Session["TaiKhoan"] = null;
            Session["MatKhau"] = null;
            ID = -1;
            return RedirectToAction("Login");
        }
    }
}