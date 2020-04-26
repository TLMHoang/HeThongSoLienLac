CREATE PROCEDURE SelectThongTinGV
@IDLop INT
AS
BEGIN
	SELECT A.TenGV, C.TenMon, A.SDT, A.IDLop 
	FROM nxtckedu_sa.TaiKhoanTruong AS A
	JOIN nxtckedu_sa.PhanCongDay AS B
	ON B.IDGiaoVien = A.ID
	JOIN nxtckedu_sa.MonHoc AS C
	ON C.ID = A.IDMonHoc
	WHERE B.IDLop = @IDLop
END
GO


ALTER PROCEDURE SelectThongTinHSv2
@ID INT	
AS
BEGIN
    SELECT HS.CaNam,
           HS.DanToc,
           HS.GioiTinh,
           HS.HKI,
           HS.HKII,
           HS.ID,
           L.IDKhoi,
           HS.IDLoaiHocSinh,
           HS.IDLop,
           HS.NoiSinh,
           HS.NgaySinh,
           HS.Ten,
           K.TenKhoi,
           LHS.TenLoai,
           L.TenLop,
           HS.TonGiao,
		   HS.Tien,
		   BH.DangKy,
		   BH.BHQD
	FROM nxtckedu_sa.ThongTinHS AS HS
	JOIN nxtckedu_sa.Lop AS L
	ON L.ID = HS.IDLop
	JOIN nxtckedu_sa.Khoi AS K
	ON K.ID = L.IDKhoi
	JOIN nxtckedu_sa.LoaiHocSinh AS LHS
	ON LHS.ID = HS.IDLoaiHocSinh
	JOIN nxtckedu_sa.BHYT AS BH
	ON BH.IDHocSinh = HS.ID
	WHERE HS.ID = @ID
END
GO	

CREATE PROCEDURE SelectChiTietTienHoc
@Thang INT,
@IDLoaiHocSinh INT,
@IDKhoi int
AS
BEGIN
    SELECT SoNgayHoc,
				 TienAn,
                 TienDien,
                 TienHoc,
                 TienNuoc,
                 TienTaiLieu,
                 TienTrangThietBi,
                 TienVeSinh
	FROM nxtckedu_sa.TienHocPhi
	WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi
END
GO

ALTER PROCEDURE GetNgayNghi
@IDHocSinh INT,
@StartDate DATE,
@EndDate DATE,
@Phep BIT
AS
BEGIN
	IF @Phep = -1
	BEGIN
		SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= @StartDate AND NgayNghi < @EndDate
	END
	ELSE
	BEGIN
		SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= @StartDate AND NgayNghi < @EndDate AND	Phep = @Phep   
	END
END
GO

ALTER PROCEDURE GetNgayNghiTrongThang
@IDHocSinh INT,
@Phep BIT
AS
BEGIN
	DECLARE @Count INT
	IF @Phep = -1
	BEGIN
		SET @Count = (SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= DATEADD(DAY,1, EOMONTH(GETDATE(), -2)) AND NgayNghi < EOMONTH(GETDATE(),-1))
		RETURN @Count
	END
	ELSE
	BEGIN
		SET @Count = (SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= DATEADD(DAY,1, EOMONTH(GETDATE(), -2)) AND NgayNghi < EOMONTH(GETDATE(),-1) AND Phep = @Phep)
		RETURN @Count
	END
END
GO


CREATE PROCEDURE InsertXinPhepV2
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@LyDo NVARCHAR(1000)
AS
BEGIN
    INSERT nxtckedu_sa.XinPhep
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        TrangThai,
        ChoHuy,
        LyDo
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - date
        @NghiDen, -- NghiDen - date
        0,      -- TrangThai - bit
        0,      -- ChoHuy - bit
        @LyDo        -- LyDo - nvarchar(1000)
        )
END
GO

ALTER PROCEDURE SelectXinPhepTheoIDHS
@IDHocSinh INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.XinPhep WHERE IDHocSinh = @IDHocSinh
END
GO 

ALTER PROCEDURE UpdateXinPhepV2
@ID INT,
@NghiTu DATE,
@NghiDen DATE,
@LyDo NVARCHAR(1000)
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
	SET NghiTu = @NghiTu,
        NghiDen = @NghiDen,
        TrangThai = 0,
        LyDo = @LyDo
	WHERE ID = @ID
END
GO

CREATE PROCEDURE HuyXinPhep
@ID INT
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
	SET TrangThai = 0,
		ChoHuy = 1
	WHERE ID = @ID
END
GO

CREATE PROCEDURE SelectChiTiepDiemDanh
@IDHocSinh INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = 1
END
GO

CREATE PROCEDURE m_SelectThoiKhoaBieu
@IDLop INT
AS
BEGIN
    SELECT Thu, Tiet, TenMon FROM nxtckedu_sa.ThoiKhoaBieu
	JOIN nxtckedu_sa.MonHoc
	ON MonHoc.ID = ThoiKhoaBieu.IDMonHoc
	WHERE IDLop = @IDLop
END
GO

CREATE PROCEDURE SelectMonhocv2
AS
BEGIN
	SELECT ID,TenMon,LoaiDiem FROM nxtckedu_sa.MonHoc WHERE CoDiem = 1
END
GO


alter PROCEDURE SelectBangDiemv2
@IDHocSinh INT 
AS
BEGIN
	SELECT B.IDLoaiDiem,
           B.IDMonHoc,
           B.NgayNhap,
           L.TenLoaiDiem,
           B.HocKyI,
           B.Diem FROM nxtckedu_sa.BangDiem AS B
	JOIN nxtckedu_sa.LoaiDiem AS L
	ON L.ID = B.IDLoaiDiem
	WHERE IDHocSinh = @IDHocSinh
END
GO


	