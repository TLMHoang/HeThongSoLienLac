using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DTO;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;


namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    public class TaiKhoanTruongController : Controller
    {
        public static TaiKhoanTruong TK = new TaiKhoanTruong();
        // GET: Admin/TaiKhoanTruong
        [SessionTimeout]
        public ActionResult Index()
        {
            return View();
        }
        [SessionTimeout]
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
                    List<TaiKhoanTruong> lst = new List<TaiKhoanTruong>();
                    TK = new TaiKhoanTruong(dt.Rows[0]);
                    FormsAuthentication.SetAuthCookie(lg.TaiKhoan, true);
                    Session["TaiKhoan"] = lg.TaiKhoan.ToString();
                    Session["MatKhau"] = lg.MatKhau.ToString();
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng !");
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
        public async Task<ActionResult> ChangePass(ChangePassModel changePass)
        {
            if (ModelState.IsValid)
            {
                if (Session["MatKhau"].Equals(changePass.MatKhauCu))
                {
                    if(Session["MatKhau"].Equals(changePass.MatKhauMoi))
                    {
                        ModelState.AddModelError("", "Mật Khẩu Mới Không Được Giống Mật Khẩu Cũ !");
                    }
                    else
                    {
                        if ((await new TaiKhoanTruongDAL().DoiMatKhau(TK.ID, changePass.MatKhauCu, changePass.MatKhauMoi)) != 0)
                        {
                            TK.MatKhau = changePass.MatKhauMoi;
                            Session["MatKhau"] = changePass.MatKhauMoi;
                            ViewBag.Message = "Update Success!";
                            return View();
                        }
                        else
                        {
                            ModelState.AddModelError("", "Đổi Mật Khẩu Thất Bại !");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Mật Khẩu Cũ Không Đúng !");
                }
            }
            return View();

        }

        public ActionResult Logout()
        {
            Session["TaiKhoan"] = null;
            Session["MatKhau"] = null;
            return RedirectToAction("Login");
        }
    }
}