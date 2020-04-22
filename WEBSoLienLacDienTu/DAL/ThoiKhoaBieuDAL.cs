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
    public class ThoiKhoaBieuDAL : SQL.SQLHelper
    {
        public async Task<int> CapNhap(ThoiKhoaBieu obj)
        {
            return await ExecuteNonQuery(
                "UpdateThoiKhoaBieu",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop},
                new SqlParameter("@Thu", SqlDbType.Int) { Value = obj.Thu },
                new SqlParameter("@Tiet", SqlDbType.Int) { Value = obj.Tiet },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc}
            );
        }

        public async Task<DataTable> LayDT(int idlop,int thu,int tiet)
        {
            return await ExecuteQuery(
                "SelectThoiKhoaBieu",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = idlop },
                new SqlParameter("@Thu", SqlDbType.Int) { Value = thu },
                new SqlParameter("@Tiet", SqlDbType.Int) { Value = tiet }
            );
        }

        public Task<DataTable> LayDT(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ThoiKhoaBieu>> LayLst(int idlop, int thu, int tiet)
        {
            List<ThoiKhoaBieu> lst = new List<ThoiKhoaBieu>();
            foreach (DataRow dr in (await LayDT(idlop,thu,tiet)).Rows)
            {
                lst.Add(new ThoiKhoaBieu(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThoiKhoaBieu obj)
        {
            return await ExecuteNonQuery(
                "InsertThoiKhoaBieu",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@Thu", SqlDbType.Int) { Value = obj.Thu },
                new SqlParameter("@Tiet", SqlDbType.Int) { Value = obj.Tiet },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc }
            );
        }

        public async Task<int> Xoa(int idlop,int thu)
        {
            return await ExecuteNonQuery("DeleteThoiKhoaBieu",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = idlop},
                new SqlParameter("@Thu", SqlDbType.Int) { Value = thu }
                );
        }

        public async Task<DataTable> LayDT_CoTenMon(int idlop, int thu)
        {
            return await ExecuteQuery(
                "W_SelectThoiKhoaBieuV2",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = idlop },
                new SqlParameter("@Thu", SqlDbType.Int) { Value = thu }
            );
        }
    }
}
