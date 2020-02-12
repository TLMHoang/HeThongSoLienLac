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
    public class TaiKhoangTruongBAL : CInterface<TaiKhoanTruong>
    {
        TaiKhoanTruongDAL val = new TaiKhoanTruongDAL();
        public Task<int> CapNhap(TaiKhoanTruong obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<TaiKhoanTruong>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(TaiKhoanTruong obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DangNhap(string TaiKhoan, string MatKhau)
        {
            if ((await val.DangNhap(TaiKhoan,MatKhau)).Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
