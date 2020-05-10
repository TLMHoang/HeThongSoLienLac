using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Code;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class ThongBaoTruongCaNhanController : Controller
    {
        // GET: ThongBaoTruongCaNhan
        public async Task<ActionResult> Index()
        {
            List<ThongBaoHS> lst = new List<ThongBaoHS>();
            foreach (DataRow dr in (await new ThongBaoHSDAL().LayDT_TheoIDHS(TaiKhoanPhuHuynhController.ttHS.ID)).Rows)
            {
                lst.Add(new ThongBaoHS(dr));
            }
            return View(lst);
        }
        
    }
}