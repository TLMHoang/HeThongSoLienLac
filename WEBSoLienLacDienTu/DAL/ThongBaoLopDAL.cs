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
    public class ThongBaoLopDAL : SQL.SQLHelper, CInterface<ThongBaoLop>
    {
        public async Task<int> CapNhap(ThongBaoLop obj)
        {
            return await ExecuteNonQuery(
                "UpdateThongBaoLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = obj.NoiDung },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay },
                new SqlParameter("@IDLoaiThongBao", SqlDbType.Int) { Value = obj.IDLoaiThongBao }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectThongBaoLop", new SqlParameter("@ID", SqlDbType.Int) { Value = -1 });
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectThongBaoLop", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }

        public async Task<List<ThongBaoLop>> LayLst()
        {
            List<ThongBaoLop> lst = new List<ThongBaoLop>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongBaoLop(dr));
            }

            return lst;
        }

        public async Task<List<ThongBaoLop>> LayLst(int id)
        {
            List<ThongBaoLop> lst = new List<ThongBaoLop>();
            foreach (DataRow dr in (await LayDT(id)).Rows)
            {
                lst.Add(new ThongBaoLop(dr));
            }

            return lst;
        }

        public async Task<int> Them(int idlop,string noidung,DateTime ngay,int idloaithongbao)
        {
            return await ExecuteNonQuery(
                "InsertThongBaoLop",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = idlop },
                new SqlParameter("@NoiDung", SqlDbType.NVarChar) { Value = noidung },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = ngay },
                new SqlParameter("@IDLoaiThongBao", SqlDbType.Int) { Value = idloaithongbao }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteThongBaoLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<DataTable> LayDT_TheoLop(int ID)
        {
            return await ExecuteQuery("SelectThongBaoLopV2", new SqlParameter("@IDLop", SqlDbType.Int) { Value = ID });
        }

        public Task<int> Them(ThongBaoLop obj)
        {
            throw new NotImplementedException();
        }
    }
}
