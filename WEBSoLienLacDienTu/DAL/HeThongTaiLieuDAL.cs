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
    public class HeThongTaiLieuDAL:SQL.SQLHelper
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

        public async Task<DataTable> GetQues(int IDQuiz)
        {
            return await ExecuteQuery_HTTL(
                "selectQues",
                new SqlParameter("@IDQuiz", SqlDbType.Int) { Value = IDQuiz });
        }

        public async Task<DataTable> GetAns(int IDQues)
        {
            return await ExecuteQuery_HTTL(
                "selectAns",
                new SqlParameter("@IDQues", SqlDbType.Int) { Value = IDQues });
        }
    }
}
