using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DTO;
using DAL;
using WEBSoLienLacDienTu.Models;
using WEBSoLienLacDienTu.Home;


namespace WEBSoLienLacDienTu.Controllers
{
    public class TaiKhoanPhuHuynhController : Controller
    {
        public static TaiKhoanPH TK = new TaiKhoanPH();
        // GET: TaiKhoanPhuHuynh
        //[SessionTimeout]
        public ActionResult Index()
        {
            return View();
        }
        //[SessionTimeout]

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> DangNhap(DangNhapModels lg)
        {

            if (ModelState.IsValid)
            {
                DataTable dt = await new TaiKhoanPhDal().DangNhap(lg.TaiKhoan, lg.MatKhau);

                if (dt.Rows.Count == 1)
                {
                    List<TaiKhoanPH> lst = new List<TaiKhoanPH>();
                    TK = new TaiKhoanPH(dt.Rows[0]);
                    FormsAuthentication.SetAuthCookie(lg.TaiKhoan, true);
                    Session["TaiKhoan"] = lg.TaiKhoan.ToString();
                    Session["MatKhau"] = lg.MatKhau.ToString();
                    return RedirectToAction("Index", "TaiKhoanPhuHuynh");
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
        public ActionResult DoiPass()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        [SessionTimeout]
        public async Task<ActionResult> DoiPass(DoiPassModels DoiPass)
        {
            if (ModelState.IsValid)
            {
                if (Session["MatKhau"].Equals(DoiPass.MatKhauCu))
                {
                    if (Session["MatKhau"].Equals(DoiPass.MatKhauMoi))
                    {
                        ModelState.AddModelError("", "Mật Khẩu Mới Không Được Giống Mật Khẩu Cũ !");
                    }
                    else
                    {
                        if ((await new TaiKhoanPhDal().DoiMatKhau(TK.ID, DoiPass.MatKhauCu, DoiPass.MatKhauMoi)) != 0)
                        {
                            TK.MatKhau = DoiPass.MatKhauMoi;
                            Session["MatKhau"] = DoiPass.MatKhauMoi;
                            ViewBag.Message = "Đổi Thành Công";
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
            Session["TaiKhoanPhuHuynh"] = null;
            Session["MatKhau"] = null;
            return RedirectToAction("DangNhap");
        }

    }
}