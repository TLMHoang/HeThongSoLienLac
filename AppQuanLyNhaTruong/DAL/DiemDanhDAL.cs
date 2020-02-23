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
    public class DiemDanhDAL : SQL.SQLHelper, CInterface<DiemDanh>
    {
        public async Task<int> CapNhap(DiemDanh obj)
        {
            return await ExecuteNonQuery("UpdateDiemDanh", 
                new SqlParameter("@STT", SqlDbType.Int) { Value = obj.STT },
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh},
                new SqlParameter("@NgayNghi", SqlDbType.Date) { Value = obj.NgayNghi },
                new SqlParameter("@Phep", SqlDbType.Bit) { Value = obj.Phep }
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectDiemDanh",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectDiemDanh",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(DiemDanh obj)
        {
            return await ExecuteNonQuery("InsertDiemDanh",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@NgayNghi", SqlDbType.Date) { Value = obj.NgayNghi },
                new SqlParameter("@Phep", SqlDbType.Bit) { Value = obj.Phep }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteDiemDanh", new SqlParameter("@STT", SqlDbType.Int) { Value = ID });
        }

        public async Task<DataTable> LaySTT(int IDHS, DateTime NgayNghi)
        {
            return await ExecuteQuery(
                "LaySTTDiemDanh",
                new SqlParameter("@IDHS", SqlDbType.Int) { Value = IDHS },
                new SqlParameter("@NgayNghi", SqlDbType.Date) { Value = NgayNghi}
                );
        }
    }
}
