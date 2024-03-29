USE [master]
GO
/****** Object:  Database [nxtckedu_HeThongSoLienLac]    Script Date: 16/11/2020 9:52:53 AM ******/
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
/****** Object:  User [nxtckedu_sa]    Script Date: 16/11/2020 9:52:53 AM ******/
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
/****** Object:  Schema [nxtckedu_sa]    Script Date: 16/11/2020 9:52:54 AM ******/
CREATE SCHEMA [nxtckedu_sa]
GO
/****** Object:  Table [nxtckedu_sa].[BangDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[BHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[CupHoc]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[DiemDanh]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[DTBMon]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[DTBMon](
	[IDHocSinh] [int] NOT NULL,
	[IDMon] [int] NOT NULL,
	[IDLop] [int] NOT NULL,
	[HKI] [float] NULL,
	[HKII] [float] NULL,
	[CaNam] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDHocSinh] ASC,
	[IDMon] ASC,
	[IDLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[DTBTong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[DTBTong](
	[IDHocSinh] [int] NOT NULL,
	[IDLop] [int] NOT NULL,
	[HKI] [float] NULL,
	[HKII] [float] NULL,
	[CaNam] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDHocSinh] ASC,
	[IDLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[FunctionOrder]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[HoaDonHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[HoaDonHocPhi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHocPhi] [int] NULL,
	[NgayTao] [datetime] NULL,
	[IDHocSinh] [int] NULL,
	[ThanhToan] [bit] NULL,
 CONSTRAINT [PK_HoaDonHocPhi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[Khoi]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[LienKetPHvsHS]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[LoaiDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[LoaiHanhKiem]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[LoaiHocSinh]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[LoaiThongBao]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[LoaiTrangThai]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[LoaiTrangThai](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTrangThai] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [nxtckedu_sa].[Lop]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[MonHoc]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[PhanCongDay]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[TaiKhoanPH]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[TaiKhoanTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[ThoiKhoaBieu]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[ThongBaoHS]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[ThongBaoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[ThongBaoTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[ThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[TienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Table [nxtckedu_sa].[XinPhep]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [nxtckedu_sa].[XinPhep](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHocSinh] [int] NULL,
	[NghiTu] [date] NULL,
	[NghiDen] [date] NULL,
	[TrangThai] [int] NULL,
	[LyDo] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [nxtckedu_sa].[ThongTinHS_View_M]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [nxtckedu_sa].[ThongTinHS_View_M] AS
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
GO
/****** Object:  View [nxtckedu_sa].[XinPhep_View]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [nxtckedu_sa].[XinPhep_View] AS
SELECT X.ID,
       X.IDHocSinh,
       X.LyDo,
       X.NghiDen,
       X.NghiTu,
       T.TenTrangThai FROM nxtckedu_sa.XinPhep AS X
JOIN nxtckedu_sa.LoaiTrangThai AS T ON T.ID = X.TrangThai
GO
SET IDENTITY_INSERT [nxtckedu_sa].[BangDiem] ON 

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
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (143, 1, 4, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (144, 2, 4, 1, 7.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (145, 3, 4, 1, 9.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (146, 6, 4, 1, 1, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (147, 7, 4, 1, 1, 1, 1)
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
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (184, 100, 1, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (185, 160, 18, 1, 1, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (186, 160, 18, 1, 2.25, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (187, 160, 18, 1, 3, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (188, 160, 18, 1, 0.5, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (189, 160, 18, 1, 1, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (190, 160, 18, 1, 1, 0, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (191, 160, 18, 4, 2.5, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (192, 160, 18, 4, 3.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (193, 160, 18, 3, 2, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (194, 160, 18, 3, 3, 0, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (195, 160, 18, 3, 3.25, 0, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (196, 160, 18, 3, 2, 0, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (197, 160, 18, 3, 0, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (198, 160, 18, 3, 0, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (199, 160, 18, 3, 0.25, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (200, 1, 14, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (201, 2, 14, 1, 8, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (202, 1, 14, 1, 8, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (203, 2, 14, 1, 9, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (212, 106, 1, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (214, 1, 1, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (215, 155, 1, 1, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (217, 101, 1, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (218, 102, 1, 1, 4, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (222, 103, 1, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (226, 156, 1, 1, 6, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (228, 6, 1, 4, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (229, 158, 1, 1, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (230, 158, 1, 1, 9, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (231, 97, 15, 1, 2, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (232, 7, 11, 4, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (233, 7, 11, 4, 10, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (234, 2, 15, 3, 3, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (235, 2, 15, 3, 5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (243, 2, 15, 2, 9, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (244, 2, 15, 2, 8, 0, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (246, 2, 10, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (249, 2, 10, 2, 8, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (253, 6, 10, 4, 9, 1, 1)
GO
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (255, 2, 5, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (256, 2, 5, 1, 10, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (257, 2, 5, 1, 8, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (266, 2, 5, 1, 8, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (267, 2, 5, 1, 9, 0, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (268, 2, 5, 1, 7, 0, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (269, 2, 5, 1, 6, 0, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (270, 2, 5, 1, 9, 0, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (273, 104, 1, 1, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (274, 104, 1, 1, 6, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (275, 156, 1, 1, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (281, 2, 15, 1, 9, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (287, 156, 1, 2, 9, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (289, 157, 1, 1, 3, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (292, 157, 1, 3, 5, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (304, 3, 1, 2, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (305, 1, 1, 2, 9, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (306, 1, 1, 2, 6, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (307, 1, 1, 3, 1.5, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (311, 159, 1, 4, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (313, 160, 1, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (315, 160, 1, 2, 9, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (317, 160, 1, 2, 3, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (321, 160, 1, 3, 4, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (329, 2, 3, 2, 8, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (331, 1, 11, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (361, 2, 11, 1, 10, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (362, 105, 1, 1, 4, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (363, 105, 1, 2, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (364, 105, 1, 2, 6, 0, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (365, 2, 5, 1, 7, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (366, 2, 5, 1, 8.5, 1, 5)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (367, 2, 5, 2, 7.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (368, 2, 5, 2, 8, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (369, 2, 5, 2, 6.75, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (370, 2, 5, 2, 7, 1, 4)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (371, 2, 5, 3, 8, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (372, 2, 5, 4, 9.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (373, 2, 7, 1, 8, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (374, 2, 7, 1, 9, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (375, 2, 7, 2, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (376, 2, 7, 2, 9, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (377, 2, 7, 3, 8.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (378, 2, 7, 4, 7.5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (379, 159, 1, 1, 0, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (380, 6, 1, 1, 6, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (381, 106, 1, 2, 5, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (382, 106, 1, 2, 9, 1, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (383, 155, 1, 2, 6.5, 0, 3)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (384, 176, 1, 1, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (385, 8, 15, 1, 8, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (386, 11, 15, 1, 9, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (387, 12, 15, 1, 7, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (388, 8, 15, 1, 7, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (389, 11, 15, 1, 8, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (390, 12, 15, 1, 7, 1, 2)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (391, 1, 5, 1, 3, 1, 1)
INSERT [nxtckedu_sa].[BangDiem] ([ID], [IDHocSinh], [IDMonHoc], [IDLoaiDiem], [Diem], [HocKyI], [CotDiem]) VALUES (392, 3, 5, 1, 3, 1, 1)
SET IDENTITY_INSERT [nxtckedu_sa].[BangDiem] OFF
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (1, 0, NULL)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (2, 1, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (3, 1, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (6, 1, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (7, 1, 0)
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
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (97, 0, 1)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (98, 0, 1)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (99, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (100, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (101, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (102, 0, 1)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (103, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (104, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (105, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (106, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (155, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (156, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (157, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (158, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (159, 0, 1)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (160, 1, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (161, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (164, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (165, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (166, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (167, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (168, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (169, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (170, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (171, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (172, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (173, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (174, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (175, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (176, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (177, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (178, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (179, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (180, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (181, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (182, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (183, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (184, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (185, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (186, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (187, 0, 0)
INSERT [nxtckedu_sa].[BHYT] ([IDHocSinh], [DangKy], [BHQD]) VALUES (188, 0, 0)
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
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (59, 1, CAST(N'2020-05-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (62, 106, CAST(N'2020-05-08' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (65, 1, CAST(N'2020-05-13' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (66, 160, CAST(N'2020-05-13' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (67, 161, CAST(N'2020-05-19' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (68, 3, CAST(N'2020-05-20' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (69, 1, CAST(N'2020-05-20' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (70, 161, CAST(N'2020-05-20' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (71, 161, CAST(N'2020-05-20' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (72, 2, CAST(N'2020-05-20' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (73, 1, CAST(N'2020-05-23' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (74, 6, CAST(N'2020-05-25' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (75, 161, CAST(N'2020-05-26' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (76, 1, CAST(N'2020-05-28' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (77, 1, CAST(N'2020-05-28' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (78, 1, CAST(N'2020-05-28' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (79, 1, CAST(N'2020-05-28' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (80, 161, CAST(N'2020-05-29' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (81, 1, CAST(N'2020-05-29' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (82, 161, CAST(N'2020-05-29' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (83, 7, CAST(N'2020-05-29' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (84, 161, CAST(N'2020-05-29' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (85, 7, CAST(N'2020-05-29' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (86, 7, CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (87, 2, CAST(N'2020-05-30' AS Date), 1)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (88, 7, CAST(N'2020-05-30' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (89, 7, CAST(N'2020-05-30' AS Date), 0)
INSERT [nxtckedu_sa].[DiemDanh] ([ID], [IDHocSinh], [NgayNghi], [Phep]) VALUES (90, 2, CAST(N'2020-06-25' AS Date), 1)
SET IDENTITY_INSERT [nxtckedu_sa].[DiemDanh] OFF
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (1, 1, 31, 6.3586956521739131, 0, 2.1195652173913042)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (1, 2, 31, 0, 0, 0)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (1, 4, 31, 8.25, 0, 2.75)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (1, 5, 31, 3, 0, 1)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (1, 11, 31, 6, 0, 2)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (2, 3, 31, 8, 0, 2.6666666666666665)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (2, 5, 31, 8.375, 7.8, 7.9916666666666671)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (2, 7, 31, 8.0555555555555554, 0, 2.6851851851851851)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (2, 10, 31, 7.5, 0, 2.5)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (2, 11, 31, 10, 0, 3.3333333333333335)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (2, 15, 31, 5, 8.5, 7.333333333333333)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (3, 1, 31, 7.416666666666667, 0, 2.4722222222222223)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (3, 5, 31, 3, 0, 1)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (6, 1, 31, 8.25, 0, 2.75)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (6, 10, 31, 9, 0, 3)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (7, 11, 31, 9, 10, 9.6666666666666661)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (8, 15, 32, 7.5, 0, 2.5)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (11, 15, 32, 8.5, 0, 2.8333333333333335)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (12, 15, 32, 7, 0, 2.3333333333333335)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (97, 15, 34, 2, 0, 0.66666666666666663)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (101, 1, 34, 6, 0, 2)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (102, 1, 34, 4, 0, 1.3333333333333333)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (103, 1, 34, 6, 0, 2)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (104, 1, 34, 9, 6, 7)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (105, 1, 34, 5, 6, 5.666666666666667)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (106, 1, 35, 7, 0, 2.3333333333333335)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (155, 1, 35, 9, 6.5, 7.333333333333333)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (156, 1, 35, 9, 6, 7)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (157, 1, 35, 4.333333333333333, 0, 1.4444444444444444)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (158, 1, 31, 9, 9, 9)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (159, 1, 31, 6.75, 0, 2.25)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (160, 1, 39, 5.2, 0, 1.7333333333333334)
INSERT [nxtckedu_sa].[DTBMon] ([IDHocSinh], [IDMon], [IDLop], [HKI], [HKII], [CaNam]) VALUES (176, 1, 31, 9, 0, 3)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (1, 31, 4.7217391304347824, 0, 1.5739130434782609)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (2, 31, 7.8217592592592595, 2.7166666666666668, 4.4183641975308641)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (3, 31, 5.2083333333333339, 0, 1.7361111111111112)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (6, 31, 8.625, 0, 2.875)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (7, 31, 9, 10, 9.6666666666666661)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (8, 32, 7.5, 0, 2.5)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (11, 32, 8.5, 0, 2.8333333333333335)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (12, 32, 7, 0, 2.3333333333333335)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (97, 34, 2, 0, 0.66666666666666663)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (101, 34, 6, 0, 2)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (102, 34, 4, 0, 1.3333333333333333)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (103, 34, 6, 0, 2)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (104, 34, 9, 6, 7)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (105, 34, 5, 6, 5.666666666666667)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (106, 35, 7, 0, 2.3333333333333335)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (155, 35, 9, 6.5, 7.333333333333333)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (156, 35, 9, 6, 7)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (157, 35, 4.333333333333333, 0, 1.4444444444444444)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (158, 31, 9, 9, 9)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (159, 31, 6.75, 0, 2.25)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (160, 39, 5.2, 0, 1.7333333333333334)
INSERT [nxtckedu_sa].[DTBTong] ([IDHocSinh], [IDLop], [HKI], [HKII], [CaNam]) VALUES (176, 31, 9, 0, 3)
SET IDENTITY_INSERT [nxtckedu_sa].[FunctionOrder] ON 

INSERT [nxtckedu_sa].[FunctionOrder] ([ID], [NameFunc], [StartDate], [EndDate]) VALUES (1, N'BHYT', CAST(N'2020-04-27' AS Date), CAST(N'2020-06-30' AS Date))
SET IDENTITY_INSERT [nxtckedu_sa].[FunctionOrder] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[HoaDonHocPhi] ON 

INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (3, 1, CAST(N'2020-08-28 00:00:00.000' AS DateTime), 1, 1)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (5, 39, CAST(N'2020-11-03 18:24:10.973' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (6, 39, CAST(N'2020-11-03 18:25:09.130' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (7, 1, CAST(N'2020-08-28 00:00:00.000' AS DateTime), 1, 1)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (8, 39, CAST(N'2020-11-03 18:28:01.093' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (9, 39, CAST(N'2020-11-03 18:30:11.493' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (10, 1, CAST(N'2020-08-28 00:00:00.000' AS DateTime), 1, 1)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (11, 39, CAST(N'2020-11-03 18:33:57.790' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (16, 39, CAST(N'2020-11-03 18:59:21.357' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (17, 39, CAST(N'2020-11-03 19:06:00.290' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (18, 39, CAST(N'2020-11-03 19:16:04.057' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (19, 39, CAST(N'2020-11-03 19:21:08.497' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (20, 39, CAST(N'2020-11-03 19:25:02.677' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (21, 39, CAST(N'2020-11-03 19:28:54.600' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (22, 39, CAST(N'2020-11-03 20:06:14.657' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (23, 39, CAST(N'2020-11-04 14:29:03.877' AS DateTime), 102, 0)
INSERT [nxtckedu_sa].[HoaDonHocPhi] ([ID], [IDHocPhi], [NgayTao], [IDHocSinh], [ThanhToan]) VALUES (24, 39, CAST(N'2020-11-04 14:30:44.017' AS DateTime), 102, 0)
SET IDENTITY_INSERT [nxtckedu_sa].[HoaDonHocPhi] OFF
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
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (7, 5)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (97, 4)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (98, 3)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (102, 5)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (104, 24)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (158, 24)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (159, 24)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (160, 24)
INSERT [nxtckedu_sa].[LienKetPHvsHS] ([IDHocSinh], [IDTaiKhoan]) VALUES (161, 5)
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
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiTrangThai] ON 

INSERT [nxtckedu_sa].[LoaiTrangThai] ([ID], [TenTrangThai]) VALUES (1, N'Chờ duyệt')
INSERT [nxtckedu_sa].[LoaiTrangThai] ([ID], [TenTrangThai]) VALUES (2, N'Đã duyệt')
INSERT [nxtckedu_sa].[LoaiTrangThai] ([ID], [TenTrangThai]) VALUES (3, N'Từ Chối')
INSERT [nxtckedu_sa].[LoaiTrangThai] ([ID], [TenTrangThai]) VALUES (4, N'Chờ Xóa')
SET IDENTITY_INSERT [nxtckedu_sa].[LoaiTrangThai] OFF
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
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (43, 1, N'C4')
INSERT [nxtckedu_sa].[Lop] ([ID], [IDKhoi], [TenLop]) VALUES (44, 2, N'B5')
SET IDENTITY_INSERT [nxtckedu_sa].[Lop] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[MonHoc] ON 

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
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (15, N'GDQP - AN', 1, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (18, N'Kỹ Năng Sống 1', 0, 1)
INSERT [nxtckedu_sa].[MonHoc] ([ID], [TenMon], [LoaiDiem], [CoDiem]) VALUES (19, N'GIáo Dục Giới Tính', 0, 1)
SET IDENTITY_INSERT [nxtckedu_sa].[MonHoc] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[PhanCongDay] ON 

INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (5, 6, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (6, 6, 33)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (7, 11, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (8, 11, 33)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (9, 11, 34)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (10, 6, 34)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (11, 6, 35)
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
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (67, 13, 33)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (68, 6, 39)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (69, 13, 39)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (70, 4, 39)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (71, 19, 39)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (72, 19, 32)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (73, 4, 33)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (74, 20, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (75, 19, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (76, 21, 31)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (77, 13, 34)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (78, 4, 34)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (79, 4, 32)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (80, 21, 32)
INSERT [nxtckedu_sa].[PhanCongDay] ([ID], [IDGiaoVien], [IDLop]) VALUES (81, 11, 32)
SET IDENTITY_INSERT [nxtckedu_sa].[PhanCongDay] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[TaiKhoanPH] ON 

INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (3, N'admin', N'0CC175B9C0F1B6A831C399E269772661', N'Admin', N'0123456789', N'Admin', N'0123456789')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (4, N'truong', N'047C30E8313DB6E45FD87AB6E1BFD1FB', N'Dao', N'0215555585', N'Hung', N'5566666998')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (5, N'phong', N'9F48495BB4B98AC37A1A72C7E6490C7A', N'phong', N'123456789', N'ph', N'123568796')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (23, N'0352908667', N'AC151FCF77E229ADE20B67973CB54062', N'Mai', N'0123456789', N'Phát Đạt', N'0466165651')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (24, N'duong', N'A8A3CC869DB1FB318CE847C92ACD517C', N'Quên rr', N'0216541655', N'Chú Quảng', N'0908076666')
INSERT [nxtckedu_sa].[TaiKhoanPH] ([ID], [TaiKhoan], [MatKhau], [TenMe], [SDTMe], [TenBo], [SDTBo]) VALUES (25, N'vhp', N'8B02D10C4AD6040529C8EEF40FE7311A', N'phong', N'123456', N'phong', N'123456')
SET IDENTITY_INSERT [nxtckedu_sa].[TaiKhoanPH] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[TaiKhoanTruong] ON 

INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 1, N'admin', N'123456789', 1, -1)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (2, N'gv001', N'213EF674A59C115A7B41BC50044AB2E1', 0, N'GV Dạy Toán', N'0366666666', 15, -1)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (4, N'gv003', N'E6658BB23E0779F02A1B399731B725FB', 0, N'GV Hóa', N'5745648789', 3, -1)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (6, N'phong', N'9F48495BB4B98AC37A1A72C7E6490C7A', 0, N'phong', N'36936985', 1, 38)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (7, N'a', N'0CC175B9C0F1B6A831C399E269772661', 1, N'a', N'0123456789', 1, 32)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (11, N'an', N'18B049CC8D8535787929DF716F9F4E68', 1, N'an', N'0123456789', 14, 36)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (12, N'gvkynangsong', N'9DF1F90D219A7A73FA2584F763CCE33A', 0, N'Cao Thành Phát', N'0369856214', 15, 31)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (13, N'gv007', N'FC669D4007CE2A8F8C667E6A97437F02', 0, N'Nguyễn Thành Khang GV Lý', N'0369852147', 2, 40)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (19, N'duong', N'3E48F1CE9F015CC59BD7BF0605681F28', 0, N'Dương Bit', N'0938214850', 11, 39)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (20, N'Truong123', N'44F490CA670187F3284859EAED7DFFF2', 0, N'Trần Trường', N'123', 5, 37)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (21, N'Dialy', N'FFF54918F93489D686E753DF6CA68611', 0, N'Táo', N'020229933', 7, -1)
INSERT [nxtckedu_sa].[TaiKhoanTruong] ([ID], [TaiKhoan], [MatKhau], [Loai], [TenGV], [SDT], [IDMonHoc], [IDLop]) VALUES (22, N'0352908667', N'AC151FCF77E229ADE20B67973CB54062', 1, N'VHP', N'0352908667', 1, -1)
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
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 1, 4)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 2, 3)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 3, 9)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 4, 1)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 5, 1)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 6, 10)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 7, 10)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 9, 5)
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
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 1, 5)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 2, 11)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 3, 11)
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
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 10, 12)
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
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 1, 4)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 2, 3)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 3, 9)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 4, 1)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 5, 1)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 6, 10)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 7, 10)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (31, 2, 9, 5)
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
GO
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
GO
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
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 1, 5)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 2, 11)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (34, 2, 3, 11)
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
GO
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
GO
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
GO
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
GO
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
GO
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
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 6, 10, 12)
GO
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (43, 7, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 1, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 2, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 3, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 4, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 5, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 6, 10, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 1, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 2, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 3, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 4, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 5, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 6, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 7, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 8, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 9, 12)
INSERT [nxtckedu_sa].[ThoiKhoaBieu] ([IDLop], [Thu], [Tiet], [IDMonHoc]) VALUES (44, 7, 10, 12)
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
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (13, 102, N'0908780988 gọi vào số này', CAST(N'2020-04-15' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (14, 156, N'Hop phụ huynh tháng 6', CAST(N'2020-04-15' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (16, 7, N'123', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (17, 1, N'369', CAST(N'2020-04-22' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (19, 160, N'Mời phụ huynh ngày 16/5', CAST(N'2020-05-13' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (20, 160, N'Hạnh Kiểm Yếu Kém Lưu Ban Năm Nay', CAST(N'2020-05-13' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (21, 8, N'An Lol', CAST(N'2020-05-13' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (22, 161, N'123', CAST(N'2020-05-25' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (23, 1, N'Ngày Mai Được Nghỉ Học', CAST(N'2020-05-25' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (24, 1, N'alo 123 tét thông báo', CAST(N'2020-05-25' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (25, 161, N'Pppp
666', CAST(N'2020-05-26' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (32, 161, N'phong 123456', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (34, 161, N'phong ettt', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (40, 7, N'6666', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (42, 7, N'9', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (45, 161, N'a', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (48, 161, N'9', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (49, 1, N'96', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (50, 7, N'Io', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (51, 7, N'Ty', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (52, 7, N'Ô', CAST(N'2020-05-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (53, 2, N'ngày mai đc nghỉ nhé', CAST(N'2020-05-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (54, 2, N'mời phụ huynh', CAST(N'2020-06-04' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoHS] ([ID], [IDHocSinh], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (55, 1, N'3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd3633666625652sdkjnkfnsidnfuisdnfinaisfnaijsnfjinaisndpiansipdnaijsnd', CAST(N'2020-06-25' AS Date), 1)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoHS] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoLop] ON 

INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (18, 38, N'Các Em Đi Học Lại Vào Tháng 6', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (19, 31, N'Thông Báo Từ Nhà Trường : Săp hết hạn đăng kí BHYT ', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (20, 31, N'123456789', CAST(N'2020-04-21' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (21, 38, N'369', CAST(N'2020-05-13' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (23, 39, N'Học sinh dương mời phụ huynh', CAST(N'2020-05-13' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (24, 38, N'12365', CAST(N'2020-05-24' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (25, 38, N'33', CAST(N'2020-05-29' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (26, 31, N'123', CAST(N'2020-05-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (27, 31, N'963', CAST(N'2020-05-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (28, 31, N'36', CAST(N'2020-05-30' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (29, 31, N'3', CAST(N'2020-06-03' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (30, 38, N'Gggh', CAST(N'2020-06-05' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoLop] ([ID], [IDLop], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (31, 32, N'adsdasdsadad', CAST(N'2020-11-11' AS Date), 1)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoLop] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoTruong] ON 

INSERT [nxtckedu_sa].[ThongBaoTruong] ([ID], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (1, N'Toàn Trường ', CAST(N'2020-04-14' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoTruong] ([ID], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (2, N'Các Bạn Được Nghỉ Dịch Covid Đến Hết Tháng 7', CAST(N'2020-04-15' AS Date), 1)
INSERT [nxtckedu_sa].[ThongBaoTruong] ([ID], [NoiDung], [Ngay], [IDLoaiThongBao]) VALUES (9, N'ngay mai duoc nghi', CAST(N'2020-06-25' AS Date), 1)
SET IDENTITY_INSERT [nxtckedu_sa].[ThongBaoTruong] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[ThongTinHS] ON 

INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (1, N'Phong 2', CAST(N'2000-02-01' AS Date), 1, N'Gotham City', N'Human', N'Thiên Chúa Giáo', 31, 1, NULL, NULL, 1, 400)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (2, N'Trường', CAST(N'2000-03-02' AS Date), 1, N'tp hcm', N'kinh', N'Tu la giáo', 31, 1, 1, 2, 1, 6700)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (3, N'Minh Hoàng', CAST(N'1999-06-09' AS Date), 1, N'tp hcm', N'kinh', N'khong', 31, 1, 1, 2, 1, -3100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (6, N'Phan Việt Hoàng', CAST(N'1999-01-08' AS Date), 1, N'TpHCM', N'Kinh', N'Thien Chua Giao', 31, 1, NULL, NULL, NULL, -3100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (7, N'Nguyễn Thị Tú', CAST(N'1997-09-06' AS Date), 0, N'Tiền Giang', N'Kinh', N'Phật Giáo', 31, 1, NULL, NULL, 1, 6800)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (8, N'Trần Công Danh', CAST(N'1997-08-06' AS Date), 1, N'tphcm', N'kinh', N'thien chua giao', 32, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (11, N'Nguyễn Thị Tú', CAST(N'1998-02-03' AS Date), 0, N'Tiền Giang Gò Công', N'kinh', N'thien chua giao', 32, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (12, N'phong 2', CAST(N'2006-06-06' AS Date), 1, N'tphcm', N'kinh', N'Phật Giáo', 32, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (15, N'Trần Công An', CAST(N'1998-12-03' AS Date), 1, N'Nam Định', N'kinh', N'Phật Giáo', 33, 1, NULL, NULL, NULL, -3200)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (28, N'Cao Hoài An', CAST(N'2000-03-05' AS Date), 0, N'TP HCM', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, -3200)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (29, N'Trần Mai Phát', CAST(N'2000-05-09' AS Date), 1, N'Hà Nội', N'Kinh', N'Thiên Chúa Giáo', 33, 1, NULL, NULL, NULL, -3100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (30, N'Nguyễn Văn C', CAST(N'2000-08-06' AS Date), 1, N'Ninh Bình', N'Kinh', N'Phật Giáo', 33, 1, NULL, NULL, NULL, -3100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (31, N'Vũ Hoài An ', CAST(N'2000-06-05' AS Date), 0, N'An Giang', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, -3000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (32, N'Bùi Văn Hến', CAST(N'2000-02-01' AS Date), 1, N'Khánh Hòa', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, -3100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (33, N'Võ Cao Hoài Nhung', CAST(N'2000-08-04' AS Date), 0, N'Gia Lai', N'Kinh', N'Khong', 33, 1, NULL, NULL, NULL, -3100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (97, N'Trần Hoài An ', CAST(N'1999-09-01' AS Date), 1, N'TP Hà Nội', N'Kinh', N'Không', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (98, N'Nguyễn Hoàng Phúc', CAST(N'1999-06-01' AS Date), 1, N'TP Hồ Chí Minh', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (99, N'Hoài Thương ', CAST(N'1999-05-09' AS Date), 0, N'TP Vinh', N'Kinh', N'Phật Giáo ', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (100, N'Cao Quang Lâm ', CAST(N'1999-04-09' AS Date), 1, N'Cà Mau', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (101, N'Võ Hùng Phương Duy', CAST(N'1999-01-01' AS Date), 1, N'Gia Lai', N'Kinh', N'Không', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (102, N'Nguyễn Quế Chi', CAST(N'1999-09-06' AS Date), 0, N'TP Hồ Chí Minh', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, 1000)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (103, N'Trần Cao Phương Mai ', CAST(N'1999-08-05' AS Date), 0, N'Tiền Giang', N'Kinh', N'Không', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (104, N'Võ Lâm Phương Quỳnh', CAST(N'1999-08-08' AS Date), 0, N'Gia Lai', N'Kinh', N'Phật Giáo ', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (105, N'Đào Huỳnh Quang', CAST(N'1999-09-08' AS Date), 1, N'Cần Thơ', N'Kinh', N'Thiên Chúa Giáo', 34, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (106, N'Đào Hoa Mai', CAST(N'1999-01-06' AS Date), 0, N'Tiền Giang', N'Kinh', N'Phật Giáo', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (155, N'Võ Hoàng Phát', CAST(N'1999-04-14' AS Date), 0, N'tphcm', N'kinh', N'thien chua giao', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (156, N'Vũ Hoàng An', CAST(N'2004-02-29' AS Date), 1, N'TP HCM', N'Kinh', N'Thiên Chúa Giáo', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (157, N'Hoài Công Phúc', CAST(N'1999-04-16' AS Date), 1, N'Hà Nội', N'Kinh', N'Thiên Chúa Giáo', 35, 1, NULL, NULL, NULL, 100)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (158, N'Cao Công Danh Thành', CAST(N'1999-06-06' AS Date), 1, N'Hà Nội', N'Kinh', N'Phật Giáo', 31, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (159, N'Vũ Đình Nam Dương', CAST(N'1999-05-13' AS Date), 0, N'Nam Định', N'Khơ Me', N'Không', 31, 3, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (160, N'Vũ Đình Nam Dương', CAST(N'1983-05-11' AS Date), 1, N'Gotham City', N'Batman', N'Hội Thánh Batman Lord (A-wayne)', 39, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (161, N'Hào Phong', CAST(N'1999-01-31' AS Date), 1, N'Hà Nội', N'Kinh', N'Phật Giáo', 38, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (164, N'Nguyễn Ngọc Quế Chi', CAST(N'1999-09-06' AS Date), 0, N'TP Hồ Chí Minh', N'Kinh', N'Thiên Chúa Giáo', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (165, N'Hoàng Thị Cẩm Tú', CAST(N'1969-09-06' AS Date), 1, N'', N'Kinh', N'Thiên Chúa Giáo', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (166, N'Nguyễn Phương Mai ', CAST(N'1999-08-05' AS Date), 0, N'Tiền Giang', N'Kinh', N'Không', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (167, N'Trần Thùy My', CAST(N'1999-04-09' AS Date), 0, N'Cần Thơ', N'Kinh', N'Không', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (168, N'Trần Hoàng Mỹ', CAST(N'1999-09-01' AS Date), 1, N'TP Hà Nội', N'Kinh', N'Không', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (169, N'Huỳnh Hoàng Nam', CAST(N'1999-06-05' AS Date), 1, N'TP Hồ Chí Minh', N'Kinh', N'Phật Giáo ', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (170, N'Cao Quang Lâm Nghĩa', CAST(N'1999-04-09' AS Date), 1, N'Cà Mau', N'Kinh', N'Thiên Chúa Giáo', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (171, N'Nguyễn Thị Trúc Như', CAST(N'1999-07-06' AS Date), 0, N'TP Hồ Chí Minh', N'Kinh', N'Không', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (172, N'Võ Cao Quang', CAST(N'1999-01-01' AS Date), 1, N'Gia Lai', N'Kinh', N'Không', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (173, N'Đỗ Thanh Tâm', CAST(N'1999-08-08' AS Date), 0, N'Gia Lai', N'Kinh', N'Phật Giáo ', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (174, N'Võ Hoài Thương ', CAST(N'1999-05-09' AS Date), 0, N'TP Vinh', N'Kinh', N'Phật Giáo ', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (175, N'Đào Nguyễn Công Vinh', CAST(N'1999-09-08' AS Date), 1, N'Cần Thơ', N'Kinh', N'Thiên Chúa Giáo', 43, 1, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (176, N'Hoang', CAST(N'2020-06-18' AS Date), 1, N'HCM', N'Kinh', N'Không', 31, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (177, N'Nguyễn Ngọc Quế Chi', CAST(N'1999-09-06' AS Date), 0, N'TP Hồ Chí Minh', N'Kinh', N'Thiên Chúa Giáo', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (178, N'Hoàng Thị Cẩm Tú', CAST(N'1969-09-06' AS Date), 1, N'', N'Kinh', N'Thiên Chúa Giáo', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (179, N'Nguyễn Phương Mai ', CAST(N'1999-08-05' AS Date), 0, N'Tiền Giang', N'Kinh', N'Không', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (180, N'Trần Thùy My', CAST(N'1999-04-09' AS Date), 0, N'Cần Thơ', N'Kinh', N'Không', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (181, N'Trần Hoàng Mỹ', CAST(N'1999-09-01' AS Date), 1, N'TP Hà Nội', N'Kinh', N'Không', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (182, N'Huỳnh Hoàng Nam', CAST(N'1999-06-05' AS Date), 1, N'TP Hồ Chí Minh', N'Kinh', N'Phật Giáo ', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (183, N'Cao Quang Lâm Nghĩa', CAST(N'1999-04-09' AS Date), 1, N'Cà Mau', N'Kinh', N'Thiên Chúa Giáo', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (184, N'Nguyễn Thị Trúc Như', CAST(N'1999-07-06' AS Date), 0, N'TP Hồ Chí Minh', N'Kinh', N'Không', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (185, N'Võ Cao Quang', CAST(N'1999-01-01' AS Date), 1, N'Gia Lai', N'Kinh', N'Không', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (186, N'Đỗ Thanh Tâm', CAST(N'1999-08-08' AS Date), 0, N'Gia Lai', N'Kinh', N'Phật Giáo ', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (187, N'Võ Hoài Thương ', CAST(N'1999-05-09' AS Date), 0, N'TP Vinh', N'Kinh', N'Phật Giáo ', 44, 2, NULL, NULL, NULL, NULL)
INSERT [nxtckedu_sa].[ThongTinHS] ([ID], [Ten], [NgaySinh], [GioiTinh], [NoiSinh], [DanToc], [TonGiao], [IDLop], [IDLoaiHocSinh], [HKI], [HKII], [CaNam], [Tien]) VALUES (188, N'Đào Nguyễn Công Vinh', CAST(N'1999-09-08' AS Date), 1, N'Cần Thơ', N'Kinh', N'Thiên Chúa Giáo', 44, 2, NULL, NULL, NULL, NULL)
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
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (34, 5, 1, 1, 20, 500, 100, 300, 150, 50, 200, 200)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (39, 11, 2, 2, 20, 500, 100, 20000, 20, 50, 100, 300)
INSERT [nxtckedu_sa].[TienHocPhi] ([ID], [Thang], [IDLoaiHocSinh], [IDKhoi], [SoNgayHoc], [TienHoc], [TienAn], [TienDien], [TienNuoc], [TienVeSinh], [TienTrangThietBi], [TienTaiLieu]) VALUES (40, 11, 2, 1, 20, 200, 100, 200, 1000, 200, 200, 102)
SET IDENTITY_INSERT [nxtckedu_sa].[TienHocPhi] OFF
SET IDENTITY_INSERT [nxtckedu_sa].[XinPhep] ON 

INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (1, 1, CAST(N'2020-04-13' AS Date), CAST(N'2020-04-13' AS Date), 2, N'Dịch covid-19')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (2, 1, CAST(N'2020-05-14' AS Date), CAST(N'2020-05-18' AS Date), 4, N'Không rõ lý do')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (3, 1, CAST(N'2020-04-15' AS Date), CAST(N'2020-04-17' AS Date), 2, N'tea')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (4, 3, CAST(N'2020-04-23' AS Date), CAST(N'2020-04-25' AS Date), 4, N'về que')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (5, 161, CAST(N'2020-05-10' AS Date), CAST(N'2020-05-30' AS Date), 2, N'Thích Thì Nghỉ')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (6, 161, CAST(N'2020-05-19' AS Date), CAST(N'2020-05-29' AS Date), 3, N'Đi Chơi')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (7, 2, CAST(N'2020-05-19' AS Date), CAST(N'2020-05-29' AS Date), 2, N'CHán')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (9, 2, CAST(N'2020-05-19' AS Date), CAST(N'2020-05-29' AS Date), 3, N'chan đời')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (10, 2, CAST(N'2020-05-19' AS Date), CAST(N'2020-05-29' AS Date), 2, N'Đang nghỉ')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (11, 2, CAST(N'2020-05-19' AS Date), CAST(N'2020-05-22' AS Date), 3, N'ádasd')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (12, 2, CAST(N'2020-05-19' AS Date), CAST(N'2020-05-30' AS Date), 4, N'Em bị 7 TÌnh')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (13, 97, CAST(N'2020-05-20' AS Date), CAST(N'2020-05-21' AS Date), 4, N'Em đg chán dơid')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (14, 6, CAST(N'2020-05-20' AS Date), CAST(N'2020-05-24' AS Date), 4, N'Bùn lắm e ơi')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (15, 2, CAST(N'2020-05-20' AS Date), CAST(N'2020-05-20' AS Date), 4, N'123')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (16, 2, CAST(N'2020-05-20' AS Date), CAST(N'2020-05-21' AS Date), 4, N'253')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (17, 2, CAST(N'2020-05-23' AS Date), CAST(N'2020-05-24' AS Date), 4, N'Bệnh')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (18, 2, CAST(N'2020-05-23' AS Date), CAST(N'2020-05-26' AS Date), 2, N'Bệnh')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (19, 7, CAST(N'2020-05-24' AS Date), CAST(N'2020-06-30' AS Date), 3, N'Thích Nghỉ đó làm sao nào ?')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (20, 6, CAST(N'2020-05-24' AS Date), CAST(N'2020-05-24' AS Date), 4, N'123')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (21, 7, CAST(N'2020-05-21' AS Date), CAST(N'2020-05-31' AS Date), 3, N'1234')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (22, 2, CAST(N'2020-05-27' AS Date), CAST(N'2020-05-28' AS Date), 4, N'Bị đau bụng')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (23, 7, CAST(N'2020-05-31' AS Date), CAST(N'2020-05-31' AS Date), 4, N'1')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (24, 102, CAST(N'2020-02-03' AS Date), CAST(N'2020-09-06' AS Date), 1, N'Nghỉ bệnh')
INSERT [nxtckedu_sa].[XinPhep] ([ID], [IDHocSinh], [NghiTu], [NghiDen], [TrangThai], [LyDo]) VALUES (25, 3, CAST(N'2020-06-20' AS Date), CAST(N'2020-07-30' AS Date), 1, N'nghi hoc')
SET IDENTITY_INSERT [nxtckedu_sa].[XinPhep] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__D5B8C7F044510EDC]    Script Date: 16/11/2020 9:52:54 AM ******/
ALTER TABLE [nxtckedu_sa].[TaiKhoanPH] ADD UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__D5B8C7F0FE4E337B]    Script Date: 16/11/2020 9:52:54 AM ******/
ALTER TABLE [nxtckedu_sa].[TaiKhoanPH] ADD UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__D5B8C7F00B4056E3]    Script Date: 16/11/2020 9:52:54 AM ******/
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong] ADD UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__D5B8C7F01DDDE682]    Script Date: 16/11/2020 9:52:54 AM ******/
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong] ADD UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [nxtckedu_sa].[BangDiem]  WITH CHECK ADD FOREIGN KEY([IDLoaiDiem])
REFERENCES [nxtckedu_sa].[LoaiDiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[BangDiem]  WITH CHECK ADD FOREIGN KEY([IDLoaiDiem])
REFERENCES [nxtckedu_sa].[LoaiDiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK__BangDiem__IDMonH__0BF1ACC7] FOREIGN KEY([IDMonHoc])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[BangDiem] CHECK CONSTRAINT [FK__BangDiem__IDMonH__0BF1ACC7]
GO
ALTER TABLE [nxtckedu_sa].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_ThongTinHS] FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_ThongTinHS]
GO
ALTER TABLE [nxtckedu_sa].[BHYT]  WITH CHECK ADD  CONSTRAINT [FK_BHYT_ThongTinHS] FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[BHYT] CHECK CONSTRAINT [FK_BHYT_ThongTinHS]
GO
ALTER TABLE [nxtckedu_sa].[CupHoc]  WITH CHECK ADD  CONSTRAINT [FK__CupHoc__IDHocSin__0DD9F539] FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[CupHoc] CHECK CONSTRAINT [FK__CupHoc__IDHocSin__0DD9F539]
GO
ALTER TABLE [nxtckedu_sa].[DiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_ThongTinHS] FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[DiemDanh] CHECK CONSTRAINT [FK_DiemDanh_ThongTinHS]
GO
ALTER TABLE [nxtckedu_sa].[DTBMon]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBMon]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBMon]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBMon]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBMon]  WITH CHECK ADD FOREIGN KEY([IDMon])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBMon]  WITH CHECK ADD FOREIGN KEY([IDMon])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBTong]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBTong]  WITH CHECK ADD FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBTong]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[DTBTong]  WITH CHECK ADD FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[HoaDonHocPhi]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonHocPhi_TienHocPhi] FOREIGN KEY([IDHocPhi])
REFERENCES [nxtckedu_sa].[TienHocPhi] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[HoaDonHocPhi] CHECK CONSTRAINT [FK_HoaDonHocPhi_TienHocPhi]
GO
ALTER TABLE [nxtckedu_sa].[LienKetPHvsHS]  WITH CHECK ADD  CONSTRAINT [FK_LienKetPHvsHS_TaiKhoanPH] FOREIGN KEY([IDTaiKhoan])
REFERENCES [nxtckedu_sa].[TaiKhoanPH] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[LienKetPHvsHS] CHECK CONSTRAINT [FK_LienKetPHvsHS_TaiKhoanPH]
GO
ALTER TABLE [nxtckedu_sa].[LienKetPHvsHS]  WITH CHECK ADD  CONSTRAINT [FK_LienKetPHvsHS_ThongTinHS] FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[LienKetPHvsHS] CHECK CONSTRAINT [FK_LienKetPHvsHS_ThongTinHS]
GO
ALTER TABLE [nxtckedu_sa].[Lop]  WITH CHECK ADD  CONSTRAINT [FK__Lop__IDKhoi__11AA861D] FOREIGN KEY([IDKhoi])
REFERENCES [nxtckedu_sa].[Khoi] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[Lop] CHECK CONSTRAINT [FK__Lop__IDKhoi__11AA861D]
GO
ALTER TABLE [nxtckedu_sa].[PhanCongDay]  WITH CHECK ADD FOREIGN KEY([IDGiaoVien])
REFERENCES [nxtckedu_sa].[TaiKhoanTruong] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[PhanCongDay]  WITH CHECK ADD FOREIGN KEY([IDGiaoVien])
REFERENCES [nxtckedu_sa].[TaiKhoanTruong] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[PhanCongDay]  WITH CHECK ADD  CONSTRAINT [FK__PhanCongD__IDLop__1392CE8F] FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[PhanCongDay] CHECK CONSTRAINT [FK__PhanCongD__IDLop__1392CE8F]
GO
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong]  WITH CHECK ADD  CONSTRAINT [FK__TaiKhoanT__IDLop__1486F2C8] FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong] CHECK CONSTRAINT [FK__TaiKhoanT__IDLop__1486F2C8]
GO
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong]  WITH CHECK ADD FOREIGN KEY([IDMonHoc])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[TaiKhoanTruong]  WITH CHECK ADD FOREIGN KEY([IDMonHoc])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK__ThoiKhoaB__IDLop__166F3B3A] FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThoiKhoaBieu] CHECK CONSTRAINT [FK__ThoiKhoaB__IDLop__166F3B3A]
GO
ALTER TABLE [nxtckedu_sa].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK__ThoiKhoaB__IDMon__17635F73] FOREIGN KEY([IDMonHoc])
REFERENCES [nxtckedu_sa].[MonHoc] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThoiKhoaBieu] CHECK CONSTRAINT [FK__ThoiKhoaB__IDMon__17635F73]
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoHS]  WITH CHECK ADD  CONSTRAINT [FK__ThongBaoH__IDHoc__185783AC] FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoHS] CHECK CONSTRAINT [FK__ThongBaoH__IDHoc__185783AC]
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoHS]  WITH CHECK ADD  CONSTRAINT [FK__ThongBaoH__IDLoa__194BA7E5] FOREIGN KEY([IDLoaiThongBao])
REFERENCES [nxtckedu_sa].[LoaiThongBao] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoHS] CHECK CONSTRAINT [FK__ThongBaoH__IDLoa__194BA7E5]
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoLop]  WITH CHECK ADD  CONSTRAINT [FK__ThongBaoL__IDLoa__1A3FCC1E] FOREIGN KEY([IDLoaiThongBao])
REFERENCES [nxtckedu_sa].[LoaiThongBao] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoLop] CHECK CONSTRAINT [FK__ThongBaoL__IDLoa__1A3FCC1E]
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoLop]  WITH CHECK ADD  CONSTRAINT [FK__ThongBaoL__IDLop__1B33F057] FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoLop] CHECK CONSTRAINT [FK__ThongBaoL__IDLop__1B33F057]
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoTruong]  WITH CHECK ADD  CONSTRAINT [FK__ThongBaoT__IDLoa__1C281490] FOREIGN KEY([IDLoaiThongBao])
REFERENCES [nxtckedu_sa].[LoaiThongBao] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongBaoTruong] CHECK CONSTRAINT [FK__ThongBaoT__IDLoa__1C281490]
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([CaNam])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([CaNam])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD  CONSTRAINT [FK__ThongTinH__IDLoa__1E105D02] FOREIGN KEY([IDLoaiHocSinh])
REFERENCES [nxtckedu_sa].[LoaiHocSinh] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS] CHECK CONSTRAINT [FK__ThongTinH__IDLoa__1E105D02]
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD  CONSTRAINT [FK__ThongTinH__IDLop__1F04813B] FOREIGN KEY([IDLop])
REFERENCES [nxtckedu_sa].[Lop] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS] CHECK CONSTRAINT [FK__ThongTinH__IDLop__1F04813B]
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([HKI])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD FOREIGN KEY([HKI])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS]  WITH NOCHECK ADD  CONSTRAINT [FK__ThongTinHS__HKII__20ECC9AD] FOREIGN KEY([HKII])
REFERENCES [nxtckedu_sa].[LoaiHanhKiem] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[ThongTinHS] CHECK CONSTRAINT [FK__ThongTinHS__HKII__20ECC9AD]
GO
ALTER TABLE [nxtckedu_sa].[TienHocPhi]  WITH CHECK ADD  CONSTRAINT [FK__TienHocPh__IDKho__21E0EDE6] FOREIGN KEY([IDKhoi])
REFERENCES [nxtckedu_sa].[Khoi] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[TienHocPhi] CHECK CONSTRAINT [FK__TienHocPh__IDKho__21E0EDE6]
GO
ALTER TABLE [nxtckedu_sa].[TienHocPhi]  WITH CHECK ADD  CONSTRAINT [FK__TienHocPh__IDLoa__22D5121F] FOREIGN KEY([IDLoaiHocSinh])
REFERENCES [nxtckedu_sa].[LoaiHocSinh] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[TienHocPhi] CHECK CONSTRAINT [FK__TienHocPh__IDLoa__22D5121F]
GO
ALTER TABLE [nxtckedu_sa].[XinPhep]  WITH CHECK ADD  CONSTRAINT [FK__XinPhep__IDHocSi__23C93658] FOREIGN KEY([IDHocSinh])
REFERENCES [nxtckedu_sa].[ThongTinHS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [nxtckedu_sa].[XinPhep] CHECK CONSTRAINT [FK__XinPhep__IDHocSi__23C93658]
GO
ALTER TABLE [nxtckedu_sa].[XinPhep]  WITH CHECK ADD FOREIGN KEY([TrangThai])
REFERENCES [nxtckedu_sa].[LoaiTrangThai] ([ID])
GO
ALTER TABLE [nxtckedu_sa].[XinPhep]  WITH CHECK ADD FOREIGN KEY([TrangThai])
REFERENCES [nxtckedu_sa].[LoaiTrangThai] ([ID])
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DangNhapPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DangNhapPH]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DangNhapTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[DangNhapTruong]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM nxtckedu_sa.TaiKhoanTruong WHERE TaiKhoan = @TaiKhoan AND MatKhau = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteBangDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[DeleteBangDiem]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.BangDiem WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteBHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteBHYT]
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_sa.BHYT
    WHERE IDHocSinh = @IDHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteCupHoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteCupHoc]
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteDiemDanh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteDiemDanh]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.DiemDanh
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteHanhKiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteHanhKiem]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.LoaiHanhKiem
	WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteKhoi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteKhoi]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.Khoi
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLienKetPHvsHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteLienKetPHvsHS]
@IDHocSinh INT
AS
BEGIN
    DELETE nxtckedu_sa.LienKetPHvsHS
    WHERE IDHocSinh = @IDHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLoaiDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteLoaiDiem]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiDiem
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLoaiHocSinh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteLoaiHocSinh]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiHocSinh
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLoaiThongBao]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteLoaiThongBao]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.LoaiThongBao
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[DeleteLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteMonhoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteMonhoc]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.MonHoc
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeletePhanCongDay]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeletePhanCongDay]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.PhanCongDay
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteTaiKhoanPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteTaiKhoanPH]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.TaiKhoanPH
    WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteTaiKhoanTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteTaiKhoanTruong]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.TaiKhoanTruong
     WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThoiKhoaBieu]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[DeleteThoiKhoaBieu]
