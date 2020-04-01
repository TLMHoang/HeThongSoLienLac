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
    public class KhoiDAL : SQL.SQLHelper, CInterface<Khoi>
    {
        public async Task<int> CapNhap(Khoi obj)
        {
            return await ExecuteNonQuery(
                "UpdateKhoi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenKhoi", SqlDbType.VarChar) { Value = obj.TenKhoi }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectKhoi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectKhoi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<Khoi>> LayLst()
        {
            List<Khoi> lst = new List<Khoi>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Khoi(dr));
            }

            return lst;
        }

        public async Task<int> Them(Khoi obj)
        {
            return await ExecuteNonQuery(
                "InsertKhoi",
                new SqlParameter("@TenKhoi", SqlDbType.VarChar) { Value = obj.TenKhoi }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteKhoi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID}
            );
        }
    }
}
