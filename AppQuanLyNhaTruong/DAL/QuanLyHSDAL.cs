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
    public class QuanLyHSDAL :SQL.SQLHelper
    {
        public async Task<int> CapNhap(QuanLyHS obj)
        {
            return await ExecuteNonQuery(
                "UpdateQuanLyHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectQuanLyHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = -1 },
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(QuanLyHS obj)
        {
            return await ExecuteQuery(
                "SelectQuanLyHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan }
                );
        }

        public async Task<int> Them(QuanLyHS obj)
        {
            return await ExecuteNonQuery(
                "InsertQuanLyHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan }
                );
        }

        public async Task<int> Xoa(QuanLyHS obj)
        {
            return await ExecuteNonQuery(
                "DeleteQuanLyHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan }
                );
        }
    }
}
