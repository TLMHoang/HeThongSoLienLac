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