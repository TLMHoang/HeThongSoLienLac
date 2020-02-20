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
    public class CupHocBAL : CInterface<CupHoc>
    {
        CupHocDAL Cup = new CupHocDAL();
        public async Task<int> CapNhap(CupHoc obj)
        {
            return await Cup.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Cup.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await Cup.Lay(ID);
        }

        public async Task<List<CupHoc>> LayLst()
        {
            List<CupHoc> lst = new List<CupHoc>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new CupHoc(dr));
            }

            return lst;
        }

        public async Task<int> Them(CupHoc obj)
        {
            return await Cup.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await Cup.Xoa(ID);
        }
    }
}
