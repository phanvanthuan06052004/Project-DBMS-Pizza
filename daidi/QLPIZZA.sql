--DROP DATABASE QuanLyPizza
--CREATE DATABASE QuanLyPizza
--USE QuanLyPizza
--USE northwindS
GO
CREATE TABLE ChucVu
(
  MaChucVu CHAR(10),
  TenChucVu NVARCHAR(30) NOT NULL,
  Luong MONEY NOT NULL,
  CONSTRAINT Ck_ChucVu_Luong CHECK (Luong > 0),
  CONSTRAINT Pk_ChucVu_MaChucVu PRIMARY KEY (MaChucVu) 
);
GO
--drop table NguyenLieuS
CREATE TABLE NguyenLieu
(
  MaNL CHAR(10),
  TenNL NVARCHAR(30) NOT NULL,
  SoLuong DECIMAL(30,2),
  DonVi NVARCHAR(20),
  CONSTRAINT Pk_NguyenLieu_MaNL PRIMARY KEY (MaNL),
  CONSTRAINT Ck_NguyenLieu_SoLuong CHECK (SoLuong > 0)
);
GO
CREATE TABLE NhaCungCap
(
  MaNCC CHAR(10),
  TenNCC NVARCHAR(50) NOT NULL,
  DiaChi NVARCHAR(50) NOT NULL,
  SoDT varCHAR(10) NOT NULL ,
  CONSTRAINT Pk_NhaCungCap_MaNCC PRIMARY KEY (MaNCC),
  CONSTRAINT Ck_NhaCungCap_SoDT CHECK (LEN(SoDT) = 10 AND SoDT NOT LIKE '%[^0-9]%')
--So dien thoai phai la chu so va do dai la 10
);
GO
CREATE TABLE KhachHang
(
  MaKH CHAR(10),
  TenKH NVARCHAR(30) NOT NULL,
  SoDT CHAR(10) not null,
  CONSTRAINT Pk_KhachHang_MaKH PRIMARY KEY (MaKH),
  CONSTRAINT Ck_KhachHang_SoDT CHECK (LEN(SoDT) = 10 AND SoDT NOT LIKE '%[^0-9]%')
);
GO
CREATE TABLE Ca
(
  MaCa CHAR(10),
  GioBatDau TIME NOT NULL,
  GioKetThuc TIME NOT NULL,
  CONSTRAINT Pk_Ca_MaCa PRIMARY KEY (MaCa)
);
GO
CREATE TABLE LoaiSanPham
(
  MaLoaiSP CHAR(10),
  TenLoaiSP NVARCHAR(30) NOT NULL ,
  CONSTRAINT Pk_LoaiSanPham_MaLoaiSP PRIMARY KEY (MaLoaiSP)
);
GO
CREATE TABLE KichCo
(
  MaKichCo CHAR(10),
  TenKichCo NVARCHAR(30) NOT NULL,
  CONSTRAINT Pk_KichCo_MaKichCo PRIMARY KEY (MaKichCo)
);
GO
CREATE TABLE ChiTietCungCap
(
  MaNCC CHAR(10) NOT NULL,
  MaNL CHAR(10) NOT NULL,
  CONSTRAINT Pk_ChiTietCungCap_MaNCC_MaNL PRIMARY KEY (MaNCC, MaNL),
  CONSTRAINT Fk_ChiTietCungCap_NhaCungCap_MaNCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
  CONSTRAINT Fk_ChiTietCungCap_NguyenLieu_MaNL FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL)
);
GO
CREATE TABLE NhanVien
(
  MaNV CHAR(10) ,----MANV tự tăng----
  HoNV NVARCHAR(10) NOT NULL,
  TenNV NVARCHAR(20) NOT NULL,
  NgaySinh DATE NOT NULL ,
  GioiTinh NVARCHAR(3),
  SoDT CHAR(10) not null ,
  DiaChi NVARCHAR(50) NOT NULL, 
  Email VARCHAR(30) ,
  CCCD CHAR(12) NOT NULL, 
  MaChucVu CHAR(10) NOT NULL,
  CONSTRAINT Pk_NhanVien_MaNV PRIMARY KEY(MaNV),
  CONSTRAINT Fk_NhanVien_ChucVu_MaChucVu FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu),
  CONSTRAINT Ck_NhanVien_Ngaysinh CHECK (DATEDIFF(YEAR, NgaySinh, GETDATE()) >= 18),--NV phải trên 18 tuổi
  CONSTRAINT Ck_NhanVien_SoDT CHECK (LEN(SoDT) = 10 AND SoDT NOT LIKE '%[^0-9]%'),
  CONSTRAINT Ck_NhanVien_CCCD CHECK(len(CCCD)=12),--CCCD đúng định dạng
  CONSTRAINT Ck_NhanVien_Email CHECK (Email like '%@gmail.com')
);
use QuanLyPizza
ALTER TABLE NhanVien
DROP CONSTRAINT Ck_NhanVien_Ngaysinh;

