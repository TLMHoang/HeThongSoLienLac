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
    class DiemDanhBAL : CInterface<DiemDanh>
    {
        public Task<int> CapNhap(DiemDanh obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<DiemDanh>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(DiemDanh obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
