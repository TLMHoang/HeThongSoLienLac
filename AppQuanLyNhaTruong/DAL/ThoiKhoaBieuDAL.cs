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
    public class ThoiKhoaBieuDAL : SQL.SQLHelper, CInterface<ThoiKhoaBieu>
    {
        public async Task<int> CapNhap(ThoiKhoaBieu obj)
        {
            return await ExecuteNonQuery("UpdateThoiKhaoBieu", 
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@Thu", SqlDbType.Int) { Value = obj.Thu },
                new SqlParameter("@Tiet", SqlDbType.Int) { Value = obj.Tiet },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = obj.IDMon }
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectThoiKhaoBieu");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(ThoiKhoaBieu obj)
        {
            return await ExecuteNonQuery("InsertThoiKhaoBieu",
               new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
               new SqlParameter("@Thu", SqlDbType.Int) { Value = obj.Thu },
               new SqlParameter("@Tiet", SqlDbType.Int) { Value = obj.Tiet },
               new SqlParameter("@IDMon", SqlDbType.Int) { Value = obj.IDMon }
           );
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
