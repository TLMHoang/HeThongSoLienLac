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
    public class PhanCongBAL : CInterface<PhanCong>
    {
        PhanCongDAL pc = new PhanCongDAL();
        public async Task<int> CapNhap(PhanCong obj)
        {
            return await pc.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await pc.Lay();
        }

        public Task<DataTable> LayID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PhanCong>> LayLst()
        {
            List<PhanCong> lst = new List<PhanCong>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new PhanCong(dr));
            }

            return lst;
        }

        public async Task<int> Them(PhanCong obj)
        {
            return await pc.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await pc.Xoa(ID);
        }
    }
}
