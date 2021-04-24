using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Controllers
{
    public class UserController : Controller
    {
        HeThongTaiLieuDAL httl = new HeThongTaiLieuDAL();
        // GET: HeThongTaiLieu/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login_TaiLieuONL()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login_TaiLieuONL(Login_HocSinhModel hs)
        {
            var result = await httl.StudenLogin(hs.UserName, hs.PassWord);
            if (hs.UserName== null|| hs.PassWord == null)
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Đầy Đủ Thông Tin !");
            }
            else
            {
                if (result.Rows.Count == 1)
                {
                    Session["StudentName"] = hs.UserName.ToString();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Sai Tên Đăng Nhập Hoặc Mật Khẩu !");
                }
            }
            
            return View();
        }

        public ActionResult Selected_Subject_Student()
        {
            return View();
        }
        public ActionResult Test_Student()
        {
            return View();
        }
    }
}