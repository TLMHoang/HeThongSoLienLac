using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDB.DTO;

namespace ConnectDB.DAL
{
    class ThongTinHSDAL : SQL.SQLHelper, CInterface<ThongTinHS>
    {
        public async Task<int> CapNhap(ThongTinHS obj)
        {
            return await ExecuteNonQuery("UpdateThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID},
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten},
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = obj.NgaySinh },
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh},
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = obj.NoiSinh },
                new SqlParameter("@DanToc", SqlDbType.NVarChar) { Value = obj.DanToc },
                new SqlParameter("@TonGiao", SqlDbType.NVarChar) { Value = obj.TonGiao },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = obj.IDLoaiHocSinh },
                new SqlParameter("@HKI", SqlDbType.Int) { Value = obj.HKI },
                new SqlParameter("@HKII", SqlDbType.Int) { Value = obj.HKII },
                new SqlParameter("@CaNam", SqlDbType.Int) { Value = obj.CaNam }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<ThongTinHS>> LayLst()
        {
            List<ThongTinHS> lst = new List<ThongTinHS>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }
            return lst;
        }

        public Task<int> Them(ThongTinHS obj)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
    }
}
