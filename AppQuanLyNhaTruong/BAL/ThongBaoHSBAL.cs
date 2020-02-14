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
    class ThongBaoHSBAL : CInterface<ThongBaoHS>
    {
        public Task<int> CapNhap(ThongBaoHS obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<ThongBaoHS>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(ThongBaoHS obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
