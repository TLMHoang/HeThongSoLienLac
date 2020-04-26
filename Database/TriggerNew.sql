ALTER TRIGGER trg_InsertTienHocPhi
ON nxtckedu_sa.TienHocPhi
FOR INSERT
AS
BEGIN
	DECLARE @Thang INT = (SELECT Thang FROM Inserted)
	DECLARE @IDLoaiHocSinh INT = (SELECT IDLoaiHocSinh FROM Inserted)
	DECLARE @IDKhoi INT = (SELECT IDKhoi FROM Inserted)

	IF (SELECT COUNT(ID) FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDKhoi = @IDKhoi AND IDLoaiHocSinh = @IDLoaiHocSinh) = 2
	BEGIN
	    PRINT 'Đã có tháng này rồi không thể thêm'
		ROLLBACK
	END
	ELSE
	BEGIN
		IF @Thang <> MONTH(GETDATE())
		BEGIN
			PRINT 'Không có quyền thêm tháng này vui lòng kiểm tra lại'
			ROLLBACK
		END
		ELSE
		BEGIN
			DECLARE @list TABLE (ID INT)
			DECLARE @TongTien INT = 0
			DECLARE @Loop INT
			
			SET @Thang = @Thang - 1
			DECLARE @TienAn INT = (SELECT TienAn FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			DECLARE @SoNgayHoc INT = (SELECT SoNgayHoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			
			SET @TongTien = @TongTien +  (SELECT TienHoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienDien FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienNuoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienVeSinh FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienTrangThietBi FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienTaiLieu FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)

			INSERT INTO @list
			SELECT ID FROM nxtckedu_sa.ThongTinHS WHERE IDLop IN (SELECT ID FROM nxtckedu_sa.Lop WHERE IDKhoi = @IDKhoi) AND IDLoaiHocSinh = @IDLoaiHocSinh
	
			SET @Loop = (SELECT COUNT(ID) FROM @list)

			WHILE @Loop <> 0
			BEGIN
				DECLARE @IDHS INT = (SELECT MIN(ID) FROM @list)
				DECLARE @SoNgayNghi INT
				EXEC @SoNgayNghi = nxtckedu_sa.GetNgayNghiTrongThang @IDHocSinh = @IDHS, -- int
				                                                     @Phep = 1    -- bit
				UPDATE nxtckedu_sa.ThongTinHS
				SET Tien = Tien - ((@TienAn * (@SoNgayHoc - @SoNgayNghi))+ @TongTien)
				WHERE ID = @IDHS
				DELETE @list WHERE ID = @IDHS
				SET @Loop = @Loop - 1
			END
		END
	END
END
GO

ALTER TRIGGER trg_UpdateTienHocPhi
ON nxtckedu_sa.TienHocPhi
FOR UPDATE
AS
BEGIN
	IF (SELECT COUNT(ID) FROM nxtckedu_sa.TienHocPhi WHERE Thang = (SELECT Inserted.Thang FROM Inserted) AND IDKhoi = (SELECT Inserted.IDKhoi FROM Inserted) AND IDLoaiHocSinh = (SELECT Inserted.IDLoaiHocSinh FROM Inserted)) = 1
	BEGIN
	    IF (SELECT Thang FROM Inserted) <> MONTH(GETDATE())
		BEGIN
			PRINT 'Không có quyền cập nhập tháng này vui lòng kiểm tra lại'
			ROLLBACK
		END
	END
	ELSE
	BEGIN
	    PRINT 'Chưa có tháng này rồi không thể cập nhập'
		ROLLBACK
	END
END
GO

ALTER TRIGGER trg_DeleteTienHocPhi
ON nxtckedu_sa.TienHocPhi
FOR DELETE
AS
BEGIN
	PRINT 'Không thể xóa'
	ROLLBACK
END
GO


ALTER TRIGGER trg_InsertLop
ON nxtckedu_sa.Lop
FOR	INSERT
AS
BEGIN
	IF (SELECT COUNT(TenLop) FROM nxtckedu_sa.Lop WHERE TenLop = (SELECT Inserted.TenLop FROM Inserted) AND IDKhoi = (SELECT Inserted.IDKhoi FROM Inserted)) = 2
	BEGIN
	    PRINT 'Lớp đã có không thể thêm'
		ROLLBACK
	END
	ELSE
	BEGIN
	    DECLARE @Thu INT = 1
		DECLARE @Tiet INT
		WHILE @Thu < 8
		BEGIN
		    SET @Tiet = 1
			WHILE @Tiet < 11
			BEGIN
			    INSERT nxtckedu_sa.ThoiKhoaBieu
			    (
				    IDLop,
			        Thu,
			        Tiet,
			        IDMonHoc
			    )
			    VALUES
			    (   (SELECT Inserted.ID FROM Inserted), -- IDLop - int
			        @Thu, -- Thu - int
			        @Tiet, -- Tiet - int
			        12  -- IDMonHoc - int
			        )
				SET @Tiet = @Tiet + 1
			END
			SET @Thu = @Thu + 1
		END
	END
END
GO


CREATE TRIGGER trg_InsertThongTinHS
ON nxtckedu_sa.ThongTinHS
FOR INSERT
AS
BEGIN
    INSERT nxtckedu_sa.BHYT
    (
        IDHocSinh,
        DangKy,
        BHQD
    )
    VALUES
    (   (SELECT ID FROM Inserted),    -- IDHocSinh - int
        0, -- DangKy - bit
        0  -- BHQD - bit
        )
END