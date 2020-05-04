using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TaiKhoanPhDal : SQL.SQLHelper, CInterface<TaiKhoanPH>
    {
        public async Task<int> CapNhap(TaiKhoanPH obj)
        {
            return await ExecuteNonQuery(
                "UpdateTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@TenMe", SqlDbType.NVarChar) { Value = obj.TenMe },
                new SqlParameter("@SDTMe", SqlDbType.VarChar) { Value = obj.SDTMe },
                new SqlParameter("@TenBo", SqlDbType.NVarChar) { Value = obj.TenBo },
                new SqlParameter("@SDTBo", SqlDbType.VarChar) { Value = obj.SDTBo }
                );
        }
        public async Task<int> CapNhapTT(TaiKhoanPH obj)
        {
            return await ExecuteNonQuery(
                "W_UpdateTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = obj.TaiKhoan },
                new SqlParameter("@TenMe", SqlDbType.NVarChar) { Value = obj.TenMe },
                new SqlParameter("@SDTMe", SqlDbType.VarChar) { Value = obj.SDTMe },
                new SqlParameter("@TenBo", SqlDbType.NVarChar) { Value = obj.TenBo },
                new SqlParameter("@SDTBo", SqlDbType.VarChar) { Value = obj.SDTBo }
            );
        }
        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<TaiKhoanPH>> LayLst()
        {
            List<TaiKhoanPH> lst = new List<TaiKhoanPH>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TaiKhoanPH(dr));
            }

            return lst;
        }

        public async Task<int> Them(TaiKhoanPH obj)
        {
            return await ExecuteNonQuery(
                "InsertTaiKhoanPH",
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = obj.TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@TenMe", SqlDbType.NVarChar) { Value = obj.TenMe },
                new SqlParameter("@SDTMe", SqlDbType.VarChar) { Value = obj.SDTMe },
                new SqlParameter("@TenBo", SqlDbType.NVarChar) { Value = obj.TenBo },
                new SqlParameter("@SDTBo", SqlDbType.VarChar) { Value = obj.SDTBo }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
        public async Task<DataTable> DangNhap(string TaiKhoan, string MatKhau)
        {
            return await ExecuteQuery(
                "DangNhapPH",
                new SqlParameter("@TaiKhoan", SqlDbType.NVarChar) { Value = TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = MatKhau });
        }
        public async Task<int> DoiMatKhau(int ID, string MatKhauCu, string MatKhauMoi)
        {
            return await ExecuteNonQuery(
                "DoiMatKhauPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                new SqlParameter("@MatKhauCu", SqlDbType.VarChar) { Value = MatKhauCu },
                new SqlParameter("@MatKhauMoi", SqlDbType.VarChar) { Value = MatKhauMoi }
                );
        }

        public async Task<int> ResetPass(int ID)
        {
            return await ExecuteNonQuery("W_UpdateResetPassTaiKhoanPH",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<int> CheckExist(string taiKhoan)
        {
            return await ExecuteScalar<int>("W_SelectTaiKhoanPH_Check",new SqlParameter("@TaiKhoan",SqlDbType.VarChar) {Value = taiKhoan} );
        }

        public async Task<DataTable> Search(string chuoiTimKiem)
        {
            return await ExecuteQuery("W_SelectTaiKhoanPH_Search", new SqlParameter("@TaiKhoan",SqlDbType.VarChar) {Value = chuoiTimKiem});
        }
    }
}

