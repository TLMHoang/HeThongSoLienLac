using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.Admin.Models;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    public class TrainBotController : Controller
    {
        // GET: Admin/TrainBot
        public async Task<ActionResult> Index()
        {
            List<NoiDungChatBotModel> lst = new List<NoiDungChatBotModel>();
            foreach (DataRow dr in (await new BotChat().GetData()).Rows)
            {
                lst.Add(new NoiDungChatBotModel(dr));
            }
            
            return View(lst);
        }
        public async Task<JsonResult> AddAnswer(string cauHoi,string cauTraLoi)
        {
            return Json(await new BotChat().AddAnswer(cauHoi, cauTraLoi),JsonRequestBehavior.AllowGet);
        }
        
    }
}