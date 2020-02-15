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
    public class LopBAL : CInterface<Lop>
    {
        LopDAL lop = new LopDAL();
        public async Task<int> CapNhap(Lop obj)
        {
            return await lop.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await lop.Lay();
        }

        public async Task<List<Lop>> LayLst()
        {
            List<Lop> lst = new List<Lop>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Lop(dr));
            }

            return lst;
        }

        public async Task<int> Them(Lop obj)
        {
            return await lop.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await lop.Xoa(ID);
        }
    }
}
