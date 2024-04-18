---------------------------VIEW----------------------------
USE QuanLyPizza
select * from ChiTietCaTruc
select * from Ca
-----------------------------------------------------------------------------------------------
--Xem thông tin ca trực
GO
CREATE VIEW vw_XemThongTinCatruc
		AS
		SELECT * FROM Ca;

GO
--select * from vw_XemThongTinPhanCaTruc
--drop view vw_XemThongTinPhanCaTruc
--CREATE VIEW vw_XemThongTinPhanCaTruc
--AS
--SELECT c.*, nv.MaNV, nv.HoNV, nv.TenNV, ct.Ngay 
--FROM Ca c 
--JOIN ChiTietCaTruc ct ON c.MaCa = ct.MaCa
--JOIN NhanVien nv ON nv.MaNV = ct.MaNV
--ORDER BY c.MaCa;

GO
-----------------------------------------------------------------------------------------------
--Xem thông tin nhân viên
CREATE VIEW vw_XemThongTinNhanVien
		AS
		SELECT * FROM [dbo].[NhanVien];

GO

		CREATE VIEW vw_XemThongTinKhachHang 
		AS
		SELECT * FROM KhachHang;

GO
SELECT * FROM vw_XemThongTinKhachHang
-----------------------------------------------------------------------------------------------
--xem danh sách sản phẩm
GO
CREATE VIEW vw_XemDanhSachSanPham
AS
SELECT SP.MaSP, SP.TenSP, SP.MaLoaiSP, CK.TenKichCo, CTKC.DonGia AS DonGiaKichCo, LSP.TenLoaiSP
FROM SanPham SP
JOIN ChiTietKichCo CTKC ON SP.MaSP = CTKC.MaSP
JOIN KichCo CK ON CTKC.MaKichCo = CK.MaKichCo
JOIN LoaiSanPham LSP ON SP.MaLoaiSP = LSP.MaLoaiSP;
GO
SELECT * FROM vw_XemDanhSachSanPham
----------------------------------------------------------------------------------------------
go
--drop view vw_XemCaLamViecTheoNgay
--CREATE VIEW vw_XemCaLamViecTheoNgay 
--AS
--SELECT
--	ct.Ngay, nv.HoNV, nv.TenLotNV,
--    nv.TenNV, Ca.GioBatDau,	Ca.GioKetThuc
--FROM
--    (ChiTietCaTruc ct join Ca on ct.MaCa = Ca.MaCa) 
--	join NhanVien nv on nv.MaNV = ct.MaNV
--GROUP BY 
--	DAY(ct.Ngay), nv.HoNV, nv.TenLotNV, nv.TenNV, 
--	Ca.GioBatDau, ct.Ngay, Ca.GioKetThuc;
--GO
--select * from vw_XemCaLamViecTheoNgay
----------------------------------------------------------------------------------------------
go
--xem doanh thu theo ngày tháng năm
CREATE VIEW vw_XemDoanhThuTheoNgayThangNam AS
SELECT
    YEAR(NgayGioDat) AS Nam,
    MONTH(NgayGioDat) AS Thang,
	DAY(NgayGioDat) AS Ngay,
    SUM(TriGia) AS DoanhThu
FROM
    HoaDonBanHang hd JOIN 
    ChiTietHD ct ON hd.MaHD = ct.MaHD
GROUP BY
    YEAR(NgayGioDat),
    MONTH(NgayGioDat),
	DAY(NgayGioDat);
	
go
select * from vw_XemDoanhThuTheoNgayThangNam
----------------------------------------------------------------------------------------------------
go
--xem số lượng sản phẩm bán trong ngày
CREATE VIEW vw_XemSoLuongSanPhamDaBanTrongNgay AS 
SELECT  
    DATEPART(YEAR, HoaDonBanHang.NgayGioDat) AS Nam,
    DATEPART(MONTH, HoaDonBanHang.NgayGioDat) AS Thang,
    DATEPART(DAY, HoaDonBanHang.NgayGioDat) AS Ngay,
    SanPham.TenSP, 
    SUM(ChiTietHD.SoLuong) AS SoLuongBan
FROM 
    (HoaDonBanHang 
    JOIN ChiTietHD ON ChiTietHD.MaHD = HoaDonBanHang.MaHD) 
    JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP
GROUP BY
    DATEPART(YEAR, HoaDonBanHang.NgayGioDat),
    DATEPART(MONTH, HoaDonBanHang.NgayGioDat),
    DATEPART(DAY, HoaDonBanHang.NgayGioDat), --DATEPART là lấy chính xác phần cần lấy từ mốc thời gian
    SanPham.TenSP;

go
select * from vw_XemSoLuongSanPhamDaBanTrongNgay
go
----------------------------------------------------------------------------------------------------
--xem số lượng nguyên liệu đã nhập trong ngày
CREATE VIEW vw_XemSoLuongNguyenLieuDaNhapTrongNgay AS 
SELECT  
    DATEPART(YEAR, PhieuNhap.NgayNhap) AS Nam,
    DATEPART(MONTH, PhieuNhap.NgayNhap) AS Thang,
    DATEPART(DAY, PhieuNhap.NgayNhap) AS Ngay,
    NguyenLieu.TenNL,
    SUM(ChiTietPN.SoLuong) AS TongSoLuong,
	NguyenLieu.DonVi
FROM 
    (ChiTietPN 
    JOIN NguyenLieu ON ChiTietPN.MaNL = NguyenLieu.MaNL)
    JOIN PhieuNhap ON PhieuNhap.MaPhieu = ChiTietPN.MaPhieu
GROUP BY
    DATEPART(YEAR, PhieuNhap.NgayNhap),
    DATEPART(MONTH, PhieuNhap.NgayNhap),
    DATEPART(DAY, PhieuNhap.NgayNhap),
    NguyenLieu.TenNL,NguyenLieu.DonVi;

	go
--select * from vw_XemSoLuongNguyenLieuDaNhapTrongNgay
go

--view xem thông tin tài khoản nhân viên
CREATE VIEW vw_InfoAccountEmployee AS 
SELECT  * FROM [dbo].[TaiKhoan]
--select * from vw_InfoAccountEmployee
--select * from TaiKhoan
--delete from TaiKhoan where UserName = ''
CREATE VIEW vw_XemLoaiSP AS 
SELECT  * FROM LoaiSanPham