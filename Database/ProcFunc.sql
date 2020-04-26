ALTER PROCEDURE DangNhapTruong
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_sa.TaiKhoanTruong WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)
GO

ALTER PROCEDURE DangNhapPH
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)
GO

ALTER PROCEDURE SelectLayHSQuanLy
@IDTaiKhoan INT
AS
BEGIN
	SELECT * FROM nxtckedu_sa.LienKetPHvsHS WHERE IDTaiKhoan = @IDTaiKhoan
END
GO

ALTER PROCEDURE DoiMatKhauPH
@ID INT,
@MatKhauCu VARCHAR(200),
@MatKhauMoi VARCHAR(200)
AS
BEGIN
    IF (SELECT COUNT(ID) FROM nxtckedu_sa.TaiKhoanPH WHERE ID = @ID AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauCu),2)) = 1
	BEGIN
	    UPDATE nxtckedu_sa.TaiKhoanPH 
		SET MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauMoi),2) 
		WHERE ID = @ID
	END
END
GO	

ALTER PROCEDURE DoiMatKhauTruong
@ID INT,
@MatKhauCu VARCHAR(200),
@MatKhauMoi VARCHAR(200)
AS
BEGIN
    IF (SELECT COUNT(ID) FROM nxtckedu_sa.TaiKhoanTruong WHERE ID = @ID AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauCu),2)) = 1
	BEGIN
	    UPDATE nxtckedu_sa.TaiKhoanTruong 
		SET MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauMoi),2) 
		WHERE ID = @ID
	END
END
GO	

ALTER PROCEDURE SelectHocSinhTrongLop
@IDLop INT
AS
BEGIN
    SELECT Ten,NgaySinh FROM nxtckedu_sa.ThongTinHS WHERE IDLop = @IDLop
END
GO 

ALTER PROCEDURE SelectListThongBaoTruong
AS
BEGIN
    SELECT ThongBaoTruong.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoTruong
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = nxtckedu_sa.ThongBaoTruong.IDLoaiThongBao
END
GO	

CREATE PROCEDURE SelectNoiDungThongBaoTruong
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoTruong WHERE ID = @ID
END
GO

ALTER PROCEDURE SelectListThongBaoHS
@IDHocSinh INT
AS
BEGIN
    SELECT ThongBaoHS.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoHS 
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = ThongBaoHS.IDLoaiThongBao
	WHERE IDHocSinh = @IDHocSinh
END
GO	

CREATE PROCEDURE SelectNoiDungThongBaoHS
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoHS WHERE ID = @ID
END
GO

ALTER PROCEDURE SelectListThongBaoLop
@IDLop INT
AS
BEGIN
    SELECT ThongBaoLop.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoLop 
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = ThongBaoLop.IDLoaiThongBao WHERE IDLop = @IDLop
END
GO

CREATE PROCEDURE SelectNoiDungThongBaoLop
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoLop WHERE ID = @ID
END
GO

CREATE PROCEDURE LayTienHocPhiHocSinh
@IDLoaiHocSinh INT,
@Thang INT,
@IDKhoi INT
AS
BEGIN
-- tông tiên
	DECLARE @TongTien INT = 0
	SET @TongTien = @TongTien +  (SELECT TienHoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
	SET @TongTien = @TongTien +  (SELECT TienDien FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
	SET @TongTien = @TongTien +  (SELECT TienNuoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
	SET @TongTien = @TongTien +  (SELECT TienVeSinh FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
	SET @TongTien = @TongTien +  (SELECT TienTrangThietBi FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
	SET @TongTien = @TongTien +  (SELECT TienTaiLieu FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
	
	RETURN @TongTien
END
GO 


CREATE PROCEDURE SelectFunctionOrder
AS
BEGIN
    SELECT * FROM FunctionOrder
END