USE [quanlinhahang]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2/28/2019 12:35:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id_account] [int] NOT NULL,
	[user_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[id_account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ban_an]    Script Date: 2/28/2019 12:35:10 AM ******/
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
/****** Object:  Table [dbo].[chitiet_hoadon]    Script Date: 2/28/2019 12:35:10 AM ******/
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
/****** Object:  Table [dbo].[hoadon]    Script Date: 2/28/2019 12:35:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[id_hoadon] [int] IDENTITY(1,1) NOT NULL,
	[id_nhanvienlap] [int] NULL,
	[id_khachhang] [int] NULL,
	[ngaylap] [date] NULL,
	[giolap] [time](6) NULL,
	[tinhtrang] [bit] NULL,
	[id_khuyenmai] [int] NULL,
	[id_bannan] [int] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 2/28/2019 12:35:10 AM ******/
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
/****** Object:  Table [dbo].[khuyenmai]    Script Date: 2/28/2019 12:35:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khuyenmai](
	[id_khuyenmai] [int] IDENTITY(1,1) NOT NULL,
	[name_khuyenmai] [nvarchar](50) NULL,
	[phantram_discount] [varchar](4) NULL,
 CONSTRAINT [PK_khuyenmai] PRIMARY KEY CLUSTERED 
(
	[id_khuyenmai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loai_mon_an]    Script Date: 2/28/2019 12:35:10 AM ******/
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
/****** Object:  Table [dbo].[Loaibanan]    Script Date: 2/28/2019 12:35:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaibanan](
	[id_loaiban] [int] IDENTITY(1,1) NOT NULL,
	[soluongkhach] [int] NULL,
 CONSTRAINT [PK_Loaibanan] PRIMARY KEY CLUSTERED 
(
	[id_loaiban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monan]    Script Date: 2/28/2019 12:35:11 AM ******/
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
/****** Object:  Table [dbo].[nhanvien]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[id_nhanvien] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[ngaysinh] [date] NULL,
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
/****** Object:  Table [dbo].[thongtin_datban]    Script Date: 2/28/2019 12:35:11 AM ******/
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
INSERT [dbo].[Account] ([id_account], [user_name], [password]) VALUES (0, N'a', N'123')
INSERT [dbo].[Account] ([id_account], [user_name], [password]) VALUES (2, N'vuvanminhh', N'12311')
INSERT [dbo].[Account] ([id_account], [user_name], [password]) VALUES (4, N'vuhoanglam', N'123')
INSERT [dbo].[Account] ([id_account], [user_name], [password]) VALUES (5, N'nguyenthilien', N'123')
SET IDENTITY_INSERT [dbo].[ban_an] ON 

INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (1, N'gỗ', 0, 5)
INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (2, N'gỗ', 0, 1)
INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (3, N'inox', 0, 2)
INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (4, N'inox', 0, 3)
INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (5, N'gỗ', 0, 4)
INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (6, N'gỗ', 0, 4)
INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (10, N'abc', 1, 1)
INSERT [dbo].[ban_an] ([id_banan], [chatlieu], [tinhtrang], [id_loaibanan]) VALUES (1004, N'inox', 1, 5)
SET IDENTITY_INSERT [dbo].[ban_an] OFF
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (2, 2, 1)
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (2, 1002, 2)
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (2, 1003, 1)
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (2, 1006, 1)
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (2, 1010, 1)
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (3, 1003, 2)
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (3, 1009, 1)
INSERT [dbo].[chitiet_hoadon] ([id_hoadon], [id_monan], [soluong]) VALUES (4, 1005, 1)
SET IDENTITY_INSERT [dbo].[hoadon] ON 

INSERT [dbo].[hoadon] ([id_hoadon], [id_nhanvienlap], [id_khachhang], [ngaylap], [giolap], [tinhtrang], [id_khuyenmai], [id_bannan]) VALUES (2, 5, 1, CAST(N'2019-01-01' AS Date), CAST(N'12:00:00' AS Time), 1, 3, 1)
INSERT [dbo].[hoadon] ([id_hoadon], [id_nhanvienlap], [id_khachhang], [ngaylap], [giolap], [tinhtrang], [id_khuyenmai], [id_bannan]) VALUES (3, 5, 4, CAST(N'2019-01-01' AS Date), CAST(N'12:00:00' AS Time), 0, 3, 1004)
INSERT [dbo].[hoadon] ([id_hoadon], [id_nhanvienlap], [id_khachhang], [ngaylap], [giolap], [tinhtrang], [id_khuyenmai], [id_bannan]) VALUES (4, 5, 2, CAST(N'2019-02-27' AS Date), CAST(N'03:26:00' AS Time), 0, 1, 1)
SET IDENTITY_INSERT [dbo].[hoadon] OFF
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([id_khachhang], [name_khachhang], [gioitinh], [Ngaysinh], [diachi], [sđt], [so_the]) VALUES (1, N'Nguyễn Văn Vinh', 1, CAST(N'1998-01-01' AS Date), N'Hà Nội', 12371232, 113)
INSERT [dbo].[khachhang] ([id_khachhang], [name_khachhang], [gioitinh], [Ngaysinh], [diachi], [sđt], [so_the]) VALUES (2, N'Nguyễn Nhật Nam', 1, CAST(N'1997-02-03' AS Date), N'Hà Nội', 238127213, 291381293)
INSERT [dbo].[khachhang] ([id_khachhang], [name_khachhang], [gioitinh], [Ngaysinh], [diachi], [sđt], [so_the]) VALUES (3, N'Vũ Văn Sơn', 1, CAST(N'1989-02-19' AS Date), N'Hải Dương', 123213, 123123)
INSERT [dbo].[khachhang] ([id_khachhang], [name_khachhang], [gioitinh], [Ngaysinh], [diachi], [sđt], [so_the]) VALUES (4, N'Đặng Thị Chịu Được', 0, CAST(N'2019-02-26' AS Date), N'Hải Dương', 123213, 123123)
SET IDENTITY_INSERT [dbo].[khachhang] OFF
SET IDENTITY_INSERT [dbo].[khuyenmai] ON 

INSERT [dbo].[khuyenmai] ([id_khuyenmai], [name_khuyenmai], [phantram_discount]) VALUES (1, N'Cực sốc', N'20')
INSERT [dbo].[khuyenmai] ([id_khuyenmai], [name_khuyenmai], [phantram_discount]) VALUES (2, N'Vui vẻ', N'30')
INSERT [dbo].[khuyenmai] ([id_khuyenmai], [name_khuyenmai], [phantram_discount]) VALUES (3, N'Trống', N'0')
SET IDENTITY_INSERT [dbo].[khuyenmai] OFF
INSERT [dbo].[loai_mon_an] ([id_loaimonan], [name_loaimonan]) VALUES (1, N'buffe')
INSERT [dbo].[loai_mon_an] ([id_loaimonan], [name_loaimonan]) VALUES (2, N'Lẩu')
INSERT [dbo].[loai_mon_an] ([id_loaimonan], [name_loaimonan]) VALUES (3, N'Nướng')
INSERT [dbo].[loai_mon_an] ([id_loaimonan], [name_loaimonan]) VALUES (4, N'Đồ ăn tự chọn')
SET IDENTITY_INSERT [dbo].[Loaibanan] ON 

INSERT [dbo].[Loaibanan] ([id_loaiban], [soluongkhach]) VALUES (1, 4)
INSERT [dbo].[Loaibanan] ([id_loaiban], [soluongkhach]) VALUES (2, 6)
INSERT [dbo].[Loaibanan] ([id_loaiban], [soluongkhach]) VALUES (3, 8)
INSERT [dbo].[Loaibanan] ([id_loaiban], [soluongkhach]) VALUES (4, 2)
INSERT [dbo].[Loaibanan] ([id_loaiban], [soluongkhach]) VALUES (5, 10)
SET IDENTITY_INSERT [dbo].[Loaibanan] OFF
SET IDENTITY_INSERT [dbo].[monan] ON 

INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (2, N'Cá rán ', 50000, 4)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1002, N'Nướng 1', 129000, 3)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1003, N'Nướng 2', 299000, 3)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1004, N'Nướng 3', 399000, 3)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1005, N'Lẩu kim chi', 99000, 2)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1006, N'Lẩu nấm', 199000, 2)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1007, N'Lẩu bò', 299000, 2)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1008, N'buffe 1', 99000, 1)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1009, N'buffe 2 ', 199000, 1)
INSERT [dbo].[monan] ([id_monan], [name_monan], [gia_monan], [id_loaimonan]) VALUES (1010, N'Ngô chiên', 50000, 4)
SET IDENTITY_INSERT [dbo].[monan] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([id_nhanvien], [hoten], [gioitinh], [ngaysinh], [diachi], [sdt], [chucvu], [luong], [id_account]) VALUES (5, N'Vũ Hoàng Lâm', 0, CAST(N'2019-10-12' AS Date), N'Hải ', 1, N'Thu ngân', 1000, 4)
INSERT [dbo].[nhanvien] ([id_nhanvien], [hoten], [gioitinh], [ngaysinh], [diachi], [sdt], [chucvu], [luong], [id_account]) VALUES (1012, N'Vũ Minh Hiếu', 0, CAST(N'2019-02-27' AS Date), N'Hải dương', 1, N'Trưởng phòng', 1, 0)
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
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_ban_an] FOREIGN KEY([id_bannan])
REFERENCES [dbo].[ban_an] ([id_banan])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_ban_an]
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
/****** Object:  StoredProcedure [dbo].[checkaccount]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkaccount] @user varchar(50),@pass varchar(50)
as
begin
select * from Account where @user= Account.user_name and @pass=Account.password
end
GO
/****** Object:  StoredProcedure [dbo].[checklogin]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checklogin] @id int
as
begin
select * from nhanvien where @id=nhanvien.id_account and chucvu=N'quản lý'
end
GO
/****** Object:  StoredProcedure [dbo].[delete_banan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_banan] @id int 
as
begin
 delete from ban_an where id_banan=@id
end
GO
/****** Object:  StoredProcedure [dbo].[delete_hoadon]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_hoadon] @id_hoadon int
as
begin
delete from hoadon 
where id_hoadon=@id_hoadon
end
GO
/****** Object:  StoredProcedure [dbo].[delete_khachhang]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_khachhang] @id int
as
begin
delete from khachhang
where id_khachhang=@id
end
GO
/****** Object:  StoredProcedure [dbo].[delete_monan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[delete_monan] @id_hoadon int , @id_monan int
 as
 begin
 delete from chitiet_hoadon where id_hoadon=@id_hoadon and id_monan=@id_monan
 end
GO
/****** Object:  StoredProcedure [dbo].[delete_nhanvien]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[delete_nhanvien] @id_nhanvien int , @id_account int
as
begin
delete from nhanvien where id_nhanvien=@id_nhanvien
delete from Account where id_account=@id_account
end
GO
/****** Object:  StoredProcedure [dbo].[hienthi]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienthi]
as
begin 
select monan.name_monan,monan.gia_monan,loai_mon_an.name_loaimonan from monan , loai_mon_an where monan.id_loaimonan= loai_mon_an.id_loaimonan;
end
GO
/****** Object:  StoredProcedure [dbo].[insert_banan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insert_banan]  @chatlieuu nvarchar(50),@tinhtrang bit, @id_loaibanan int
as
begin
 insert into ban_an (chatlieu,tinhtrang,id_loaibanan)
 values( @chatlieuu,@tinhtrang,@id_loaibanan)
end
GO
/****** Object:  StoredProcedure [dbo].[insert_chitietmonan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_chitietmonan] @id_hoadon int, @id_monan int ,@soluong int
as
begin
insert into chitiet_hoadon 
values(@id_hoadon,@id_monan,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[insert_hoadon]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_hoadon] @id_nhanvien int , @id_banan int ,@id_khachhang int,@id_khuyenmai int,@tinhtrang bit,@ngaylap date,@gio time
as
begin
insert into hoadon values(@id_nhanvien,@id_khachhang,@ngaylap,@gio,@tinhtrang,@id_khuyenmai,@id_banan)


end
GO
/****** Object:  StoredProcedure [dbo].[insert_nhanvien]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insert_nhanvien]  @id_account int,@username varchar(50),@pass varchar(50) ,@hoten nvarchar(50),@gioitinh bit,@ngaysinh date,
@diachi nvarchar(50),@sdt int,@chucvu nvarchar(50),@luong int
as
begin
insert into Account values(@id_account,@username,@pass)
insert into nhanvien values(@hoten,@gioitinh,@ngaysinh,@diachi,@sdt,@chucvu,@luong,@id_account)
end
GO
/****** Object:  StoredProcedure [dbo].[kiemtra_dangnhap]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[kiemtra_dangnhap] @username varchar(50),@pass varchar(50)
as
begin
select Account.user_name,Account.password,nhanvien.chucvu from Account,nhanvien where nhanvien.id_account=Account.id_account
 and Account.user_name =@username and Account.password=@pass
end
GO
/****** Object:  StoredProcedure [dbo].[seach_khachhang]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seach_khachhang] @name nvarchar(50)
as
begin
select * from khachhang where name_khachhang like '%'+ @name +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[seach_khachhang_diachi]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seach_khachhang_diachi] @diachi nvarchar(50)
as
begin
  select * from khachhang where diachi like '%'+@diachi+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[search_banan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[search_banan] @loc bit
as
begin

select ban_an.id_banan as [Số hiệu bàn] ,ban_an.chatlieu as [Chất liệu] ,tinhtrang as [Tình trạng] ,Loaibanan.soluongkhach as[Số lượng khách tối đa]
 from ban_an ,Loaibanan where ban_an.id_loaibanan=Loaibanan.id_loaiban and ban_an.tinhtrang=@loc

end
GO
/****** Object:  StoredProcedure [dbo].[search_hoadon]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[search_hoadon] @ten nvarchar(50)
as
begin

select hoadon.id_hoadon as [Mã hóa đơn] ,nhanvien.hoten as [Nhân viên lập ],khachhang.name_khachhang as [Tên khách hàng],
hoadon.id_bannan as [Số bàn ăn],
hoadon.ngaylap as [Ngày lập],hoadon.giolap as [Giờ lập],khuyenmai.name_khuyenmai as [khuyến mãi]
 ,hoadon.tinhtrang as [ Tình trạng thanh toán ]
 from hoadon ,nhanvien,khachhang,khuyenmai,ban_an
where hoadon.id_khachhang=khachhang.id_khachhang and hoadon.id_nhanvienlap= nhanvien.id_nhanvien and 
hoadon.id_khuyenmai=khuyenmai.id_khuyenmai and ban_an.id_banan=hoadon.id_bannan and khachhang.name_khachhang like '%'+@ten+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[search_khuyenmai]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[search_khuyenmai] @id int
as
begin
 select * from khuyenmai where id_khuyenmai=@id
end
GO
/****** Object:  StoredProcedure [dbo].[search_monan_theo_idloaimonan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[search_monan_theo_idloaimonan] @id_loaimonan int
as
begin
select * from monan where monan.id_loaimonan=@id_loaimonan

end
GO
/****** Object:  StoredProcedure [dbo].[search_nhanvien_ten]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[search_nhanvien_ten] @ten nvarchar(50)
as
begin

select nhanvien.id_nhanvien as [Mã nhân viên],nhanvien.hoten as [Họ và tên]
,nhanvien.gioitinh as[Giới tính],nhanvien.ngaysinh as [Ngày sinh],nhanvien.diachi as [Địa chỉ]
,nhanvien.sdt as [Số điện thoại] ,nhanvien.chucvu as [Chức vụ] ,nhanvien.luong as [Lương] ,Account.id_account ,Account.user_name as [Tên tài khoản],Account.password as [Mật khẩu]
from nhanvien,Account where nhanvien.id_account=Account.id_account and hoten like '%'+ @ten+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[show_dsmonan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[show_dsmonan] @id_hoadon int
as
begin
select monan.name_monan as [Tên món ăn],monan.gia_monan as [Đơn giá],chitiet_hoadon.soluong as [Số lượng] ,loai_mon_an.id_loaimonan 
from monan,chitiet_hoadon ,hoadon,loai_mon_an
 where chitiet_hoadon.id_hoadon=hoadon.id_hoadon and chitiet_hoadon.id_monan=monan.id_monan and chitiet_hoadon.id_hoadon= @id_hoadon and loai_mon_an.id_loaimonan=monan.id_loaimonan
end
GO
/****** Object:  StoredProcedure [dbo].[show_hoadon]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[show_hoadon]
as
begin
select hoadon.id_hoadon as [Mã hóa đơn] ,nhanvien.hoten as [Nhân viên lập ],khachhang.name_khachhang as [Tên khách hàng],
hoadon.id_bannan as [Số bàn ăn],
hoadon.ngaylap as [Ngày lập],hoadon.giolap as [Giờ lập],khuyenmai.name_khuyenmai as [khuyến mãi]
 ,hoadon.tinhtrang as [ Tình trạng thanh toán ]
 from hoadon ,nhanvien,khachhang,khuyenmai,ban_an
where hoadon.id_khachhang=khachhang.id_khachhang and hoadon.id_nhanvienlap= nhanvien.id_nhanvien and 
hoadon.id_khuyenmai=khuyenmai.id_khuyenmai and ban_an.id_banan=hoadon.id_bannan
end
GO
/****** Object:  StoredProcedure [dbo].[show_nhanvien]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[show_nhanvien]
as
begin
select nhanvien.id_nhanvien as [Mã nhân viên],nhanvien.hoten as [Họ và tên]
,nhanvien.gioitinh as[Giới tính],nhanvien.ngaysinh as [Ngày Sinh],nhanvien.diachi as [Địa chỉ]
,nhanvien.sdt as [Số điện thoại] ,nhanvien.chucvu as [Chức vụ] ,nhanvien.luong as [Lương] ,Account.id_account ,Account.user_name as [Tên tài khoản],Account.password as [Mật khẩu]
from nhanvien,Account where nhanvien.id_account=Account.id_account
end
GO
/****** Object:  StoredProcedure [dbo].[showbanan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[showbanan]
as
begin
select ban_an.id_banan as [Số hiệu bàn] ,ban_an.chatlieu as [Chất liệu] ,tinhtrang as [Tình trạng] ,Loaibanan.soluongkhach as[Số lượng khách tối đa] from ban_an ,Loaibanan
where ban_an.id_loaibanan=Loaibanan.id_loaiban
end
GO
/****** Object:  StoredProcedure [dbo].[showkhachhang]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[showkhachhang]
as
begin
select id_khachhang as [Mã khách hàng],name_khachhang as [ Tên khách hàng],gioitinh as [ Giới tính ],Ngaysinh as[Ngày sinh],
diachi as [Địa chỉ] ,sđt as [Số điện thoại],so_the as [Số thẻ]
from khachhang
end
GO
/****** Object:  StoredProcedure [dbo].[themkhachhang]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themkhachhang] @ten nvarchar(50),@gioitinh bit ,@ngaysinh date,@diachi nvarchar(50),@phone int,@card int
as
begin
insert into khachhang
values(@ten,@gioitinh,@ngaysinh,@diachi,@phone,@card)
end
GO
/****** Object:  StoredProcedure [dbo].[tinhtien]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[tinhtien] @id_hoadon int
 as
 begin
 select sum(monan.gia_monan*chitiet_hoadon.soluong) as tien  
from monan,chitiet_hoadon ,hoadon,loai_mon_an
 where chitiet_hoadon.id_hoadon=hoadon.id_hoadon and chitiet_hoadon.id_monan=monan.id_monan and chitiet_hoadon.id_hoadon= @id_hoadon and loai_mon_an.id_loaimonan=monan.id_loaimonan
 end
GO
/****** Object:  StoredProcedure [dbo].[update_banan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_banan] @id int , @chatlieuu nvarchar(50),@tinhtrang bit,@id_loaibanan int 
as
begin
update ban_an
set chatlieu=@chatlieuu,tinhtrang=@tinhtrang,id_loaibanan=@id_loaibanan
where id_banan=@id
end
GO
/****** Object:  StoredProcedure [dbo].[update_chitietmonan]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_chitietmonan] @id_hoadon int, @id_monan int ,@soluong int
as
begin
update chitiet_hoadon
set
soluong=@soluong
where id_hoadon=@id_hoadon and id_monan=@id_monan
end
GO
/****** Object:  StoredProcedure [dbo].[update_hoadon]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[update_hoadon] @id_hoadon int, @id_nhanvien int , @id_banan int ,@id_khachhang int,@id_khuyenmai int,@tinhtrang bit,@ngaylap date,@gio time
as
begin
update hoadon
set id_khachhang=@id_khachhang,id_nhanvienlap=@id_nhanvien,id_bannan=@id_banan,tinhtrang=@tinhtrang,id_khuyenmai=@id_khuyenmai
,ngaylap=@ngaylap,giolap=@gio
where id_hoadon=@id_hoadon
end
GO
/****** Object:  StoredProcedure [dbo].[update_khachhang]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_khachhang] @id int,  @ten nvarchar(50),@gioitinh bit ,@ngaysinh date,@diachi nvarchar(50),@phone int,@card int
as
begin
update khachhang 
set
 name_khachhang=@ten,gioitinh=@gioitinh,Ngaysinh=@ngaysinh,diachi=@diachi,sđt=@phone,so_the=@card
 where id_khachhang=@id
end
GO
/****** Object:  StoredProcedure [dbo].[update_nhanvien]    Script Date: 2/28/2019 12:35:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_nhanvien] @id_nhanvien int,@hoten nvarchar(50),@gioitinh bit,@ngaysinh date,@diachi nvarchar(50),@sdt int,@chucvu nvarchar(50),@luong int,@id_account int ,@tentk varchar(50),@matkhau varchar(50)
as
begin
update nhanvien
set 
hoten=@hoten,gioitinh=@gioitinh,ngaysinh=@ngaysinh,diachi=@diachi,sdt=@sdt,chucvu=@chucvu,luong=@luong
where id_nhanvien=@id_nhanvien

update Account
set user_name=@tentk,password=@matkhau
where id_account=@id_account
end
GO
