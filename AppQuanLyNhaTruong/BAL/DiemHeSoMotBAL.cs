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
    public class DiemHeSoMotBAL : CInterface<DiemHeSoMot>
    {
        DiemHeSoMotDAL diem1 = new DiemHeSoMotDAL();
        public async Task<int> CapNhap(DiemHeSoMot obj)
        {
            return await diem1.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await diem1.Lay();
        }

        public async Task<List<DiemHeSoMot>> LayLst()
        {
            List<DiemHeSoMot> lst = new List<DiemHeSoMot>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new DiemHeSoMot(dr));
            }

            return lst;
        }

        public async Task<int> Them(DiemHeSoMot obj)
        {
            return await diem1.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await diem1.Xoa(ID);
        }
    }
}
