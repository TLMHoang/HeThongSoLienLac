using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiemDanh_ScanQRDAL : SQL.SQLHelper, CInterface<DiemDanh_ScanQR>
    {
        public Task<int> CapNhap(DiemDanh_ScanQR obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<DiemDanh_ScanQR>> LayLst()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(DiemDanh_ScanQR obj)
        {
            return await ExecuteNonQuery(
                "InsertDiemDanh_ScanQR",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh }
            );
        }


        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<DataTable> LayDSHocSinhVang_QR()
        {
            return await ExecuteQuery(
                "selectHocSinhVang_ScanQR"
                );

        }

        public async Task<List<ThongTinHS>> LayLstHocSinhVang_QR()
        {
            List<ThongTinHS> lst = new List<ThongTinHS>();
            foreach (DataRow dr in (await LayDSHocSinhVang_QR()).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }

            return lst;
        }
    }
}
