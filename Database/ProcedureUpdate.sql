USE HeThongSoLienLac
GO

CREATE PROCEDURE UpdateCupHoc
@STT INT,
@IDHocSinh INT,
@Ngay DATETIME,
@NghiTu INT,
@NghiDen INT,
@SoTietNghi INT
AS
BEGIN
    Update dbo.CupHoc
    SET	
        IDHocSinh = @IDHocSinh,         -- IDHocSinh - int
        Ngay = @Ngay, -- Ngay - datetime
        NghiTu = @NghiTu,         -- NghiTu - int
        NghiDen = @NghiDen,         -- NghiDen - int
        SoTietNghi = @SoTietNghi          -- SoTietNghi - int
	WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateDiemDanh
@STT INT,
@IDHocSinh INT,
@NghiTu DATETIME,
@NghiDen DATETIME,
@SoNgayNghi INT,
@Phep BIT
AS
BEGIN
    Update dbo.DiemDanh
    SET	
        IDHocSinh = @IDHocSinh,         -- IDHocSinh - int
        NghiTu = @NghiTu, -- NghiTu - datetime
        NghiDen = @NghiDen, -- NghiDen - datetime
        SoNgayNghi = @SoNgayNghi,         -- SoNgayNghi - int
        Phep = @Phep       -- Phep - bit
	WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateHanhKiem
@IDHocSinh INT,
@Loai NVARCHAR(20),
@HocKy BIT
AS
BEGIN
    Update dbo.HanhKiem
    SET	
        Loai = @Loai -- Loai - nvarchar(20)
	WHERE IDHocSinh = @IDHocSinh AND HocKy = @HocKy
END
GO

CREATE PROCEDURE UpdateLop
@ID INT,
@TenLop NVARCHAR(50)
AS
BEGIN
    Update dbo.Lop
    SET	
    TenLop = @TenLop -- TenLop - nvarchar(50)
	WHERE ID = @ID
END
GO

CREATE PROCEDURE UpdateMonhoc
@ID INT,
@TenMon NVARCHAR(200),
@LoaiDiem INT
AS
BEGIN
    Update dbo.MonHoc
    SET	
        TenMon = @TenMon, -- TenMon - nvarchar(200)
        LoaiDiem = @LoaiDiem -- LoaiDiem - bit
	WHERE ID = @ID
END
GO

CREATE PROCEDURE UpdateTaiKhoanPH
@ID INT,
@MatKhau VARCHAR(500)
AS
BEGIN
    Update dbo.TaiKhoanPH
    SET	
        MatKhau = @MatKhau  -- MatKhau - varchar(500)
	WHERE ID = @ID
END
GO

CREATE PROCEDURE UpdateTaiKhoanTruong
@ID INT,
@MatKhau VARCHAR(500),
@Loai BIT
AS
BEGIN
    Update dbo.TaiKhoanTruong
    SET	
        MatKhau = @MatKhau,  -- MatKhau - varchar(500)
		Loai = @Loai
	WHERE ID = @ID
END
GO

CREATE PROCEDURE UpdateThoiKhaoBieu
@IDLop INT,
@Thu INT,
@Tiet INT,
@IDMon INT
AS
BEGIN
	Update dbo.ThoiKhoaBieu
	SET	
	    IDMon = @IDMon  -- IDMon - int	  
	WHERE IDLop = @IDLop AND Thu = @Thu AND Tiet = @Tiet
END
GO

CREATE PROCEDURE UpdateThongBaoH
@STT INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Update dbo.ThongBaoHS
    SET	
    NoiDung = @NoiDung -- NoiDung - nvarchar(max)
    WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateThongBaoLop
@STT INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Update dbo.ThongBaoLop
    SET	
    NoiDung = @NoiDung -- NoiDung - nvarchar(max)
    WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateThongBaoTruong
@STT INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Update dbo.ThongBaoTruong
    SET	
    NoiDung = @NoiDung -- NoiDung - nvarchar(max)
    WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateThongTinGV
@IDTKT INT,
@TenGV NVARCHAR(200),
@IDMonHoc INT,
@IDLop INT
AS
BEGIN
    Update dbo.ThongTinGV
    SET	
        TenGV = @TenGV, -- TenGV - nvarchar(200)
		IDMonHoc = @IDMonHoc,   -- IDMonHoc - int
        IDLop = @IDLop    -- IDLop - int
    WHERE  IDTKT = @IDTKT
END
GO

CREATE PROCEDURE UpdateThongTinHS
@ID INT,
@Ten NVARCHAR(200),
@NgaySinh DATETIME,
@GioiTinh BIT,
@NoiSinh NVARCHAR(250),
@DanhToc NVARCHAR(100),
@TonGiao NVARCHAR(100),
@IDLop INT,
@IDTaiKhoan INT,
@TenMe NVARCHAR(150),
@SDTMe NVARCHAR(12),
@TenBo NVARCHAR(150),
@SDTBo NVARCHAR(12)
AS
BEGIN
    Update	dbo.ThongTinHS
    SET	
        Ten = @Ten,       -- Ten - nvarchar(200)
        NgaySinh = @NgaySinh, -- NgaySinh - datetime
        GioiTinh = @GioiTinh,      -- GioiTinh - bit
        NoiSinh = @NoiSinh,       -- NoiSinh - nvarchar(250)
        DanhToc = @DanhToc,       -- DanhToc - nvarchar(100)
        TonGiao = @TonGiao,       -- TonGiao - nvarchar(100)
        IDLop = @IDLop,         -- IDLop - int
        IDTaiKhoan = @IDTaiKhoan,         -- IDTaiKhoan - int
        TenMe = @TenMe,       -- TenMe - nvarchar(150)
        SDTMe = @SDTMe,        -- SDTMe - varchar(12)
        TenBo = @TenBo,       -- TenBo - nvarchar(150)
        SDTBo = @SDTBo         -- SDTBo - varchar(12)
    WHERE ID = @ID
END
GO

CREATE PROCEDURE UpdateXinPhep
@STT INT,
@IDHocSinh INT,
@NghiTu DATETIME,
@NghiDen DATETIME,
@SoNgayNghi INT
AS
BEGIN
    Update dbo.XinPhep
    SET	
        IDHocSinh = @IDHocSinh,         -- IDHocSinh - int
        NghiTu = @NghiTu, -- NghiTu - datetime
        NghiDen = @NghiDen, -- NghiDen - datetime
        SoNgayNghi = @SoNgayNghi          -- SoNgayNghi - int
    WHERE STT = @STT
END
GO