@IDLop INT,
@Thu INT
AS
BEGIN
	DELETE nxtckedu_sa.ThoiKhoaBieu
	WHERE IDLop = @IDLop AND Thu = @Thu
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongBaoHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteThongBaoHS]
@ID INT
AS
BEGIN
	DELETE nxtckedu_sa.ThongBaoHS
     WHERE ID = @ID
	
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongBaoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteThongBaoLop]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.ThongBaoLop
     WHERE ID = @ID

END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongBaoTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteThongBaoTruong]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.ThongBaoTruong
     WHERE ID = @ID
    
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[DeleteThongTinHS]
@ID INT
AS
BEGIN
	DELETE from nxtckedu_sa.BHYT
	where IDHocSinh =  @ID
	DELETE from nxtckedu_sa.ThongTinHS
     WHERE ID = @ID 
	
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteTienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteTienHocPhi]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.TienHocPhi
     WHERE ID = @ID
    
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DeleteXinPhep]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DeleteXinPhep]
@ID INT
AS
BEGIN
    DELETE nxtckedu_sa.XinPhep
     WHERE ID = @ID
    
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[DoiMatKhauPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DoiMatKhauPH]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[DoiMatKhauTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[DoiMatKhauTruong]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[GetNgayNghi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[GetNgayNghi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[GetNgayNghiTrongThang]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[GetNgayNghiTrongThang]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[HuyXinPhep]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[HuyXinPhep]
@ID INT
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
	SET TrangThai = 3
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertBangDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertBangDiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertBHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertBHYT]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertCupHoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertCupHoc]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertDiemDanh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertDiemDanh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertHanhKiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertHanhKiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertKhoi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertKhoi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLienKetPHvsHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertLienKetPHvsHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLoaiDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertLoaiDiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLoaiHocSinh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertLoaiHocSinh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLoaiThongBao]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertLoaiThongBao]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertMonhoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertMonhoc]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertPhanCongDay]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertPhanCongDay]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertQuanLyThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertQuanLyThongTinHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertTaiKhoanPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertTaiKhoanPH]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertTaiKhoanTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertTaiKhoanTruong]
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





