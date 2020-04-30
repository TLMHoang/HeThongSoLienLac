using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using WEBSoLienLacDienTu.Areas.GiaoVien.Code;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    [SessionAuthorize]
    public class QuanLyNhapDiemController : Controller
    {
        // GET: GiaoVien/QuanLyNhapDiem
        public static Lop lop = new Lop();
        LoaiDiemDAL ld = new LoaiDiemDAL();
        public async Task<ActionResult> Index()
        {
            List<GetNameClassModel> lst = new List<GetNameClassModel>();
            foreach (DataRow dr in (await new PhanCongDayDAL().DanhSachLopDay_ByIdGv(HomeGiaoVienController.TK.ID)).Rows)
            {
                lst.Add(new GetNameClassModel(dr));
            }
            return View(lst);
        }

        public async Task<ActionResult> NhapDiem(int id)
        {
            lop.ID = id;
            await LoadLoaiDiem();
            return View();
        }
        public async Task<ActionResult> DanhSachDiem()
        {
            List<DanhSachBangDiemModel> lst = new List<DanhSachBangDiemModel>();
            //foreach (DataRow dr in (await new BangDiemDAL().LayDanhSachDiem(lop.ID, HomeGiaoVienController.TK.IDMonHoc)).Rows)
            //{
            //    lst.Add(new DanhSachBangDiemModel(dr));
            //}
            return View(lst);
        }

        public async Task LoadLoaiDiem()
        {
            ViewBag.LstLoaiDiem = new SelectList(await ld.LayLst(), "ID", "TenLoaiDiem");
        }

        public async Task<JsonResult> LoadData(int IDLoaiDiem,int Lan,byte HocKyI)
        {
            List<DanhSachDiemModel> lst = new List<DanhSachDiemModel>();
            foreach (DataRow dr in (await new BangDiemDAL().LayDanhSachDiem(lop.ID,HomeGiaoVienController.TK.IDMonHoc,IDLoaiDiem,Lan,HocKyI)).Rows)
            {
                lst.Add(new DanhSachDiemModel(dr));
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> LoadSoLanNhap(int LoaiDiem)
        {
            List<LoaiDiem> lst = await ld.LayLst();
            List<SelectListItem> lstLan =  new List<SelectListItem>();
            int solan = lst.FirstOrDefault(p => p.ID == LoaiDiem).TongCot;
            for (int i = 0; i < solan; i++)
            {
                lstLan.Add(new SelectListItem() {Text = (i+1).ToString(),Value = (i+1).ToString()});
            }
            return Json(lstLan, JsonRequestBehavior.AllowGet);
        }

    }
}