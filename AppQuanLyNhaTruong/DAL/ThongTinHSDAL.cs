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
    public class ThongTinHSDAL : SQL.SQLHelper, CInterface<ThongTinHS>
    {
        public async Task<int> CapNhap(ThongTinHS obj)
        {
            return await ExecuteNonQuery("UpdateThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten},
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = obj.NgaySinh},
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh},
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = obj.NoiSinh},
                new SqlParameter("@DanhToc", SqlDbType.NVarChar) { Value = obj.DanToc },
                new SqlParameter("@TonGiao", SqlDbType.NVarChar) { Value = obj.TonGiao },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop},
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan },
                new SqlParameter("@TenMe", SqlDbType.NVarChar) { Value = obj.TenMe },
                new SqlParameter("@SDTMe", SqlDbType.NVarChar) { Value = obj.SDTMe},
                new SqlParameter("@TenBo", SqlDbType.NVarChar) { Value = obj.TenBo},
                new SqlParameter("@SDTBo", SqlDbType.NVarChar) { Value = obj.SDTBo}
            );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "SelectThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1}
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "SelectThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<int> Them(ThongTinHS obj)
        {
            return await ExecuteNonQuery("InsertThongTinHS",
               new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten },
               new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = obj.NgaySinh },
               new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh },
               new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = obj.NoiSinh },
               new SqlParameter("@DanhToc", SqlDbType.NVarChar) { Value = obj.DanToc },
               new SqlParameter("@TonGiao", SqlDbType.NVarChar) { Value = obj.TonGiao },
               new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
               new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan },
               new SqlParameter("@TenMe", SqlDbType.NVarChar) { Value = obj.TenMe },
               new SqlParameter("@SDTMe", SqlDbType.NVarChar) { Value = obj.SDTMe },
               new SqlParameter("@TenBo", SqlDbType.NVarChar) { Value = obj.TenBo },
               new SqlParameter("@SDTBo", SqlDbType.NVarChar) { Value = obj.SDTBo }

           );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteThongTinHS", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }
    }
}
