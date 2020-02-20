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
    public class TaiKhoanPHBAL : CInterface<TaiKhoanPH>
    {
        TaiKhoanPHDAL taiKhoanph = new TaiKhoanPHDAL();
        public async Task<int> CapNhap(TaiKhoanPH obj)
        {
            return await taiKhoanph.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await taiKhoanph.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await taiKhoanph.Lay(ID);
        }

        public async Task<List<TaiKhoanPH>> LayLst()
        {
            List<TaiKhoanPH> lst = new List<TaiKhoanPH>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TaiKhoanPH(dr));
            }

            return lst;
        }

        public async Task<int> Them(TaiKhoanPH obj)
        {
            return await taiKhoanph.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await taiKhoanph.Xoa(ID);
        }
    }
}
