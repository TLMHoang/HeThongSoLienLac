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
    public class CupHocDAL : SQL.SQLHelper, CInterface<CupHoc>
    {
        public async Task<int> CapNhap(CupHoc obj)
        {
            return await ExecuteNonQuery("UpdateCupHoc",
                new SqlParameter("@STT", SqlDbType.Int) { Value=obj.STT},
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh},
                new SqlParameter("@Ngay", SqlDbType.Date) { Value = obj.Ngay },
                new SqlParameter("@Tiet", SqlDbType.Int) { Value = obj.Tiet }
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectCupHoc",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectCupHoc",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = ID }
                );
        }
        public async Task<int> Them(CupHoc obj)
        {
            return await ExecuteNonQuery("InsertCupHoc",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@Ngay", SqlDbType.Date) { Value = obj.Ngay },
                new SqlParameter("@Tiet", SqlDbType.Int) { Value = obj.Tiet }
            );
        }

        public async Task<int> Xoa(int STT)
        {
            return await ExecuteNonQuery("DeleteCupHoc", new SqlParameter("@STT", SqlDbType.Int) { Value = STT });
        }
    }
}