ALTER TABLE NhanVien
ADD CONSTRAINT Ck_NhanVien_Ngaysinh CHECK (DATEDIFF(YEAR, NgaySinh, GETDATE()) >= 19);

GO
CREATE TABLE TaiKhoan
(
  UserName VARCHAR(20) NOT NULL,
  Password VARCHAR(20) NOT NULL,---**************FIXXXXX***********************
  MaNV CHAR(10),   -- nên để MaNV và Role là null bởi vì lúc đăng kí mình chỉ quan tâm 
  Role int ,		-- admin chứ còn nhân viên hồi mình tự thêm đươi data, Hoặc để số tự tăng
  CONSTRAINT Pk_TaiKhoan_UserName PRIMARY KEY(UserName),
  CONSTRAINT Fk_TaiKhoan_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE SET NULL
);
GO
CREATE TABLE SanPham
(
  MaSP CHAR(10),
  TenSP NVARCHAR(30) NOT NULL,
  MaLoaiSP CHAR(10) NOT NULL,
  HinhAnh NVARCHAR(MAX),
  CONSTRAINT Pk_SanPham_MaSP PRIMARY KEY (MaSP),
  CONSTRAINT FK_SanPham_LoaiSanPham_MaLoaiSP FOREIGN KEY (MaLoaiSP) REFERENCES LoaiSanPham(MaLoaiSP)
);
GO
CREATE TABLE HoaDonBanHang
(
  MaHD CHAR(10),
  NgayGioDat DATETIME NOT NULL,
  MaNV CHAR(10),
  MaKH CHAR(10) NOT NULL,
  CONSTRAINT Pk_HoaDonBanHang_MaHD PRIMARY KEY (MaHD),
  CONSTRAINT Fk_HoaDonBanHang_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE SET NULL,
  CONSTRAINT FK_HoaDonBanHang_KhachHang_MaKH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) 
);
GO
CREATE TABLE PhieuNhap
(
  MaPhieu CHAR(10),
  NgayNhap DATE NOT NULL,
  TriGiaDonNH MONEY NOT NULL,
  MaNV CHAR(10),
  MaNCC CHAR(10) NOT NULL,
  CONSTRAINT Pk_PhieuNhap_MaPhieu PRIMARY KEY (MaPhieu),
  CONSTRAINT Fk_PhieuNhap_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE SET NULL,
  CONSTRAINT Fk_PhieuNhap_NhaCungCap_MaNCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
  CONSTRAINT Ck_PhieuNhap_TriGiaDonNH CHECK (TriGiaDonNH > 0)
);
GO
---sua lai khoa ngoai null dc
CREATE TABLE ChiTietPN
(
  SoLuong INT,
  MaPhieu CHAR(10) CONSTRAINT Fk_ChiTietPN_PhieuNhap_MaPhieu FOREIGN KEY (MaPhieu) REFERENCES PhieuNhap(MaPhieu),
  MaNL CHAR(10) CONSTRAINT Fk_ChiTietPN_NguyenLieu_MaNL FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL),
  DonGia MONEY,
  CONSTRAINT Pk_ChiTietPN_MaPhieu_MaNL PRIMARY KEY (MaPhieu, MaNL),
  CONSTRAINT CK_ChiTietPN_SoLuong CHECK (SoLuong > 0),
);
GO
CREATE TABLE ChiTietHD
(
  SoLuong INT NOT NULL,

  TriGia MONEY NOT NULL,
  MaKichCo CHAR(10) NOT NULL,
  MaHD CHAR(10) CONSTRAINT Fk_ChiTietHD_HoaDonBanHang_MaHD FOREIGN KEY (MaHD) REFERENCES HoaDonBanHang(MaHD),
  MaSP CHAR(10) CONSTRAINT FK_ChiTietHD_SanPham_MaSP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
  CONSTRAINT Pk_ChiTietHD_MaHD_MaSP PRIMARY KEY (MaHD, MaSP, MaKichCO),
  CONSTRAINT Ck_ChiTietHD_SoLuong CHECK (SoLuong > 0),
  CONSTRAINT Ck_ChiTietHD_TriGia CHECK (TriGia > 0),
  CONSTRAINT FK_ChiTietHD_KichCo_MaKichCo FOREIGN KEY (MaKichCo) REFERENCES KichCo(MaKichCo)
);
GO
CREATE TABLE CheBien
(
	LieuLuong DECIMAL(30,2),
	DonVi varchar(10),
	MaKichCo CHAR(10) CONSTRAINT Fk_CheBien_KichCo_MaKichCo FOREIGN KEY (MaKichCo) REFERENCES KichCo(MaKichCo),
	MaNL CHAR(10) CONSTRAINT Fk_CheBien_NguyenLieu_MaNL FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL),
	MaSP CHAR(10) CONSTRAINT Fk_CheBien_SanPham_MaSP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
	CONSTRAINT Pk_CheBien_MaNL_MaSP PRIMARY KEY (MaNL, MaSP, MaKichCo)
);
GO
CREATE TABLE ChiTietCaTruc
(
  MaNV CHAR(10) CONSTRAINT Fk_ChiTietCaTruc_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE CASCADE,
  MaCa CHAR(10) CONSTRAINT Fk_ChiTietCaTruc_Ca_MaCa FOREIGN KEY (MaCa) REFERENCES Ca(MaCa),
  Ngay Date NOT NULL,
  CONSTRAINT Pk_ChiTietCaTruc_MaNV_MaCa PRIMARY KEY (MaNV, MaCa)
);
GO
-----------------------------------------------------
-- Add the ON DELETE SET NULL to an existing foreign key constraint
-- Step 1: Drop the existing foreign key constraint
--ALTER TABLE ChiTietCaTruc
--DROP CONSTRAINT Fk_ChiTietCaTruc_NhanVien_MaNV;

