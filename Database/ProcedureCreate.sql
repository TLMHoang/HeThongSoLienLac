USE HeThongSoLienLac
GO

CREATE PROCEDURE InsertCupHoc
@IDHocSinh INT,
@Ngay DATETIME,
@NghiTu INT,
@NghiDen INT,
@SoTietNghi INT
AS
BEGIN
    INSERT dbo.CupHoc
    (
        IDHocSinh,
        Ngay,
        NghiTu,
        NghiDen,
        SoTietNghi
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @Ngay, -- Ngay - datetime
        @NghiTu,         -- NghiTu - int
        @NghiDen,         -- NghiDen - int
        @SoTietNghi          -- SoTietNghi - int
        )
END
GO

CREATE PROCEDURE InsertDiemDanh
@IDHocSinh INT,
@NghiTu DATETIME,
@NghiDen DATETIME,
@SoNgayNghi INT,
@Phep BIT
AS
BEGIN
    INSERT dbo.DiemDanh
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        SoNgayNghi,
        Phep
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - datetime
        @NghiDen, -- NghiDen - datetime
        @SoNgayNghi,         -- SoNgayNghi - int
        @Phep       -- Phep - bit
        )
END
GO

CREATE PROCEDURE InsertHanhKiem
@IDHocSinh INT,
@Loai NVARCHAR(20),
@HocKy BIT
AS
BEGIN
    Insert dbo.HanhKiem
    (
        IDHocSinh,
        Loai,
        HocKy
    )
    VALUES
    (   @IDHocSinh,   -- IDHocSinh - int
        @Loai, -- Loai - nvarchar(20)
        @HocKy -- HocKy - bit
        )
END
GO

CREATE PROCEDURE InsertLop
@TenLop NVARCHAR(50),
@IDGiaoVien INT
AS
BEGIN
    Insert dbo.Lop
    (
        TenLop,
    )
    VALUES
    (@TenLop, -- TenLop - nvarchar(50)
        )
END
GO

CREATE PROCEDURE InsertMonhoc
@ID INT,
@TenMon NVARCHAR(200),
@LoaiDiem INT
AS
BEGIN
    Insert dbo.MonHoc
    (
        ID,
        TenMon,
        LoaiDiem
    )
    VALUES
    (   @ID,   -- ID - int
        @TenMon, -- TenMon - nvarchar(200)
        @LoaiDiem -- LoaiDiem - bit
        )
END
GO

