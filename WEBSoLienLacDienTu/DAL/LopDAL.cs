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
    public class LopDAL : SQL.SQLHelper, CInterface<Lop>
    {
        public async Task<int> CapNhap(Lop obj)
        {
            return await ExecuteNonQuery(
                "UpdateLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = obj.IDKhoi },
                new SqlParameter("@TenLop", SqlDbType.VarChar) { Value = obj.TenLop }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<Lop>> LayLst()
        {
            List<Lop> lst = new List<Lop>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Lop(dr));
            }

            return lst;
        }

        public async Task<int> Them(Lop obj)
        {
            return await ExecuteNonQuery(
                "InsertLop",
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = obj.IDKhoi },
                new SqlParameter("@TenLop", SqlDbType.VarChar) { Value = obj.TenLop }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<DataTable> LayDTLopTheoKhoi(int ID)
        {
            return await ExecuteQuery(
                "SelectLopTheoKhoi",
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = ID }
            );
        }
        public async Task<DataTable> LayTenLop(int ID)
        {
            return await ExecuteQuery(
                "SelectLopTheoKhoi_LayTen",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = ID }
            );
        }
    }
}
