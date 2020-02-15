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
    public class CupHocDAL : SQL.SQLHelper, CInterface<CupHoc>
    {
        public async Task<int> CapNhap(CupHoc obj)
        {
            return await ExecuteNonQuery("UpdateCupHoc",
                new SqlParameter("@STT", SqlDbType.Int) { Value=obj.STT},
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh},
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay },
                new SqlParameter("@NghiTu", SqlDbType.Int) { Value = obj.NghiTu },
                new SqlParameter("@NghiDen", SqlDbType.Int) { Value = obj.NghiDen },
                new SqlParameter("@SoTietNghi", SqlDbType.Int) { Value = obj.SoTietNghi }
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectCupHoc");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(CupHoc obj)
        {
            return await ExecuteNonQuery("UpdateCupHoc",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay },
                new SqlParameter("@NghiTu", SqlDbType.Int) { Value = obj.NghiTu },
                new SqlParameter("@NghiDen", SqlDbType.Int) { Value = obj.NghiDen },
                new SqlParameter("@SoTietNghi", SqlDbType.Int) { Value = obj.SoTietNghi }
            );
        }

        public async Task<int> Xoa(int STT)
        {
            return await ExecuteNonQuery("DeleteCupHoc", new SqlParameter("@STT", SqlDbType.Int) { Value = STT });
        }
    }
}
