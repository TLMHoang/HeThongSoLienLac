using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class QuanLyHSBAL
    {
        QuanLyHSDAL gv = new QuanLyHSDAL();
        public async Task<int> CapNhap(QuanLyHS obj)
        {
            return await gv.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await gv.Lay();
        }

        public async Task<DataTable> LayDT(QuanLyHS obj)
        {
            return await gv.Lay(obj);
        }

        public async Task<List<QuanLyHS>> LayLst()
        {
            List<QuanLyHS> lst = new List<QuanLyHS>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new QuanLyHS(dr));
            }

            return lst;
        }

        public async Task<int> Them(QuanLyHS obj)
        {
            return await gv.Them(obj);
        }

        public async Task<int> Xoa(QuanLyHS obj)
        {
            return await gv.Xoa(obj);
        }
    }
}
