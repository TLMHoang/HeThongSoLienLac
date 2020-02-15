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
                new SqlParameter("@TenMon", SqlDbType.Int) { Value = obj.TenMon },
                new SqlParameter("@LoaiDiem", SqlDbType.Int) { Value = obj.LoaiDiem }
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectMonhoc");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(MonHoc obj)
        {
            return await ExecuteNonQuery("InsertMonhoc",
                 new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                 new SqlParameter("@TenMon", SqlDbType.Int) { Value = obj.TenMon },
                 new SqlParameter("@LoaiDiem", SqlDbType.Int) { Value = obj.LoaiDiem }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteMonhoc", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }
    }
}
