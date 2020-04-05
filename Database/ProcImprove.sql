CREATE PROCEDURE SelectThongTinGV
@IDLop INT
AS
BEGIN
	SELECT A.TenGV, C.TenMon, A.SDT, A.IDLop 
	FROM nxtckedu_sa.TaiKhoanTruong AS A
	JOIN nxtckedu_sa.PhanCongDay AS B
	ON B.IDGiaoVien = A.ID
	JOIN nxtckedu_sa.MonHoc AS C
	ON C.ID = A.IDMonHoc
	WHERE B.IDLop = @IDLop
END
GO
