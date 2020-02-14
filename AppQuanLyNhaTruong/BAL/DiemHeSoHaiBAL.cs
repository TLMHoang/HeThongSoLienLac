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
    class DiemHeSoHaiBAL : CInterface<DiemHeSoHai>
    {
        public Task<int> CapNhap(DiemHeSoHai obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<DiemHeSoHai>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(DiemHeSoHai obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
