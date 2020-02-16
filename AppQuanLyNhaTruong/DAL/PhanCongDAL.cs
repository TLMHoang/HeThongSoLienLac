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
    public class PhanCongDAL : SQL.SQLHelper, CInterface<PhanCong>
    {
        public async Task<int> CapNhap(PhanCong obj)
        {
            return await ExecuteNonQuery("UpdatePhanCong",
                new SqlParameter("@STT", SqlDbType.Int) { Value = obj.STT },
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = obj.IDMon }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectPhanCong");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(PhanCong obj)
        {
            return await ExecuteNonQuery("InsertPhanCong",           
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = obj.IDMon }
                );
        }

        public async Task<int> Xoa(int STT)
        {
            return await ExecuteNonQuery("DeletePhanCong", new SqlParameter("@STT", SqlDbType.Int) { Value = STT });
        }
    }
}
