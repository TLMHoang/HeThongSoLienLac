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
    public class DiemHocKyBAL
    {
        DiemHocKyDAL diemHocKy = new DiemHocKyDAL();
        public async Task<int> CapNhap(string TenLop, DiemHocKy obj)
        {
            return await diemHocKy.CapNhap(TenLop, obj);
        }

        public async Task<DataTable> LayDT(string TenLop)
        {
            return await diemHocKy.Lay(TenLop);
        }

        public async Task<List<DiemHocKy>> LayLst(string TenLop)
        {
            List<DiemHocKy> lst = new List<DiemHocKy>();

            foreach (DataRow dr in (await LayDT(TenLop)).Rows)
            {
                lst.Add(new DiemHocKy(dr));
            }

            return lst;
        }

        public async Task<DataTable> LayID(string TenLop, int ID)
        {
            return await diemHocKy.Lay(TenLop, ID);

        }

        public async Task<int> Them(string TenLop, DiemHocKy obj)
        {
            return await diemHocKy.Them(TenLop, obj);
        }

        public async Task<int> Xoa(string TenLop, int ID)
        {
            return await diemHocKy.Xoa(TenLop, ID);
        }
    }
}
