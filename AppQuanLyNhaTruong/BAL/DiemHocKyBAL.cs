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
    class DiemHocKyBAL : CInterface<DiemHocKy>
    {
        public Task<int> CapNhap(DiemHocKy obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<DiemHocKy>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(DiemHocKy obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
