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

    }
}