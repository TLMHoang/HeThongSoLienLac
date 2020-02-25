USE nxtckedu_SoLienLac
GO	

CREATE TABLE TaiKhoanTruong
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TaiKhoan VARCHAR(100),
	MatKhau VARCHAR(500),
	Loai BIT DEFAULT 0
)
GO

CREATE TABLE TaiKhoanPH
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TaiKhoan VARCHAR(100),
	MatKhau VARCHAR(500)

)
GO

CREATE TABLE MonHoc
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TenMon NVARCHAR(200),
	LoaiDiem BIT DEFAULT 1
)
GO

CREATE TABLE Lop
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TenLop NVARCHAR(50)
)
GO

CREATE TABLE ThongTinGV
(
	IDTKT INT PRIMARY KEY,
	TenGV NVARCHAR(200),
	SDT VARCHAR(12),
	IDMonHoc INT,

	FOREIGN KEY (IDTKT) REFERENCES nxtckedu_USTeam.TaiKhoanTruong(ID),
	FOREIGN KEY (IDMonHoc) REFERENCES nxtckedu_USTeam.MonHoc(ID)
)
GO

CREATE TABLE ThongTinHS
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Ten NVARCHAR(200),
	NgaySinh DATE,
	GioiTinh BIT,
	NoiSinh NVARCHAR(250),
	DanToc NVARCHAR(100),
	TonGiao NVARCHAR(100),
	IDLop INT,
	IDTaiKhoan INT,
	TenMe NVARCHAR(150),
	SDTMe VARCHAR(12),
	TenBo NVARCHAR(150),
	SDTBo VARCHAR(12),

	FOREIGN KEY (IDTaiKhoan) REFERENCES nxtckedu_USTeam.TaiKhoanPH(ID),
	FOREIGN KEY (IDLop) REFERENCES nxtckedu_USTeam.Lop(ID)
)
GO

CREATE TABLE DiemDanh
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	IDHocSinh INT,
	NgayNghi DATE,
	Phep BIT DEFAULT 0,

	FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)
)
GO

CREATE TABLE XinPhep
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	IDHocSinh INT,
	NghiTu DATE,
	NghiDen DATE,
	SoNgayNghi INT,

	FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)
)
GO

CREATE TABLE CupHoc
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	IDHocSinh INT,
	Ngay DATE,
	Tiet INT,

	FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)
)
GO

CREATE TABLE HanhKiem
(
	IDHocSinh INT PRIMARY KEY,
	Loai NVARCHAR(20),
	HocKy BIT DEFAULT 0,

	FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)
)
GO

CREATE TABLE ThoiKhoaBieu
(
	IDLop INT,
	Thu INT,
	Tiet INT,
	IDMon INT,

	FOREIGN KEY (IDLop) REFERENCES  nxtckedu_USTeam.Lop(ID),
	FOREIGN KEY (IDMon) REFERENCES nxtckedu_USTeam.MonHoc(ID)
)
GO

CREATE TABLE ThongBaoTruong
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	NoiDung NVARCHAR(MAX)
)
GO	

CREATE TABLE ThongBaoLop
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	IDLop INT,
	NoiDung NVARCHAR(MAX)

	FOREIGN KEY (IDLop) REFERENCES nxtckedu_USTeam.Lop(ID)
)
GO

CREATE TABLE ThongBaoHS
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	IDHocSinh INT,
	NoiDung NVARCHAR(MAX),

	FOREIGN KEY (IDHocSinh) REFERENCES nxtckedu_USTeam.ThongTinHS(ID)
)
GO
CREATE TABLE PhanCong
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	IDGiaoVien INT,
	IDLop INT,
	IDMon INT,

	FOREIGN KEY (IDGiaoVien) REFERENCES nxtckedu_USTeam.TaiKhoanTruong(ID),
	FOREIGN KEY (IDLop) REFERENCES nxtckedu_USTeam.Lop(ID),
	FOREIGN KEY (IDMon) REFERENCES nxtckedu_USTeam.MonHoc(ID)
)
GO	

