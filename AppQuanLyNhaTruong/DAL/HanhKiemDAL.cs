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
    public class HanhKiemDAL : SQL.SQLHelper, CInterface<HanhKiem>
    {
        public async Task<int> CapNhap(HanhKiem obj)
        {
            return await ExecuteNonQuery("UpdateHanhKiem", 
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@Loai", SqlDbType.NVarChar) { Value = obj.Loai },
                new SqlParameter("@HocKy", SqlDbType.Bit) { Value = obj.HocKy }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectHanhKiem",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectHanhKiem",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(HanhKiem obj)
        {
            return await ExecuteNonQuery("InsertHanhKiem",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@Loai", SqlDbType.NVarChar) { Value = obj.Loai },
                new SqlParameter("@HocKy", SqlDbType.Bit) { Value = obj.HocKy }
                );
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
