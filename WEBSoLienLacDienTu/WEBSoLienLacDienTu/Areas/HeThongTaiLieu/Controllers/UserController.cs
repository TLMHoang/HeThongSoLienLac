using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Controllers
{
    public class UserController : Controller
    {
        HeThongTaiLieuDAL httl = new HeThongTaiLieuDAL();
        public static ThongTinHS hocsinh = new ThongTinHS();
        public static int iDStudent_HTTL;
        public static int iDQuiz;
        public static float coefficient;
        public static float scores;
        public static List<QuestionModel> lstQues_level = new List<QuestionModel>();
        public static List<AnswerModel> lstAns_Check = new List<AnswerModel>();
        public static float combo = 0;
        int idQues;
        public static int idKhoi;
        public static int sta_IdMon;

        // GET: HeThongTaiLieu/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login_TaiLieuONL()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login_TaiLieuONL(Login_HocSinhModel hs)
        {

            DataTable result = await httl.StudenLogin(hs.UserName, hs.PassWord);
            if (ModelState.IsValid)
            {

                if (result.Rows.Count == 1)
                {
                    DataTable dt = await new ThongTinHSDAL().LayDT(int.Parse(hs.UserName.Remove(0, 3)));
                    iDStudent_HTTL = int.Parse(result.Rows[0][0].ToString());
                    hocsinh = new ThongTinHS(dt.Rows[0]);
                    Session["StudentName"] = hocsinh.Ten.ToString();
                    return RedirectToAction("Index");
                }
                else if (hs.UserName.Contains("hs00"))
                {
                    DataTable dt = await new ThongTinHSDAL().LayDT(int.Parse(hs.UserName.Remove(0, 3)));
                    if (dt.Rows.Count == 1)
                    {

                        hocsinh = new ThongTinHS(dt.Rows[0]);
                        if (await httl.CreateStudent(hs.UserName, hs.UserName) != 0)
                        {
                            DataTable result1 = await httl.StudenLogin(hs.UserName, hs.PassWord);
                            iDStudent_HTTL = int.Parse(result1.Rows[0][0].ToString());
                            Session["StudentName"] = hocsinh.Ten.ToString();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Không Thể Thêm Tài Khoản");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Xin Lỗi, Không Tìm Thấy Tài Khoản");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Sai Tên Đăng Nhập Hoặc Mật Khẩu");
                }
            }


            return View();
        }

        public async Task<ActionResult> Selected_Subject_Student()
        {
            return View(await new MonHocDAL().LayLst());
        }
        public async Task<ActionResult> Selected_Topic(int idMon)
        {
            Lop l = await new KhoiDAL().SelectKhoi_ByIDLop(hocsinh.IDLop);
            idKhoi = l.IDKhoi;
            sta_IdMon = idMon;
            return View(await new HeThongTaiLieuDAL().GetListTopic(idMon, l.IDKhoi));
        }

        public async Task<ActionResult> Test_Student(int idquiz)
        {
            List<QuestionModel> lst = await getQues(idquiz);
            if (lst.Count != 0)
            {
                scores = 0;
                MergeQues mymodel = new MergeQues();
                DataTable dt = new DataTable();
                List<QuestionModel> lstQues = await getQues(idquiz);
                iDQuiz = idquiz;
                lstAns_Check = await getAns(-1);

                mymodel = await GetListQuestion(idquiz);
                return View(mymodel);
            }
            else
                return RedirectToAction("Notfound_Quiz");
        }

        [HttpPost]
        public async Task<ActionResult> Test_Student(FormCollection f)
        {
            var resultAnswer = f["idQues"]; //GET DATA FROM CLIENT BY POST
            var random = new Random();//DECLARE VAR RANDOM
            MergeQues mymodel = new MergeQues();
            AnswerModel answer = lstAns_Check.FirstOrDefault(x => x.ID == int.Parse(resultAnswer));

            if (answer.CorrectAns == 1)
            {
                combo += coefficient;
                if (combo >= 0.5)
                {
                    int level = await checkScores();
                    if (level == 3)
                    {
                        await httl.UpdateScoresLevel(iDStudent_HTTL, iDQuiz, level);
                        lstQues_level.Clear();
                        scores = 0;
                    }
                    else
                    {
                        await httl.UpdateScoresLevel(iDStudent_HTTL, iDQuiz, level + 1);
                        lstQues_level.Clear();
                        scores = 0;
                    }
                    mymodel = await GetListQuestion(iDQuiz);
                }
                else
                {
                    scores += coefficient;
                    if (scores >= 0.9)
                    {
                        int level = await checkScores();
                        if (level == 3)
                        {
                            await httl.UpdateScoresLevel(iDStudent_HTTL, iDQuiz, level);
                            lstQues_level.Clear();
                            scores = 0;
                        }
                        else
                        {
                            await httl.UpdateScoresLevel(iDStudent_HTTL, iDQuiz, level + 1);
                            lstQues_level.Clear();
                            scores = 0;
                        }
                        mymodel = await GetListQuestion(iDQuiz);
                    }
                    else
                    {

                        lstQues_level.RemoveAt(lstQues_level.FindIndex(x => x.ID == answer.IDQues));
                        if (lstQues_level.Count == 0)
                        {
                            int level = await checkScores();
                            List<QuestionModel> lst = await getQues(iDQuiz);
                            lstQues_level = lst.Where(x => x.LevelQues == level).ToList();
                            QuestionModel question = lstQues_level[random.Next(lstQues_level.Count)];
                            List<AnswerModel> lstAns = await getAns(question.ID);
                            mymodel.Question = question;
                            mymodel.LstAns = lstAns;
                        }
                        else
                        {
                            QuestionModel question = lstQues_level[random.Next(lstQues_level.Count)];
                            List<AnswerModel> lstAns = await getAns(question.ID);
                            mymodel.Question = question;
                            mymodel.LstAns = lstAns;
                        }

                    }

                }

            }
            else
            {
                combo = 0;
                scores -= coefficient;
                if (scores <= -0.3)
                {
                    int level = await checkScores();
                    if (level == 1)
                    {
                        await httl.UpdateScoresLevel(iDStudent_HTTL, iDQuiz, level);
                        scores = 0;
                    }
                    else
                    {
                        await httl.UpdateScoresLevel(iDStudent_HTTL, iDQuiz, level - 1);
                        lstQues_level.Clear();
                        scores = 0;
                    }
                    mymodel = await GetListQuestion(iDQuiz);
                }
                else
                {
                    var r = 0;
                    var lastAnsID = lstQues_level.FindIndex(x => x.ID == answer.IDQues);
                    if (lstQues_level.Count == 1)
                    {
                        lstQues_level.Clear();
                        int level = await checkScores();
                        List<QuestionModel> lst = await getQues(iDQuiz);
                        lstQues_level = lst.Where(x => x.LevelQues == level).ToList();
                    }
                    else
                    {
                        do
                        {
                            r = random.Next(lstQues_level.Count);
                        } while (r == lastAnsID);
                    }
                    QuestionModel question = lstQues_level[r];
                    List<AnswerModel> lstAns = await getAns(question.ID);
                    mymodel.Question = question;
                    mymodel.LstAns = lstAns;
                }
            }
            return View(mymodel);
        }
        public async Task<MergeQues> GetListQuestion(int idQuiz)
        {
            MergeQues mymodel = new MergeQues();
            DataTable dt = new DataTable();
            List<QuestionModel> lst = await getQues(idQuiz);
            var random = new Random();
            int level = await checkScores();
            lstQues_level = lst.Where(x => x.LevelQues == level).ToList();
            QuestionModel question = lstQues_level[random.Next(lstQues_level.Count)];
            List<AnswerModel> lstAns = await getAns(question.ID);
            idQues = question.ID;
            mymodel.Question = question;
            mymodel.LstAns = lstAns;
            dt = await httl.CountQueslevel(1);
            coefficient = 1 / float.Parse(dt.Rows[0][0].ToString());
            return mymodel;
        }
        public ActionResult Notfound_Quiz()
        {
            return View();
        }
        public JsonResult showResult(int idAns)
        {
            AnswerModel ans = lstAns_Check.FirstOrDefault(x => x.ID == idAns);
            AnswerModel correctAns = lstAns_Check.FirstOrDefault(x => x.IDQues == ans.IDQues && x.CorrectAns == 1);
            return Json(correctAns, JsonRequestBehavior.AllowGet);
        }
        public async Task<List<QuestionModel>> getQues(int idquiz)
        {
            List<QuestionModel> lst = new List<QuestionModel>();
            DataTable dt = await new HeThongTaiLieuDAL().GetQues(idquiz);
            foreach (DataRow item in dt.Rows)
            {
                lst.Add(new QuestionModel(item));
            }
            return lst;
        }
        public async Task<List<AnswerModel>> getAns(int idques)
        {
            List<AnswerModel> lst = new List<AnswerModel>();
            DataTable dt = await new HeThongTaiLieuDAL().GetAns(idques);
            foreach (DataRow item in dt.Rows)
            {
                lst.Add(new AnswerModel(item));
            }
            return lst;
        }

        public async Task<int> checkScores()
        {
            int result;
            DataTable dt = await httl.GetScores(iDStudent_HTTL, iDQuiz);
            if (dt.Rows.Count == 0)
            {
                await httl.CreateScores(iDStudent_HTTL, iDQuiz, 1);
                result = 1;
            }
            else
            {
                result = int.Parse(dt.Rows[0][3].ToString());
            }
            return result;
        }
        public ActionResult ViewDocument(string fileName, string path)
        {
            string ReportURL = Server.MapPath("~" + path);
            ViewBag.Link = ReportURL;
            return View();
        }
        public async Task<ActionResult> Document()
        {
            List<DocumentModel> list = new List<DocumentModel>();
            DataTable dtFiles = await new HeThongTaiLieuDAL().SelectDocuments_Student(idKhoi, sta_IdMon);
            foreach (DataRow dr in dtFiles.Rows)
            {
                list.Add(new DocumentModel(dr));
            }
            return View(list);
        }
        ///
        public async Task<ActionResult> TuLuan()
        {
            List<DocumentModel> list = new List<DocumentModel>();
            DataTable dtFiles = await new HeThongTaiLieuDAL().SelectDocuments_Student(idKhoi, sta_IdMon);
            foreach (DataRow dr in dtFiles.Rows)
            {
                list.Add(new DocumentModel(dr));
            }
            return View(list);
        }
        public ActionResult DeThi(string fileName, string path)
        {
            string ReportURL = Server.MapPath("~" + path);
            ViewBag.Link = ReportURL;
            return View();
        }
    }
}