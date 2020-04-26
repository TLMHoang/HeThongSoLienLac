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
    public class MonHocDAL : SQL.SQLHelper, CInterface<MonHoc>
    {
        public async Task<int> CapNhap(MonHoc obj)
        {
            return await ExecuteNonQuery("UpdateMonHoc", new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID},
                new SqlParameter("@TenMon", SqlDbType.NVarChar) { Value = obj.TenMon},
                new SqlParameter("@LoaiDiem", SqlDbType.Bit) { Value = obj.LoaiDiem}
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectMonHoc",new SqlParameter("@ID",SqlDbType.Int) {Value = -1});
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectMonHoc", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }

        public async Task<List<MonHoc>> LayLst()
        {
            List<MonHoc> lst = new List<MonHoc>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new MonHoc(dr));
            }

            return lst;
        }

        public async Task<int> Them(MonHoc obj)
        {
            return await ExecuteNonQuery("InsertMonHoc",
                new SqlParameter("@TenMon", SqlDbType.NVarChar) { Value = obj.TenMon },
                new SqlParameter("@LoaiDiem", SqlDbType.Bit) { Value = obj.LoaiDiem }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteMonHoc",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
    }
}