/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThoiKhoaBieu]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertThoiKhoaBieu]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongBaoHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertThongBaoHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongBaoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertThongBaoLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongBaoTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertThongBaoTruong]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertThongTinHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertTienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[InsertTienHocPhi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertXinPhep]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertXinPhep]
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@TrangThai int,
@LyDo Nvarchar(1000)
AS
BEGIN
    INSERT nxtckedu_sa.XinPhep
    (
        IDHocSinh,
        NghiTu,
        NghiDen,
        TrangThai,
		LyDo
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - DATE
        @NghiDen, -- NghiDen - DATE
        @TrangThai,         
		@LyDo
        )
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[InsertXinPhepV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[InsertXinPhepV2]
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
        LyDo
    )
    VALUES
    (   @IDHocSinh,         -- IDHocSinh - int
        @NghiTu, -- NghiTu - date
        @NghiDen, -- NghiDen - date
        1,      -- TrangThai - bit       
        @LyDo        -- LyDo - nvarchar(1000)
        )
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[M_LayDTB]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[M_LayDTB]
@IDHocSinh INT,
@IDLop INT
AS
BEGIN
    SELECT HKI,
           HKII,
		   CaNam FROM nxtckedu_sa.DTBTong
		WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[M_LayDTBMon]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[M_LayDTBMon]
