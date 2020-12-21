using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BotChat : SQL.SQLHelper
    {
        public async Task<int> Them(NoiDungChat obj)
        {
            return await ExecuteNonQuery_BotChat("InsertChat",
                new SqlParameter("@IDKhachHang", SqlDbType.Int) { Value = obj.IDKhachHang },
                new SqlParameter("@ThoiGian", SqlDbType.DateTime) { Value = obj.ThoiGian },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung }
            );
        }
        public async Task<DataTable> GetData()
        {
            return await ExecuteQuery_BotChat("SoLanBotChat");
        }
       
    }
    
}
