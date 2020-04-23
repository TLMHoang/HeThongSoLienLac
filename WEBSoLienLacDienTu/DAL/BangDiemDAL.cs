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
    public class BangDiemDAL : SQL.SQLHelper, CInterface<BangDiem>
    {
        public async Task<int> CapNhap(BangDiem obj)
        {
            return await ExecuteNonQuery("UpdateBangDiem",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc },
                new SqlParameter("@IDLoaiDiem", SqlDbType.Int) { Value = obj.IDLoaiDiem },
                new SqlParameter("@NgayNhap", SqlDbType.DateTime) { Value = obj.NgayNhap },
                new SqlParameter("@Diem", SqlDbType.Float) { Value = obj.Diem },
                new SqlParameter("@HocKyI", SqlDbType.Bit) { Value = obj.HocKyI }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery("SelectBangDiem",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 });
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery("SelectBangDiem",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        }

        public async Task<List<BangDiem>> LayLst()
        {
            List<BangDiem> lst = new List<BangDiem>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new BangDiem(dr));
            }
            return lst;
        }

        public async Task<int> Them(BangDiem obj)
        {
            return await ExecuteNonQuery("InsertBangDiem",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDMonHoc", SqlDbType.Int) { Value = obj.IDMonHoc },
                new SqlParameter("@IDLoaiDiem", SqlDbType.Int) { Value = obj.IDLoaiDiem },
                new SqlParameter("@NgayNhap", SqlDbType.DateTime) { Value = obj.NgayNhap },
                new SqlParameter("@Diem", SqlDbType.Float) { Value = obj.Diem },
                new SqlParameter("@HocKyI", SqlDbType.Bit) { Value = obj.HocKyI }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteBangDiem",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
        public async Task<DataTable> LayDanhSachDiem_TheoLopMon(int idLop,int idMon)
        {
            return await ExecuteQuery("W_SelectBangDiem_ByIdLopIdMon",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = idLop },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = idMon }
                );
        }
    }
}