@IDHocSinh INT,
@IDLop INT,
@HocKy INT 
AS
BEGIN
	IF @HocKy = 1
	BEGIN
	    SELECT M.TenMon, D.HKI AS Diem FROM nxtckedu_sa.DTBMon AS D
		JOIN nxtckedu_sa.MonHoc AS M
		ON M.ID = D.IDMon
		WHERE d.IDHocSinh = @IDHocSinh AND D.IDLop = @IDLop
	END
	ELSE
	IF @HocKy = 2
	BEGIN
	    SELECT M.TenMon, D.HKII AS Diem FROM nxtckedu_sa.DTBMon AS D
		JOIN nxtckedu_sa.MonHoc AS M
		ON M.ID = D.IDMon
		WHERE d.IDHocSinh = @IDHocSinh AND D.IDLop = @IDLop
	END
	ELSE
	BEGIN
	    SELECT M.TenMon, D.CaNam AS Diem FROM nxtckedu_sa.DTBMon AS D
		JOIN nxtckedu_sa.MonHoc AS M
		ON M.ID = D.IDMon
		WHERE d.IDHocSinh = @IDHocSinh AND D.IDLop = @IDLop
	END
    
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[m_SelectThoiKhoaBieu]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[m_SelectThoiKhoaBieu]
@IDLop INT
AS
BEGIN
    SELECT Thu, Tiet, TenMon FROM nxtckedu_sa.ThoiKhoaBieu
	JOIN nxtckedu_sa.MonHoc
	ON MonHoc.ID = ThoiKhoaBieu.IDMonHoc
	WHERE IDLop = @IDLop
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[M_UpdateBHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[M_UpdateBHYT]
@IDHocSinh INT,
@BHYT BIT,
@DK BIT
AS
BEGIN
    IF @DK = 1
	BEGIN
	    IF @BHYT = 1
		BEGIN
		    UPDATE nxtckedu_sa.BHYT SET DangKy = 1 WHERE IDHocSinh = @IDHocSinh
		END
		ELSE
		BEGIN
		    UPDATE nxtckedu_sa.BHYT SET BHQD = 1 WHERE IDHocSinh = @IDHocSinh
		END
	END
	ELSE
	BEGIN
	    IF @BHYT = 1
		BEGIN
		    UPDATE nxtckedu_sa.BHYT SET DangKy = 0 WHERE IDHocSinh = @IDHocSinh
		END
		ELSE
		BEGIN
		    UPDATE nxtckedu_sa.BHYT SET BHQD = 0 WHERE IDHocSinh = @IDHocSinh
		END
	END
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBangDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectBangDiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBangDiemByHocSinh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectBangDiemByHocSinh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBangDiemv2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectBangDiemv2]
@IDHocSinh INT 
AS
BEGIN
	SELECT B.IDLoaiDiem,
           B.IDMonHoc,
           B.CotDiem,
           L.TenLoaiDiem,
           B.HocKyI,
           B.Diem FROM nxtckedu_sa.BangDiem AS B
	JOIN nxtckedu_sa.LoaiDiem AS L
	ON L.ID = B.IDLoaiDiem
	WHERE IDHocSinh = @IDHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectBHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectBHYT]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectChiTiepDiemDanh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectChiTiepDiemDanh]
