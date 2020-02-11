USE HeThongSoLienLac
GO

INSERT dbo.TaiKhoanTruong
(
    TaiKhoan,
    MatKhau,
    Loai
)
VALUES
(   'admin',  -- TKhoan - varchar(100)
    '21232F297A57A5A743894A0E4A801FC3',  -- MatKhau - varchar(200)
    1 -- Loai - bit
    )
	GO