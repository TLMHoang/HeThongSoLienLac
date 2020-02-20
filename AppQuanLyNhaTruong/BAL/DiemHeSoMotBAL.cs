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
    public class DiemHeSoMotBAL
    {
        DiemHeSoMotDAL diem1 = new DiemHeSoMotDAL();
        public async Task<int> CapNhap(string TenLop, DiemHeSoMot obj)
        {
            return await diem1.CapNhap(TenLop ,obj);
        }

        public async Task<DataTable> LayDT(string TenLop)
        {
            return await diem1.Lay(TenLop);
        }

        public async Task<List<DiemHeSoMot>> LayLst(string TenLop)
        {
            List<DiemHeSoMot> lst = new List<DiemHeSoMot>();

            foreach (DataRow dr in (await LayDT(TenLop)).Rows)
            {
                lst.Add(new DiemHeSoMot(dr));
            }

            return lst;
        }

        public async Task<DataTable> LayID(string TenLop, int ID)
        {
            return await diem1.Lay(TenLop, ID);

        }

        public async Task<int> Them(string TenLop, DiemHeSoMot obj)
        {
            return await diem1.Them(TenLop ,obj);
        }

        public async Task<int> Xoa(string TenLop, int ID)
        {
            return await diem1.Xoa(TenLop, ID);
        }
    }
}
