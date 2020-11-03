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
    public class ThongTinHocPhiDAL : SQL.SQLHelper, CInterface<TienHocPhi>
    {
        public async Task<int> CapNhap(TienHocPhi obj)
        {
            return await ExecuteNonQuery("UpdateTienHocPhi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@Thang", SqlDbType.Int) { Value = obj.Thang },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = obj.IDLoaiHocSinh },
                new SqlParameter("@IDKhoi", SqlDbType.Bit) { Value = obj.IDKhoi },
                new SqlParameter("@SoNgayHoc", SqlDbType.Int) { Value = obj.SoNgayHoc },
                new SqlParameter("@TienHoc", SqlDbType.Int) { Value = obj.TienHoc },
                new SqlParameter("@TienAn", SqlDbType.Int) { Value = obj.TienAn },
                new SqlParameter("@TienDien", SqlDbType.Int) { Value = obj.TienDien },
                new SqlParameter("@TienNuoc", SqlDbType.Int) { Value = obj.TienNuoc },
                new SqlParameter("@TienVeSinh", SqlDbType.Int) { Value = obj.TienVeSinh },
                new SqlParameter("@TienTrangThietBi", SqlDbType.Int) { Value = obj.TienTrangThietBi },
                new SqlParameter("@TienTaiLieu", SqlDbType.Int) { Value = obj.TienTaiLieu }
            );
        }

        public async Task<DataTable> LayDT()
        {
            return await ExecuteQuery(
                "SelectTienHocPhi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 }
            );
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await ExecuteQuery(
                "SelectTienHocPhi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
        public async Task<DataTable> LayDT_ByIDKhoi(int ID)
        {
            return await ExecuteQuery(
                "SelectHocPhiTheoKhoi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }

        public async Task<List<TienHocPhi>> LayLst()
        {
            List<TienHocPhi> lst = new List<TienHocPhi>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TienHocPhi(dr));
            }
            return lst;
        }

        public async Task<int> Them(TienHocPhi obj)
        {
            return await ExecuteNonQuery("InsertTienHocPhi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@Thang", SqlDbType.Int) { Value = obj.Thang },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = obj.IDLoaiHocSinh },
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = obj.IDKhoi },
                new SqlParameter("@SoNgayHoc", SqlDbType.Int) { Value = obj.SoNgayHoc },
                new SqlParameter("@TienHoc", SqlDbType.Int) { Value = obj.TienHoc },
                new SqlParameter("@TienAn", SqlDbType.Int) { Value = obj.TienAn },
                new SqlParameter("@TienDien", SqlDbType.Int) { Value = obj.TienDien },
                new SqlParameter("@TienNuoc", SqlDbType.Int) { Value = obj.TienNuoc },
                new SqlParameter("@TienVeSinh", SqlDbType.Int) { Value = obj.TienVeSinh },
                new SqlParameter("@TienTrangThietBi", SqlDbType.Int) { Value = obj.TienTrangThietBi },
                new SqlParameter("@TienTaiLieu", SqlDbType.Int) { Value = obj.TienTaiLieu }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "DeleteTienHocPhi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
            );
        }
        public async Task<int> ThemHp(int Thang, int IdLoaiHs,int idKhoi,int songayhoc,int tienhoc,int tienAn,int tienDien,int tienNuoc,int tienVeSinh,int tienTrangThietBi, int tienTailieu)
        {
            return await ExecuteNonQuery("InsertTienHocPhi",
               
                new SqlParameter("@Thang", SqlDbType.Int) { Value = Thang },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value =  IdLoaiHs},
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = idKhoi },
                new SqlParameter("@SoNgayHoc", SqlDbType.Int) { Value =songayhoc},
                new SqlParameter("@TienHoc", SqlDbType.Int) { Value = tienhoc },
                new SqlParameter("@TienAn", SqlDbType.Int) { Value = tienAn },
                new SqlParameter("@TienDien", SqlDbType.Int) { Value = tienDien},
                new SqlParameter("@TienNuoc", SqlDbType.Int) { Value = tienNuoc },
                new SqlParameter("@TienVeSinh", SqlDbType.Int) { Value = tienVeSinh },
                new SqlParameter("@TienTrangThietBi", SqlDbType.Int) { Value =  tienTrangThietBi},
                new SqlParameter("@TienTaiLieu", SqlDbType.Int) { Value =  tienTailieu}
                );
        }
        public async Task<int> CapNhatHp(int id,int Thang, int IdLoaiHs,int idKhoi, int songayhoc, int tienhoc, int tienAn, int tienDien, int tienNuoc, int tienVeSinh, int tienTrangThietBi, int tienTailieu)
        {
            return await ExecuteNonQuery("UpdateTienHocPhi",
                new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Thang", SqlDbType.Int) { Value = Thang },
                new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = IdLoaiHs },
                new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = idKhoi },
                new SqlParameter("@SoNgayHoc", SqlDbType.Int) { Value = songayhoc },
                new SqlParameter("@TienHoc", SqlDbType.Int) { Value = tienhoc },
                new SqlParameter("@TienAn", SqlDbType.Int) { Value = tienAn },
                new SqlParameter("@TienDien", SqlDbType.Int) { Value = tienDien },
                new SqlParameter("@TienNuoc", SqlDbType.Int) { Value = tienNuoc },
                new SqlParameter("@TienVeSinh", SqlDbType.Int) { Value = tienVeSinh },
                new SqlParameter("@TienTrangThietBi", SqlDbType.Int) { Value = tienTrangThietBi },
                new SqlParameter("@TienTaiLieu", SqlDbType.Int) { Value = tienTailieu }
                );
        }
        public async Task<DataTable> LayDT_ByID_Thang(int ID , int Thang)
        {
            return await ExecuteQuery(
                "SelectHocPhiTheoIDHS_Thang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                new SqlParameter("@Thang", SqlDbType.Int) { Value = Thang }
            );
        }
        public async Task<DataTable> LoadHocPhiNo(int IDHS)
        {
            return await ExecuteQuery(
                "W_SelectHocPhiNo",
                new SqlParameter("@IDHS", SqlDbType.Int) { Value = IDHS }
            );
        }
        public async Task<DataTable> LoadTongHocPhi(int Thang,int IDKhoi,int idloaiHocSinh)
        {
            return await ExecuteQuery(
                "W_SelectTongHocPhi",
                new SqlParameter("@Thang", SqlDbType.Int) { Value = Thang} ,
                    new SqlParameter("@IDKhoi", SqlDbType.Int) { Value = IDKhoi },
                    new SqlParameter("@IDLoaiHocSinh", SqlDbType.Int) { Value = idloaiHocSinh }
            );
        }
        public async Task<DataTable> LoadThongTinHocPhi_IDHS(int idHocSinh)
        {
            return await ExecuteQuery(
                "W_SelectHocPhi_ThongTinHS",
                new SqlParameter("@IDHocSinh", SqlDbType.Int) { Value = idHocSinh }
              
            );
        }
    }
}
