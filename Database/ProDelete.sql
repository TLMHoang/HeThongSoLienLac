ALTER PROCEDURE DeleteBangDiem
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.BangDiem WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteBHYT
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_sa.BHYT
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
    DELETE nxtckedu_sa.DiemDanh
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteKhoi
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.Khoi
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteLienKetPHvsHS
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_sa.LienKetPHvsHS
    WHERE IDHocSinh = @IDHocSinh
END
GO

ALTER PROCEDURE DeleteLoaiDiem
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiDiem
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteHanhKiem
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.LoaiHanhKiem
	WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteLoaiHocSinh
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiHocSinh
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteLoaiThongBao
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiThongBao
    WHERE ID = @ID
END
GO 

ALTER PROCEDURE DeleteLop
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.Lop
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteMonhoc
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.MonHoc
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeletePhanCongDay
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.PhanCongDay
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteTaiKhoanPH
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.TaiKhoanPH
    WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteTaiKhoanTruong
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.TaiKhoanTruong
     WHERE ID = @ID
END
GO

ALTER PROCEDURE DeleteThoiKhaoBieu
@IDLop INT,
@Thu INT
AS
BEGIN
	DELETE nxtckedu_sa.ThoiKhoaBieu
	WHERE IDLop = @IDLop AND Thu = @Thu
END
GO

ALTER PROCEDURE DeleteThongBaoHS
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.ThongBaoHS
     WHERE ID = @ID
	
END
GO

ALTER PROCEDURE DeleteThongBaoLop
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.ThongBaoLop
     WHERE ID = @ID

END
GO

ALTER PROCEDURE DeleteThongBaoTruong
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.ThongBaoTruong
     WHERE ID = @ID
    
END
GO

ALTER PROCEDURE DeleteThongTinHS
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.ThongTinHS
     WHERE ID = @ID
	
END
GO

ALTER PROCEDURE DeleteTienHocPhi
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.TienHocPhi
     WHERE ID = @ID
    
END
GO	

ALTER PROCEDURE DeleteXinPhep
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.XinPhep
     WHERE ID = @ID
    
END
GO