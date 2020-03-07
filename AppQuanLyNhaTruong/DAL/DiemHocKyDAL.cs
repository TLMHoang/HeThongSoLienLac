using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DiemHocKyDAL : SQL.SQLHelper
    {
        public async Task<int> CapNhap(string TenLop, DiemHocKy obj)
        {
            return await ExecuteNonQuery(
                "UpdateDHK" + TenLop,
                new SqlParameter("@STT", SqlDbType.Int) { Value = obj.STT },
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMon },
                new SqlParameter("@Diem", SqlDbType.Float) { Value = obj.Diem },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai },
                new SqlParameter("@HocKy", SqlDbType.Bit) { Value = obj.HocKy }
                );
        }

        public async Task<DataTable> Lay(string TenLop)
        {
            return await ExecuteQuery(
                "SelectDHK" + TenLop,
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(string TenLop, int ID)
        {
            return await ExecuteQuery(
                "SelectDHK" + TenLop,
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(string TenLop, DiemHocKy obj)
        {
            return await ExecuteNonQuery(
                "InsertDHK" + TenLop,
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMon },
                new SqlParameter("@Diem", SqlDbType.Float) { Value = obj.Diem },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai },
                new SqlParameter("@HocKy", SqlDbType.Bit) { Value = obj.HocKy }
                );
        }

        public async Task<int> Xoa(string TenLop, int STT)
        {
            return await ExecuteNonQuery(
                "DeleteDHK" + TenLop,
                new SqlParameter("@STT", SqlDbType.Int) { Value = STT }
                );
        }
    }
}
