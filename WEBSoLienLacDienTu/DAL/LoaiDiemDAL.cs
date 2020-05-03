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
    public class LoaiDiemDAL: SQL.SQLHelper,CInterface<LoaiDiem>
    {
        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectLoaiDiem",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1}
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectLoaiDiem",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<LoaiDiem>> LayLst()
        {
            List<LoaiDiem> lst = new List<LoaiDiem>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new LoaiDiem(dr));
            }

            return lst;
        }

        public Task<int> CapNhap(LoaiDiem obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(LoaiDiem obj)
        {
            throw new NotImplementedException();
        }
    }
}
