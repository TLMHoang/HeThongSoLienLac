CREATE TRIGGER trg_InsertTienHocPhi
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

CREATE TRIGGER trg_UpdateTienHocPhi
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

CREATE TRIGGER trg_DeleteTienHocPhi
ON nxtckedu_sa.TienHocPhi
FOR DELETE
AS
BEGIN
	PRINT 'Không thể xóa'
	ROLLBACK
END
GO


CREATE TRIGGER trg_InsertLop
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
GO	

ALTER TRIGGER trg_InsertDiem
ON nxtckedu_sa.BangDiem
FOR INSERT,UPDATE
AS
BEGIN
	IF ((SELECT Inserted.CotDiem FROM Inserted) > (SELECT TongCot FROM nxtckedu_sa.LoaiDiem WHERE ID = (SELECT Inserted.IDLoaiDiem FROM Inserted)))
	BEGIN
	    PRINT N'Vượt quá giới hạn số cột của loai điểm'
		ROLLBACK
	END
	DECLARE @Diem INT = (SELECT Inserted.Diem FROM Inserted)
    IF (@Diem <0.0 AND @Diem > 10.0)
	BEGIN
	    PRINT N'Nhập diểm nhỏ hơn 0 học 10 khôn được'
		ROLLBACK
	END
	ELSE
	BEGIN
	    IF((SELECT COUNT(*) FROM nxtckedu_sa.BangDiem 
		WHERE IDHocSinh = (SELECT Inserted.IDHocSinh FROM Inserted) 
		AND IDMonHoc = (SELECT Inserted.IDMonHoc FROM Inserted)
		AND CotDiem = (SELECT Inserted.CotDiem FROM Inserted)) = 2)
		BEGIN
		    PRINT N'Đã có cột này không thể thêm, chỉ có thể sửa'
			ROLLBACK
		END
		ELSE
		BEGIN
		    DECLARE @IDHocSinh INT = (SELECT Inserted.IDHocSinh FROM Inserted)
			DECLARE @IDMonHoc INT = (SELECT Inserted.IDMonHoc FROM Inserted)
			DECLARE @HKI BIT = (SELECT Inserted.HocKyI FROM Inserted)
			DECLARE @IDLop INT = (SELECT IDLop FROM nxtckedu_sa.ThongTinHS WHERE ID = @IDHocSinh)
			DECLARE @Count INT = 0
			DECLARE @Loop INT
			DECLARE @Point FLOAT = 0.0
			DECLARE @TablePoint TABLE(IDLoaiDiem INT, HocKyI BIT, Diem FLOAT, HeSo INT)

			INSERT INTO @TablePoint
			SELECT D.IDLoaiDiem,
                   D.HocKyI,
                   D.Diem,
                   L.HeSo FROM nxtckedu_sa.BangDiem AS D
			JOIN nxtckedu_sa.LoaiDiem AS L
			ON L.ID = D.IDLoaiDiem
			WHERE D.IDHocSinh = @IDHocSinh AND D.IDMonHoc = @IDMonHoc

			DECLARE @P FLOAT = (SELECT SUM(Diem * HeSo) FROM @TablePoint WHERE HocKyI = @HKI)
			DECLARE @C INT = (SELECT SUM(HeSo) FROM @TablePoint WHERE  HocKyI = @HKI)
			IF @P <> 0
				BEGIN
				    SET @Point = @Point + @P
				END
			IF @C <> 0
				BEGIN
				    SET @Count = @Count + @C
				END
			
			-- Input AGV to Table DTBMon
			IF ((SELECT COUNT(*) FROM nxtckedu_sa.DTBMon 
			WHERE IDHocSinh = @IDHocSinh
			AND IDMon = @IDMonHoc
			AND IDLop = @IDLop) = 1)
			BEGIN
				IF(@HKI = 1)
			    BEGIN
			        UPDATE nxtckedu_sa.DTBMon 
					SET HKI = @Point / @Count
					WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop
			    END 
				ELSE
				BEGIN
			        UPDATE nxtckedu_sa.DTBMon 
					SET HKII = @Point / @Count
					WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop
				END
			END
			ELSE
			BEGIN
				IF(@HKI = 1)
				BEGIN
				    INSERT nxtckedu_sa.DTBMon
					(
						IDHocSinh,
						IDMon,
						IDLop,
						HKI,
						HKII,
						CaNam
					)
					VALUES
				    (   @IDHocSinh,   -- IDHocSinh - int
					    @IDMonHoc,   -- IDMon - int
				        @IDLop,  
					    @Point / @Count, -- HKI - float
					    0.0, -- HKII - float
					    0.0  -- CaNam - float
					    )
				END
				ELSE
				BEGIN
				    INSERT nxtckedu_sa.DTBMon
					(
						IDHocSinh,
						IDMon,
						IDLop,
						HKI,
						HKII,
						CaNam
					)
					VALUES
				    (   @IDHocSinh,   -- IDHocSinh - int
					    @IDMonHoc,   -- IDMon - int
				        @IDLop,  
					    0.0, -- HKI - float
					    @Point / @Count, -- HKII - float
					    0.0  -- CaNam - float
					    )
				END
			END

			UPDATE nxtckedu_sa.DTBMon 
					SET CaNam = ((SELECT HKI FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop) + (SELECT HKII FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop) * 2) / 3
					WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop

			--Get count Subject
			SET @Count = (SELECT COUNT(*) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop)

			-- Sum Point AGV
			IF((SELECT COUNT(*) FROM nxtckedu_sa.DTBTong 
			WHERE IDHocSinh = @IDHocSinh
			AND IDLop = @IDLop) = 1)
			BEGIN
			    UPDATE nxtckedu_sa.DTBTong 
				SET HKI = (SELECT SUM(HKI) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count,
				HKII = (SELECT SUM(HKII) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count,
				CaNam = (SELECT SUM(CaNam) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count
				WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop
			END
			ELSE
			BEGIN
			    INSERT nxtckedu_sa.DTBTong
			    (
			        IDHocSinh,
			        IDLop,
			        HKI,
			        HKII,
			        CaNam
			    )
			    VALUES
			    (   @IDHocSinh,   -- IDHocSinh - int
			        @IDLop,  
			        (SELECT SUM(HKI) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count, -- HKI - float
			        (SELECT SUM(HKII) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count, -- HKII - float
			        (SELECT SUM(CaNam) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count  -- CaNam - float
			        )
			END
			
		END
	END
END
GO	

