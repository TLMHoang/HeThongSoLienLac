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

            var result = await httl.StudenLogin(hs.UserName, hs.PassWord);
            if (ModelState.IsValid)
            {

                if (result.Rows.Count == 1)
                {
                    DataTable dt = await new ThongTinHSDAL().LayDT(int.Parse(hs.UserName.Remove(0, 3)));
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
            return View(await new HeThongTaiLieuDAL().GetListTopic(idMon, l.IDKhoi));
        }

        public async Task<ActionResult> Test_Student(int idquiz)
        {
            var random = new Random();
            List<QuestionModel> lstQues = await getQues(idquiz);
            
            
            MergeQues mymodel = new MergeQues();
            QuestionModel question = lstQues[random.Next(lstQues.Count)];
            List<AnswerModel> lstAns = await getAns(question.ID);
            
            mymodel.Question =question;

            mymodel.LstAns = lstAns;
            
            return View(mymodel);
        }

        public async Task<List<QuestionModel>> getQues(int idquiz){
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
    }
}