@IDHocSinh INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.DiemDanh WHERE IDHocSinh = @IDHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectChiTietDD]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectChiTietDD]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectChiTietTienHoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectChiTietTienHoc]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectChiTietTienHocV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [nxtckedu_sa].[SelectChiTietTienHocV2]
@Thang INT,
@IDLoaiHocSinh INT

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
	WHERE Thang = @Thang AND IDLoaiHocSinh = @IDLoaiHocSinh 
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectCupHoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectCupHoc]
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectDiemDanh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectDiemDanh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectFunctionOrder]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectFunctionOrder]
AS
BEGIN
    SELECT * FROM FunctionOrder
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHanhKiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectHanhKiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHocPhiTheoIDHS_Thang]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectHocPhiTheoIDHS_Thang]
@ID INT,
@Thang int

AS
BEGIN
    SELECT TP.Thang,TP.IDLoaiHocSinh,SoNgayHoc,TienHoc,TienAn,TienDien,TienNuoc,TienVeSinh,TienTrangThietBi,TienTaiLieu,TT.Tien
	FROM nxtckedu_sa.ThongTinHS TT
	inner join nxtckedu_sa.LoaiHocSinh L 
	on TT.IDLoaiHocSinh = L.ID inner join nxtckedu_sa.TienHocPhi TP 
	on L.ID = TP.IDLoaiHocSinh
	WHERE TT.ID = @ID and @Thang = Thang
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHocPhiTheoKhoi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectHocPhiTheoKhoi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectHocSinhTrongLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectHocSinhTrongLop]
@IDLop INT
AS
BEGIN
    SELECT Ten,NgaySinh FROM nxtckedu_sa.ThongTinHS WHERE IDLop = @IDLop
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectKhoi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectKhoi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLayHSQuanLy]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectLayHSQuanLy]
@IDTaiKhoan INT
AS
BEGIN
	SELECT * FROM nxtckedu_sa.LienKetPHvsHS WHERE IDTaiKhoan = @IDTaiKhoan
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLienKetPHvsHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectLienKetPHvsHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectListThongBaoHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectListThongBaoHS]
@IDHocSinh INT
AS
BEGIN
    SELECT ThongBaoHS.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoHS 
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = ThongBaoHS.IDLoaiThongBao
	WHERE IDHocSinh = @IDHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectListThongBaoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectListThongBaoLop]
