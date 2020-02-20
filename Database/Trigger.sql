USE HeThongSoLienLac
GO	

/*
CREATE TRIGGER Trg_CreateHocSinh
ON dbo.ThongTinHS
FOR INSERT
AS
BEGIN
	DECLARE @ID INT 
	SET @ID = Inserted.ID
    INSERT dbo.HanhKiem
    (
        IDHocSinh,
        Loai,
        HocKy
    )
    VALUES
    (   ,   -- IDHocSinh - int
        N'', -- Loai - nvarchar(20)
        NULL -- HocKy - bit
        )
END
*/
