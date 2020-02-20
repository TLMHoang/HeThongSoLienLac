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
    public class ThongBaoLopBAL : CInterface<ThongBaoLop>
    {
        ThongBaoLopDAL tbLop = new ThongBaoLopDAL();
        public async Task<int> CapNhap(ThongBaoLop obj)
        {
            return await tbLop.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await tbLop.Lay();
        }

        public Task<DataTable> LayID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ThongBaoLop>> LayLst()
        {
            List<ThongBaoLop> lst = new List<ThongBaoLop>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongBaoLop(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThongBaoLop obj)
        {
            return await tbLop.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await tbLop.Xoa(ID);
        }
    }
}
