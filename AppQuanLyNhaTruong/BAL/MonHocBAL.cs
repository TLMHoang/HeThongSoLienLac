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
    public class MonHocBAL : CInterface<MonHoc>
    {
        MonHocDAL monHoc = new MonHocDAL();
        public async Task<int> CapNhap(MonHoc obj)
        {
            return await monHoc.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await monHoc.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await monHoc.Lay(ID);
        }
        public async Task<List<MonHoc>> LayLst()
        {
            List<MonHoc> lst = new List<MonHoc>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new MonHoc(dr));
            }

            return lst;
        }

        public async Task<int> Them(MonHoc obj)
        {
            return await monHoc.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await monHoc.Xoa(ID);
        }
    }
}
