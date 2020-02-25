USE [HeThongSoLienLac]
GO

INSERT dbo.TaiKhoanTruong
(
    TaiKhoan,
    MatKhau,
    Loai
)
VALUES
(   'admin',  -- TaiKhoan - varchar(100)
    '21232F297A57A5A743894A0E4A801FC3',  -- MatKhau - varchar(500)
    1 -- Loai - bit
    )