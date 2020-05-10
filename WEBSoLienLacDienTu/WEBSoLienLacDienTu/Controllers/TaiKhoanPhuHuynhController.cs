using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DTO;
using DAL;
using WEBSoLienLacDienTu.Models;
using WEBSoLienLacDienTu.Code;


namespace WEBSoLienLacDienTu.Controllers
{
    public class TaiKhoanPhuHuynhController : Controller
    {
        public static TaiKhoanPH TK = new TaiKhoanPH();
        public static ThongTinHSLienKetModel ttHS = new ThongTinHSLienKetModel();
        // GET: TaiKhoanPhuHuynh
        [SessionTimeout]
        public ActionResult Index()
        {
            return View();
        }
        
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
                    TK = new TaiKhoanPH(dt.Rows[0]);
                    FormsAuthentication.SetAuthCookie(lg.TaiKhoan, true);
                    Session["TaiKhoan"] = lg.TaiKhoan.ToString();
                    Session["MatKhau"] = lg.MatKhau.ToString();
                    DataTable dt1 = await new LienKetPhDAL().LayThongTinHS_ByPH(TK.ID);
                    if (LoadTths().Result.Rows.Count == 1)
                    {
                        ttHS = new ThongTinHSLienKetModel(dt1.Rows[0]);
                        return RedirectToAction("Index", "Home");
                    }
                    else if (LoadTths().Result.Rows.Count == 0)
                    {
                        return RedirectToAction("ChonHS", "TaiKhoanPhuHuynh");
                    }
                    else
                    {
                        ttHS = new ThongTinHSLienKetModel(dt1.Rows[0]);
                        return RedirectToAction("ChonHS", "TaiKhoanPhuHuynh");
                    }
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
                        if (await new TaiKhoanPhDal().DoiMatKhau(TK.ID, DoiPass.MatKhauCu, DoiPass.MatKhauMoi) != 0)
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
            Session["TaiKhoan"] = null;
            Session["MatKhau"] = null;
            return RedirectToAction("DangNhap");
        }
        [SessionTimeout]
        public ActionResult ChonHS()
        {
            List<ThongTinHSLienKetModel> lst = new List<ThongTinHSLienKetModel>();
            foreach (DataRow dr in LoadTths().Result.Rows)
            {
                lst.Add(new ThongTinHSLienKetModel(dr));
            }
            return View(lst);
        }

        public async Task<DataTable> LoadTths()
        {
            DataTable dt = await new LienKetPhDAL().LayThongTinHS_ByPH(TK.ID);
            return dt;
        }

        public async Task<JsonResult> ChonTTHS(int id)
        {
            var row = LoadTths().Result.AsEnumerable().SingleOrDefault(r => r.Field<int>("ID") == id);
            ttHS = new ThongTinHSLienKetModel(row);
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult TenHS()
        {
            return Json(ttHS.Ten, JsonRequestBehavior.AllowGet);
        }
    }
}