CREATE TABLE GVCN
(
	IDLop INT,
	IDGiaoVien INT,

	PRIMARY KEY(IDLop,IDGiaoVien),
	FOREIGN KEY (IDLop) REFERENCES nxtckedu_USTeam.Lop(ID),
	FOREIGN KEY (IDGiaoVien) REFERENCES nxtckedu_USTeam.TaiKhoanTruong(ID)
)
GO
--- proc insert

CREATE PROCEDURE InsertCupHoc
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    INSERT nxtckedu_USTeam.CupHoc
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

CREATE PROCEDURE InsertDiemDanh
@IDHocSinh INT,
@NgayNghi DATE,
@Phep BIT
AS
BEGIN
    INSERT nxtckedu_USTeam.DiemDanh
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

CREATE PROCEDURE InsertHanhKiem
@IDHocSinh INT,
@Loai NVARCHAR(20),
@HocKy BIT
AS
BEGIN
    Insert nxtckedu_USTeam.HanhKiem
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
@TenLop NVARCHAR(50)
AS
BEGIN
    Insert nxtckedu_USTeam.Lop
    (
        TenLop
    )
    VALUES
    (@TenLop -- TenLop - nvarchar(50)
        )
END
GO

CREATE PROCEDURE InsertMonhoc
@TenMon NVARCHAR(200),
@LoaiDiem INT
AS
BEGIN
    Insert nxtckedu_USTeam.MonHoc
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

