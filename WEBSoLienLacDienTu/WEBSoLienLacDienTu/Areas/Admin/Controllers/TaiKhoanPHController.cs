using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;
using PagedList;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    [SessionAuthorize]
    public class TaiKhoanPHController : Controller
    {
        TaiKhoanPhDal tkphDal = new TaiKhoanPhDal();
        // GET: Admin/TaiKhoanPH
        [HttpGet]
        public async Task<ActionResult> Index(int? page)
        {
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            IPagedList<TaiKhoanPH> pLstTKPH = null;
            List<TaiKhoanPH> LstTKPH = await tkphDal.LayLst();
            pLstTKPH = LstTKPH.ToPagedList(pageIndex, pageSize);
            return View(pLstTKPH);
        }

        public ActionResult ThemTaiKhoanPH()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ThemTaiKhoanPH(FormCollection f)
        {
            string taiKhoan = f["TenTk"];
            string tenMe = f["TenMe"];
            string sdtMe = f["SDTMe"];
            string tenBo = f["TenBo"];
            string sdtBo = f["SDTBo"];
            try
            {
                if (await tkphDal.CheckExist(taiKhoan) > 0)
                {
                    ModelState.AddModelError("","Tài Khoản Đã Tồn Tại !");
                }
                else
                {
                    if (await tkphDal.Them(new TaiKhoanPH(-1, taiKhoan, taiKhoan, tenMe, sdtMe, tenBo, sdtBo)) != 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Tạo Mới Thất Bại !");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }

        public async Task<ActionResult> CapNhatTKPH(int id)
        {
            TaiKhoanPH tk = new TaiKhoanPH();
            DataTable dt = await tkphDal.LayDT(id);
            tk = new TaiKhoanPH(dt.Rows[0]);
            return View(tk);
        }

        [HttpPost]
        public async Task<ActionResult> CapNhatTKPH(int id, TaiKhoanPH tkph)
        {
            try
            {
                if (await tkphDal.CapNhapTT(tkph) != 0)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }

        public async Task<JsonResult> XoaTKPH(int id)
        {
            return Json(await tkphDal.Xoa(id), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> ResetPass(int ID)
        {
            return Json(await tkphDal.ResetPass(ID), JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> Search(string chuoiTimKiem)
        {
            List<TaiKhoanPH> lst = new List<TaiKhoanPH>();
            foreach (DataRow dr in (await tkphDal.Search(chuoiTimKiem)).Rows)
            {
                lst.Add(new TaiKhoanPH(dr));
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ThemTK_ByExcel()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ThemTK_ByExcel(ImportExcel importExcel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Request != null)
                    {
                        DataTable dt = new DataTable();
                        HttpPostedFileBase file = importExcel.file;
                        if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))
                        {
                            string fileName = file.FileName;
                            string path = Server.MapPath("~/Content/Upload/" + fileName);
                            file.SaveAs(path);
                            var excelData = new ExcelData(path);
                            var sData = excelData.getData("Sheet1");
                            dt = sData.CopyToDataTable();
                            foreach (DataRow item in dt.Rows)
                            {
                                await new TaiKhoanPhDal().Them(new TaiKhoanPH(
                                    -1,
                                    item["Tài Khoản"].ToString(),
                                    item["Tài Khoản"].ToString(),
                                    item["Tên Mẹ"].ToString(),
                                    item["SĐT Mẹ"].ToString(),
                                    item["Tên Bố"].ToString(),
                                    item["SĐT Bố"].ToString()
                                ));
                            }
                            return RedirectToAction("Index", "TaiKhoanPH", new { page = 1 });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ViewBag.Loi = "Nhập Dữ Liệu Thất Bại ,Kiểm Tra Lại Định Dạng File Excel !";
            }
            return View();
        }
    }
}