-- Step 2: Add the foreign key constraint with ON DELETE SET DEFAULT
--ALTER TABLE ChiTietCaTruc
--ADD CONSTRAINT Fk_ChiTietCaTruc_NhanVien_MaNV 
--FOREIGN KEY (MaNV) 
--REFERENCES NhanVien(MaNV)
--ON DELETE CASCADE

-------------------------------------------------
CREATE TABLE ChiTietKichCo
(
  SoLuong int,
  DonGia MONEY,
  MaSP CHAR(10) CONSTRAINT Fk_ChiTietKichCo_SanPham_MaSP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
  MaKichCo CHAR(10) CONSTRAINT Fk_ChiTietKichCo_KichCo_MaKichCo FOREIGN KEY (MaKichCo) REFERENCES KichCo(MaKichCo),
  CONSTRAINT Pk_ChiTietKichCo_MaSP_MaKichCo PRIMARY KEY (MaSP, MaKichCo)
);
GO
-- Chèn dữ liệu vào bảng ChucVu
INSERT INTO ChucVu (MaChucVu, TenChucVu, Luong)
VALUES 
('CV001', N'Quản lý', 15000000),
('CV002', N'Phục vụ', 7000000),
('CV003', N'Bảo vệ', 6000000),
('CV004', N'Thu ngân', 9000000)
--SELECT * FROM ChucVu
--DELETE ChucVu
-- Chèn dữ liệu vào bảng NguyenLieu
INSERT INTO NguyenLieu (MaNL, TenNL, SoLuong, DonVi)
VALUES 
('NL001', N'Bột mỳ', 70, N'Kg'),
('NL002', N'Sốt cà chua', 20, N'Lon'),
('NL003', N'Phô mai', 10, N'Túi'),
('NL004', N'Men Nở', 10, N'Gam'),
('NL005', N'Thịt heo', 50, N'Kg'),
('NL006', N'Dầu Oliu', 50, N'Lít'),
('NL007', N'Hành Tây', 90, N'Kg'),
('NL008', N'Muối', 1, N'kg'),
('NL009', N'Tiêu', 30, N'kg'),
('NL0010', N'CoCa', 10, N'Lon'),
('NL0011', N'Suối', 10, N'Chai')
--SELECT * FROM NguyenLieu


