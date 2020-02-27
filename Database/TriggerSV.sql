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
FOR INSERT
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
GO	


CREATE TRIGGER Trg_InsertHanhKiem
ON nxtckedu_USTeam.HanhKiem
FOR INSERT, UPDATE
AS
BEGIN
    IF ((SELECT COUNT(nxtckedu_USTeam.HanhKiem.IDHocSinh) 
	FROM nxtckedu_USTeam.HanhKiem
	JOIN Inserted ON Inserted.IDHocSinh = nxtckedu_USTeam.HanhKiem.IDHocSinh AND Inserted.HocKy = HanhKiem.HocKy) = 2)
	BEGIN
	    PRINT N'Học sinh này đã được giá hạnh kiểm rồi!\nko cần dánh giá lại!'
	    ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_InsertLop
ON nxtckedu_USTeam.Lop
FOR INSERT, UPDATE
AS
BEGIN
    IF ((SELECT COUNT(nxtckedu_USTeam.Lop.TenLop) 
	FROM nxtckedu_USTeam.Lop
	JOIN Inserted ON Inserted.TenLop = Lop.TenLop) = 2)
	BEGIN
	    PRINT N'Lớp đã tồn tại!'
	    ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_DeleteLop
ON nxtckedu_USTeam.Lop
FOR DELETE
AS
BEGIN
	DECLARE @IDLop INT = (SELECT Deleted.ID FROM Deleted)
    DELETE nxtckedu_USTeam.ThongBaoLop WHERE IDLop = @IDLop
	DELETE nxtckedu_USTeam.ThongTinHS WHERE IDLop = @IDLop
	DELETE nxtckedu_USTeam.ThoiKhoaBieu WHERE IDLop = @IDLop
	DELETE nxtckedu_USTeam.PhanCong WHERE IDLop = @IDLop
	DELETE nxtckedu_USTeam.GVCN WHERE IDLop = @IDLop
END
GO

CREATE TRIGGER Trg_InsertMonHoc
ON nxtckedu_USTeam.MonHoc
FOR INSERT, UPDATE
AS
BEGIN
    IF ((SELECT COUNT(nxtckedu_USTeam.MonHoc.TenMon) 
	FROM nxtckedu_USTeam.MonHoc
	JOIN Inserted ON Inserted.TenMon = MonHoc.TenMon) = 2)
	BEGIN
	    PRINT N'Môn học này đã có đã tồn tại!'
	    ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_DeleteMonHoc
ON nxtckedu_USTeam.MonHoc
FOR DELETE
AS
BEGIN
    DECLARE @IDMon INT = (SELECT Deleted.ID FROM Deleted)
	DELETE nxtckedu_USTeam.ThoiKhoaBieu WHERE IDMon = @IDMon
	DELETE nxtckedu_USTeam.PhanCong WHERE IDLop = @IDMon
	DELETE nxtckedu_USTeam.ThongTinGV WHERE IDMonHoc = @IDMon
END
GO

CREATE TRIGGER Trg_InsertPhanCong
ON nxtckedu_USTeam.PhanCong
FOR INSERT, UPDATE
AS
BEGIN
    IF ((SELECT COUNT(nxtckedu_USTeam.PhanCong.IDGiaoVien) 
	FROM nxtckedu_USTeam.PhanCong
	JOIN Inserted ON Inserted.IDLop = PhanCong.IDLop AND Inserted.IDMon = PhanCong.IDMon) = 2)
	BEGIN
		PRINT N'Lớp đã có giáo viên bộ môn này rồi!'
		ROLLBACK TRANSACTION
	END
END
GO

CREATE TRIGGER Trg_InsertTKT
ON nxtckedu_USTeam.TaiKhoanTruong
FOR INSERT
AS
BEGIN
	IF (SELECT COUNT(TaiKhoanTruong.TaiKhoan)
		FROM nxtckedu_USTeam.TaiKhoanTruong
		JOIN Inserted ON Inserted.TaiKhoan = TaiKhoanTruong.TaiKhoan) = 2
	BEGIN
		PRINT N'Tài khoản đã tồn tại không thểm thêm'
	    ROLLBACK TRANSACTION
	END
