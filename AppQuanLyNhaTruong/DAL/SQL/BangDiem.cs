using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace DAL.SQL
{
    public class BangDiem
    {
        public string connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;  // string connect database
        #region Bảng điểm hệ số một

        public async Task BangDiemHeSoMot(string TenLop)
        {
            await DiemHeSoMot(TenLop);
            await CreateBDHSM(TenLop);
            await DeleteBDHSM(TenLop);
            await SelectBDHSM(TenLop);
            await UpdateBDHSM(TenLop);
        }

        public async Task DiemHeSoMot(string TenLop) // Create table database
        {
            string Query = "CREATE TABLE DHSM" +
                TenLop +
                 " ( STT INT IDENTITY(1,1) PRIMARY KEY," +
                " IDHocSinh INT," +
                " IDMon INT," +
                " Diem FLOAT," +
                " CotThu INT," +
                " DiemMieng BIT," +
                " Loai BIT," +
                " HocKy BIT )";
                


            await ConnectDB(Query);
        }



        #region Proc

        public async Task CreateBDHSM(string TenLop)
        {
            string TenBang = "DHSM" + TenLop;
            string Query = "CREATE PROCEDURE Insert" +
                TenBang +
                " @IDHocSinh INT," +
                " @IDMonHoc INT," +
                " @Diem FLOAT," +
                " @CotThu INT," +
                " @DiemMieng BIT," +
                " @Loai BIT," +
                " @HocKy BIT" +
                " AS" +
                " BEGIN" +
                " INSERT nxtckedu_USTeam." + TenBang + " VALUES ( @IDHocSinh, @IDMonHoc, @Diem, @CotThu, @DiemMieng, @Loai, @HocKy )" +
                " END";


            await ConnectDB(Query);
        }

        public async Task DeleteBDHSM(string TenLop)
        {
            string TenBang = "DHSM" + TenLop;
            string Query = "CREATE PROCEDURE Delete" +
                TenBang +
                " @STT INT" +
                " AS" +
                " BEGIN" +
                " DELETE nxtckedu_USTeam." + TenBang + " WHERE STT = @STT" +
                " END";


            await ConnectDB(Query);
        }

        public async Task SelectBDHSM(string TenLop)
        {
            string TenBang = "DHSM" + TenLop;
            string Query = "CREATE PROCEDURE Select" +
                TenBang +
                " @IDHocSinh INT" +
                " AS" +
                " BEGIN" +
                " IF @IDHocSinh = -1" +
                " BEGIN" +
                " SELECT * FROM nxtckedu_USTeam." + TenBang +
                " END" +
                " ELSE" +
                " BEGIN" +
                " SELECT * FROM nxtckedu_USTeam." + TenBang + " WHERE IDHocSinh = @IDHocSinh" +
                " END" +
                " END";


            await ConnectDB(Query);
        }

        public async Task UpdateBDHSM(string TenLop)
        {
            string TenBang = "DHSM" + TenLop;
            string Query = "CREATE PROCEDURE Update" +
                TenBang +
                " @STT INT," +
                " @IDHocSinh INT," +
                " @IDMonHoc INT," +
                " @Diem FLOAT," +
                " @CotThu INT," +
                " @DiemMieng BIT," +
                " @Loai BIT," +
                " @HocKy BIT" +
                " AS" +
                " BEGIN" +
                " UPDATE nxtckedu_USTeam." + TenBang + " SET" +
                " IDHocSinh = @IDHocSinh," +
                " IDMon = @IDMonHoc," +
                " Diem = @Diem," +
                " CotThu = @CotThu," +
                " DiemMieng = @DiemMieng," +
                " Loai = @Loai," +
                " HocKy = @HocKy" +
                " WHERE STT = @STT" +
                " END";

            await ConnectDB(Query);
        }

        #endregion

        #endregion

        #region Bảng điểm hệ số hai

        public async Task BangDiemHeSoHai(string TenLop)
        {
            await DiemHeSoHai(TenLop);
            await CreateBDHSH(TenLop);
            await DeleteBDHSH(TenLop);
            await SelectBDHSH(TenLop);
            await UpdateBDHSH(TenLop);
        }

        public async Task DiemHeSoHai(string TenLop)
        {
            string Query = "CREATE TABLE DHSH" +
                TenLop +
                 " ( STT INT IDENTITY(1,1) PRIMARY KEY," +
                " IDHocSinh INT," +
                " IDMon INT," +
                " Diem FLOAT," +
                " CotThu INT," +
                " Loai BIT," +
                " HocKy BIT )";
                

            await ConnectDB(Query);
        }

        #region Proc

        public async Task CreateBDHSH(string TenLop)
        {
            string TenBang = "DHSH" + TenLop;
            string Query = "CREATE PROCEDURE Insert" +
                TenBang +
                " @IDHocSinh INT," +
                " @IDMonHoc INT," +
                " @Diem FLOAT," +
                " @CotThu INT," +
                " @Loai BIT," +
                " @HocKy BIT" +
                " AS" +
                " BEGIN" +
                " INSERT nxtckedu_USTeam." + TenBang + " VALUES ( @IDHocSinh, @IDMonHoc, @Diem, @CotThu, @Loai, @HocKy )" +
                " END";


            await ConnectDB(Query);
        }

        public async Task DeleteBDHSH(string TenLop)
        {
            string TenBang = "DHSH" + TenLop;
            string Query = "CREATE PROCEDURE Delete" +
                TenBang +
                " @STT INT" +
                " AS" +
                " BEGIN" +
                " DELETE nxtckedu_USTeam." + TenBang + " WHERE STT = @STT" +
                " END";


            await ConnectDB(Query);
        }

        public async Task SelectBDHSH(string TenLop)
        {
            string TenBang = "DHSH" + TenLop;
            string Query = "CREATE PROCEDURE Select" +
                TenBang +
                " @IDHocSinh INT" +
                " AS" +
                " BEGIN" +
                " IF @IDHocSinh = -1" +
                " BEGIN" +
                " SELECT * FROM nxtckedu_USTeam." + TenBang +
                " END" +
                " ELSE" +
                " BEGIN" +
                " SELECT * FROM nxtckedu_USTeam." + TenBang + " WHERE IDHocSinh = @IDHocSinh" +
                " END" +
                " END";


            await ConnectDB(Query);
        }

        public async Task UpdateBDHSH(string TenLop)
        {
            string TenBang = "DHSH" + TenLop;
            string Query = "CREATE PROCEDURE Update" +
                TenBang +
                " @STT INT," +
                " @IDHocSinh INT," +
                " @IDMonHoc INT," +
                " @Diem FLOAT," +
                " @CotThu INT," +
                " @Loai BIT," +
                " @HocKy BIT" +
                " AS" +
                " BEGIN" +
                " UPDATE nxtckedu_USTeam." + TenBang + " SET" +
                " IDHocSinh = @IDHocSinh," +
                " IDMon = @IDMonHoc," +
                " Diem = @Diem," +
                " CotThu = @CotThu," +
                " Loai = @Loai," +
                " HocKy = @HocKy" +
                " WHERE STT = @STT" +
                " END";

            await ConnectDB(Query);
        }

        #endregion

        #endregion

        #region Bảng điểm học kỳ

        public async Task BangDiemHocKy(string TenLop)
        {
            await DiemHocKy(TenLop);
            await CreateBDHK(TenLop);
            await DeleteBDHK(TenLop);
            await SelectBDHK(TenLop);
            await UpdateBDHK(TenLop);

           
        }

        public async Task DiemHocKy(string TenLop)// Create table database
        {
            string Query = "CREATE TABLE DHK" +
                TenLop +
                 " ( STT INT IDENTITY(1,1) PRIMARY KEY," +
                " IDHocSinh INT," +
                " IDMon INT," +
                " Diem FLOAT," +
                " Loai BIT," +
                " HocKy BIT )";

            await ConnectDB(Query);
        }

        #region Proc

        public async Task CreateBDHK(string TenLop) 
        {
            string TenBang = "DHK" + TenLop;
            string Query = "CREATE PROCEDURE Insert" +
                TenBang +
                " @IDHocSinh INT," +
                " @IDMonHoc INT," +
                " @Diem FLOAT," +
                " @Loai BIT," +
                " @HocKy BIT" +
                " AS" +
                " BEGIN" +
                " INSERT nxtckedu_USTeam." + TenBang + " VALUES ( @IDHocSinh, @IDMonHoc, @Diem, @Loai, @HocKy )" +
                " END";


            await ConnectDB(Query);
        }

        public async Task DeleteBDHK(string TenLop) 
        {
            string TenBang = "DHK" + TenLop;
            string Query = "CREATE PROCEDURE Delete" +
                TenBang +
                " @STT INT" +
                " AS" +
                " BEGIN" +
                " DELETE nxtckedu_USTeam." + TenBang + " WHERE STT = @STT" +
                " END";


            await ConnectDB(Query);
        }

        public async Task SelectBDHK(string TenLop) 
        {
            string TenBang = "DHK" + TenLop;
            string Query = "CREATE PROCEDURE Select" +
                TenBang +
                " @IDHocSinh INT" +
                " AS" +
                " BEGIN" +
                " IF @IDHocSinh = -1" +
                " BEGIN" +
                " SELECT * FROM nxtckedu_USTeam." + TenBang +
                " END" +
                " ELSE" +
                " BEGIN" +
                " SELECT * FROM nxtckedu_USTeam." + TenBang + " WHERE IDHocSinh = @IDHocSinh" +
                " END" +
                " END";


            await ConnectDB(Query);
        }

        public async Task UpdateBDHK(string TenLop) // Create table database
        {
            string TenBang = "DHK" + TenLop;
            string Query = "CREATE PROCEDURE Update" +
                TenBang +
                " @STT INT," +
                " @IDHocSinh INT," +
                " @IDMonHoc INT," +
                " @Diem FLOAT," +
                " @Loai BIT," +
                " @HocKy BIT" +
                " AS" +
                " BEGIN" +
                " UPDATE nxtckedu_USTeam." + TenBang + " SET" +
                " IDHocSinh = @IDHocSinh," +
                " IDMon = @IDMonHoc," +
                " Diem = @Diem," +
                " Loai = @Loai," +
                " HocKy = @HocKy" +
                " WHERE STT = @STT" +
                " END";

            await ConnectDB(Query);
        }

        #endregion

        #endregion

        private async Task ConnectDB(string Query) // connect database and create
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(Query, con))
                    {
                        await con.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LỖI \n\n" + ex.ToString());
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        public async Task RenameTable(string OldName, string NewName)
        {
            await DeleteFK(OldName);
            await ConnectDB("EXEC sys.sp_rename DHSM" + OldName + ", DHSM" + NewName);
            await ConnectDB("DROP PROCEDURE InsertDHSM" + OldName);
            await ConnectDB("DROP PROCEDURE  DeleteDHSM" + OldName);
            await ConnectDB("DROP PROCEDURE  SelectDHSM" + OldName);
            await ConnectDB("DROP PROCEDURE  UpdateDHSM" + OldName);
            await CreateBDHSM(NewName);
            await DeleteBDHSM(NewName);
            await SelectBDHSM(NewName);
            await UpdateBDHSM(NewName);
            await ConnectDB("EXEC sys.sp_rename DHSH" + OldName + ", DHSH" + NewName);
            await ConnectDB("DROP PROCEDURE  InsertDHSH" + OldName);
            await ConnectDB("DROP PROCEDURE  DeleteDHSH" + OldName);
            await ConnectDB("DROP PROCEDURE  SelectDHSH" + OldName);
            await ConnectDB("DROP PROCEDURE  UpdateDHSH" + OldName);
            await CreateBDHSH(NewName);
            await DeleteBDHSH(NewName);
            await SelectBDHSH(NewName);
            await UpdateBDHSH(NewName);
            await ConnectDB("EXEC sys.sp_rename DHK" + OldName + ", DHK" + NewName);
            await ConnectDB("DROP PROCEDURE  InsertDHK" + OldName);
            await ConnectDB("DROP PROCEDURE  DeleteDHK" + OldName);
            await ConnectDB("DROP PROCEDURE  SelectDHK" + OldName);
            await ConnectDB("DROP PROCEDURE  UpdateDHK" + OldName);
            await CreateBDHK(NewName);
            await DeleteBDHK(NewName);
            await SelectBDHK(NewName);
            await UpdateBDHK(NewName);
            await CreateFK(NewName);
        }

        public async Task CreateTable(string ClassName)
        {
            await BangDiemHeSoMot(ClassName);
            await BangDiemHeSoHai(ClassName);
            await BangDiemHocKy(ClassName);
            await CreateFK(ClassName);
        }

        public async Task DeleteTable(string ClassName)
        {
            await DeleteFK(ClassName);
            await ConnectDB("DROP PROCEDURE InsertDHSM" + ClassName );
            await ConnectDB("DROP PROCEDURE  DeleteDHSM" + ClassName );
            await ConnectDB("DROP PROCEDURE  SelectDHSM" + ClassName );
            await ConnectDB("DROP PROCEDURE  UpdateDHSM" + ClassName );
            await ConnectDB("DROP PROCEDURE  InsertDHSH" + ClassName);
            await ConnectDB("DROP PROCEDURE  DeleteDHSH" + ClassName );
            await ConnectDB("DROP PROCEDURE  SelectDHSH" + ClassName );
            await ConnectDB("DROP PROCEDURE  UpdateDHSH" + ClassName);
            await ConnectDB("DROP PROCEDURE  InsertDHK" + ClassName );
            await ConnectDB("DROP PROCEDURE  DeleteDHK" + ClassName );
            await ConnectDB("DROP PROCEDURE  SelectDHK" + ClassName );
            await ConnectDB("DROP PROCEDURE  UpdateDHK" + ClassName );
            await ConnectDB("DROP TABLE DHSM" + ClassName );
            await ConnectDB("DROP TABLE DHSH" + ClassName );
            await ConnectDB("DROP TABLE DHK" + ClassName);

        }

        public async Task DeleteFK(string ClassName) // delete FOREIGN KEY
        {
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSM" + ClassName + " DROP fk_DHSM" + ClassName + "_IDHocSinh");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSM" + ClassName + " DROP fk_DHSM" + ClassName + "_IDMonHoc");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSH" + ClassName + " DROP fk_DHSH" + ClassName + "_IDHocSinh");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSH" + ClassName + " DROP fk_DHSH" + ClassName + "_IDMonHoc");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHK" + ClassName + " DROP fk_DHK" + ClassName + "_IDHocSinh");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHK" + ClassName + " DROP fk_DHK" + ClassName + "_IDMonHoc");
        } 

        public async Task CreateFK(string ClassName) // create FOREIGN KEY
        {
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSM" + ClassName + " ADD CONSTRAINT fk_DHSM" + ClassName + "_IDHocSinh FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSM" + ClassName + " ADD CONSTRAINT fk_DHSM" + ClassName + "_IDMonHoc FOREIGN KEY(IDMon) REFERENCES nxtckedu_USTeam.MonHoc(ID)");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSH" + ClassName + " ADD CONSTRAINT fk_DHSH" + ClassName + "_IDHocSinh FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHSH" + ClassName + " ADD CONSTRAINT fk_DHSH" + ClassName + "_IDMonHoc FOREIGN KEY(IDMon) REFERENCES nxtckedu_USTeam.MonHoc(ID)");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHK" + ClassName + " ADD CONSTRAINT fk_DHK" + ClassName + "_IDHocSinh FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)");
            await ConnectDB("ALTER TABLE nxtckedu_USTeam.DHK" + ClassName + " ADD CONSTRAINT fk_DHK" + ClassName + "_IDMonHoc FOREIGN KEY(IDMon) REFERENCES nxtckedu_USTeam.MonHoc(ID)");
        }

    }
}
