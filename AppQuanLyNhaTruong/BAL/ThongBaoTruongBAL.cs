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
    class ThongBaoTruongBAL : CInterface<ThongBaoTruong>
    {
        public Task<int> CapNhap(ThongBaoTruong obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<ThongBaoTruong>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(ThongBaoTruong obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
