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
        public static string mk;
        public static int flag;
        
        MonHocDAL mh = new MonHocDAL();
        TaiKhoanTruongDAL tkDal = new TaiKhoanTruongDAL();
        LopDAL lop = new LopDAL();
        // GET: Admin/TaiKhoanTruong
        [SessionTimeout]
        [SessionAuthorize]
        public async Task<ActionResult> Index()
        {
            List<DanhSachTaiKhoanTruongModel> lst = new List<DanhSachTaiKhoanTruongModel>();
            foreach (DataRow dr in (await tkDal.LayDanhSachTK()).Rows)
            {
                lst.Add(new DanhSachTaiKhoanTruongModel(dr));
            }
            return View(lst);
        }

        [SessionTimeout]
        [SessionAuthorize]
        public ActionResult ChonChucNang()
        {
            return View();
        }
        [SessionTimeout]
        [SessionAuthorize]
        [HttpPost]
        public ActionResult ChonChucNang(FormCollection f)
        {
            Session["TaiKhoanGiaoVien"] = TK.TaiKhoan;
            flag = 1;
            return RedirectToAction("GetTKTruong", "HomeGiaoVien",
                 new { area = "GiaoVien", tenTaiKhoan = TK.TaiKhoan, matKhauTaiKhoan = mk });
        }
        public JsonResult Flag()
        {
            return Json(flag, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> CheckStatusTaiKhoan()
        {
            DataTable dt = await new TaiKhoanTruongDAL().CheckStatus();
            int flagStatus;
            if (dt.Rows.Count > 0)
            {
                flagStatus = 1;
            }
            else
            {
                flagStatus = 0;
            }
            return Json(flagStatus, JsonRequestBehavior.AllowGet);
        }
        [SessionTimeout]
        [SessionAuthorize]
        public async Task<ActionResult> Create()
        {
            await LoadDanhSachMon();
            await LoadDanhSachLop();
            return View();
        }
        [SessionTimeout]
        [SessionAuthorize]
        [HttpPost]
        public async Task<ActionResult> Create(FormCollection f)
        {
            await LoadDanhSachMon();
            await LoadDanhSachLop();
            var tenTk = f["TenTk"];
            var tenGV = f["TenGV"];
            var sdt = f["SDT"];
            var mon = f["LstMon"];
            var lopDay = f["LstLop"];
            byte Loai;
            Boolean chk = f["Loai"] != null ? true : false;
            if (chk == true)
            {
                Loai = 1;
            }
            else
            {
                Loai = 0;
            }

            if (mon != "" && lopDay != "")
            {
                if (await tkDal.CheckExist(tenTk) > 0)
                {
                    ModelState.AddModelError("", "Tài Khoản Đã Tồn Tại !");
                }
                else
                {
                    if (await tkDal.Them(new TaiKhoanTruong(-1, tenTk, tenTk, Loai, tenGV, sdt, int.Parse(mon), int.Parse(lopDay))) != 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Vui Lòng Nhập Đầy Đủ Thông Tin !");
            }

            return View();
        }

        public async Task<ActionResult> Update(int id)
        {
            await LoadDanhSachMon();
            TaiKhoanTruong taiKhoan = new TaiKhoanTruong();
            DataTable dt = await tkDal.LayDT(id);
            taiKhoan = new TaiKhoanTruong(dt.Rows[0]);
            await LoadDanhSachLop(taiKhoan.IDLop);
            return View(taiKhoan);
        }
        [HttpPost]
        public async Task<ActionResult> Update(int id, TaiKhoanTruong tkTruong)
        {
            if (await tkDal.CapNhap(tkTruong) != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<JsonResult> ResetPass(int ID)
        {
            return Json(await tkDal.ResetPass(ID), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> Delete(int id)
        {
            return Json(await tkDal.Xoa(id), JsonRequestBehavior.AllowGet);
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
                    TK = new TaiKhoanTruong(dt.Rows[0]);
                    FormsAuthentication.SetAuthCookie(lg.TaiKhoan, true);
                    if (TK.Loai == 1)
                    {
                        Session["TaiKhoanNhaTruong"] = lg.TaiKhoan.ToString();
                        Session["MatKhau"] = lg.MatKhau.ToString();
                        mk = lg.MatKhau.ToString();
                        return RedirectToAction("Index","HomeAdmin");
                    }
                    else
                    {
                        Session["TaiKhoanGiaoVien"] = lg.TaiKhoan.ToString();
                        Session["MatKhau"] = lg.MatKhau.ToString();
                        await new TaiKhoanTruongDAL().SetStatus(lg.TaiKhoan, 1);
                        return RedirectToAction("GetTKTruong", "HomeGiaoVien", new { area = "GiaoVien", tenTaiKhoan = lg.TaiKhoan, matKhauTaiKhoan = lg.MatKhau });
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
                    if (Session["MatKhau"].Equals(changePass.MatKhauMoi))
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

        public async Task<ActionResult> Logout()
        {
            await new TaiKhoanTruongDAL().SetStatus(Session["TaiKhoanGiaoVien"].ToString(), 0);
            Session["TaiKhoanGiaoVien"] = null;
            Session["TaiKhoanNhaTruong"] = null;
            Session["MatKhau"] = null;
            flag = 0;
            
            return RedirectToAction("Login");
        }
        

        public async Task<JsonResult> OnWindowClosing()
        {
            await new TaiKhoanTruongDAL().SetStatus(Session["TaiKhoanGiaoVien"].ToString(), 0);
            Session["TaiKhoanGiaoVien"] = null;
            Session["TaiKhoanNhaTruong"] = null;
            Session["MatKhau"] = null;
            flag = 0;
            return Json(flag, JsonRequestBehavior.AllowGet);
        }
        public async Task LoadDanhSachMon()
        {
            ViewBag.LstMon = new SelectList(await mh.LayLst(), "ID", "TenMon");
        }

        public async Task LoadDanhSachLop()
        {
            List<GetNameClassModel> lst = new List<GetNameClassModel>();
            foreach (DataRow dr in (await lop.LayTenLopChuaCoChuNhiem()).Rows)
            {
                if (Convert.ToInt32(dr["ID"].ToString()) == -1)
                {
                    GetNameClassModel l = new GetNameClassModel();
                    l.ID = -1;
                    l.TenDayDu = "Trống";
                    lst.Add(l);
                }
                else
                {
                    lst.Add(new GetNameClassModel(dr));
                }
            }

            ViewBag.LstLop = new SelectList(lst, "ID", "TenDayDu");
        }
        public async Task LoadDanhSachLop(int id)
        {
            List<GetNameClassModel> lst = new List<GetNameClassModel>();
            foreach (DataRow dr in (await lop.LayTenLopChuaCoChuNhiem(id)).Rows)
            {
                if (Convert.ToInt32(dr["ID"].ToString()) == -1)
                {
                    GetNameClassModel l = new GetNameClassModel();
                    l.ID = -1;
                    l.TenDayDu = "Trống";
                    lst.Add(l);
                }
                else
                {
                    lst.Add(new GetNameClassModel(dr));
                }
            }

            ViewBag.LstLop1 = new SelectList(lst, "ID", "TenDayDu");
        }
        public JsonResult TenTK()
        {
            return Json(TK.TaiKhoan, JsonRequestBehavior.AllowGet);
        }
    }
}