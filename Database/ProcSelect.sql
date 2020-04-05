ALTER PROCEDURE SelectBangDiem
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.BangDiem
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.BangDiem WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectBHYT
@IDHocSinh INT
AS
BEGIN
    IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.BHYT
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.BHYT WHERE IDHocSinh = @IDHocSinh 	
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
	    SELECT * FROM nxtckedu_sa.DiemDanh
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.DiemDanh WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectKhoi
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.Khoi WHERE ID <> @ID
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.Khoi WHERE ID = @ID AND	ID <> -1
	END
END
GO

ALTER PROCEDURE SelectLienKetPHvsHS
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LienKetPHvsHS
	END
	ELSE 
	BEGIN
		SELECT * FROM nxtckedu_sa.LienKetPHvsHS WHERE IDHocSinh = @IDHocSinh
	END
END
GO

ALTER PROCEDURE SelectLoaiDiem
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiDiem WHERE ID <> -1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiDiem WHERE ID = @ID AND ID <> -1
	END
END
GO 

ALTER PROCEDURE SelectHanhKiem
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiHanhKiem
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiHanhKiem WHERE ID = @ID
	END
END
GO 

ALTER PROCEDURE SelectLoaiHocSinh
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiHocSinh
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiHocSinh WHERE ID = @ID
	END
END
GO 

ALTER PROCEDURE SelectLoaiThongBao
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiThongBao
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiThongBao WHERE ID = @ID
	END
END
GO 

ALTER PROCEDURE SelectLop
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.Lop WHERE ID <> -1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.Lop WHERE ID = @ID AND ID <> -1
	END
END
GO

ALTER PROCEDURE SelectMonhoc
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.MonHoc
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.MonHoc WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectPhanCongDay
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.PhanCongDay
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.PhanCongDay WHERE ID = @ID
	END
END
GO

ALTER PROCEDURE SelectTaiKhoanPH
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE ID <> -1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE ID = @ID AND ID <> -1
	END
END
GO

ALTER PROCEDURE SelectTaiKhoanTruong
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.PhanCongDay
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.PhanCongDay WHERE ID = @ID
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
	    SELECT * FROM nxtckedu_sa.ThoiKhoaBieu WHERE IDLop = @IDLop AND Thu = @Thu
	END
	ELSE
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThoiKhoaBieu WHERE IDLop = @IDLop AND Thu = @Thu AND	Tiet = @Tiet
	END
END
GO

ALTER PROCEDURE SelectThongBaoHS
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoHS WHERE ID = @ID
	END
	
END
GO

ALTER PROCEDURE SelectThongBaoLop
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoLop
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoLop WHERE ID = @ID
	END

END
GO

ALTER PROCEDURE SelectThongBaoTruong
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoTruong
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoTruong WHERE ID = @ID
	END
    
END
GO

ALTER PROCEDURE SelectThongTinHS
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongTinHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongTinHS WHERE ID = @ID
	END
	
END
GO

ALTER PROCEDURE SelectTienHocPhi
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.TienHocPhi
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.TienHocPhi WHERE ID = @ID
	END
    
END
GO	

ALTER PROCEDURE SelectXinPhep
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.XinPhep
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.XinPhep WHERE ID = @ID
	END
    
END
GO