CREATE PROCEDURE InsertTaiKhoanPH
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500)
AS
BEGIN
    INSERT nxtckedu_USTeam.TaiKhoanPH
    (
        TaiKhoan,
        MatKhau
    )
    VALUES
    (   @TaiKhoan, -- TaiKhoan - varchar(100)
        @MatKhau  -- MatKhau - varchar(500)
    )
	DECLARE @I INT = (SELECT ID FROM nxtckedu_USTeam.TaiKhoanTruong WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE nxtckedu_USTeam.TaiKhoanTruong SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END
GO

CREATE PROCEDURE InsertTaiKhoanTruong
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@Loai BIT
AS
BEGIN
    Insert nxtckedu_USTeam.TaiKhoanTruong
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
	DECLARE @I INT = (SELECT ID FROM nxtckedu_USTeam.TaiKhoanTruong WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE nxtckedu_USTeam.TaiKhoanTruong SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END
GO

CREATE PROCEDURE InsertThoiKhaoBieu
@IDLop INT,
@Thu INT,
@Tiet INT,
@IDMon INT
AS
BEGIN
	INSERT nxtckedu_USTeam.ThoiKhoaBieu
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
    Insert nxtckedu_USTeam.ThongBaoHS
    (
		IDHocSinh,
        NoiDung
    )
    VALUES
    (	@IDHocSinh,
		@NoiDung -- NoiDung - nvarchar(max)
        )
END
GO

CREATE PROCEDURE InsertThongBaoLop
@IDLop INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Insert nxtckedu_USTeam.ThongBaoLop
    (
		IDLop,
        NoiDung
    )
    VALUES
    (	@IDLop,
		@NoiDung -- NoiDung - nvarchar(max)
        )
END
GO

CREATE PROCEDURE InsertThongBaoTruong
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Insert nxtckedu_USTeam.ThongBaoTruong
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
@IDMonHoc INT
AS
BEGIN
    Insert nxtckedu_USTeam.ThongTinGV
    (
        IDTKT,
        TenGV,
		SDT,
        IDMonHoc
    )
    VALUES
    (   @IDTKT,   -- IDTKT - int
        @TenGV, -- TenGV - nvarchar(200)
		@SDT,     -- SDT - varchar (12)
		@IDMonHoc   -- IDMonHoc - int
        )
END
GO

CREATE PROCEDURE InsertThongTinHS
@Ten NVARCHAR(200),
@NgaySinh DATE,
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
    INSERT	nxtckedu_USTeam.ThongTinHS
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
        @NgaySinh, -- NgaySinh - DATE
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
	EXEC nxtckedu_USTeam.InsertHanhKiem @IDHocSinh = @IDLop, -- int
	                        @Loai = N'',    -- nvarchar(20)
	                        @HocKy = NULL   -- bit
	
END
GO

CREATE PROCEDURE InsertXinPhep
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@SoNgayNghi INT
AS
BEGIN
    INSERT nxtckedu_USTeam.XinPhep
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        SoNgayNghi
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - DATE
        @NghiDen, -- NghiDen - DATE
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
	Insert nxtckedu_USTeam.PhanCong
	(
		IDGiaoVien ,
		IDLop,
		IDMon 
	)
	values
	(
	@IDGiaoVien ,
	@IDLop,
	@IDMon 
	)
END
GO

CREATE PROC InsertGVCN
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
	Insert nxtckedu_USTeam.GVCN
	(
		IDGiaoVien ,
		IDLop
	)
	values
	(
	@IDGiaoVien ,
	@IDLop
	)
END
GO

-- proc del

CREATE PROCEDURE DeleteCupHoc
@STT INT
AS
BEGIN
    Delete nxtckedu_USTeam.CupHoc WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteDiemDanh
@STT INT
AS
BEGIN
    Delete nxtckedu_USTeam.DiemDanh WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteXinPhep
@STT INT
AS
BEGIN
    Delete nxtckedu_USTeam.XinPhep WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteLop
@ID INT
AS
BEGIN
    Delete nxtckedu_USTeam.Lop WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteMonhoc
@ID INT
AS
BEGIN
    Delete nxtckedu_USTeam.MonHoc WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteTaiKhoanPH
@ID INT
AS
BEGIN
    Delete nxtckedu_USTeam.TaiKhoanPH WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteTaiKhoanTruong
@ID INT
AS
BEGIN
    Delete nxtckedu_USTeam.TaiKhoanTruong WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteThongBaoHS
@STT INT
AS
BEGIN
    Delete nxtckedu_USTeam.ThongBaoHS WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteThongBaoLop
@STT INT
AS
BEGIN
    Delete nxtckedu_USTeam.ThongBaoLop WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteThongBaoTruong
@STT INT
AS
BEGIN
    Delete nxtckedu_USTeam.ThongBaoTruong WHERE STT = @STT 
END
GO

CREATE PROCEDURE DeleteThongTinGV
@IDTKT INT
AS
BEGIN
    Delete nxtckedu_USTeam.ThongTinGV WHERE IDTKT = @IDTKT
END
GO

CREATE PROCEDURE DeleteThongTinHS
@ID INT
AS
BEGIN
    Delete nxtckedu_USTeam.ThongTinHS WHERE ID = @ID
END
GO

CREATE PROC DeletePhanCong
@STT INT
AS
BEGIN
	Delete nxtckedu_USTeam.PhanCong where STT = @STT
END
GO

CREATE PROC DeleteGVCN
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
	IF	@IDLop = -1
	BEGIN
	    DELETE nxtckedu_USTeam.GVCN WHERE IDGiaoVien = @IDGiaoVien
	END
	ELSE
	BEGIN
	    DELETE nxtckedu_USTeam.GVCN WHERE @IDLop = @IDLop
	END
END
GO

-- proc select

CREATE PROCEDURE SelectCupHoc
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.CupHoc
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.CupHoc WHERE IDHocSinh = @IDHocSinh
    END

END
GO

CREATE PROCEDURE SelectDiemDanh
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.DiemDanh
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.DiemDanh WHERE IDHocSinh = @IDHocSinh
    END

END
GO

CREATE PROCEDURE SelectHanhKiem
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.HanhKiem
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.HanhKiem WHERE IDHocSinh = @IDHocSinh
    END

END
GO

CREATE PROCEDURE SelectLop
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.Lop
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.Lop WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectMonhoc
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.MonHoc
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.MonHoc WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectTaiKhoanPH
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.TaiKhoanPH
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.TaiKhoanPH WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectTaiKhoanTruong
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.TaiKhoanTruong
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.TaiKhoanPH WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectThoiKhaoBieu
@IDLop INT
AS
BEGIN
	IF @IDLop = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.ThoiKhoaBieu
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.ThoiKhoaBieu WHERE IDLop = @IDLop
    END

END
GO

CREATE PROCEDURE SelectThongBaoHS
AS
BEGIN
    SELECT * FROM nxtckedu_USTeam.ThongBaoHS
END
GO

CREATE PROCEDURE SelectThongBaoLop
AS
BEGIN
    SELECT * FROM nxtckedu_USTeam.ThongBaoLop
END
GO

CREATE PROCEDURE SelectThongBaoTruong
AS
BEGIN
    SELECT * FROM nxtckedu_USTeam.ThongBaoTruong
END
GO

CREATE PROCEDURE SelectThongTinGV
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.ThongTinGV
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.ThongTinGV WHERE IDTKT = @ID
    END

END
GO

CREATE PROCEDURE SelectThongTinHS
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.ThongTinHS
	END
	ELSE
    BEGIN
        SELECT * FROM nxtckedu_USTeam.ThongTinHS WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectXinPhep
AS
BEGIN
    SELECT * FROM nxtckedu_USTeam.XinPhep
END
GO

CREATE PROC SelectPhanCong
@IDLop INT
as
BEGIN
	IF	@IDlop = -1
	BEGIN
		select * from nxtckedu_USTeam.PhanCong
	END
	ELSE
	BEGIN
	    SELECT * FROM nxtckedu_USTeam.PhanCong WHERE IDLop = @IDLop
	END
end
GO

CREATE PROC SelectGVCN
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
	IF @IDLop = -1 AND @IDGiaoVien = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.GVCN
	END
	ELSE
	BEGIN
	    IF	@IDLop = -1
		BEGIN
			SELECT * FROM nxtckedu_USTeam.GVCN WHERE IDGiaoVien = @IDGiaoVien
		END
		ELSE
		BEGIN
			SELECT * FROM nxtckedu_USTeam.GVCN WHERE @IDLop = @IDLop
		END
	END
	
END
GO

-- proc update


CREATE PROCEDURE UpdateCupHoc
@STT INT,
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    Update nxtckedu_USTeam.CupHoc
    SET	
        IDHocSinh = @IDHocSinh,         -- IDHocSinh - int
        Ngay = @Ngay, -- Ngay - DATE
        Tiet = @Tiet         -- NghiTu - int
	WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateDiemDanh
@STT INT,
@IDHocSinh INT,
@NgayNghi DATE,
@Phep BIT
AS
BEGIN
    Update nxtckedu_USTeam.DiemDanh
    SET	
        IDHocSinh = @IDHocSinh,         -- IDHocSinh - int
        NgayNghi = @NgayNghi, -- NghiTu - DATE
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
    Update nxtckedu_USTeam.HanhKiem
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
    Update nxtckedu_USTeam.Lop
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
    Update nxtckedu_USTeam.MonHoc
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
    Update nxtckedu_USTeam.TaiKhoanPH
    SET	
        MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2)  -- MatKhau - varchar(500)
	WHERE ID = @ID
END
GO

CREATE PROCEDURE UpdateTaiKhoanTruong
@ID INT,
@MatKhau VARCHAR(500),
@Loai BIT
AS
BEGIN
    Update nxtckedu_USTeam.TaiKhoanTruong
    SET	
        MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2),  -- MatKhau - varchar(500)
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
	Update nxtckedu_USTeam.ThoiKhoaBieu
	SET	
	    IDMon = @IDMon  -- IDMon - int	  
	WHERE IDLop = @IDLop AND Thu = @Thu AND Tiet = @Tiet
