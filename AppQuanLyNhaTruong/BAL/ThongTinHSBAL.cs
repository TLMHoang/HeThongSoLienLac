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
    class ThongTinHSBAL : CInterface<ThongTinHS>
    {
        public Task<int> CapNhap(ThongTinHS obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<ThongTinHS>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(ThongTinHS obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
