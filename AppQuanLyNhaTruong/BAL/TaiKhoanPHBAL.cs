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
    class TaiKhoanPHBAL : CInterface<TaiKhoanPH>
    {
        public Task<int> CapNhap(TaiKhoanPH obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<TaiKhoanPH>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(TaiKhoanPH obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
