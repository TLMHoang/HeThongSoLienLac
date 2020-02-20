USE HeThongSoLienLac
GO

CREATE PROCEDURE DeleteCupHoc
@STT INT
AS
BEGIN
    Delete dbo.CupHoc WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteDiemDanh
@STT INT
AS
BEGIN
    Delete dbo.DiemDanh WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteXinPhep
@STT INT
AS
BEGIN
    Delete dbo.XinPhep WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteLop
@ID INT
AS
BEGIN
    Delete dbo.Lop WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteMonhoc
@ID INT
AS
BEGIN
    Delete dbo.MonHoc WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteTaiKhoanPH
@ID INT
AS
BEGIN
    Delete dbo.TaiKhoanPH WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteTaiKhoanTruong
@ID INT
AS
BEGIN
    Delete dbo.TaiKhoanTruong WHERE ID = @ID
END
GO

CREATE PROCEDURE DeleteThongBaoHS
@STT INT
AS
BEGIN
    Delete dbo.ThongBaoHS WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteThongBaoLop
@STT INT
AS
BEGIN
    Delete dbo.ThongBaoLop WHERE STT = @STT
END
GO

CREATE PROCEDURE DeleteThongBaoTruong
@STT INT
AS
BEGIN
    Delete dbo.ThongBaoTruong WHERE STT = @STT 
END
GO

CREATE PROCEDURE DeleteThongTinGV
@IDTKT INT
AS
BEGIN
    Delete dbo.ThongTinGV WHERE IDTKT = @IDTKT
END
GO

CREATE PROCEDURE DeleteThongTinHS
@ID INT
AS
BEGIN
    Delete dbo.ThongTinHS WHERE ID = @ID
END
GO

CREATE PROC DeletePhanCong
@STT INT
AS
BEGIN
	Delete dbo.PhanCong where STT = @STT
END
GO