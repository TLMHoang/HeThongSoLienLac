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
    public class XinPhepDAL : SQL.SQLHelper, CInterface<XinPhep>
    {
        public async Task<int> CapNhap(XinPhep obj)
        {
            return await ExecuteNonQuery("UpdateXinPhep",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@NghiTu", SqlDbType.DateTime) { Value = obj.NghiTu },
                new SqlParameter("@NghiDen", SqlDbType.DateTime) { Value = obj.NghiDen },
                new SqlParameter("@TrangThai", SqlDbType.Int) { Value = obj.TrangThai }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectXinPhep",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }
        public async Task<DataTable> LayDT_CoTenHS(int IDLop,int TrangThai)
        {
            return await ExecuteQuery(
                "W_SelectXinPhep_V2",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = IDLop },
                new SqlParameter("@TrangThai", SqlDbType.Int) { Value = TrangThai }
            );
        }
        public async Task<DataTable> LayDT_CoTenHS(int ID,int IDLop, int TrangThai)
        {
            return await ExecuteQuery(
                "W_SelectXinPhep_V2",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = IDLop },
                new SqlParameter("@TrangThai", SqlDbType.Int) { Value = TrangThai }
            );
        }
        public async Task<DataTable> LayDT_DaDuyet(int IDLop)
        {
            return await ExecuteQuery(
                "W_SelectXinPhep_DSDaDuyet",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 },
                new SqlParameter("@IDLop", SqlDbType.Int) { Value = IDLop }
            );
        }
        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectXinPhep",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<XinPhep>> LayLst()
        {
            List<XinPhep> lst = new List<XinPhep>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new XinPhep(dr));
            }
            return lst;
        }

        public async Task<int> Them(XinPhep obj)
        {
            return await ExecuteNonQuery("InsertXinPhep",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
               new SqlParameter("@NghiTu", SqlDbType.DateTime) { Value = obj.NghiTu },
               new SqlParameter("@NghiDen", SqlDbType.DateTime) { Value = obj.NghiDen },
               new SqlParameter("@TrangThai", SqlDbType.Int) { Value = obj.TrangThai },
               new SqlParameter("@LyDo", SqlDbType.NVarChar) { Value = obj.LyDo }
            );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteXinPhep",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<int> DuyetDon(int ID,int TrangThai)
        {
            return await ExecuteNonQuery("W_SelectXinPhep_DuyetDon",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                new SqlParameter("@TrangThai", SqlDbType.Int) { Value = TrangThai }
            );
        }
        public async Task<int> XinPhepV2(int idHocSinh, DateTime nghiTu, DateTime nghiDen, string lyDo)
        {
            return await ExecuteNonQuery("InsertXinPhepV2",
               //new SqlParameter("@ID", SqlDbType.Int) { Value = iD },
               new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = idHocSinh },
               new SqlParameter("@NghiTu", SqlDbType.DateTime) { Value = nghiTu },
               new SqlParameter("@NghiDen", SqlDbType.DateTime) { Value = nghiDen },
               //new SqlParameter("@TrangThai", SqlDbType.Bit) { Value = trangThai },
               //new SqlParameter("@ChoHuy", SqlDbType.Bit) { Value = choHuy },
               new SqlParameter("@LyDo", SqlDbType.NVarChar) { Value = lyDo }
           );
        }
        public async Task<int> CapNhatV2(int iD, int idHocSinh, DateTime nghiTu, DateTime nghiDen, byte trangThai, byte choHuy, string lyDo)
        {
            return await ExecuteNonQuery("UpdateXinPhepV2",
               new SqlParameter("@ID", SqlDbType.Int) { Value = iD },
               new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = idHocSinh },
               new SqlParameter("@NghiTu", SqlDbType.DateTime) { Value = nghiTu },
               new SqlParameter("@NghiDen", SqlDbType.DateTime) { Value = nghiDen },
               new SqlParameter("@TrangThai", SqlDbType.Bit) { Value = trangThai },
               new SqlParameter("@ChoHuy", SqlDbType.Bit) { Value = choHuy },
               new SqlParameter("@LyDo", SqlDbType.NVarChar) { Value = lyDo }
           );
        }
        public async Task<DataTable> LayDT_ID(int ID)
        {
            return await ExecuteQuery(
                "SelectXinPhepID",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
    }
}