-- Chèn dữ liệu vào bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SoDT)
VALUES 
('NCC001', N'Công ty TNHH Thực phẩm Nguyên Hà', N'456 Đường XYZ, Quận 2, TP. Hồ Chí Minh', '0987654321'),
('NCC002', N'Công ty TNHH Thực phẩm Việt Nam Food', N'567 Đường STU, Quận 8, TP. Hồ Chí Minh', '0896541237'),
('NCC003', N'Công ty TNHH Nước giải khát SUNTORY PEPSICO VN', N'890 Đường VWX, Quận 9, TP. Hồ Chí Minh', '0456987312')
--SELECT * FROM NhaCungCap
--DELETE FROM NhaCungCap
-- Chèn dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, SoDT)
VALUES 
('KH001', N'Nguyễn Văn Phát', '0123456789'),
('KH002', N'Trần Thị Dung', '0987654321'),
('KH003', N'Lê Văn Nam', '0369852147'),
('KH004', N'Phạm Thị Nghĩa', '0541236987'),
('KH005', N'Huỳnh Văn Kiệt', '0321456987')
--SELECT * FROM KhachHang
--
-- Chèn dữ liệu vào bảng Ca
INSERT INTO Ca (MaCa, GioBatDau, GioKetThuc)
VALUES 
('CA001', '07:00:00', '12:00:00'),
('CA002', '13:00:00', '18:00:00'),
('CA003', '18:00:00', '20:00:00'),
('CA004', '20:00:00', '00:00:00')

--DELETE Ca


-- Chèn dữ liệu vào bảng LoaiSanPham
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP)
VALUES 
('LSP001', N'Đồ ăn'),
('LSP002', N'Đồ uống')
--SELECT * FROM LoaiSanPham

-- Chèn dữ liệu vào bảng KichCo
INSERT INTO KichCo (MaKichCo, TenKichCo)
VALUES 
('KC001', N'Nhỏ'), --s
('KC002', N'Vừa'), --m
('KC003', N'Lớn')  --l
--SELECT * FROM KichCo


--delete ChiTietCungCap
-- Chèn dữ liệu vào bảng ChiTietCungCap
INSERT INTO ChiTietCungCap (MaNCC, MaNL)
VALUES 
('NCC001', 'NL001'),
('NCC001', 'NL002'),
('NCC001', 'NL003'),
('NCC001', 'NL004'),
('NCC002', 'NL005'),
('NCC001', 'NL006'),
('NCC001', 'NL007'),
('NCC001', 'NL008'),
('NCC001', 'NL009'),
('NCC003', 'NL0010'),
('NCC003', 'NL0011')
--SELECT * FROM ChiTietCungCap

