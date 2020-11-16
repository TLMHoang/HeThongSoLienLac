using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanTruongDAL : SQL.SQLHelper, CInterface<TaiKhoanTruong>
    {
        public async Task<int> CapNhap(TaiKhoanTruong obj)
        {
            return await ExecuteNonQuery(
                "UpdateTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai },
                new SqlParameter("@TenGV", SqlDbType.NVarChar) { Value = obj.TenGV },
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
                new SqlParameter("@TenGV", SqlDbType.NVarChar) { Value = obj.TenGV },
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
        public async Task<int> DoiMatKhau(int ID, string MatKhauCu, string MatKhauMoi)
        {
            return await ExecuteNonQuery(
                "DoiMatKhauTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                new SqlParameter("@MatKhauCu", SqlDbType.NVarChar) { Value = MatKhauCu },
                new SqlParameter("@MatKhauMoi", SqlDbType.NVarChar) { Value = MatKhauMoi }
                );
        }

        public async Task<DataTable> LayDanhSachTK()
        {
            return await ExecuteQuery(
                "W_SelectTaiKhoanTruongV2",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }
        public async Task<DataTable> LayDanhSachTK(int id)
        {
            return await ExecuteQuery(
                "W_SelectTaiKhoanTruongV2",
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            );
        }

        public async Task<int> ResetPass(int ID)
        {
            return await ExecuteNonQuery("W_UpdateResetPassTaiKhoanTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID}
            );
        }

        public async Task<DataTable> LayDT_ByIdMon(int id)
        {
            return await ExecuteQuery(
                "W_SelectTaiKhoanTruong_ByIdMon",
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = id }
            );
        }
        public async Task<int> CheckExist(string taiKhoan)
        {
            return await ExecuteScalar<int>("W_SelectTaiKhoanTruong_Check", new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = taiKhoan });
        }
        public async Task<int> SetStatus(string taiKhoan,byte trangThai)
        {
            return await ExecuteNonQuery("UpdateTrangThaiTKTruong",
                new SqlParameter("@TaiKhoan", SqlDbType.NVarChar) { Value = taiKhoan },
                new SqlParameter("@TrangThai", SqlDbType.Bit) { Value = trangThai }
            );
        }
        public async Task<DataTable> CheckStatus()
        {
            return await ExecuteQuery(
                "W_SelectTrangThaiTKTruong"
            );
        }
    }
}
