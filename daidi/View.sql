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
CREATE OR ALTER VIEW vw_XemThongTinNhanVien
		AS
		SELECT NhanVien.*, ChucVu.TenChucVu,ChucVu.Luong FROM [dbo].[NhanVien] join ChucVu on NhanVien.MaChucVu = ChucVu.MaChucVu;

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
GO
--select * from vw_InfoAccountEmployee
--select * from TaiKhoan
--delete from TaiKhoan where UserName = ''
CREATE VIEW vw_XemLoaiSP AS 
SELECT  * FROM LoaiSanPham
Go
USE QuanLyPizza
CREATE VIEW vw_ChucVu AS 
SELECT TenChucVu FROM ChucVu

CREATE VIEW vw_XemKichCo AS 
SELECT * FROM KichCo


CREATE VIEW vw_XemKhachHang AS 
SELECT * FROM KhachHang

go
CREATE OR ALTER VIEW vw_XemHoaDon AS
SELECT hd.MaHD, hd.NgayGioDat, nv.TenNV, kh.TenKH, sp.TenSP, kc.TenKichCo, cthd.SoLuong, cthd.TriGia FROM HoaDonBanHang hd 
	JOIN ChiTietHD cthd ON hd.MaHD = cthd.MaHD 
	JOIN KhachHang kh ON kh.MaKH = hd.MaKH 
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
	JOIN KichCo kc ON kc.MaKichCo = cthd.MaKichCo
	JOIN SanPham sp ON sp.MaSP = cthd.MaSP
	GROUP BY hd.MaHD,hd.NgayGioDat, nv.TenNV, kh.TenKH, sp.TenSP, kc.TenKichCo, cthd.SoLuong, cthd.TriGia
GO
	
--select * from NhaCungCap
--select * from NguyenLieu
--select * from PhieuNhap
--select * from NhanVien
--select * from ChiTietCungCap
--select * from ChiTietPN

--MaPhieu, tenNV, SoLuong, tenNL, tenNCC, donGia
--NhanVien, PhieuNhap, ChiTietPN, NguyenLieu, NhaCungCap, ChiTietCungCap

CREATE OR ALTER VIEW vw_XemChiTietCungCap AS
SELECT pn.MaPhieu, nv.TenNV, ctpn.SoLuong, nl.TenNL, ncc.TenNCC, ctpn.DonGia from NhanVien nv
	JOIN PhieuNhap pn ON nv.MaNV = pn.MaNV
	JOIN ChiTietPN ctpn ON ctpn.MaPhieu = pn.MaPhieu
	JOIN NguyenLieu nl ON nl.MaNL = ctpn.MaNL
	JOIN ChiTietCungCap ctcc ON ctcc.MaNL = nl.MaNL
	JOIN NhaCungCap ncc ON ncc.MaNCC = ctcc.MaNCC

	--select * from vw_XemChiTietCungCap
	select * from KhachHang

