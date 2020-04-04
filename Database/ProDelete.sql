ALTER PROCEDURE DeleteBangDiem
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.BangDiem WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteBHYT
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_Backup.BHYT
    WHERE IDHocSinh = @IDHocSinh
END
GO	

ALTER PROCEDURE DeleteCupHoc
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END
GO

ALTER PROCEDURE DeleteDiemDanh
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.DiemDanh
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteKhoi
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.Khoi
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteLienKetPHvsHS
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_Backup.LienKetPHvsHS
    WHERE IDHocSinh = @IDHocSinh
END
GO

ALTER PROCEDURE DeleteLoaiDiem
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.LoaiDiem
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteHanhKiem
@ID INT
AS
BEGIN
	DELETE nxtckedu_Backup.LoaiHanhKiem
	WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteLoaiHocSinh
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.LoaiHocSinh
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteLoaiThongBao
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.LoaiThongBao
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteLop
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.Lop
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteMonhoc
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.MonHoc
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeletePhanCongDay
@ID INT
AS
BEGIN
	DELETE nxtckedu_Backup.PhanCongDay
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteTaiKhoanPH
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.TaiKhoanPH
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteTaiKhoanTruong
@ID INT
AS
BEGIN
	DELETE nxtckedu_Backup.TaiKhoanTruong
     WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteThoiKhaoBieu
@IDLop INT,
@Thu INT
AS
BEGIN
	DELETE nxtckedu_Backup.ThoiKhoaBieu
	WHERE IDLop = @IDLop AND Thu = @Thu
END
GO

ALTER PROCEDURE DeleteThongBaoHS
@ID INT
AS
BEGIN
	DELETE nxtckedu_Backup.ThongBaoHS
     WHERE ID = @ID
	
END
GO

ALTER PROCEDURE DeleteThongBaoLop
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.ThongBaoLop
     WHERE ID = @ID

END
GO

ALTER PROCEDURE DeleteThongBaoTruong
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.ThongBaoTruong
     WHERE ID = @ID
    
END
GO

ALTER PROCEDURE DeleteThongTinHS
@ID INT
AS
BEGIN
	DELETE nxtckedu_Backup.ThongTinHS
     WHERE ID = @ID
	
END
GO

ALTER PROCEDURE DeleteTienHocPhi
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.TienHocPhi
     WHERE ID = @ID
    
END
GO	

ALTER PROCEDURE DeleteXinPhep
@ID INT
AS
BEGIN
    DELETE nxtckedu_Backup.XinPhep
     WHERE ID = @ID
    
END
GO