ALTER PROCEDURE DangNhapTruong
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_Backup.TaiKhoanTruong WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)
GO

ALTER PROCEDURE DangNhapPH
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_Backup.TaiKhoanPH WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)
GO

ALTER PROCEDURE SelectLayHSQuanLy
@IDTaiKhoan INT
AS
BEGIN
	SELECT * FROM nxtckedu_Backup.LienKetPHvsHS WHERE IDTaiKhoan = @IDTaiKhoan
END
GO

ALTER PROCEDURE DoiMatKhauPH
@ID INT,
@MatKhauCu VARCHAR(200),
@MatKhauMoi VARCHAR(200)
AS
BEGIN
    IF (SELECT COUNT(ID) FROM nxtckedu_Backup.TaiKhoanPH WHERE ID = @ID AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauCu),2)) = 1
	BEGIN
	    UPDATE nxtckedu_Backup.TaiKhoanPH 
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
    IF (SELECT COUNT(ID) FROM nxtckedu_Backup.TaiKhoanTruong WHERE ID = @ID AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauCu),2)) = 1
	BEGIN
	    UPDATE nxtckedu_Backup.TaiKhoanTruong 
		SET MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauMoi),2) 
		WHERE ID = @ID
	END
END
GO	

ALTER PROCEDURE SelectHocSinhTrongLop
@IDLop INT
AS
BEGIN
    SELECT Ten,NgaySinh FROM nxtckedu_Backup.ThongTinHS WHERE IDLop = @IDLop
END
GO 

--ALTER PROCEDURE TongTien
--@Thang INT,
--@IDLoaiHocSinh INT,
--@IDKhoi INT,
--@SoNgayNghi INT
--AS
--BEGIN
    
--	RETURN @TongTien
--END
--GO

--ALTER PROCEDURE LayNgayNghiCoPhep
--@Start DATE,
--@End DATE,


--ALTER PROCEDURE LayTienHocPhi
--@IDHocSinh INT,
--@IDLoaiHocSinh INT,
--@Start DATE,
--@End DATE
--AS
--BEGIN
---- tông tiên
--	DECLARE @TongTien INT = 0
--	DECLARE @NgayHoc INT = (SELECT SoNgayHoc FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
--	SET @NgayHoc = @NgayHoc - @SoNgayNghi
--	SET @TongTien = @TongTien + ((SELECT TienAn FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi) * @NgayHoc)
--	SET @TongTien = @TongTien +  (SELECT TienHoc FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
--	SET @TongTien = @TongTien +  (SELECT TienDien FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
--	SET @TongTien = @TongTien +  (SELECT TienNuoc FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
--	SET @TongTien = @TongTien +  (SELECT TienVeSinh FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
--	SET @TongTien = @TongTien +  (SELECT TienTrangThietBi FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
--	SET @TongTien = @TongTien +  (SELECT TienTaiLieu FROM nxtckedu_Backup.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
	
--END
--GO 