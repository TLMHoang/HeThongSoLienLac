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
    public class ThongBaoHSDAL : SQL.SQLHelper, CInterface<ThongBaoHS>
    {
        public async Task<int> CapNhap(ThongBaoHS obj)
        {
            return await ExecuteNonQuery(
                "UpdateThongBaoHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay },
                new SqlParameter("@IDLoaiThongBao", SqlDbType.Int) { Value = obj.IDLoaiThongBao }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectThongBaoHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1}
                );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectThongBaoHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<ThongBaoHS>> LayLst()
        {
            List<ThongBaoHS> lst = new List<ThongBaoHS>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongBaoHS(dr));
            }
            return lst;
        }

        public async Task<int> Them(ThongBaoHS obj)
        {
            return await ExecuteNonQuery(
                "InsertThongBaoHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay },
                new SqlParameter("@IDLoaiThongBao", SqlDbType.Int) { Value = obj.IDLoaiThongBao }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteThongBaoHS", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }

        public async Task<DataTable> LayDT_TheoIDHS(int id)
        {
            return await ExecuteQuery("W_SelectThongBaoHSV2",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = id }
            );
        }
    }
}
