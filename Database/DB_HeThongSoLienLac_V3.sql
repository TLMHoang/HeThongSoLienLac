USE [master]
GO
/****** Object:  Database [nxtckedu_HeThongSoLienLac]    Script Date: 10/05/2020 8:23:36 AM ******/
CREATE DATABASE [nxtckedu_HeThongSoLienLac]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nxtckedu_HeThongSoLienLac', FILENAME = N'D:\Plesk\Databases\MSSQL\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\nxtckedu_HeThongSoLienLac.mdf' , SIZE = 4288KB , MAXSIZE = 307200KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'nxtckedu_HeThongSoLienLac_log', FILENAME = N'D:\Plesk\Databases\MSSQL\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\nxtckedu_HeThongSoLienLac_log.ldf' , SIZE = 1024KB , MAXSIZE = 204800KB , FILEGROWTH = 10%)
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nxtckedu_HeThongSoLienLac].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET ARITHABORT OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET  ENABLE_BROKER 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET  MULTI_USER 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET DELAYED_DURABILITY = DISABLED 
GO
USE [nxtckedu_HeThongSoLienLac]
GO
/****** Object:  User [nxtckedu_sa]    Script Date: 10/05/2020 8:23:36 AM ******/
CREATE USER [nxtckedu_sa] FOR LOGIN [nxtckedu_sa] WITH DEFAULT_SCHEMA=[nxtckedu_sa]
GO
ALTER ROLE [db_owner] ADD MEMBER [nxtckedu_sa]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [nxtckedu_sa]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [nxtckedu_sa]
GO
ALTER ROLE [db_datareader] ADD MEMBER [nxtckedu_sa]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [nxtckedu_sa]
GO
/****** Object:  Schema [nxtckedu_sa]    Script Date: 10/05/2020 8:23:36 AM ******/
CREATE SCHEMA [nxtckedu_sa]
GO
/****** Object:  Table [nxtckedu_sa].[BangDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[BangDiem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHocSinh] [int] NULL,
	[IDMonHoc] [int] NULL,
	[IDLoaiDiem] [int] NULL,
	[Diem] [float] NULL,
	[HocKyI] [bit] NULL DEFAULT ((1)),
	[CotDiem] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[BHYT]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[BHYT](
	[IDHocSinh] [int] NOT NULL,
	[DangKy] [bit] NULL DEFAULT ((0)),
	[BHQD] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[IDHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[CupHoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[CupHoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHocSinh] [int] NULL,
	[Ngay] [date] NULL,
	[Tiet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[DiemDanh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[DiemDanh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHocSinh] [int] NULL,
	[NgayNghi] [date] NULL,
	[Phep] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[FunctionOrder]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[FunctionOrder](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NameFunc] [nvarchar](200) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[Khoi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[Khoi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoi] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[LienKetPHvsHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[LienKetPHvsHS](
	[IDHocSinh] [int] NOT NULL,
	[IDTaiKhoan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[LoaiDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[LoaiDiem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiDiem] [nvarchar](50) NULL,
	[HeSo] [int] NULL,
	[TongCot] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[LoaiHanhKiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[LoaiHanhKiem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHanhKiem] [nvarchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[LoaiHocSinh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[LoaiHocSinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[LoaiThongBao]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[LoaiThongBao](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenThongBao] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[Lop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[Lop](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKhoi] [int] NULL,
	[TenLop] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[MonHoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[MonHoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](200) NULL,
	[LoaiDiem] [bit] NULL DEFAULT ((1)),
	[CoDiem] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[PhanCongDay]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[PhanCongDay](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDGiaoVien] [int] NULL,
	[IDLop] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[TaiKhoanPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [nxtckedu_sa].[TaiKhoanPH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [varchar](100) NULL,
	[MatKhau] [varchar](500) NULL,
	[TenMe] [nvarchar](150) NULL,
	[SDTMe] [varchar](12) NULL,
	[TenBo] [nvarchar](150) NULL,
	[SDTBo] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [nxtckedu_sa].[TaiKhoanTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [nxtckedu_sa].[TaiKhoanTruong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [varchar](100) NULL,
	[MatKhau] [varchar](500) NULL,
	[Loai] [bit] NULL DEFAULT ((0)),
	[TenGV] [nvarchar](200) NULL,
	[SDT] [varchar](12) NULL,
	[IDMonHoc] [int] NULL,
	[IDLop] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [nxtckedu_sa].[ThoiKhoaBieu]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[ThoiKhoaBieu](
	[IDLop] [int] NULL,
	[Thu] [int] NULL,
	[Tiet] [int] NULL,
	[IDMonHoc] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[ThongBaoHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[ThongBaoHS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHocSinh] [int] NULL,
	[NoiDung] [nvarchar](max) NULL,
	[Ngay] [date] NULL,
	[IDLoaiThongBao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[ThongBaoLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[ThongBaoLop](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDLop] [int] NULL,
	[NoiDung] [nvarchar](max) NULL,
	[Ngay] [date] NULL,
	[IDLoaiThongBao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[ThongBaoTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[ThongBaoTruong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[Ngay] [date] NULL,
	[IDLoaiThongBao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[ThongTinHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[ThongTinHS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](200) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[NoiSinh] [nvarchar](250) NULL,
	[DanToc] [nvarchar](100) NULL,
	[TonGiao] [nvarchar](100) NULL,
	[IDLop] [int] NULL,
	[IDLoaiHocSinh] [int] NULL,
	[HKI] [int] NULL,
	[HKII] [int] NULL,
	[CaNam] [int] NULL,
	[Tien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[TienHocPhi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[TienHocPhi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [int] NULL,
	[IDLoaiHocSinh] [int] NULL,
	[IDKhoi] [int] NULL,
	[SoNgayHoc] [int] NULL,
	[TienHoc] [int] NULL,
	[TienAn] [int] NULL,
	[TienDien] [int] NULL,
	[TienNuoc] [int] NULL,
	[TienVeSinh] [int] NULL,
	[TienTrangThietBi] [int] NULL,
	[TienTaiLieu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[XinPhep]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[XinPhep](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHocSinh] [int] NULL,
	[NghiTu] [date] NULL,
	[NghiDen] [date] NULL,
	[TrangThai] [bit] NULL DEFAULT ((0)),
	[ChoHuy] [bit] NULL DEFAULT ((0)),
	[LyDo] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [nxtckedu_sa].[BangDiem] ON 

INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (1, 1, 1, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (2, 1, 1, 2, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (3, 1, 1, 3, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (4, 1, 1, 4, 3.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (5, 1, 1, 1, 6.75, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (6, 1, 1, 2, 6.5, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (7, 1, 1, 3, 7, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (8, 1, 1, 4, 4.75, 0, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (9, 2, 1, 1, 6.75, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (10, 2, 1, 2, 6.25, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (11, 2, 1, 3, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (12, 2, 1, 4, 8.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (13, 2, 1, 1, 6.75, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (14, 2, 1, 2, 7.5, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (135, 15, 1, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (136, 28, 1, 1, 9.25, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (137, 29, 1, 1, 5.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (138, 30, 1, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (139, 31, 1, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (140, 32, 1, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (141, 33, 1, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (142, 15, 1, 1, 7, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (143, 1, 4, 1, 6.25, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (144, 2, 4, 1, 7.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (145, 3, 4, 1, 9.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (146, 6, 4, 1, 1, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (147, 7, 4, 1, 1, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (148, 233, 4, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (149, 1, 4, 1, 6.5, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (150, 2, 4, 1, 1.25, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (151, 3, 4, 1, 1.5, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (152, 6, 4, 1, 10, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (153, 7, 4, 1, 8, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (154, 3, 1, 1, 3.5, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (155, 1, 1, 1, 9.5, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (156, 1, 1, 1, 2.75, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (157, 1, 1, 1, 6.25, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (158, 1, 1, 2, 3, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (159, 1, 1, 3, 9, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (160, 3, 1, 4, 8, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (161, 1, 1, 3, 7, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (162, 7, 1, 1, 6.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (163, 1, 1, 1, 7, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (164, 2, 1, 1, 8, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (165, 15, 1, 2, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (166, 28, 1, 2, 5.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (167, 29, 1, 2, 4.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (168, 30, 1, 2, 8.75, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (169, 3, 1, 1, 8, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (170, 28, 1, 1, 10, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (171, 97, 1, 1, 7.75, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (172, 98, 1, 1, 3.5, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (175, 97, 1, 1, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (176, 29, 1, 1, 6.5, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (177, 15, 14, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (178, 28, 14, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (179, 29, 14, 1, 9.25, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (180, 1, 8, 1, 5.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (181, 2, 8, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (182, 98, 1, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (183, 99, 1, 1, 6.25, 1, 1)
SET IDENTITY_INSERT [nxtckedu_sa].[BangDiem] OFF
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (1, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (2, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (3, 1, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (6, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (7, 0, 1)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (8, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (11, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (12, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (15, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (28, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (29, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (30, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (31, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (32, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (33, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (97, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (98, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (99, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (100, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (101, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (102, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (103, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (104, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (105, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (106, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (155, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (156, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (157, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (233, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (235, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (236, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (237, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (238, 0, 0)
SET IDENTITY_INSERT [nxtckedu_sa].[DiemDanh] ON 

INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (22, 1, CAST(N'2020-04-07' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (23, 6, CAST(N'2020-04-07' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (24, 1, CAST(N'2020-04-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (25, 11, CAST(N'2020-04-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (26, 2, CAST(N'2020-04-08' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (27, 3, CAST(N'2020-04-10' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (28, 11, CAST(N'2020-04-10' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (30, 1, CAST(N'2020-04-10' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (31, 31, CAST(N'2020-04-10' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (32, 31, CAST(N'2020-04-11' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (33, 7, CAST(N'2020-04-11' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (34, 30, CAST(N'2020-04-11' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (35, 30, CAST(N'2020-04-13' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (36, 1, CAST(N'2020-04-13' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (37, 1, CAST(N'2020-04-12' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (38, 3, CAST(N'2020-04-13' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (40, 3, CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (41, 32, CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (42, 33, CAST(N'2020-04-14' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (44, 99, CAST(N'2020-04-16' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (45, 31, CAST(N'2020-04-16' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (47, 32, CAST(N'2020-04-16' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (48, 33, CAST(N'2020-04-16' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (49, 155, CAST(N'2020-04-16' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (51, 30, CAST(N'2020-04-16' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (52, 106, CAST(N'2020-04-16' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (54, 29, CAST(N'2020-04-16' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (55, 15, CAST(N'2020-04-16' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (56, 3, CAST(N'2020-01-02' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (57, 233, CAST(N'2020-05-08' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (58, 233, CAST(N'2020-05-08' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (59, 1, CAST(N'2020-05-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (60, 1, CAST(N'2020-05-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (61, 1, CAST(N'2020-05-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (62, 106, CAST(N'2020-05-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (63, 235, CAST(N'2020-05-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (64, 236, CAST(N'2020-05-08' AS Date), 0)
SET IDENTITY_INSERT [nxtckedu_sa].[DiemDanh] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[FunctionOrder] ON 

INSERT [nxtckedu_sa].[FunctionOrder] ([ID], [NameFunc], [StartDate], [EndDate]) VALUES (1, N'BHYT', CAST(N'2020-04-23' AS Date), CAST(N'2020-05-05' AS Date))
SET IDENTITY_INSERT [nxtckedu_sa].[FunctionOrder] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[Khoi] ON 

INSERT [nxtckedu_sa].[Khoi] ([ID], [TenKhoi]) VALUES (-1, N'null')
INSERT [nxtckedu_sa].[Khoi] ([ID], [TenKhoi]) VALUES (1, N'10')
INSERT [nxtckedu_sa].[Khoi] ([ID], [TenKhoi]) VALUES (2, N'11')
INSERT [nxtckedu_sa].[Khoi] ([ID], [TenKhoi]) VALUES (3, N'12')
SET IDENTITY_INSERT [nxtckedu_sa].[Khoi] OFF
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (1, 3)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (2, 4)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (3, 3)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (6, 4)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (7, 12)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (97, 4)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (98, 3)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (101, 12)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (102, 5)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (106, 21)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (233, 5)
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiDiem] ON 

INSERT [nxtckedu_sa].[LoaiDiem] ([ID], [TenLoaiDiem], [HeSo], [TongCot]) VALUES (-1, N'null', NULL, NULL)
INSERT [nxtckedu_sa].[LoaiDiem] ([ID], [TenLoaiDiem], [HeSo], [TongCot]) VALUES (1, N'Miệng', 1, 5)
INSERT [nxtckedu_sa].[LoaiDiem] ([ID], [TenLoaiDiem], [HeSo], [TongCot]) VALUES (2, N'15p', 1, 5)
INSERT [nxtckedu_sa].[LoaiDiem] ([ID], [TenLoaiDiem], [HeSo], [TongCot]) VALUES (3, N'1 Tiết', 2, 5)
INSERT [nxtckedu_sa].[LoaiDiem] ([ID], [TenLoaiDiem], [HeSo], [TongCot]) VALUES (4, N'Học kỳ', 3, 1)
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiDiem] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiHanhKiem] ON 

INSERT [nxtckedu_sa].[LoaiHanhKiem] ([ID], [TenHanhKiem]) VALUES (1, N'Xuất sắc')
INSERT [nxtckedu_sa].[LoaiHanhKiem] ([ID], [TenHanhKiem]) VALUES (2, N'Giỏi')
INSERT [nxtckedu_sa].[LoaiHanhKiem] ([ID], [TenHanhKiem]) VALUES (3, N'Khá')
INSERT [nxtckedu_sa].[LoaiHanhKiem] ([ID], [TenHanhKiem]) VALUES (4, N'Trung Bình')
INSERT [nxtckedu_sa].[LoaiHanhKiem] ([ID], [TenHanhKiem]) VALUES (5, N'Yếu')
INSERT [nxtckedu_sa].[LoaiHanhKiem] ([ID], [TenHanhKiem]) VALUES (6, N'Kém')
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiHanhKiem] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiHocSinh] ON 

INSERT [nxtckedu_sa].[LoaiHocSinh] ([ID], [TenLoai]) VALUES (1, N'Nội chú')
INSERT [nxtckedu_sa].[LoaiHocSinh] ([ID], [TenLoai]) VALUES (2, N'Bán chú')
INSERT [nxtckedu_sa].[LoaiHocSinh] ([ID], [TenLoai]) VALUES (3, N'Ngoại chú')
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiHocSinh] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiThongBao] ON 

INSERT [nxtckedu_sa].[LoaiThongBao] ([ID], [TenThongBao]) VALUES (1, N'Tin mới')
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiThongBao] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[Lop] ON 

INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (-1, 1, N'Null')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (31, 1, N'C1')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (32, 1, N'C2')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (33, 1, N'C3')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (34, 2, N'B1')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (35, 2, N'B2')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (36, 2, N'B3')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (37, 3, N'A1')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (38, 3, N'A2')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (39, 3, N'A3')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (40, 2, N'B4')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (41, 1, N'C4')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (42, 1, N'C5')
SET IDENTITY_INSERT [nxtckedu_sa].[Lop] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[MonHoc] ON 

INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (-1, N'null', 1, 0)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (1, N'Toán', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (2, N'Vật Lý', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (3, N'Hóa Học', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (4, N'Sinh Học', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (5, N'Ngữ Văn', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (6, N'Lịch Sử', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (7, N'Địa Lý', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (8, N'Anh Văn', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (9, N'GDCD', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (10, N'Tin Học', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (11, N'Thể Dục', 0, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (12, N'Trống', 0, 0)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (14, N'Công Nghệ', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (15, N'Kỹ Năng Sống', 0, 0)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (18, N'Giáo Dục Giới Tính', 0, NULL)
SET IDENTITY_INSERT [nxtckedu_sa].[MonHoc] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[PhanCongDay] ON 

INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (5, 6, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (6, 6, 33)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (7, 11, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (8, 11, 33)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (9, 11, 34)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (10, 6, 34)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (11, 2, 35)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (13, 6, 37)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (14, 6, 38)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (15, 7, -1)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (16, 4, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (44, 12, 34)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (47, 12, 36)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (48, 2, 36)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (50, 7, 40)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (51, 4, 40)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (52, 13, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (54, 12, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (55, 4, 36)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (56, 6, 32)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (57, 13, 32)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (58, 12, 32)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (60, 2, 39)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (61, 13, 39)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (62, 4, 39)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (63, 14, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (64, 15, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (65, 1, 31)
SET IDENTITY_INSERT [nxtckedu_sa].[PhanCongDay] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[TaiKhoanPH] ON 

INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (3, N'admin', N'0CC175B9C0F1B6A831C399E269772661', N'Admin Mẹ', N'0123456789', N'Admin Bố 1', N'0123456789')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (4, N'truong', N'A9A517C33EDF315102B732876FEB1155', N'Dao', N'0215555585', N'Hung', N'5566666998')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (5, N'phong', N'9F48495BB4B98AC37A1A72C7E6490C7A', N'phong', N'123456789', N'phong 2', N'123568796')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (10, N'0369875622', N'81463320059598E04C15444789DF57C5', N'Ly', N'0236985745', N'Sơn', N'0325664448')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (12, N'0352908667', N'AC151FCF77E229ADE20B67973CB54062', N'Json Mẹ', N'0123456789', N'Ajax Bố', N'0123456789')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (16, N'0368951561', N'243DAAAE888617674B8DB7E2D3AF61AF', N'Lan', N'0216541655', N'Hùng', N'0466165651')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (17, N'0396874632', N'B03C56EBEB1F4460568AB50CC41FB020', N'Trúc ', N'6561565615', N'Thái', N'0325656115')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (18, N'0398741235', N'4BB3E0093B40E8A9CBA9B3CE9BC67EDF', N'Mai', N'0156654165', N'Hưng', N'0254868446')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (19, N'0398564123', N'5D626D90B07A0B5C4186176558EB01A6', N'Phương', N'0121851516', N'Đạt', N'0698225166')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (20, N'0398745612', N'2109F46E2730E712390C0DEB4A933B0F', N'Hồ Cao Trang', N'0569816166', N'Nguyễn Trần Phang', N'0651661156')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (21, N'0396874563', N'639B7C483B2F618CC15783BD44174CD3', N'Hương', N'0358316516', N'Mai Văn Hoang', N'0516186681')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (22, N'an', N'18B049CC8D8535787929DF716F9F4E68', N'an', N'0236985745', N'an', N'0466165651')
SET IDENTITY_INSERT [nxtckedu_sa].[TaiKhoanPH] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[TaiKhoanTruong] ON 

INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 1, N'admin', N'123456789', 8, 35)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (2, N'gv001', N'213EF674A59C115A7B41BC50044AB2E1', 0, N'gv day toan', N'987654321', 1, 41)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (4, N'gv003', N'E6658BB23E0779F02A1B399731B725FB', 0, N'GV Hóa', N'5745648789', 3, 39)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (6, N'phong', N'9F48495BB4B98AC37A1A72C7E6490C7A', 0, N'phong', N'0123564896', 1, 36)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (7, N'a', N'0CC175B9C0F1B6A831C399E269772661', 1, N'a', N'0123456789', 1, 32)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (11, N'an', N'9F48495BB4B98AC37A1A72C7E6490C7A', 0, N'an', N'0123456789', 14, 31)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (12, N'gvkynangsong', N'9DF1F90D219A7A73FA2584F763CCE33A', 0, N'Cao Thành Phát', N'0369856214', 15, 34)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (13, N'gv007', N'FC669D4007CE2A8F8C667E6A97437F02', 0, N'Nguyễn Thành Khang GV Lý', N'0369852147', 2, 40)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (14, N'gv009', N'ABFFBFB6FF035C878F92E32E3F4F8B2A', 0, N'Gv dạy giáo dục gt', N'0352908667', 18, 33)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (15, N'truong', N'047C30E8313DB6E45FD87AB6E1BFD1FB', 0, N'Trần Trường', N'034603', 4, 37)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (16, N'nhung', N'40B340B06A104930D9C4164578BF4D79', 0, N'Nhung', N'0987678965', 8, -1)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (17, N'gv020', N'3D8531EFAF89D14C744F96FACF30303B', 0, N'GV Dạy Địa', N'0122555554', 7, -1)
SET IDENTITY_INSERT [nxtckedu_sa].[TaiKhoanTruong] OFF
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 1, 1)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 2, 2)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 3, 9)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 4, 1)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 5, 1)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 6, 3)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 10, 8)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 3, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (32, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 6, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (33, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 2, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (35, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 5, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (36, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (37, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 1, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (38, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 4, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (39, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (40, 7, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (41, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 3, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (42, 7, 10, 12)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoHS] ON 

INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (1, 11, N'365', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (2, 6, N'Ngày Mai mời Phụ Huynh', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (3, 11, N'Hello 123
', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (4, 6, N'Morning 123', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (5, 15, N'Em Được nghỉ ngày mai', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (7, 3, N'Họp Phụ Huynh lân 2', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (8, 33, N'123', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (9, 6, N'Em Được Học Bổng ', CAST(N'2020-04-13' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (10, 2, N'Ngày mốt họp phụ huynh nha em', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (11, 32, N'12334', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (12, 15, N'123456', CAST(N'2020-04-15' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (13, 102, N'0908780988 gọi vào số này', CAST(N'2020-04-15' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (14, 156, N'Hop phụ huynh tháng 6', CAST(N'2020-04-15' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (16, 7, N'123', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (17, 1, N'369', CAST(N'2020-04-22' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (19, 235, N'321', CAST(N'2020-04-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (20, 236, N'hello
', CAST(N'2020-04-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (21, 235, N'36912336', CAST(N'2020-04-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (23, 238, N'14555', CAST(N'2020-04-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (24, 106, N'không cần đi học', CAST(N'2020-05-07' AS Date), 1)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoHS] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoLop] ON 

INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (18, 38, N'Các Em Đi Học Lại Vào Tháng 6', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (19, 31, N'Thông Báo Từ Nhà Trường : Săp hết hạn đăng kí BHYT ', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (20, 31, N'123', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (23, 36, N'1237', CAST(N'2020-04-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (25, 31, N'Tháng 6 Được Nghỉ Cả Tháng', CAST(N'2020-05-03' AS Date), 1)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoLop] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoTruong] ON 

INSERT [nxtckedu_sa].[ThongBaoTruong] ([ID], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (1, N'Toàn Trường Được Nghỉ Học', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoTruong] ([ID], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (2, N'Các Bạn Được Nghỉ Dịch Covid Đến Hết Tháng 6', CAST(N'2020-04-15' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoTruong] ([ID], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (6, N'@ko biết ghi gì nữa ', CAST(N'2020-04-15' AS Date), 1)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoTruong] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[ThongTinHS] ON 

INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (1, N'Phong', CAST(N'2000-06-01' AS Date), 1, N'tp hcm', N'kinh', N'Không', 31, 1, 1, 3, 2, 3400)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (2, N'Trường', CAST(N'2000-03-02' AS Date), 1, N'tp hcm', N'kinh', N'khong', 31, 1, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (3, N'Minh Hoàng', CAST(N'1999-06-09' AS Date), 1, N'tp hcm', N'kinh', N'khong', 31, 1, 1, 2, 3, 0)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (6, N'Phan Việt Hoàng', CAST(N'1999-01-08' AS Date), 1, N'TpHCM', N'Kinh', N'Thien Chua Giao', 31, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (7, N'Nguyễn Thị Tú', CAST(N'1997-09-06' AS Date), 0, N'Tiền Giang', N'Kinh', N'Phật Giáo', 31, 1, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (8, N'Trần Công Danh', CAST(N'1997-08-06' AS Date), 1, N'tphcm', N'kinh', N'thien chua giao', 32, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (11, N'Thị Nở', CAST(N'1998-02-03' AS Date), 0, N'Tiền Giang Gò Công', N'kinh', N'thien chua giao', 32, 2, NULL, NULL, NULL, 3400)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (12, N'Phong 2K', CAST(N'2006-06-06' AS Date), 1, N'tphcm', N'kinh', N'Phật Giáo', 32, 2, NULL, NULL, NULL, 3400)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (15, N'Trần Công An', CAST(N'1998-12-03' AS Date), 1, N'Nam Định', N'kinh', N'Phật Giáo', 33, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (28, N'Cao Hoài An', CAST(N'2000-03-05' AS Date), 0, N'TP HCM', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (29, N'Trần Mai Phát', CAST(N'2000-05-09' AS Date), 1, N'Hà Nội', N'Kinh', N'Thiên Chúa Giáo', 33, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (30, N'Nguyễn Văn C', CAST(N'2000-08-06' AS Date), 1, N'Ninh Bình', N'Kinh', N'Phật Giáo', 33, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (31, N'Vũ Hoài An ', CAST(N'2000-06-05' AS Date), 0, N'An Giang', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (32, N'Bùi Văn Hến', CAST(N'2000-02-01' AS Date), 1, N'Khánh Hòa', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (33, N'Võ Cao Hoài Nhung', CAST(N'2000-08-04' AS Date), 0, N'Gia Lai', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (97, N'Trần Hoài An ', CAST(N'1999-09-01' AS Date), 1, N'TP Hà Nội', N'Kinh', N'Không', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (98, N'Nguyễn Hoàng Phúc', CAST(N'1999-06-01' AS Date), 1, N'TP Hồ Chí Minh', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (99, N'Hoài Thương ', CAST(N'1999-05-09' AS Date), 0, N'TP Vinh', N'Kinh', N'Phật Giáo ', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (100, N'Cao Quang Lâm ', CAST(N'1999-04-09' AS Date), 1, N'Cà Mau', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (101, N'Võ Hùng Phương Duy', CAST(N'1999-01-01' AS Date), 1, N'Gia Lai', N'Kinh', N'Không', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (102, N'Nguyễn Quế Chi', CAST(N'1999-09-06' AS Date), 0, N'TP Hồ Chí Minh', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (103, N'Trần Cao Phương Mai ', CAST(N'1999-08-05' AS Date), 0, N'Tiền Giang', N'Kinh', N'Không', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (104, N'Võ Lâm Phương Quỳnh', CAST(N'1999-08-08' AS Date), 0, N'Gia Lai', N'Kinh', N'Phật Giáo ', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (105, N'Đào Huỳnh Quang', CAST(N'1999-09-08' AS Date), 1, N'Cần Thơ', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, 10000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (106, N'Đào Hoa Mai', CAST(N'1999-01-06' AS Date), 0, N'Tiền Giang', N'Kinh', N'Phật Giáo', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (155, N'Võ Hoàng Phát', CAST(N'1999-04-14' AS Date), 0, N'tphcm', N'kinh', N'thien chua giao', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (156, N'Vũ Hoàng An', CAST(N'2004-02-29' AS Date), 1, N'TP HCM', N'Kinh', N'Thiên Chúa Giáo', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (157, N'Hoài Công Phúc', CAST(N'1999-04-16' AS Date), 1, N'Hà Nội', N'Kinh', N'Thiên Chúa Giáo', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (233, N'Cao Công Thành', CAST(N'1999-09-06' AS Date), 1, N'tphcm', N'kinh', N'thien chua giao', 31, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (235, N'Hoàng An', CAST(N'1999-07-02' AS Date), 1, N'Hà Nội', N'Kinh', N'Thiên Chúa Giáo', 36, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (236, N'Hồ Thùy Trang', CAST(N'1999-06-03' AS Date), 0, N'Ninh Bình', N'Kinh', N'Thiên Chúa Giáo', 36, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (237, N'Phát Đạt', CAST(N'1999-01-01' AS Date), 1, N'Tiền Giang', N'Kinh', N'Phật Giáo', 36, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (238, N'Vinh Quang', CAST(N'1999-05-03' AS Date), 1, N'Nam Định', N'kinh', N'Phật Giáo', 36, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongTinHS] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[TienHocPhi] ON 

INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (1, 1, 1, 1, 20, 500, 2000, 1000, 500, 0, 120, 300)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (2, 4, 2, 1, 20, 500, 100, 1000, 500, 100, 500, 120)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (3, 6, 1, 2, 21, 500, 100, 10, 5000, 100, 300, 150)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (7, 6, 3, 1, 25, 500, 0, 500, 200, 120, 500, 300)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (8, 2, 2, 3, 16, 500, 100, 200, 100, 0, 300, 100)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (27, 3, 1, 1, 20, 500, 100, 300, 200, 150, 100, 50)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (28, 1, 2, 1, 20, 500, 100, 300, 200, 150, 100, 50)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (32, 4, 1, 1, 20, 500, 100, 300, 200, 150, 100, 50)
SET IDENTITY_INSERT [nxtckedu_sa].[TienHocPhi] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[XinPhep] ON 

INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [ChoHuy], [LyDo]) VALUES (1, 1, CAST(N'2020-04-13' AS Date), CAST(N'2020-04-13' AS Date), 0, 0, N'Dịch covid-19')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [ChoHuy], [LyDo]) VALUES (2, 1, CAST(N'2020-05-01' AS Date), CAST(N'2020-05-10' AS Date), 1, 0, N'Không rõ lý do')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [ChoHuy], [LyDo]) VALUES (3, 1, CAST(N'2020-04-15' AS Date), CAST(N'2020-04-17' AS Date), 0, 0, N'tea')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [ChoHuy], [LyDo]) VALUES (4, 3, CAST(N'2020-04-23' AS Date), CAST(N'2020-04-25' AS Date), 0, 0, N'về que')
SET IDENTITY_INSERT [nxtckedu_sa].[XinPhep] OFF
GO
ALTER TABLE [nxtckedu_sa].[BangDiem]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[BangDiem]  WITH CHECK ADD FOREIGN KEY([IDLoaiDiem])
REFERENCES [nxtckedu_sa].[LoaiDiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[BangDiem]  WITH CHECK ADD FOREIGN KEY([IDMonHoc])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
GO
---dadad
ALTER TABLE [nxtckedu_sa].[BHYT]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[CupHoc]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
---
ALTER TABLE [nxtckedu_sa].[DiemDanh]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[LienKetPHvsHS]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[LienKetPHvsHS]  WITH CHECK ADD FOREIGN KEY([IDTaiKhoan])
REFERENCES [nxtckedu_sa].[TaiKhoanPH] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[Lop]  WITH CHECK ADD FOREIGN KEY([IDKhoi])
REFERENCES [nxtckedu_sa].[Khoi] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[PhanCongDay]  WITH CHECK ADD FOREIGN KEY([IDGiaoVien])
REFERENCES [nxtckedu_sa].[TaiKhoanTruong] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[PhanCongDay]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong]  WITH CHECK ADD FOREIGN KEY([IDMonHoc])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThoiKhoaBieu]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThoiKhoaBieu]  WITH CHECK ADD FOREIGN KEY([IDMonHoc])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoHS]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoHS]  WITH CHECK ADD FOREIGN KEY([IDLoaiThongBao])
REFERENCES [nxtckedu_sa].[LoaiThongBao] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoLop]  WITH CHECK ADD FOREIGN KEY([IDLoaiThongBao])
REFERENCES [nxtckedu_sa].[LoaiThongBao] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoLop]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoTruong]  WITH CHECK ADD FOREIGN KEY([IDLoaiThongBao])
REFERENCES [nxtckedu_sa].[LoaiThongBao] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([CaNam])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([IDLoaiHocSinh])
REFERENCES [nxtckedu_sa].[LoaiHocSinh] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([HKI])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([HKII])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[TienHocPhi]  WITH CHECK ADD FOREIGN KEY([IDKhoi])
REFERENCES [nxtckedu_sa].[Khoi] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[TienHocPhi]  WITH CHECK ADD FOREIGN KEY([IDLoaiHocSinh])
REFERENCES [nxtckedu_sa].[LoaiHocSinh] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[XinPhep]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DangNhapPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DangNhapPH]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DangNhapTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[DangNhapTruong]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_sa.TaiKhoanTruong WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteBangDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[DeleteBangDiem]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.BangDiem WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteBHYT]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteBHYT]
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_sa.BHYT
    WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteCupHoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteCupHoc]
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteDiemDanh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteDiemDanh]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.DiemDanh
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteHanhKiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteHanhKiem]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.LoaiHanhKiem
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteKhoi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteKhoi]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.Khoi
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLienKetPHvsHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteLienKetPHvsHS]
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_sa.LienKetPHvsHS
    WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLoaiDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteLoaiDiem]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiDiem
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLoaiHocSinh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteLoaiHocSinh]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiHocSinh
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLoaiThongBao]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteLoaiThongBao]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiThongBao
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[DeleteLop]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.ThoiKhoaBieu WHERE IDLop = @ID
	DELETE nxtckedu_sa.ThongBaoLop WHERE IDLop = @ID
	DELETE nxtckedu_sa.PhanCongDay WHERE IDLop = @ID
	UPDATE nxtckedu_sa.ThongTinHS SET IDLop = -1 WHERE IDLop = @ID
	UPDATE nxtckedu_sa.TaiKhoanTruong SET IDLop = -1 WHERE IDLop = @ID
    DELETE nxtckedu_sa.Lop
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteMonhoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteMonhoc]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.MonHoc
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeletePhanCongDay]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeletePhanCongDay]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.PhanCongDay
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteTaiKhoanPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteTaiKhoanPH]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.TaiKhoanPH
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteTaiKhoanTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteTaiKhoanTruong]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.TaiKhoanTruong
     WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThoiKhoaBieu]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[DeleteThoiKhoaBieu]
@IDLop INT,
@Thu INT
AS
BEGIN
	DELETE nxtckedu_sa.ThoiKhoaBieu
	WHERE IDLop = @IDLop AND Thu = @Thu
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongBaoHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteThongBaoHS]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.ThongBaoHS
     WHERE ID = @ID
	
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongBaoLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteThongBaoLop]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.ThongBaoLop
     WHERE ID = @ID

END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongBaoTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteThongBaoTruong]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.ThongBaoTruong
     WHERE ID = @ID
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongTinHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[DeleteThongTinHS]
@ID INT
AS
BEGIN
	DELETE from nxtckedu_sa.BHYT
	where IDHocSinh =  @ID
	DELETE from nxtckedu_sa.ThongTinHS
     WHERE ID = @ID 
	
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteTienHocPhi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteTienHocPhi]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.TienHocPhi
     WHERE ID = @ID
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteXinPhep]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DeleteXinPhep]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.XinPhep
     WHERE ID = @ID
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DoiMatKhauPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DoiMatKhauPH]
@ID INT,
@MatKhauCu VARCHAR(200),
@MatKhauMoi VARCHAR(200)
AS
BEGIN
    IF (SELECT COUNT(ID) FROM nxtckedu_sa.TaiKhoanPH WHERE ID = @ID AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauCu),2)) = 1
	BEGIN
	    UPDATE nxtckedu_sa.TaiKhoanPH 
		SET MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauMoi),2) 
		WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DoiMatKhauTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[DoiMatKhauTruong]
@ID INT,
@MatKhauCu VARCHAR(200),
@MatKhauMoi VARCHAR(200)
AS
BEGIN
    IF (SELECT COUNT(ID) FROM nxtckedu_sa.TaiKhoanTruong WHERE ID = @ID AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauCu),2)) = 1
	BEGIN
	    UPDATE nxtckedu_sa.TaiKhoanTruong 
		SET MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhauMoi),2) 
		WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[GetNgayNghi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[GetNgayNghi]
@IDHocSinh INT,
@StartDate DATE,
@EndDate DATE,
@Phep BIT
AS
BEGIN
	IF @Phep = -1
	BEGIN
		SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= @StartDate AND NgayNghi < @EndDate
	END
	ELSE
	BEGIN
		SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= @StartDate AND NgayNghi < @EndDate AND	Phep = @Phep   
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[GetNgayNghiTrongThang]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[GetNgayNghiTrongThang]
@IDHocSinh INT,
@Phep BIT
AS
BEGIN
	DECLARE @Count INT
	IF @Phep = -1
	BEGIN
		SET @Count = (SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= DATEADD(DAY,1, EOMONTH(GETDATE(), -2)) AND NgayNghi < EOMONTH(GETDATE(),-1))
		RETURN @Count
	END
	ELSE
	BEGIN
		SET @Count = (SELECT COUNT(ID) FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh AND NgayNghi >= DATEADD(DAY,1, EOMONTH(GETDATE(), -2)) AND NgayNghi < EOMONTH(GETDATE(),-1) AND Phep = @Phep)
		RETURN @Count
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[HuyXinPhep]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[HuyXinPhep]
@ID INT
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
	SET TrangThai = 0,
		ChoHuy = 1
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertBangDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[InsertBangDiem]
@IDHocSinh INT,
@IDMonHoc INT,
@IDLoaiDiem INT,
@Diem FLOAT,
@HocKyI BIT	,
@CotDiem int
AS
BEGIN
    INSERT nxtckedu_sa.BangDiem
    (
        IDHocSinh,
        IDMonHoc,
        IDLoaiDiem,
        Diem,
        HocKyI,
		CotDiem
    )
    VALUES
    (   @IDHocSinh,
		@IDMonHoc,
		@IDLoaiDiem,
		@Diem,
		@HocKyI,
		@CotDiem
        )
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertBHYT]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertBHYT]
@IDHocSinh INT,
@DangKy BIT,
@BHQD BIT
AS
BEGIN
    INSERT nxtckedu_sa.BHYT
    (
        IDHocSinh,
        DangKy,
        BHQD
    )
    VALUES
    (   @IDHocSinh,
		@DangKy,
		@BHQD
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertCupHoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertCupHoc]
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    INSERT nxtckedu_sa.CupHoc
    (
        IDHocSinh,
        Ngay,
        Tiet
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @Ngay, -- Ngay - DATE
        @Tiet        -- Tiet - int
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertDiemDanh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertDiemDanh]
@IDHocSinh INT,
@NgayNghi DATE,
@Phep BIT
AS
BEGIN
    INSERT nxtckedu_sa.DiemDanh
    (
        IDHocSinh,
        NgayNghi,
        Phep
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NgayNghi, -- NghiTu - DATE
        @Phep       -- Phep - bit
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertHanhKiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertHanhKiem]
@TenHanhKiem nvarchar(60)
AS
BEGIN
	INSERT nxtckedu_sa.LoaiHanhKiem
	(
	    TenHanhKiem
	)
	VALUES
	(@TenHanhKiem -- TenHanhKiem - nvarchar(60)
	    )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertKhoi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertKhoi]
@TenKhoi NVARCHAR(20)
AS
BEGIN
    INSERT nxtckedu_sa.Khoi
    (
        TenKhoi
    )
    VALUES
    (@TenKhoi -- TenKhoi - nvarchar(20)
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLienKetPHvsHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertLienKetPHvsHS]
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
    INSERT nxtckedu_sa.LienKetPHvsHS
    (
        IDHocSinh,
        IDTaiKhoan
    )
    VALUES
    (   @IDHocSinh,
        @IDTaiKhoan
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLoaiDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertLoaiDiem]
@TenLoaiDiem nvarchar(50)
AS
BEGIN
    INSERT nxtckedu_sa.LoaiDiem
    (
        TenLoaiDiem
    )
    VALUES
    (@TenLoaiDiem -- TenLoaiDiem - nvarchar(50)
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLoaiHocSinh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertLoaiHocSinh]
@TenLoai nvarchar(200)
AS
BEGIN
    INSERT nxtckedu_sa.LoaiHocSinh
    (
        TenLoai
    )
    VALUES
    (@TenLoai -- TenLoai - nvarchar(200)
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLoaiThongBao]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertLoaiThongBao]
@TenThongBao nvarchar(100)
AS
BEGIN
    INSERT nxtckedu_sa.LoaiThongBao
    (
        TenThongBao
    )
    VALUES
    (@TenThongBao -- TenThongBao - nvarchar(100)
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertLop]
@IDKhoi INT, 
@TenLop NVARCHAR(50)
AS
BEGIN
    INSERT nxtckedu_sa.Lop
    (
        IDKhoi,
        TenLop
    )
    VALUES
    (   @IDKhoi,  -- IDKhoi - int
        @TenLop -- TenLop - nvarchar(50)
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertMonhoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[InsertMonhoc]
@TenMon NVARCHAR(200),
@LoaiDiem bit
AS
BEGIN
    Insert nxtckedu_sa.MonHoc
    (
        TenMon,
        LoaiDiem
    )
    VALUES
    (
        @TenMon, -- TenMon - nvarchar(200)
        @LoaiDiem -- LoaiDiem - bit
        )
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertPhanCongDay]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[InsertPhanCongDay]
@IDGiaoVien INT,
@IDLop INT
AS
BEGIN
    INSERT nxtckedu_sa.PhanCongDay
    (
        IDGiaoVien,
        IDLop
    )
    VALUES
    (   @IDGiaoVien,
        @IDLop
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertQuanLyThongTinHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[InsertQuanLyThongTinHS]
@Ten NVARCHAR(200),
@NgaySinh DATE,
@GioiTinh BIT,
@NoiSinh NVARCHAR(250),
@DanToc NVARCHAR(100),
@TonGiao NVARCHAR(100),
@IDLop INT,
@IDLoaiHocSinh INT
AS
BEGIN
	INSERT nxtckedu_sa.ThongTinHS
	(
	    Ten,
	    NgaySinh,
	    GioiTinh,
	    NoiSinh,
	    DanToc,
	    TonGiao,
	    IDLop,
	    IDLoaiHocSinh
	)
	VALUES
	(   @Ten,       -- Ten - nvarchar(200)
        @NgaySinh, -- NgaySinh - DATE
        @GioiTinh,      -- GioiTinh - bit
        @NoiSinh,       -- NoiSinh - nvarchar(250)
        @DanToc,       -- DanToc - nvarchar(100)
        @TonGiao,       -- TonGiao - nvarchar(100)
        @IDLop,         -- IDLop - int
	    @IDLoaiHocSinh
	    )
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertTaiKhoanPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertTaiKhoanPH]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@TenMe NVARCHAR(150),
@SDTMe VARCHAR(12),
@TenBo NVARCHAR(150),
@SDTBo VARCHAR(12)
AS
BEGIN
    INSERT nxtckedu_sa.TaiKhoanPH
    (
        TaiKhoan,
        MatKhau,
        TenMe,
        SDTMe,
        TenBo,
        SDTBo
    )
    VALUES
    (   @TaiKhoan,
        @MatKhau,
        @TenMe,
        @SDTMe,
        @TenBo,
        @SDTBo
        )
	DECLARE @I INT = (SELECT ID FROM nxtckedu_sa.TaiKhoanPH WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE nxtckedu_sa.TaiKhoanPH SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertTaiKhoanTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertTaiKhoanTruong]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@Loai BIT,
@TenGV NVARCHAR(200),
@SDT VARCHAR(12),
@IDMonHoc INT,
@IDLop INT
AS
BEGIN
	INSERT nxtckedu_sa.TaiKhoanTruong
	(
	    TaiKhoan,
	    MatKhau,
	    Loai,
	    TenGV,
	    SDT,
	    IDMonHoc,
	    IDLop
	)
	VALUES
	(   @TaiKhoan,
		@MatKhau,
		@Loai,
		@TenGV,
		@SDT,
		@IDMonHoc,
		@IDLop
	    )
	DECLARE @I INT = (SELECT ID FROM nxtckedu_sa.TaiKhoanTruong WHERE MatKhau = @MatKhau AND TaiKhoan = @TaiKhoan)
	UPDATE nxtckedu_sa.TaiKhoanTruong SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThoiKhoaBieu]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[InsertThoiKhoaBieu]
@IDLop INT,
@Thu INT,
@Tiet INT,
@IDMonHoc INT
AS
BEGIN
	INSERT nxtckedu_sa.ThoiKhoaBieu
	(
	    IDLop,
	    Thu,
	    Tiet,
	    IDMonHoc
	)
	VALUES
	(   @IDLop, -- IDLop - int
	    @Thu, -- Thu - int
	    @Tiet, -- Tiet - int
	    @IDMonHoc  -- IDMon - int
	    )
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongBaoHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertThongBaoHS]
@IDHocSinh INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
	INSERT nxtckedu_sa.ThongBaoHS
	(
	    IDHocSinh,
	    NoiDung,
	    Ngay,
	    IDLoaiThongBao
	)
	VALUES
	(   @IDHocSinh,
		@NoiDung,
	    @Ngay,
	    @IDLoaiThongBao
	    )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongBaoLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertThongBaoLop]
@IDLop INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Insert nxtckedu_sa.ThongBaoLop
    (
		IDLop,
        NoiDung,
		Ngay,
	    IDLoaiThongBao
    )
    VALUES
    (	@IDLop,
		@NoiDung,
		@Ngay,
	    @IDLoaiThongBao
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongBaoTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertThongBaoTruong]
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Insert nxtckedu_sa.ThongBaoTruong
    (
        NoiDung,
		Ngay,
	    IDLoaiThongBao
    )
    VALUES
    (	@NoiDung,
		@Ngay,
	    @IDLoaiThongBao
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongTinHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[InsertThongTinHS]
@Ten NVARCHAR(200),
@NgaySinh DATE,
@GioiTinh BIT,
@NoiSinh NVARCHAR(250),
@DanToc NVARCHAR(100),
@TonGiao NVARCHAR(100),
@IDLop INT,
@IDLoaiHocSinh INT,
@HKI INT,
@HKII INT,
@CaNam INT
AS
BEGIN
	INSERT nxtckedu_sa.ThongTinHS
	(
	    Ten,
	    NgaySinh,
	    GioiTinh,
	    NoiSinh,
	    DanToc,
	    TonGiao,
	    IDLop,
	    IDLoaiHocSinh,
	    HKI,
	    HKII,
	    CaNam
	)
	VALUES
	(   @Ten,       -- Ten - nvarchar(200)
        @NgaySinh, -- NgaySinh - DATE
        @GioiTinh,      -- GioiTinh - bit
        @NoiSinh,       -- NoiSinh - nvarchar(250)
        @DanToc,       -- DanToc - nvarchar(100)
        @TonGiao,       -- TonGiao - nvarchar(100)
        @IDLop,         -- IDLop - int
	    @IDLoaiHocSinh,
		@HKI,
		@HKII,
		@CaNam
	    )
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertTienHocPhi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertTienHocPhi]
@Thang INT,
@IDLoaiHocSinh INT,
@IDKhoi INT,
@SoNgayHoc INT,
@TienHoc INT,
@TienAn INT,
@TienDien INT,
@TienNuoc INT,
@TienVeSinh INT,
@TienTrangThietBi INT,
@TienTaiLieu INT
AS
BEGIN
    INSERT nxtckedu_sa.TienHocPhi
    (
        Thang,
        IDLoaiHocSinh,
        IDKhoi,
        SoNgayHoc,
        TienHoc,
        TienAn,
        TienDien,
        TienNuoc,
        TienVeSinh,
        TienTrangThietBi,
        TienTaiLieu
    )
    VALUES
    (   @Thang,
        @IDLoaiHocSinh,
        @IDKhoi,
        @SoNgayHoc,
        @TienHoc,
        @TienAn,
        @TienDien,
        @TienNuoc,
        @TienVeSinh,
        @TienTrangThietBi,
        @TienTaiLieu
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertXinPhep]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[InsertXinPhep]
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@TrangThai BIT,
@ChoHuy BIT 
AS
BEGIN
    INSERT nxtckedu_sa.XinPhep
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        TrangThai,
		ChoHuy
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - DATE
        @NghiDen, -- NghiDen - DATE
        @TrangThai,         
		@ChoHuy
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertXinPhepV2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[InsertXinPhepV2]
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@LyDo NVARCHAR(1000)
AS
BEGIN
    INSERT nxtckedu_sa.XinPhep
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        TrangThai,
        ChoHuy,
        LyDo
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - date
        @NghiDen, -- NghiDen - date
        0,      -- TrangThai - bit
        0,      -- ChoHuy - bit
        @LyDo        -- LyDo - nvarchar(1000)
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[m_SelectThoiKhoaBieu]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[m_SelectThoiKhoaBieu]
@IDLop INT
AS
BEGIN
    SELECT Thu, Tiet, TenMon FROM nxtckedu_sa.ThoiKhoaBieu
	JOIN nxtckedu_sa.MonHoc
	ON MonHoc.ID = ThoiKhoaBieu.IDMonHoc
	WHERE IDLop = @IDLop
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBangDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectBangDiem]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.BangDiem
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.BangDiem WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBangDiemByHocSinh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectBangDiemByHocSinh]
@IDHocSinh INT
AS
BEGIN
	select A.Ten,B.Diem as [DiemMieng],C.Diem as[15p_1],D.Diem as[15p_2],E.Diem as[15p_3],F.Diem as[1t_1],G.Diem as[1t_2],H.Diem as[1t_3],I.Diem as[HocKy]
	from nxtckedu_sa.ThongTinHS as A
	FULL OUTER JOIN nxtckedu_sa.BangDiem as B
	on A.ID=B.IDHocSinh  and B.IDLoaiDiem=1
	FULL OUTER JOIN nxtckedu_sa.BangDiem as C
	on A.ID=C.IDHocSinh  and C.IDLoaiDiem=2
	FULL OUTER JOIN nxtckedu_sa.BangDiem as D
	on A.ID=D.IDHocSinh  and D.IDLoaiDiem=3
	FULL OUTER JOIN nxtckedu_sa.BangDiem as E
	on A.ID=E.IDHocSinh  and E.IDLoaiDiem=4
	FULL OUTER JOIN nxtckedu_sa.BangDiem as F
	on A.ID=F.IDHocSinh  and F.IDLoaiDiem=5
	FULL OUTER JOIN nxtckedu_sa.BangDiem as G
	on A.ID=G.IDHocSinh  and G.IDLoaiDiem=6
	FULL OUTER JOIN nxtckedu_sa.BangDiem as H
	on A.ID=H.IDHocSinh  and H.IDLoaiDiem=7
	FULL OUTER JOIN nxtckedu_sa.BangDiem as I
	on A.ID=I.IDHocSinh  and I.IDLoaiDiem=8
	where A.ID = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBangDiemv2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectBangDiemv2]
@IDHocSinh INT 
AS
BEGIN
	SELECT B.IDLoaiDiem,
           B.IDMonHoc,
           B.NgayNhap,
           L.TenLoaiDiem,
           B.HocKyI,
           B.Diem FROM nxtckedu_sa.BangDiem AS B
	JOIN nxtckedu_sa.LoaiDiem AS L
	ON L.ID = B.IDLoaiDiem
	WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBHYT]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectBHYT]
@IDHocSinh INT
AS
BEGIN
    IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.BHYT
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.BHYT WHERE IDHocSinh = @IDHocSinh 	
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectChiTiepDiemDanh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectChiTiepDiemDanh]
@IDHocSinh INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectChiTietDD]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectChiTietDD]
@IDTaiKhoan INT

AS
BEGIN
    SELECT Tk.ID as MaPH,Tk.TaiKhoan, DD.NgayNghi,DD.Phep,DD.IDHocSinh
	FROM nxtckedu_sa.TaiKhoanPH Tk
	inner join nxtckedu_sa.LienKetPHvsHS LK  
	on TK.ID = Lk.IDTaiKhoan inner join ThongTinHS TT
	on LK.IDHocSinh = TT.ID inner join DiemDanh DD
	on TT.ID = DD.IDHocSinh
	WHERE Tk.ID = @IDTaiKhoan
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectChiTietTienHoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectChiTietTienHoc]
@Thang INT,
@IDLoaiHocSinh INT,
@IDKhoi int
AS
BEGIN
    SELECT SoNgayHoc,
				 TienAn,
                 TienDien,
                 TienHoc,
                 TienNuoc,
                 TienTaiLieu,
                 TienTrangThietBi,
                 TienVeSinh
	FROM nxtckedu_sa.TienHocPhi
	WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectCupHoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectCupHoc]
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectDiemDanh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectDiemDanh]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.DiemDanh
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.DiemDanh WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectFunctionOrder]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectFunctionOrder]
AS
BEGIN
    SELECT * FROM FunctionOrder
END
GO


ALTER PROCEDURE [nxtckedu_sa].[W_UpdateFunctionOrder_BHYT]
@StartDate date,
@EndDate date
AS
BEGIN
    UPDATE nxtckedu_sa.FunctionOrder
    SET	StartDate = @StartDate,
		EndDate = @EndDate
	WHERE ID = 1
END
GO


ALTER PROCEDURE [nxtckedu_sa].[W_SelectFunctionOrder_BHYT]
AS
BEGIN
    SELECT * FROM FunctionOrder
	where ID = 1
END
GO

/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHanhKiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectHanhKiem]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiHanhKiem
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiHanhKiem WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHocPhiTheoKhoi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectHocPhiTheoKhoi]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.TienHocPhi
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.TienHocPhi WHERE IDKhoi = @ID
	END
	
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHocSinhTrongLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectHocSinhTrongLop]
@IDLop INT
AS
BEGIN
    SELECT Ten,NgaySinh FROM nxtckedu_sa.ThongTinHS WHERE IDLop = @IDLop
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHsvsPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter PROCEDURE [nxtckedu_sa].[W_SelectTTHS_ByIDPH]
@IDTaiKhoan INT
AS
BEGIN
    SELECT A.ID,A.Ten,A.NgaySinh,A.GioiTinh,A.NoiSinh,A.DanToc,A.TonGiao
	FROM nxtckedu_sa.ThongTinHS as A
	inner join nxtckedu_sa.LienKetPHvsHS as B 
	on A.ID = B.IDHocSinh
	inner join nxtckedu_sa.TaiKhoanPH as C
	on B.IDTaiKhoan = C.ID 
	WHERE B.IDTaiKhoan = @IDTaiKhoan
END
GO

/****** Object:  StoredProcedure [nxtckedu_sa].[SelectKhoi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectKhoi]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.Khoi WHERE ID <> @ID
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.Khoi WHERE ID = @ID AND	ID <> -1
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLayHSQuanLy]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectLayHSQuanLy]
@IDTaiKhoan INT
AS
BEGIN
	SELECT * FROM nxtckedu_sa.LienKetPHvsHS WHERE IDTaiKhoan = @IDTaiKhoan
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLienKetPHvsHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectLienKetPHvsHS]
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LienKetPHvsHS
	END
	ELSE 
	BEGIN
		SELECT * FROM nxtckedu_sa.LienKetPHvsHS WHERE IDHocSinh = @IDHocSinh
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectListThongBaoHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectListThongBaoHS]
@IDHocSinh INT
AS
BEGIN
    SELECT ThongBaoHS.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoHS 
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = ThongBaoHS.IDLoaiThongBao
	WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectListThongBaoLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectListThongBaoLop]
@IDLop INT
AS
BEGIN
    SELECT ThongBaoLop.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoLop 
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = ThongBaoLop.IDLoaiThongBao WHERE IDLop = @IDLop
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectListThongBaoTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectListThongBaoTruong]
AS
BEGIN
    SELECT ThongBaoTruong.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoTruong
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = nxtckedu_sa.ThongBaoTruong.IDLoaiThongBao
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLoaiDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectLoaiDiem]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiDiem WHERE ID <> -1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiDiem WHERE ID = @ID AND ID <> -1
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLoaiHocSinh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectLoaiHocSinh]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiHocSinh
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiHocSinh WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLoaiThongBao]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectLoaiThongBao]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.LoaiThongBao
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.LoaiThongBao WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectLop]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.Lop WHERE ID <> -1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.Lop WHERE ID = @ID AND ID <> -1
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectMonhoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectMonhoc]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.MonHoc WHERE ID <> -1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.MonHoc WHERE ID = @ID AND ID <> -1
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectMonhocv2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectMonhocv2]
AS
BEGIN
	SELECT ID,TenMon,LoaiDiem FROM nxtckedu_sa.MonHoc WHERE CoDiem = 1
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectNoiDungThongBaoHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectNoiDungThongBaoHS]
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoHS WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectNoiDungThongBaoLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectNoiDungThongBaoLop]
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoLop WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectNoiDungThongBaoTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectNoiDungThongBaoTruong]
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoTruong WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectPhanCongDay]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectPhanCongDay]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.PhanCongDay
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.PhanCongDay WHERE ID = @ID
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectTaiKhoanPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectTaiKhoanPH]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE ID <> -1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE ID = @ID AND ID <> -1
	END
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectTaiKhoanTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectTaiKhoanTruong]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.TaiKhoanTruong
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.TaiKhoanTruong WHERE ID = @ID
	END
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThoiKhoaBieu]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectThoiKhoaBieu]
@IDLop INT,
@Thu INT,
@Tiet INT 
AS
BEGIN
	IF @Tiet = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThoiKhoaBieu WHERE IDLop = @IDLop AND Thu = @Thu
	END
	ELSE
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThoiKhoaBieu WHERE IDLop = @IDLop AND Thu = @Thu AND	Tiet = @Tiet
	END
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectThongBaoHS]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoHS WHERE ID = @ID
	END
	
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoHSV2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectThongBaoHSV2]
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoHS WHERE IDHocSinh = @IDHocSinh
	END
	
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectThongBaoLop]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoLop
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoLop WHERE ID = @ID
	END

END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoLopV2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectThongBaoLopV2]
@IDLop INT
AS
BEGIN
    IF @IDLop = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoLop
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoLop WHERE IDLop = @IDLop
	END

END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectThongBaoTruong]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoTruong
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoTruong WHERE ID = @ID
	END
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongTinGV]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectThongTinGV]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongTinHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectThongTinHS]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongTinHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongTinHS WHERE ID = @ID
	END
	
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongTinHSv2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectThongTinHSv2]
@ID INT	
AS
BEGIN
    SELECT HS.CaNam,
           HS.DanToc,
           HS.GioiTinh,
           HS.HKI,
           HS.HKII,
           HS.ID,
           L.IDKhoi,
           HS.IDLoaiHocSinh,
           HS.IDLop,
           HS.NoiSinh,
           HS.NgaySinh,
           HS.Ten,
           K.TenKhoi,
           LHS.TenLoai,
           L.TenLop,
           HS.TonGiao,
		   HS.Tien,
		   BH.DangKy,
		   BH.BHQD
	FROM nxtckedu_sa.ThongTinHS AS HS
	JOIN nxtckedu_sa.Lop AS L
	ON L.ID = HS.IDLop
	JOIN nxtckedu_sa.Khoi AS K
	ON K.ID = L.IDKhoi
	JOIN nxtckedu_sa.LoaiHocSinh AS LHS
	ON LHS.ID = HS.IDLoaiHocSinh
	JOIN nxtckedu_sa.BHYT AS BH
	ON BH.IDHocSinh = HS.ID
	WHERE HS.ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectTienHocPhi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectTienHocPhi]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.TienHocPhi
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.TienHocPhi WHERE ID = @ID
	END
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectXinPhep]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[SelectXinPhep]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.XinPhep
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.XinPhep WHERE ID = @ID
	END
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectXinPhepTheoIDHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[SelectXinPhepTheoIDHS]
@IDHocSinh INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.XinPhep WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateBangDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdateBangDiem]
@ID INT,
@IDHocSinh INT,
@IDMonHoc INT,
@IDLoaiDiem INT,
@NgayNhap DATE,
@Diem FLOAT,
@HocKyI BIT	
AS
BEGIN
    UPDATE nxtckedu_sa.BangDiem
    SET	IDHocSinh = @IDHocSinh,
		IDMonHoc = @IDMonHoc,
		IDLoaiDiem = @IDLoaiDiem,
		NgayNhap = @NgayNhap,
		Diem = @Diem,
		HocKyI = @HocKyI
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateBHYT]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateBHYT]
@IDHocSinh INT,
@DangKy BIT,
@BHQD BIT
AS
BEGIN
    UPDATE nxtckedu_sa.BHYT
    SET	DangKy = @DangKy,
        BHQD = @BHQD
    WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateCupHoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateCupHoc]
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateDiemDanh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateDiemDanh]
@ID INT,
@IDHocSinh INT,
@NgayNghi DATE,
@Phep BIT
AS
BEGIN
    UPDATE nxtckedu_sa.DiemDanh
    SET IDHocSinh = @IDHocSinh,
        NgayNghi = @NgayNghi,
        Phep = @Phep
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateHanhKiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateHanhKiem]
@ID INT,
@TenHanhKiem nvarchar(60)
AS
BEGIN
	UPDATE nxtckedu_sa.LoaiHanhKiem
	SET
	    TenHanhKiem = @TenHanhKiem
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateKhoi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateKhoi]
@ID INT,
@TenKhoi NVARCHAR(20)
AS
BEGIN
    UPDATE nxtckedu_sa.Khoi
    SET
        TenKhoi = @TenKhoi
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLienKetPHvsHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdateLienKetPHvsHS]
@IDHocSinh INT,
@IDTaiKhoan INT
AS
BEGIN
    UPDATE nxtckedu_sa.LienKetPHvsHS
    SET
        IDTaiKhoan = @IDTaiKhoan
    WHERE IDHocSinh = @IDHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLoaiDiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateLoaiDiem]
@ID INT,
@TenLoaiDiem nvarchar(50)
AS
BEGIN
    UPDATE nxtckedu_sa.LoaiDiem
    SET
        TenLoaiDiem = @TenLoaiDiem
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLoaiHocSinh]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateLoaiHocSinh]
@ID INT,
@TenLoai nvarchar(200)
AS
BEGIN
    UPDATE nxtckedu_sa.LoaiHocSinh
    SET
        TenLoai = @TenLoai
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLoaiThongBao]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateLoaiThongBao]
@ID INT,
@TenThongBao nvarchar(100)
AS
BEGIN
    UPDATE nxtckedu_sa.LoaiThongBao
    SET
        TenThongBao = @TenThongBao
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateLop]
@ID INT,
@IDKhoi INT, 
@TenLop NVARCHAR(50)
AS
BEGIN
    UPDATE nxtckedu_sa.Lop
    SET
        IDKhoi = @IDKhoi,
        TenLop = @TenLop
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateMonhoc]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateMonhoc]
@ID INT,
@TenMon NVARCHAR(200),
@LoaiDiem INT
AS
BEGIN
    Update nxtckedu_sa.MonHoc
    SET	
        TenMon = @TenMon,
        LoaiDiem = @LoaiDiem
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdatePhanCongDay]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdatePhanCongDay]
@ID INT,
@IDGiaoVien INT
AS
BEGIN
	Update nxtckedu_sa.PhanCongDay
	SET
	    IDGiaoVien = @IDGiaoVien
	    
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateQuanLyThongTinHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdateQuanLyThongTinHS]
@ID INT,
@Ten NVARCHAR(200),
@NgaySinh DATE,
@GioiTinh BIT,
@NoiSinh NVARCHAR(250),
@DanToc NVARCHAR(100),
@TonGiao NVARCHAR(100),
@IDLop INT,
@IDLoaiHocSinh INT
AS
BEGIN
	UPDATE nxtckedu_sa.ThongTinHS
	SET
	    Ten = @Ten,
	    NgaySinh = @NgaySinh,
	    GioiTinh = @GioiTinh,
	    NoiSinh = @NoiSinh,
	    DanToc = @DanToc,
	    TonGiao = @TonGiao,
	    IDLop = @IDLop,
	    IDLoaiHocSinh = @IDLoaiHocSinh
     WHERE ID = @ID
	
END


GO

ALTER PROCEDURE [nxtckedu_sa].[W_UpdateThongTinHS_PH]
@ID INT,
@NoiSinh NVARCHAR(250),
@DanToc NVARCHAR(100),
@TonGiao NVARCHAR(100)
AS
BEGIN
	UPDATE nxtckedu_sa.ThongTinHS
	SET
	    NoiSinh = @NoiSinh,
	    DanToc = @DanToc,
	    TonGiao = @TonGiao
     WHERE ID = @ID
	
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateTaiKhoanPH]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateTaiKhoanPH]
@ID INT,
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@TenMe NVARCHAR(150),
@SDTMe VARCHAR(12),
@TenBo NVARCHAR(150),
@SDTBo VARCHAR(12)
AS
BEGIN
    UPDATE nxtckedu_sa.TaiKhoanPH
    SET	
        TaiKhoan = @TaiKhoan,
        MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2),
        TenMe = @TenMe,
        SDTMe = @SDTMe,
        TenBo = @TenBo,
        SDTBo = @SDTBo
     WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateTaiKhoanTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdateTaiKhoanTruong]
@ID INT,
@Loai BIT,
@TenGV NVARCHAR(200),
@SDT VARCHAR(12),
@IDMonHoc INT,
@IDLop INT
AS
BEGIN
	UPDATE nxtckedu_sa.TaiKhoanTruong
	SET   
	    Loai = @Loai,
	    TenGV = @TenGV,
	    SDT = @SDT,
	    IDMonHoc = @IDMonHoc,
	    IDLop = @IDLop
     WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThoiKhoaBieu]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdateThoiKhoaBieu]
@IDLop INT,
@Thu INT,
@Tiet INT,
@IDMonHoc INT
AS
BEGIN
	UPDATE nxtckedu_sa.ThoiKhoaBieu
	SET
	    IDMonHoc = @IDMonHoc
	WHERE IDLop = @IDLop AND Thu = @Thu and Tiet=@Tiet
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongBaoHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateThongBaoHS]
@ID INT,
@IDHocSinh INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
	UPDATE nxtckedu_sa.ThongBaoHS
	SET
	    IDHocSinh = @IDHocSinh,
	    NoiDung = @NoiDung,
	    Ngay= @Ngay,
	    IDLoaiThongBao = @IDLoaiThongBao
     WHERE ID = @ID
	
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongBaoLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateThongBaoLop]
@ID INT,
@IDLop INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Update nxtckedu_sa.ThongBaoLop
    SET
		IDLop = @IDLop,
        NoiDung = @NoiDung,
	    Ngay= @Ngay,
	    IDLoaiThongBao = @IDLoaiThongBao
     WHERE ID = @ID

END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongBaoTruong]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateThongBaoTruong]
@ID INT,
@NoiDung NVARCHAR(MAX),
@Ngay DATE,
@IDLoaiThongBao INT
AS
BEGIN
    Update nxtckedu_sa.ThongBaoTruong
    SET
        NoiDung = @NoiDung,
	    Ngay= @Ngay,
	    IDLoaiThongBao = @IDLoaiThongBao
     WHERE ID = @ID
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongTinHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdateThongTinHS]
@ID INT,
@Ten NVARCHAR(200),
@NgaySinh DATE,
@GioiTinh BIT,
@NoiSinh NVARCHAR(250),
@DanToc NVARCHAR(100),
@TonGiao NVARCHAR(100),
@IDLop INT,
@IDLoaiHocSinh INT,
@HKI INT,
@HKII INT,
@CaNam INT
AS
BEGIN
	UPDATE nxtckedu_sa.ThongTinHS
	SET
	    Ten = @Ten,
	    NgaySinh = @NgaySinh,
	    GioiTinh = @GioiTinh,
	    NoiSinh = @NoiSinh,
	    DanToc = @DanToc,
	    TonGiao = @TonGiao,
	    IDLop = @IDLop,
	    IDLoaiHocSinh = @IDLoaiHocSinh,
	    HKI = @HKI,
	    HKII = @HKII,
	    CaNam = @CaNam
     WHERE ID = @ID
	
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateTienHocPhi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateTienHocPhi]
@ID INT,
@Thang INT,
@IDLoaiHocSinh INT,
@IDKhoi INT,
@SoNgayHoc INT,
@TienHoc INT,
@TienAn INT,
@TienDien INT,
@TienNuoc INT,
@TienVeSinh INT,
@TienTrangThietBi INT,
@TienTaiLieu INT
AS
BEGIN
    UPDATE nxtckedu_sa.TienHocPhi
    SET
        Thang  = @Thang,
        IDLoaiHocSinh = @IDLoaiHocSinh,
        IDKhoi = @IDKhoi,
        SoNgayHoc = @SoNgayHoc,
        TienHoc = @TienHoc,
        TienAn = @TienAn,
        TienDien = @TienDien,
        TienNuoc = @TienNuoc,
        TienVeSinh = @TienVeSinh,
        TienTrangThietBi = @TienTrangThietBi,
        TienTaiLieu = @TienTaiLieu
     WHERE ID = @ID
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateXinPhep]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [nxtckedu_sa].[UpdateXinPhep]
@ID INT,
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@TrangThai BIT ,
@ChoHuy BIT 
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
    SET
        IDHocSinh = @IDHocSinh,
        NghiTu = @NghiTu,
        NghiDen = @NghiDen,
        TrangThai = @TrangThai,
		ChoHuy = @ChoHuy
     WHERE ID = @ID
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateXinPhepV2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[UpdateXinPhepV2]
@ID INT,
@NghiTu DATE,
@NghiDen DATE,
@LyDo NVARCHAR(1000)
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
	SET NghiTu = @NghiTu,
        NghiDen = @NghiDen,
        TrangThai = 0,
        LyDo = @LyDo
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectBangDiem_Full]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectBangDiem_Full]
@IDLop INT,
@IDMon Int,
@HocKy bit
AS
BEGIN
	select A.Ten,B.Diem as [DM1],C.Diem as[DM2],D.Diem as[DM3],E.Diem as[DM4],F.Diem as[DM5],G.Diem as[15p_1]
	,H.Diem as[15p_2],I.Diem as[15p_3],J.Diem as[15p_4],K.Diem as[15p_5]
	,L.Diem as[1t_1],M.Diem as[1t_2],N.Diem as[1t_3],O.Diem as[1t_4],P.Diem as[1t_5],Q.Diem as[HocKy]
	from nxtckedu_sa.ThongTinHS as A
	FULL OUTER JOIN nxtckedu_sa.BangDiem as B
	on A.ID=B.IDHocSinh  and B.IDLoaiDiem=1 and B.CotDiem = 1 and B.HocKyI = @HocKy and B.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as C
	on A.ID=C.IDHocSinh  and C.IDLoaiDiem=1 and C.CotDiem = 2 and C.HocKyI = @HocKy and C.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as D
	on A.ID=D.IDHocSinh  and D.IDLoaiDiem=1 and D.CotDiem = 3 and D.HocKyI = @HocKy and D.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as E
	on A.ID=E.IDHocSinh  and E.IDLoaiDiem=1 and E.CotDiem = 4 and E.HocKyI = @HocKy and E.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as F
	on A.ID=F.IDHocSinh  and F.IDLoaiDiem=1 and F.CotDiem = 5 and E.HocKyI = @HocKy and F.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as G
	on A.ID=G.IDHocSinh  and G.IDLoaiDiem=2 and G.CotDiem = 1 and G.HocKyI = @HocKy and G.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as H
	on A.ID=H.IDHocSinh  and H.IDLoaiDiem=2 and H.CotDiem = 2 and H.HocKyI = @HocKy and H.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as I
	on A.ID=I.IDHocSinh  and I.IDLoaiDiem=2 and I.CotDiem = 3 and I.HocKyI = @HocKy and I.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as J
	on A.ID=J.IDHocSinh  and J.IDLoaiDiem=2 and J.CotDiem = 4 and J.HocKyI = @HocKy and J.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as K
	on A.ID=K.IDHocSinh  and K.IDLoaiDiem=2 and K.CotDiem = 5 and K.HocKyI = @HocKy and K.IDMonHoc = @IDMon


	FULL OUTER JOIN nxtckedu_sa.BangDiem as L
	on A.ID=L.IDHocSinh  and L.IDLoaiDiem=3 and L.CotDiem = 1 and L.HocKyI = @HocKy and L.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as M
	on A.ID=M.IDHocSinh  and M.IDLoaiDiem=3 and M.CotDiem = 2 and M.HocKyI = @HocKy and M.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as N
	on A.ID=N.IDHocSinh  and N.IDLoaiDiem=3 and N.CotDiem = 3 and N.HocKyI = @HocKy and N.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as O
	on A.ID=O.IDHocSinh  and O.IDLoaiDiem=3 and O.CotDiem = 4 and O.HocKyI = @HocKy and O.IDMonHoc = @IDMon
	FULL OUTER JOIN nxtckedu_sa.BangDiem as P
	on A.ID=P.IDHocSinh  and P.IDLoaiDiem=3 and P.CotDiem = 5 and P.HocKyI = @HocKy and P.IDMonHoc = @IDMon

	FULL OUTER JOIN nxtckedu_sa.BangDiem as Q
	on A.ID=Q.IDHocSinh  and Q.IDLoaiDiem=4 and Q.CotDiem = 1 and Q.HocKyI = @HocKy and Q.IDMonHoc = @IDMon
	where A.IDLop = @IDLop
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectBangDiem_V2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectBangDiem_V2]
@IDLop INT,
@IDMon INT,
@IDLoaiDiem INT,
@Lan INT,
@HocKyI bit
AS
BEGIN
	
	select A.ID,A.Ten,B.Diem
	from nxtckedu_sa.ThongTinHS as A
	full outer join (select A.ID,A.Ten,B.Diem
	from nxtckedu_sa.ThongTinHS as A
	JOIN nxtckedu_sa.BangDiem as B
	on A.ID=B.IDHocSinh and B.IDMonHoc =  @IDMon and B.IDLoaiDiem=@IDLoaiDiem and B.Cotdiem = @Lan and B.HocKyI = @HocKyI
	) as B
	on A.ID = B.ID
	where A.IDLop = @IDLop 
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectDanhSachLopChuNhiem]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectDanhSachLopChuNhiem]
@ID int
AS
BEGIN
	if @ID= -1
	begin
		select A.ID,B.TenKhoi,A.TenLop,concat(B.TenKhoi,A.TenLop) as[TenDayDu]
		from nxtckedu_sa.Lop as A
		inner join nxtckedu_sa.Khoi as B
		on A.IDKhoi = B.ID
		where  A.ID Not in
		(
			select A.ID
			from nxtckedu_sa.Lop as A
			inner JOIN nxtckedu_sa.TaiKhoanTruong as B
			on A.ID = B.IDLop and A.ID != -1
		) 
	end
	else
	begin
		select A.ID,B.TenKhoi,A.TenLop,concat(B.TenKhoi,A.TenLop) as[TenDayDu]
		from nxtckedu_sa.Lop as A
		inner join nxtckedu_sa.Khoi as B
		on A.IDKhoi = B.ID
		where  A.ID Not in
		(
			select A.ID
			from nxtckedu_sa.Lop as A
			inner JOIN nxtckedu_sa.TaiKhoanTruong as B
			on A.ID = B.IDLop and A.ID != -1 and A.ID != @ID
		)
	end 
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectDiemDanhByIDHS]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectDiemDanhByIDHS]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.DiemDanh
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @ID
	END
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectLienKetPHvsHS_ByIdLop]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectLienKetPHvsHS_ByIdLop]
@IDLop INT
AS
BEGIN
	select A.ID , A.Ten , B.TaiKhoan
	from nxtckedu_sa.ThongTinHS as A
	full outer join (select A.IDHocSinh , A.IDTaiKhoan , B.TaiKhoan
	from nxtckedu_sa.LienKetPHvsHS as A
	join  nxtckedu_sa.TaiKhoanPH as B
	on A.IDTaiKhoan = B.ID )as B on A.ID =B.IDHocSinh 
	where A.IDLop = @IDLop
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectLopTheoKhoi]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectLopTheoKhoi]
@IDKhoi INT
AS
BEGIN
    IF @IDKhoi = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.Lop WHERE ID <> 0 and ID!=-1
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.Lop WHERE IDKhoi = @IDKhoi AND ID <> 0 and ID!=-1
	END
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectLopTheoKhoi_LayTen]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectLopTheoKhoi_LayTen]
@IDLop INT
AS
BEGIN
    if @IDLop = -1
	Begin
	select A.ID,B.TenKhoi,A.TenLop,concat(B.TenKhoi,A.TenLop) as[TenDayDu]
	from nxtckedu_sa.Lop as A
	inner join nxtckedu_sa.Khoi as B
	on A.IDKhoi = B.ID
	end
	else
	begin
	select A.ID,B.TenKhoi,A.TenLop,concat(B.TenKhoi,A.TenLop) as[TenDayDu]
	from nxtckedu_sa.Lop as A
	inner join nxtckedu_sa.Khoi as B
	on A.IDKhoi = B.ID
	where A.ID = @IDLop 
	end
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectPhanCongDay_ByIdGv]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectPhanCongDay_ByIdGv]
@IDGV INT
AS
BEGIN
	select B.IDLop as [ID],D.TenKhoi,C.TenLop,concat(D.TenKhoi,C.TenLop) as [TenDayDu]
	from nxtckedu_sa.TaiKhoanTruong as A
	inner join nxtckedu_sa.PhanCongDay as B
	on A.ID=B.IDGiaoVien
	inner join nxtckedu_sa.Lop as C
	on B.IDLop = C.ID
	inner join nxtckedu_sa.Khoi as D
	on C.IDKhoi=D.ID
	where A.ID = @IDGV
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectPhanCongDayV2]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectPhanCongDayV2]
@IDLop INT
AS
BEGIN
	select h.TenMon,g.TenGV,h.ID as[IDMon],g.IDPhanCong
	from nxtckedu_sa.MonHoc as h
	Full outer join (
	select A.ID,A.TenMon,D.IDGiaoVien,C.TenGV,D.ID as[IDPhanCong]
	from nxtckedu_sa.MonHoc as A
	Left JOIN nxtckedu_sa.MonHoc as B
	on B.ID= A.ID 
	join nxtckedu_sa.TaiKhoanTruong as C
	on B.ID= C.IDMonHoc
	join nxtckedu_sa.PhanCongDay as D
	on D.IDGiaoVien = C.ID
	where D.IDLop = @IDLop
	) g on h.ID = g.ID 
	where h.ID != -1 and h.ID != 12
END



GO

ALTER PROCEDURE [nxtckedu_sa].[W_SelectPhanCongDay_TTGVBM]
@IDLop INT
AS
BEGIN
	select h.TenMon,g.TenGV,g.SDT
	from nxtckedu_sa.MonHoc as h
	Full outer join (
	select A.ID,A.TenMon,D.IDGiaoVien,C.TenGV,D.ID as[IDPhanCong],C.SDT
	from nxtckedu_sa.MonHoc as A
	Left JOIN nxtckedu_sa.MonHoc as B
	on B.ID= A.ID 
	join nxtckedu_sa.TaiKhoanTruong as C
	on B.ID= C.IDMonHoc
	join nxtckedu_sa.PhanCongDay as D
	on D.IDGiaoVien = C.ID
	where D.IDLop = @IDLop
	) g on h.ID = g.ID 
	where h.ID != -1 and h.ID != 12
END
GO


/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanPH_Check]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanPH_Check]
@TaiKhoan Varchar(100)
AS
BEGIN
	SELECT Count(*) FROM nxtckedu_sa.TaiKhoanPH
	where TaiKhoan = @TaiKhoan
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanPH_Search]    Script Date: 10/05/2020 8:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanPH_Search]
@TaiKhoan Varchar(100)
AS
BEGIN
		SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE TaiKhoan Like '%' + @TaiKhoan +'%'
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanTruong_ByIdMon]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanTruong_ByIdMon]
@IDMon INT
AS
BEGIN
	IF @IDMon = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.TaiKhoanTruong
	END
	ELSE
	BEGIN
		SELECT * FROM nxtckedu_sa.TaiKhoanTruong WHERE IDMonHoc = @IDMon
	END
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanTruong_Check]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanTruong_Check]
@TaiKhoan Varchar(100)
AS
BEGIN
	SELECT Count(*) FROM nxtckedu_sa.TaiKhoanTruong
	where TaiKhoan = @TaiKhoan
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanTruongV2]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [nxtckedu_sa].[W_SelectTaiKhoanTruongV2]
@ID Int
as
begin 
if @ID = -1 
begin
	select A.ID,A.TaiKhoan,A.Loai,A.TenGV,A.SDT,A.IDMonHoc,B.TenMon,A.IDLop,D.TenKhoi,C.TenLop
	from nxtckedu_sa.TaiKhoanTruong as A
	inner join nxtckedu_sa.MonHoc as B
	on A.IDMonHoc = B.ID
	inner join nxtckedu_sa.Lop as C
	on A.IDLop = C.ID
	inner join nxtckedu_sa.Khoi as D
	on C.IDKhoi = D.ID
end
else
begin
	select A.ID,A.TaiKhoan,A.Loai,A.TenGV,A.SDT,A.IDMonHoc,B.TenMon,A.IDLop,D.TenKhoi,C.TenLop
	from nxtckedu_sa.TaiKhoanTruong as A
	inner join nxtckedu_sa.MonHoc as B
	on A.IDMonHoc = B.ID
	inner join nxtckedu_sa.Lop as C
	on A.IDLop = C.ID
	inner join nxtckedu_sa.Khoi as D
	on C.IDKhoi = D.ID
	where A.ID = @ID
end
end 



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThoiKhoaBieuV2]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectThoiKhoaBieuV2]
@IDLop INT,@Thu Int
AS
BEGIN
    if @Thu = -1
	Begin
	SELECT IDLop,Thu, Tiet, IDMonHoc,TenMon 
	FROM nxtckedu_sa.ThoiKhoaBieu as A
	JOIN nxtckedu_sa.MonHoc as B
	ON A.IDMonHoc = B.ID
	WHERE IDLop = @IDLop 
	end
	else
	begin
	SELECT IDLop,Thu, Tiet, IDMonHoc,TenMon 
	FROM nxtckedu_sa.ThoiKhoaBieu as A
	JOIN nxtckedu_sa.MonHoc as B
	ON A.IDMonHoc = B.ID
	WHERE IDLop = @IDLop and Thu = @Thu
	end
END



GO

alter PROCEDURE [nxtckedu_sa].[W_SelectThoiKhoaBieu_ByIdHs]
@IDHocSinh INT,
@Thu int
AS
BEGIN
    select B.TenMon
	from nxtckedu_sa.ThongTinHS as A
	left join (
	select B.TenMon , A.IDLop
	from nxtckedu_sa.ThoiKhoaBieu as A
	join nxtckedu_sa.MonHoc as B on A.IDMonHoc = B.ID
	where A.Tiet < 11 and A.Thu = @Thu
	) as B on A.IDLop =B.IDLop 
	where A.ID = @IDHocSinh
END
GO



/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongBaoHSV2]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectThongBaoHSV2]
@IDHocSinh INT
AS
BEGIN
	IF @IDHocSinh = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongBaoHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongBaoHS WHERE IDHocSinh = @IDHocSinh
	END
	
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongTinHSTheoLop]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_SelectThongTinHSTheoLop]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.ThongTinHS
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.ThongTinHS WHERE IDLop = @ID
	END
	
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongTinLienKetPHvsHS_ByIdPh]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter PROCEDURE [nxtckedu_sa].[W_SelectThongTinLienKetPHvsHS_ByIdPh]
@IDTaiKhoan INT
AS
BEGIN
	select B.ID,B.Ten,B.IDLop,B.TenLop
	from nxtckedu_sa.LienKetPHvsHS as A
	join (
	select A.ID ,A.Ten,concat(C.TenKhoi,B.TenLop) as [TenLop],A.IDLop
	from nxtckedu_sa.ThongTinHS as A
	join nxtckedu_sa.Lop as B
	on A.IDLop = B.ID
	join nxtckedu_sa.Khoi as C
	on B.IDKhoi = C.ID
	) as B
	on A.IDHocSinh = B.ID
	where A.IDTaiKhoan = @IDTaiKhoan
END


GO

/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateResetPassTaiKhoanPH]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_UpdateResetPassTaiKhoanPH]
@ID INT
AS
BEGIN
	UPDATE nxtckedu_sa.TaiKhoanPH
	SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', TaiKhoan), 2	)
     WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateResetPassTaiKhoanTruong]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_UpdateResetPassTaiKhoanTruong]
@ID INT
AS
BEGIN
	UPDATE nxtckedu_sa.TaiKhoanTruong
	SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', TaiKhoan), 2	)
     WHERE ID = @ID
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateTaiKhoanPH]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [nxtckedu_sa].[W_UpdateTaiKhoanPH]
@ID INT,
@TaiKhoan VARCHAR(100),
@TenMe NVARCHAR(150),
@SDTMe VARCHAR(12),
@TenBo NVARCHAR(150),
@SDTBo VARCHAR(12)
AS
BEGIN
    UPDATE nxtckedu_sa.TaiKhoanPH
    SET	
        TaiKhoan = @TaiKhoan,
        TenMe = @TenMe,
        SDTMe = @SDTMe,
        TenBo = @TenBo,
        SDTBo = @SDTBo
     WHERE ID = @ID
END


GO
/****** Object:  Trigger [nxtckedu_sa].[trg_InsertLop]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [nxtckedu_sa].[trg_InsertLop]
ON [nxtckedu_sa].[Lop]
FOR	INSERT
AS
BEGIN
	IF (SELECT COUNT(TenLop) FROM nxtckedu_sa.Lop WHERE TenLop = (SELECT Inserted.TenLop FROM Inserted) AND IDKhoi = (SELECT Inserted.IDKhoi FROM Inserted)) = 2
	BEGIN
	    PRINT 'Lớp đã có không thể thêm'
		ROLLBACK
	END
	ELSE
	BEGIN
	    DECLARE @Thu INT = 1
		DECLARE @Tiet INT
		WHILE @Thu < 8
		BEGIN
		    SET @Tiet = 1
			WHILE @Tiet < 11
			BEGIN
			    INSERT nxtckedu_sa.ThoiKhoaBieu
			    (
				    IDLop,
			        Thu,
			        Tiet,
			        IDMonHoc
			    )
			    VALUES
			    (   (SELECT Inserted.ID FROM Inserted), -- IDLop - int
			        @Thu, -- Thu - int
			        @Tiet, -- Tiet - int
			        12  -- IDMonHoc - int
			        )
				SET @Tiet = @Tiet + 1
			END
			SET @Thu = @Thu + 1
		END
	END
END

GO
/****** Object:  Trigger [nxtckedu_sa].[trg_InsertThongTinHS]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [nxtckedu_sa].[trg_InsertThongTinHS]
ON [nxtckedu_sa].[ThongTinHS]
FOR INSERT
AS
BEGIN
    INSERT nxtckedu_sa.BHYT
    (
        IDHocSinh,
        DangKy,
        BHQD
    )
    VALUES
    (   (SELECT ID FROM Inserted),    -- IDHocSinh - int
        0, -- DangKy - bit
        0  -- BHQD - bit
        )
END
GO
/****** Object:  Trigger [nxtckedu_sa].[trg_DeleteTienHocPhi]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [nxtckedu_sa].[trg_DeleteTienHocPhi]
ON [nxtckedu_sa].[TienHocPhi]
FOR DELETE
AS
BEGIN
	PRINT 'Không thể xóa'
	ROLLBACK
END

GO
/****** Object:  Trigger [nxtckedu_sa].[trg_InsertTienHocPhi]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [nxtckedu_sa].[trg_InsertTienHocPhi]
ON [nxtckedu_sa].[TienHocPhi]
FOR INSERT
AS
BEGIN
	DECLARE @Thang INT = (SELECT Thang FROM Inserted)
	DECLARE @IDLoaiHocSinh INT = (SELECT IDLoaiHocSinh FROM Inserted)
	DECLARE @IDKhoi INT = (SELECT IDKhoi FROM Inserted)

	IF (SELECT COUNT(ID) FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDKhoi = @IDKhoi AND IDLoaiHocSinh = @IDLoaiHocSinh) = 2
	BEGIN
	    PRINT 'Đã có tháng này rồi không thể thêm'
		ROLLBACK
	END
	ELSE
	BEGIN
		IF @Thang <> MONTH(GETDATE())
		BEGIN
			PRINT 'Không có quyền thêm tháng này vui lòng kiểm tra lại'
			ROLLBACK
		END
		ELSE
		BEGIN
			DECLARE @list TABLE (ID INT)
			DECLARE @TongTien INT = 0
			DECLARE @Loop INT
			
			SET @Thang = @Thang - 1
			DECLARE @TienAn INT = (SELECT TienAn FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			DECLARE @SoNgayHoc INT = (SELECT SoNgayHoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			
			SET @TongTien = @TongTien +  (SELECT TienHoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienDien FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienNuoc FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienVeSinh FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienTrangThietBi FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)
			SET @TongTien = @TongTien +  (SELECT TienTaiLieu FROM nxtckedu_sa.TienHocPhi WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh AND IDKhoi = @IDKhoi)

			INSERT INTO @list
			SELECT ID FROM nxtckedu_sa.ThongTinHS WHERE IDLop IN (SELECT ID FROM nxtckedu_sa.Lop WHERE IDKhoi = @IDKhoi) AND IDLoaiHocSinh = @IDLoaiHocSinh
	
			SET @Loop = (SELECT COUNT(ID) FROM @list)

			WHILE @Loop <> 0
			BEGIN
				DECLARE @IDHS INT = (SELECT MIN(ID) FROM @list)
				DECLARE @SoNgayNghi INT
				EXEC @SoNgayNghi = nxtckedu_sa.GetNgayNghiTrongThang @IDHocSinh = @IDHS, -- int
				                                                     @Phep = 1    -- bit
				UPDATE nxtckedu_sa.ThongTinHS
				SET Tien = Tien - ((@TienAn * (@SoNgayHoc - @SoNgayNghi))+ @TongTien)
				WHERE ID = @IDHS
				DELETE @list WHERE ID = @IDHS
				SET @Loop = @Loop - 1
			END
		END
	END
END

GO
/****** Object:  Trigger [nxtckedu_sa].[trg_UpdateTienHocPhi]    Script Date: 10/05/2020 8:23:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [nxtckedu_sa].[trg_UpdateTienHocPhi]
ON [nxtckedu_sa].[TienHocPhi]
FOR UPDATE
AS
BEGIN
	IF (SELECT COUNT(ID) FROM nxtckedu_sa.TienHocPhi WHERE Thang = (SELECT COUNT(Inserted.Thang) FROM Inserted)) = 1
	OR (SELECT COUNT(ID) FROM nxtckedu_sa.TienHocPhi WHERE IDKhoi = (SELECT COUNT(Inserted.IDKhoi) FROM Inserted)) = 1
		OR (SELECT COUNT(ID) FROM nxtckedu_sa.TienHocPhi WHERE IDLoaiHocSinh = (SELECT COUNT(Inserted.IDLoaiHocSinh) FROM Inserted)) = 1
	BEGIN
	    IF (SELECT Thang FROM Inserted) <> MONTH(GETDATE())
		BEGIN
			PRINT 'Không có quyền cập nhập tháng này vui lòng kiểm tra lại'
			ROLLBACK
		END
	END
	ELSE
	BEGIN
	    PRINT 'Chưa có tháng này rồi không thể cập nhập'
		ROLLBACK
	END
END

GO
USE [master]
GO
ALTER DATABASE [nxtckedu_HeThongSoLienLac] SET  READ_WRITE 
GO