-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNV, HoNV, TenNV, NgaySinh, GioiTinh, SoDT, DiaChi, Email, CCCD, MaChucVu)
VALUES 
('NV001', N'Nguyễn', N'Thuận', '1990-05-15', N'Nam', '0123456789', N'123 Đường ABC, Quận 1, TP. Hồ Chí Minh', 'nva@gmail.com', '123456789012', 'CV001'),
('NV002', N'Trần', N'Nam', '1995-08-20', N'Nam', '0987654321', N'456 Đường XYZ, Quận 2, TP. Hồ Chí Minh', 'ttb@gmail.com', '234567890123', 'CV002'),
('NV003', N'Lê', N'Phát', '1988-03-10', N'Nam', '0369852147', N'789 Đường DEF, Quận 3, TP. Hồ Chí Minh', 'lvc@gmail.com', '345678901234', 'CV002'),
('NV004', N'Phạm', N'Ngọc', '1992-11-25', N'Nam', '0541236987', N'321 Đường GHI, Quận 4, TP. Hồ Chí Minh', 'ptd@gmail.com', '456789012345', 'CV002'),
('NV005', N'Huỳnh', N'Trúc', '1997-07-03', N'Nam', '0321456987', N'654 Đường JKL, Quận 5, TP. Hồ Chí Minh', 'hve@gmail.com', '567890123456', 'CV002'),
('NV006', N'Đặng', N'Xuân', '1993-09-18', N'Nam', '0123456987', N'987 Đường MNO, Quận 6, TP. Hồ Chí Minh', 'dtf@gmail.com', '678901234567', 'CV003'),
('NV007', N'Võ', N'Ngân', '1991-02-28', N'Nam', '0365987412', N'234 Đường PQR, Quận 7, TP. Hồ Chí Minh', 'vvg@gmail.com', '789012345678', 'CV003'),
('NV008', N'Bùi', N'Xuân', '1996-06-13', N'Nữ', '0896541237', N'567 Đường STU, Quận 8, TP. Hồ Chí Minh', 'bth@gmail.com', '890123456789', 'CV004'),
('NV009', N'Lê', N'Mai', '1994-04-05', N'Nữ', '0456987312', N'890 Đường VWX, Quận 9, TP. Hồ Chí Minh', 'lvi@gmail.com', '901234567890', 'CV004')
--select * from NhanVien
-- Chèn dữ liệu vào bảng TaiKhoan
INSERT INTO TaiKhoan (UserName, Password, MaNV, Role)
VALUES 
('user1', 'pass1', 'NV001', 1),
('user2', 'pass2', 'NV002', 2),
('user3', 'pass3', 'NV003', 2),
('user4', 'pass4', 'NV004', 2),
('user5', 'pass5', 'NV005', 2),
('user8', 'pass8', 'NV008', 3),
('user9', 'pass9', 'NV009', 3)

--SELECT * FROM TaiKhoan
-- Chèn dữ liệu vào bảng SanPham
INSERT INTO SanPham (MaSP, TenSP, MaLoaiSP)--------------------------------HÌNH ẢNH ---------------------
VALUES 
('SP001', N'Neapolitan pizza', 'LSP001'),
('SP002', N'Pizza phô mai.', 'LSP001'),
('SP003', N'Pizza nhân thịt sốt cà chua', 'LSP001'),
('SP004', N'Nước Suối', 'LSP002'),
('SP005', N'CoCa', 'LSP002')
--SELECT * FROM SanPham
-- Chèn dữ liệu vào bảng HoaDonBanHang
INSERT INTO HoaDonBanHang (MaHD, NgayGioDat, MaNV, MaKH)
VALUES 
('HD001', '2015-01-18 08:30:00', 'NV008', 'KH001'),
('HD002', '2015-01-18 09:45:00', 'NV008', 'KH002'),
('HD003', '2017-01-18 10:20:00', 'NV008', 'KH003'),
('HD004', '2018-04-21 11:10:00', 'NV009', 'KH004'),
('HD005', '2018-04-21 12:40:00', 'NV009', 'KH005'),
('HD006', '2020-06-23 13:55:00', 'NV008', 'KH005')

