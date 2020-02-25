USE HeThongSoLienLac
GO

CREATE PROCEDURE SelectCupHoc
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
		SELECT * FROM dbo.CupHoc
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.CupHoc WHERE IDHocSinh = @IDHocSinh
    END

END
GO

CREATE PROCEDURE SelectDiemDanh
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
		SELECT * FROM dbo.DiemDanh
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.DiemDanh WHERE IDHocSinh = @IDHocSinh
    END

END
GO

CREATE PROCEDURE SelectHanhKiem
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
		SELECT * FROM dbo.HanhKiem
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.HanhKiem WHERE IDHocSinh = @IDHocSinh
    END

END
GO

CREATE PROCEDURE SelectLop
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM dbo.Lop
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.Lop WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectMonhoc
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM dbo.MonHoc
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.MonHoc WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectTaiKhoanPH
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM dbo.TaiKhoanPH
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.TaiKhoanPH WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectTaiKhoanTruong
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM dbo.TaiKhoanTruong
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.TaiKhoanPH WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectThoiKhaoBieu
@IDLop INT
AS
BEGIN
	IF @IDLop = -1
	BEGIN
		SELECT * FROM dbo.ThoiKhoaBieu
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.ThoiKhoaBieu WHERE IDLop = @IDLop
    END

END
GO

CREATE PROCEDURE SelectThongBaoHS
AS
BEGIN
    SELECT * FROM dbo.ThongBaoHS
END
GO

CREATE PROCEDURE SelectThongBaoLop
AS
BEGIN
    SELECT * FROM dbo.ThongBaoLop
END
GO

CREATE PROCEDURE SelectThongBaoTruong
AS
BEGIN
    SELECT * FROM dbo.ThongBaoTruong
END
GO

CREATE PROCEDURE SelectThongTinGV
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM dbo.ThongTinGV
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.ThongTinGV WHERE IDTKT = @ID
    END

END
GO

CREATE PROCEDURE SelectThongTinHS
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
		SELECT * FROM dbo.ThongTinHS
	END
	ELSE
    BEGIN
        SELECT * FROM dbo.ThongTinHS WHERE ID = @ID
    END

END
GO

CREATE PROCEDURE SelectXinPhep
AS
BEGIN
    SELECT * FROM dbo.XinPhep
END
GO

CREATE PROC SelectPhanCong
@IDLop INT
as
BEGIN
	IF	@IDlop = -1
	BEGIN
		select * from dbo.PhanCong
	END
	ELSE
	BEGIN
	    SELECT * FROM dbo.PhanCong WHERE IDLop = @IDLop
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
		SELECT * FROM dbo.GVCN
	END
	ELSE
	BEGIN
	    IF	@IDLop = -1
		BEGIN
			SELECT * FROM dbo.GVCN WHERE IDGiaoVien = @IDGiaoVien
		END
		ELSE
		BEGIN
			SELECT * FROM dbo.GVCN WHERE @IDLop = @IDLop
		END
	END
	
END
Go