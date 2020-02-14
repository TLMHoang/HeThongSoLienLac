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
    class ThongTinGVBAL : CInterface<ThongTinGV>
    {
        public Task<int> CapNhap(ThongTinGV obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<ThongTinGV>> LayLst()
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
