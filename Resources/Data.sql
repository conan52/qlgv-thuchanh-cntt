USE [master]
GO
/****** Object:  Database [ThucHanhCNTT]    Script Date: 04/27/2014 15:28:34 ******/
CREATE DATABASE [ThucHanhCNTT] 
GO
ALTER DATABASE [ThucHanhCNTT] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ThucHanhCNTT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ThucHanhCNTT] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET ARITHABORT OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ThucHanhCNTT] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ThucHanhCNTT] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ThucHanhCNTT] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET  ENABLE_BROKER
GO
ALTER DATABASE [ThucHanhCNTT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ThucHanhCNTT] SET READ_COMMITTED_SNAPSHOT ON
GO
ALTER DATABASE [ThucHanhCNTT] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ThucHanhCNTT] SET  READ_WRITE
GO
ALTER DATABASE [ThucHanhCNTT] SET RECOVERY FULL
GO
ALTER DATABASE [ThucHanhCNTT] SET  MULTI_USER
GO
ALTER DATABASE [ThucHanhCNTT] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ThucHanhCNTT] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'ThucHanhCNTT', N'ON'
GO
USE [ThucHanhCNTT]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MonHocId] [int] IDENTITY(1,1) NOT NULL,
	[MaMonHoc] [nvarchar](max) NOT NULL,
	[TenMonHoc] [nvarchar](max) NOT NULL,
	[SoTinChi] [int] NOT NULL,
	[BatBuoc] [bit] NOT NULL,
	[TrinhDo] [int] NOT NULL,
	[ChuyenNganh] [int] NOT NULL,
 CONSTRAINT [PK_dbo.MonHoc] PRIMARY KEY CLUSTERED 
