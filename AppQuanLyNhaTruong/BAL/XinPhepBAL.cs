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
    public class XinPhepBAL : CInterface<XinPhep>
    {
        XinPhepDAL xinPhep = new XinPhepDAL();
        public async Task<int> CapNhap(XinPhep obj)
        {
            return await xinPhep.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await xinPhep.Lay();
        }

        public Task<DataTable> LayID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<XinPhep>> LayLst()
        {
            List<XinPhep> lst = new List<XinPhep>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new XinPhep(dr));
            }

            return lst;
        }

        public async Task<int> Them(XinPhep obj)
        {
            return await xinPhep.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await xinPhep.Xoa(ID);
        }
    }
}