--SELECT * FROM HoaDonBanHang
--DELETE HoaDonBanHang
-- Chèn dữ liệu vào bảng PhieuNhap
INSERT INTO PhieuNhap (MaPhieu, NgayNhap, TriGiaDonNH, MaNV, MaNCC)
VALUES 
('PN001', '2015-03-18', 10760000, 'NV001', 'NCC001'),
('PN002', '2016-03-19', 8000000, 'NV001', 'NCC002'),
('PN003', '2017-03-20', 3550000, 'NV001', 'NCC003')
--SELECT * FROM PhieuNhap
-- Chèn dữ liệu vào bảng ChiTietPN
INSERT INTO ChiTietPN (SoLuong, MaPhieu, MaNL, DonGia)
VALUES 
(70, 'PN001', 'NL001',30000 ),
(20, 'PN001', 'NL002', 60000),
(10, 'PN001', 'NL003', 50000),
(10, 'PN001', 'NL004', 5000),
(50, 'PN002', 'NL005', 160000),				---
(50, 'PN001', 'NL006', 15000),
(90, 'PN001', 'NL007', 35000),
(1, 'PN001', 'NL008', 10000),
(30, 'PN001', 'NL009', 100000),
(10, 'PN003', 'NL0010', 235000),
(10, 'PN003', 'NL0011', 120000)
--SELECT * FROM ChiTietPN
-- Chèn dữ liệu vào bảng ChiTietHD
INSERT INTO ChiTietHD(SoLuong,TriGia,MaHD,MaKichCo,MaSP)
VALUES 
(2, 200000, 'HD001', 'KC001', 'SP001'),
(3, 180000, 'HD001','KC002', 'SP002'),
(4, 400000, 'HD001', 'KC001','SP003'),
(3, 120000, 'HD002', 'KC003','SP002'),
(3, 180000, 'HD002', 'KC002','SP002'),
(4, 280000, 'HD003', 'KC002','SP003'),
(5, 500000, 'HD004', 'KC001','SP003'),
(6, 480000, 'HD004', 'KC001','SP002'),
(7, 350000, 'HD005', 'KC003','SP001'),
(8, 320000, 'HD005', 'KC003','SP002'),
(9, 540000, 'HD006', 'KC002','SP002'),
(10, 500000, 'HD006', 'KC003','SP001'),
(5, 100000, 'HD006', 'KC002','SP005')
--SELECT * FROM HoaDonBanHang
--SELECT * FROM ChiTietHD
-- Chèn dữ liệu vào bảng CheBien
-- Thêm dữ liệu cho bảng CheBien
INSERT INTO CheBien (LieuLuong, DonVi, MaKichCo, MaNL, MaSP)
VALUES 
(0.5, 'Kg', 'KC001', 'NL001', 'SP001'),  -- 0.5 Kg bột mỳ để chế biến pizza Neapolitan
(0.2, 'Lon', 'KC001', 'NL002', 'SP001'),  -- 0.2 lon sốt cà chua để chế biến pizza Neapolitan
(0.1, 'Túi', 'KC001', 'NL003', 'SP001'),  -- 0.1 túi phô mai để chế biến pizza Neapolitan
(0.01, 'Gam', 'KC001', 'NL004', 'SP001'),  -- 0.01 gam men nở để chế biến pizza Neapolitan

(0.2, 'Kg', 'KC001', 'NL001', 'SP002'),  -- 0.2 Kg bột mỳ để chế biến pizza phô mai
(0.1, 'Lon', 'KC001', 'NL003', 'SP002'),  -- 0.1 lon sốt cà chua để chế biến pizza phô mai
(0.1, 'Túi', 'KC001', 'NL004', 'SP002'),  -- 0.1 túi phô mai để chế biến pizza phô mai
(0.01, 'Kg', 'KC001', 'NL005', 'SP002'),  -- 0.01 kg thịt heo để chế biến pizza phô mai

(0.3, 'Kg', 'KC002', 'NL001', 'SP003'),  -- 0.3 Kg bột mỳ để chế biến pizza nhân thịt sốt cà chua
(0.1, 'Lon', 'KC002', 'NL002', 'SP003'),  -- 0.1 lon sốt cà chua để chế biến pizza nhân thịt sốt cà chua
(0.05, 'Túi', 'KC002', 'NL003', 'SP003'),  -- 0.05 túi phô mai để chế biến pizza nhân thịt sốt cà chua
(0.005, 'Kg', 'KC002', 'NL005', 'SP003'),  -- 0.005 kg thịt heo để chế biến pizza nhân thịt sốt cà chua
(1, 'Chai', 'KC001', 'NL0011', 'SP004'), ---- 1 chai nước suối để chế biến nước suối
(1, 'Lon', 'KC001', 'NL0010', 'SP005');  -- 0.1 lon coca để chế biến coca

