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
                new SqlParameter("@NghiTu", SqlDbType.DateTime) { Value = obj.NghiTu},
                new SqlParameter("@NghiDen", SqlDbType.DateTime) { Value = obj.NghiDen},
                new SqlParameter("@SoNgayNghi", SqlDbType.Int) { Value = obj.SoNgayNghi },
                new SqlParameter("@Phep", SqlDbType.Bit) { Value = obj.Phep }
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectDiemDanh");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(DiemDanh obj)
        {
            return await ExecuteNonQuery("InsertDiemDanh",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@NghiTu", SqlDbType.DateTime) { Value = obj.NghiTu },
                new SqlParameter("@NghiDen", SqlDbType.DateTime) { Value = obj.NghiDen },
                new SqlParameter("@SoNgayNghi", SqlDbType.Int) { Value = obj.SoNgayNghi },
                new SqlParameter("@Phep", SqlDbType.Bit) { Value = obj.Phep }
            );
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
