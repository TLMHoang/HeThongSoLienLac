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
    public class MonHocDAL : SQL.SQLHelper, CInterface<MonHoc>
    {
        public async Task<int> CapNhap(MonHoc obj)
        {
            return await ExecuteNonQuery("UpdateMonhoc",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenMon", SqlDbType.NVarChar) { Value = obj.TenMon },
                new SqlParameter("@LoaiDiem", SqlDbType.Int) { Value = obj.LoaiDiem }
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectMonhoc",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectMonhoc",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(MonHoc obj)
        {
            return await ExecuteNonQuery("InsertMonhoc",
                 new SqlParameter("@TenMon", SqlDbType.NVarChar) { Value = obj.TenMon },
                 new SqlParameter("@LoaiDiem", SqlDbType.Int) { Value = obj.LoaiDiem }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteMonhoc", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }
    }
}