END
GO

CREATE PROCEDURE UpdateThongBaoHS
@STT INT,
@IDHocSinh INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Update nxtckedu_USTeam.ThongBaoHS
    SET	
	IDHocSinh = @IDHocSinh,
    NoiDung = @NoiDung -- NoiDung - nvarchar(max)
    WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateThongBaoLop
@STT INT,
@IDLop INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Update nxtckedu_USTeam.ThongBaoLop
    SET	
	IDLop = @IDLop,
    NoiDung = @NoiDung -- NoiDung - nvarchar(max)
    WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateThongBaoTruong
@STT INT,
@NoiDung NVARCHAR(MAX)
AS
BEGIN
    Update nxtckedu_USTeam.ThongBaoTruong
    SET	
    NoiDung = @NoiDung -- NoiDung - nvarchar(max)
    WHERE STT = @STT
END
GO

CREATE PROCEDURE UpdateThongTinGV
@IDTKT INT,
@TenGV NVARCHAR(200),
@SDT VARCHAR(12),
@IDMonHoc INT
AS
BEGIN
    Update nxtckedu_USTeam.ThongTinGV
    SET	
        TenGV = @TenGV, -- TenGV - nvarchar(200)
		SDT = @SDT,	-- SDT - varchar(12)
		IDMonHoc = @IDMonHoc   -- IDMonHoc - int
    WHERE  IDTKT = @IDTKT
