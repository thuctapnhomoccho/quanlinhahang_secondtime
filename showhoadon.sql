USE [quanlinhahang]
GO
/****** Object:  StoredProcedure [dbo].[showhoadon]    Script Date: 2/26/2019 3:18:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[showhoadon]
AS
BEGIN
SELECT        dbo.chitiet_hoadon.id_hoadon, dbo.hoadon.id_nhanvienlap, dbo.hoadon.ngaylap, dbo.loai_mon_an.name_loaimonan, dbo.monan.name_monan, 
              dbo.monan.gia_monan, dbo.chitiet_hoadon.soluong, dbo.khuyenmai.phantram_discount, 
( (dbo.chitiet_hoadon.soluong * dbo.monan.gia_monan)  -   ( ((dbo.chitiet_hoadon.soluong * dbo.monan.gia_monan) * dbo.khuyenmai.phantram_discount))/100 ) AS thanhtien
FROM            dbo.chitiet_hoadon INNER JOIN
                         dbo.hoadon ON dbo.chitiet_hoadon.id_hoadon = dbo.hoadon.id_hoadon INNER JOIN
                         dbo.monan ON dbo.chitiet_hoadon.id_monan = dbo.monan.id_monan INNER JOIN
                         dbo.loai_mon_an ON dbo.monan.id_loaimonan = dbo.loai_mon_an.id_loaimonan INNER JOIN
                         dbo.khuyenmai ON dbo.hoadon.id_khuyenmai = dbo.khuyenmai.id_khuyenmai
END
GO
