----------------------PROCEDURE----------------
USE QuanLyPizza
-----------------------------------------------------------------------------------------------
--Thêm nhân viên
GO
CREATE OR ALTER PROCEDURE sp_AddEmployee
	@MaNV CHAR(10),
	@HoNV NVARCHAR(10),
	@TenNV NVARCHAR(20),
	@NgaySinh DATE ,
	@GioiTinh NVARCHAR(3),
	@SoDT CHAR(10),
	@DiaChi NVARCHAR(50), 
	@Email VARCHAR(30) ,
	@CCCD CHAR(12), 
	@MaChucVu CHAR(10)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO NhanVien (MaNV, HoNV, TenNV, NgaySinh, GioiTinh, SoDT, DiaChi, Email, CCCD, MaChucVu)
		VALUES 
		(@MaNV, @HoNV, @TenNV, @NgaySinh, @GioiTinh, @SoDT, @DiaChi, @Email, @CCCD, @MaChucVu)
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RAISERROR('KHÔNG THÊM ĐƯỢC NHÂN VIÊN', 16, 1)
	END CATCH
END
GO
-----------------------------------------------------------------------------------------------
--sữa nhân viên
CREATE PROCEDURE sp_UpdateEmployee
	@MaNV CHAR(10),
	@HoNV NVARCHAR(10),
	@TenNV NVARCHAR(20),
	@NgaySinh DATE,
	@GioiTinh NVARCHAR(3),
	@SoDT CHAR(10),
	@DiaChi NVARCHAR(50), 
	@Email VARCHAR(30),
	@CCCD CHAR(12), 
	@MaChucVu CHAR(10)
AS
BEGIN
	BEGIN TRANSACTION;
	BEGIN TRY
		UPDATE NhanVien
		SET HoNV = @HoNV,
			TenNV = @TenNV,
			NgaySinh = @NgaySinh,
			GioiTinh = @GioiTinh,
			SoDT = @SoDT,
			DiaChi = @DiaChi,
			Email = @Email,
			CCCD = @CCCD,
			MaChucVu = @MaChucVu
		WHERE MaNV = @MaNV;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		RAISERROR('KHÔNG CẬP NHẬT ĐƯỢC NHÂN VIÊN', 16, 1); -- Sử dụng level 16 cho RAISERROR
	END CATCH;
END;
-----------------------------------------------------------------------------------------------
--Xóa nhân viên
GO

CREATE PROCEDURE sp_DeleteEmployee
	@MaNV CHAR(10)
AS
BEGIN
	BEGIN TRANSACTION;
	BEGIN TRY
		-- Xóa nhân viên từ bảng NhanVien dựa trên MaNV
		DELETE FROM NhanVien
		WHERE MaNV = @MaNV;

		-- Kiểm tra xem có bản ghi nào bị ảnh hưởng không
		IF @@ROWCOUNT = 0
		BEGIN
			-- Nếu không có bản ghi nào bị xóa, rollback giao dịch và phát sinh lỗi
			ROLLBACK TRANSACTION;
			RAISERROR('KHÔNG TÌM THẤY NHÂN VIÊN CÓ MaNV = %s', 16, 1, @MaNV); -- Thông báo lỗi không tìm thấy nhân viên
		END
		ELSE
		BEGIN
			-- Nếu xóa thành công, commit giao dịch
			COMMIT TRANSACTION;
			PRINT 'ĐÃ XÓA NHÂN VIÊN CÓ MaNV = ' + @MaNV; -- Thông báo xóa thành công
		END
	END TRY
	BEGIN CATCH
		-- Nếu có lỗi xảy ra, rollback giao dịch và phát sinh lỗi
		ROLLBACK TRANSACTION;
		RAISERROR('LỖI KHI XÓA NHÂN VIÊN', 16, 1); -- Phát sinh lỗi chung
	END CATCH;
END;
 exec dbo.sp_DeleteEmployee 'NV008'

