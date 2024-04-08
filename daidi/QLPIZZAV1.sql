--DROP DATABASE QuanLyPizza
--CREATE DATABASE QuanLyPizza
--USE QuanLyPizza
--USE northwind
CREATE TABLE ChucVu
(
  MaChucVu CHAR(10),
  TenChucVu NVARCHAR(30) NOT NULL,
  Luong MONEY NOT NULL,
  CONSTRAINT Ck_ChucVu_Luong CHECK (Luong > 0),
  CONSTRAINT Pk_ChucVu_MaChucVu PRIMARY KEY (MaChucVu) 
);
--drop table NguyenLieu
CREATE TABLE NguyenLieu
(
  MaNL CHAR(10),
  TenNL NVARCHAR(30) NOT NULL,
  SoLuong INT,
  DonVi NVARCHAR(20),
  DonGia MONEY,
  CONSTRAINT Pk_NguyenLieu_MaNL PRIMARY KEY (MaNL),
  CONSTRAINT Ck_NguyenLieu_SoLuong CHECK (SoLuong > 0)
);

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

CREATE TABLE KhachHang
(
  MaKH CHAR(10),
  TenKH NVARCHAR(30) NOT NULL,
  SoDT CHAR(10) not null,
  CONSTRAINT Pk_KhachHang_MaKH PRIMARY KEY (MaKH),
  CONSTRAINT Ck_KhachHang_SoDT CHECK (LEN(SoDT) = 10 AND SoDT NOT LIKE '%[^0-9]%')
);

CREATE TABLE Ca
(
  MaCa CHAR(10),
  GioBatDau TIME NOT NULL,
  GioKetThuc TIME NOT NULL,
  CONSTRAINT Pk_Ca_MaCa PRIMARY KEY (MaCa)
);

CREATE TABLE LoaiSanPham
(
  MaLoaiSP CHAR(10),
  TenLoaiSP NVARCHAR(30) NOT NULL ,
  CONSTRAINT Pk_LoaiSanPham_MaLoaiSP PRIMARY KEY (MaLoaiSP)
);

CREATE TABLE KichCo
(
  MaKichCo CHAR(10),
  TenKichCo NVARCHAR(30) NOT NULL,
  CONSTRAINT Pk_KichCo_MaKichCo PRIMARY KEY (MaKichCo)
);

CREATE TABLE ChiTietCungCap
(
  MaNCC CHAR(10) NOT NULL,
  MaNL CHAR(10) NOT NULL,
  CONSTRAINT Pk_ChiTietCungCap_MaNCC_MaNL PRIMARY KEY (MaNCC, MaNL),
  CONSTRAINT Fk_ChiTietCungCap_NhaCungCap_MaNCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
  CONSTRAINT Fk_ChiTietCungCap_NguyenLieu_MaNL FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL)
);


