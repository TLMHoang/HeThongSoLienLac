USE HeThongSoLienLac
GO	


CREATE TRIGGER Trg_InsertCupHoc
ON dbo.CupHoc
FOR INSERT
AS
BEGIN
	IF (SELECT COUNT(CupHoc.IDHocSinh)
	FROM dbo.CupHoc
	JOIN Inserted ON Inserted.IDHocSinh = dbo.CupHoc.IDHocSinh AND Inserted.Ngay = dbo.CupHoc.Ngay AND	Inserted.Tiet = dbo.CupHoc.Tiet ) = 2
	BEGIN
	    ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_UpdateCupHoc
ON dbo.CupHoc
FOR UPDATE
AS
BEGIN
	IF ((SELECT Tiet FROM Inserted) > 15)
	BEGIN
	    ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_InsertDiemDanh
ON dbo.DiemDanh
FOR INSERT
AS
BEGIN
	DECLARE @IDHS INT = (SELECT IDHocSinh FROM Inserted)
	DECLARE @Ngay DATE = (SELECT NgayNghi FROM Inserted)
	DECLARE @Phep BIT = (SELECT Phep FROM Inserted)
	IF (SELECT COUNT(dbo.DiemDanh.IDHocSinh)
	FROM dbo.DiemDanh
	JOIN Inserted ON Inserted.IDHocSinh = dbo.DiemDanh.IDHocSinh AND Inserted.NgayNghi = dbo.DiemDanh.NgayNghi AND Inserted.Phep = DiemDanh.Phep) = 2
	BEGIN
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
	    IF (SELECT COUNT(dbo.DiemDanh.IDHocSinh)
		FROM dbo.DiemDanh
		JOIN Inserted ON Inserted.IDHocSinh = dbo.DiemDanh.IDHocSinh AND Inserted.NgayNghi = dbo.DiemDanh.NgayNghi) = 2
		BEGIN
		    UPDATE dbo.DiemDanh SET Phep = @Phep WHERE IDHocSinh = @IDHS AND NgayNghi = @Ngay
			ROLLBACK TRANSACTION
		END
	END
END
GO