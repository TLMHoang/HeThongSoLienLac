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
    public class LopDAL : SQL.SQLHelper
    {
        SQL.BangDiem val = new SQL.BangDiem();
        public async Task<int> CapNhap(string OldName, Lop obj)
        {
            var a = await ExecuteNonQuery(
                "UpdateLop", 
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID},
                new SqlParameter("@TenLop", SqlDbType.NVarChar) { Value = obj.TenLop }
                //new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien}
                ) ;
            if (a == 1)
            {
                await val.RenameTable(OldName, obj.TenLop);
            }
            return a;
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }


        public async Task<int> Them(Lop obj)
        {
            var a = await ExecuteNonQuery(
                "InsertLop", 
                new SqlParameter("@TenLop", SqlDbType.NVarChar) { Value = obj.TenLop }
                //new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien}
                );
            if (a == 1)
            {
                await val.CreateTable(obj.TenLop);
            }

            return a;
        }

        public async Task<int> Xoa(Lop obj)
        {
            var a = await ExecuteNonQuery("DeleteLop", new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID });

            if (a == 1)
            {
                await val.DeleteTable(obj.TenLop);
            }

            return a;
        }
    }
}
