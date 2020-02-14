using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    class ThoiKhoaBieuBAL : CInterface<ThoiKhoaBieu>
    {
        public Task<int> CapNhap(ThoiKhoaBieu obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<ThoiKhoaBieu>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(ThoiKhoaBieu obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
