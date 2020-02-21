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
    public class ThongBaoLopDAL : SQL.SQLHelper, CInterface<ThongBaoLop>
    {
        public async Task<int> CapNhap(ThongBaoLop obj)
        {
            return await ExecuteNonQuery("UpdateThongBaoLop",
                new SqlParameter("@STT", SqlDbType.Int) { Value = obj.STT },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectThongBaoLop");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(ThongBaoLop obj)
        {
            return await ExecuteNonQuery("InsertThongBaoLop",
                 new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                 new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung }
                 );
        }

        public async Task<int> Xoa(int STT)
        {
            return await ExecuteNonQuery("DeleteThongBaoLop", new SqlParameter("@STT", SqlDbType.Int) { Value = STT });
        }
    }
}