GO
-----------------------------------------------------------------------------------------------
--xem danh sách phân ca trực
CREATE PROCEDURE sp_XemThongTinPhanCaTruc
AS
BEGIN
    SELECT c.*, nv.MaNV, nv.HoNV, nv.TenNV, ct.Ngay 
    FROM Ca c 
    JOIN ChiTietCaTruc ct ON c.MaCa = ct.MaCa
    JOIN NhanVien nv ON nv.MaNV = ct.MaNV
    ORDER BY c.MaCa;
END;


GO
-----------------------------------------------------------------------------------------------
--Thêm khách hàng
CREATE PROCEDURE sp_ThemThongTinKhachHang
	@MaKH char(10),
	@TenKH nvarchar(30),
	@SoDT char(10)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO KhachHang(MaKH, TenKH, SoDT)
		VALUES (@MaKH, @TenKH, @SoDT)
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		RAISERROR('KHÁCH HÀNG ĐÃ TỒN TẠI', 25, 1)
	END CATCH
END

GO
-----------------------------------------------------------------------------------------------
--Xóa thông tin khách hàng
CREATE PROCEDURE sp_XoaThongTinKhachHang
	@MaKH char(10)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DELETE FROM KhachHang WHERE MaKH = @MaKH
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		RAISERROR('Không xóa được khách hàng', 25, 1)
	END CATCH
END
Go
-----------------------------------------------------------------------------------------------
--Sửa thông tin khách hàng
CREATE PROCEDURE sp_CapNhatThongTinKhachHang
    @MaKH char(10),
    @TenKH nvarchar(30),
    @SoDT char(10)
AS
BEGIN
    BEGIN TRANSACTION
    BEGIN TRY
        UPDATE KhachHang
        SET TenKH = @TenKH,
            SoDT = @SoDT
        WHERE MaKH = @MaKH;
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH 
        ROLLBACK TRANSACTION
        RAISERROR('Cập nhật thông tin khách hàng không thành công', 25, 1)
    END CATCH
END

-----------------------------------------------------------------------------------------------
--Thêm ca
GO
CREATE PROCEDURE sp_AddCa
    @MaCa CHAR(10),
    @GioBatDau TIME,
    @GioKetThuc TIME
AS
BEGIN
    BEGIN TRY
        INSERT INTO Ca (MaCa, GioBatDau, GioKetThuc)
        VALUES (@MaCa, @GioBatDau, @GioKetThuc);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RAISERROR('Thêm thông tin ca không thành công', 25, 1)
    END CATCH
END;

-----------------------------------------------------------------------------------------------
--Sữa ca
go
CREATE PROCEDURE sp_UpdateCa
    @MaCa CHAR(10),
    @GioBatDau TIME,
    @GioKetThuc TIME
AS
BEGIN
    BEGIN TRY
        UPDATE Ca
        SET GioBatDau = @GioBatDau,
            GioKetThuc = @GioKetThuc
        WHERE MaCa = @MaCa;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RAISERROR('Cập nhật thông tin ca không thành công', 25, 1)
    END CATCH
END;

-----------------------------------------------------------------------------------------------
--Xóa ca
go
CREATE PROCEDURE sp_DeleteCa
    @MaCa CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM Ca
        WHERE MaCa = @MaCa;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RAISERROR('Xóa thông tin ca không thành công', 25, 1)
    END CATCH
END;

-----------------------------------------------------------------------------------------------
--thêm xóa sửa chi tiết ca trực
go
CREATE PROCEDURE sp_AddChiTietCaTruc
    @MaNV CHAR(10),
    @MaCa CHAR(10),
    @Ngay DATE
AS
BEGIN
    BEGIN TRY
        INSERT INTO ChiTietCaTruc (MaNV, MaCa, Ngay)
        VALUES (@MaNV, @MaCa, @Ngay);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Thêm thông tin chi tiết ca trực không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_UpdateChiTietCaTruc
    @MaNV CHAR(10),
    @MaCa CHAR(10),
    @Ngay DATE
