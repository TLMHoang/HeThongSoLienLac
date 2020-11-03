using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonHocPhiDAL : SQL.SQLHelper, CInterface<HoaDonHocPhi>
    {
        public Task<int> CapNhap(HoaDonHocPhi obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<HoaDonHocPhi>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(HoaDonHocPhi obj)
        {
            throw new NotImplementedException();
        }

        public async Task<DataTable> ThemHoaDon(int idHocPhi,int idHocSinh,DateTime ngayTao,byte thanhToan)
        {
            return await ExecuteQuery("InsertHoaDonHocPhi",
                    new SqlParameter("@IDHocPhi", SqlDbType.Int) { Value = idHocPhi },
                    new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = idHocSinh },
                    new SqlParameter("@NgayTao", SqlDbType.DateTime) { Value = ngayTao },
                    new SqlParameter("@ThanhToan", SqlDbType.Bit) { Value = thanhToan }
                );
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
