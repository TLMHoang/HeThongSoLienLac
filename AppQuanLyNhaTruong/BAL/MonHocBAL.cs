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
    class MonHocBAL : CInterface<MonHoc>
    {
        public Task<int> CapNhap(MonHoc obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<MonHoc>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(MonHoc obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