AS
BEGIN
    BEGIN TRY
        UPDATE ChiTietCaTruc
        SET Ngay = @Ngay
        WHERE MaNV = @MaNV AND MaCa = @MaCa;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Cập nhật thông tin chi tiết ca trực không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_DeleteChiTietCaTruc
    @MaNV CHAR(10),
    @MaCa CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM ChiTietCaTruc
        WHERE MaNV = @MaNV AND MaCa = @MaCa;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Xóa thông tin chi tiết ca trực không thành công', 25, 1);
    END CATCH
END;

-----------------------------------------------------------------------------------------------
-- thêm xóa sửa chi tiết cung cấp
go
CREATE PROCEDURE sp_AddChiTietCungCap
    @MaNCC CHAR(10),
    @MaNL CHAR(10)
AS
BEGIN
    BEGIN TRY
        INSERT INTO ChiTietCungCap (MaNCC, MaNL)
        VALUES (@MaNCC, @MaNL);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RAISERROR('thêm thông tin chi tiết cung cấp không thành công', 25, 1)
    END CATCH
END;

go
CREATE PROCEDURE sp_UpdateChiTietCungCap
    @MaNCC CHAR(10),
    @MaNL CHAR(10),
    -- Thêm các tham số cần cập nhật
    @NewMaNCC CHAR(10),
    @NewMaNL CHAR(10)
AS
BEGIN
    BEGIN TRY
        UPDATE ChiTietCungCap
        SET MaNCC = @NewMaNCC, -- Cập nhật Mã nhà cung cấp mới
            MaNL = @NewMaNL   -- Cập nhật Mã nguyên liệu mới
        WHERE MaNCC = @MaNCC AND MaNL = @MaNL;
    END TRY
    BEGIN CATCH
         ROLLBACK TRANSACTION
        RAISERROR('Sửa thông tin chi tiết cung cấp không thành công', 25, 1)
    END CATCH
END;

go
CREATE PROCEDURE sp_DeleteChiTietCungCap
    @MaNCC CHAR(10),
    @MaNL CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM ChiTietCungCap
        WHERE MaNCC = @MaNCC AND MaNL = @MaNL;
    END TRY
    BEGIN CATCH
         ROLLBACK TRANSACTION
        RAISERROR('xóa thông tin chi tiết cung cấp không thành công', 25, 1)
    END CATCH
END;

-----------------------------------------------------------------------------------------------
--thêm xóa sửa tài khoản
go
CREATE or alter PROCEDURE sp_AddTaiKhoan
    @UserName VARCHAR(20),
    @Password VARCHAR(20),
    @MaNV CHAR(10),
    @Role INT
AS
BEGIN
    BEGIN TRY
        INSERT INTO TaiKhoan (UserName, Password, MaNV, Role)
        VALUES (@UserName, @Password, @MaNV, @Role);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Thêm thông tin tài khoản không thành công', 16, 1);
    END CATCH
END;


go
CREATE PROCEDURE sp_UpdateTaiKhoan
    @UserName VARCHAR(20),
    @Password VARCHAR(20),
    @MaNV CHAR(10),
    @Role INT
AS
BEGIN
    BEGIN TRY
        UPDATE TaiKhoan
        SET Password = @Password,
            MaNV = @MaNV,
            Role = @Role
        WHERE UserName = @UserName;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Cập nhật thông tin tài khoản không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_DeleteTaiKhoan
    @UserName VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        DELETE FROM TaiKhoan
        WHERE UserName = @UserName;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Xóa thông tin tài khoản không thành công', 25, 1);
    END CATCH
END;
go
-----------------------------------------------------------------------------------------------
--thêm xóa sửa sản phẩm
go
CREATE OR ALTER PROCEDURE sp_AddSanPham
    @MaSP CHAR(10),
    @TenSP NVARCHAR(30),
    @MaLoaiSP CHAR(10),
    @HinhAnh IMAGE
AS
BEGIN
    BEGIN TRY
        INSERT INTO SanPham (MaSP, TenSP, MaLoaiSP, HinhAnh)
        VALUES (@MaSP, @TenSP, @MaLoaiSP, @HinhAnh);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Thêm thông tin sản phẩm không thành công', 16, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_UpdateSanPham
    @MaSP CHAR(10),
    @TenSP NVARCHAR(30),
    @MaLoaiSP CHAR(10),
    @HinhAnh IMAGE
