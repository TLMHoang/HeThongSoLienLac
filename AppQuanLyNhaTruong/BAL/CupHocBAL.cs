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
    class CupHocBAL : CInterface<CupHoc>
    {
        public Task<int> CapNhap(CupHoc obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<CupHoc>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(CupHoc obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