-- Chèn dữ liệu vào bảng ChiTietCaTruc
INSERT INTO ChiTietCaTruc (MaNV, MaCa, Ngay)
VALUES 
('NV001', 'CA001', '2022-03-18'),
('NV002', 'CA002', '2021-03-19'),
('NV003', 'CA003', '2024-03-20'),
('NV004', 'CA004', '2024-03-21'),
('NV005', 'CA001', '2022-03-22'),
('NV006', 'CA002', '2024-03-23'),
('NV007', 'CA003', '2024-03-24'),
('NV008', 'CA004', '2024-03-25'),
('NV009', 'CA001', '2024-03-26')
--SELECT * FROM ChiTietCaTruc
-- Chèn dữ liệu vào bảng ChiTietKichCo

INSERT INTO ChiTietKichCo (SoLuong, DonGia, MaSP, MaKichCo)
VALUES 
(1, 100000, 'SP001', 'KC001'),
(2, 75000, 'SP001', 'KC002'),
(3, 50000, 'SP001', 'KC003'),
(4, 80000, 'SP002', 'KC001'),
(5, 60000, 'SP002', 'KC002'),
(6, 40000, 'SP002', 'KC003'),
(7, 100000, 'SP003', 'KC001'),
(8, 70000, 'SP003', 'KC002'),
(9, 50000, 'SP003', 'KC003'),
(10, 10000, 'SP004', 'KC002'),
(10, 20000, 'SP005', 'KC002');

--SELECT * FROM ChiTietKichCo

-------------------------------------------PROCEDURE----------------------------------------------------
GO
CREATE PROCEDURE sp_ThemKhachHang
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
		RAISERROR('KHÁCH HÀNG ĐÃ TỒN TẠI', 16, 1)
		--LỖI Ở MỨC ĐỘ 16, XEM LẠI NHÉ AE, KH BIẾT NÊN ĐỂ SỐ MẤY
	END CATCH
END
GO

EXEC sp_ThemKhachHang 
	@MaKH = 'KH012',
	@TenKH = N'Nguyễn Văn A',
	@SoDT = '1234567890';
GO
--select * from KhachHang

--Thêm thông tin nhân viên
Go
CREATE PROCEDURE sp_ThemNhanVien
	@MaNV char(10),
	@HoNV nvarchar(10),
	@TenLotNV nvarchar(20),
	@TenNV nvarchar(20),
	@NgaySinh date,
	@GioiTinh nvarchar(3),
	@SoDT char(10),
	@DiaChi nvarchar(50),
	@Email varchar(30),
	@CCCD char(12),
	@MaChucVu char(10)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO NhanVien(MaNV, HoNV, TenLotNV, TenNV, NgaySinh
		, SoDT, DiaChi, Email, CCCD, MaChucVu)
		VALUES (@MaNV, @HoNV, @TenLotNV, @TenNV, @NgaySinh, @SoDT, 
		@DiaChi, @Email, @CCCD, @MaChucVu)
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		RAISERROR('Không thể thêm nhân viên', 16, 1)
		--LỖI Ở MỨC ĐỘ 16, XEM LẠI NHÉ AE, KH BIẾT NÊN ĐỂ SỐ MẤY
	END CATCH
END

Go



-- Thêm thông tin sản phẩm
CREATE PROCEDURE sp_ThemSanPham
	@MaSP char(10),
	@TenSP nvarchar(30),
	@MaLoaiSP char(10)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO SanPham(MaSP, TenSP, MaLoaiSP)
		VALUES (@MaSP, @TenSP, @MaLoaiSP)
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		RAISERROR('Sản phẩm đã tồn tại', 18, 1)
		--LỖI Ở MỨC ĐỘ 18, XEM LẠI NHÉ AE, KH BIẾT NÊN ĐỂ SỐ MẤY
	END CATCH
END

GO



--Thêm thông tin loại sản phẩm
CREATE PROCEDURE sp_ThemLoaiSanPham
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


--Xóa thông tin khách hàng
CREATE PROCEDURE sp_XoaKhachHang
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
		RAISERROR('Không xóa được khách hàng', 18, 1)
	END CATCH
END
Go
select * from KhachHang
GO
EXEC sp_XoaKhachHang KH01212
GO



