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
    public class TaiKhoanTruongBAL : CInterface<TaiKhoanTruong>
    {
        TaiKhoanTruongDAL val = new TaiKhoanTruongDAL();
        public async Task<int> CapNhap(TaiKhoanTruong obj)
        {
            return await val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await val.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await val.Lay(ID);
        }

        public async Task<List<TaiKhoanTruong>> LayLst()
        {
            List<TaiKhoanTruong> lst = new List<TaiKhoanTruong>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TaiKhoanTruong(dr));
            }

            return lst;
        }

        public async Task<int> Them(TaiKhoanTruong obj)
        {
            return await val.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await val.Xoa(ID);
        }

        public async Task<DataTable> DangNhap(string TaiKhoan, string MatKhau)
        {
            TaiKhoanTruongDAL data = new TaiKhoanTruongDAL();
            DataTable dt = await data.DangNhap(TaiKhoan,MatKhau);                       
            if (dt.Rows.Count == 1)
            {
                return dt;
            }
            return null;
        }
    }
}
