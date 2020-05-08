CREATE DATABASE [HotelSoftware]

USE [HotelSoftware]
GO
/****** Object:  Table [dbo].[ChiTietPhieuThue]    Script Date: 5/7/2020 1:57:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuThue](
	[MaChiTietPhieuThue] [varchar](8) NOT NULL,
	[NgayVao] [date] NULL,
	[NgayRa] [date] NULL,
	[HinhThucThue] [bit] NULL,
	[SoLuongKhach] [tinyint] NULL,
	[MaPhong] [varchar](8) NULL,
	[MaPhieuThuePhong] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [varchar](8) NOT NULL,
	[TenDV] [nvarchar](20) NULL,
	[DonGia] [float] NULL,
	[MaLoaiDV] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](8) NOT NULL,
	[TienPhong] [float] NULL,
	[TienDV] [float] NULL,
	[TongTien] [float] NULL,
	[HinhThucThanhToan] [bit] NULL,
	[NgayThanhToan] [date] NULL,
	[GhiChu] [nvarchar](500) NULL,
	[MaPhieuThuePhong] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](8) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[SoCMND] [char](12) NULL,
	[DiaChi] [nvarchar](20) NULL,
	[SDT] [char](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiDichVu]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiDichVu](
	[MaLoaiDV] [varchar](8) NOT NULL,
	[TenLoaiDV] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoai] [varchar](8) NOT NULL,
	[TenLoai] [nvarchar](30) NULL,
	[SoNguoi] [tinyint] NULL,
	[GhiChu] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](8) NOT NULL,
	[TenTk] [varchar](30) NULL,
	[MatKhau] [varchar](30) NULL,
	[Quyen] [bit] NULL,
	[HoTen] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [char](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuSuDungDichVu]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuSuDungDichVu](
	[MaSD] [varchar](8) NOT NULL,
	[NgaySD] [date] NULL,
	[SoLuong] [tinyint] NULL,
	[GiaTien] [float] NULL,
	[MaDV] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuThuePhong]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuThuePhong](
	[MaPhieuThuePhong] [varchar](8) NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
	[MaKH] [varchar](8) NULL,
	[MaNV] [varchar](8) NULL,
	[MaSD] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuePhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](8) NOT NULL,
	[TenPhong] [nvarchar](20) NULL,
	[TinhTrang] [tinyint] NULL,
	[DienTich] [int] NULL,
	[GiaThue] [float] NULL,
	[MaLoai] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT01', CAST(N'2019-08-07' AS Date), CAST(N'2019-08-20' AS Date), 0, 2, N'MP01', N'MPTP01')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT02', CAST(N'2019-08-03' AS Date), CAST(N'2019-08-30' AS Date), 1, 1, N'MP02', N'MPTP02')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT03', CAST(N'2019-12-07' AS Date), CAST(N'2019-12-17' AS Date), 1, 2, N'MP03', N'MPTP03')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT05', CAST(N'2019-12-06' AS Date), CAST(N'2019-12-18' AS Date), 0, 2, N'MP05', N'MPTP05')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT06', CAST(N'2019-02-12' AS Date), CAST(N'2019-02-25' AS Date), 1, 2, N'MP06', N'MPTP06')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT07', CAST(N'2019-01-11' AS Date), CAST(N'2019-01-23' AS Date), 1, 4, N'MP07', N'MPTP07')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT08', CAST(N'2019-06-08' AS Date), CAST(N'2019-06-29' AS Date), 1, 3, N'MP08', N'MPTP08')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT09', CAST(N'2019-08-09' AS Date), CAST(N'2019-08-20' AS Date), 0, 2, N'MP09', N'MPTP09')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT10', CAST(N'2019-01-03' AS Date), CAST(N'2019-01-17' AS Date), 0, 2, N'MP10', N'MPTP10')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT11', CAST(N'2019-08-01' AS Date), CAST(N'2019-08-15' AS Date), 0, 1, N'MP11', N'MPTP11')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT12', CAST(N'2019-02-13' AS Date), CAST(N'2019-02-25' AS Date), 1, 1, N'MP12', N'MPTP12')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT13', CAST(N'2019-11-05' AS Date), CAST(N'2019-11-17' AS Date), 1, 1, N'MP13', N'MPTP13')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT14', CAST(N'2019-12-09' AS Date), CAST(N'2019-12-18' AS Date), 0, 1, N'MP14', N'MPTP14')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT15', CAST(N'2019-07-02' AS Date), CAST(N'2019-07-28' AS Date), 1, 2, N'MP15', N'MPTP15')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT16', CAST(N'2019-01-10' AS Date), CAST(N'2019-01-17' AS Date), 1, 1, N'MP16', N'MPTP16')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT17', CAST(N'2019-03-10' AS Date), CAST(N'2019-03-30' AS Date), 1, 3, N'MP01', N'MPTP17')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT18', CAST(N'2019-01-01' AS Date), CAST(N'2019-01-26' AS Date), 1, 3, N'MP02', N'MPTP18')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT19', CAST(N'2019-05-09' AS Date), CAST(N'2019-05-30' AS Date), 1, 2, N'MP03', N'MPTP19')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT20', CAST(N'2019-12-04' AS Date), CAST(N'2019-12-18' AS Date), 1, 2, N'MP04', N'MPTP20')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT21', CAST(N'2019-07-12' AS Date), CAST(N'2019-07-26' AS Date), 1, 3, N'MP05', N'MPTP21')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT22', CAST(N'2019-10-02' AS Date), CAST(N'2019-10-16' AS Date), 1, 3, N'MP06', N'MPTP22')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT23', CAST(N'2019-09-11' AS Date), CAST(N'2019-09-15' AS Date), 1, 4, N'MP07', N'MPTP23')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT24', CAST(N'2019-11-03' AS Date), CAST(N'2019-11-18' AS Date), 1, 1, N'MP08', N'MPTP24')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT25', CAST(N'2019-08-13' AS Date), CAST(N'2019-08-30' AS Date), 1, 5, N'MP09', N'MPTP25')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT26', CAST(N'2019-08-08' AS Date), CAST(N'2019-08-22' AS Date), 0, 2, N'MP10', N'MPTP26')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT27', CAST(N'2019-09-04' AS Date), CAST(N'2019-09-30' AS Date), 1, 3, N'MP11', N'MPTP27')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT28', CAST(N'2019-01-10' AS Date), CAST(N'2019-01-18' AS Date), 1, 1, N'MP12', N'MPTP28')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT29', CAST(N'2019-02-11' AS Date), CAST(N'2019-02-18' AS Date), 1, 1, N'MP13', N'MPTP29')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT30', CAST(N'2019-10-02' AS Date), CAST(N'2019-10-15' AS Date), 1, 2, N'MP14', N'MPTP30')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT32', CAST(N'2019-02-02' AS Date), CAST(N'2019-02-18' AS Date), 1, 2, N'MP16', N'MPTP32')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT33', CAST(N'2019-11-02' AS Date), CAST(N'2019-11-15' AS Date), 1, 2, N'MP01', N'MPTP33')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT34', CAST(N'2019-05-10' AS Date), CAST(N'2019-05-27' AS Date), 1, 2, N'MP02', N'MPTP34')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT35', CAST(N'2019-09-11' AS Date), CAST(N'2019-09-30' AS Date), 1, 3, N'MP03', N'MPTP35')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT36', CAST(N'2019-02-09' AS Date), CAST(N'2019-02-24' AS Date), 1, 1, N'MP04', N'MPTP36')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT37', CAST(N'2019-02-05' AS Date), CAST(N'2019-02-18' AS Date), 1, 1, N'MP05', N'MPTP37')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT38', CAST(N'2019-02-12' AS Date), CAST(N'2019-02-26' AS Date), 1, 1, N'MP06', N'MPTP38')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT39', CAST(N'2019-01-03' AS Date), CAST(N'2019-01-23' AS Date), 1, 2, N'MP07', N'MPTP39')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT40', CAST(N'2019-02-12' AS Date), CAST(N'2019-03-02' AS Date), 0, 2, N'MP08', N'MPTP40')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT41', CAST(N'2019-02-12' AS Date), CAST(N'2019-03-02' AS Date), 0, 3, N'MP09', N'MPTP01')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV01', N'mì xào hải sản', 100000, N'MLDV01')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV02', N'tôm hùm hấp bia', 1000000, N'MLDV01')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV03', N'cơm rang hải sản', 70000, N'MLDV01')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV04', N'pepsi', 10000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV05', N'7up', 10000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV06', N'trà đào', 15000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV07', N'cocacola', 10000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV08', N'bia sài gòn', 12000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV09', N'hút mụn', 100000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV10', N'massage mặt', 100000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV11', N'xăm môi', 200000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV12', N'xăm lông mày', 150000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV13', N'giặt đồ', 50000, N'MLDV04')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV14', N'karaoke', 200000, N'MLDV05')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV15', N'trông trẻ', 80000, N'MLDV06')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [HinhThucThanhToan], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong]) VALUES (N'MHD01', 3820000, 1000000, 4820000, 0, CAST(N'2019-08-07' AS Date), N'', N'MPTP01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [HinhThucThanhToan], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong]) VALUES (N'MHD02', 1000000, 232321, 1232321, 1, CAST(N'2019-08-03' AS Date), N'', N'MPTP02')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [HinhThucThanhToan], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong]) VALUES (N'MHD03', 800000, 200000, 100000, 1, CAST(N'2019-12-07' AS Date), N'', N'MPTP03')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [HinhThucThanhToan], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong]) VALUES (N'MHD05', 2000000, 368000, 2368000, 1, CAST(N'2019-12-06' AS Date), N'', N'MPTP05')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH01', N'Nhật Thị Mai', N'152222791   ', N'Nghệ An', N'0320619713  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH02', N'Cao Thái Thuý', N'152222754   ', N'Hà Nội', N'0360016135  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH03', N'Dương Cao Kỳ Hà', N'120746600   ', N'Quảng Bình', N'0450418548  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH04', N'Cao Thái Thảo', N'160336487   ', N'Thanh Hóa', N'0160947417  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH05', N'Đàm Hoài Hà', N'120435879   ', N'Ninh Bình', N'0450780809  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH06', N'Tôn Thanh Linh', N'160491989   ', N'Hà Nam', N'0980375789  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH07', N'Văn Lê Ngọc', N'160703395   ', N'Thái Bình', N'0320943955  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH08', N'Bùi Thương Quyên', N'150797834   ', N'Nghệ An', N'0920905428  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH09', N'Đinh Thu Tám', N'120163489   ', N'Nghệ An', N'0980681788  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH10', N'Lê Hoài Tám', N'120680791   ', N'Nha Trang', N'0820151829  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH11', N'Phùng Xuân Ly', N'160653256   ', N'Lào Cai', N'0160498848  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH12', N'Bùi Hoàng Ý', N'160669526   ', N'Quảng Ninh', N'0960352339  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH13', N'Lương Hoài Hoa', N'160207401   ', N'Quảng Bình', N'0160821009  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH14', N'Phùng Châu Gấm', N'160240401   ', N'Ninh Thuận', N'0920829114  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH15', N'Phùng Cẩm Hương', N'160390157   ', N'Cần Thơ', N'0960594347  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH16', N'Dương Ngọc Ngọc', N'110777750   ', N'Nghệ An', N'0820078078  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH17', N'Phan Khánh Tâm', N'160156537   ', N'Thái Bình', N'0980383812  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH18', N'Hồ Hải Lan', N'180839147   ', N'Hải Phòng', N'0360640798  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH19', N'Đinh Thái Lan', N'150368448   ', N'Nam Định', N'0450025744  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH20', N'Vũ Hải Cúc', N'160583850   ', N'Bình Định', N'0980282788  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH21', N'Tăng Cẩm Hậu', N'160629087   ', N'Thanh Hóa', N'0910224056  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH22', N'Phùng Minh Nhân', N'120047740   ', N'Cần Thơ', N'0920871778  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH23', N'Phan Thu An', N'120455940   ', N'Ninh Bình', N'0920988999  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH24', N'Trương Thu Nhi', N'160101736   ', N'Cà Mau', N'0160748499  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH25', N'Lê Bình Tâm', N'160492965   ', N'Quảng Nam', N'0160965763  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH26', N'Nhật Thương Quyên', N'120317947   ', N'Nghệ An', N'0160890526  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH27', N'Đoàn Thái Liên', N'120295460   ', N'Nghệ An', N'0360692144  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH28', N'Trương Bình Ngân', N'110637257   ', N'Quảng Nam', N'0920621452  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH29', N'Ngô Hoàng Bình Thanh', N'160824064   ', N'Cà Mau', N'0360152802  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH30', N'Nhật Khánh Bích', N'160617515   ', N'Thái Bình', N'0980297473  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH31', N'Lê Thương Gấm', N'110229143   ', N'Thanh Hóa', N'0820694992  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH32', N'Trương Như Huyền', N'120575002   ', N'Hà Nội', N'0820274402  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH33', N'Tôn Minh Nhân', N'120664353   ', N'Phú Thọ', N'0960558366  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH34', N'Chu Thương Oanh', N'120402687   ', N'Yên Bái', N'0820279002  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH35', N'Tôn Bình Giang', N'160463059   ', N'Lai Châu', N'0960449641  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH36', N'Nhật Thái Lụa', N'120100324   ', N'Bắc Giang', N'0980657333  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH37', N'Phan Bình Thanh', N'160460277   ', N'Điện Biên', N'0160315853  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH38', N'Trương Bình Hoa', N'110411267   ', N'Hòa Bình', N'0960696834  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH39', N'Tăng Hoài Hồng', N'160451184   ', N'Sóc Trăng', N'0820157866  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH40', N'Lê Hoàng Ba', N'120603312   ', N'Cần Thơ', N'0820632156  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH41', N'Lê Văn Long', N'187622531   ', N'Hà Nội', N'0334312344  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH42', N'Đặng Nhật Qúy', N'187522451   ', N'Đà Nẵng', N'0982318725  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH45', N'1', N'1           ', N'1', N'1           ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH46', N'3', N'3           ', N'3', N'3           ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH47', N'5', N'5           ', N'5', N'5           ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH48', N'Nguyễn Thị Bích', N'172344761   ', N'Tây Ninh', N'0367676566  ')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV01', N'đồ ăn')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV02', N'đồ uống')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV03', N'spa')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV04', N'giặt đồ')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV05', N'karaoke')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV06', N'trông trẻ')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP01', N'deluxe', 3, N'2 giường, 1 điều hòa, 1 tivi')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP02', N'luxury', 3, N'2 giường, 1 điều hòa, 1tivi')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP03', N'superio', 2, N'2 giường, 1 điều hòa, 1 tivi')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP04', N'suite', 4, N'2 giường, 1 điều hòa, 1 tivi')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV01', N'datproqhna', N'2', 1, N'Phạm Hoài Lam', CAST(N'1982-12-23' AS Date), N'0920503767  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV02', N'nv2', N'1', 1, N'Văn Thu Anh', CAST(N'1982-12-21' AS Date), N'0450035805  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV03', N'nv3', N'1', 0, N'Phạm Hoài Hương', CAST(N'1982-12-22' AS Date), N'0960375532  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV05', N'sonvt', N'son123', 0, N'Chu Thanh Anh', CAST(N'1982-12-24' AS Date), N'0820650522  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV06', N'nv6', N'1', 0, N'Ngô Cao Kỳ Lê', CAST(N'1982-12-25' AS Date), N'0920172226  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV07', N'1', N'1', 0, N'Hoàng Thu Nga', CAST(N'1982-12-26' AS Date), N'0920610346  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV08', N'2', N'2', 0, N'Trần Khánh Trân', CAST(N'1982-12-27' AS Date), N'0320686497  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV09', N'3', N'3', 0, N'Hoàng Ngô Diệu Lệ', CAST(N'1982-12-28' AS Date), N'0910978401  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV10', N'4', N'4', 0, N'Văn Diệu Trang', CAST(N'1982-12-29' AS Date), N'0960382807  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV11', N'5', N'5', 1, N'Vũ Châu Trân', CAST(N'1982-12-30' AS Date), N'0980032157  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV12', N'6', N'6', 0, N'Chu Bình Lê', CAST(N'1982-12-31' AS Date), N'0910904579  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV13', N'77', N'7', 0, N'Đinh Bình Hạnh', CAST(N'1983-01-01' AS Date), N'0980725291  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV14', N'8', N'8', 0, N'Hoàng Mỹ Nhân', CAST(N'1983-01-02' AS Date), N'0360869541  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV15', N'9', N'9', 0, N'Tôn Hoàng Lan', CAST(N'1983-01-03' AS Date), N'0980528151  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV16', N'11', N'11', 0, N'Phùng Thị Bích', CAST(N'1983-01-04' AS Date), N'0960402769  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV17', N'12', N'12', 0, N'Đàm Thương Mai', CAST(N'1983-01-05' AS Date), N'0360070222  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV18', N'13', N'13', 0, N'Ngô Khánh Nhung', CAST(N'1983-01-06' AS Date), N'0820302730  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV19', N'14', N'14', 0, N'Ngô Hoàng Mỹ Nhân', CAST(N'1983-01-07' AS Date), N'0920411337  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV20', N'15', N'15', 0, N'Đinh Khánh Tâm', CAST(N'1983-01-08' AS Date), N'0820490387  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV21', N'16', N'16', 1, N'Cao Thị Tư', CAST(N'1983-01-09' AS Date), N'0920393917  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV22', N'111', N'1', 0, N'Cao Hải Nguyệt', CAST(N'1983-01-10' AS Date), N'0360183219  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV23', N'121', N'1', 0, N'Hồ Hoàng Dung', CAST(N'1983-01-11' AS Date), N'0820700016  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV24', N'122', N'1', 0, N'Phạm Khánh Trang', CAST(N'1983-01-12' AS Date), N'0980880648  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV25', N'a', N'1', 0, N'Văn Xuân Trang', CAST(N'1983-01-13' AS Date), N'0820986093  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV26', N'b', N'1', 0, N'Phan Hoàng Ngọc', CAST(N'1983-01-14' AS Date), N'0320901231  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV27', N'c', N'1', 0, N'Hoàng Ngô Hồng Dung', CAST(N'1983-01-15' AS Date), N'0320743415  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV28', N'd', N'1', 0, N'Tăng Hồng Hoa', CAST(N'1983-01-16' AS Date), N'0450952025  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV29', N'e', N'1', 0, N'Quách Mỹ Anh', CAST(N'1983-01-17' AS Date), N'0450828455  ')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV01', CAST(N'2019-08-07' AS Date), 7, 700000, N'MDV01')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV02', CAST(N'2019-08-03' AS Date), 4, 4000000, N'MDV02')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV03', CAST(N'2019-12-07' AS Date), 4, 280000, N'MDV03')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV04', CAST(N'2019-01-04' AS Date), 5, 50000, N'MDV04')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV05', CAST(N'2019-12-06' AS Date), 2, 20000, N'MDV05')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV06', CAST(N'2019-02-12' AS Date), 2, 30000, N'MDV06')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV07', CAST(N'2019-01-11' AS Date), 5, 50000, N'MDV07')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV08', CAST(N'2019-06-08' AS Date), 4, 48000, N'MDV08')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV09', CAST(N'2019-08-09' AS Date), 6, 600000, N'MDV09')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV10', CAST(N'2019-01-03' AS Date), 5, 500000, N'MDV10')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV11', CAST(N'2019-08-01' AS Date), 4, 800000, N'MDV11')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV12', CAST(N'2019-02-13' AS Date), 2, 300000, N'MDV12')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV13', CAST(N'2019-11-05' AS Date), 4, 200000, N'MDV13')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV14', CAST(N'2019-12-09' AS Date), 8, 1600000, N'MDV14')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV15', CAST(N'2019-07-02' AS Date), 3, 40000, N'MDV15')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV16', CAST(N'2019-01-10' AS Date), 2, 1000000, N'MDV01')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV17', CAST(N'2019-03-10' AS Date), 7, 1000000, N'MDV02')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV18', CAST(N'2019-01-01' AS Date), 9, 1000000, N'MDV03')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV19', CAST(N'2019-05-09' AS Date), 9, 1000000, N'MDV04')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV20', CAST(N'2019-12-04' AS Date), 8, 1000000, N'MDV05')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV21', CAST(N'2019-07-12' AS Date), 8, 1000000, N'MDV06')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV22', CAST(N'2019-10-02' AS Date), 1, 1000000, N'MDV07')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV23', CAST(N'2019-09-11' AS Date), 2, 1000000, N'MDV08')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV24', CAST(N'2019-11-03' AS Date), 1, 1000000, N'MDV09')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV25', CAST(N'2019-08-13' AS Date), 7, 1000000, N'MDV10')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV26', CAST(N'2019-08-08' AS Date), 1, 1000000, N'MDV11')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV27', CAST(N'2019-09-04' AS Date), 2, 1000000, N'MDV12')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV28', CAST(N'2019-01-10' AS Date), 5, 1000000, N'MDV13')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV29', CAST(N'2019-02-11' AS Date), 4, 1000000, N'MDV14')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV30', CAST(N'2019-10-02' AS Date), 2, 1000000, N'MDV15')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV31', CAST(N'2019-01-03' AS Date), 8, 1000000, N'MDV02')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV32', CAST(N'2019-02-02' AS Date), 1, 1000000, N'MDV03')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV33', CAST(N'2019-11-02' AS Date), 2, 1000000, N'MDV04')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV34', CAST(N'2019-05-10' AS Date), 4, 1000000, N'MDV05')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV35', CAST(N'2019-09-11' AS Date), 4, 1000000, N'MDV06')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV36', CAST(N'2019-02-09' AS Date), 6, 1000000, N'MDV07')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV37', CAST(N'2019-02-05' AS Date), 4, 1000000, N'MDV08')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV38', CAST(N'2019-02-12' AS Date), 3, 1000000, N'MDV09')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV39', CAST(N'2019-01-03' AS Date), 7, 1000000, N'MDV10')
INSERT [dbo].[PhieuSuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaDV]) VALUES (N'MPDV40', CAST(N'2019-02-12' AS Date), 2, 1000000, N'MDV11')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP01', N'', N'MKH01', N'MNV01', N'MPDV01')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP02', N'', N'MKH02', N'MNV02', N'MPDV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP03', N'', N'MKH03', N'MNV03', N'MPDV03')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP05', N'', N'MKH05', N'MNV05', N'MPDV05')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP06', N'', N'MKH06', N'MNV06', N'MPDV06')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP07', N'', N'MKH07', N'MNV07', N'MPDV07')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP08', N'', N'MKH08', N'MNV08', N'MPDV08')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP09', N'', N'MKH09', N'MNV09', N'MPDV09')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP10', N'', N'MKH10', N'MNV10', N'MPDV10')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP11', N'', N'MKH11', N'MNV11', N'MPDV11')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP12', N'', N'MKH12', N'MNV12', N'MPDV12')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP13', N'', N'MKH13', N'MNV13', N'MPDV13')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP14', N'', N'MKH14', N'MNV14', N'MPDV14')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP15', N'', N'MKH15', N'MNV15', N'MPDV15')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP16', N'', N'MKH16', N'MNV16', N'MPDV16')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP17', N'', N'MKH17', N'MNV17', N'MPDV17')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP18', N'', N'MKH18', N'MNV18', N'MPDV18')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP19', N'', N'MKH19', N'MNV19', N'MPDV19')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP20', N'', N'MKH20', N'MNV20', N'MPDV20')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP21', N'', N'MKH21', N'MNV21', N'MPDV21')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP22', N'', N'MKH22', N'MNV22', N'MPDV22')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP23', N'', N'MKH23', N'MNV23', N'MPDV23')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP24', N'', N'MKH24', N'MNV24', N'MPDV24')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP25', N'', N'MKH25', N'MNV25', N'MPDV25')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP26', N'', N'MKH26', N'MNV26', N'MPDV26')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP27', N'', N'MKH27', N'MNV27', N'MPDV27')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP28', N'', N'MKH28', N'MNV28', N'MPDV28')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP29', N'', N'MKH29', N'MNV29', N'MPDV29')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP30', N'', N'MKH30', N'MNV03', N'MPDV30')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP32', N'', N'MKH32', N'MNV05', N'MPDV32')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP33', N'', N'MKH33', N'MNV06', N'MPDV33')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP34', N'', N'MKH34', N'MNV07', N'MPDV34')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP35', N'', N'MKH35', N'MNV08', N'MPDV35')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP36', N'', N'MKH36', N'MNV09', N'MPDV36')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP37', N'', N'MKH37', N'MNV10', N'MPDV37')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP38', N'', N'MKH38', N'MNV11', N'MPDV38')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP39', N'', N'MKH39', N'MNV12', N'MPDV39')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV], [MaSD]) VALUES (N'MPTP40', N'', N'MKH40', N'MNV13', N'MPDV40')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP01', N'101', 0, 100, 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP02', N'102', 1, 100, 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP03', N'103', 1, 70, 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP04', N'104', 0, 70, 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP05', N'201', 2, 100, 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP06', N'202', 1, 100, 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP07', N'203', 0, 20, 600000, N'MLP03')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP08', N'204', 2, 20, 600000, N'MLP03')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP09', N'301', 2, 70, 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP10', N'302', 1, 45, 300000, N'MLP01')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP11', N'303', 0, 70, 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP12', N'304', 1, 45, 300000, N'MLP01')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP13', N'401', 2, 100, 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP14', N'402', 1, 20, 600000, N'MLP03')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP15', N'403', 1, 100, 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP16', N'404', 0, 20, 600000, N'MLP03')
ALTER TABLE [dbo].[ChiTietPhieuThue]  WITH CHECK ADD FOREIGN KEY([MaPhieuThuePhong])
REFERENCES [dbo].[PhieuThuePhong] ([MaPhieuThuePhong])
GO
ALTER TABLE [dbo].[ChiTietPhieuThue]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD FOREIGN KEY([MaLoaiDV])
REFERENCES [dbo].[LoaiDichVu] ([MaLoaiDV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaPhieuThuePhong])
REFERENCES [dbo].[PhieuThuePhong] ([MaPhieuThuePhong])
GO
ALTER TABLE [dbo].[PhieuSuDungDichVu]  WITH CHECK ADD FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD FOREIGN KEY([MaSD])
REFERENCES [dbo].[PhieuSuDungDichVu] ([MaSD])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiPhong] ([MaLoai])
GO
/****** Object:  StoredProcedure [dbo].[addCus]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[addCus](@MAKH VARCHAR(8), @TENKH NVARCHAR(30), @CMND CHAR(12), @DIACHI NVARCHAR(20), @SDT CHAR(12))
	 AS
	 BEGIN
		INSERT INTO KhachHang (MaKH, TenKH, SoCMND, DiaChi, SDT) 
		VALUES (@MAKH, @TENKH, @CMND, @DIACHI, @SDT)
	 END
GO
/****** Object:  StoredProcedure [dbo].[addEmp]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[addEmp](@MANV VARCHAR(8), @HOTEN NVARCHAR(30), @NGAYSINH DATE, @SDT CHAR(12))
	 AS
	 BEGIN
		INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, SDT) 
		VALUES (@MANV, @HOTEN, @NGAYSINH, @SDT)
	 END
GO
/****** Object:  StoredProcedure [dbo].[changePass]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[changePass](@matkhauhientai varchar(30), @idnv varchar(8))
as
UPDATE dbo.NhanVien 
SET MatKhau= @matkhauhientai
WHERE MaNV= @idnv
GO
/****** Object:  StoredProcedure [dbo].[delCus]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delCus](@MAKH VARCHAR(8))
	 AS
	 BEGIN
		DELETE dbo.ChiTietPhieuThue 
			 WHERE dbo.ChiTietPhieuThue.MaPhieuThuePhong = (SELECT dbo.ChiTietPhieuThue.MaPhieuThuePhong 
															FROM dbo.KhachHang, dbo.PhieuThuePhong, dbo.ChiTietPhieuThue
															WHERE dbo.KhachHang.MaKH = dbo.PhieuThuePhong.MaKH AND
															dbo.ChiTietPhieuThue.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong AND
															@MaKH = dbo.PhieuThuePhong.MaKH)
			 DELETE dbo.HoaDon WHERE dbo.HoaDon.MaPhieuThuePhong = (SELECT dbo.HoaDon.MaPhieuThuePhong
																		  FROM dbo.KhachHang, dbo.PhieuThuePhong, dbo.HoaDon
																		  WHERE dbo.KhachHang.MaKH = dbo.PhieuThuePhong.MaKH AND
																		  dbo.HoaDon.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong AND
																		  @MaKH = dbo.PhieuThuePhong.MaKH)
			 DELETE dbo.PhieuThuePhong WHERE @MaKH = dbo.PhieuThuePhong.MaKH
			 DELETE dbo.KhachHang WHERE MaKH=@MaKH
	 END
GO
/****** Object:  StoredProcedure [dbo].[delEmp]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[delEmp](@MANV VARCHAR(8))
	 AS
	 BEGIN
			 DELETE dbo.ChiTietPhieuThue 
			 WHERE dbo.ChiTietPhieuThue.MaPhieuThuePhong = (SELECT dbo.ChiTietPhieuThue.MaPhieuThuePhong 
															FROM dbo.NhanVien, dbo.PhieuThuePhong, dbo.ChiTietPhieuThue
															WHERE dbo.NhanVien.MaNV = dbo.PhieuThuePhong.MaNV AND
															dbo.ChiTietPhieuThue.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong AND
															@MANV = dbo.PhieuThuePhong.MaNV)
			 DELETE dbo.HoaDon WHERE dbo.HoaDon.MaPhieuThuePhong = (SELECT dbo.HoaDon.MaPhieuThuePhong
																		  FROM dbo.NhanVien, dbo.PhieuThuePhong, dbo.HoaDon
																		  WHERE dbo.NhanVien.MaNV = dbo.PhieuThuePhong.MaNV AND
																		  dbo.HoaDon.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong AND
																		  @MANV = dbo.PhieuThuePhong.MaNV)
			 DELETE dbo.PhieuThuePhong WHERE @MANV = dbo.PhieuThuePhong.MaNV
			 DELETE dbo.NhanVien WHERE MaNV=@MANV
	 END
GO
/****** Object:  StoredProcedure [dbo].[DSKHTP]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[DSKHTP]
	 AS
	 BEGIN
		SELECT * FROM KhachHang
		WHERE KhachHang.MaKH IN (SELECT MaKH FROM dbo.PhieuThuePhong)
	 END
GO
/****** Object:  StoredProcedure [dbo].[DSNV]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[DSNV]
	 AS
	 BEGIN
		  SELECT * FROM NhanVien
		  ORDER BY DAY(NgaySinh), MONTH(NgaySinh), YEAR(NgaySinh)
	 END
GO
/****** Object:  StoredProcedure [dbo].[getAcc1]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAcc1]
as
SELECT dbo.NhanVien.MaNV, dbo.NhanVien.HoTen, dbo.NhanVien.TenTk, dbo.NhanVien.MatKhau, 
CASE WHEN Quyen=0 THEN N'Lễ Tân' WHEN Quyen=1 THEN N'Quản Lý' 
END AS Quyen
FROM dbo.NhanVien
GO
/****** Object:  StoredProcedure [dbo].[getAccount]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAccount]
AS 
SELECT dbo.NhanVien.MaNV, dbo.NhanVien.HoTen, dbo.NhanVien.TenTk, dbo.NhanVien.MatKhau, Quyen,
CASE WHEN Quyen=0 THEN N'Lễ Tân' WHEN Quyen=1 THEN N'Quản Lý' 
END AS Quyen 
FROM dbo.NhanVien
GO
/****** Object:  StoredProcedure [dbo].[getallCus]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getallCus]
AS SELECT * FROM dbo.KhachHang
GO
/****** Object:  StoredProcedure [dbo].[getallEmp]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[getallEmp]
AS SELECT dbo.NhanVien.MaNV, dbo.NhanVien.HoTen, NgaySinh, SDT FROM dbo.NhanVien
GO
/****** Object:  StoredProcedure [dbo].[getCusFrPhieuThue]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getCusFrPhieuThue](@maphieuthue Varchar(30))
AS
BEGIN
SELECT KhachHang.MaKH, TenKH, SoCMND, KhachHang.SDT, DiaChi, HoTen FROM
dbo.NhanVien,dbo.KhachHang,dbo.PhieuThuePhong WHERE
dbo.KhachHang.MaKH = dbo.PhieuThuePhong.MaKH AND
dbo.NhanVien.MaNV = dbo.PhieuThuePhong.MaNV AND
@maphieuthue = MaPhieuThuePhong
end

GO
/****** Object:  StoredProcedure [dbo].[getIdMPT]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIdMPT]
AS
BEGIN
	SELECT dbo.PhieuThuePhong.MaPhieuThuePhong FROM dbo.PhieuThuePhong
end
GO
/****** Object:  StoredProcedure [dbo].[getIdNV]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIdNV](@TenTk varchar(30), @MatKhau varchar(30))
as
SELECT dbo.NhanVien.MaNV FROM dbo.NhanVien
WHERE dbo.NhanVien.TenTk = @TenTk AND  MatKhau = @MatKhau
GO
/****** Object:  StoredProcedure [dbo].[HTTT]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[HTTT](@HTTT NVARCHAR(20))
	 AS
	 BEGIN
		SELECT KhachHang.MaKH, TenKH, DiaChi, SDT FROM dbo.KhachHang, dbo.PhieuThuePhong, dbo.ThanhToan
		WHERE dbo.KhachHang.MaKH = dbo.PhieuThuePhong.MaKH AND
		  dbo.ThanhToan.MaPhieuThuePhong = dbo.PhieuThuePhong.MaPhieuThuePhong AND
		  dbo.ThanhToan.HinhThucThanhToan = @HTTT
	 END
GO
/****** Object:  StoredProcedure [dbo].[logIn]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[logIn](@tentk varchar(30), @matkhau varchar(30))
AS
begin
SELECT * FROM dbo.NhanVien WHERE dbo.NhanVien.TenTk=@tentk AND dbo.NhanVien.MatKhau=@matkhau
end
GO
/****** Object:  StoredProcedure [dbo].[TENNV]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TENNV](@TenNV NVARCHAR(30))
	 AS
	 BEGIN
		  	SELECT * FROM NhanVien 
			WHERE HoTen LIKE @TenNV
	 END
GO
/****** Object:  StoredProcedure [dbo].[TIMNV]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TIMNV](@TenKH NVARCHAR(30))
	 AS
	 BEGIN
		  SELECT NhanVien.MaNV, NhanVien.HoTen, NhanVien.NgaySinh, NhanVien.SDT FROM NhanVien, PhieuThuePhong, KhachHang
		  WHERE PhieuThuePhong.MaKH = KhachHang.MaKH AND
		  NhanVien.MaNV = PhieuThuePhong.MaNV AND
		  KhachHang.TenKH = @TENKH 
	 END
GO
/****** Object:  StoredProcedure [dbo].[TKKH]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TKKH](@TenLoaiPhong NVARCHAR(30))
	 AS
	 BEGIN
		SELECT COUNT(MaKH) Soluong FROM dbo.PhieuThuePhong, dbo.LoaiPhong, dbo.Phong, dbo.ChiTietPhieuThue
		WHERE dbo.LoaiPhong.MaLoai = dbo.Phong.MaLoai AND
		  dbo.Phong.MaPhong = dbo.ChiTietPhieuThue.MaPhong AND
		  ChiTietPhieuThue.MaPhieuThuePhong = dbo.PhieuThuePhong.MaPhieuThuePhong AND
		  dbo.LoaiPhong.TenLoai = @TenLoaiPhong
	 END
GO
/****** Object:  StoredProcedure [dbo].[TKKHTHEOPHONG]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TKKHTHEOPHONG]
	 AS
	 BEGIN
		SELECT dbo.Phong.TenPhong, COUNT(*) slkhach FROM dbo.Phong, dbo.ChiTietPhieuThue
		WHERE dbo.Phong.MaPhong = dbo.ChiTietPhieuThue.MaPhong 
		GROUP BY TenPhong
	 END
GO
/****** Object:  StoredProcedure [dbo].[TKKHTHEOSOLANTHUE]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TKKHTHEOSOLANTHUE](@SOLANTHUE INT)
	 AS
	 BEGIN
		SELECT dbo.KhachHang.TenKH, COUNT(dbo.PhieuThuePhong.MaKH) solanthue FROM dbo.KhachHang, dbo.PhieuThuePhong
		WHERE dbo.PhieuThuePhong.MaKH  = dbo.KhachHang.MaKH 
		GROUP BY TenKH
		HAVING COUNT(dbo.PhieuThuePhong.MaKH) >= @SOLANTHUE
	 END
GO
/****** Object:  StoredProcedure [dbo].[TKKHTHEOSOPHONGTHUE]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TKKHTHEOSOPHONGTHUE](@SOPHONGTHUE INT)
	 AS
	 BEGIN
		SELECT dbo.KhachHang.TenKH, dbo.PhieuThuePhong.MaPhieuThuePhong, COUNT(dbo.ChiTietPhieuThue.MaPhieuThuePhong) SoPhongThueTrong1Lan FROM dbo.KhachHang, dbo.PhieuThuePhong, dbo.ChiTietPhieuThue
		WHERE dbo.PhieuThuePhong.MaKH = dbo.KhachHang.MaKH AND
			  ChiTietPhieuThue.MaPhieuThuePhong = dbo.PhieuThuePhong.MaPhieuThuePhong
			  GROUP BY TenKH, dbo.PhieuThuePhong.MaPhieuThuePhong
		      HAVING COUNT(dbo.ChiTietPhieuThue.MaPhieuThuePhong) >= @SOPHONGTHUE
	 END
GO
/****** Object:  StoredProcedure [dbo].[TKKHTHEOTHANG]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TKKHTHEOTHANG](@THANG CHAR(2))
	 AS
	 BEGIN
		SELECT COUNT(MaKH) Soluong FROM dbo.PhieuThuePhong, dbo.ChiTietPhieuThue
		WHERE ChiTietPhieuThue.MaPhieuThuePhong = dbo.PhieuThuePhong.MaPhieuThuePhong AND
			  MONTH(NgayVao) = @THANG
	 END
GO
/****** Object:  StoredProcedure [dbo].[TTKH]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TTKH](@MaKH CHAR(8))
	 AS
	 BEGIN
		SELECT * FROM KhachHang
		WHERE MaKH=@MaKH
	 END
GO
/****** Object:  StoredProcedure [dbo].[TTNV]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[TTNV](@MaNV CHAR(8))
	 AS
	 BEGIN
			SELECT * FROM dbo.NhanVien
			WHERE MaNV=@MaNV
	 END
GO
/****** Object:  StoredProcedure [dbo].[updateAcc]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateAcc](@MANV VARCHAR(8), @tenTK varchar(30), @matkhau varchar(30), @quyen bit)
AS
BEGIN
	UPDATE NhanVien SET TenTk=@tenTK, MatKhau=@matkhau, Quyen=@quyen
	WHERE MaNV=@MANV;
END
GO
/****** Object:  StoredProcedure [dbo].[updateCus]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateCus](@MAKH VARCHAR(8), @TENKH NVARCHAR(30), @CMND CHAR(12), @DIACHI NVARCHAR(20), @SDT CHAR(12))
	 AS
	 BEGIN
		UPDATE KhachHang SET TenKH=@TENKH, SoCMND=@CMND, DiaChi=@DIACHI, SDT=@SDT 
		WHERE MaKH=@MAKH;
	 END
GO
/****** Object:  StoredProcedure [dbo].[updateEmp]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROC [dbo].[updateEmp](@MANV VARCHAR(8), @HOTEN NVARCHAR(30), @NGAYSINH DATE, @SDT CHAR(12))
	 AS
	 BEGIN
		UPDATE NhanVien SET HoTen=@HOTEN, NgaySinh=@NGAYSINH, SDT=@SDT
		WHERE MaNV=@MANV;
	 END
GO
/****** Object:  StoredProcedure [dbo].[wellCome]    Script Date: 5/7/2020 1:57:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[wellCome](@TenTk varchar(30), @MatKhau varchar(30))
as
SELECT dbo.NhanVien.HoTen FROM dbo.NhanVien 
WHERE dbo.NhanVien.TenTk = @TenTk AND MatKhau = @MatKhau
GO

---------------------------------------------------SƠN-------------------------------------------------
/****** Object:  StoredProcedure [dbo].[addSer]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addSer](@MADV VARCHAR(8), @TENDV NVARCHAR(20), @DONGIA FLOAT,@MALOAIDICHVU VARCHAR(8))
	 AS
	 BEGIN
		INSERT INTO DichVu(MaDV, TenDV, DonGia, MaLoaiDV) 
		VALUES (@MADV, @TENDV, @DONGIA, @MALOAIDICHVU)
	 END
GO

/****** Object:  StoredProcedure [dbo].[DSDichVu]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSDichVu]
	 AS
	 BEGIN
		SELECT * FROM DichVu
	 END
GO

/****** Object:  StoredProcedure [dbo].[updateSer]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[updateSer](@MADV VARCHAR(8), @TENDV NVARCHAR(20), @DONGIA FLOAT,@MALOAIDICHVU VARCHAR(8))
	 AS
	 BEGIN
		UPDATE DichVu SET TenDV=@TENDV, DonGia=@DONGIA, MaLoaiDV=@MALOAIDICHVU
		WHERE MaDV=@MADV;
	 END
GO

/****** Object:  StoredProcedure [dbo].[delSer]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delSer](@MADV VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.DichVu
     WHERE MaDV = @MADV
     END
GO

/****** Object:  StoredProcedure [dbo].[addTypeSer]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addTypeSer](@MALOAIDV VARCHAR(8), @TENLOAIDV NVARCHAR(20))
	 AS
	 BEGIN
		INSERT INTO LoaiDichVu(MaLoaiDV, TenLoaiDV) 
		VALUES (@MALOAIDV, @TENLOAIDV)
	 END
GO

/****** Object:  StoredProcedure [dbo].[DSLoaDichVu]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSLoaiDichVu]
	 AS
	 BEGIN
		SELECT * FROM LoaiDichVu
	 END
GO

/****** Object:  StoredProcedure [dbo].[UpdateTypeSer]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[updateTypeSer](@MALOAIDV VARCHAR(8), @TENLOAIDV NVARCHAR(20))
	 AS
	 BEGIN
		UPDATE LoaiDichVu SET TenLoaiDV=@TENLOAIDV
		WHERE MaLoaiDV=@MALOAIDV;
	 END
GO

/****** Object:  StoredProcedure [dbo].[delTypeSer]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delTypeSer](@MALOAIDV VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.LoaiDichVu
     WHERE MaLoaiDV = @MALOAIDV
     END
GO

/****** Object:  StoredProcedure [dbo].[addTypeRoom]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addTypeRoom](@MALOAIPHONG VARCHAR(8), @TENLOAIPHONG NVARCHAR(30), @SONGUOI TINYINT, @GHICHU NVARCHAR(250))
	 AS
	 BEGIN
		INSERT INTO LoaiPhong(MaLoai, TenLoai, SoNguoi, GhiChu) 
		VALUES (@MALOAIPHONG,@TENLOAIPHONG ,@SONGUOI ,@GHICHU)
	 END
GO

/****** Object:  StoredProcedure [dbo].[DSLoaiPhong]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSLoaiPhong]
	 AS
	 BEGIN
		SELECT * FROM LoaiPhong
	 END
GO

/****** Object:  StoredProcedure [dbo].[UpdateTypeRoom]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[updateTypeRoom](@MALOAIPHONG VARCHAR(8), @TENLOAIPHONG NVARCHAR(30), @SONGUOI TINYINT, @GHICHU NVARCHAR(250))
	 AS
	 BEGIN
		UPDATE LoaiPhong SET TenLoai=@TENLOAIPHONG, SoNguoi= @SONGUOI, GhiChu=@GHICHU
		WHERE MaLoai= @MALOAIPHONG;
	 END
GO

/****** Object:  StoredProcedure [dbo].[delTypeRoom]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delTypeRoom](@MALOAIPHONG VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.LoaiPhong
     WHERE MaLoai= @MALOAIPHONG
     END
GO

/****** Object:  StoredProcedure [dbo].[addRoom]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addRoom](@MAPHONG VARCHAR(8), @TENPHONG NVARCHAR(30), @TINHTRANG TINYINT, @DIENTICH INT, @GIATHUE FLOAT, @MALOAI VARCHAR(8))
	 AS
	 BEGIN
		INSERT INTO Phong(MaPhong, TenPhong, TinhTrang, DienTich, GiaThue, MaLoai) 
		VALUES (@MAPHONG, @TENPHONG, @TINHTRANG, @DIENTICH, @GIATHUE, @MALOAI)
	 END
GO

/****** Object:  StoredProcedure [dbo].[DSPhong]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSPhong]
	 AS
	 BEGIN
		SELECT * FROM Phong
	 END
GO

/****** Object:  StoredProcedure [dbo].[UpdateRoom]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[updateRoom](@MAPHONG VARCHAR(8), @TENPHONG NVARCHAR(30), @TINHTRANG TINYINT, @DIENTICH INT, @GIATHUE FLOAT, @MALOAI VARCHAR(8))
	 AS
	 BEGIN
		UPDATE Phong SET TenPhong=@TENPHONG, TinhTrang= @TINHTRANG, DienTich=@DIENTICH, GiaThue=@GIATHUE, MaLoai =@MALOAI
		WHERE MaPhong= @MAPHONG;
	 END
GO

/****** Object:  StoredProcedure [dbo].[delRoom]    Script Date: 5/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delRoom](@MAPHONG VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.Phong
     WHERE MaPhong= @MAPHONG
     END
GO

/****** Object:  StoredProcedure [dbo].[TKTypeRoom]    Script Date: 8/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKtypeRoom](@TENLOAIPHONG VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.LoaiPhong
     WHERE TenLoai = @TENLOAIPHONG
     END
GO	

/****** Object:  StoredProcedure [dbo].[TKRoom]    Script Date: 8/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKPhong](@TENPHONG VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.Phong
     WHERE TenPhong = @TENPHONG
     END
GO	

/****** Object:  StoredProcedure [dbo].[TKTypeSer]    Script Date: 8/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKtypeService](@TENLOAIDV VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.LoaiDichVu
     WHERE TenLoaiDV = @TENLOAIDV
     END
GO	

/****** Object:  StoredProcedure [dbo].[TKSer]    Script Date: 8/5/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKService](@TENDV VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.DichVu
     WHERE TenDV = @TENDV
     END
GO	