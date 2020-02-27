using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GVCNDAL : SQL.SQLHelper
    {
        public async Task<int> CapNhap(GVCN obj)
        {
            return await ExecuteNonQuery(
                "UpdateGVCN",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectGVCN",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = -1 },
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(GVCN obj)
        {
            return await ExecuteQuery(
                "SelectGVCN",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien }
                );
        }

        public async Task<int> Them(GVCN obj)
        {
            return await ExecuteNonQuery(
                "InsertGVCN",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien }
                );
        }

        public async Task<int> Xoa(GVCN obj)
        {
            return await ExecuteNonQuery(
                "DeleteGVCN",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien }
                );
        }
    }
}