CREATE PROCEDURE InsertTaiKhoanPH
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500)
AS
BEGIN
    INSERT dbo.TaiKhoanPH
    (
        TaiKhoan,
        MatKhau
    )
    VALUES
    (   @TaiKhoan, -- TaiKhoan - varchar(100)
        @MatKhau  -- MatKhau - varchar(500)
    )
	DECLARE @I INT = (SELECT ID FROM dbo.TaiKhoanTruong WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE dbo.TaiKhoanTruong SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END
GO

CREATE PROCEDURE InsertTaiKhoanTruong
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@Loai BIT
AS
BEGIN
    Insert dbo.TaiKhoanTruong
    (
        TaiKhoan,
        MatKhau,
        Loai
    )
    VALUES
    (   @TaiKhoan,  -- TaiKhoan - varchar(100)
        @MatKhau,  -- MatKhau - varchar(500)
        @Loai -- Loai - bit
    )
	DECLARE @I INT = (SELECT ID FROM dbo.TaiKhoanTruong WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE dbo.TaiKhoanTruong SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END
GO

CREATE PROCEDURE InsertThoiKhaoBieu
@IDLop INT,
@Thu INT,
@Tiet INT,
@IDMon INT
AS
BEGIN
	INSERT dbo.ThoiKhoaBieu
	(
	    IDLop,
	    Thu,
	    Tiet,
	    IDMon
	)
	VALUES
	(   @IDLop, -- IDLop - int
	    @Thu, -- Thu - int
	    @Tiet, -- Tiet - int
	    @IDMon  -- IDMon - int
	    )
END
GO

CREATE PROCEDURE InsertThongBaoHS
@IDHocSinh INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Insert dbo.ThongBaoHS
    (
		IDHocSinh,
        NoiDung
    )
    VALUES
    (	@IDHocSinh
		@NoiDung -- NoiDung - nvarchar(max)
        )
END
GO

CREATE PROCEDURE InsertThongBaoLop
@IDLop INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Insert dbo.ThongBaoLop
    (
		IDLop
        NoiDung
    )
    VALUES
    (	@IDLop
		@NoiDung -- NoiDung - nvarchar(max)
        )
END
GO

CREATE PROCEDURE InsertThongBaoTruong
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Insert dbo.ThongBaoTruong
    (
        NoiDung
    )
    VALUES
    (@NoiDung -- NoiDung - nvarchar(max)
        )
END
GO

CREATE PROCEDURE InsertThongTinGV
@IDTKT INT,
@TenGV NVARCHAR(200),
@SDT VARCHAR(12),
@IDMonHoc INT,
@IDLop INT,
@GVCN BIT	
AS
BEGIN
    Insert dbo.ThongTinGV
    (
        IDTKT,
        TenGV,
		SDT,
        IDMonHoc,
        IDLop,
		GVCN
    )
    VALUES
    (   @IDTKT,   -- IDTKT - int
        @TenGV, -- TenGV - nvarchar(200)
		@SDT,     -- SDT - varchar (12)
		@IDMonHoc,   -- IDMonHoc - int
        @IDLop,    -- IDLop - int
		@GVCN
        )
END
GO

CREATE PROCEDURE InsertThongTinHS
@Ten NVARCHAR(200),
@NgaySinh DATETIME,
@GioiTinh BIT,
@NoiSinh NVARCHAR(250),
@DanToc NVARCHAR(100),
@TonGiao NVARCHAR(100),
@IDLop INT,
@IDTaiKhoan INT,
@TenMe NVARCHAR(150),
@SDTMe NVARCHAR(12),
@TenBo NVARCHAR(150),
@SDTBo NVARCHAR(12)
AS
BEGIN
    INSERT	dbo.ThongTinHS
    (
        Ten,
        NgaySinh,
        GioiTinh,
        NoiSinh,
        DanToc,
        TonGiao,
        IDLop,
        IDTaiKhoan,
        TenMe,
        SDTMe,
        TenBo,
        SDTBo
    )
    VALUES
    (   @Ten,       -- Ten - nvarchar(200)
        @NgaySinh, -- NgaySinh - datetime
        @GioiTinh,      -- GioiTinh - bit
        @NoiSinh,       -- NoiSinh - nvarchar(250)
        @DanToc,       -- DanToc - nvarchar(100)
        @TonGiao,       -- TonGiao - nvarchar(100)
        @IDLop,         -- IDLop - int
        @IDTaiKhoan,         -- IDTaiKhoan - int
        @TenMe,       -- TenMe - nvarchar(150)
        @SDTMe,        -- SDTMe - varchar(12)
        @TenBo,       -- TenBo - nvarchar(150)
        @SDTBo         -- SDTBo - varchar(12)
        )
	EXEC dbo.InsertHanhKiem @IDHocSinh = @IDLop, -- int
	                        @Loai = N'',    -- nvarchar(20)
	                        @HocKy = NULL   -- bit
	
END
GO

CREATE PROCEDURE InsertXinPhep
@IDHocSinh INT,
@NghiTu DATETIME,
@NghiDen DATETIME,
@SoNgayNghi INT
AS
BEGIN
    INSERT dbo.XinPhep
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        SoNgayNghi
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - datetime
        @NghiDen, -- NghiDen - datetime
        @SoNgayNghi          -- SoNgayNghi - int
        )
END
GO

CREATE PROC InsertPhanCong
@IDGiaoVien INT,
@IDLop INT,
@IDMon INT

AS
BEGIN
	Insert dbo.PhanCong
	(
		IDGiaoVien ,
		IDLop ,
		IDMon 
	)
	values
	(
	@IDGiaoVien ,
	@IDLop ,
	@IDMon
	)
END
GO