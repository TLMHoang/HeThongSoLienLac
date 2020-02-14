using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    class ThongTinGVDAL : SQL.SQLHelper, CInterface<ThongTinGV>
    {
        public Task<int> CapNhap(ThongTinGV obj)
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

        public Task<int> Them(ThongTinGV obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
