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
    public class LopDAL : SQL.SQLHelper, CInterface<Lop>
    {
        public async Task<int> CapNhap(Lop obj)
        {
            return await ExecuteNonQuery("UpdateLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenLop", SqlDbType.NVarChar) { Value = obj.TenLop }
                ) ; 
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectLop");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(Lop obj)
        {
            return await ExecuteNonQuery("InsertLop", new SqlParameter("@TenLop", SqlDbType.NVarChar) { Value = obj.TenLop });
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteLop", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }
    }
}
