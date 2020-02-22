using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class TaiKhoanPHDAL : SQL.SQLHelper, CInterface<TaiKhoanPH>
    {
        public async Task<int> CapNhap(TaiKhoanPH obj)
        {
            return await ExecuteNonQuery("UpdateTaiKhoanPH", 
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(TaiKhoanPH obj)
        {
            return await ExecuteNonQuery("InsertTaiKhoanPH",
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteTaiKhoanPH", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }
    }
}