@IDLop INT
AS
BEGIN
    SELECT ThongBaoLop.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoLop 
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = ThongBaoLop.IDLoaiThongBao WHERE IDLop = @IDLop
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectListThongBaoTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectListThongBaoTruong]
AS
BEGIN
    SELECT ThongBaoTruong.ID,Ngay,TenThongBao FROM nxtckedu_sa.ThongBaoTruong
	JOIN nxtckedu_sa.LoaiThongBao ON LoaiThongBao.ID = nxtckedu_sa.ThongBaoTruong.IDLoaiThongBao
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLoaiDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectLoaiDiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLoaiHocSinh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectLoaiHocSinh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLoaiThongBao]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectLoaiThongBao]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectMonhoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectMonhoc]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.MonHoc WHERE ID <> -1 and id!=12
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.MonHoc WHERE ID = @ID AND ID <> -1 
	END
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectMonhocv2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectMonhocv2]
AS
BEGIN
	SELECT ID,TenMon,LoaiDiem FROM nxtckedu_sa.MonHoc WHERE CoDiem = 1
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectNoiDungThongBaoHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectNoiDungThongBaoHS]
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoHS WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectNoiDungThongBaoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectNoiDungThongBaoLop]
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoLop WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectNoiDungThongBaoTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectNoiDungThongBaoTruong]
@ID INT
AS
BEGIN
    SELECT * FROM nxtckedu_sa.ThongBaoTruong WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectPhanCongDay]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectPhanCongDay]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectTaiKhoanPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectTaiKhoanPH]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectTaiKhoanTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectTaiKhoanTruong]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThoiKhoaBieu]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectThoiKhoaBieu]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectThongBaoHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoHSV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectThongBaoHSV2]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectThongBaoLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoLopV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectThongBaoLopV2]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongBaoTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectThongBaoTruong]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongTinGV]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectThongTinGV]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectThongTinHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectThongTinHSv2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectThongTinHSv2]
@ID INT	
AS
BEGIN
	SELECT * FROM nxtckedu_sa.ThongTinHS_View_M
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectTienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[SelectTienHocPhi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectXinPhep]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectXinPhep]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.XinPhep
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.XinPhep_View WHERE ID = @ID
	END
    
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectXinPhep2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectXinPhep2]
@ID INT
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT * FROM nxtckedu_sa.XinPhep
	END
	ELSE
	BEGIN    
		SELECT * FROM nxtckedu_sa.XinPhep WHERE IDHocSinh = @ID
	END
    
