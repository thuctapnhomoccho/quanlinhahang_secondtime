USE [quanlinhahang]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[id_account] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[id_account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ban_an]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ban_an](
	[id_banan] [int] IDENTITY(1,1) NOT NULL,
	[chatlieu] [nvarchar](50) NULL,
	[tinhtrang] [bit] NULL,
	[id_loaibanan] [int] NULL,
 CONSTRAINT [PK_ban_an] PRIMARY KEY CLUSTERED 
(
	[id_banan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitiet_hoadon]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiet_hoadon](
	[id_hoadon] [int] NOT NULL,
	[id_monan] [int] NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_chitiet_hoadon] PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC,
	[id_monan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[id_hoadon] [int] NOT NULL,
	[id_nhanvienlap] [int] NULL,
	[id_khachhang] [int] NULL,
	[ngaylap] [date] NULL,
	[id_khuyenmai] [int] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[id_khachhang] [int] IDENTITY(1,1) NOT NULL,
	[name_khachhang] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[Ngaysinh] [date] NULL,
	[diachi] [nvarchar](50) NULL,
	[sđt] [int] NULL,
	[so_the] [int] NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[id_khachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khuyenmai]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khuyenmai](
	[id_khuyenmai] [int] NOT NULL,
	[name_khuyenmai] [nvarchar](50) NULL,
	[phantram_discount] [varchar](4) NULL,
 CONSTRAINT [PK_khuyenmai] PRIMARY KEY CLUSTERED 
(
	[id_khuyenmai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loai_mon_an]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loai_mon_an](
	[id_loaimonan] [int] NOT NULL,
	[name_loaimonan] [nvarchar](50) NULL,
 CONSTRAINT [PK_loai_mon_an] PRIMARY KEY CLUSTERED 
(
	[id_loaimonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Loaibanan]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaibanan](
	[id_loaiban] [int] NOT NULL,
	[soluongkhach] [int] NULL,
 CONSTRAINT [PK_Loaibanan] PRIMARY KEY CLUSTERED 
(
	[id_loaiban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[monan]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monan](
	[id_monan] [int] IDENTITY(1,1) NOT NULL,
	[name_monan] [nvarchar](50) NULL,
	[gia_monan] [int] NULL,
	[id_loaimonan] [int] NULL,
 CONSTRAINT [PK_monan] PRIMARY KEY CLUSTERED 
(
	[id_monan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[id_nhanvien] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [int] NULL,
	[chucvu] [nvarchar](50) NULL,
	[luong] [int] NULL,
	[id_account] [int] NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[id_nhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[thongtin_datban]    Script Date: 2/26/2019 1:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thongtin_datban](
	[id_khachhang] [int] NOT NULL,
	[id_banan] [int] NOT NULL,
	[ngaydatban] [date] NULL,
	[giodatban] [time](1) NULL,
 CONSTRAINT [PK_thongtin_datban] PRIMARY KEY CLUSTERED 
(
	[id_khachhang] ASC,
	[id_banan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id_account], [user_name], [password]) VALUES (1, N'vuminhhieu', N'123')
INSERT [dbo].[Account] ([id_account], [user_name], [password]) VALUES (2, N'manhtruong', N'321')
SET IDENTITY_INSERT [dbo].[Account] OFF
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (1, 1, 3)
INSERT [dbo].[hoadon] ([id_hoadon], [id_nhanvienlap], [id_khachhang], [ngaylap], [id_khuyenmai]) VALUES (1, 1, NULL, CAST(0x553F0B00 AS Date), 3)
INSERT [dbo].[khuyenmai] ([id_khuyenmai], [name_khuyenmai], [phantram_discount]) VALUES (1, N'VIP', N'50')
INSERT [dbo].[khuyenmai] ([id_khuyenmai], [name_khuyenmai], [phantram_discount]) VALUES (2, N'VVIP', N'30')
INSERT [dbo].[khuyenmai] ([id_khuyenmai], [name_khuyenmai], [phantram_discount]) VALUES (3, N'MEMBER', N'10')
INSERT [dbo].[loai_mon_an] ([id_loaimonan], [name_loaimonan]) VALUES (1, N'Buffet Lẩu')
INSERT [dbo].[loai_mon_an] ([id_loaimonan], [name_loaimonan]) VALUES (2, N'Buffet Nướng')
INSERT [dbo].[loai_mon_an] ([id_loaimonan], [name_loaimonan]) VALUES (3, N'Buffet Lẩu + Nướng')
SET IDENTITY_INSERT [dbo].[monan] ON 

INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1, N'Buffet Nướng 1', 149000, 1)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (2, N'Buffet Nướng 2', 169000, 1)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (3, N'Buffet Nướng 3', 199000, 1)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (4, N'Buffet Lẩu 1', 99000, 2)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (5, N'Buffet Lẩu 2', 149000, 2)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (6, N'Buffet Lẩu 3', 169000, 2)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (7, N'Buffet Lẩu + Nướng 1', 299000, 3)
SET IDENTITY_INSERT [dbo].[monan] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([id_nhanvien], [hoten], [gioitinh], [diachi], [sdt], [chucvu], [luong], [id_account]) VALUES (1, N'Truong', NULL, NULL, NULL, NULL, 50000, NULL)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
ALTER TABLE [dbo].[ban_an]  WITH CHECK ADD  CONSTRAINT [FK_ban_an_Loaibanan] FOREIGN KEY([id_loaibanan])
REFERENCES [dbo].[Loaibanan] ([id_loaiban])
GO
ALTER TABLE [dbo].[ban_an] CHECK CONSTRAINT [FK_ban_an_Loaibanan]
GO
ALTER TABLE [dbo].[chitiet_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitiet_hoadon_hoadon] FOREIGN KEY([id_hoadon])
REFERENCES [dbo].[hoadon] ([id_hoadon])
GO
ALTER TABLE [dbo].[chitiet_hoadon] CHECK CONSTRAINT [FK_chitiet_hoadon_hoadon]
GO
ALTER TABLE [dbo].[chitiet_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitiet_hoadon_monan] FOREIGN KEY([id_monan])
REFERENCES [dbo].[monan] ([id_monan])
GO
ALTER TABLE [dbo].[chitiet_hoadon] CHECK CONSTRAINT [FK_chitiet_hoadon_monan]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([id_khachhang])
REFERENCES [dbo].[khachhang] ([id_khachhang])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khuyenmai] FOREIGN KEY([id_khuyenmai])
REFERENCES [dbo].[khuyenmai] ([id_khuyenmai])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khuyenmai]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([id_nhanvienlap])
REFERENCES [dbo].[nhanvien] ([id_nhanvien])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
ALTER TABLE [dbo].[monan]  WITH CHECK ADD  CONSTRAINT [FK_monan_loai_mon_an] FOREIGN KEY([id_loaimonan])
REFERENCES [dbo].[loai_mon_an] ([id_loaimonan])
GO
ALTER TABLE [dbo].[monan] CHECK CONSTRAINT [FK_monan_loai_mon_an]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_Account] FOREIGN KEY([id_account])
REFERENCES [dbo].[Account] ([id_account])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_Account]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_Account1] FOREIGN KEY([id_account])
REFERENCES [dbo].[Account] ([id_account])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_Account1]
GO
ALTER TABLE [dbo].[thongtin_datban]  WITH CHECK ADD  CONSTRAINT [FK_thongtin_datban_ban_an] FOREIGN KEY([id_banan])
REFERENCES [dbo].[ban_an] ([id_banan])
GO
ALTER TABLE [dbo].[thongtin_datban] CHECK CONSTRAINT [FK_thongtin_datban_ban_an]
GO
ALTER TABLE [dbo].[thongtin_datban]  WITH CHECK ADD  CONSTRAINT [FK_thongtin_datban_khachhang] FOREIGN KEY([id_khachhang])
REFERENCES [dbo].[khachhang] ([id_khachhang])
GO
ALTER TABLE [dbo].[thongtin_datban] CHECK CONSTRAINT [FK_thongtin_datban_khachhang]
GO
