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
    public class ThongBaoHSDAL : SQL.SQLHelper, CInterface<ThongBaoHS>
    {
        public async Task<int> CapNhap(ThongBaoHS obj)
        {
            return await ExecuteNonQuery("UpdateThongBaoH", 
                new SqlParameter("@STT", SqlDbType.Int) { Value = obj.STT },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectThongBaoHS");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(ThongBaoHS obj)
        {
            return await ExecuteNonQuery("InsertThongBaoH",
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung }
                );
        }

        public async Task<int> Xoa(int STT)
        {
            return await ExecuteNonQuery("DeleteThongBaoHS", new SqlParameter("@STT", SqlDbType.Int) { Value = STT });
        }
    }
}
