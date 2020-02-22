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
    public class XinPhepDAL : SQL.SQLHelper, CInterface<XinPhep>
    {
        public async Task<int> CapNhap(XinPhep obj)
        {
            return await ExecuteNonQuery("UpdateXinPhep", 
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value= obj.IDHocSinh},
                new SqlParameter("@NghiTu", SqlDbType.Date) { Value = obj.NghiTu },
                new SqlParameter("@NghiDen", SqlDbType.Date) { Value = obj.NghiDen },
                new SqlParameter("@SoNgayNghi", SqlDbType.Int) { Value = obj.SoNgayNghi }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("SelectXinPhep");
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(XinPhep obj)
        {
            return await ExecuteNonQuery("InsertXinPhep",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh},
                new SqlParameter("@NghiTu", SqlDbType.Date) { Value=obj.NghiTu},
                new SqlParameter("@NghiDen", SqlDbType.Date) { Value=obj.NghiDen},
                new SqlParameter("@SoNgayNghi", SqlDbType.Int) { Value=obj.SoNgayNghi}
                );
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
