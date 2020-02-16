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
                new SqlParameter("@TaiKhoan", SqlDbType.Int) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectTaiKhoanPH");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(TaiKhoanPH obj)
        {
            return await ExecuteNonQuery("InsertTaiKhoanPH",
                new SqlParameter("@TaiKhoan", SqlDbType.Int) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteTaiKhoanPH", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }
    }
}
