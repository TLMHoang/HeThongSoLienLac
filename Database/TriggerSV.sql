USE nxtckedu_SoLienLac
GO	

CREATE TRIGGER Trg_InsertCupHoc
ON nxtckedu_USTeam.CupHoc
FOR INSERT
AS
BEGIN
	IF (SELECT COUNT(CupHoc.IDHocSinh)
	FROM nxtckedu_USTeam.CupHoc
	JOIN Inserted ON Inserted.IDHocSinh = nxtckedu_USTeam.CupHoc.IDHocSinh AND Inserted.Ngay = nxtckedu_USTeam.CupHoc.Ngay AND	Inserted.Tiet = nxtckedu_USTeam.CupHoc.Tiet ) = 2
	BEGIN
		PRINT N'Đã ghi nhận học sinh cúp học trong tiết này rồi không cần lặp lại'
	    ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_UpdateCupHoc
ON nxtckedu_USTeam.CupHoc
FOR UPDATE
AS
BEGIN
	IF ((SELECT Tiet FROM Inserted) > 15)
	BEGIN
		PRINT N'Số tiết không thể quá 15'
	    ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_InsertDiemDanh
ON nxtckedu_USTeam.DiemDanh
FOR INSERT
AS
BEGIN
	DECLARE @IDHS INT = (SELECT IDHocSinh FROM Inserted)
	DECLARE @Ngay DATE = (SELECT NgayNghi FROM Inserted)
	DECLARE @Phep BIT = (SELECT Phep FROM Inserted)
	IF (SELECT COUNT(nxtckedu_USTeam.DiemDanh.IDHocSinh)
	FROM nxtckedu_USTeam.DiemDanh
	JOIN Inserted ON Inserted.IDHocSinh = nxtckedu_USTeam.DiemDanh.IDHocSinh AND Inserted.NgayNghi = nxtckedu_USTeam.DiemDanh.NgayNghi AND Inserted.Phep = DiemDanh.Phep) = 2
	BEGIN
		PRINT N'Đã ghi nhận học sinh vắng học rồi không cần lặp lại'
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
	    IF (SELECT COUNT(nxtckedu_USTeam.DiemDanh.IDHocSinh)
		FROM nxtckedu_USTeam.DiemDanh
		JOIN Inserted ON Inserted.IDHocSinh = nxtckedu_USTeam.DiemDanh.IDHocSinh AND Inserted.NgayNghi = nxtckedu_USTeam.DiemDanh.NgayNghi) = 2
		BEGIN
		    UPDATE nxtckedu_USTeam.DiemDanh SET Phep = @Phep WHERE IDHocSinh = @IDHS AND NgayNghi = @Ngay
			PRINT N'Đã cập nhập lại thông tin'
			ROLLBACK TRANSACTION
		END
	END
END
GO

CREATE TRIGGER Trg_InsertGVCN
ON nxtckedu_USTeam.GVCN
FOR INSERT, UPDATE
AS
BEGIN
	IF ((SELECT COUNT(nxtckedu_USTeam.GVCN.IDLop) 
	FROM nxtckedu_USTeam.GVCN
	JOIN Inserted ON Inserted.IDGiaoVien = GVCN.IDGiaoVien) = 2)
	BEGIN
		PRINT N'Lớp đã giáo viên chủ nhiệm!'
	    ROLLBACK TRANSACTION
	END
    IF ((SELECT COUNT(GVCN.IDLop) 
	FROM nxtckedu_USTeam.GVCN
	JOIN Inserted ON Inserted.IDLop = GVCN.IDLop) = 2)
	BEGIN
		PRINT N'Giáo viên là chủ nhiệm không thể thêm làm giáo viên chủ nhiệm nữa!'
	    ROLLBACK TRANSACTION
	END
END