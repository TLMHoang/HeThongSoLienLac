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
                new SqlParameter("@CotDiem", SqlDbType.Int) { Value = obj.CotDiem },
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
                new SqlParameter("@Diem", SqlDbType.Float) { Value = obj.Diem },
                new SqlParameter("@HocKyI", SqlDbType.Bit) { Value = obj.HocKyI },
                new SqlParameter("@CotDiem", SqlDbType.Int) { Value = obj.CotDiem }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteBangDiem",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
        public async Task<DataTable> LayDanhSachDiem(int idLop,int idMon,int idLoaiDiem,int lan,int hocKyI)
        {
            return await ExecuteQuery("W_SelectBangDiem_V2",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = idLop },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = idMon },
                new SqlParameter("@IDloaiDiem", SqlDbType.Int) { Value = idLoaiDiem },
                new SqlParameter("@Lan", SqlDbType.Int) { Value = lan },
                new SqlParameter("@HocKyI", SqlDbType.Bit) { Value = hocKyI }
                );
        }
        public async Task<DataTable> LayDanhSachDiem_Full(int idLop,int idMon,byte hocKy)
        {
            return await ExecuteQuery("W_SelectBangDiem_Full",
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = idLop },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = idMon },
                new SqlParameter("@HocKy", SqlDbType.Bit) { Value = hocKy }

            );
        }
        public async Task<DataTable> LayDanhSachDiem_ID(int id)
        {
            return await ExecuteQuery("SelectBangDiemByHocSinh",
                new SqlParameter("@ID", SqlDbType.Int) { Value = id}
                
                );
        }
    }
}