END
GO

CREATE PROCEDURE UpdateThongTinHS
@ID INT,
@Ten NVARCHAR(200),
@NgaySinh DATE,
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
    Update	nxtckedu_USTeam.ThongTinHS
    SET	
        Ten = @Ten,       -- Ten - nvarchar(200)
        NgaySinh = @NgaySinh, -- NgaySinh - DATE
        GioiTinh = @GioiTinh,      -- GioiTinh - bit
        NoiSinh = @NoiSinh,       -- NoiSinh - nvarchar(250)
        DanToc = @DanToc,       -- DanToc - nvarchar(100)
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
@NghiTu DATE,
@NghiDen DATE,
@SoNgayNghi INT
AS
BEGIN
    Update nxtckedu_USTeam.XinPhep
    SET	
        IDHocSinh = @IDHocSinh,         -- IDHocSinh - int
        NghiTu = @NghiTu, -- NghiTu - DATE
        NghiDen = @NghiDen, -- NghiDen - DATE
        SoNgayNghi = @SoNgayNghi          -- SoNgayNghi - int
    WHERE STT = @STT
END
GO

CREATE PROC UpdatePhanCong
@STT INT,
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
	Update nxtckedu_USTeam.PhanCong
	SET 
		IDGiaoVien = @IDGiaoVien,
		IDLop = @IDLop
	WHERE STT = @STT
END
GO


CREATE PROC UpdateGVCN
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
	UPDATE nxtckedu_USTeam.GVCN
	SET
	IDGiaoVien = @IDGiaoVien
	WHERE IDLop = @IDLop
END
GO


-- proc function

CREATE PROCEDURE DangNhapTruong
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_USTeam.TaiKhoanTruong WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)
GO

CREATE PROCEDURE LayDanhSachTheoLop
@IDLop INT
AS	
BEGIN
    SELECT * FROM nxtckedu_USTeam.ThongTinHS WHERE IDLop = @IDLop
END
GO	

CREATE PROCEDURE UpdateTKQLyHS
@ID INT,
@IDTK INT
AS	
BEGIN
    UPDATE nxtckedu_USTeam.ThongTinHS
	SET	IDTaiKhoan = @IDTK
	WHERE ID = @ID
END
GO	

CREATE PROCEDURE LaySTTDiemDanh
@IDHS INT,
@NgayNghi DATE
AS	
BEGIN
    SELECT * FROM nxtckedu_USTeam.DiemDanh WHERE IDHocSinh = @IDHS AND  NgayNghi = @NgayNghi
END
GO

CREATE PROCEDURE KiemTraLopMon
@IDLop INT,
@IDMon INT
AS	
BEGIN
    SELECT COUNT(STT) FROM nxtckedu_USTeam.PhanCong WHERE IDLop = @IDLop AND  IdMon = @IDMon
END
GO