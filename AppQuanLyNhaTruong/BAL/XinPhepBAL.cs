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
    class XinPhepBAL : CInterface<XinPhep>
    {
        public Task<int> CapNhap(XinPhep obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<XinPhep>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(XinPhep obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
