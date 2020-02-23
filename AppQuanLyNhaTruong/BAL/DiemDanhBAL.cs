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
    public class DiemDanhBAL : CInterface<DiemDanh>
    {
        DiemDanhDAL diemdanh = new DiemDanhDAL();
        public async Task<int> CapNhap(DiemDanh obj)
        {
            return await diemdanh.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await diemdanh.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await diemdanh.Lay(ID);

        }

        public async Task<List<DiemDanh>> LayLst()
        {
            List<DiemDanh> lst = new List<DiemDanh>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new DiemDanh(dr));
            }

            return lst;
        }

        public async Task<int> Them(DiemDanh obj)
        {
            return await diemdanh.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await diemdanh.Xoa(ID);
        }

        public async Task<int> LaySTT(int IDHS, DateTime NgayNghi)
        {
            DiemDanh dd = new DiemDanh((await diemdanh.LaySTT(IDHS, NgayNghi)).Rows[0]);
            return dd.STT;
        }
    }
}