--Xóa thông tin nhân viên
CREATE PROCEDURE sp_XoaNhanVien
	@MaNV char(10)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DELETE FROM NhanVien WHERE MaNV = @MaNV
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		RAISERROR('Không xóa được nhân viên', 18, 1)
	END CATCH
END
GO



--Xóa thông tin sản phẩm
CREATE PROCEDURE sp_XoaSanPham
    @MaSP char(10)
AS
BEGIN
    BEGIN TRANSACTION
    BEGIN TRY
        DELETE FROM SanPham WHERE MaSP = @MaSP;
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH 
        ROLLBACK TRANSACTION
        RAISERROR('Không thể xóa sản phẩm', 16, 1)
    END CATCH
END
GO


--Xóa thông tin loại sản phẩm
GO
CREATE PROCEDURE sp_XoaLoaiSanPham
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

--Sửa thông tin khách hàng
CREATE PROCEDURE sp_CapNhatKhachHang
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
        RAISERROR('Cập nhật thông tin khách hàng không thành công', 18, 1)
    END CATCH
END

Go

--Sửa thông tin nhân viên
CREATE PROCEDURE sp_CapNhatNhanVien
    @MaNV char(10),
    @HoNV nvarchar(10),
    @TenLotNV nvarchar(20),
    @TenNV nvarchar(20),
    @NgaySinh date,
    @GioiTinh nvarchar(3),
    @SoDT char(10),
    @DiaChi nvarchar(50),
    @Email varchar(30),
    @CCCD char(12),
    @MaChucVu char(10)
AS
BEGIN
    BEGIN TRANSACTION
    BEGIN TRY
        UPDATE NhanVien
        SET HoNV = @HoNV,
            TenLotNV = @TenLotNV,
            TenNV = @TenNV,
            NgaySinh = @NgaySinh,
            GioiTinh = @GioiTinh,
            SoDT = @SoDT,
            DiaChi = @DiaChi,
            Email = @Email,
            CCCD = @CCCD,
            MaChucVu = @MaChucVu
        WHERE MaNV = @MaNV;
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH 
        ROLLBACK TRANSACTION
        RAISERROR('Cập nhật thông tin nhân viên không thành công', 18, 1)
    END CATCH
END

Go

--Sửa thông tin sản phẩm
CREATE PROCEDURE sp_CapNhatSanPham
    @MaSP char(10),
    @TenSP nvarchar(30),
    @MaLoaiSP char(10)
AS
BEGIN
    BEGIN TRANSACTION
    BEGIN TRY
        UPDATE SanPham
        SET TenSP = @TenSP,
            MaLoaiSP = @MaLoaiSP
        WHERE MaSP = @MaSP;
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH 
        ROLLBACK TRANSACTION
        RAISERROR('Cập nhật thông tin sản phẩm không thành công', 18, 1)
    END CATCH
END


GO
--Sửa thông tin loại sản phẩm
CREATE PROCEDURE sp_CapNhatLoaiSanPham
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


--------------------------------------TRIGGER---------------------
/*
CREATE TRIGGER TG_SanPhamDaHet
ON ChiTietHD
AFTER INSERT
AS
BEGIN
    DECLARE @MaSP CHAR(10), @SoLuongConLai INT;

    -- Lấy thông tin sản phẩm và số lượng bán ra từ bảng Inserted
    SELECT @MaSP = MaSP FROM Inserted;

    -- Lấy số lượng còn lại của sản phẩm từ bảng ChiTietKichCo
    SELECT @SoLuongConLai = SoLuong 
    FROM ChiTietKichCo 
    WHERE MaSP = @MaSP;

    -- Kiểm tra nếu số lượng sản phẩm sau khi bán là 0
    IF @SoLuongConLai = 0
    BEGIN
        -- Thực hiện hành động cụ thể ở đây, ví dụ: ghi lại sự kiện hoặc thông báo
        PRINT 'Sản phẩm đã bán hết.';
        -- Thêm mã logic hoặc ghi nhật ký tại đây.
    END
END;
INSERT INTO ChiTietHD (SoLuong, TriGia, MaHD, MaSP)
VALUES 
(2, 40000, 'HD004', 'SP010')
*/
