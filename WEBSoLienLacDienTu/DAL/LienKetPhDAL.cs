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
    public class LienKetPhDAL : SQL.SQLHelper, CInterface<LienKetPHvsHS>
    {
        public async Task<int> CapNhap(LienKetPHvsHS obj)
        {
            return await ExecuteNonQuery("UpdateLienKetPHvsHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh},
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan }            
                );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectHsvsPH",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = -1 });
        }

        public async Task<DataTable> LayDT(int IDTaiKhoan)
        {
            return await ExecuteQuery("SelectHsvsPH",
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = IDTaiKhoan });
        }

        public async Task<List<LienKetPHvsHS>> LayLst()
        {
            List<LienKetPHvsHS> lst = new List<LienKetPHvsHS>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new LienKetPHvsHS(dr));
            }
            return lst;
        }

        public async  Task<int> Them(LienKetPHvsHS obj)
        {
            return await ExecuteNonQuery("InsertLienKetPHvsHS",
                new SqlParameter("@IDHocSinh", SqlDbType.NVarChar) { Value = obj.IDHocSinh },
                new SqlParameter("@IDTaiKhoan", SqlDbType.Int) { Value = obj.IDTaiKhoan }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteLienKetPHvsHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
    }
}
