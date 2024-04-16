----------------------PROCEDURE----------------
CREATE PROCEDURE sp_AddEmployee
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
		RAISERROR('KHÔNG THÊM ĐƯỢC NHÂN VIÊN', 25, 1)
	END CATCH
END


----xem danh sách phân ca trực----
CREATE PROCEDURE sp_XemThongTinPhanCaTruc
AS
BEGIN
    SELECT c.*, nv.MaNV, nv.HoNV, nv.TenNV, ct.Ngay 
    FROM Ca c 
    JOIN ChiTietCaTruc ct ON c.MaCa = ct.MaCa
    JOIN NhanVien nv ON nv.MaNV = ct.MaNV
    ORDER BY c.MaCa;
END;



----------------------PROCEDURE----------------
-- Them Nhan Vien
CREATE PROCEDURE sp_ThemThongTinNhanVien
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
		RAISERROR('KHÔNG THÊM ĐƯỢC NHÂN VIÊN', 25, 1)
	END CATCH
END

GO
--Xoa Nhan Vien
CREATE PROCEDURE sp_XoaThongTinNhanVien
@MaNV CHAR(10)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DELETE FROM NhanVien WHERE MaNV = @MaNV
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RAISERROR('KHÔNG XÓA ĐƯỢC NHÂN VIÊN', 25, 1)
	END CATCH
END

GO
--Sua Nhan Vien
CREATE PROCEDURE sp_CapNhatThongTinNhanVien
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
		RAISERROR('CẬP NHẬT THÔNG TIN NHÂN VIÊN KHÔNG THÀNH CÔNG', 25, 1)
	END CATCH
END;

GO
--Them khach hang
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