END
GO	

CREATE TRIGGER Trg_DeleteTKT
ON nxtckedu_USTeam.TaiKhoanTruong
FOR DELETE
AS
BEGIN
	DECLARE @ID INT = (SELECT ID FROM Deleted)
	DELETE nxtckedu_USTeam.ThongTinGV WHERE IDTKT = @ID
	DELETE nxtckedu_USTeam.PhanCong WHERE IDGiaoVien = @ID
	DELETE nxtckedu_USTeam.GVCN WHERE IDGiaoVien = @ID
END
GO	

CREATE TRIGGER Trg_InsertTKPH
ON nxtckedu_USTeam.TaiKhoanPH
FOR INSERT
AS
BEGIN
	IF (SELECT COUNT(nxtckedu_USTeam.TaiKhoanPH.TaiKhoan)
		FROM nxtckedu_USTeam.TaiKhoanPH
		JOIN Inserted ON Inserted.TaiKhoan = nxtckedu_USTeam.TaiKhoanPH.TaiKhoan) = 2
	BEGIN
		PRINT N'Tài khoản đã tồn tại không thểm thêm'
	    ROLLBACK TRANSACTION
	END
END
GO	


CREATE TRIGGER Trg_DeleteTKPH
ON nxtckedu_USTeam.TaiKhoanPH
FOR DELETE
AS
BEGIN
	IF (SELECT COUNT(nxtckedu_USTeam.ThongTinHS.ID) 
	FROM nxtckedu_USTeam.ThongTinHS
	JOIN Deleted ON Deleted.ID = ThongTinHS.IDTaiKhoan) > 0
	BEGIN
		PRINT N'Không thể xóa tài khoản vì tài khoản dang còn quản lý học sinh'
	    ROLLBACK TRANSACTION
	END
END
GO	


CREATE TRIGGER Trg_DeleteTTGV
ON nxtckedu_USTeam.ThongTinGV
FOR DELETE
AS
BEGIN
	PRINT N'Không thể xóa Giáo vien bằng cách này.\nNếu muốn xóa chỉ có thể xóa tài khoản GV'
	ROLLBACK TRANSACTION
END
GO

CREATE TRIGGER Trg_InsertQuanLyHS
ON nxtckedu_USTeam.QuanLyHS
FOR INSERT
AS
BEGIN
	IF ((SELECT COUNT(nxtckedu_USTeam.QuanLyHS.IDHocSinh) 
	FROM nxtckedu_USTeam.QuanLyHS
	JOIN Inserted ON Inserted.IDHocSinh = QuanLyHS.IDHocSinh) = 2)
	BEGIN
		PRINT N'Học sinh đã có quản lý không thể thêm.\nGợi ý: Sửa tài khoản quản lý!'
	    ROLLBACK TRANSACTION
	END
END
GO	


CREATE TRIGGER Trg_InsertThoiKhoaBieu
ON nxtckedu_USTeam.ThoiKhoaBieu
FOR INSERT
AS
BEGIN
    IF ((SELECT COUNT(nxtckedu_USTeam.ThoiKhoaBieu.Tiet) 
	FROM nxtckedu_USTeam.ThoiKhoaBieu
	JOIN Inserted ON Inserted.IDLop = ThoiKhoaBieu.IDLop AND Inserted.IDMon = ThoiKhoaBieu.IDMon AND Inserted.Thu = ThoiKhoaBieu.Thu AND	Inserted.Tiet = ThoiKhoaBieu.Tiet) = 2)
	BEGIN
		PRINT N'Tiết này đã có không thể thêm.\nGợi ý: Sửa thời khoá biểu quản lý!'
		ROLLBACK TRANSACTION
	END
END
GO	