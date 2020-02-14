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
    class ThongBaoLopBAL : CInterface<ThongBaoLop>
    {
        public Task<int> CapNhap(ThongBaoLop obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<ThongBaoLop>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(ThongBaoLop obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
