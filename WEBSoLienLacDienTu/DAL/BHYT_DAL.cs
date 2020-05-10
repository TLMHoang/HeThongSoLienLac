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
    public class BHYT_DAL : SQL.SQLHelper,CInterface<BHYT>
    {
        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectBHYT",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectBHYT",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<BHYT>> LayLst()
        {
            List<BHYT> lst = new List<BHYT>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new BHYT(dr));
            }
            return lst;
        }

        public async Task<int> CapNhap(BHYT obj)
        {
            return await ExecuteNonQuery("UpdateBHYT",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh},
                new SqlParameter("@DangKy", SqlDbType.Bit) { Value = obj.DangKy },
                new SqlParameter("@BHQD", SqlDbType.Bit) { Value = obj.BHQD }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery("DeleteBHYT", new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = ID });
        }

        public async Task<int> Them(BHYT obj)
        {
            return await ExecuteNonQuery("InsertBHYT",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@DangKy", SqlDbType.Bit) { Value = obj.DangKy },
                new SqlParameter("@BHQD", SqlDbType.Bit) { Value = obj.BHQD }
            );
        }
        public async Task<DataTable> CheckDateBhyt()
        {
            return await ExecuteQuery("W_SelectFunctionOrder_BHYT");
        }
    }
}