AS
BEGIN
    BEGIN TRY
        UPDATE SanPham
        SET TenSP = @TenSP,
            MaLoaiSP = @MaLoaiSP,
            HinhAnh = @HinhAnh
        WHERE MaSP = @MaSP;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Cập nhật thông tin sản phẩm không thành công', 25, 1);
    END CATCH
END;

go
CREATE OR ALTER PROCEDURE sp_DeleteSanPham
    @MaSP CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM SanPham
        WHERE MaSP = @MaSP;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Xóa thông tin sản phẩm không thành công', 16, 1);
    END CATCH
END;
go

-----------------------------------------------------------------------------------------------
--thêm xóa sửa hóa đơn bán hàng
go
CREATE PROCEDURE sp_AddHoaDonBanHang
    @MaHD CHAR(10),
    @NgayGioDat DATETIME,
    @MaNV CHAR(10),
    @MaKH CHAR(10)
AS
BEGIN
    BEGIN TRY
        INSERT INTO HoaDonBanHang (MaHD, NgayGioDat, MaNV, MaKH)
        VALUES (@MaHD, @NgayGioDat, @MaNV, @MaKH);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Thêm thông tin hóa đơn bán hàng không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_UpdateHoaDonBanHang
    @MaHD CHAR(10),
    @NgayGioDat DATETIME,
    @MaNV CHAR(10),
    @MaKH CHAR(10)
AS
BEGIN
    BEGIN TRY
        UPDATE HoaDonBanHang
        SET NgayGioDat = @NgayGioDat,
            MaNV = @MaNV,
            MaKH = @MaKH
        WHERE MaHD = @MaHD;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Cập nhật thông tin hóa đơn bán hàng không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_DeleteHoaDonBanHang
    @MaHD CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM HoaDonBanHang
        WHERE MaHD = @MaHD;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Xóa thông tin hóa đơn bán hàng không thành công', 25, 1);
    END CATCH
END;

-----------------------------------------------------------------------------------------------
--thêm xóa sửa chi tiết hóa đơn 
go
CREATE PROCEDURE sp_AddChiTietHD
    @MaHD CHAR(10),
    @MaSP CHAR(10),
    @MaKichCo CHAR(10),
    @SoLuong INT,
    @TriGia MONEY
AS
BEGIN
    BEGIN TRY
        INSERT INTO ChiTietHD (MaHD, MaSP, MaKichCo, SoLuong, TriGia)
        VALUES (@MaHD, @MaSP, @MaKichCo, @SoLuong, @TriGia);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Thêm thông tin chi tiết hóa đơn không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_UpdateChiTietHD
    @MaHD CHAR(10),
    @MaSP CHAR(10),
    @MaKichCo CHAR(10),
    @SoLuong INT,
    @TriGia MONEY
AS
BEGIN
    BEGIN TRY
        UPDATE ChiTietHD
        SET SoLuong = @SoLuong,
            TriGia = @TriGia
        WHERE MaHD = @MaHD AND MaSP = @MaSP AND MaKichCo = @MaKichCo;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Cập nhật thông tin chi tiết hóa đơn không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_DeleteChiTietHD
    @MaHD CHAR(10),
    @MaSP CHAR(10),
    @MaKichCo CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM ChiTietHD
        WHERE MaHD = @MaHD AND MaSP = @MaSP AND MaKichCo = @MaKichCo;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Xóa thông tin chi tiết hóa đơn không thành công', 25, 1);
    END CATCH
END;

-----------------------------------------------------------------------------------------------
--thêm xóa sửa phiếu nhập
go
CREATE PROCEDURE sp_AddPhieuNhap
    @MaPhieu CHAR(10),
    @NgayNhap DATE,
    @TriGiaDonNH MONEY,
    @MaNV CHAR(10),
    @MaNCC CHAR(10)
