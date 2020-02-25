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
    public class GVCNBAL : CInterface<GVCN>
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

        public async Task<DataTable> LayDT(GVCN obj)
        {
            return await gv.Lay(obj);
        }

        public Task<DataTable> LayID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GVCN>> LayLst()
        {
            List<GVCN> lst = new List<GVCN>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new GVCN(dr));
            }

            return lst;
        }

        public async Task<int> Them(GVCN obj)
        {
            return await gv.Them(obj);
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Xoa(GVCN obj)
        {
            return await gv.Xoa(obj);
        }
    }
}
