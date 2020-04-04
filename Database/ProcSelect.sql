ALTER PROCEDURE SelectBangDiem
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.BangDiem
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.BangDiem WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectBHYT
@IDHocSinh INT
AS
BEGIN
    IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.BHYT
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.BHYT WHERE IDHocSinh = @IDHocSinh 	
	END
END
GO	

ALTER PROCEDURE SelectCupHoc
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END
GO

ALTER PROCEDURE SelectDiemDanh
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.DiemDanh
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.DiemDanh WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectKhoi
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.Khoi
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.Khoi WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectLienKetPHvsHS
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.LienKetPHvsHS
	END
	ELSE 
	BEGIN
		SELECT * FROM nxtckedu_Backup.LienKetPHvsHS WHERE IDHocSinh = @IDHocSinh
	END
END
GO

ALTER PROCEDURE SelectLoaiDiem
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.LoaiDiem
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.LoaiDiem WHERE ID = @ID
	END
END
GO 

ALTER PROCEDURE SelectHanhKiem
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.LoaiHanhKiem
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.LoaiHanhKiem WHERE ID = @ID
	END
END
GO 

ALTER PROCEDURE SelectLoaiHocSinh
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.LoaiHocSinh
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.LoaiHocSinh WHERE ID = @ID
	END
END
GO 

ALTER PROCEDURE SelectLoaiThongBao
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.LoaiThongBao
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.LoaiThongBao WHERE ID = @ID
	END
END
GO 

ALTER PROCEDURE SelectLop
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.Lop WHERE ID <> 0
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.Lop WHERE ID = @ID AND ID <> 0
	END
END
GO

ALTER PROCEDURE SelectMonhoc
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.MonHoc
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.MonHoc WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectPhanCongDay
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.PhanCongDay
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.PhanCongDay WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectTaiKhoanPH
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.TaiKhoanPH WHERE ID <> 0
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.TaiKhoanPH WHERE ID = @ID AND ID <> 0
	END
END
GO

ALTER PROCEDURE SelectTaiKhoanTruong
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.PhanCongDay
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.PhanCongDay WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectThoiKhaoBieu
@IDLop INT,
@Thu INT,
@Tiet INT 
AS
BEGIN
	IF @Tiet = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.ThoiKhoaBieu WHERE IDLop = @IDLop AND Thu = @Thu
	END
	ELSE
	BEGIN
	    SELECT * FROM nxtckedu_Backup.ThoiKhoaBieu WHERE IDLop = @IDLop AND Thu = @Thu AND	Tiet = @Tiet
	END
END
GO

ALTER PROCEDURE SelectThongBaoHS
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.ThongBaoHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.ThongBaoHS WHERE ID = @ID
	END
	
END
GO

ALTER PROCEDURE SelectThongBaoLop
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.ThongBaoLop
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.ThongBaoLop WHERE ID = @ID
	END

END
GO

ALTER PROCEDURE SelectThongBaoTruong
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.ThongBaoTruong
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.ThongBaoTruong WHERE ID = @ID
	END
    
END
GO

ALTER PROCEDURE SelectThongTinHS
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.ThongTinHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.ThongTinHS WHERE ID = @ID
	END
	
END
GO

ALTER PROCEDURE SelectTienHocPhi
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.TienHocPhi
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.TienHocPhi WHERE ID = @ID
	END
    
END
GO	

ALTER PROCEDURE SelectXinPhep
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_Backup.XinPhep
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_Backup.XinPhep WHERE ID = @ID
	END
    
END
GO