CREATE TABLE NhanVien
(
  MaNV CHAR(10) ,
  HoNV NVARCHAR(10) NOT NULL,
  TenLotNV NVARCHAR(20) NOT NULL,
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

CREATE TABLE TaiKhoan
(
  UserName VARCHAR(20) NOT NULL,
  Password VARCHAR(20) NOT NULL,---**************FIXXXXX***********************
  MaNV CHAR(10) NOT NULL,   -- nên để MaNV và Role là null bởi vì lúc đăng kí mình chỉ quan tâm 
  Role int NOT NULL,		-- admin chứ còn nhân viên hồi mình tự thêm đươi data, Hoặc để số tự tăng
  CONSTRAINT Pk_TaiKhoan_UserName PRIMARY KEY(UserName),
  CONSTRAINT Fk_TaiKhoan_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE SanPham
(
  MaSP CHAR(10),
  TenSP NVARCHAR(30) NOT NULL,
  MaLoaiSP CHAR(10) NOT NULL,
  CONSTRAINT Pk_SanPham_MaSP PRIMARY KEY (MaSP),
  CONSTRAINT FK_SanPham_LoaiSanPham_MaLoaiSP FOREIGN KEY (MaLoaiSP) REFERENCES LoaiSanPham(MaLoaiSP)
);

CREATE TABLE HoaDonBanHang
(
  MaHD CHAR(10),
  NgayGioDat DATETIME NOT NULL,
  MaNV CHAR(10) NOT NULL,
  MaKH CHAR(10) NOT NULL,
  CONSTRAINT Pk_HoaDonBanHang_MaHD PRIMARY KEY (MaHD),
  CONSTRAINT Fk_HoaDonBanHang_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
  CONSTRAINT FK_HoaDonBanHang_KhachHang_MaKH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE PhieuNhap
(
  MaPhieu CHAR(10),
  NgayNhap DATE NOT NULL,
  TriGiaDonNH MONEY NOT NULL,
  MaNV CHAR(10) NOT NULL,
  MaNCC CHAR(10) NOT NULL,
  CONSTRAINT Pk_PhieuNhap_MaPhieu PRIMARY KEY (MaPhieu),
  CONSTRAINT Fk_PhieuNhap_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
  CONSTRAINT Fk_PhieuNhap_NhaCungCap_MaNCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
  CONSTRAINT Ck_PhieuNhap_TriGiaDonNH CHECK (TriGiaDonNH > 0)
);
CREATE TABLE ChiTietPN
(
  SoLuong INT,
  MaPhieu CHAR(10) CONSTRAINT Fk_ChiTietPN_PhieuNhap_MaPhieu FOREIGN KEY (MaPhieu) REFERENCES PhieuNhap(MaPhieu),
  MaNL CHAR(10) CONSTRAINT Fk_ChiTietPN_NguyenLieu_MaNL FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL),
  CONSTRAINT Pk_ChiTietPN_MaPhieu_MaNL PRIMARY KEY (MaPhieu, MaNL),
  CONSTRAINT CK_ChiTietPN_SoLuong CHECK (SoLuong > 0),
);

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
CREATE TABLE CheBien
(
	LieuLuong int,
	DonVi varchar(10),
	MaNL CHAR(10) CONSTRAINT Fk_CheBien_NguyenLieu_MaNL FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL),
	MaSP CHAR(10) CONSTRAINT Fk_CheBien_SanPham_MaSP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
	CONSTRAINT Pk_CheBien_MaNL_MaSP PRIMARY KEY (MaNL, MaSP)
);

CREATE TABLE ChiTietCaTruc
(
  MaNV CHAR(10) CONSTRAINT Fk_ChiTietCaTruc_NhanVien_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
  MaCa CHAR(10) CONSTRAINT Fk_ChiTietCaTruc_Ca_MaCa FOREIGN KEY (MaCa) REFERENCES Ca(MaCa),
  Ngay Date NOT NULL,
  CONSTRAINT Pk_ChiTietCaTruc_MaNV_MaCa PRIMARY KEY (MaNV, MaCa)
);

CREATE TABLE ChiTietKichCo
(
  SoLuong int,
  DonGia MONEY,
  MaSP CHAR(10) CONSTRAINT Fk_ChiTietKichCo_SanPham_MaSP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
  MaKichCo CHAR(10) CONSTRAINT Fk_ChiTietKichCo_KichCo_MaKichCo FOREIGN KEY (MaKichCo) REFERENCES KichCo(MaKichCo),
  CONSTRAINT Pk_ChiTietKichCo_MaSP_MaKichCo PRIMARY KEY (MaSP, MaKichCo)
);

-- Chèn dữ liệu vào bảng ChucVu
INSERT INTO ChucVu (MaChucVu, TenChucVu, Luong)
VALUES 
('CV001', N'Quản lý', 15000000),
('CV002', N'Phục vụ', 7000000),
('CV003', N'Bảo vệ', 6000000),
('CV004', N'Thu ngân', 9000000)
SELECT * FROM ChucVu
DELETE ChucVu
-- Chèn dữ liệu vào bảng NguyenLieu
INSERT INTO NguyenLieu (MaNL, TenNL, SoLuong, DonVi, DonGia)
VALUES 
('NL001', N'Bột mỳ', 70, N'Kg', 30000),
('NL002', N'Sốt cà chua', 20, N'Lon', 60000),
('NL003', N'Phô mai', 10, N'Túi', 50000),
('NL004', N'Men Nở', 10, N'Gam', 5000),
('NL005', N'Thịt heo', 50, N'Kg', 160000),
('NL006', N'Dầu Oliu', 50, N'Lít', 15000),
('NL007', N'Hành Tây', 90, N'Kg', 35000),
('NL008', N'Muối', 1, N'kg', 10000),
('NL009', N'Tiêu', 30, N'kg', 100000),
('NL0010', N'CoCa', 10, N'Thùng', 235000),
('NL0011', N'Suối', 10, N'Thùng', 120000)
SELECT * FROM NguyenLieu


-- Chèn dữ liệu vào bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SoDT)
VALUES 
('NCC001', N'Công ty TNHH Thực phẩm Nguyên Hà', N'456 Đường XYZ, Quận 2, TP. Hồ Chí Minh', '0987654321'),
('NCC002', N'Công ty TNHH Thực phẩm Việt Nam Food', N'567 Đường STU, Quận 8, TP. Hồ Chí Minh', '0896541237'),
('NCC003', N'Công ty TNHH Nước giải khát SUNTORY PEPSICO VN', N'890 Đường VWX, Quận 9, TP. Hồ Chí Minh', '0456987312')
SELECT * FROM NhaCungCap
DELETE FROM NhaCungCap
-- Chèn dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, SoDT)
VALUES 
('KH001', N'Nguyễn Văn Phát', '0123456789'),
('KH002', N'Trần Thị Dung', '0987654321'),
('KH003', N'Lê Văn Nam', '0369852147'),
('KH004', N'Phạm Thị Nghĩa', '0541236987'),
('KH005', N'Huỳnh Văn Kiệt', '0321456987')
SELECT * FROM KhachHang

