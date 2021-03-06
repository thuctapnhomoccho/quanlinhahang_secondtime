USE [quanlinhahang]
GO
/****** Object:  StoredProcedure [dbo].[checkaccount]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[checklogin]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[delete_banan]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[delete_khachhang]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[delete_nhanvien]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[hienthi]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[insert_banan]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[insert_nhanvien]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[seach_khachhang]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[seach_khachhang_diachi]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[search_banan]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[search_nhanvien_ten]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[show_nhanvien]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[showbanan]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[showkhachhang]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[themkhachhang]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[update_banan]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[update_khachhang]    Script Date: 2/26/2019 2:57:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[update_nhanvien]    Script Date: 2/26/2019 2:57:03 PM ******/
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
