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
    public class ThongBaoHSBAL : CInterface<ThongBaoHS>
    {
        ThongBaoHSDAL thongBaohs = new ThongBaoHSDAL();
        public async Task<int> CapNhap(ThongBaoHS obj)
        {
            return await thongBaohs.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await thongBaohs.Lay();
        }

        public Task<DataTable> LayID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ThongBaoHS>> LayLst()
        {
            List<ThongBaoHS> lst = new List<ThongBaoHS>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongBaoHS(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThongBaoHS obj)
        {
            return await thongBaohs.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await thongBaohs.Xoa(ID);
        }
    }
}
