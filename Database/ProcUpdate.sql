ALTER PROCEDURE UpdateBangDiem
@ID INT,
@IDHocSinh INT,
@IDMonHoc INT,
@IDLoaiDiem INT,
@NgayNhap DATE,
@Diem FLOAT,
@HocKyI BIT	
AS
BEGIN
    UPDATE nxtckedu_sa.BangDiem
    SET	IDHocSinh = @IDHocSinh,
		IDMonHoc = @IDMonHoc,
		IDLoaiDiem = @IDLoaiDiem,
		NgayNhap = @NgayNhap,
		Diem = @Diem,
		HocKyI = @HocKyI
	WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdateBHYT
@IDHocSinh INT,
@DangKy BIT,
@BHQD BIT
AS
BEGIN
    UPDATE nxtckedu_sa.BHYT
    SET	DangKy = @DangKy,
        BHQD = @BHQD
    WHERE IDHocSinh = @IDHocSinh
END
GO	

ALTER PROCEDURE UpdateCupHoc
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END
GO

ALTER PROCEDURE UpdateDiemDanh
@ID INT,
@IDHocSinh INT,
@NgayNghi DATE,
@Phep BIT
AS
BEGIN
    UPDATE nxtckedu_sa.DiemDanh
    SET IDHocSinh = @IDHocSinh,
        NgayNghi = @NgayNghi,
        Phep = @Phep
    WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdateKhoi
@ID INT,
@TenKhoi NVARCHAR(20)
AS
BEGIN
    UPDATE nxtckedu_sa.Khoi
    SET
        TenKhoi = @TenKhoi
    WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdateLienKetPHvsHS
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
    UPDATE nxtckedu_sa.LienKetPHvsHS
    SET
        IDTaiKhoan = IDTaiKhoan
    WHERE IDHocSinh = @IDHocSinh
END
GO

ALTER PROCEDURE UpdateLoaiDiem
@ID INT,
@TenLoaiDiem nvarchar(50)
AS
BEGIN
    UPDATE nxtckedu_sa.LoaiDiem
    SET
        TenLoaiDiem = @TenLoaiDiem
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE UpdateHanhKiem
@ID INT,
@TenHanhKiem nvarchar(60)
AS
BEGIN
	UPDATE nxtckedu_sa.LoaiHanhKiem
	SET
	    TenHanhKiem = @TenHanhKiem
	WHERE ID = @ID
END
GO 

ALTER PROCEDURE UpdateLoaiHocSinh
@ID INT,
@TenLoai nvarchar(200)
AS
BEGIN
    UPDATE nxtckedu_sa.LoaiHocSinh
    SET
        TenLoai = @TenLoai
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE UpdateLoaiThongBao
@ID INT,
@TenThongBao nvarchar(100)
AS
BEGIN
    UPDATE nxtckedu_sa.LoaiThongBao
    SET
        TenThongBao = @TenThongBao
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE UpdateLop
@ID INT,
@IDKhoi INT, 
@TenLop NVARCHAR(50)
AS
BEGIN
    UPDATE nxtckedu_sa.Lop
    SET
        IDKhoi = @IDKhoi,
        TenLop = @TenLop
    WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdateMonhoc
@ID INT,
@TenMon NVARCHAR(200),
@LoaiDiem INT
AS
BEGIN
    Update nxtckedu_sa.MonHoc
    SET	
        TenMon = @TenMon,
        LoaiDiem = @LoaiDiem
    WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdatePhanCongDay
@ID INT,
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
	Update nxtckedu_sa.PhanCongDay
	SET
	    IDGiaoVien = @IDGiaoVien,
	    IDLop = @IDLop
    WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdateTaiKhoanPH
@ID INT,
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@TenMe NVARCHAR(150),
@SDTMe VARCHAR(12),
@TenBo NVARCHAR(150),
@SDTBo VARCHAR(12)
AS
BEGIN
    UPDATE nxtckedu_sa.TaiKhoanPH
    SET	
        TaiKhoan = @TaiKhoan,
        MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2),
        TenMe = @TenMe,
        SDTMe = @SDTMe,
        TenBo = @TenBo,
        SDTBo = @SDTBo
     WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdateTaiKhoanTruong
