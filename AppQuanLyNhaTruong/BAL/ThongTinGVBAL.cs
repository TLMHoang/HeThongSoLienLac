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
    public class ThongTinGVBAL : CInterface<ThongTinGV>
    {
        ThongTinGVDAL gv = new ThongTinGVDAL();
        public async Task<int> CapNhap(ThongTinGV obj)
        {
            return await gv.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await gv.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await gv.Lay(ID);
        }

        public async Task<List<ThongTinGV>> LayLst()
        {
            List<ThongTinGV> lst = new List<ThongTinGV>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongTinGV(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThongTinGV obj)
        {
            return await gv.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await gv.Xoa(ID);
        }
               
        public async Task<DataTable> KiemTraID(int id)
        {
            DataTable dt = await LayDT();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].Equals(id))
                {
                    return dt;
                }
            }
            return null;
        }
    }
}