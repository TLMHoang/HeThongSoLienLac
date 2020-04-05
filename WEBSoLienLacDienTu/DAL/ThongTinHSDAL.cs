using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThongTinHSDAL : SQL.SQLHelper, CInterface<ThongTinHS>
    {
        public async Task<int> CapNhap(ThongTinHS obj)
        {
            return await ExecuteNonQuery("UpdateThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten },
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = obj.NgaySinh },
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh },
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = obj.NoiSinh },
                new SqlParameter("@DanToc", SqlDbType.NVarChar) { Value = obj.DanToc },
                new SqlParameter("@TonGiao", SqlDbType.NVarChar) { Value = obj.TonGiao },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = obj.IDLoaiHocSinh },
                new SqlParameter("@HKI", SqlDbType.Int) { Value = obj.HKI },
                new SqlParameter("@HKII", SqlDbType.Int) { Value = obj.HKII },
                new SqlParameter("@CaNam", SqlDbType.Int) { Value = obj.CaNam }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
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
            return await ExecuteNonQuery("InsertThongTinHS",
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten },
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = obj.NgaySinh },
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh },
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = obj.NoiSinh },
                new SqlParameter("@DanToc", SqlDbType.NVarChar) { Value = obj.DanToc },
                new SqlParameter("@TonGiao", SqlDbType.NVarChar) { Value = obj.TonGiao },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = obj.IDLop },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = obj.IDLoaiHocSinh },
                new SqlParameter("@HKI", SqlDbType.Int) { Value = obj.HKI },
                new SqlParameter("@HKII", SqlDbType.Int) { Value = obj.HKII },
                new SqlParameter("@CaNam", SqlDbType.Int) { Value = obj.CaNam }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<DataTable> LayDT_ByIDLop(int ID)
        {
            return await ExecuteQuery(
                "SelectThongTinHSTheoLop",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
        public async Task<int> ThemTTHS(string ten,DateTime ngaySinh,byte gioiTinh,string noiSinh,string danToc,string TonGiao,int iDLop,int iDHocSinh)
        {
            return await ExecuteNonQuery("InsertQuanLyThongTinHS",
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = ten},
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = ngaySinh },
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = gioiTinh },
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = noiSinh },
                new SqlParameter("@DanToc", SqlDbType.NVarChar) { Value = danToc },
                new SqlParameter("@TonGiao", SqlDbType.NVarChar) { Value = TonGiao },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = iDLop },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = iDHocSinh }
            );
        }
        public async Task<int> CapNhapTTHS(int id,string ten, DateTime ngaySinh, byte gioiTinh, string noiSinh, string danToc, string TonGiao, int iDLop, int iDHocSinh)
        {
            return await ExecuteNonQuery("UpdateQuanLyThongTinHS",
                new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = ten },
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = ngaySinh },
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = gioiTinh },
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = noiSinh },
                new SqlParameter("@DanToc", SqlDbType.NVarChar) { Value = danToc },
                new SqlParameter("@TonGiao", SqlDbType.NVarChar) { Value = TonGiao },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = iDLop },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = iDHocSinh }
            );
        }
    }
}
