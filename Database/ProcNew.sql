ALTER PROCEDURE InsertBangDiem
@IDHocSinh INT,
@IDMonHoc INT,
@IDLoaiDiem INT,
@NgayNhap DATE,
@Diem FLOAT,
@HocKyI BIT	
AS
BEGIN
    INSERT nxtckedu_sa.BangDiem
    (
        IDHocSinh,
        IDMonHoc,
        IDLoaiDiem,
        NgayNhap,
        Diem,
        HocKyI
    )
    VALUES
    (   @IDHocSinh,
		@IDMonHoc,
		@IDLoaiDiem,
		@NgayNhap,
		@Diem,
		@HocKyI
        )
END
GO

ALTER PROCEDURE InsertBHYT
@IDHocSinh INT,
@DangKy BIT,
@BHQD BIT
AS
BEGIN
    INSERT nxtckedu_sa.BHYT
    (
        IDHocSinh,
        DangKy,
        BHQD
    )
    VALUES
    (   @IDHocSinh,
		@DangKy,
		@BHQD
        )
END
GO	

ALTER PROCEDURE InsertCupHoc
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    INSERT nxtckedu_sa.CupHoc
    (
        IDHocSinh,
        Ngay,
        Tiet
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @Ngay, -- Ngay - DATE
        @Tiet        -- Tiet - int
        )
END
GO

ALTER PROCEDURE InsertDiemDanh
@IDHocSinh INT,
@NgayNghi DATE,
@Phep BIT
AS
BEGIN
    INSERT nxtckedu_sa.DiemDanh
    (
        IDHocSinh,
        NgayNghi,
        Phep
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NgayNghi, -- NghiTu - DATE
        @Phep       -- Phep - bit
        )
END
GO

ALTER PROCEDURE InsertKhoi
@TenKhoi NVARCHAR(20)
AS
BEGIN
    INSERT nxtckedu_sa.Khoi
    (
        TenKhoi
    )
    VALUES
    (@TenKhoi -- TenKhoi - nvarchar(20)
        )
END
GO

ALTER PROCEDURE InsertLienKetPHvsHS
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
    INSERT nxtckedu_sa.LienKetPHvsHS
    (
        IDHocSinh,
        IDTaiKhoan
    )
    VALUES
    (   @IDHocSinh,
        @IDTaiKhoan
        )
END
GO

ALTER PROCEDURE InsertLoaiDiem
@TenLoaiDiem nvarchar(50)
AS
BEGIN
    INSERT nxtckedu_sa.LoaiDiem
    (
        TenLoaiDiem
    )
    VALUES
    (@TenLoaiDiem -- TenLoaiDiem - nvarchar(50)
        )
END
GO 

ALTER PROCEDURE InsertHanhKiem
@TenHanhKiem nvarchar(60)
AS
BEGIN
	INSERT nxtckedu_sa.LoaiHanhKiem
	(
	    TenHanhKiem
	)
	VALUES
	(@TenHanhKiem -- TenHanhKiem - nvarchar(60)
	    )
END
GO 

ALTER PROCEDURE InsertLoaiHocSinh
@TenLoai nvarchar(200)
AS
BEGIN
    INSERT nxtckedu_sa.LoaiHocSinh
    (
        TenLoai
    )
    VALUES
    (@TenLoai -- TenLoai - nvarchar(200)
        )
END
GO 

ALTER PROCEDURE InsertLoaiThongBao
@TenThongBao nvarchar(100)
AS
BEGIN
    INSERT nxtckedu_sa.LoaiThongBao
    (
        TenThongBao
    )
    VALUES
    (@TenThongBao -- TenThongBao - nvarchar(100)
        )
END
GO 

ALTER PROCEDURE InsertLop
@IDKhoi INT, 
@TenLop NVARCHAR(50)
AS
BEGIN
    INSERT nxtckedu_sa.Lop
    (
        IDKhoi,
        TenLop
    )
    VALUES
    (   @IDKhoi,  -- IDKhoi - int
        @TenLop -- TenLop - nvarchar(50)
        )
END
GO

ALTER PROCEDURE InsertMonhoc
@TenMon NVARCHAR(200),
@LoaiDiem INT
AS
BEGIN
    Insert nxtckedu_sa.MonHoc
    (
        TenMon,
        LoaiDiem
    )
    VALUES
    (
        @TenMon, -- TenMon - nvarchar(200)
        @LoaiDiem -- LoaiDiem - bit
        )
END
GO

ALTER PROCEDURE InsertPhanCongDay
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
    INSERT nxtckedu_sa.PhanCongDay
    (
        IDGiaoVien,
        IDLop
    )
    VALUES
    (   @IDGiaoVien,
        @IDLop
        )
END
GO

