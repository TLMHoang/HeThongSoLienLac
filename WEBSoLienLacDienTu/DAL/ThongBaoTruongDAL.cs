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
    public class ThongBaoTruongDAL: SQL.SQLHelper,CInterface<ThongBaoTruong>
    {
        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectThongBaoTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1}
                );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectThongBaoTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<ThongBaoTruong>> LayLst()
        {
            List<ThongBaoTruong> lst = new List<ThongBaoTruong>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongBaoTruong(dr));
            }

            return lst;
        }

        public async Task<int> CapNhap(ThongBaoTruong obj)
        {
            return await ExecuteNonQuery("UpdateThongBaoTruong",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay },
                new SqlParameter("@IDLoaiThongBao", SqlDbType.Int) { Value = obj.IDLoaiThongBao }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteThongBaoTruong", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }

        public async Task<int> Them(ThongBaoTruong obj)
        {

            return await ExecuteNonQuery("InsertThongBaoTruong",
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay},
                new SqlParameter("@IDLoaiThongBao", SqlDbType.Int) { Value = obj.IDLoaiThongBao }
            );
        }
    }
}
