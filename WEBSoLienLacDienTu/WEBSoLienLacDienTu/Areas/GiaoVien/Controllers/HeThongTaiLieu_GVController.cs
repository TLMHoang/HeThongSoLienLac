using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.GiaoVien.Models;
using WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    public class HeThongTaiLieu_GVController : Controller
    {
        // GET: GiaoVien/HeThongTaiLieu_GV
        public ActionResult Index()
        {

            return View();
        }
        public async Task<ActionResult> Quiz()
        {
            DataTable dt = await new HeThongTaiLieuDAL().GetListTopic2(HomeGiaoVienController.TK.IDMonHoc, HomeGiaoVienController.TK.ID);
            List<QuizModel> lst = new List<QuizModel>();
            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new QuizModel(dr));
            }
            return View(lst);
        }
        public async Task<ActionResult> QuizDetails(int idTopic)
        {
            DataTable dt = await new HeThongTaiLieuDAL().GetListQues_Ans(idTopic);
            List<ListQuestionModel> lst = new List<ListQuestionModel>();
            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new ListQuestionModel(dr));
            }
            return View(lst);
        }
        public async Task<ActionResult> Import_Quiz()
        {            
            return View();
        }

        public ActionResult Documents()
        {
            return View();
        }
    }
}