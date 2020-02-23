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
        public async Task<int> CapNhap(TaiKhoanTruong obj)
        {
            return await ExecuteNonQuery(
                "UpdateTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(TaiKhoanTruong obj)
        {
            return await ExecuteNonQuery(
                "InsertTaiKhoanTruong",
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<DataTable> DangNhap(string TaiKhoan, string MatKhau)
        {
            return await ExecuteQuery(
                "DangNhapTruong",
                new SqlParameter("@TaiKhoan", SqlDbType.NVarChar) { Value = TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = MatKhau });
        }
    }
}
