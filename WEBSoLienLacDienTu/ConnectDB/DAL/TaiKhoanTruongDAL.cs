using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDB.DTO;

namespace ConnectDB.DAL
{
    class TaiKhoanTruongDAL : SQL.SQLHelper, CInterface<TaiKhoanTruong>
    {
        public async Task<int> CapNhap(TaiKhoanTruong obj)
        {
            return await ExecuteNonQuery(
                "UpdateTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai },
                new SqlParameter("@TenGV", SqlDbType.VarChar) { Value = obj.TenGV },
                new SqlParameter("@SDT", SqlDbType.VarChar) { Value = obj.SDT },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<TaiKhoanTruong>> LayLst()
        {
            List<TaiKhoanTruong> lst = new List<TaiKhoanTruong>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TaiKhoanTruong(dr));
            }

            return lst;
        }

        public async Task<int> Them(TaiKhoanTruong obj)
        {
            return await ExecuteNonQuery(
                "InsertTaiKhoanTruong",
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai },
                new SqlParameter("@TenGV", SqlDbType.VarChar) { Value = obj.TenGV },
                new SqlParameter("@SDT", SqlDbType.VarChar) { Value = obj.SDT },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop }
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
