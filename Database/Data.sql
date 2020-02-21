USE [HeThongSoLienLac]
GO
SET IDENTITY_INSERT [dbo].[TaiKhoanTruong] ON 

INSERT [dbo].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 1)
SET IDENTITY_INSERT [dbo].[TaiKhoanTruong] OFF
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([ID], [TenLop]) VALUES (1, N'TEST')
INSERT [dbo].[Lop] ([ID], [TenLop]) VALUES (2, N'TEST1')
INSERT [dbo].[Lop] ([ID], [TenLop]) VALUES (3, N'Test2')
SET IDENTITY_INSERT [dbo].[Lop] OFF
SET IDENTITY_INSERT [dbo].[ThongTinHS] ON 

INSERT [dbo].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDTaiKhoan], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (1, N'A', CAST(N'2020-02-22' AS Date), 1, N'A', N'A', N'A', 1, NULL, N'me', N'0123456789', N'cha', N'9876543210')
INSERT [dbo].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDTaiKhoan], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (2, N'B', CAST(N'2020-02-22' AS Date), 1, N'A', N'A', N'A', 2, NULL, N'me', N'0123456789', N'cha', N'9876543210')
INSERT [dbo].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDTaiKhoan], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (3, N'c', CAST(N'2020-02-22' AS Date), 1, N'A', N'A', N'A', 3, NULL, N'me', N'0123456789', N'cha', N'9876543210')
SET IDENTITY_INSERT [dbo].[ThongTinHS] OFF