@ID INT,
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@Loai BIT,
@TenGV NVARCHAR(200),
@SDT VARCHAR(12),
@IDMonHoc INT,
@IDLop INT
AS
BEGIN
	UPDATE nxtckedu_sa.TaiKhoanTruong
	SET
	    TaiKhoan = @TaiKhoan,
	    MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2),
	    Loai = @Loai,
	    TenGV = @TenGV,
	    SDT = @SDT,
	    IDMonHoc = @IDMonHoc,
	    IDLop = @IDLop
     WHERE ID = @ID
END
GO

ALTER PROCEDURE UpdateThoiKhaoBieu
@IDLop INT,
@Thu INT,
@Tiet INT,
@IDMonHoc INT
AS
BEGIN
	UPDATE nxtckedu_sa.ThoiKhoaBieu
	SET
	    Tiet = @Tiet,
	    IDMonHoc = @IDMonHoc
	WHERE IDLop = @IDLop AND Thu = @Thu
END
GO

ALTER PROCEDURE UpdateThongBaoHS
@ID INT,
@IDHocSinh INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
	UPDATE nxtckedu_sa.ThongBaoHS
	SET
	    IDHocSinh = @IDHocSinh,
	    NoiDung = @NoiDung,
	    Ngay= @Ngay,
	    IDLoaiThongBao = @IDLoaiThongBao
     WHERE ID = @ID
	
END
GO

ALTER PROCEDURE UpdateThongBaoLop
@ID INT,
@IDLop INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Update nxtckedu_sa.ThongBaoLop
    SET
		IDLop = @IDLop,
        NoiDung = @NoiDung,
	    Ngay= @Ngay,
	    IDLoaiThongBao = @IDLoaiThongBao
     WHERE ID = @ID

END
GO

ALTER PROCEDURE UpdateThongBaoTruong
@ID INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Update nxtckedu_sa.ThongBaoTruong
    SET
        NoiDung = @NoiDung,
	    Ngay= @Ngay,
	    IDLoaiThongBao = @IDLoaiThongBao
     WHERE ID = @ID
    
END
GO

ALTER PROCEDURE UpdateThongTinHS
@ID INT,
@Ten NVARCHAR(200),
@NgaySinh DATE,
@GioiTinh BIT,
@NoiSinh NVARCHAR(250),
@DanToc NVARCHAR(100),
@TonGiao NVARCHAR(100),
@IDLop INT,
@IDTaiKhoan INT,
@IDLoaiHocSinh INT,
@HKI INT,
@HKII INT,
@CaNam INT
AS
BEGIN
	UPDATE nxtckedu_sa.ThongTinHS
	SET
	    Ten = @Ten,
	    NgaySinh = @NgaySinh,
	    GioiTinh = @GioiTinh,
	    NoiSinh = @NoiSinh,
	    DanToc = @DanToc,
	    TonGiao = @TonGiao,
	    IDLop = @IDLop,
	    IDLoaiHocSinh = @IDLoaiHocSinh,
	    HKI = @HKI,
	    HKII = @HKII,
	    CaNam = @CaNam
     WHERE ID = @ID
	
END
GO

ALTER PROCEDURE UpdateTienHocPhi
@ID INT,
@Thang INT,
@IDLoaiHocSinh INT,
@IDKhoi INT,
@SoNgayHoc INT,
@TienHoc INT,
@TienAn INT,
@TienDien INT,
@TienNuoc INT,
@TienVeSinh INT,
@TienTrangThietBi INT,
@TienTaiLieu INT
AS
BEGIN
    UPDATE nxtckedu_sa.TienHocPhi
    SET
        Thang  = @Thang,
        IDLoaiHocSinh = @IDLoaiHocSinh,
        IDKhoi = @IDKhoi,
        SoNgayHoc = @SoNgayHoc,
        TienHoc = @TienHoc,
        TienAn = @TienAn,
        TienDien = @TienDien,
        TienNuoc = @TienNuoc,
        TienVeSinh = @TienVeSinh,
        TienTrangThietBi = @TienTrangThietBi,
        TienTaiLieu = @TienTaiLieu
     WHERE ID = @ID
    
END
GO	

ALTER PROCEDURE UpdateXinPhep
@ID INT,
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@TrangThai BIT ,
@ChoHuy BIT 
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
    SET
        IDHocSinh = @IDHocSinh,
        NghiTu = @NghiTu,
        NghiDen = @NghiDen,
        TrangThai = @TrangThai,
		ChoHuy = @ChoHuy
     WHERE ID = @ID
    
END
GO