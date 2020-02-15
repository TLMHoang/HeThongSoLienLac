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
    public class ThongBaoTruongDAL : SQL.SQLHelper, CInterface<ThongBaoTruong>
    {
        public async Task<int> CapNhap(ThongBaoTruong obj)
        {
            return await ExecuteNonQuery("UpdateThongBaoTruong",
                new SqlParameter("@STT", SqlDbType.Int) { Value = obj.STT },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung });
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectThongBaoTruong");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(ThongBaoTruong obj)
        {
            return await ExecuteNonQuery("InsertThongBaoTruong", new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung });
        }

        public async Task<int> Xoa(int STT)
        {
            return await ExecuteNonQuery("DeleteThongBaoTruong", new SqlParameter("@STT", SqlDbType.Int) { Value = STT });
        }
    }
}
