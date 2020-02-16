﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DiemHeSoMotDAL : SQL.SQLHelper
    {
        public async Task<int> CapNhap(string TenLop, DiemHeSoMot obj)
        {
            return await ExecuteNonQuery(
                "UpdateDHSM" + TenLop,
                new SqlParameter("@STT", SqlDbType.Int) { Value = obj.STT },
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = obj.IDMon },
                new SqlParameter("@Diem", SqlDbType.Float) { Value = obj.Diem },
                new SqlParameter("@CotThu", SqlDbType.Int) { Value = obj.CotThu },
                new SqlParameter("@DiemMieng", SqlDbType.Bit) { Value = obj.DiemMieng },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai },
                new SqlParameter("@HocKy", SqlDbType.Bit) { Value = obj.HocKy }
                );
        }

        public async Task<DataTable> Lay(string TenLop)
        {
            return await ExecuteQuery("SelectDHSM" + TenLop);
        }

        public Task<DataTable> Lay(string TenLop, int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Them(string TenLop, DiemHeSoMot obj)
        {
            return await ExecuteNonQuery(
                "CreateDHSM" + TenLop,
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = obj.IDHocSinh },
                new SqlParameter("@IDMon", SqlDbType.Int) { Value = obj.IDMon },
                new SqlParameter("@Diem", SqlDbType.Float) { Value = obj.Diem },
                new SqlParameter("@CotThu", SqlDbType.Int) { Value = obj.CotThu },
                new SqlParameter("@DiemMieng", SqlDbType.Bit) { Value = obj.DiemMieng },
                new SqlParameter("@Loai", SqlDbType.Bit) { Value = obj.Loai },
                new SqlParameter("@HocKy", SqlDbType.Bit) { Value = obj.HocKy }
                );
        }

        public async Task<int> Xoa(string TenLop, int STT)
        {
            return await ExecuteNonQuery(
                "DeleteDHSM" + TenLop,
                new SqlParameter("@STT", SqlDbType.Int) { Value = STT }
                );
        }
    }
}
