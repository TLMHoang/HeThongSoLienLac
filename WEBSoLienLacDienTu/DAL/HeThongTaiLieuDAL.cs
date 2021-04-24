using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
