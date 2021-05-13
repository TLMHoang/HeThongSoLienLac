using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.Admin.Code;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using WEBSoLienLacDienTu.Areas.GiaoVien.Models;
using WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Controllers
{
    public class HeThongTaiLieu_GVController : Controller
    {
        public static int sta_IDTopic;
        // GET: GiaoVien/HeThongTaiLieu_GV
        public async Task<ActionResult> Index()
        {
            
            return View();
        }
        public async Task<ActionResult> Quiz()
        {
            await LoadListKhoi();
            DataTable dt = await new HeThongTaiLieuDAL().GetListTopic2(HomeGiaoVienController.TK.IDMonHoc, HomeGiaoVienController.TK.ID);
            List<QuizModel> lst = new List<QuizModel>();
            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new QuizModel(dr));
            }
            return View(lst);
        }
        public async Task<JsonResult> InsertQuiz(string ten,int idKhoi)
        {
            return Json(await new HeThongTaiLieuDAL().InsertQuiz(HomeGiaoVienController.TK.IDMonHoc,HomeGiaoVienController.TK.ID,DateTime.Now,ten,idKhoi), JsonRequestBehavior.AllowGet);
        }
        public async Task LoadListKhoi()
        {
            ViewBag.LstKhoi = new SelectList(await new KhoiDAL().LayLst(), "ID", "TenKhoi");
        }
        public async Task<ActionResult> QuizDetails(int idTopic)
        {
            sta_IDTopic = idTopic;
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
        [HttpPost]
        public async Task<ActionResult> Import_Quiz(ImportExcel importExcel)
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
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            string fullPath = Request.MapPath("~/Content/Upload/" + file.FileName);
                            if (System.IO.File.Exists(fullPath))
                            {
                                System.IO.File.Delete(fullPath);
                            }

                            string fileName = file.FileName;
                            string path = Server.MapPath("~/Content/Upload/" + fileName);
                            
                            file.SaveAs(path);
                            
                            var excelData = new ExcelData(path);
                            var sData = excelData.getData("Sheet1");
                            dt = sData.CopyToDataTable();
                            foreach (DataRow item in dt.Rows)
                            {
                                string ques = item["Câu Hỏi"].ToString();
                                string level = item["Độ Khó"].ToString();
                                string A = item["A"].ToString();
                                string B = item["B"].ToString();
                                string C = item["C"].ToString();
                                string D = item["D"].ToString();
                                string correct = item["Câu Đúng"].ToString();
                                string explain = item["Giải Thích"].ToString();

                                DataTable dtIDQues = await new HeThongTaiLieuDAL().InsertQues(ques, sta_IDTopic, int.Parse(level));
                                int resultIdQues = int.Parse(dtIDQues.Rows[0]["ID"].ToString());
                                if(correct.Contains("A")|| correct.Contains("a"))
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, A, explain, 1);
                                }
                                else
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, A, "", 0);
                                }

                                if (correct.Contains("B") || correct.Contains("b"))
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, B, explain, 1);
                                }
                                else
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, B, "", 0);
                                }

                                if (correct.Contains("C") || correct.Contains("c"))
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, C, explain, 1);
                                }
                                else
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, C, "", 0);
                                }

                                if (correct.Contains("D") || correct.Contains("d"))
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, D, explain, 1);
                                }
                                else
                                {
                                    await new HeThongTaiLieuDAL().InsertAns(resultIdQues, D, "", 0);
                                }

                            }
                            
                            

                            return RedirectToAction("QuizDetails", "HeThongTaiLieu_GV", new { idTopic = sta_IDTopic });
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

        public ActionResult Documents()
        {
            return View();
        }
    }
}