ALTER PROCEDURE InsertTaiKhoanPH
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@TenMe NVARCHAR(150),
@SDTMe VARCHAR(12),
@TenBo NVARCHAR(150),
@SDTBo VARCHAR(12)
AS
BEGIN
    INSERT nxtckedu_sa.TaiKhoanPH
    (
        TaiKhoan,
        MatKhau,
        TenMe,
        SDTMe,
        TenBo,
        SDTBo
    )
    VALUES
    (   @TaiKhoan,
        @MatKhau,
        @TenMe,
        @SDTMe,
        @TenBo,
        @SDTBo
        )
	DECLARE @I INT = (SELECT ID FROM nxtckedu_sa.TaiKhoanPH WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE nxtckedu_sa.TaiKhoanPH SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END
GO

ALTER PROCEDURE InsertTaiKhoanTruong
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@Loai BIT,
@TenGV NVARCHAR(200),
@SDT VARCHAR(12),
@IDMonHoc INT,
@IDLop INT
AS
BEGIN
	INSERT nxtckedu_sa.TaiKhoanTruong
	(
	    TaiKhoan,
	    MatKhau,
	    Loai,
	    TenGV,
	    SDT,
	    IDMonHoc,
	    IDLop
	)
	VALUES
	(   @TaiKhoan,
		@MatKhau,
		@Loai,
		@TenGV,
		@SDT,
		@IDMonHoc,
		@IDLop
	    )
	DECLARE @I INT = (SELECT ID FROM nxtckedu_sa.TaiKhoanTruong WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE nxtckedu_sa.TaiKhoanTruong SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END
GO

ALTER PROCEDURE InsertThoiKhaoBieu
@IDLop INT,
@Thu INT,
@Tiet INT,
@IDMonHoc INT
AS
BEGIN
	INSERT nxtckedu_sa.ThoiKhoaBieu
	(
	    IDLop,
	    Thu,
	    Tiet,
	    IDMonHoc
	)
	VALUES
	(   @IDLop, -- IDLop - int
	    @Thu, -- Thu - int
	    @Tiet, -- Tiet - int
	    @IDMonHoc  -- IDMon - int
	    )
END
GO

ALTER PROCEDURE InsertThongBaoHS
@IDHocSinh INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
	INSERT nxtckedu_sa.ThongBaoHS
	(
	    IDHocSinh,
	    NoiDung,
	    Ngay,
	    IDLoaiThongBao
	)
	VALUES
	(   @IDHocSinh,
		@NoiDung,
	    @Ngay,
	    @IDLoaiThongBao
	    )
END
GO

ALTER PROCEDURE InsertThongBaoLop
@IDLop INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Insert nxtckedu_sa.ThongBaoLop
    (
		IDLop,
        NoiDung,
		Ngay,
	    IDLoaiThongBao
    )
    VALUES
    (	@IDLop,
		@NoiDung,
		@Ngay,
	    @IDLoaiThongBao
        )
END
GO

ALTER PROCEDURE InsertThongBaoTruong
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Insert nxtckedu_sa.ThongBaoTruong
    (
        NoiDung,
		Ngay,
	    IDLoaiThongBao
    )
    VALUES
    (	@NoiDung,
		@Ngay,
	    @IDLoaiThongBao
        )
END
GO

ALTER PROCEDURE InsertThongTinHS
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
	INSERT nxtckedu_sa.ThongTinHS
	(
	    Ten,
	    NgaySinh,
	    GioiTinh,
	    NoiSinh,
	    DanToc,
	    TonGiao,
	    IDLop,
	    IDLoaiHocSinh,
	    HKI,
	    HKII,
	    CaNam
	)
	VALUES
	(   @Ten,       -- Ten - nvarchar(200)
        @NgaySinh, -- NgaySinh - DATE
        @GioiTinh,      -- GioiTinh - bit
        @NoiSinh,       -- NoiSinh - nvarchar(250)
        @DanToc,       -- DanToc - nvarchar(100)
        @TonGiao,       -- TonGiao - nvarchar(100)
        @IDLop,         -- IDLop - int
	    @IDLoaiHocSinh,
		@HKI,
		@HKII,
		@CaNam
	    )
END
GO

ALTER PROCEDURE InsertTienHocPhi
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
    INSERT nxtckedu_sa.TienHocPhi
    (
        Thang,
        IDLoaiHocSinh,
        IDKhoi,
        SoNgayHoc,
        TienHoc,
        TienAn,
        TienDien,
        TienNuoc,
        TienVeSinh,
        TienTrangThietBi,
        TienTaiLieu
    )
    VALUES
    (   @Thang,
        @IDLoaiHocSinh,
        @IDKhoi,
        @SoNgayHoc,
        @TienHoc,
        @TienAn,
        @TienDien,
        @TienNuoc,
        @TienVeSinh,
        @TienTrangThietBi,
        @TienTaiLieu
        )
END
GO	

ALTER PROCEDURE InsertXinPhep
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@TrangThai BIT,
@ChoHuy BIT 
AS
BEGIN
    INSERT nxtckedu_sa.XinPhep
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        TrangThai,
		ChoHuy
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - DATE
        @NghiDen, -- NghiDen - DATE
        @TrangThai,         
		@ChoHuy
        )
END
GO