-- Chèn dữ liệu vào bảng Ca
INSERT INTO Ca (MaCa, GioBatDau, GioKetThuc)
VALUES 
('CA001', '07:00:00', '12:00:00'),
('CA002', '13:00:00', '18:00:00'),
('CA003', '18:00:00', '20:00:00'),
('CA004', '20:00:00', '00:00:00')

DELETE Ca


-- Chèn dữ liệu vào bảng LoaiSanPham
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP)
VALUES 
('LSP001', N'Đồ ăn'),
('LSP002', N'Đồ uống')
SELECT * FROM LoaiSanPham

-- Chèn dữ liệu vào bảng KichCo
INSERT INTO KichCo (MaKichCo, TenKichCo)
VALUES 
('KC001', N'Nhỏ'),
('KC002', N'Vừa'),
('KC003', N'Lớn')
SELECT * FROM KichCo


delete ChiTietCungCap
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
SELECT * FROM ChiTietCungCap

-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNV, HoNV, TenLotNV, TenNV, NgaySinh, GioiTinh, SoDT, DiaChi, Email, CCCD, MaChucVu)
VALUES 
('NV001', N'Nguyễn', N'Văn', N'Thuận', '1990-05-15', N'Nam', '0123456789', N'123 Đường ABC, Quận 1, TP. Hồ Chí Minh', 'nva@gmail.com', '123456789012', 'CV001'),
('NV002', N'Trần', N'Văn', N'Nam', '1995-08-20', N'Nam', '0987654321', N'456 Đường XYZ, Quận 2, TP. Hồ Chí Minh', 'ttb@gmail.com', '234567890123', 'CV002'),
('NV003', N'Lê', N'Văn', N'Phát', '1988-03-10', N'Nam', '0369852147', N'789 Đường DEF, Quận 3, TP. Hồ Chí Minh', 'lvc@gmail.com', '345678901234', 'CV002'),
('NV004', N'Phạm', N'Văn', N'Ngọc', '1992-11-25', N'Nam', '0541236987', N'321 Đường GHI, Quận 4, TP. Hồ Chí Minh', 'ptd@gmail.com', '456789012345', 'CV002'),
('NV005', N'Huỳnh', N'Văn', N'Trúc', '1997-07-03', N'Nam', '0321456987', N'654 Đường JKL, Quận 5, TP. Hồ Chí Minh', 'hve@gmail.com', '567890123456', 'CV002'),
('NV006', N'Đặng', N'Văn', N'Xuân', '1993-09-18', N'Nam', '0123456987', N'987 Đường MNO, Quận 6, TP. Hồ Chí Minh', 'dtf@gmail.com', '678901234567', 'CV003'),
('NV007', N'Võ', N'Văn', N'Ngân', '1991-02-28', N'Nam', '0365987412', N'234 Đường PQR, Quận 7, TP. Hồ Chí Minh', 'vvg@gmail.com', '789012345678', 'CV003'),
('NV008', N'Bùi', N'Thị', N'Xuân', '1996-06-13', N'Nữ', '0896541237', N'567 Đường STU, Quận 8, TP. Hồ Chí Minh', 'bth@gmail.com', '890123456789', 'CV004'),
('NV009', N'Lê', N'Thị', N'Mai', '1994-04-05', N'Nữ', '0456987312', N'890 Đường VWX, Quận 9, TP. Hồ Chí Minh', 'lvi@gmail.com', '901234567890', 'CV004')
select * from NhanVien
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

