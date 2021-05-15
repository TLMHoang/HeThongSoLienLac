using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model;

namespace DAL
{
    public class HeThongTaiLieuDAL : SQL.SQLHelper
    {
        public async Task<DataTable> StudenLogin(string TaiKhoan, string MatKhau)
        {
            return await ExecuteQuery_HTTL(
                "Login_HTTL",
                new SqlParameter("@TaiKhoan", SqlDbType.NVarChar) { Value = TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = MatKhau });
        }
        public async Task<int> CreateStudent(string TaiKhoan, string MatKhau)
        {
            return await ExecuteNonQuery_HTTL(
                "InsertStudents",
                new SqlParameter("@TaiKhoan", SqlDbType.NVarChar) { Value = TaiKhoan },
                new SqlParameter("@NgayTao", SqlDbType.Date) { Value = DateTime.Now },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = MatKhau });
        }
        public async Task<int> DeleteDocument(int ID)
        {
            return await ExecuteNonQuery_HTTL(
                "DeleteDocument",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }
        public async Task<List<QuesTopicModel>> GetListTopic(int idMon, int idKhoi)
        {
            DataTable dt = await ExecuteQuery_HTTL("selecttopic",
                  new SqlParameter("@idMon", SqlDbType.Int) { Value = idMon },
                  new SqlParameter("@idKhoi", SqlDbType.Int) { Value = idKhoi }
                );
            List<QuesTopicModel> lst = new List<QuesTopicModel>();
            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new QuesTopicModel(dr));
            }
            return lst;

        }
        public async Task<DataTable> GetListTopic2(int idMon, int idTeacher)
        {
            return await ExecuteQuery_HTTL("selecttopic2",
                 new SqlParameter("@idMon", SqlDbType.Int) { Value = idMon },
                 new SqlParameter("@idteacher", SqlDbType.Int) { Value = idTeacher }
               );

        }
        public async Task<DataTable> GetQues(int IDQuiz)
        {
            return await ExecuteQuery_HTTL(
                "selectQues",
                new SqlParameter("@IDQuiz", SqlDbType.Int) { Value = IDQuiz });
        }
        public async Task<DataTable> InsertQues(string ques, int idquiz, int level)
        {
            return await ExecuteQuery_HTTL("insertQuesTopic",
                 new SqlParameter("@Question", SqlDbType.NVarChar) { Value = ques },
                 new SqlParameter("@IDQuiz", SqlDbType.Int) { Value = idquiz },
                 new SqlParameter("@Level", SqlDbType.Int) { Value = level }
               );
        }
        public async Task<int> InsertAns(int IDQues, string Ans, string Ex, byte correct)
        {
            return await ExecuteNonQuery_HTTL(
                "insertAns",
                new SqlParameter("@IDQuestion", SqlDbType.Int) { Value = IDQues },
                new SqlParameter("@Ans", SqlDbType.NVarChar) { Value = Ans },
            new SqlParameter("@explain", SqlDbType.NVarChar) { Value = Ex },
            new SqlParameter("@correct", SqlDbType.Bit) { Value = correct }
            );
        }
        public async Task<int> InsertDocument(int IdTeacher, DateTime NgayTao, int IdKhoi, int IdMon, string DuongDan, string Ten)
        {
            return await ExecuteNonQuery_HTTL(
                "InsertDocument",
                new SqlParameter("@IdTeacher", SqlDbType.Int) { Value = IdTeacher },
                new SqlParameter("@NgayTao", SqlDbType.Date) { Value = NgayTao },
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = IdKhoi },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = IdMon },
                new SqlParameter("@path", SqlDbType.NVarChar) { Value = DuongDan },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = Ten }
            );
        }
        public async Task<DataTable> SelectDocuments(int IdTeacher,int IdKhoi,int IdMon)
        {
            return await ExecuteQuery_HTTL(
                "SelectDocuments",
                new SqlParameter("@IDTeacher", SqlDbType.Int) { Value = IdTeacher },
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = IdKhoi },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = IdMon }
                );
        }
        public async Task<int> InsertQuiz(int IDMon, int IDGV, DateTime NgayTao, string Ten, int IDKhoi)
        {
            return await ExecuteNonQuery_HTTL(
                "insertQuiz",
                new SqlParameter("@IdMon", SqlDbType.Int) { Value = IDMon },
                new SqlParameter("@IdGV", SqlDbType.Int) { Value = IDGV },
                new SqlParameter("@NgayTao", SqlDbType.DateTime) { Value = NgayTao },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = Ten },
                new SqlParameter("@IdKhoi", SqlDbType.Int) { Value = IDKhoi }
            );
        }
        public async Task<DataTable> GetListQues_Ans(int IDQuiz)
        {
            return await ExecuteQuery_HTTL(
                "SelectListQuest",
                new SqlParameter("@IDQuiz", SqlDbType.Int) { Value = IDQuiz });
        }
        public async Task<DataTable> GetAns(int IDQues)
        {
            return await ExecuteQuery_HTTL(
                "selectAns",
                new SqlParameter("@IDQues", SqlDbType.Int) { Value = IDQues });
        }

        public async Task<DataTable> GetScores(int IDStudent, int IDTopic)
        {
            return await ExecuteQuery_HTTL(
                "selectScores",
                new SqlParameter("@IDStudent", SqlDbType.Int) { Value = IDStudent },
                new SqlParameter("@IDTopic", SqlDbType.Int) { Value = IDTopic }
                );
        }

        public async Task<int> CreateScores(int IDStudent, int IDTopic, int efficiencyLevel)
        {
            return await ExecuteNonQuery_HTTL(
                "insertScores",
                new SqlParameter("@IDStudent", SqlDbType.Int) { Value = IDStudent },
                new SqlParameter("@IDTopic", SqlDbType.Int) { Value = IDTopic },
                new SqlParameter("@efficiencyLevel", SqlDbType.Int) { Value = efficiencyLevel });
        }
        public async Task<int> UpdateScoresLevel(int IDStudent, int IDTopic, int efficiencyLevel)
        {
            return await ExecuteNonQuery_HTTL(
                "updateScores",
                new SqlParameter("@IDStudent", SqlDbType.Int) { Value = IDStudent },
                new SqlParameter("@IDTopic", SqlDbType.Int) { Value = IDTopic },
                new SqlParameter("@efficiencyLevel", SqlDbType.Int) { Value = efficiencyLevel });
        }
        public async Task<DataTable> CountQueslevel(int level)
        {
            return await ExecuteQuery_HTTL(
                "selectQuesLevel",
                new SqlParameter("@level", SqlDbType.Int) { Value = level }
                );
        }
    }
}
