using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    class LopDAL : SQL.SQLHelper, CInterface<Lop>
    {
        public Task<int> CapNhap(Lop obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Lay()
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(Lop obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
