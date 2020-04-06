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
    public class DiemDanhDAL : SQL.SQLHelper, CInterface<DiemDanh>
    {
        public async Task<int> CapNhap(DiemDanh obj)
        {
            return await ExecuteNonQuery("UpdateDiemDanh",
                new SqlParameter("@ID",SqlDbType.Int) { Value = obj.ID},
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@NgayNghi", SqlDbType.DateTime) { Value = obj.NgayNghi},
                new SqlParameter("@Phep", SqlDbType.Bit) { Value = obj.Phep}
                );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectDiemDanh",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1}
                );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectDiemDanh",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<DiemDanh>> LayLst()
        {
            List<DiemDanh> lst = new List<DiemDanh>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new DiemDanh(dr));
            }

            return lst;
        }

        public async Task<int> Them(DiemDanh obj)
        {
            return await ExecuteNonQuery("InsertDiemDanh",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@NgayNghi", SqlDbType.DateTime) { Value = obj.NgayNghi },
                new SqlParameter("@Phep", SqlDbType.Bit) { Value = obj.Phep }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteDiemDanh",new SqlParameter("@ID",SqlDbType.Int) {Value = ID});
        }
    }
}
