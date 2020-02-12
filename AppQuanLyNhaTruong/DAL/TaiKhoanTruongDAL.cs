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
    public class TaiKhoanTruongDAL : SQL.SQLHelper, CInterface<TaiKhoanTruong>
    {
        public Task<int> CapNhap(TaiKhoanTruong obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Lay()
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(TaiKhoanTruong obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<DataTable> DangNhap(string TaiKhoan, string MatKhau)
        {
            return await ExecuteQuery(
                "DangNhap",
                new SqlParameter("@TaiKhoan", SqlDbType.NVarChar) { Value = TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = MatKhau });
        }
    }
}