(
	[MonHocId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MonHoc] ON
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (1, N'CT2103', N'Lập trình cấu trúc với C/C', 5, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (2, N'CT2106', N'Kiến trúc và tổ chức máy tính', 4, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (3, N'CT2129', N'Internet và các dịch vụ', 3, 0, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (4, N'CT2309', N'Chuyên đề 1 (KTPM - Các phương pháp khai thác dữ liệu)', 3, 0, 2, 1)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (5, N'TN1111', N'Toán cao cấp B2', 5, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (6, N'TN1115', N'Xác suất thống kê', 3, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (7, N'CT0002', N'Kỹ năng máy tính', 3, 0, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (8, N'CT0003', N'Lập trình cấu trúc với C/C', 5, 1, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (9, N'CT0006', N'Kiến trúc và tổ chức máy tính', 4, 1, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (10, N'CT0029', N'Internet và các dịch vụ', 3, 0, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (11, N'CT0015', N'Photoshop', 4, 0, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (12, N'CT0010', N'Công cụ&môi trường LT1', 3, 0, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (13, N'CT0011', N'Cơ sở dữ liệu', 4, 1, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (14, N'CT0012', N'Hệ Điều Hành', 4, 1, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (15, N'VL0113', N'Vật lý đại cương D (cao đẳng)', 4, 1, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (16, N'CT0024', N'Chuyên đề 1 (Cao đẳng)', 3, 0, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (17, N'CT2107', N'CTDL và thuật giải 2', 4, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (18, N'CT2109', N'Lập trình Hướng đối tượng', 4, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (19, N'CT2112', N'Hệ điều hành', 4, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (20, N'CT2113', N'Công nghệ phần mềm', 4, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (21, N'CT2119', N'Trí tuệ nhân tạo', 4, 1, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (22, N'CT2120', N'Lập trình mạng', 3, 0, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (23, N'CT2121', N'Phát triển UD Web với.NET', 3, 0, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (24, N'CT2122', N'Phát triển ứng dụng web với PHP', 3, 0, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (25, N'CT2124', N'Chuyên đề cơ sở 1', 3, 0, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (26, N'CT2126', N'Lập trình cơ sở dữ liệu', 3, 0, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (27, N'CT0013', N'Thiết kế mạng LAN', 3, 1, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (28, N'CT0018', N'Đồ án Cao Đẳng', 3, 0, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (29, N'CT0022', N'Phát triển UD Web với PHP', 3, 0, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (30, N'CT0030', N'Thực tập nghề nghiệp (Cao Đẳng)', 3, 1, 1, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (31, N'CT2102', N'Kỹ năng máy tính', 3, 0, 2, 0)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (32, N'CT2310', N'Chuyên đề 2', 3, 0, 2, 1)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (33, N'CT2201', N'Thiết kế mạng LAN', 3, 0, 2, 2)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (34, N'CT2202', N'Quản trị mạng', 4, 0, 2, 2)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (35, N'CT2203', N'Hệ điều hành nguồn mở', 3, 0, 2, 2)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (36, N'CT2204', N'Bảo mật mạng', 3, 0, 2, 2)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (37, N'CT2205', N'Hạ tầng và các dịch vụ Int', 3, 0, 2, 2)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (38, N'CT2207', N'Mạng không dây', 3, 0, 2, 2)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (39, N'CT2209', N'Chuyên đề 2 (Mạng & Truyền thông)', 3, 0, 2, 2)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (40, N'CT2301', N'Lập trình Web nâng cao', 4, 0, 2, 1)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (41, N'CT2302', N'Quản trị dự án công nghệ thông tin', 2, 0, 2, 1)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (42, N'CT2304', N'Thiết kế mẫu', 3, 0, 2, 1)
INSERT [dbo].[MonHoc] ([MonHocId], [MaMonHoc], [TenMonHoc], [SoTinChi], [BatBuoc], [TrinhDo], [ChuyenNganh]) VALUES (43, N'CT2306', N'Phát triển mã nguồn mở', 3, 0, 2, 1)
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
/****** Object:  Table [dbo].[Lop]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[TenLop] [nvarchar](128) NOT NULL,
	[TrinhDo] [nvarchar](max) NOT NULL,
	[NamNhapHoc] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Lop] PRIMARY KEY CLUSTERED 
(
	[TenLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK34A', N'DaiHoc', 2010)
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK34B', N'DaiHoc', 2010)
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK35', N'DaiHoc', 2011)
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK35CD', N'CaoDang', 2011)
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK36', N'DaiHoc', 2012)
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK36CD', N'CaoDang', 2011)
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK37', N'DaiHoc', 2013)
INSERT [dbo].[Lop] ([TenLop], [TrinhDo], [NamNhapHoc]) VALUES (N'CTK37CD', N'CaoDang', 2011)
/****** Object:  Table [dbo].[webpages_Roles]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[webpages_Roles] ON
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (3, N'Admin')
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (4, N'AdminTeacher')
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (1, N'Blocked')
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (2, N'Teacher')
SET IDENTITY_INSERT [dbo].[webpages_Roles] OFF
/****** Object:  Table [dbo].[webpages_OAuthMembership]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_OAuthMembership](
	[Provider] [nvarchar](30) NOT NULL,
	[ProviderUserId] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Provider] ASC,
	[ProviderUserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[webpages_Membership]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Membership](
	[UserId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[ConfirmationToken] [nvarchar](128) NULL,
	[IsConfirmed] [bit] NULL,
	[LastPasswordFailureDate] [datetime] NULL,
	[PasswordFailuresSinceLastSuccess] [int] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordChangedDate] [datetime] NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordVerificationToken] [nvarchar](128) NULL,
	[PasswordVerificationTokenExpirationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (1, CAST(0x0000A31A00849AC3 AS DateTime), NULL, 1, NULL, 0, N'ALGuaGusvaB7lrM0fpaLg+jOgWpVgrumI+Znmi0rLkLNK+1+gZqjcHlS+i5/I/XuXA==', CAST(0x0000A31A00849AC3 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (2, CAST(0x0000A31A008A683F AS DateTime), NULL, 1, NULL, 0, N'AAXURVZiERWltIDLGIx2kV0ZurNIw7PHJkMCI9J3j5VdlvgJqH+3gItQQ/QmkGuGVQ==', CAST(0x0000A31A008A683F AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (3, CAST(0x0000A31A008A68B3 AS DateTime), NULL, 1, NULL, 0, N'APQ03yoS49hlOUmktqCl7lhWFADiDuMjOSM71Z7morCC5l/uYZlsUQrE+/VVEk3gAA==', CAST(0x0000A31A008A68B3 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (4, CAST(0x0000A31A008A68BE AS DateTime), NULL, 1, NULL, 0, N'AP3PmjaJ0iBXgehG9KdiCyvFxPmcp/oeLmS4pOCG0HFPo/BljHZnFrStHotcXCO7IQ==', CAST(0x0000A31A008A68BE AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (5, CAST(0x0000A31A008A68C6 AS DateTime), NULL, 1, NULL, 0, N'AJCDepeBoj9dIsxzpILYqsEZHiC+0QpmU3l3vS7/4j1pdGGthHugVPHi+w/xkL4C3Q==', CAST(0x0000A31A008A68C6 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (6, CAST(0x0000A31A008A68CE AS DateTime), NULL, 1, NULL, 0, N'AFxu6EPxKorW+2Z8bPsuhAdP3F60XYdFcm+eSGddnh3WEeSfCpPRHPt8thW0hWV8iw==', CAST(0x0000A31A008A68CE AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (7, CAST(0x0000A31A008A68E4 AS DateTime), NULL, 1, NULL, 0, N'ANaZRfKVNvQKw7QOgWOq2Cgou45H+HYN/urOpq9P/wPikw7es2e6LwPaYwSPMqW3Iw==', CAST(0x0000A31A008A68E4 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (8, CAST(0x0000A31A008A68EC AS DateTime), NULL, 1, NULL, 0, N'AIQ+k3TJd/w8ITUkeOIgIezkGACULlL23LteQag96ODhBVpnNCcuJBPWX/WhrWAk6g==', CAST(0x0000A31A008A68EC AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (9, CAST(0x0000A31A008A68F5 AS DateTime), NULL, 1, NULL, 0, N'AGXcFmAje/b5A44N4qlt7RahL3ScUy1Xi881MKzZ/2EOqG0e5x3+e6e4mSvNseNptw==', CAST(0x0000A31A008A68F5 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (10, CAST(0x0000A31A008A68FD AS DateTime), NULL, 1, NULL, 0, N'ANbp1WtEfNjnGqlbMZPPebOqykcIzBBkTptkY98dJx9ligbutmulPeLUSWI2CpPN5Q==', CAST(0x0000A31A008A68FD AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (11, CAST(0x0000A31A008A6908 AS DateTime), NULL, 1, NULL, 0, N'AN5CJtcyx+d+5hl9zCxiHRvKkUgVpVRhCw65s2dPQaccMBXXtN/T7Vo566Fk3xdISg==', CAST(0x0000A31A008A6908 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (12, CAST(0x0000A31A008A6912 AS DateTime), NULL, 1, NULL, 0, N'ADQ8ZEXcYsGofdHgxn/CRcyy7WcWhFt7/t2+fbfx2M4YduuYjh5Mo0NHZX+4XBGmIg==', CAST(0x0000A31A008A6912 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (13, CAST(0x0000A31A008A691A AS DateTime), NULL, 1, NULL, 0, N'AHklsJybIssvAVYpY+uGZxdFK8YNNmc+6yEAk1I1AUDmznup/DbVu0L8KpZiyz0H1A==', CAST(0x0000A31A008A691A AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (14, CAST(0x0000A31A008A6922 AS DateTime), NULL, 1, NULL, 0, N'AF6c3MqdjiI1hbff/Q4WDaRt0O88MQT4IoLlj2/9cdTjvTDONcMscI7kEOwspeSPzw==', CAST(0x0000A31A008A6922 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (15, CAST(0x0000A31A008A692B AS DateTime), NULL, 1, NULL, 0, N'ALX5WEEQuoWghYQXIoGjsy4cNojLhy4yCgxtF95ETE6cIg0jUi/kzq1dNCho56mwPQ==', CAST(0x0000A31A008A692B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (16, CAST(0x0000A31A008A6933 AS DateTime), NULL, 1, NULL, 0, N'AP8RuSTMPmmd2sPv+mK04l+FbJXd2CE4pXMFgW87y5lK5aUAKQXEHoc+WhacDbFusQ==', CAST(0x0000A31A008A6933 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (17, CAST(0x0000A31A008A693B AS DateTime), NULL, 1, NULL, 0, N'AB3AX1vUHrS5wOholh3iAmah7Viu1FVhLZ1LQ4HNGxiTjn+qOH/t5vozb8geZtYFgw==', CAST(0x0000A31A008A693B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (18, CAST(0x0000A31A008A6943 AS DateTime), NULL, 1, NULL, 0, N'AFGkkoNm8LKVGieR9kekoAW+e5/+T+S4NIChP3Fi1MkseT+0KDh+APVB5HQTT9f8PQ==', CAST(0x0000A31A008A6943 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (19, CAST(0x0000A31A008A694B AS DateTime), NULL, 1, NULL, 0, N'AL0TChOHA5P5SZlc+DiiVIxzd4X2VoxbJ+u5IoIMHX9IlG6dp0Y6Qp6ccvskTUohzw==', CAST(0x0000A31A008A694B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (20, CAST(0x0000A31A008A6953 AS DateTime), NULL, 1, NULL, 0, N'AKF3vimk7TMQf7+UPgdlwBSh6vuqpDWQrm5IducbYfY3oca4HPXERdB5ShzyCSkHGg==', CAST(0x0000A31A008A6953 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (21, CAST(0x0000A31A008A695B AS DateTime), NULL, 1, NULL, 0, N'AA8mJF1Ebzg3qoWeM6CIf9EHRjapxH65ouvVY3FGjJD3pB8UO2SlsAMjAkmXzWgF5A==', CAST(0x0000A31A008A695B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (22, CAST(0x0000A31A008A6967 AS DateTime), NULL, 1, NULL, 0, N'AApaQSHM3hTmR/jdyAO2Nv/CXX47GIKxOaawo1G9aaflbc7pyO61fNP2LLo63290oA==', CAST(0x0000A31A008A6967 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (23, CAST(0x0000A31A008A696F AS DateTime), NULL, 1, NULL, 0, N'AG3K0fb+ZTfNCmjdvT30l8O06X2eoUdiUwDJabJX1PcHPlElzCw01NfTIlpvIctqyg==', CAST(0x0000A31A008A696F AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (24, CAST(0x0000A31A008A6978 AS DateTime), NULL, 1, NULL, 0, N'APEh+ySIy7IIZoXp7oxjPQrKPFFfDLdpzYsOmmZuldNDoqNC817lE8rkCEPqpdRxWw==', CAST(0x0000A31A008A6978 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (25, CAST(0x0000A31A008A6980 AS DateTime), NULL, 1, NULL, 0, N'ALsrHphy8TozBtHBodsgTApyr3G4AKIp3vdmkxjMYFUPZ9dcoSGkYTV4E/jErFO7zQ==', CAST(0x0000A31A008A6980 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (26, CAST(0x0000A31A008A6988 AS DateTime), NULL, 1, NULL, 0, N'ACEk1Rzw8JpZhNMYBIXPGSCaAlXaypzryZozV4TJwSxgSnbDLBfpmEBYtnF4tg7uxA==', CAST(0x0000A31A008A6988 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (27, CAST(0x0000A31A008A6990 AS DateTime), NULL, 1, NULL, 0, N'AF5aCCq/B95cz0/QRBgjljNJetSFjOpLhIYlQJo6KB1kdffJlrCrAWqUXWtiPIxaAA==', CAST(0x0000A31A008A6990 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (28, CAST(0x0000A31A008A6999 AS DateTime), NULL, 1, NULL, 0, N'ABmAPPcrMq5TIixCIvYEU9JGalY5N2Qts1iHAtFgHXwFkJNhNWtvop/ppaLCSU/g7w==', CAST(0x0000A31A008A6999 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (29, CAST(0x0000A31A008A69A1 AS DateTime), NULL, 1, NULL, 0, N'AMIhipDEqNQ/xSt88DeFiTK7+wxYsGJNu/0bIf+UOqCbZSqaHbycB7NUPCaQr7Me2A==', CAST(0x0000A31A008A69A1 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (30, CAST(0x0000A31A008A69A9 AS DateTime), NULL, 1, NULL, 0, N'ADa+3pi7VLNohsevhALXuZmXjZBL6KksKyFid1Q1zVcE/V+rSBMs00YxLVNvQRk0Fg==', CAST(0x0000A31A008A69A9 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (31, CAST(0x0000A31A008A69B2 AS DateTime), NULL, 1, NULL, 0, N'AFLpj9NJnX1j+umUsE1gov68ejjM+mu1MPTIRLvM+N1+lQ5S0B6PtZXnp2KvCxoEKA==', CAST(0x0000A31A008A69B2 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (32, CAST(0x0000A31A008A69BA AS DateTime), NULL, 1, NULL, 0, N'AI7hCYaOLMiAh5CBGO3RJiSbsE/ioBxyJxw3jyHckwFl9pDccPH+GgjHtTO76fZFJA==', CAST(0x0000A31A008A69BA AS DateTime), N'', NULL, NULL)
/****** Object:  Table [dbo].[UserProfile]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[MaGv] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Role] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.UserProfile] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserProfile] ON
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (1, N' ', N'admin', N'Admin')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (2, N'CT02', N'conglg', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (3, N'CT03', N'binhntt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (4, N'CT07', N'ngaptt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (5, N'CT08', N'thangth', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (6, N'CT09', N'locpd', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (7, N'CT13', N'phucnv', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (8, N'CT15', N'hunghm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (9, N'CT19', N'anhpt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (10, N'CT20', N'khanhtnn', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (11, N'CT24', N'trangnth', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (12, N'CT25', N'cuongdn', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (13, N'CT28', N'luongnt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (14, N'CT29', N'binhvp', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (15, N'CT31', N'thylu', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (16, N'CT33', N'binhnt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (17, N'CT36', N'baclh', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (18, N'CT45', N'toandn', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (19, N'CT46', N'quytd', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (20, N'CT48', N'linhlv', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (21, N'CT49', N'luyenln', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (22, N'CT51', N'linhttp', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (23, N'CT59', N'choihk', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (24, N'CT60', N'duongnh', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (25, N'CT65', N'quanvm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (26, N'CT68', N'khuedm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (27, N'TH01', N'hiepnm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (28, N'TN12', N'haidt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (29, N'TN15', N'minhtt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (30, N'TN16', N'nghiapv', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (31, N'TN20', N'thongt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (32, N'TN22', N'tintc', N'Teacher')
SET IDENTITY_INSERT [dbo].[UserProfile] OFF
/****** Object:  Table [dbo].[TuanHoc]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuanHoc](
	[SttTuan] [int] NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[DaLayThongTin] [bit] NOT NULL,
	[DaXepLichThucHanh] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.TuanHoc] PRIMARY KEY CLUSTERED 
(
	[SttTuan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (1, CAST(0x0000A20A00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (2, CAST(0x0000A21100000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (3, CAST(0x0000A21800000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (4, CAST(0x0000A21F00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (5, CAST(0x0000A22600000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (6, CAST(0x0000A22D00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (7, CAST(0x0000A23400000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (8, CAST(0x0000A23B00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (9, CAST(0x0000A24200000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (10, CAST(0x0000A24900000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (11, CAST(0x0000A25000000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (12, CAST(0x0000A25700000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (13, CAST(0x0000A25E00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (14, CAST(0x0000A26500000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (15, CAST(0x0000A26C00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (16, CAST(0x0000A27300000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (17, CAST(0x0000A27A00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (18, CAST(0x0000A28100000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (19, CAST(0x0000A28800000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (20, CAST(0x0000A28F00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (21, CAST(0x0000A29600000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (22, CAST(0x0000A29D00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (23, CAST(0x0000A2A400000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (24, CAST(0x0000A2AB00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (25, CAST(0x0000A2B200000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (26, CAST(0x0000A2B900000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (27, CAST(0x0000A2C000000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (28, CAST(0x0000A2C700000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (29, CAST(0x0000A2CE00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (30, CAST(0x0000A2D500000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (31, CAST(0x0000A2DC00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (32, CAST(0x0000A2E300000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (33, CAST(0x0000A2EA00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (34, CAST(0x0000A2F100000000 AS DateTime), 1, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (35, CAST(0x0000A2F800000000 AS DateTime), 1, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (36, CAST(0x0000A2FF00000000 AS DateTime), 1, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (37, CAST(0x0000A30600000000 AS DateTime), 1, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (38, CAST(0x0000A30D00000000 AS DateTime), 1, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (39, CAST(0x0000A31400000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (40, CAST(0x0000A31B00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (41, CAST(0x0000A32200000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (42, CAST(0x0000A32900000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (43, CAST(0x0000A33000000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (44, CAST(0x0000A33700000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (45, CAST(0x0000A33E00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (46, CAST(0x0000A34500000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (47, CAST(0x0000A34C00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (48, CAST(0x0000A35300000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (49, CAST(0x0000A35A00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (50, CAST(0x0000A36100000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (51, CAST(0x0000A36800000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (52, CAST(0x0000A36F00000000 AS DateTime), 0, 0)
INSERT [dbo].[TuanHoc] ([SttTuan], [NgayBatDau], [DaLayThongTin], [DaXepLichThucHanh]) VALUES (53, CAST(0x0000A37600000000 AS DateTime), 0, 0)
/****** Object:  Table [dbo].[PhongThucHanh]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongThucHanh](
	[TenPhong] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.PhongThucHanh] PRIMARY KEY CLUSTERED 
(
	[TenPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PhongThucHanh] ([TenPhong]) VALUES (N'A21.1')
INSERT [dbo].[PhongThucHanh] ([TenPhong]) VALUES (N'A21.3')
INSERT [dbo].[PhongThucHanh] ([TenPhong]) VALUES (N'A6.1')
INSERT [dbo].[PhongThucHanh] ([TenPhong]) VALUES (N'A6.2')
INSERT [dbo].[PhongThucHanh] ([TenPhong]) VALUES (N'A6.MT')
INSERT [dbo].[PhongThucHanh] ([TenPhong]) VALUES (N'A6MT')
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201404270802400_InitialCreate', N'TkbThucHanhCNTT.Models.TkbThucHanhContext', 0x1F8B0800000000000400ED5D596F23B9117E0F90FF20E82909662D5BDA049B81BD8BB13D87E1630663ED60DF06B4444B8DB4BA1575CBB010E497E5213F297F21EC8BCDFB6AF6216031C0C0EA26AB8BC58FC522ABC8FADF7FFE7BFECBEB261CBDC05D12C4D1C5F8ECE4743C82D1225E06D1EA62BC4F9F7FF869FCCBCF7FFCC3F9FBE5E675F4AD2A37CBCAA19A5172315EA7E9F6ED64922CD6700392934DB0D8C549FC9C9E2CE2CD042CE3C9F4F4F4EF93B3B3094424C688D66874FE751FA5C106E63FD0CFAB385AC06DBA07E17DBC8461523E476F1E73AAA307B081C9162CE0C578FE8FA7F97ABFF804A2F5D5C37C7E52D4188FDE850140DC3CC2F0793C025114A72045BCBEFD35818FE92E8E568F5BF40084F3C316A272CF204C60D986B77571D3E69C4EB3E64CEA8A15A9C53E49E38D25C1B359299F095BDD49CA632C3F24C1F748D2E9216B752EC58BF1C70044AB6F0144B4D9AFBDBD0A77594999944F70DD3723A6C41B0C0E84A1ECDF9BD1D53E4CF73B7811C17DBA03E19BD197FD53182C6EE1611EFF034617D13E0C495611B3E81DF5003DFAB28BB770971EBEC2E7B201F7E0E3CB7834A16B4ED8AAB82255AB681D0204C2F778740F5EEF60B44AD708F908D01F8257B8AC1E9400F9350AD0684075D2DD1EFD7C403C83A710E2F713E547AFD6FB038C1E564848F8DB08A027D4734B9A9FE26F609EF59EB42DE8CF561A13CFD7F0CB1A4468B8AEAACF5FC6710841644D0C0DCB1D7AF41C84F0665911BB89D2D994ABF9005E82558E4F86C65DB0585F82080DFEAF30CC0B24EB605B8AB87CF99D80FB875DBCF91A8775CDFAE5F739D8AD608A188965251EE3FD6EC1B74BC95D3542C42CD6B499B235A3922298998A5D59B9AA59A64CA3518D498999264B88852B2EC1495852CC56CC04903442A64A8A444C145008982C2512EFF9A456B94A455C42CC410D9735FB54C2250BD9D8B5D5C444556AD8731A8490C8631AEFE04718C11D48E1F20B4853B84373EBCD12E652D5691B3FCA5FFD8DC7349DEF41A46B949AC87C8760365F83E012F8D0F0A6838818C7CD55293B74E4CAD6582B21B97E8A17627D54BCFB5E4F06842662DEF13A882D20D23EC6031AB3693DA0CB9A7D0E680C5FDBE16C887BFD607E8823EDF84026D3E112A4D7605F7DEF1AD198A3B584F550BB0677E0305F235B661E444DCD996BF01BDC9253AF3541372BC70AFDECC0940E0F7F260E59E23B1E1FB4F660DF0B6D31AE90AD9D6069D9087815BD575B352A5EADCC841A554EB642F5BCDF555BC189CBCAADAAD999B91067DDA637503473398CBEAC89A592C8F098FED4C64A0D7DF92EDEF6F0DD00A6B47676941CA2730BD30CA9CD0879B1C9B239679EED2091A4728DC1BCB1A4FBF165BD3CEB7C4B22FBEAB46D5B38FBC8ACF58FAC83ABF5DEBF95CCB5E5EC2ABE07695313E1E3CBD4139D991B1DBDF57FA69FC3C9B29269BC2E225C0A88CAD91A1EB8EAD482E3A99EE3A921C753778E67161CCFF41CCF0C399ED91B77D90CA263352F24E111BD53339715B0E5AA989AF58C55E524BC15AFD5EC95656C39CCE7FCDA60D331CA1497F04B9552B34D17F5B9D47632E695BCB256B49B819C61D0DE2E8EB77D9AC39589666B0CF766DAA10FADAFE3EEBD0EE8FF8735D8E650B3B2E21403B47061E4BA510874AAC43538B06A4EF49E5B090A0B355A09B2141D50CF92E87308DC2C6B6792ED3020EB76B52A44FFDBA39073DE2D6E0FCD48F8599CF6E20EED4C79396E74734356B8E32D2FC54D768AA2BECC31275DA5E5D3B369569A52EC67A8ED4A59194EB14A0B3652AE15F7D62AB5A8D8EBD61AD608D65B6B86BAC4A727AE1274D78604523E7D7DFA319E07D1D53A68A6B22F417AB9AFD977DD3F602DB97CEBBB7AD6477C8B99A156A80BDFBA8555845A25E468B8516B3C07AB8DA8DFF3AAA5DCD27658B774B2196EEEAC251C352E1E5BA27ABF6E15F46D179F4A5EAD2BADDFA3EED5A1AEA5CF2203CA4F738FCCE3D2CBBA62586E1EC7C58773601DE7D657C7DF7909BA7171952BF9F4B2134845F859AB74A2769F1A3D63C3C596AFEA0D24A6AE25BD9AB532FBABFB2F67A0F5ACCFAD6240327B740E5C56A844EDBE43464B365CC34689EA0381793B13DADDC1CB56BB66CE5FC741A6802FB1349D63E92A52B7A93DA90641A9251CE481A95C01A13B8A2F65370BED37C450A596BE37C98710ACEAE346D64337239E90CB696F031861650977E101618B1C4A74DFDCC3CD13DCE1F31F7950F23710EED1AF53AE2399C2D1EA61559C17412F70B53375B5FB2CFC7997B5765ED8ED65B529DF1785D4153DC1986D9EFA82A2DA636FA0AF7E02816977A0D297C0B41350E1F95E267A4161F4072E3DD3967E0435ED1F0DB83EE0D27FD5400E71B2CEE262CAE27F73C00CDE08F38496925E8F38B95D673683E1A005F13520469D0627D720C8ED7E33A0DC05ECA0D660E5DB1E20F2E8FF3B025F3F9A74EABB24891741DE4F7410353153D01F7E1F2D47DAF30CF58A101FDDB9479D166C5137A189E162FC17AE412ABAD8AF51D32526329AF2E9C909DF19C8B482BBCC8A012152B709424D10A5BC1D16448B600B421D1F4C45C96E137FF432EB04FC11F6CD35DCC228B3B474D26DF275FC11C6A2D4C9E77C4200458D1F2ECE5ED6CDF2A07B62B7BD5A30D37D7CC60AE1FC73740D4398C2D1BB457196F80A240BB0E46D28340A96C61C0970678C6727C8C96462D2E792632956A09349A0E1F73B809D2CF452A5649471987497D72E093B3DA60AE134D1665E91EEAC0515ADE84C172A3ACB848732847C40D8646D111D70A6ED6373DAE34CABE0A6478C4D6D31C69976BD626C6689B159FB189B0D0A63B301606C668B316E35D011C614415F320C984480D530E0C336CDD1661040761C13AEBE219D6055DF73035F8808C3FD8CD143C5FEB584502A169AD0B75958E2E05149306F020471147F3344127DD48C850ED0288DBD92A1451F885523A68A18E96495AC8F3E6D325C9CC0A9939591A69284865A4154279BA68C746D48AA54A6FC049B67D3F198D4A48CF18E54A4AC4F06AF1E4527128DC0C11E4FF48C3DE66463B73AB7390269F63B53838A1E3A360D4807241B61467202D53332C58757A9B9970AA51E344E858D31545AC2306B77B80A7BAF292B5DA3B6F29B1821898B3AF48C54EE02A06EFD3BCDD1C934C0040C3E9C31AA4E6AC843177E407190AE0C31BA885D0233D47104734CEA2EDB3C8ACD2175233AD91852F7D4C0378584E1D846885168492F883C462DA96A40575A52D549C3D79235EBA4B697EF0A49CA8B5069E753D17F42120C61681E38C9843CA5A067577829B1813C5443544C5D200AEA40455B3E2C25372660179F98B01A6F4A799BF2F0A5BECFBC3763990F895659B38AF8687A3CE0C30776D6B23CB2FA380C13651B3AB14B94BD3428B3A4888E47755254A30EE125E25ED12BF89A0A6269D1E029C36993F2E8020BAA8CF4234C595D9A8C4775503E0F270E9B34191CCCC713C101711A12E5D42C2281ED1B032E884B7485ACD4D3918E58BC15D2105C35C556151CA0E7E8F09E0F0DD162D34B44AADA69D472456C5C8859A2368474FD85EC2A0576689B57438B50F9225AD4DC6980817294CB20803530438A188D1CB2C983314439E9B5EEAC9230898AC64D21C713A76E4CE2A0094AE40067353BDD600361F07764F3B250C7F7D2EB1B59842FC17FAD1614929006E61A88D4410CB258520932B461A7F2AD3141E029D32462406BA0A20A356D0B30B2C84663494DAD25356D4352D39E24353397D4CC5A52B33624356B5D52AAABC5786199C6A4514D33884A235A2798EE1562338843EB4C72B931632033CECDAF6E11E9ECF72727D2CD4F0236B7D31ACB467EF7112F1FB3581DAA35DA681DA245D8D25348471B646323F7A6EA4A022375A4885C9748E0E3A899DA858D282E41270A51F8829C7F2680A1B9409890053DF09A8A85595768A4A370A8CBDB2476A9379795D8894E8D2D7A51E5577278E1AB9199D05161EED06D2E27D6396160C0BB2C3F24F7FA08162106CE451BF722D91E6ADDAB5A94A8FD89ADADD184170A6944A40790D2D7D5583CDDE047E64C1148C7C8EF62E57931EA6F2B478BE9B06D24296AEF452527A92FC6C21BD3444622FF0B418FDE62F2A2A60577A688F5B4C69360E14B60BABCDEE8D2286AB9F7A0A91AAAEE72C1BBD5F8DDF9A448395D3E389F4872539FDF83ED36885644AEEAF2C9E8B148547DF5C3A37DF6E64D4163B2A0062DBBB78EBF94C63BB082CCDBECF29525FC10EC92F41AA4E00964F7575C2D375C31C1DEBC649BB2FA20B7FDCE7760B5755955C9FEE65D01A29CD202774649E4036AE526F389E47739893A9FAF3BCA92878310EC84F7395DC5E17E13A93C24720AD40D3F2421EA85393D9CD099A4851F5AF045E767A638A35F99D364DC9A244D8DC7331B3B4CF7713E280E2D9C138FC69F113A155BB8D6D8ACDC40F6C894D69449BAACC04A99786CDE6BCD318EE3474822D2A012391D3A9F2D498C7E3318F460C3CD037A24F6A9017AA435DBEE2F32BF2A498A7C6E4E8D49B14A12645ED9D0E432ADD274B9D783C196CE2877524FB24D07431D25AF2E572E453D56C1544F2DD4143E114151929E939053AAA3D42915238D5D5752CA3706193AC233440A2AC4B5CC1425E2B91D357C39334B0EBFE85EB93317ECB1FA8278654EB3BCD184A425B9E4444D63CAD3105C62A1A631E369082E2950D02813545244CA67369C54F9276966AAA73694A6424A53074A3321A59994525F2A37DB30F7A169794780898215D56A59F3541718D2B656F9D0626C1369D7A8814D3C1F4C2F9BF8B4ACBB9C8B75B2EF7F3D0999F8C9FC66A4F8E539D3349D29EA484927CAD7A979EE327A959A3FEA63CA6FBEC6B11B703D41BBF26E7900B4D88367006359C52E3AB9F24ED21D2D0E1ED474B68814F1D8C27E8AAB744E9401859F9A53C2299D4842F861F75ADF756BAB37BD4FF931BD287D851FD748E32BEBFB5BBFF4B53D423ACA7C6C919001B70EFB24CAEA72AD92273FA2558A208D92A6C7BCE91341D75BAF5BAB7C43D4DE612CB3D38E73DD3A9C6DCD262BDF9E462EE54AF43072159E538381ABACAD724688BC105D1B8E750E1A9693E2A939A522A70C49A5783218D450FE5A4F3B96D54906B70D4B696D956385C81BC33A57A41969DAC55091E18562E66067AB91E95B28E54A3CB7A7769B8AA9DDF6B2AB433BF0255E68362EC6DCE3CCD6B4D920CF621564096BC4C134BCF40CB155D3951DE623787167537AACD18B1B40C9241A84CB203FC97A9364F98270DA0D7331B0D11E3C9EB8A00FB6084673F904FFC6411F65C0051509920B288BEBC8059394C11F6C044651643C421278099659F4C5E32149E1E6242B70F2F8CFF02A442D4BEB02F7200A9E619216C93FC6D3D3D39FC6A3776100922246A78C2D79CB1EA6340A36399B65C12670B999B0D5ED4356322A49B2A45282F119CC64E7910D939C8AFA5B9FE3B4CEDC15BD80DD620D765CEEAEE6098F83ACD72CC9E0E80E9ABB3F6DC0EB9FED79A2833B0A924F813D574C4407D13CEEC4EE4DB484AF17E37FE535DF8E6E7EFB4E557E33FABC43187E3B3A1DFD9B64A3610A3C2EA0C23CF19C3086C22CE95C5995108736A55C83A4A935520D849E55A4652D85B7494638268FAA69D797D5649D6E98959C0C07D10C8B063012DF8E630423C93A510F2291581D92D3D2797E97087AA94BAE3E26F2C25D5D08422D4C89598D7AC93D85863387D81E31993DAA9A6D0E7CBC276E37E2AA7ACD861C9392DD4AF35495E5DA27CBE66ECF51EE7D71E30755F5CB0D975BDB65E40A326BBB90E951350B1363BBB4A10CE470E8DDBCA6E14467CCCAD49995A9C739B78C2A71E464E693933234C57AF21535AA8A4E719F5EEAB894263466CD6930CB4E979EA248387799F9ACC95D706E34598A9DDFFAA952A6B69BEADFCA7FE96391F440C4AD986A306379ABE33CCC842F8FECD0770059B7456BE5A10C1969B2EECDE345DC09F46A3075B14C1BBC9D643C2884F7DD9B19ED92481103A35D040FFFABF5CAC5EB4331111E631FE4EA2814F741860350DC274D4677BB70E1B4D566A1B2E537E09B4E964227BDD174295977B53310E54112A66B68416C84C9023AAFD6E240F43C74849DE246AA8ABCF0604A0F6A153A9819F0F896C3C6C3557E3DB0D168150744E8876B55AFE36D6EB7F155C75AF8A056C45CB4B7E72C0D5B30775F48A314CC5C1844F523776398A9DF83C1B2D148F912B1140DB7DDC9400A2B52329889EF7F565CE829BA80C2CBDDEAF8B25CE6CAD2F632CAAB6246CDDCC723DB4B98C5C7C0CD3FD6451A08E525A6FCCDA39DA763E81332F2C3D8C69EBED630D36FB606A3DB5EDD95478B08621D8F0ED99D8E45FD28CE24F05F949C98ED114DD30EA7A2DF51214785E00C748FA898FD8E8A41A04270AABD9F64E6DE2DD796261F3E0F02C14C47E9A13B0696C171E84119C3FAEBA04905517B533AC9C23C2C24892F3730F50FB78FA2634C71DF5F26FB21204A7AD4DCDCD9D781721A5042E6612AA73EEDA60E9592B5CD743449E5FBD6457D02A86B1D648DA221E91FB384F0CC9DF8D4BCD2555AF661804B774F8479BC40EB9AEA68D2B70F6357BA2F44F5B13F6D05A5A34ABC3E8C6D023A9D20096BABDCDAC7B03DA0B9C865505B0376E9D27BD74A7DA2A86BAD640DA3234D74FEFBB6B61D2EECB7B5B57726740A0F939CEF54D212A2376D93B03BC3CD1334D437039946AC59C1C30E8DC797AB7D18E60C19C7E69C20FE58B48DFC96A21E6D19E602932A529E4BF7C2F6209D6D9AC04D1D5AC663AAB8B2E462BC7CCA82E98AF834E235A775E88FE0681EEE13F88DE803F8A5863C36C138F2F88D88BC4B52766D4E76593B6CB2B6CB92B60B693B6473374AE62EFA9863CA7745C677D1575CB2C1EB93C18BDB639B2F5E315AE8D742C0396694D72594177DCB31E3BC2EE1BC0CDEFD66A4E7BA854908C5AB6341F42173D79748F10C25DFBC28BD608F8D94050D7AC926DFB46F590DC15FE6D696003C25893F5E0178CAFD7E0C02E820A57B1331C82C0071668216C4E1274F3B611BE19C1A436A762729D80509AF0725042E96A1616275CB3EEF45E5F9CA9BEED6C3BD34B99D9CE842A35E709BFEE0C4E12FD179131BAF8B66B798C3BCC914275A9DF179013C37DF637672C75EEFAAD9D27B92BD661E1FB08527DEBFF790505CB0D0E7AEC55709C05278434A15DEB4DF994D0BEE5E78F3A65B2401E7EF7D3E9F7CDD47D9E9DDE2D7354C82554D22BBD03A820B6AFB1697B9899EE36A0F99E1A82AC21EAC8629588214BCDBA5C13358A4E8F502264990C5F57C03E11E1579BF7982CB9BE8F33EDDEE53D464B8790A29CB2EDB8D567D3FCF744EF37CFE799BFD4A7C3401B11964079E3F4797FB205C62BE3F080E3C4B4864DBDCE569F5AC2FD3ECD4FAEA80293DC49121A1527C78777E0E37DB10114B3E478FE005BAF08606EE1D5C81C5E14B797DB79C88BE2368B19F5F0760B5039BA4A451D7473F1186979BD79FFF0F341E1A48CAF90000, N'6.1.0-30225')
/****** Object:  Table [dbo].[GiangVien]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGv] [nvarchar](10) NOT NULL,
	[ChuyenNganh] [int] NOT NULL,
	[HoVaTen] [nvarchar](max) NOT NULL,
	[CoThePhanCong] [bit] NOT NULL,
	[UserProfileId] [int] NULL,
 CONSTRAINT [PK_dbo.GiangVien] PRIMARY KEY CLUSTERED 
(
	[MaGv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_UserProfileId] ON [dbo].[GiangVien] 
(
	[UserProfileId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT02', 2, N'Lê Gia Công', 1, 2)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT03', 1, N'Nguyễn Thị Thanh Bình', 1, 3)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT07', 2, N'Phan Thị Thanh Nga', 1, 4)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT08', 1, N'Tạ Hoàng Thắng', 1, 5)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT09', 2, N'Phạm Duy Lộc', 1, 6)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT13', 1, N'Nguyễn Văn Phúc', 1, 7)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT15', 2, N'Hoàng Mạnh Hùng', 1, 8)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT19', 1, N'Phạm Tuấn Anh', 1, 9)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT20', 2, N'Trần Ngô Như Khánh', 1, 10)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT24', 1, N'Nguyễn Thị Huyền Trang', 1, 11)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT25', 1, N'Đỗ Ngọc Cường', 1, 12)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT28', 1, N'Nguyễn Thị Lương', 1, 13)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT29', 1, N'Võ Phương Bình', 1, 14)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT31', 2, N'Lâm Uyên Thy', 1, 15)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT33', 2, N'Nguyễn Thanh Bình', 1, 16)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT36', 0, N'Lê Hoài Bắc', 0, 17)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT45', 0, N'Đỗ Năng Toàn', 0, 18)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT46', 1, N'Thái Duy Qúy', 1, 19)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT48', 1, N'Lê Văn Linh', 1, 20)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT49', 1, N'Lê Ngọc Luyện', 1, 21)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT50', 2, N'Phan Tuấn Anh', 1, NULL)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT51', 1, N'Trần Thị Phương Linh', 1, 22)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT59', 0, N'Hong Kyu Choi', 1, 23)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT60', 1, N'Nguyễn Hữu Dương', 1, 24)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT65', 0, N'Vũ Minh Quan', 1, 25)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'CT68', 2, N'Đoàn Minh Khuê', 1, 26)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'TH01', 1, N'Nguyễn Minh Hiệp', 1, 27)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'TN12', 0, N'Đặng Thanh Hải', 1, 28)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'TN15', 1, N'Trần Tuấn Minh', 1, 29)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'TN16', 0, N'Phan Văn Nghĩa', 1, 30)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'TN20', 2, N'Trần Thống', 1, 31)
INSERT [dbo].[GiangVien] ([MaGv], [ChuyenNganh], [HoVaTen], [CoThePhanCong], [UserProfileId]) VALUES (N'TN22', 0, N'Trương Chí Tín', 1, 32)
/****** Object:  Table [dbo].[webpages_UsersInRoles]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_UsersInRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (1, 3)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (2, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (3, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (4, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (5, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (6, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (7, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (8, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (9, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (10, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (11, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (12, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (13, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (14, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (15, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (16, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (17, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (18, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (19, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (20, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (21, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (22, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (23, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (24, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (25, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (26, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (27, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (28, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (29, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (30, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (31, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (32, 2)
/****** Object:  Table [dbo].[PhanCongGiangDay]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCongGiangDay](
	[IdPhanCong] [int] IDENTITY(1,1) NOT NULL,
	[NamHoc] [int] NOT NULL,
	[HocKy] [int] NOT NULL,
	[MonHocId] [int] NOT NULL,
	[MaGv] [nvarchar](10) NOT NULL,
	[TenLop] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.PhanCongGiangDay] PRIMARY KEY CLUSTERED 
(
	[IdPhanCong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_MaGv] ON [dbo].[PhanCongGiangDay] 
(
	[MaGv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_MonHocId] ON [dbo].[PhanCongGiangDay] 
(
	[MonHocId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TenLop] ON [dbo].[PhanCongGiangDay] 
(
	[TenLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PhanCongGiangDay] ON
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (1, 2014, 2, 32, N'CT46', N'CTK34B')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (2, 2014, 2, 33, N'CT60', N'CTK34A')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (3, 2014, 2, 34, N'CT02', N'CTK34A')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (4, 2014, 2, 35, N'TN12', N'CTK34A')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (5, 2014, 2, 36, N'CT07', N'CTK34A')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (6, 2014, 2, 37, N'TN20', N'CTK34A')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (7, 2014, 2, 38, N'CT09', N'CTK34A')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (8, 2014, 2, 39, N'CT65', N'CTK34A')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (9, 2014, 2, 40, N'CT13', N'CTK34B')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (10, 2014, 2, 41, N'CT46', N'CTK34B')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (11, 2014, 2, 42, N'TH01', N'CTK34B')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (12, 2014, 2, 43, N'CT13', N'CTK34B')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (13, 2014, 2, 4, N'TN15', N'CTK34B')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (14, 2014, 2, 19, N'TN12', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (15, 2014, 2, 20, N'CT46', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (16, 2014, 2, 21, N'TN22', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (17, 2014, 2, 22, N'CT13', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (18, 2014, 2, 23, N'CT25', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (19, 2014, 2, 24, N'TH01', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (20, 2014, 2, 25, N'CT46', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (21, 2014, 2, 26, N'CT28', N'CTK35')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (22, 2014, 2, 27, N'CT65', N'CTK35CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (23, 2014, 2, 29, N'TH01', N'CTK35CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (24, 2014, 2, 30, N'CT60', N'CTK35CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (25, 2014, 2, 17, N'TN15', N'CTK36')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (26, 2014, 2, 18, N'CT13', N'CTK36')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (27, 2014, 2, 11, N'CT59', N'CTK36CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (28, 2014, 2, 12, N'CT28', N'CTK36CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (29, 2014, 2, 13, N'CT03', N'CTK36CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (30, 2014, 2, 14, N'CT02', N'CTK36CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (31, 2014, 2, 16, N'CT07', N'CTK36CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (32, 2014, 2, 1, N'TN15', N'CTK37')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (33, 2014, 2, 2, N'TN16', N'CTK37')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (34, 2014, 2, 3, N'CT65', N'CTK37')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (35, 2014, 2, 31, N'CT60', N'CTK37')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (36, 2014, 2, 7, N'CT60', N'CTK37CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (37, 2014, 2, 8, N'CT13', N'CTK37CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (38, 2014, 2, 9, N'CT09', N'CTK37CD')
INSERT [dbo].[PhanCongGiangDay] ([IdPhanCong], [NamHoc], [HocKy], [MonHocId], [MaGv], [TenLop]) VALUES (39, 2014, 2, 10, N'CT50', N'CTK37CD')
SET IDENTITY_INSERT [dbo].[PhanCongGiangDay] OFF
/****** Object:  Table [dbo].[TkbGiangVien]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TkbGiangVien](
	[MaTkb] [int] IDENTITY(1,1) NOT NULL,
	[TenMonHoc] [nvarchar](max) NOT NULL,
	[Phong] [nvarchar](max) NOT NULL,
	[LopHoc] [nvarchar](max) NULL,
	[TietBatDau] [int] NOT NULL,
	[TietKetThuc] [int] NOT NULL,
	[MaGv] [nvarchar](10) NOT NULL,
	[SttTuan] [int] NOT NULL,
	[NgayTrongTuan] [int] NOT NULL,
 CONSTRAINT [PK_dbo.TkbGiangVien] PRIMARY KEY CLUSTERED 
(
	[MaTkb] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_MaGv] ON [dbo].[TkbGiangVien] 
(
	[MaGv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_SttTuan] ON [dbo].[TkbGiangVien] 
(
	[SttTuan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TkbGiangVien] ON
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (68, N'Quản trị dự án công nghệ TT', N'A30.5', N'CTK34B', 1, 4, N'CT46', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (69, N'Lập trình Web nâng cao', N'A30.6', N'CTK34B', 7, 10, N'CT13', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (70, N'Chuyên đề 1 (kỹ thuật phần mềm', N'A31201', N'CTK34B', 1, 5, N'TN15', 38, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (71, N'Quản trị dự án công nghệ TT', N'A30.4', N'CTK34B', 7, 10, N'CT46', 38, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (76, N'Lập trình Web nâng cao', N'A27.10', N'CTK34B', 7, 10, N'CT13', 38, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (77, N'Chuyên đề 2 (mạng và truyền th', N'A31201', N'CTK34A', 1, 5, N'CT65', 38, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (78, N'Bảo mật mạng', N'A31301', N'CTK34A', 7, 10, N'CT07', 38, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (82, N'Bảo mật mạng', N'A30.5', N'CTK34A', 1, 4, N'CT07', 38, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (94, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 7, 10, N'TN15', 38, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (101, N'Chuyên đề 1', N'A31205', N'CTK36CD', 7, 10, N'CT07', 38, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (103, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (110, N'Kiến trúc và tổ chức máy tính', N'A30.7', N'CTK37CD', 7, 10, N'CT09', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (114, N'Kiến trúc và tổ chức máy tính', N'A27.12', N'CTK37CD', 7, 10, N'CT09', 38, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (115, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (116, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 38, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (117, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (118, N'Điện tử tương tự', N'A31302', NULL, 7, 10, N'TN16', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (119, N'Cơ sở kỹ thuật điện tử', N'A27.2', NULL, 7, 10, N'TN16', 38, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (120, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 38, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (121, N'Cơ sở kỹ thuật điện tử', N'A31303', NULL, 1, 4, N'TN16', 38, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (122, N'Điện tử tương tự', N'A27.5', NULL, 7, 10, N'TN16', 38, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (123, N'Thực tập chuyên đề 1', N'A21.3', NULL, 11, 14, N'TN20', 38, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (124, N'Thương mại điện tử', N'A31104', NULL, 7, 10, N'TN15', 38, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (125, N'Công nghệ phần mềm', N'A27.2', NULL, 1, 3, N'TN15', 38, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (126, N'Tin học cơ sở', N'A27.1', NULL, 7, 10, N'CT65', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (127, N'Tin học cơ sở', N'A27.11', NULL, 7, 10, N'CT65', 38, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (128, N'Xác suất - Thống kê', N'A27.4', NULL, 1, 4, N'TN22', 38, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (129, N'TH. Nhập môn trí tuệ nhân tạo', N'A24LAU', NULL, 1, 4, N'TN22', 38, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (130, N'Xác suất - Thống kê', N'A31204', NULL, 1, 4, N'TN22', 38, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (131, N'TH. Nhập môn trí tuệ nhân tạo', N'A24LAU', NULL, 1, 4, N'TN22', 38, 6)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (132, N'Thương mại điện tử', N'A27.12', NULL, 1, 4, N'CT46', 38, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (133, N'Tin học cơ sở', N'A31206', NULL, 7, 10, N'CT46', 38, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (134, N'Thương mại điện tử', N'A31302', NULL, 1, 4, N'CT46', 38, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (135, N'Tin học cơ sở', N'A27.10', NULL, 7, 10, N'CT46', 38, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (136, N'Tin học cơ sở', N'A31105', NULL, 1, 4, N'CT09', 38, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (137, N'Tin học cơ sở', N'A31205', NULL, 11, 13, N'CT09', 38, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (138, N'Tin học cơ sở', N'A31205', NULL, 11, 13, N'CT09', 38, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (139, N'Tin học cơ sở', N'A20105', NULL, 1, 4, N'CT09', 38, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (140, N'Tin học cơ sở', N'A27.8', NULL, 11, 13, N'CT09', 38, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (217, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (220, N'Thực hành kỹ năng máy tính', N'A27.4', N'CTK37', 1, 3, N'CT60', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (222, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (223, N'Kiến trúc và tổ chức máy tính', N'A27.10', N'CTK37', 1, 5, N'TN16', 35, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (224, N'Chuyên đề 2 (mạng và truyền th', N'A20104', N'CTK34A', 1, 4, N'CT65', 35, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (225, N'Bảo mật mạng', N'A31301', N'CTK34A', 7, 10, N'CT07', 35, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (231, N'Quản trị mạng', N'A27.12', N'CTK34A', 1, 5, N'CT02', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (232, N'Bảo mật mạng', N'A8.7.1', N'CTK34A', 7, 10, N'CT07', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (235, N'Công cụ và môi trường lập trìn', N'A31205', N'CTK36CD', 7, 10, N'CT28', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (236, N'Hệ điều hành', N'A27.1', N'CTK36CD', 1, 5, N'CT02', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (237, N'Chuyên đề 1', N'A31105', N'CTK36CD', 7, 10, N'CT07', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (240, N'Photoshop', N'A21.3', N'CTK36CD', 7, 9, N'CT59', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (241, N'Lập trình hướng đối tượng', N'A31303', N'CTK36', 7, 9, N'CT13', 35, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (243, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 1, 4, N'TN15', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (245, N'Lập trình hướng đối tượng', N'A31205', N'CTK36', 7, 9, N'CT13', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (246, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 7, 10, N'TN15', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (247, N'Chuyên đề 1 (kỹ thuật phần mềm', N'A30.4', N'CTK34B', 7, 10, N'TN15', 35, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (248, N'Quản trị dự án công nghệ TT', N'A31204', N'CTK34B', 7, 10, N'CT46', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (249, N'Quản trị dự án công nghệ TT', N'A7.6', N'CTK34B', 7, 10, N'CT46', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (250, N'Trí tuệ nhân tạo', N'A20101', N'CTK35', 1, 5, N'TN22', 35, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (252, N'Chuyên đề cơ sở 1', N'A7.1', N'CTK35', 1, 4, N'CT46', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (253, N'Phát triển ứng dụng web với.NE', N'A7.8', N'CTK35', 7, 9, N'CT25', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (255, N'Lập trình cơ sở dữ liệu', N'A27.12', N'CTK35', 1, 4, N'CT28', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (257, N'Lập trình cơ sở dữ liệu', N'A8.5.2', N'CTK35', 1, 5, N'CT28', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (258, N'Phát triển ứng dụng web với.NE', N'A27.5', N'CTK35', 7, 9, N'CT25', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (261, N'Công nghệ phần mềm', N'A8.6.2', N'CTK35', 7, 9, N'CT46', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (263, N'Trí tuệ nhân tạo', N'A27.4', N'CTK35', 7, 10, N'TN22', 35, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (264, N'Lập trình cấu trúc với C/C++', N'A31105', N'CTK37CD', 1, 4, N'CT13', 35, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (267, N'Thực hành kỹ năng máy tính', N'A8.7.1', N'CTK37CD', 7, 9, N'CT60', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (269, N'Lập trình cấu trúc với C/C++', N'A31105', N'CTK37CD', 1, 4, N'CT13', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (271, N'Thương mại điện tử', N'A31204', NULL, 7, 10, N'CT46', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (272, N'Thương mại điện tử', N'A31206', NULL, 1, 4, N'CT46', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (273, N'Tin học cơ sở', N'A27.7', NULL, 1, 4, N'CT46', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (274, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (275, N'Điện tử tương tự', N'A20103', NULL, 1, 4, N'TN16', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (276, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (277, N'Điện tử tương tự', N'A27.5', NULL, 7, 10, N'TN16', 35, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (278, N'Tin học cơ sở', N'A31104', NULL, 1, 4, N'CT07', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (279, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (280, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (281, N'Tin học cơ sở', N'A20105', NULL, 1, 4, N'CT07', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (282, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 35, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (283, N'Công nghệ phần mềm', N'A31102', NULL, 7, 10, N'TN15', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (284, N'Nhập môn trí tuệ nhân tạo', N'A7.3', NULL, 7, 10, N'TN22', 35, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (285, N'Xác suất - Thống kê', N'A7.4', NULL, 1, 4, N'TN22', 35, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (286, N'TH. Nhập môn trí tuệ nhân tạo', N'A24LAU', NULL, 7, 10, N'TN22', 35, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (287, N'Xác suất - Thống kê', N'A7.4', NULL, 1, 4, N'TN22', 35, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (288, N'Phát triển ứng dụng Web với PH', N'A21.1', N'CTK35CD', 1, 5, N'TH01', 34, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (289, N'Phát triển ứng dụng Web với PH', N'A21.1', N'CTK35CD', 1, 5, N'TH01', 34, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (291, N'Phát triển ứng dụng Web với PH', N'A21.1', N'CTK35CD', 1, 5, N'TH01', 34, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (293, N'Phát triển ứng dụng Web với PH', N'A21.1', N'CTK35CD', 1, 5, N'TH01', 34, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (295, N'Phát triển ứng dụng Web với PH', N'A21.1', N'CTK35CD', 1, 5, N'TH01', 34, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (297, N'Phát triển ứng dụng Web với PH', N'A21.1', N'CTK35CD', 1, 5, N'TH01', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (299, N'Thiết kế mạng LAN', N'A7.8', N'CTK34A', 7, 8, N'CT65', 34, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (302, N'Chuyên đề 2 (mạng và truyền th', N'A31301', N'CTK34A', 1, 4, N'CT65', 34, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (304, N'Quản trị mạng', N'A27.12', N'CTK34A', 1, 5, N'CT02', 34, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (305, N'Chuyên đề 2 (mạng và truyền th', N'A27.12', N'CTK34A', 1, 4, N'CT65', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (308, N'Trí tuệ nhân tạo', N'A31203', N'CTK35', 1, 4, N'TN22', 34, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (310, N'Trí tuệ nhân tạo', N'A31203', N'CTK35', 1, 4, N'TN22', 34, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (311, N'Phát triển ứng dụng web với.NE', N'A31105', N'CTK35', 7, 10, N'CT25', 34, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (312, N'Phát triển ứng dụng web với.NE', N'A7.8', N'CTK35', 7, 10, N'CT25', 34, 4)
GO
print 'Processed 100 total records'
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (313, N'Lập trình cơ sở dữ liệu', N'A31302', N'CTK35', 1, 5, N'CT28', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (314, N'Phát triển ứng dụng web với.NE', N'A27.8', N'CTK35', 7, 10, N'CT25', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (316, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 34, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (318, N'Kiến trúc và tổ chức máy tính', N'A31206', N'CTK37', 7, 10, N'TN16', 34, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (321, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 34, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (322, N'Kiến trúc và tổ chức máy tính', N'A31206', N'CTK37', 7, 10, N'TN16', 34, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (324, N'Thực hành kỹ năng máy tính', N'A27.7', N'CTK37', 7, 10, N'CT60', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (325, N'Lập trình hướng đối tượng', N'A31303', N'CTK36', 7, 10, N'CT13', 34, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (327, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 1, 3, N'TN15', 34, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (328, N'Lập trình hướng đối tượng', N'A31303', N'CTK36', 7, 10, N'CT13', 34, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (329, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 7, 9, N'TN15', 34, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (330, N'Chuyên đề 1 (kỹ thuật phần mềm', N'A27.1', N'CTK34B', 7, 10, N'TN15', 34, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (331, N'Chuyên đề 1 (kỹ thuật phần mềm', N'A31206', N'CTK34B', 7, 10, N'TN15', 34, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (333, N'Photoshop', N'A6.MT', N'CTK36CD', 7, 10, N'CT59', 34, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (334, N'Công cụ và môi trường lập trìn', N'A7.6', N'CTK36CD', 1, 4, N'CT28', 34, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (335, N'Hệ điều hành', N'A31302', N'CTK36CD', 7, 10, N'CT02', 34, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (336, N'Công cụ và môi trường lập trìn', N'A31105', N'CTK36CD', 7, 10, N'CT28', 34, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (338, N'Hệ điều hành', N'A31302', N'CTK36CD', 7, 10, N'CT02', 34, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (340, N'Công cụ và môi trường lập trìn', N'A8.8.1', N'CTK36CD', 7, 10, N'CT28', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (341, N'Lập trình cấu trúc với C/C++', N'A31105', N'CTK37CD', 1, 4, N'CT13', 34, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (346, N'Thực hành kỹ năng máy tính', N'A27.7', N'CTK37CD', 1, 4, N'CT60', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (347, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 34, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (348, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 34, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (349, N'Điện tử tương tự', N'A27.5', NULL, 7, 10, N'TN16', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (350, N'Chuyên đề 1', N'A31201', NULL, 7, 9, N'TN20', 34, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (351, N'Chuyên đề 1', N'A7.6', NULL, 1, 3, N'TN20', 34, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (352, N'Thực tập chuyên đề 1', N'A21.3', NULL, 1, 4, N'TN20', 34, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (353, N'Nhập môn trí tuệ nhân tạo', N'A7.3', NULL, 7, 10, N'TN22', 34, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (354, N'TH. Nhập môn trí tuệ nhân tạo', N'A24LAU', NULL, 7, 10, N'TN22', 34, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (356, N'Chuyên đề cơ sở 1', N'A7.1', N'CTK35', 1, 5, N'CT46', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (357, N'Phát triển ứng dụng web với PH', N'A31205', N'CTK35', 7, 10, N'TH01', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (358, N'Phát triển ứng dụng web với PH', N'A31204', N'CTK35', 1, 4, N'TH01', 36, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (361, N'Công nghệ phần mềm', N'A8.6.2', N'CTK35', 7, 9, N'CT46', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (363, N'Phát triển ứng dụng web với PH', N'A31205', N'CTK35', 7, 10, N'TH01', 36, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (365, N'Chuyên đề 1', N'A31105', N'CTK36CD', 7, 10, N'CT07', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (368, N'Photoshop', N'A21.3', N'CTK36CD', 7, 9, N'CT59', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (371, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 1, 4, N'TN15', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (373, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 7, 10, N'TN15', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (374, N'Chuyên đề 2 (mạng và truyền th', N'A31201', N'CTK34A', 1, 4, N'CT65', 36, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (381, N'Bảo mật mạng', N'A27.4', N'CTK34A', 1, 3, N'CT07', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (382, N'Chuyên đề 2 (mạng và truyền th', N'A31206', N'CTK34A', 7, 10, N'CT65', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (383, N'Bảo mật mạng', N'A30.7', N'CTK34A', 1, 3, N'CT07', 36, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (385, N'Chuyên đề 2 (kỹ thuật phần mềm', N'A20104', N'CTK34B', 1, 5, N'CT46', 36, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (386, N'Lập trình Web nâng cao', N'A27.4', N'CTK34B', 7, 10, N'CT13', 36, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (387, N'Thiết kế mẫu', N'A20101', N'CTK34B', 1, 4, N'TH01', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (388, N'Quản trị dự án công nghệ TT', N'A31204', N'CTK34B', 7, 10, N'CT46', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (390, N'Lập trình Web nâng cao', N'A27.6', N'CTK34B', 7, 10, N'CT13', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (391, N'Thiết kế mẫu', N'A31206', N'CTK34B', 7, 10, N'TH01', 36, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (392, N'Thiết kế mẫu', N'A31303', N'CTK34B', 1, 4, N'TH01', 36, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (393, N'Chuyên đề 1 (kỹ thuật phần mềm', N'A30.1', N'CTK34B', 7, 10, N'TN15', 36, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (394, N'Công nghệ phần mềm', N'A27.6', NULL, 7, 10, N'TN15', 36, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (395, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (397, N'Công nghệ phần mềm', N'A31303', NULL, 7, 10, N'TN15', 36, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (398, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (400, N'Tin học cơ sở', N'A27.3', NULL, 1, 4, N'CT65', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (402, N'Lập trình cấu trúc với C/C++', N'A31105', N'CTK37CD', 1, 5, N'CT13', 36, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (404, N'Nhập môn trí tuệ nhân tạo', N'A27.3', NULL, 1, 5, N'TN22', 36, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (405, N'Xác suất - Thống kê', N'A31203', NULL, 1, 4, N'TN22', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (406, N'TH. Nhập môn trí tuệ nhân tạo', N'A24LAU', NULL, 7, 10, N'TN22', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (407, N'Xác suất - Thống kê', N'A7.4', NULL, 1, 4, N'TN22', 36, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (411, N'Tin học cơ sở', N'A7.2', NULL, 7, 10, N'CT07', 36, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (412, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (413, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (414, N'Tin học cơ sở', N'A20105', NULL, 1, 4, N'CT07', 36, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (415, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (416, N'Tin học cơ sở', N'A30.7', NULL, 7, 10, N'CT09', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (417, N'Tin học cơ sở', N'A7.8', NULL, 7, 10, N'CT09', 36, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (420, N'Thương mại điện tử', N'A31101', NULL, 1, 4, N'CT46', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (421, N'Thương mại điện tử', N'A31302', NULL, 1, 4, N'CT46', 36, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (422, N'Tin học cơ sở', N'A27.7', NULL, 1, 4, N'CT46', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (423, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 36, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (424, N'Điện tử tương tự', N'A20103', NULL, 1, 4, N'TN16', 36, 2)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (425, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 36, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (426, N'Điện tử tương tự', N'A27.5', NULL, 7, 10, N'TN16', 36, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (427, N'Chuyên đề 2 (mạng và truyền th', N'A31303', N'CTK34A', 1, 5, N'CT65', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (436, N'Thiết kế mẫu', N'A31201', N'CTK34B', 1, 5, N'TH01', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (437, N'Thiết kế mẫu', N'A30.5', N'CTK34B', 7, 10, N'TH01', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (438, N'Thiết kế mẫu', N'A31201', N'CTK34B', 1, 5, N'TH01', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (439, N'Thiết kế mẫu', N'A31205', N'CTK34B', 7, 10, N'TH01', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (441, N'Lập trình Web nâng cao', N'A31206', N'CTK34B', 7, 8, N'CT13', 37, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (443, N'Lập trình Web nâng cao', N'A27.5', N'CTK34B', 1, 4, N'CT13', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (444, N'Quản trị dự án công nghệ TT', N'A27.8', N'CTK34B', 11, 13, N'CT46', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (445, N'Chuyên đề 2 (kỹ thuật phần mềm', N'A31201', N'CTK34B', 1, 5, N'CT46', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (446, N'Chuyên đề 1 (kỹ thuật phần mềm', N'A27.10', N'CTK34B', 7, 10, N'TN15', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (451, N'Chuyên đề cơ sở 1', N'A8.5.2', N'CTK35', 1, 5, N'CT46', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (453, N'Trí tuệ nhân tạo', N'A31204', N'CTK35', 1, 4, N'TN22', 37, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (454, N'Phát triển ứng dụng web với PH', N'A8.7.1', N'CTK35', 7, 8, N'TH01', 37, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (458, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (461, N'Lập trình cấu trúc với C/C++', N'A31303', N'CTK37', 1, 3, N'TN15', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (466, N'Cấu trúc dữ liệu và thuật giải', N'A31205', N'CTK36', 7, 10, N'TN15', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (467, N'Kiến trúc và tổ chức máy tính', N'A30.7', N'CTK37CD', 7, 10, N'CT09', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (470, N'Kiến trúc và tổ chức máy tính', N'A27.12', N'CTK37CD', 7, 10, N'CT09', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (471, N'Chuyên đề 1', N'A20104', N'CTK36CD', 1, 4, N'CT07', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (473, N'Công cụ và môi trường lập trìn', N'A20101', N'CTK36CD', 1, 5, N'CT28', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (476, N'Công cụ và môi trường lập trìn', N'A27.5', N'CTK36CD', 7, 10, N'CT28', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (477, N'Công cụ và môi trường lập trìn', N'A31204', N'CTK36CD', 1, 5, N'CT28', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (478, N'Chuyên đề 1', N'A31205', N'CTK36CD', 7, 10, N'CT07', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (479, N'Thực tập chuyên đề 1', N'A21.3', NULL, 1, 5, N'TN20', 37, 6)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (480, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (481, N'Tin học cơ sở', N'A20105', NULL, 1, 3, N'CT07', 37, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (482, N'TH. Tin học cơ sở', N'A21.3', NULL, 11, 13, N'CT07', 37, 4)
GO
print 'Processed 200 total records'
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (483, N'Tin học cơ sở', N'A30.6', NULL, 11, 13, N'CT07', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (484, N'Xác suất - Thống kê', N'A27.2', NULL, 1, 4, N'TN22', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (485, N'TH. Nhập môn trí tuệ nhân tạo', N'A24LAU', NULL, 1, 4, N'TN22', 37, 6)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (486, N'Tin học cơ sở', N'A27.10', NULL, 11, 13, N'CT09', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (487, N'Tin học cơ sở', N'A7.4', NULL, 1, 4, N'CT09', 37, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (488, N'Tin học cơ sở', N'A31201', NULL, 11, 13, N'CT09', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (489, N'Tin học cơ sở', N'A27.8', NULL, 11, 13, N'CT09', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (490, N'Tin học cơ sở', N'A8.5.2', NULL, 7, 10, N'CT09', 37, 6)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (491, N'Thương mại điện tử', N'A27.12', NULL, 1, 4, N'CT46', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (492, N'Thương mại điện tử', N'A31302', NULL, 1, 4, N'CT46', 37, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (493, N'Tin học cơ sở', N'A27.7', NULL, 1, 4, N'CT46', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (494, N'Tin học cơ sở', N'A27.11', NULL, 7, 10, N'CT65', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (495, N'Tin học cơ sở', N'A31206', NULL, 1, 4, N'CT65', 37, 6)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (496, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 37, 1)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (497, N'Đo lường điện tử', N'A8.7.1', NULL, 1, 4, N'TN16', 37, 4)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (498, N'Cơ sở kỹ thuật điện tử', N'A31303', NULL, 1, 4, N'TN16', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (499, N'Điện tử tương tự', N'A27.5', NULL, 7, 10, N'TN16', 37, 5)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (500, N'Điện tử tương tự', N'A31204', NULL, 1, 4, N'TN16', 37, 6)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (501, N'Cơ sở kỹ thuật điện tử', N'A27.3', NULL, 7, 10, N'TN16', 37, 6)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (502, N'Công nghệ phần mềm', N'A27.6', NULL, 7, 10, N'TN15', 37, 0)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (503, N'Công nghệ phần mềm', N'A31303', NULL, 7, 10, N'TN15', 37, 3)
INSERT [dbo].[TkbGiangVien] ([MaTkb], [TenMonHoc], [Phong], [LopHoc], [TietBatDau], [TietKetThuc], [MaGv], [SttTuan], [NgayTrongTuan]) VALUES (504, N'Thương mại điện tử', N'A27.3', NULL, 1, 4, N'TN15', 37, 6)
SET IDENTITY_INSERT [dbo].[TkbGiangVien] OFF
/****** Object:  Table [dbo].[LichThucHanh]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichThucHanh](
	[MaLichTh] [int] IDENTITY(1,1) NOT NULL,
	[MonHocId] [int] NOT NULL,
	[TenPhong] [nvarchar](128) NOT NULL,
	[TenLop] [nvarchar](128) NOT NULL,
	[TietBatDau] [int] NOT NULL,
	[TietKetThuc] [int] NOT NULL,
	[SttTuan] [int] NOT NULL,
	[NgayTrongTuan] [int] NOT NULL,
	[Gvhd1] [nvarchar](10) NOT NULL,
	[Gvhd2] [nvarchar](10) NULL,
	[Gvhd3] [nvarchar](10) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[Gv1CoMat] [bit] NOT NULL,
	[Gv2CoMat] [bit] NOT NULL,
	[Gv3CoMat] [bit] NOT NULL,
	[GiangVien_MaGv] [nvarchar](10) NULL,
 CONSTRAINT [PK_dbo.LichThucHanh] PRIMARY KEY CLUSTERED 
(
	[MaLichTh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_GiangVien_MaGv] ON [dbo].[LichThucHanh] 
(
	[GiangVien_MaGv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Gvhd1] ON [dbo].[LichThucHanh] 
(
	[Gvhd1] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Gvhd2] ON [dbo].[LichThucHanh] 
(
	[Gvhd2] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Gvhd3] ON [dbo].[LichThucHanh] 
(
	[Gvhd3] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_MonHocId] ON [dbo].[LichThucHanh] 
(
	[MonHocId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_SttTuan] ON [dbo].[LichThucHanh] 
(
	[SttTuan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TenLop] ON [dbo].[LichThucHanh] 
(
	[TenLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TenPhong] ON [dbo].[LichThucHanh] 
(
	[TenPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LichThucHanh] ON
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (28, 40, N'A21.3', N'CTK34B', 1, 4, 38, 0, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (29, 4, N'A21.3', N'CTK34B', 11, 14, 38, 3, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (30, 40, N'A21.1', N'CTK34B', 11, 14, 38, 4, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (31, 34, N'A21.3', N'CTK34A', 7, 10, 38, 2, N'CT02', NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (32, 33, N'A21.3', N'CTK34A', 11, 13, 38, 2, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (33, 34, N'A21.3', N'CTK34A', 7, 10, 38, 4, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (34, 33, N'A21.3', N'CTK34A', 11, 13, 38, 5, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (35, 20, N'A21.3', N'CTK35', 7, 10, 38, 0, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (36, 21, N'A6.MT', N'CTK35', 11, 14, 38, 0, N'TN22', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (37, 25, N'A21.3', N'CTK35', 7, 10, 38, 1, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (38, 20, N'A21.3', N'CTK35', 7, 10, 38, 5, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (39, 21, N'A6.MT', N'CTK35', 11, 14, 38, 5, N'TN22', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (40, 17, N'A6.MT', N'CTK36', 7, 10, 38, 0, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (41, 18, N'A6.MT', N'CTK36', 1, 4, 38, 1, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (42, 17, N'A6.MT', N'CTK36', 7, 10, 38, 2, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (43, 18, N'A6.MT', N'CTK36', 1, 4, 38, 3, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (44, 11, N'A21.3', N'CTK36CD', 1, 4, 38, 2, N'CT59', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (45, 11, N'A21.3', N'CTK36CD', 1, 4, 38, 3, N'CT59', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (46, 12, N'A21.3', N'CTK36CD', 7, 10, 38, 3, N'CT28', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (47, 16, N'A6.MT', N'CTK36CD', 11, 14, 38, 3, N'CT07', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (48, 12, N'A6.MT', N'CTK36CD', 1, 4, 38, 4, N'CT28', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (49, 12, N'A21.3', N'CTK36CD', 1, 4, 38, 5, N'CT28', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (50, 2, N'A6.MT', N'CTK37', 11, 13, 38, 1, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (51, 2, N'A6.MT', N'CTK37', 11, 13, 38, 2, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (52, 3, N'A6.MT', N'CTK37', 7, 10, 38, 3, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (53, 2, N'A6.1', N'CTK37', 11, 13, 38, 4, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (54, 8, N'A6.MT', N'CTK37CD', 1, 4, 38, 2, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (55, 7, N'A6.2', N'CTK37CD', 1, 4, 38, 4, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (56, 8, N'A6.MT', N'CTK37CD', 7, 10, 38, 4, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (86, 2, N'A6.MT', N'CTK37', 11, 13, 35, 0, N'TN16', N'CT02', N'CT33', NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (87, 2, N'A6.MT', N'CTK37', 11, 13, 35, 2, N'TN16', N'CT02', N'CT33', NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (88, 3, N'A6.MT', N'CTK37', 7, 10, 35, 3, N'CT65', N'CT33', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (89, 36, N'A21.3', N'CTK34A', 7, 10, 35, 1, N'CT07', N'CT33', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (90, 34, N'A21.3', N'CTK34A', 7, 10, 35, 2, N'CT02', N'CT50', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (91, 34, N'A21.3', N'CTK34A', 7, 10, 35, 3, N'CT02', N'CT50', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (92, 11, N'A21.3', N'CTK36CD', 1, 4, 35, 1, N'CT59', N'CT33', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (93, 11, N'A21.3', N'CTK36CD', 1, 4, 35, 4, N'CT59', N'CT33', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (94, 18, N'A6.MT', N'CTK36', 1, 4, 35, 1, N'CT13', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (95, 18, N'A6.MT', N'CTK36', 1, 4, 35, 3, N'CT13', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (96, 26, N'A21.3', N'CTK35', 7, 10, 35, 0, N'CT28', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (97, 26, N'A6.MT', N'CTK35', 7, 10, 35, 2, N'CT28', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (98, 21, N'A6.MT', N'CTK35', 1, 4, 35, 4, N'TN22', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (99, 10, N'A6.1', N'CTK37CD', 1, 4, 35, 1, N'CT50', N'CT68', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (100, 8, N'A6.MT', N'CTK37CD', 1, 4, 35, 2, N'CT13', N'CT46', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (101, 7, N'A6.2', N'CTK37CD', 7, 10, 35, 3, N'CT60', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (102, 8, N'A6.MT', N'CTK37CD', 7, 10, 35, 4, N'CT13', N'CT25', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (103, 36, N'A21.3', N'CTK34A', 7, 10, 34, 1, N'CT07', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (104, 34, N'A21.3', N'CTK34A', 7, 10, 34, 2, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (105, 26, N'A21.3', N'CTK35', 7, 10, 34, 0, N'CT28', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (106, 26, N'A21.3', N'CTK35', 1, 4, 34, 2, N'CT28', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (107, 2, N'A6.MT', N'CTK37', 11, 13, 34, 2, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (108, 2, N'A6.MT', N'CTK37', 11, 13, 34, 3, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (109, 18, N'A6.MT', N'CTK36', 1, 4, 34, 1, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (110, 12, N'A21.3', N'CTK36CD', 1, 4, 34, 4, N'CT28', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (111, 10, N'A21.3', N'CTK37CD', 1, 4, 34, 1, N'CT50', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (112, 8, N'A6.MT', N'CTK37CD', 1, 4, 34, 2, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (113, 7, N'A6.MT', N'CTK37CD', 7, 10, 34, 3, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (114, 7, N'A6.MT', N'CTK37CD', 7, 10, 34, 4, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (115, 20, N'A21.3', N'CTK35', 7, 10, 36, 0, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (116, 25, N'A21.1', N'CTK35', 7, 10, 36, 3, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (117, 21, N'A6.MT', N'CTK35', 1, 4, 36, 4, N'TN22', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (118, 20, N'A21.3', N'CTK35', 1, 4, 36, 5, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (119, 11, N'A21.3', N'CTK36CD', 1, 4, 36, 1, N'CT59', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (120, 11, N'A21.3', N'CTK36CD', 1, 4, 36, 4, N'CT59', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (121, 18, N'A6.MT', N'CTK36', 1, 4, 36, 1, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (122, 18, N'A6.MT', N'CTK36', 1, 4, 36, 3, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (123, 36, N'A21.3', N'CTK34A', 7, 10, 36, 1, N'CT07', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (124, 34, N'A21.3', N'CTK34A', 7, 10, 36, 2, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (125, 34, N'A21.3', N'CTK34A', 7, 10, 36, 3, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (126, 33, N'A21.3', N'CTK34A', 7, 10, 36, 5, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (127, 3, N'A6.MT', N'CTK37', 7, 10, 36, 3, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (128, 8, N'A6.MT', N'CTK37CD', 1, 4, 36, 2, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (129, 2, N'A6.MT', N'CTK37', 11, 13, 36, 0, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (130, 2, N'A6.MT', N'CTK37', 11, 13, 36, 2, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (131, 10, N'A6.MT', N'CTK37CD', 7, 10, 36, 5, N'CT50', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (132, 7, N'A6.MT', N'CTK37CD', 7, 10, 36, 2, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (133, 36, N'A6.2', N'CTK34A', 7, 10, 37, 0, N'CT07', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (134, 36, N'A21.3', N'CTK34A', 7, 10, 37, 1, N'CT07', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (135, 34, N'A21.3', N'CTK34A', 7, 8, 37, 3, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (136, 33, N'A6.2', N'CTK34A', 1, 4, 37, 4, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (137, 34, N'A21.3', N'CTK34A', 7, 10, 37, 4, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (138, 33, N'A21.3', N'CTK34A', 7, 10, 37, 5, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (139, 4, N'A21.3', N'CTK34B', 11, 13, 37, 3, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (140, 40, N'A21.3', N'CTK34B', 11, 13, 37, 5, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (141, 26, N'A21.3', N'CTK35', 1, 6, 37, 0, N'CT28', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (142, 20, N'A21.3', N'CTK35', 7, 10, 37, 0, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (143, 21, N'A6.MT', N'CTK35', 11, 14, 37, 0, N'TN22', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (144, 25, N'A21.1', N'CTK35', 7, 10, 37, 1, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (145, 25, N'A21.1', N'CTK35', 7, 10, 37, 4, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (146, 21, N'A6.MT', N'CTK35', 11, 14, 37, 5, N'TN22', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (147, 2, N'A6.MT', N'CTK37', 11, 13, 37, 4, N'TN16', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (148, 18, N'A6.MT', N'CTK36', 1, 4, 37, 1, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (149, 18, N'A6.MT', N'CTK36', 1, 4, 37, 3, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (150, 7, N'A6.MT', N'CTK37CD', 1, 4, 37, 4, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (151, 8, N'A6.MT', N'CTK37CD', 7, 10, 37, 4, N'CT13', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (152, 12, N'A6.MT', N'CTK36CD', 7, 10, 37, 0, N'CT28', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (153, 16, N'A6.MT', N'CTK36CD', 11, 14, 37, 3, N'CT07', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (154, 11, N'A21.3', N'CTK36CD', 1, 4, 37, 4, N'CT59', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (155, 32, N'A21.3', N'CTK34B', 1, 4, 38, 4, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (156, 32, N'A21.1', N'CTK34B', 1, 4, 38, 5, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (157, 39, N'A21.3', N'CTK34A', 1, 5, 38, 1, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (158, 31, N'A6.MT', N'CTK37', 1, 4, 38, 0, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (159, 1, N'A6.MT', N'CTK37', 7, 10, 38, 1, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (160, 1, N'A6.MT', N'CTK37', 1, 4, 38, 5, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (167, 31, N'A6.MT', N'CTK37', 1, 4, 35, 0, N'CT60', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (168, 1, N'A6.MT', N'CTK37', 7, 10, 35, 1, N'TN15', N'CT13', N'CT51', NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (169, 39, N'A21.1', N'CTK34A', 1, 4, 35, 1, N'CT65', N'CT02', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (170, 14, N'A21.3', N'CTK36CD', 1, 4, 35, 0, N'CT02', N'CT68', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (171, 14, N'A21.3', N'CTK36CD', 1, 4, 35, 3, N'CT02', N'CT68', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (172, 29, N'A21.1', N'CTK35CD', 7, 10, 34, 1, N'TH01', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (173, 29, N'A21.1', N'CTK35CD', 7, 10, 34, 2, N'TH01', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (174, 29, N'A21.1', N'CTK35CD', 7, 10, 34, 3, N'TH01', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (175, 29, N'A21.1', N'CTK35CD', 7, 10, 34, 4, N'TH01', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (176, 29, N'A21.1', N'CTK35CD', 7, 10, 34, 5, N'TH01', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (177, 31, N'A6.MT', N'CTK37', 1, 4, 34, 0, N'CT60', N'CT51', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (178, 1, N'A6.MT', N'CTK37', 7, 10, 34, 1, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (179, 1, N'A6.MT', N'CTK37', 1, 4, 34, 5, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (180, 14, N'A21.3', N'CTK36CD', 1, 4, 34, 0, N'CT02', N'CT68', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (181, 14, N'A21.3', N'CTK36CD', 1, 4, 34, 3, N'CT02', N'CT68', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (182, 14, N'A21.3', N'CTK36CD', 11, 13, 36, 3, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (183, 14, N'A6.MT', N'CTK36CD', 11, 13, 36, 4, N'CT02', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (184, 39, N'A21.1', N'CTK34A', 1, 4, 36, 1, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (185, 39, N'A21.3', N'CTK34A', 1, 4, 36, 3, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (186, 32, N'A6.MT', N'CTK34B', 11, 13, 36, 1, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (187, 1, N'A6.MT', N'CTK37', 7, 10, 36, 1, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (188, 1, N'A6.MT', N'CTK37', 1, 4, 36, 5, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (189, 31, N'A6.MT', N'CTK37', 1, 4, 36, 0, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (190, 39, N'A21.3', N'CTK34A', 1, 4, 37, 1, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (191, 39, N'A21.3', N'CTK34A', 1, 4, 37, 3, N'CT65', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (192, 32, N'A6.MT', N'CTK34B', 11, 13, 37, 1, N'CT46', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (193, 31, N'A6.MT', N'CTK37', 1, 4, 37, 0, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (194, 1, N'A6.MT', N'CTK37', 7, 10, 37, 1, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (195, 31, N'A6.MT', N'CTK37', 7, 8, 37, 3, N'CT60', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (196, 1, N'A6.MT', N'CTK37', 1, 4, 37, 5, N'TN15', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (197, 37, N'A21.3', N'CTK34A', 1, 5, 35, 2, N'TN20', N'CT65', NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (198, 23, N'A6.MT', N'CTK35', 11, 13, 35, 1, N'CT25', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (199, 23, N'A6.MT', N'CTK35', 11, 13, 35, 3, N'CT25', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (200, 23, N'A6.MT', N'CTK35', 11, 13, 35, 4, N'CT25', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (201, 37, N'A21.3', N'CTK34A', 7, 10, 34, 3, N'TN20', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (202, 37, N'A21.3', N'CTK34A', 7, 10, 34, 5, N'TN20', NULL, NULL, NULL, 1, 1, 1, NULL)
INSERT [dbo].[LichThucHanh] ([MaLichTh], [MonHocId], [TenPhong], [TenLop], [TietBatDau], [TietKetThuc], [SttTuan], [NgayTrongTuan], [Gvhd1], [Gvhd2], [Gvhd3], [GhiChu], [Gv1CoMat], [Gv2CoMat], [Gv3CoMat], [GiangVien_MaGv]) VALUES (203, 37, N'A21.3', N'CTK34A', 1, 5, 36, 2, N'TN20', NULL, NULL, NULL, 1, 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[LichThucHanh] OFF
/****** Object:  Table [dbo].[LichCongTac]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichCongTac](
	[LichCongTacId] [int] IDENTITY(1,1) NOT NULL,
	[MaGv] [nvarchar](10) NOT NULL,
	[LyDo] [nvarchar](max) NULL,
	[ThoiGianBd] [datetime] NOT NULL,
	[ThoiGianKt] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.LichCongTac] PRIMARY KEY CLUSTERED 
(
	[LichCongTacId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_MaGv] ON [dbo].[LichCongTac] 
(
	[MaGv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichBan]    Script Date: 04/27/2014 15:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichBan](
	[LichBanId] [int] IDENTITY(1,1) NOT NULL,
	[MaGv] [nvarchar](10) NULL,
	[SttTuan] [int] NOT NULL,
	[TrangThaiBan] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.LichBan] PRIMARY KEY CLUSTERED 
(
	[LichBanId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_MaGv] ON [dbo].[LichBan] 
(
	[MaGv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_SttTuan] ON [dbo].[LichBan] 
(
	[SttTuan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Default [DF__webpages___IsCon__2C3393D0]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [IsConfirmed]
GO
/****** Object:  Default [DF__webpages___Passw__2D27B809]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [PasswordFailuresSinceLastSuccess]
GO
/****** Object:  ForeignKey [FK_dbo.GiangVien_dbo.UserProfile_UserProfileId]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GiangVien_dbo.UserProfile_UserProfileId] FOREIGN KEY([UserProfileId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_dbo.GiangVien_dbo.UserProfile_UserProfileId]
GO
/****** Object:  ForeignKey [fk_RoleId]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[webpages_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_RoleId]
GO
/****** Object:  ForeignKey [fk_UserId]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_UserId]
GO
/****** Object:  ForeignKey [FK_dbo.PhanCongGiangDay_dbo.GiangVien_MaGv]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[PhanCongGiangDay]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PhanCongGiangDay_dbo.GiangVien_MaGv] FOREIGN KEY([MaGv])
REFERENCES [dbo].[GiangVien] ([MaGv])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhanCongGiangDay] CHECK CONSTRAINT [FK_dbo.PhanCongGiangDay_dbo.GiangVien_MaGv]
GO
/****** Object:  ForeignKey [FK_dbo.PhanCongGiangDay_dbo.Lop_TenLop]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[PhanCongGiangDay]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PhanCongGiangDay_dbo.Lop_TenLop] FOREIGN KEY([TenLop])
REFERENCES [dbo].[Lop] ([TenLop])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhanCongGiangDay] CHECK CONSTRAINT [FK_dbo.PhanCongGiangDay_dbo.Lop_TenLop]
GO
/****** Object:  ForeignKey [FK_dbo.PhanCongGiangDay_dbo.MonHoc_MonHocId]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[PhanCongGiangDay]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PhanCongGiangDay_dbo.MonHoc_MonHocId] FOREIGN KEY([MonHocId])
REFERENCES [dbo].[MonHoc] ([MonHocId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhanCongGiangDay] CHECK CONSTRAINT [FK_dbo.PhanCongGiangDay_dbo.MonHoc_MonHocId]
GO
/****** Object:  ForeignKey [FK_dbo.TkbGiangVien_dbo.GiangVien_MaGv]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[TkbGiangVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TkbGiangVien_dbo.GiangVien_MaGv] FOREIGN KEY([MaGv])
REFERENCES [dbo].[GiangVien] ([MaGv])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TkbGiangVien] CHECK CONSTRAINT [FK_dbo.TkbGiangVien_dbo.GiangVien_MaGv]
GO
/****** Object:  ForeignKey [FK_dbo.TkbGiangVien_dbo.TuanHoc_SttTuan]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[TkbGiangVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TkbGiangVien_dbo.TuanHoc_SttTuan] FOREIGN KEY([SttTuan])
REFERENCES [dbo].[TuanHoc] ([SttTuan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TkbGiangVien] CHECK CONSTRAINT [FK_dbo.TkbGiangVien_dbo.TuanHoc_SttTuan]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.GiangVien_GiangVien_MaGv]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_GiangVien_MaGv] FOREIGN KEY([GiangVien_MaGv])
REFERENCES [dbo].[GiangVien] ([MaGv])
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_GiangVien_MaGv]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd1]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd1] FOREIGN KEY([Gvhd1])
REFERENCES [dbo].[GiangVien] ([MaGv])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd1]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd2]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd2] FOREIGN KEY([Gvhd2])
REFERENCES [dbo].[GiangVien] ([MaGv])
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd2]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd3]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd3] FOREIGN KEY([Gvhd3])
REFERENCES [dbo].[GiangVien] ([MaGv])
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.GiangVien_Gvhd3]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.Lop_TenLop]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.Lop_TenLop] FOREIGN KEY([TenLop])
REFERENCES [dbo].[Lop] ([TenLop])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.Lop_TenLop]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.MonHoc_MonHocId]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.MonHoc_MonHocId] FOREIGN KEY([MonHocId])
REFERENCES [dbo].[MonHoc] ([MonHocId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.MonHoc_MonHocId]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.PhongThucHanh_TenPhong]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.PhongThucHanh_TenPhong] FOREIGN KEY([TenPhong])
REFERENCES [dbo].[PhongThucHanh] ([TenPhong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.PhongThucHanh_TenPhong]
GO
/****** Object:  ForeignKey [FK_dbo.LichThucHanh_dbo.TuanHoc_SttTuan]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichThucHanh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThucHanh_dbo.TuanHoc_SttTuan] FOREIGN KEY([SttTuan])
REFERENCES [dbo].[TuanHoc] ([SttTuan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichThucHanh] CHECK CONSTRAINT [FK_dbo.LichThucHanh_dbo.TuanHoc_SttTuan]
GO
/****** Object:  ForeignKey [FK_dbo.LichCongTac_dbo.GiangVien_MaGv]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichCongTac]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichCongTac_dbo.GiangVien_MaGv] FOREIGN KEY([MaGv])
REFERENCES [dbo].[GiangVien] ([MaGv])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichCongTac] CHECK CONSTRAINT [FK_dbo.LichCongTac_dbo.GiangVien_MaGv]
GO
/****** Object:  ForeignKey [FK_dbo.LichBan_dbo.GiangVien_MaGv]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichBan]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichBan_dbo.GiangVien_MaGv] FOREIGN KEY([MaGv])
REFERENCES [dbo].[GiangVien] ([MaGv])
GO
ALTER TABLE [dbo].[LichBan] CHECK CONSTRAINT [FK_dbo.LichBan_dbo.GiangVien_MaGv]
GO
/****** Object:  ForeignKey [FK_dbo.LichBan_dbo.TuanHoc_SttTuan]    Script Date: 04/27/2014 15:28:35 ******/
ALTER TABLE [dbo].[LichBan]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichBan_dbo.TuanHoc_SttTuan] FOREIGN KEY([SttTuan])
REFERENCES [dbo].[TuanHoc] ([SttTuan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichBan] CHECK CONSTRAINT [FK_dbo.LichBan_dbo.TuanHoc_SttTuan]
GO
