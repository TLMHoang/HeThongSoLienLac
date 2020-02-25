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
    public class ThongTinGVDAL : SQL.SQLHelper, CInterface<ThongTinGV>
    {
        public async Task<int> CapNhap(ThongTinGV obj)
        {
            return await ExecuteNonQuery("UpdateThongTinGV",
                new SqlParameter("@IDTKT", SqlDbType.Int) { Value = obj.IDTKT },
                new SqlParameter("@TenGV", SqlDbType.NVarChar) { Value = obj.TenGV},
                new SqlParameter("@SDT", SqlDbType.VarChar) { Value = obj.SDT },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc}
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectThongTinGV",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1}
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectThongTinGV",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(ThongTinGV obj)
        {
            return await ExecuteNonQuery("InsertThongTinGV",
                 new SqlParameter("@IDTKT", SqlDbType.Int) { Value = obj.IDTKT },
                 new SqlParameter("@TenGV", SqlDbType.NVarChar) { Value = obj.TenGV },
                 new SqlParameter("@SDT", SqlDbType.VarChar) { Value = obj.SDT },
                 new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc }
                 );
        }

        public async Task<int> Xoa(int IDTKT)
        {
            return await ExecuteNonQuery("DeleteThongTinGV", new SqlParameter("@IDTKT", SqlDbType.Int) { Value = IDTKT });
        }
    }
}
