USE [QuanLyPizza]
GO
/****** Object:  Trigger [dbo].[tg_CheckProductName]    Script Date: 4/19/2024 8:07:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------------------------------
--TRIGGER kiểm tra lúc nhập sản phẩm vào không được trùng tên
ALTER TRIGGER [dbo].[tg_CheckProductName]
ON [dbo].[SanPham]
AFTER INSERT, UPDATE 
AS
BEGIN
 -- Kiểm tra tên sản phẩm vừa thêm có bị trùng lặp
	IF EXISTS (
				SELECT *
				FROM inserted i
				WHERE EXISTS (
								SELECT *
								FROM [dbo].[SanPham] sp
								WHERE sp.TenSP = i.TenSP AND sp.MaSP <> i.MaSP 
							  )
				)
	BEGIN
	-- Nếu trùng thì rollback
		RAISERROR ('Tên sản phẩm bị trùng', 16, 1)
		ROLLBACK;
	END
END
