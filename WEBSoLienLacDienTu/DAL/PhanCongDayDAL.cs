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
    public class PhanCongDayDAL:SQL.SQLHelper,CInterface<PhanCongDay>
    {
        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectPhanCongDay",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1}
                );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectPhanCongDay",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<PhanCongDay>> LayLst()
        {
            List<PhanCongDay> lst = new List<PhanCongDay>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new PhanCongDay(dr));
            }
            return lst;
        }

        public async Task<int> CapNhap(PhanCongDay obj)
        {
            return await ExecuteNonQuery("UpdatePhanCongDay",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID},
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeletePhanCongDay", new SqlParameter("@ID", SqlDbType.Int) {Value = ID});
        }

        public async Task<int> Them(PhanCongDay obj)
        {
            return await ExecuteNonQuery("InsertPhanCongDay",
                new SqlParameter("@IDGiaoVien", SqlDbType.Int) { Value = obj.IDGiaoVien },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop }
            );
        }
        public async Task<DataTable> DanhSachLopDay_ByIdGv(int ID)
        {
            return await ExecuteQuery("SelectPhanCongDay_ByIdGv",
                new SqlParameter("@IDGV", SqlDbType.Int) { Value = ID }
            );
        }
    }
}