SELECT * FROM TaiKhoan
-- Chèn dữ liệu vào bảng SanPham
INSERT INTO SanPham (MaSP, TenSP, MaLoaiSP)
VALUES 
('SP001', N'Neapolitan pizza', 'LSP001'),
('SP002', N'Pizza phô mai.', 'LSP001'),
('SP003', N'Pizza nhân thịt sốt cà chua', 'LSP001'),
('SP004', N'Nước Suối', 'LSP002'),
('SP005', N'CoCa', 'LSP002')
SELECT * FROM SanPham
-- Chèn dữ liệu vào bảng HoaDonBanHang
INSERT INTO HoaDonBanHang (MaHD, NgayGioDat, MaNV, MaKH)
VALUES 
('HD001', '2015-01-18 08:30:00', 'NV008', 'KH001'),
('HD002', '2015-01-18 09:45:00', 'NV008', 'KH002'),
('HD003', '2017-01-18 10:20:00', 'NV008', 'KH003'),
('HD004', '2018-04-21 11:10:00', 'NV009', 'KH004'),
('HD005', '2018-04-21 12:40:00', 'NV009', 'KH005'),
('HD006', '2020-06-23 13:55:00', 'NV008', 'KH005')

SELECT * FROM HoaDonBanHang
DELETE HoaDonBanHang
-- Chèn dữ liệu vào bảng PhieuNhap
INSERT INTO PhieuNhap (MaPhieu, NgayNhap, TriGiaDonNH, MaNV, MaNCC)
VALUES 
('PN001', '2015-03-18', 10760000, 'NV001', 'NCC001'),
('PN002', '2016-03-19', 8000000, 'NV001', 'NCC002'),
('PN003', '2017-03-20', 3550000, 'NV001', 'NCC003')
SELECT * FROM PhieuNhap

-- Chèn dữ liệu vào bảng ChiTietPN
INSERT INTO ChiTietPN (SoLuong, MaPhieu, MaNL)
VALUES 
(70, 'PN001', 'NL001'),
(20, 'PN001', 'NL002'),
(10, 'PN001', 'NL003'),
(10, 'PN001', 'NL004'),
(50, 'PN002', 'NL005'),
(50, 'PN001', 'NL006'),
(90, 'PN001', 'NL007'),
(1, 'PN001', 'NL008'),
(30, 'PN001', 'NL009'),
(10, 'PN003', 'NL0010'),
(10, 'PN003', 'NL0011')
SELECT * FROM ChiTietPN
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
SELECT * FROM ChiTietHD
-- Chèn dữ liệu vào bảng CheBien
INSERT INTO CheBien (LieuLuong, DonVi, MaNL, MaSP)
VALUES 
(100, N'Kg', 'NL001', 'SP001'),
(200, N'Kg', 'NL002', 'SP002'),
(300, N'Kg', 'NL003', 'SP003'),
(400, N'Kg', 'NL004', 'SP004'),
(500, N'Kg', 'NL005', 'SP005'),
(600, N'Quả', 'NL006', 'SP006'),
(700, N'Kg', 'NL007', 'SP007'),
(800, N'Kg', 'NL008', 'SP008'),
(900, N'Lít', 'NL009', 'SP009'),
(1000, N'Kg', 'NL010', 'SP010');

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
SELECT * FROM ChiTietCaTruc
-- Chèn dữ liệu vào bảng ChiTietKichCo

INSERT INTO ChiTietKichCo (SoLuong, DonGia, MaSP, MaKichCo)--Chi tiet ma co so luong ????,sua lai soluong nua la xong
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

SELECT * FROM ChiTietKichCo
