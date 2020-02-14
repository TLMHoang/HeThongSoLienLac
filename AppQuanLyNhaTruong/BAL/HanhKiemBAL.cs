using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BAL
{
    class HanhKiemBAL : CInterface<HanhKiem>
    {
        public Task<int> CapNhap(HanhKiem obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<HanhKiem>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(HanhKiem obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
