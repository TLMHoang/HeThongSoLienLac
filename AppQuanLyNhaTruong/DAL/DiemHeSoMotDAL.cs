using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    class DiemHeSoMotDAL : SQL.SQLHelper, CInterface<DiemHeSoMot>
    {
        public Task<int> CapNhap(DiemHeSoMot obj)
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

        public Task<int> Them(DiemHeSoMot obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
