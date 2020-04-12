using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    [SessionTimeout]
    public class QuanLyThongTinHSController : Controller
    {
        // GET: Admin/QuanLyThongTinHS
        public static Lop lop = new Lop();
        public async Task<ActionResult> Index()
        {
            await LoadListKhoi();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(GetClassModel lop)
        {
            if (lop.ID == -10 || lop.IDKhoi ==0 )
            {
                await LoadListKhoi();
                ViewData["Loi"] = "Vui Lòng Chọn Đầy Đủ Thông Tin !";
            }
            else
            {
                return RedirectToAction("LoadTable", "QuanLyThongTinHS", new {id = lop.ID});
            }
            return View();
        }

        
        public async Task<ActionResult> LoadTable(int id)
        {
            lop.ID = id;
            List<ThongTinHS> lst = new List<ThongTinHS>();
            foreach (DataRow dr in (await new ThongTinHSDAL().LayDT_ByIDLop(id)).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }
            return View(lst);
        }

        public async Task<ActionResult> ThemHS()
        {
            await LoadLoaiHocSinh();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ThemHS(ThongTinHS ttHocSinh)
        {
            if(await new ThongTinHSDAL().ThemTTHS(ttHocSinh.Ten, ttHocSinh.NgaySinh, ttHocSinh.GioiTinh, ttHocSinh.NoiSinh, ttHocSinh.DanToc, ttHocSinh.TonGiao,lop.ID, ttHocSinh.IDLoaiHocSinh)!= 0)
            {
                return RedirectToAction("LoadTable", "QuanLyThongTinHS", new { id = lop.ID });
            }
            else
            {
                ModelState.AddModelError("","Thêm Không Thành Công,Vui Lòng Nhập Đủ Thông Tin !");
                await LoadLoaiHocSinh();
            }

            return View();
        }

        public ActionResult ThemHS_ByExcel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemHS_ByExcel(ImportExcel importExcel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string path = Server.MapPath("~/Content/Upload/" + importExcel.file.FileName);
                    importExcel.file.SaveAs(path);

                    string excelConnectionString = @"Provider='Microsoft.ACE.OLEDB.12.0';Data Source='" + path + "';Extended Properties='Excel 12.0 Xml;IMEX=1;HDR=YES'";
                    OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);

                    //Sheet Name
                    excelConnection.Open();
                    string tableName = excelConnection.GetSchema("Tables").Rows[0]["TABLE_NAME"].ToString();
                    excelConnection.Close();
                    //End

                    OleDbCommand cmd = new OleDbCommand("Select * from [" + tableName + "]", excelConnection);

                    excelConnection.Open();

                    OleDbDataReader dReader;
                    dReader = cmd.ExecuteReader();
                    SqlBulkCopy sqlBulk = new SqlBulkCopy(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);

                    //Give your Destination table name
                    sqlBulk.DestinationTableName = "ThongTinHS";

                    //Mappings
                    sqlBulk.ColumnMappings.Add("Tên", "Ten");
                    sqlBulk.ColumnMappings.Add("Ngày Sinh", "NgaySinh");
                    sqlBulk.ColumnMappings.Add("Giới Tính", "GioiTinh");
                    sqlBulk.ColumnMappings.Add("Nơi Sinh", "NoiSinh");
                    sqlBulk.ColumnMappings.Add("Dân Tộc", "DanToc");
                    sqlBulk.ColumnMappings.Add("Tôn Giáo", "TonGiao");
                    sqlBulk.ColumnMappings.Add("Mã Lớp", "IDLop");
                    sqlBulk.ColumnMappings.Add("Mã Chương Trình Học", "IDLoaiHocSinh");

                    sqlBulk.WriteToServer(dReader);
                    excelConnection.Close();

                    ViewBag.Result = "Nhập Dữ Liệu Thành Công !";
                    return RedirectToAction("LoadTable", "QuanLyThongTinHS", new { id = lop.ID });
                }
            }
            catch (Exception )
            {
                ViewBag.Loi = "Nhập Dữ Liệu Thất Bại ,Kiểm Tra Lại Định Dạng File Excel !";
            }
            
            return View();
        }
        
        public async Task<ActionResult> CapNhatHS(int id)
        {
            DataTable dt = new DataTable();
            dt = await new ThongTinHSDAL().LayDT(id);
            ThongTinHS tt = new ThongTinHS(dt.Rows[0]);
            await LoadLoaiHocSinh();
            return View(tt);
        }

        [HttpPost]
        public async Task<ActionResult> CapNhatHS(int id,ThongTinHS ttHocSinh)
        {
            if(await new ThongTinHSDAL().CapNhapTTHS(id,ttHocSinh.Ten,ttHocSinh.NgaySinh,ttHocSinh.GioiTinh,ttHocSinh.NoiSinh,ttHocSinh.DanToc,ttHocSinh.TonGiao,lop.ID,ttHocSinh.IDLoaiHocSinh)!=0)
            {
                return RedirectToAction("LoadTable", "QuanLyThongTinHS", new { id = lop.ID });
            }
            else
            {
                ModelState.AddModelError("", "Cập Không Thành Công !");
                await LoadLoaiHocSinh();
            }

            return View();
        }
        
        public async Task<JsonResult> DeleteHS(int id)
        {
            return Json(await new ThongTinHSDAL().Xoa(id),JsonRequestBehavior.AllowGet);
        }
        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }

        public async Task<JsonResult> LoadListLop(int IdKhoi)
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "Vui Lòng Chọn Lớp", Value = "-10" });
            foreach (DataRow dr in (await new LopDAL().LayDTLopTheoKhoi(IdKhoi)).Rows)
            {
                li.Add(new SelectListItem {Text = dr["TenLop"].ToString(),Value = dr["ID"].ToString() });
            }
            return Json( li,JsonRequestBehavior.AllowGet);
        }

        public async Task LoadLoaiHocSinh()
        {
            ViewBag.LstLoaiHocSinh = new SelectList(await new LoaiHocSinhDAL().LayLst(), "ID", "TenLoai");
        }

        public async Task<JsonResult> LoadTenLopByID(int ID)
        {
            GetNameClassModel tt = new GetNameClassModel();
            DataTable dt = await new LopDAL().LayTenLop(ID);
            tt = new GetNameClassModel(dt.Rows[0]);
            return Json(tt, JsonRequestBehavior.AllowGet);
        }
    }
}