USE [master]
GO
/****** Object:  Database [CHDT]    Script Date: 5/18/2022 1:52:21 AM ******/
CREATE DATABASE [CHDT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CHDT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CHDT.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CHDT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CHDT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CHDT] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CHDT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CHDT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CHDT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CHDT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CHDT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CHDT] SET ARITHABORT OFF 
GO
ALTER DATABASE [CHDT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CHDT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CHDT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CHDT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CHDT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CHDT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CHDT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CHDT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CHDT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CHDT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CHDT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CHDT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CHDT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CHDT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CHDT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CHDT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CHDT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CHDT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CHDT] SET  MULTI_USER 
GO
ALTER DATABASE [CHDT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CHDT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CHDT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CHDT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CHDT] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CHDT]
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 5/18/2022 1:52:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[MaHD] [nvarchar](30) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[Gia] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHD_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 5/18/2022 1:52:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TuyChon] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [nvarchar](50) NOT NULL,
	[CauHinh] [nvarchar](max) NOT NULL,
	[HinhAnh] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietDienThoai] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[TuyChon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/18/2022 1:52:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](30) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [nvarchar](20) NULL,
	[ThanhTien] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LichSu]    Script Date: 5/18/2022 1:52:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSu](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[TenNguoiDung] [nvarchar](50) NOT NULL,
	[QuyenHan] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_LichSu] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[ThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/18/2022 1:52:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/18/2022 1:52:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[PhanLoai] [nvarchar](50) NOT NULL,
	[HangSanXuat] [nvarchar](50) NULL,
	[KhuyenMai] [nvarchar](100) NULL,
 CONSTRAINT [PK_DienThoai] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/18/2022 1:52:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[NguoiDung] [nvarchar](10) NOT NULL,
	[QuyenHan] [nvarchar](10) NOT NULL,
	[HinhAnh] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [TenSP], [Gia], [SoLuong]) VALUES (N'HD1652022_234552', N'SP2', N'Xiaomi Redmi 10 (2022) ', N'4090000', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [TenSP], [Gia], [SoLuong]) VALUES (N'HD1652022_234552', N'SP7', N'Pin sạc dự phòng Polymer 10.000 mAh AVA+ PJ JP192', N'299000', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [TenSP], [Gia], [SoLuong]) VALUES (N'HD1652022_234552', N'SP8', N'Tai nghe Bluetooth True Wireless Mozard TS13 ', N'455000', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [TenSP], [Gia], [SoLuong]) VALUES (N'HD1752022_195214', N'SP3', N'Samsung Galaxy A12 6GB (2021)', N'3890000', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [TenSP], [Gia], [SoLuong]) VALUES (N'HD1752022_195510', N'SP4', N'Điện thoại Nokia G10 ', N'3690000', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [TenSP], [Gia], [SoLuong]) VALUES (N'HD1752022_195510', N'SP8', N'Tai nghe Bluetooth True Wireless Mozard TS13 ', N'455000', 1)
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP1', N'Xám', 25, N'3490000', N'-Màn hình: IPS LCD6.71"HD+
-Hệ điều hành: Android 11
-Camera sau:Chính 50 MP & Phụ 2 MP
-Camera trước: 5 MP
-Chip:Snapdragon 680 8 nhân
-RAM: 4 GB
-Bộ nhớ trong: 64 GB
-SIM: 2 Nano SIMHỗ trợ 4G
-Pin, Sạc: 5000 mAh18 W', N'sp1.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP1', N'Xanh', 25, N'3490000', N'-Màn hình: IPS LCD6.71"HD+
-Hệ điều hành: Android 11
-Camera sau:Chính 50 MP & Phụ 2 MP
-Camera trước: 5 MP
-Chip:Snapdragon 680 8 nhân
-RAM: 4 GB
-Bộ nhớ trong: 64 GB
-SIM: 2 Nano SIMHỗ trợ 4G
-Pin, Sạc: 5000 mAh18 W', N'sp1.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP2', N'Màu trắng', 20, N'4090000', N'-Màn hình:IPS LCD6.5"Full HD+
-Hệ điều hành:Android 11
-Camera sau: Chính 50 MP & Phụ 8 MP, 2 MP, 2 MP
-Camera trước:8 MP
-Chip:MediaTek Helio G88 8 nhân
-RAM: 4 GB
-Bộ nhớ trong:128 GB
-SIM: 2 Nano SIM (SIM 2 chung khe thẻ nhớ)Hỗ trợ 4G
-Pin, Sạc: 5000 mAh18 W', N'sp2.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP2', N'Xám', 19, N'4090000', N'-Màn hình:IPS LCD6.5"Full HD+
-Hệ điều hành:Android 11
-Camera sau: Chính 50 MP & Phụ 8 MP, 2 MP, 2 MP
-Camera trước:8 MP
-Chip:MediaTek Helio G88 8 nhân
-RAM: 4 GB
-Bộ nhớ trong:128 GB
-SIM: 2 Nano SIM (SIM 2 chung khe thẻ nhớ)Hỗ trợ 4G
-Pin, Sạc: 5000 mAh18 W', N'sp2.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP3', N'Đen', 30, N'3890000', N'Màn hình: PLS TFT LCD6.5"HD+
Hệ điều hành: Android 11
Camera sau: Chính 48 MP & Phụ 5 MP, 2 MP, 2 MP
Camera trước: 8 MP
Chip: Exynos 850
RAM: 6 GB
Bộ nhớ trong: 128 GB
SIM: 2 Nano SIMHỗ trợ 4G
Pin, Sạc: 5000 mAh15 W', N'sp3.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP3', N'Trắng', 29, N'3890000', N'Màn hình: PLS TFT LCD6.5"HD+
Hệ điều hành: Android 11
Camera sau: Chính 48 MP & Phụ 5 MP, 2 MP, 2 MP
Camera trước: 8 MP
Chip: Exynos 850
RAM: 6 GB
Bộ nhớ trong: 128 GB
SIM: 2 Nano SIMHỗ trợ 4G
Pin, Sạc: 5000 mAh15 W', N'sp3.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP3', N'Xanh', 30, N'3890000', N'Màn hình: PLS TFT LCD6.5"HD+
Hệ điều hành: Android 11
Camera sau: Chính 48 MP & Phụ 5 MP, 2 MP, 2 MP
Camera trước: 8 MP
Chip: Exynos 850
RAM: 6 GB
Bộ nhớ trong: 128 GB
SIM: 2 Nano SIMHỗ trợ 4G
Pin, Sạc: 5000 mAh15 W', N'sp3.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP4', N'Mặc định', 40, N'3690000', N'Màn hình:TFT LCD6.5"HD+
Hệ điều hành:Android 11
Camera sau:Chính 13 MP & Phụ 2 MP, 2 MP
Camera trước:8 MP
Chip:MediaTek Helio G25
RAM:4 GB
Bộ nhớ trong:64 GB
SIM:2 Nano SIMHỗ trợ 4G
Pin, Sạc:5050 mAh10 W', N'sp4.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP5', N'Đen-Xanh', 50, N'3490000', N'Màn hình:IPS LCD6.51"HD+
Hệ điều hành:Android 11 (Go Edition)
Camera sau:Chính 13 MP & Phụ 2 MP
Camera trước:8 MP
Chip:MediaTek Helio P35
RAM:3 GB
Bộ nhớ trong:32 GB
SIM:2 Nano SIM Hỗ trợ 4G
Pin, Sạc: 5000 mAh10 W', N'sp5.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP5', N'Trắng-Xanh', 50, N'3490000', N'Màn hình:IPS LCD6.51"HD+
Hệ điều hành:Android 11 (Go Edition)
Camera sau:Chính 13 MP & Phụ 2 MP
Camera trước:8 MP
Chip:MediaTek Helio P35
RAM:3 GB
Bộ nhớ trong:32 GB
SIM:2 Nano SIM Hỗ trợ 4G
Pin, Sạc: 5000 mAh10 W', N'sp5.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP6', N'Đen', 30, N'1990000', N'Màn hình:IPS LCD6.1"HD+
Hệ điều hành:Android 10 (Go Edition)
Camera sau:Chính 5 MP & Phụ VGA
Camera trước:5 MP
Chip:Spreadtrum SC9832E
RAM:2 GB
Bộ nhớ trong:32 GB
SIM:2 Micro SIM Hỗ trợ 4G
Pin, Sạc:3000 mAh5 W', N'sp6.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP6', N'Tím', 30, N'1990000', N'Màn hình:IPS LCD6.1"HD+
Hệ điều hành:Android 10 (Go Edition)
Camera sau:Chính 5 MP & Phụ VGA
Camera trước:5 MP
Chip:Spreadtrum SC9832E
RAM:2 GB
Bộ nhớ trong:32 GB
SIM:2 Micro SIM Hỗ trợ 4G
Pin, Sạc:3000 mAh5 W', N'sp6.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP6', N'Xanh', 30, N'1990000', N'Màn hình:IPS LCD6.1"HD+
Hệ điều hành:Android 10 (Go Edition)
Camera sau:Chính 5 MP & Phụ VGA
Camera trước:5 MP
Chip:Spreadtrum SC9832E
RAM:2 GB
Bộ nhớ trong:32 GB
SIM:2 Micro SIM Hỗ trợ 4G
Pin, Sạc:3000 mAh5 W', N'sp6.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP7', N'Hồng', 40, N'299000', N'Dung lượng pin:10.000 mAh
Thời gian sạc đầy pin:10 - 11 giờ (dùng Adapter 1A)5 - 6 giờ (dùng Adapter 2A)
Nguồn vào:Micro USB: 5V - 2A
Nguồn ra:USB: 5V - 2.4A
Lõi pin: Polymer
Công nghệ/Tiện ích:Đèn LED báo hiệu
Kích thước:Dài 8.7 cm - Ngang 6 cm - Cao 2 cm
Trọng lượng: 182 g', N'sp7_2.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP7', N'Xám', 40, N'299000', N'Dung lượng pin:10.000 mAh
Thời gian sạc đầy pin:10 - 11 giờ (dùng Adapter 1A)5 - 6 giờ (dùng Adapter 2A)
Nguồn vào:Micro USB: 5V - 2A
Nguồn ra:USB: 5V - 2.4A
Lõi pin: Polymer
Công nghệ/Tiện ích:Đèn LED báo hiệu
Kích thước:Dài 8.7 cm - Ngang 6 cm - Cao 2 cm
Trọng lượng: 182 g', N'sp7.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP8', N'Đen', 35, N'455000', N'Thời gian tai nghe: Dùng 5 giờ - Sạc 2 giờ
Thời gian hộp sạc: Dùng 16 giờ - Sạc 1.5 giờ
Cổng sạc:Micro USB
Tương thích:AndroidiOS (iPhone)Windows
Tiện ích:Đệm tai đi kèm
Hỗ trợ kết nối:Bluetooth 5.0
Điều khiển bằng:Phím nhấn', N'sp8_2.png')
INSERT [dbo].[ChiTietSanPham] ([MaSP], [TuyChon], [SoLuong], [Gia], [CauHinh], [HinhAnh]) VALUES (N'SP8', N'Xanh', 34, N'455000', N'Thời gian tai nghe: Dùng 5 giờ - Sạc 2 giờ
Thời gian hộp sạc: Dùng 16 giờ - Sạc 1.5 giờ
Cổng sạc:Micro USB
Tương thích:AndroidiOS (iPhone)Windows
Tiện ích:Đệm tai đi kèm
Hỗ trợ kết nối:Bluetooth 5.0
Điều khiển bằng:Phím nhấn', N'sp8.png')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaNV], [TenKH], [SDT], [ThanhTien], [TinhTrang]) VALUES (N'HD1652022_234552', CAST(N'2022-05-16' AS Date), N'NV1', N'Võ Tấn Khôi', N'011111235', N'6053000', N'Đã hoàn thành')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaNV], [TenKH], [SDT], [ThanhTien], [TinhTrang]) VALUES (N'HD1752022_195214', CAST(N'2022-05-17' AS Date), N'NV2', N'Trần Thanh Nhàng', N'0123654987', N'3890000', N'Đã hoàn thành')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaNV], [TenKH], [SDT], [ThanhTien], [TinhTrang]) VALUES (N'HD1752022_195510', CAST(N'2022-05-17' AS Date), N'NV2', N'Lê Thị Vui', N'01233333333', N'7835000', N'Đã hoàn thành')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaNV], [TenKH], [SDT], [ThanhTien], [TinhTrang]) VALUES (N'HD1752022_23413', CAST(N'2022-05-17' AS Date), N'NV1', N'', N'', N'', N'Đang thực hiện')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 22:48:34.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 22:52:33.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 22:55:58.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 22:56:44.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 23:08:31.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 23:12:12.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 23:14:14.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 23:17:08.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 23:17:34.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-16 23:50:03.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 10:23:53.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 10:29:50.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 10:31:31.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 19:49:57.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 19:53:24.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 20:00:52.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 20:03:23.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 20:04:04.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 20:14:54.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 21:40:28.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 21:41:13.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 21:46:36.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 22:00:44.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 22:03:39.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 23:26:42.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 23:29:25.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 23:32:06.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 23:33:52.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 23:35:37.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 23:36:33.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-17 23:40:11.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'lhphong', CAST(N'2022-05-18 01:21:20.000' AS DateTime), N'Lê Hoàng Phong', N'admin')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-16 23:50:20.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-17 19:50:17.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-17 19:51:52.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-17 19:54:51.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-17 19:58:57.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-17 21:42:07.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-17 21:57:21.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[LichSu] ([TenDangNhap], [ThoiGian], [TenNguoiDung], [QuyenHan]) VALUES (N'ttnhang', CAST(N'2022-05-17 22:01:52.000' AS DateTime), N'Trần Thanh Nhàng', N'user')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV1', N'Lê Hoàng Phong', N'Nam', CAST(N'2001-05-25' AS Date), N'0708424053', N'An Giang')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV2', N'Trần Thanh Nhàng', N'Nam', CAST(N'2001-01-01' AS Date), N'0333311111', N'An Giang')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV3', N'Trần Thị Cam', N'Nữ', CAST(N'2022-05-12' AS Date), N'0123456998', N'An Giang')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP1', N'Điện thoại Xiaomi Redmi 10C 64GB', N'Điện thoại', N'Xiaomi', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP2', N'Xiaomi Redmi 10 (2022) ', N'Điện thoại', N'Xiaomi ', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP3', N'Samsung Galaxy A12 6GB (2021)', N'Điện thoại', N'Samsung', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP4', N'Điện thoại Nokia G10 ', N'Điện thoại', N'Nokia', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP5', N'Điện thoại Vivo Y15s ', N'Điện thoại', N'Vivo', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP6', N'Điện thoại Itel L6006', N'Điện thoại', N'Itel', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP7', N'Pin sạc dự phòng Polymer 10.000 mAh AVA+ PJ JP192', N'Phụ kiện', N'AVA+', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [PhanLoai], [HangSanXuat], [KhuyenMai]) VALUES (N'SP8', N'Tai nghe Bluetooth True Wireless Mozard TS13 ', N'Phụ kiện', N'Mozard', N'')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [NguoiDung], [QuyenHan], [HinhAnh]) VALUES (N'lhphong', N'123', N'NV1', N'admin', NULL)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [NguoiDung], [QuyenHan], [HinhAnh]) VALUES (N'ttnhang', N'123', N'NV2', N'user', N'Male.png')
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_SanPham]
GO
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDienThoai_DienThoai] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietSanPham] CHECK CONSTRAINT [FK_ChiTietDienThoai_DienThoai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[LichSu]  WITH CHECK ADD  CONSTRAINT [FK_LichSu_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[LichSu] CHECK CONSTRAINT [FK_LichSu_TaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([NguoiDung])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [CHDT] SET  READ_WRITE 
GO
