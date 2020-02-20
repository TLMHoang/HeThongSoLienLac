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
    public class DiemHeSoHaiBAL
    {
        DiemHeSoHaiDAL diem2 = new DiemHeSoHaiDAL();
        public async Task<int> CapNhap(string TenLop, DiemHeSoHai obj)
        {
            return await diem2.CapNhap(TenLop, obj);
        }

        public async Task<DataTable> LayDT(string TenLop)
        {
            return await diem2.Lay(TenLop);
        }

        public async Task<List<DiemHeSoHai>> LayLst(string TenLop)
        {
            List<DiemHeSoHai> lst = new List<DiemHeSoHai>();

            foreach (DataRow dr in (await LayDT(TenLop)).Rows)
            {
                lst.Add(new DiemHeSoHai(dr));
            }

            return lst;
        }

        public async Task<DataTable> LayID(string TenLop, int ID)
        {
            return await diem2.Lay(TenLop, ID);

        }

        public async Task<int> Them(string TenLop, DiemHeSoHai obj)
        {
            return await diem2.Them(TenLop, obj);
        }

        public async Task<int> Xoa(string TenLop, int ID)
        {
            return await diem2.Xoa(TenLop, ID);
        }
    }
}