END
GO
/****** Object:  StoredProcedure [nxtckedu_sa].[SelectXinPhepTheoIDHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[SelectXinPhepTheoIDHS]
@IDHocSinh INT
AS
BEGIN
    SELECT X.ID,
           X.IDHocSinh,
           X.LyDo,
           X.NghiDen,
           X.NghiTu,
           L.TenTrangThai FROM nxtckedu_sa.XinPhep AS X
	JOIN nxtckedu_sa.LoaiTrangThai AS L
	ON L.ID = X.TrangThai
	WHERE IDHocSinh = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateBangDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateBangDiem]
@ID INT,
@IDHocSinh INT,
@IDMonHoc INT,
@IDLoaiDiem INT,
@CotDiem INT,
@Diem FLOAT,
@HocKyI BIT	
AS
BEGIN
    UPDATE nxtckedu_sa.BangDiem
    SET	IDHocSinh = @IDHocSinh,
		IDMonHoc = @IDMonHoc,
		IDLoaiDiem = @IDLoaiDiem,
		CotDiem = @CotDiem,
		Diem = @Diem,
		HocKyI = @HocKyI
	WHERE ID = @ID
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateBHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateBHYT]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateCupHoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateCupHoc]
@IDHocSinh INT,
@Ngay DATE,
@Tiet INT
AS
BEGIN
    PRINT 'GiaiDoanNayChuaHoatDong'
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateDiemDanh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateDiemDanh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateHanhKiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateHanhKiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateKhoi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateKhoi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLienKetPHvsHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateLienKetPHvsHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLoaiDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateLoaiDiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLoaiHocSinh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateLoaiHocSinh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLoaiThongBao]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateLoaiThongBao]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateMonhoc]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateMonhoc]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdatePhanCongDay]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdatePhanCongDay]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateQuanLyThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateQuanLyThongTinHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateTaiKhoanPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateTaiKhoanPH]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateTaiKhoanTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateTaiKhoanTruong]
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

CREATE PROCEDURE [nxtckedu_sa].[UpdateTrangThaiTKTruong]

@TaiKhoan NVARCHAR(100),
@TrangThai bit
AS
BEGIN
	UPDATE nxtckedu_sa.TaiKhoanTruong
	SET   
	    TrangThai = @TrangThai
     WHERE TaiKhoan = @TaiKhoan
END



GO



CREATE PROCEDURE [nxtckedu_sa].[W_SelectTrangThaiTKTruong]

AS
BEGIN
	select TrangThai
	from nxtckedu_sa.TaiKhoanTruong
	where TrangThai = 1
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThoiKhoaBieu]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateThoiKhoaBieu]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongBaoHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateThongBaoHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongBaoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateThongBaoLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongBaoTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateThongBaoTruong]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateThongTinHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateTienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[UpdateTienHocPhi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateXinPhep]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateXinPhep]
@ID INT,
@IDHocSinh INT,
@NghiTu DATE,
@NghiDen DATE,
@TrangThai int

AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
    SET
        IDHocSinh = @IDHocSinh,
        NghiTu = @NghiTu,
        NghiDen = @NghiDen,
        TrangThai = @TrangThai
     WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[UpdateXinPhepV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[UpdateXinPhepV2]
@ID INT,
@NghiTu DATE,
@NghiDen DATE,
@LyDo NVARCHAR(1000)
AS
BEGIN
    UPDATE nxtckedu_sa.XinPhep
	SET NghiTu = @NghiTu,
        NghiDen = @NghiDen,
        TrangThai = 1,
        LyDo = @LyDo
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_BangDiemByIdHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_BangDiemByIdHS]
@IDHocSinh INT,
@HocKy bit
AS
BEGIN
	select mh.TenMon,mh.LoaiDiem,dm1.Diem as [DM1],dm2.Diem as [DM2],dm3.Diem as [DM3],dm4.Diem as [DM4],dm5.Diem as [DM5]
	,_15p_1.Diem as [15p_1],_15p_2.Diem as [15p_2],_15p_3.Diem as [15p_3],_15p_4.Diem as [15p_4],_15p_5.Diem as [15p_5]
	,_1t_1.Diem as [1t_1],_1t_2.Diem as [1t_2],_1t_3.Diem as [1t_3],_1t_4.Diem as [1t_4],_1t_5.Diem as [1t_5],HocKy.Diem as [HocKy]
	,TBM.HKI as[HK1] ,TBM.HKII as[HK2]
	from nxtckedu_sa.MonHoc as mh
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 1 and CotDiem = 1 and HocKyI = @HocKy) dm1 on mh.ID = dm1.IDMonHoc 
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 1 and CotDiem = 2 and HocKyI = @HocKy) dm2 on mh.ID = dm2.IDMonHoc 
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 1 and CotDiem = 3 and HocKyI = @HocKy) dm3 on mh.ID = dm3.IDMonHoc 
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 1 and CotDiem = 4 and HocKyI = @HocKy) dm4 on mh.ID = dm4.IDMonHoc 
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 1 and CotDiem = 5 and HocKyI = @HocKy) dm5 on mh.ID = dm5.IDMonHoc

	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 2 and CotDiem = 1 and HocKyI = @HocKy) _15p_1 on mh.ID = _15p_1.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 2 and CotDiem = 2 and HocKyI = @HocKy) _15p_2 on mh.ID = _15p_2.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 2 and CotDiem = 3 and HocKyI = @HocKy) _15p_3 on mh.ID = _15p_3.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 2 and CotDiem = 4 and HocKyI = @HocKy) _15p_4 on mh.ID = _15p_4.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 2 and CotDiem = 5 and HocKyI = @HocKy) _15p_5 on mh.ID = _15p_5.IDMonHoc

	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 3 and CotDiem = 1 and HocKyI = @HocKy) _1t_1 on mh.ID = _1t_1.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 3 and CotDiem = 2 and HocKyI = @HocKy) _1t_2 on mh.ID = _1t_2.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 3 and CotDiem = 3 and HocKyI = @HocKy) _1t_3 on mh.ID = _1t_3.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 3 and CotDiem = 4 and HocKyI = @HocKy) _1t_4 on mh.ID = _1t_4.IDMonHoc
	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 3 and CotDiem = 5 and HocKyI = @HocKy) _1t_5 on mh.ID = _1t_5.IDMonHoc

	Full outer join (select Diem,IDMonHoc from nxtckedu_sa.BangDiem where IDHocSinh = @IDHocSinh and IDLoaiDiem = 4 and CotDiem = 1 and HocKyI = @HocKy) HocKy on mh.ID = HocKy.IDMonHoc

	Full outer join (select HKI,HKII,IDMon from nxtckedu_sa.DTBMon where IDHocSinh = @IDHocSinh) TBM on mh.ID = TBM.IDMon
	where mh.ID != -1 and mh.ID != 12 and mh.ID != 15 and mh.ID != 18 
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_InsertHoaDonHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [nxtckedu_sa].[W_InsertHoaDonHocPhi]
@IDHocPhi int,
@IDHocSinh INT,
@NgayTao DATETIME,
@ThanhToan BIT
AS
BEGIN
    INSERT HoaDonHocPhi
    (
		IDHocPhi,
        IDHocSinh,
        NgayTao,
        ThanhToan
    )
    VALUES
    (   @IDHocPhi,
        @IDHocSinh,
        @NgayTao,
        @ThanhToan
        )
	SELECT SCOPE_IDENTITY() as [ID]
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectBangDiem_Full]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectBangDiem_Full]
@IDLop INT,
@IDMon Int,
@HocKy bit
AS
BEGIN
	select A.Ten,B.Diem as [DM1],C.Diem as[DM2],D.Diem as[DM3],E.Diem as[DM4],F.Diem as[DM5],G.Diem as[15p_1]
	,H.Diem as[15p_2],I.Diem as[15p_3],J.Diem as[15p_4],K.Diem as[15p_5]
	,L.Diem as[1t_1],M.Diem as[1t_2],N.Diem as[1t_3],O.Diem as[1t_4],P.Diem as[1t_5],Q.Diem as[HocKy]
	,W.HKI as[HK1],W.HKII as[HK2]
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

	
	FULL OUTER JOIN nxtckedu_sa.DTBMon as W
	on A.ID=W.IDHocSinh and W.IDMon = @IDMon
	
	where A.IDLop = @IDLop
END




GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectBangDiem_TongKet]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectBangDiem_TongKet]
@IDHocSinh int
AS
BEGIN
	
	select tt.id,hanhkiem.id as [IDHanhKiem],hanhkiem.TenHanhKiem,DTB.CaNam,DTB.HKI,DTB.HKII
	from nxtckedu_sa.ThongTinHS as tt
	full outer join nxtckedu_sa.LoaiHanhKiem as hanhkiem on tt.canam = hanhkiem.id
	full outer join nxtckedu_sa.DTBTong as DTB on tt.id = DTB.IDHocSinh
	where tt.id = @IDHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectBangDiem_V2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectBangDiem_V2]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectDanhSachLopChuNhiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectDanhSachLopChuNhiem]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectDiemDanhByIDHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectDiemDanhByIDHS]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectFunctionOrder_BHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [nxtckedu_sa].[W_SelectFunctionOrder_BHYT]
AS
BEGIN
    SELECT * FROM FunctionOrder
	where ID = 1
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectHocPhi_ThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectHocPhi_ThongTinHS]
@IDHocSinh INT

AS
BEGIN
    SELECT TT.IDLoaiHocSinh,L.IDKhoi
	FROM ThongTinHS TT
	inner join Lop as L
	on TT.IDLop = L.ID	
	where TT.ID = @IDHocSinh
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectHocPhiNo]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectHocPhiNo]
@IDHS INT

AS
BEGIN
    SELECT TT.Tien
	from ThongTinHS TT
	where TT.ID = @IDHS
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectLienKetPHvsHS_ByIdLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectLienKetPHvsHS_ByIdLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectLopTheoKhoi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectLopTheoKhoi]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectLopTheoKhoi_LayTen]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectLopTheoKhoi_LayTen]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectPhanCongDay_ByIdGv]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectPhanCongDay_ByIdGv]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectPhanCongDay_TTGVBM]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[W_SelectPhanCongDay_TTGVBM]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectPhanCongDayV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectPhanCongDayV2]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanPH_Check]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanPH_Check]
@TaiKhoan Varchar(100)
AS
BEGIN
	SELECT Count(*) FROM nxtckedu_sa.TaiKhoanPH
	where TaiKhoan = @TaiKhoan
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanPH_Search]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanPH_Search]
@TaiKhoan Varchar(100)
AS
BEGIN
		SELECT * FROM nxtckedu_sa.TaiKhoanPH WHERE TaiKhoan Like '%' + @TaiKhoan +'%'
END




GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanTruong_ByIdMon]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanTruong_ByIdMon]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanTruong_Check]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectTaiKhoanTruong_Check]
@TaiKhoan Varchar(100)
AS
BEGIN
	SELECT Count(*) FROM nxtckedu_sa.TaiKhoanTruong
	where TaiKhoan = @TaiKhoan
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTaiKhoanTruongV2]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThoiKhoaBieu_ByIdHs]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectThoiKhoaBieu_ByIdHs]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThoiKhoaBieuV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectThoiKhoaBieuV2]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongBaoHSV2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectThongBaoHSV2]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongTinHS_Notification]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectThongTinHS_Notification]
@ID INT
AS
BEGIN
	IF @ID = -1
	BEGIN
	    SELECT A.*,ph.TaiKhoan FROM nxtckedu_sa.ThongTinHS as A
		full outer join (
		select B.IDHocSinh,C.TaiKhoan
		from nxtckedu_sa.LienKetPHvsHS as B 
		full outer join nxtckedu_sa.TaiKhoanPH as C on B.IDTaiKhoan = C.ID
		) as ph on A.ID =ph.IDHocSinh
	END
	ELSE
	BEGIN    
		SELECT A.*,ph.TaiKhoan FROM nxtckedu_sa.ThongTinHS as A
		full outer join (
		select B.IDHocSinh,C.TaiKhoan
		from nxtckedu_sa.LienKetPHvsHS as B 
		full outer join nxtckedu_sa.TaiKhoanPH as C on B.IDTaiKhoan = C.ID
		) as ph on A.ID = ph.IDHocSinh
		WHERE A.ID = @ID
	END
	
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongTinHSTheoLop]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectThongTinHSTheoLop]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongTinHSTheoLop_Notification]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectThongTinHSTheoLop_Notification]
@IDLop INT
AS
BEGIN
	IF @IDLop = -1
	BEGIN
	    SELECT A.*,ph.TaiKhoan FROM nxtckedu_sa.ThongTinHS as A
		full outer join (
		select B.IDHocSinh,C.TaiKhoan
		from nxtckedu_sa.LienKetPHvsHS as B 
		full outer join nxtckedu_sa.TaiKhoanPH as C on B.IDTaiKhoan = C.ID
		) as ph on A.ID =ph.IDHocSinh
	END
	ELSE
	BEGIN    
		SELECT A.*,ph.TaiKhoan FROM nxtckedu_sa.ThongTinHS as A
		full outer join (
		select B.IDHocSinh,C.TaiKhoan
		from nxtckedu_sa.LienKetPHvsHS as B 
		full outer join nxtckedu_sa.TaiKhoanPH as C on B.IDTaiKhoan = C.ID
		) as ph on A.ID =ph.IDHocSinh
		WHERE A.IDLop = @IDLop
	END
	
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectThongTinLienKetPHvsHS_ByIdPh]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectThongTinLienKetPHvsHS_ByIdPh]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTongHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectTongHocPhi]
@Thang int,
@IDKhoi int,
@IDLoaiHocSinh int
AS
BEGIN
    SELECT TienHoc + TienAn+TienDien+TienNuoc+TienVesinh+TienTrangThietBi+TienTaiLieu as[Tong],ID
	from TienHocPhi 
	where Thang= @Thang and IDKhoi = @IDKhoi and IDLoaiHocSinh = @IDLoaiHocSinh
END


GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectTTHS_ByIDPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectTTHS_ByIDPH]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectXinPhep_DSDaDuyet]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [nxtckedu_sa].[W_SelectXinPhep_DSDaDuyet]
@ID INT,
@IDLop int
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT A.*,B.Ten as [TenHS] FROM nxtckedu_sa.XinPhep as A
		join nxtckedu_sa.ThongTinHS as B 
		on A.IDHocSinh = B.ID where B.IDLop = @IDLop and A.TrangThai != 1 and A.TrangThai != 4
	END
	ELSE
	BEGIN    
		SELECT A.*,B.Ten as [TenHS] FROM nxtckedu_sa.XinPhep as A
		join nxtckedu_sa.ThongTinHS as B 
		on A.IDHocSinh = B.ID  WHERE A.ID = @ID and B.IDLop = @IDLop and A.TrangThai != 1 and A.TrangThai != 4
	END
   
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectXinPhep_DuyetDon]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [nxtckedu_sa].[W_SelectXinPhep_DuyetDon]
@ID INT,
@TrangThai int
AS
BEGIN
	UPDATE nxtckedu_sa.XinPhep
    SET
        TrangThai = @TrangThai
     WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_SelectXinPhep_V2]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_SelectXinPhep_V2]
@ID INT,
@IDLop int,
@TrangThai int
AS
BEGIN
    IF @ID = -1
	BEGIN
	    SELECT A.*,B.Ten as [TenHS] FROM nxtckedu_sa.XinPhep as A
		join nxtckedu_sa.ThongTinHS as B 
		on A.IDHocSinh = B.ID where B.IDLop = @IDLop and A.TrangThai = @TrangThai
	END
	ELSE
	BEGIN    
		SELECT A.*,B.Ten as [TenHS] FROM nxtckedu_sa.XinPhep as A
		join nxtckedu_sa.ThongTinHS as B 
		on A.IDHocSinh = B.ID  WHERE A.ID = @ID and B.IDLop = @IDLop and A.TrangThai = @TrangThai
	END
   
END

GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateFunctionOrder_BHYT]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [nxtckedu_sa].[W_UpdateFunctionOrder_BHYT]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateResetPassTaiKhoanPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_UpdateResetPassTaiKhoanPH]
@ID INT
AS
BEGIN
	UPDATE nxtckedu_sa.TaiKhoanPH
	SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', TaiKhoan), 2	)
     WHERE ID = @ID
END



GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateResetPassTaiKhoanTruong]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_UpdateResetPassTaiKhoanTruong]
@ID INT
AS
BEGIN
	UPDATE nxtckedu_sa.TaiKhoanTruong
	SET MatKhau = CONVERT(VARCHAR(32), HASHBYTES('MD5', TaiKhoan), 2	)
     WHERE ID = @ID
END




GO
/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateTaiKhoanPH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [nxtckedu_sa].[W_UpdateTaiKhoanPH]
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
/****** Object:  StoredProcedure [nxtckedu_sa].[W_UpdateThongTinHS_PH]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [nxtckedu_sa].[W_UpdateThongTinHS_PH]
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
/****** Object:  Trigger [nxtckedu_sa].[trg_InsertDiem]    Script Date: 16/11/2020 9:52:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [nxtckedu_sa].[trg_InsertDiem]
ON [nxtckedu_sa].[BangDiem]
FOR INSERT,UPDATE
AS
BEGIN
	IF ((SELECT Inserted.CotDiem FROM Inserted) > (SELECT TongCot FROM nxtckedu_sa.LoaiDiem WHERE ID = (SELECT Inserted.IDLoaiDiem FROM Inserted)))
	BEGIN
	    PRINT N'Vượt quá giới hạn số cột của loai điểm'
		ROLLBACK
	END
	DECLARE @Diem INT = (SELECT Inserted.Diem FROM Inserted)
    IF (@Diem <0.0 AND @Diem > 10.0)
	BEGIN
	    PRINT N'Nhập diểm nhỏ hơn 0 học 10 khôn được'
		ROLLBACK
	END
	ELSE
	BEGIN
	    IF((SELECT COUNT(*) FROM nxtckedu_sa.BangDiem 
		WHERE IDHocSinh = (SELECT Inserted.IDHocSinh FROM Inserted) 
		AND IDMonHoc = (SELECT Inserted.IDMonHoc FROM Inserted)
		AND IDLoaiDiem = (SELECT Inserted.IDLoaiDiem FROM Inserted)
		AND CotDiem = (SELECT Inserted.CotDiem FROM Inserted)
		AND HocKyI = (SELECT Inserted.HocKyI FROM Inserted)) = 2)
		BEGIN
		    PRINT N'Đã có cột này không thể thêm, chỉ có thể sửa'
			ROLLBACK
		END
		ELSE
		BEGIN
		    DECLARE @IDHocSinh INT = (SELECT Inserted.IDHocSinh FROM Inserted)
			DECLARE @IDMonHoc INT = (SELECT Inserted.IDMonHoc FROM Inserted)
			DECLARE @HKI BIT = (SELECT Inserted.HocKyI FROM Inserted)
			DECLARE @IDLop INT = (SELECT IDLop FROM nxtckedu_sa.ThongTinHS WHERE ID = @IDHocSinh)
			DECLARE @Count INT = 0
			DECLARE @Loop INT
			DECLARE @Point FLOAT = 0.0
			DECLARE @TablePoint TABLE(IDLoaiDiem INT, HocKyI BIT, Diem FLOAT, HeSo INT)

			INSERT INTO @TablePoint
			SELECT D.IDLoaiDiem,
                   D.HocKyI,
                   D.Diem,
                   L.HeSo FROM nxtckedu_sa.BangDiem AS D
			JOIN nxtckedu_sa.LoaiDiem AS L
			ON L.ID = D.IDLoaiDiem
			WHERE D.IDHocSinh = @IDHocSinh AND D.IDMonHoc = @IDMonHoc

			DECLARE @P FLOAT = (SELECT SUM(Diem * HeSo) FROM @TablePoint WHERE HocKyI = @HKI)
			DECLARE @C INT = (SELECT SUM(HeSo) FROM @TablePoint WHERE  HocKyI = @HKI)
			IF @P <> 0
				BEGIN
				    SET @Point = @Point + @P
				END
			IF @C <> 0
				BEGIN
				    SET @Count = @Count + @C
				END
			
			-- Input AGV to Table DTBMon
			IF ((SELECT COUNT(*) FROM nxtckedu_sa.DTBMon 
			WHERE IDHocSinh = @IDHocSinh
			AND IDMon = @IDMonHoc
			AND IDLop = @IDLop) = 1)
			BEGIN
				IF(@HKI = 1)
			    BEGIN
			        UPDATE nxtckedu_sa.DTBMon 
					SET HKI = @Point / @Count
					WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop
			    END 
				ELSE
				BEGIN
			        UPDATE nxtckedu_sa.DTBMon 
					SET HKII = @Point / @Count
					WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop
				END
			END
			ELSE
			BEGIN
				IF(@HKI = 1)
				BEGIN
				    INSERT nxtckedu_sa.DTBMon
					(
						IDHocSinh,
						IDMon,
						IDLop,
						HKI,
						HKII,
						CaNam
					)
					VALUES
				    (   @IDHocSinh,   -- IDHocSinh - int
					    @IDMonHoc,   -- IDMon - int
				        @IDLop,  
					    @Point / @Count, -- HKI - float
					    0.0, -- HKII - float
					    0.0  -- CaNam - float
					    )
				END
				ELSE
				BEGIN
				    INSERT nxtckedu_sa.DTBMon
					(
						IDHocSinh,
						IDMon,
						IDLop,
						HKI,
						HKII,
						CaNam
					)
					VALUES
				    (   @IDHocSinh,   -- IDHocSinh - int
					    @IDMonHoc,   -- IDMon - int
				        @IDLop,  
					    0.0, -- HKI - float
					    @Point / @Count, -- HKII - float
					    0.0  -- CaNam - float
					    )
				END
			END

			UPDATE nxtckedu_sa.DTBMon 
					SET CaNam = ((SELECT HKI FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop) + (SELECT HKII FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop) * 2) / 3
					WHERE IDHocSinh = @IDHocSinh AND IDMon = @IDMonHoc AND IDLop = @IDLop

			--Get count Subject
			SET @Count = (SELECT COUNT(*) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop)

			-- Sum Point AGV
			IF((SELECT COUNT(*) FROM nxtckedu_sa.DTBTong 
			WHERE IDHocSinh = @IDHocSinh
			AND IDLop = @IDLop) = 1)
			BEGIN
			    UPDATE nxtckedu_sa.DTBTong 
				SET HKI = (SELECT SUM(HKI) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count,
				HKII = (SELECT SUM(HKII) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count,
				CaNam = (SELECT SUM(CaNam) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count
				WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop
			END
			ELSE
			BEGIN
			    INSERT nxtckedu_sa.DTBTong
			    (
			        IDHocSinh,
			        IDLop,
			        HKI,
			        HKII,
			        CaNam
			    )
			    VALUES
			    (   @IDHocSinh,   -- IDHocSinh - int
			        @IDLop,  
			        (SELECT SUM(HKI) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count, -- HKI - float
			        (SELECT SUM(HKII) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count, -- HKII - float
			        (SELECT SUM(CaNam) FROM nxtckedu_sa.DTBMon WHERE IDHocSinh = @IDHocSinh AND IDLop = @IDLop) / @Count  -- CaNam - float
			        )
			END
			
		END
	END
END

GO
/****** Object:  Trigger [nxtckedu_sa].[trg_InsertLop]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Trigger [nxtckedu_sa].[trg_InsertThongTinHS]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Trigger [nxtckedu_sa].[trg_DeleteTienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Trigger [nxtckedu_sa].[trg_InsertTienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
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
/****** Object:  Trigger [nxtckedu_sa].[trg_UpdateTienHocPhi]    Script Date: 16/11/2020 9:52:54 AM ******/
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
