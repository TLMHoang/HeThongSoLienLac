using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    public class ThongTinHSBAL : CInterface<ThongTinHS>
    {
        ThongTinHSDAL hs = new ThongTinHSDAL();
        public async Task<int> CapNhap(ThongTinHS obj)
        {
            return await hs.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await hs.Lay();
        }

        public async Task<List<ThongTinHS>> LayLst()
        {
            List<ThongTinHS> lst = new List<ThongTinHS>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThongTinHS obj)
        {
            return await hs.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await hs.Xoa(ID);
        }
        //public async Task<int> ThemHs(int iD, string ten, DateTime ngaySinh, byte gioiTinh, string noiSinh, string danToc, string tonGiao, int iDLop, int iDTaiKhoan, string tenMe, string sDTMe, string tenBo, string sDTBo)
        //{
        //    ThongTinHS hs = new ThongTinHS();
        //    hs.ID = iD;
        //    hs.Ten = ten;
        //    hs.NgaySinh = ngaySinh;
        //    hs.GioiTinh = gioiTinh;
        //    hs.NoiSinh = noiSinh;
        //    hs.DanToc = danToc;
        //    hs.TonGiao = tonGiao;
        //    hs.IDLop = iDLop;
        //    hs.IDTaiKhoan = iDTaiKhoan;
        //    hs.TenBo = tenBo;
        //    hs.SDTBo = sDTBo;
        //    hs.TenMe = tenMe;
        //    hs.SDTMe = sDTMe;


        //    return await Them(hs);
        //}
        //public async Task<int> Sua(int iD, string ten, DateTime ngaySinh, byte gioiTinh, string noiSinh, string danToc, string tonGiao, int iDLop, int iDTaiKhoan, string tenMe, string sDTMe, string tenBo, string sDTBo)
        //{
        //    ThongTinHS hs = new ThongTinHS();
        //    hs.ID = iD;
        //    hs.Ten = ten;
        //    hs.NgaySinh = ngaySinh;
        //    hs.GioiTinh = gioiTinh;
        //    hs.NoiSinh = noiSinh;
        //    hs.DanToc = danToc;
        //    hs.TonGiao = tonGiao;
        //    hs.IDLop = iDLop;
        //    hs.IDTaiKhoan = iDTaiKhoan;
        //    hs.TenBo = tenBo;
        //    hs.SDTBo = sDTBo;
        //    hs.TenMe = tenMe;
        //    hs.SDTMe = sDTMe;


        //    return await CapNhap(hs);
        //}
        public async Task<DataTable> KiemTraID(int id)
        {
            DataTable dt = await LayDT();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].Equals(id))
                {
                    return dt;
                }
            }
            return null;
        }
    }
}
