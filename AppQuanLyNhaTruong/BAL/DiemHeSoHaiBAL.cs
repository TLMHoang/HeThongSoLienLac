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
    public class DiemHeSoHaiBAL : CInterface<DiemHeSoHai>
    {
        DiemHeSoHaiDAL diem2 = new DiemHeSoHaiDAL();
        public async Task<int> CapNhap(DiemHeSoHai obj)
        {
            return await diem2.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await diem2.Lay();
        }

        public async Task<List<DiemHeSoHai>> LayLst()
        {
            List<DiemHeSoHai> lst = new List<DiemHeSoHai>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new DiemHeSoHai(dr));
            }

            return lst;
        }

        public async Task<int> Them(DiemHeSoHai obj)
        {
            return await diem2.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await diem2.Xoa(ID);
        }
    }
}
