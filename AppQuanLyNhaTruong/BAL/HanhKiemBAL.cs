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
    public class HanhKiemBAL : CInterface<HanhKiem>
    {
        HanhKiemDAL hanhKiem = new HanhKiemDAL();
        public async Task<int> CapNhap(HanhKiem obj)
        {
            return await hanhKiem.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await hanhKiem.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await hanhKiem.Lay(ID);
        }

        public async Task<List<HanhKiem>> LayLst()
        {
            List<HanhKiem> lst = new List<HanhKiem>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new HanhKiem(dr));
            }

            return lst;
        }

        public async Task<int> Them(HanhKiem obj)
        {
            return await hanhKiem.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await hanhKiem.Xoa(ID);
        }
    }
}
