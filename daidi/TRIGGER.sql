-------------TRIGGER---------------
--TRIGGER lúc thêm sản phẩm vào thì số lượng nguyên liệu để chế biến sản phẩm đó giảm
use QuanLyPizza
GO

CREATE or alter TRIGGER tg_DeleteEmployeeThenDeleteAccount ON NhanVien
AFTER DELETE 
AS
BEGIN
    -- Xóa tài khoản của nhân viên bị xóa
	BEGIN TRAN
	BEGIN TRY
		DECLARE @MaNV CHAR(10)
		SELECT @MaNV = d.MaNV FROM  deleted d
		DELETE FROM TaiKhoan
		WHERE MaNV is null;
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		RAISERROR ('Không xóa được tài khoản', 16, 1);
		ROLLBACK
	END CATCH
END
delete from NhanVien where MaNV = 'NV003'
-- Complete TRIGGER
GO

------------------------
--Trigger khi xuất ra n hóa đơn thì số lượng sản phẩm trong chi tiết kích cỡ giảm đi n, 
-- NẾU SẢN PHẨM KHÔNG ĐỦ, THÌ ĐỢI LÀM THÊM.
CREATE OR ALTER TRIGGER tg_ExportOrderThenSizeDetailDecrease ON ChiTietHD
FOR INSERT
AS
BEGIN
	BEGIN TRAN
	BEGIN TRY
		DECLARE @MaSP CHAR(10), @Size CHAR(10), @SoLuong int
		SELECT @MaSP = i.MaSP, @Size = i.MaKichCo, @SoLuong = i.SoLuong FROM  inserted i
		IF (SELECT SoLuong FROM ChiTietKichCo WHERE MaSP = @MaSP AND MaKichCo = @Size) < @SoLuong
        BEGIN
            -- Nếu số lượng âm, rollback giao dịch và thông báo lỗi
            ROLLBACK
            RAISERROR('Không đủ sản phẩm', 16, 1)
        END
		ELSE
		BEGIN
			UPDATE ChiTietKichCo 
				SET @SoLuong = SoLuong - @SoLuong 
				WHERE @MaSP = MaSP AND @Size = MaKichCo
		END	
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		RAISERROR ('Không đặt được sản phẩm', 16, 1);
		ROLLBACK
	END CATCH
END
GO
INSERT INTO ChiTietHD(SoLuong,TriGia,MaHD,MaKichCo,MaSP) VALUES (1, 100000, 'HD006', 'KC001','SP001')
SELECT * FROM ChiTietKichCo
-- DONE 
-------------------------
--TRIGGER Khách hàng order nhưng hiện không đủ sản phẩm, mà nguyên liệu hết d. -- mai suy nghĩ
-- gộp cái trên
GO
--. Kiểm tra trùng lặp số điện thoại của khách hàng
CREATE TRIGGER tg_DuplicatePhoneNumber
ON dbo.KhachHang
AFTER INSERT, UPDATE
AS
BEGIN
 -- Kiểm tra số điện thoại vừa thêm có bị trùng lặp
	 IF EXISTS (
	 SELECT *
	 FROM inserted i
	 WHERE EXISTS (
			 SELECT * FROM dbo.KhachHang k
			 WHERE k.SoDT = i.SoDT AND k.MaKH != i.MaKH)
				  )
 BEGIN
	RAISERROR ('Trùng số điện thoại khách hàng', 16, 1)
	ROLLBACK;
 END
END
-- chưa test

-- Trigger bắt lỗi khi thêm khách hàng mới, xem cần không
GO
select * from NhanVien
select * from TaiKhoan


GO
select * from HoaDonBanHang
select * from ChiTiethd
select * from ChiTietKichCo
select * from ChiTietCaTruc
select * from PhieuNhap
select * from CheBien
SELECT * FROM SanPham
select * from ChiTietKichCo
SELECT * FROM NguyenLieu
SELECT * FROM ChiTietCaTruc
SELECT * FROM ChucVu