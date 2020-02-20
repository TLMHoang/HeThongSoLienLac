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
    public class ThoiKhoaBieuBAL : CInterface<ThoiKhoaBieu>
    {
        ThoiKhoaBieuDAL tkb = new ThoiKhoaBieuDAL();
        public async Task<int> CapNhap(ThoiKhoaBieu obj)
        {
            return await tkb.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await tkb.Lay();
        }

        public async Task<DataTable> LayID(int ID) // Lay tkb của lớp
        {
            return await tkb.Lay(ID);
        }


        public async Task<List<ThoiKhoaBieu>> LayLst()
        {
            List<ThoiKhoaBieu> lst = new List<ThoiKhoaBieu>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThoiKhoaBieu(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThoiKhoaBieu obj)
        {
            return await tkb.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await tkb.Xoa(ID);
        }
    }
}
