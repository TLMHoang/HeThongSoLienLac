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
    public class LoaiHocSinhDAL : SQL.SQLHelper, CInterface<LoaiHocSinh>
    {
        public async Task<int> CapNhap(LoaiHocSinh obj)
        {
            return await ExecuteNonQuery("UpdateLoaiHocSinh",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID},
                new SqlParameter("@TenLoai", SqlDbType.NVarChar) { Value = obj.TenLoai }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectLoaiHocSinh",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 });
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectLoaiHocSinh",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }

        public async Task<List<LoaiHocSinh>> LayLst()
        {
            List<LoaiHocSinh> lst = new List<LoaiHocSinh>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new LoaiHocSinh(dr));
            }
            return lst;
        }

        public async Task<int> Them(LoaiHocSinh obj)
        {
            return await ExecuteNonQuery("InsertLoaiHocSinh",
                new SqlParameter("@TenLoai", SqlDbType.NVarChar) { Value = obj.TenLoai }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteLoaiHocSinh",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
    }
}
