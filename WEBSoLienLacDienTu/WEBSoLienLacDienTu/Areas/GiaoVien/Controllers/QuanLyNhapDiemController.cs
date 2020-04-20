using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using WEBSoLienLacDienTu.Areas.GiaoVien.Code;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    [SessionAuthorize]
    public class QuanLyNhapDiemController : Controller
    {
        // GET: GiaoVien/QuanLyNhapDiem
        public async Task<ActionResult> Index()
        {
            List<GetNameClassModel> lst = new List<GetNameClassModel>();
            foreach (DataRow dr in (await new PhanCongDayDAL().DanhSachLopDay_ByIdGv(HomeGiaoVienController.TK.ID)).Rows)
            {
                lst.Add(new GetNameClassModel(dr));
            }
            return View(lst);
        }
    }
}