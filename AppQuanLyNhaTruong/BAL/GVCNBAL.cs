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
    class GVCNBAL : CInterface<GVCN>
    {
        GVCNDAL gv = new GVCNDAL();
        public async Task<int> CapNhap(GVCN obj)
        {
            return await gv.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await gv.Lay();
        }

        public Task<DataTable> LayID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<GVCN>> LayLst()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(GVCN obj)
        {
            return await gv.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await gv.Xoa(ID);
        }
    }
}
