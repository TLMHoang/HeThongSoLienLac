using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using WEBSoLienLacDienTu.Areas.GiaoVien.Models;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    [SessionTimeout]
    public class KiemDuyetXinPhepController : Controller
    {
        // GET: GiaoVien/KiemDuyetXinPhep
        public async Task<ActionResult> Index()
        {
            List<KiemDuyetXinPhepModel> lst = new List<KiemDuyetXinPhepModel>();

            if (HomeGiaoVienController.TK.IDLop == -1)
            {
                ViewBag.ThongBao = "Xin Lỗi Bạn Không Phải GVCN !";
                return View();
            }
            else
            {
                foreach (DataRow dr in (await new XinPhepDAL().LayDT_CoTenHS(HomeGiaoVienController.TK.IDLop, 1)).Rows)
                {
                    if (DateTime.Compare(DateTime.Now, Convert.ToDateTime(dr["NghiDen"].ToString())) > 0)
                    {
                        await new XinPhepDAL().DuyetDon(Convert.ToInt32(dr["ID"].ToString()), 4);
                    }
                    else
                    {
                        lst.Add(new KiemDuyetXinPhepModel(dr));
                    }
                }
                return View(lst);
                
            }
        }
        public async Task<ActionResult> DanhSachDaDuyet()
        {
            List<KiemDuyetXinPhepModel> lst = new List<KiemDuyetXinPhepModel>();
            foreach (DataRow dr in (await new XinPhepDAL().LayDT_DaDuyet(HomeGiaoVienController.TK.IDLop)).Rows)
            {
                lst.Add(new KiemDuyetXinPhepModel(dr));
            }
            return View(lst);
        }
        public async Task<JsonResult> DuyetDon(int ID)
        {
            return Json(await new XinPhepDAL().DuyetDon(ID, 2), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> TuChoiDon(int ID)
        {
            return Json(await new XinPhepDAL().DuyetDon(ID, 3), JsonRequestBehavior.AllowGet);
        }
    }
}