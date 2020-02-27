CREATE PROC InsertQuanLyHS
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
	INSERT nxtckedu_USTeam.QuanLyHS
	(
	    IDHocSinh,
	    IDTaiKhoan
	)
	VALUES
	(   @IDHocSinh, -- IDHocSinh - int
	    @IDTaiKhoan  -- IDTaiKhoan - int
	    )
END
GO

CREATE PROC DeleteQuanLyHS
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
	IF	@IDHocSinh = -1
	BEGIN
	    DELETE nxtckedu_USTeam.QuanLyHS WHERE IDTaiKhoan = @IDTaiKhoan
	END
	ELSE
	BEGIN
	    DELETE nxtckedu_USTeam.QuanLyHS WHERE IDHocSinh = @IDHocSinh
	END
END
GO

CREATE PROC SelectQuanLyHS
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
	IF @IDHocSinh = -1 AND @IDTaiKhoan = -1
	BEGIN
		SELECT * FROM nxtckedu_USTeam.QuanLyHS
	END
	ELSE
	BEGIN
	    IF	@IDTaiKhoan = -1
		BEGIN
			SELECT * FROM nxtckedu_USTeam.QuanLyHS WHERE IDHocSinh = @IDHocSinh
		END
		ELSE
		BEGIN
			SELECT * FROM nxtckedu_USTeam.QuanLyHS WHERE IDTaiKhoan = @IDTaiKhoan
		END
	END
END
GO

CREATE PROC UpdateQuanLyHS
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
	UPDATE nxtckedu_USTeam.QuanLyHS
	SET
	IDTaiKhoan = @IDTaiKhoan
	WHERE IDHocSinh = @IDHocSinh
END
GO



SELECT * FROM nxtckedu_USTeam.TaiKhoanTruong JOIN nxtckedu_USTeam.ThongTinGV ON	ThongTinGV.IDTKT = TaiKhoanTruong.ID