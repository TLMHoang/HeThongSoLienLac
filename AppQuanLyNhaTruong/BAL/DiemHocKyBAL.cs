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
    public class DiemHocKyBAL : CInterface<DiemHocKy>
    {
        DiemHocKyDAL diemHocKy = new DiemHocKyDAL();
        public async Task<int> CapNhap(DiemHocKy obj)
        {
            return await diemHocKy.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await diemHocKy.Lay();
        }

        public async Task<List<DiemHocKy>> LayLst()
        {
            List<DiemHocKy> lst = new List<DiemHocKy>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new DiemHocKy(dr));
            }

            return lst;
        }

        public async Task<int> Them(DiemHocKy obj)
        {
            return await diemHocKy.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await diemHocKy.Xoa(ID);
        }
    }
}