AS
BEGIN
    BEGIN TRY
        INSERT INTO PhieuNhap (MaPhieu, NgayNhap, TriGiaDonNH, MaNV, MaNCC)
        VALUES (@MaPhieu, @NgayNhap, @TriGiaDonNH, @MaNV, @MaNCC);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Thêm thông tin phiếu nhập không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_UpdatePhieuNhap
    @MaPhieu CHAR(10),
    @NgayNhap DATE,
    @TriGiaDonNH MONEY,
    @MaNV CHAR(10),
    @MaNCC CHAR(10)
AS
BEGIN
    BEGIN TRY
        UPDATE PhieuNhap
        SET NgayNhap = @NgayNhap,
            TriGiaDonNH = @TriGiaDonNH,
            MaNV = @MaNV,
            MaNCC = @MaNCC
        WHERE MaPhieu = @MaPhieu;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Cập nhật thông tin phiếu nhập không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_DeletePhieuNhap
    @MaPhieu CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM PhieuNhap
        WHERE MaPhieu = @MaPhieu;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Xóa thông tin phiếu nhập không thành công', 25, 1);
    END CATCH
END;

-----------------------------------------------------------------------------------------------
--thêm xóa sửa chi tiết phiếu nhập
go
CREATE PROCEDURE sp_AddChiTietPN
    @MaPhieu CHAR(10),
    @MaNL CHAR(10),
    @SoLuong INT,
    @DonGia MONEY
AS
BEGIN
    BEGIN TRY
        INSERT INTO ChiTietPN (MaPhieu, MaNL, SoLuong, DonGia)
        VALUES (@MaPhieu, @MaNL, @SoLuong, @DonGia);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Thêm thông tin chi tiết phiếu nhập không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_UpdateChiTietPN
    @MaPhieu CHAR(10),
    @MaNL CHAR(10),
    @SoLuong INT,
    @DonGia MONEY
AS
BEGIN
    BEGIN TRY
        UPDATE ChiTietPN
        SET SoLuong = @SoLuong,
            DonGia = @DonGia
        WHERE MaPhieu = @MaPhieu AND MaNL = @MaNL;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Cập nhật thông tin chi tiết phiếu nhập không thành công', 25, 1);
    END CATCH
END;

go
CREATE PROCEDURE sp_DeleteChiTietPN
    @MaPhieu CHAR(10),
    @MaNL CHAR(10)
AS
BEGIN
    BEGIN TRY
        DELETE FROM ChiTietPN
        WHERE MaPhieu = @MaPhieu AND MaNL = @MaNL;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR('Xóa thông tin chi tiết phiếu nhập không thành công', 25, 1);
    END CATCH
END;
--Thêm xóa sữa loại sản phẩm
Go
CREATE PROCEDURE sp_AddTypeProduct
	@MaLoaiSP char(10),
	@TenLoaiSP nvarchar(30)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO LoaiSanPham(MaLoaiSP, TenLoaiSP)
		VALUES (@MaLoaiSP, @TenLoaiSP)
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		RAISERROR('Loại sản phẩm đã tồn tại', 18, 1)
		--LỖI Ở MỨC ĐỘ 18, XEM LẠI NHÉ AE, KH BIẾT NÊN ĐỂ SỐ MẤY
	END CATCH
END
GO
GO
CREATE PROCEDURE sp_DeleteTypeProduct
    @MaLoaiSP char(10)
AS
BEGIN
    BEGIN TRANSACTION
    BEGIN TRY
        DELETE FROM LoaiSanPham WHERE MaLoaiSP = @MaLoaiSP;
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH 
        ROLLBACK TRANSACTION
        RAISERROR('Không thể xóa loại sản phẩm', 18, 1)
    END CATCH
END

GO
CREATE PROCEDURE sp_UpdateTypeProduct
    @MaLoaiSP char(10),
    @TenLoaiSP nvarchar(30)
AS
BEGIN
    BEGIN TRANSACTION
    BEGIN TRY
        UPDATE LoaiSanPham
        SET TenLoaiSP = @TenLoaiSP
        WHERE MaLoaiSP = @MaLoaiSP;
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH 
        ROLLBACK TRANSACTION
        RAISERROR('Cập nhật thông tin loại sản phẩm không thành công', 18, 1)
    END CATCH
END