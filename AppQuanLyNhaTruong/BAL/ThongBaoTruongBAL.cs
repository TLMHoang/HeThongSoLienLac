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
    public class ThongBaoTruongBAL : CInterface<ThongBaoTruong>
    {
        ThongBaoTruongDAL tbtruong = new ThongBaoTruongDAL();
        public async Task<int> CapNhap(ThongBaoTruong obj)
        {
            return await tbtruong.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await tbtruong.Lay();
        }

        public Task<DataTable> LayID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ThongBaoTruong>> LayLst()
        {
            List<ThongBaoTruong> lst = new List<ThongBaoTruong>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongBaoTruong(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThongBaoTruong obj)
        {
            return await tbtruong.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await tbtruong.Xoa(ID);
        }
    }
}
