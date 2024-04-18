USE QuanLyPizza

--------------------FUNCTION-------------------
--FUNCT check login
select * from NhanVien
--các optitnon:Ma NV, tên NV, mã CV,
go
-----------------------------------------------------------------------------------------------
--Tìm kiếm nhân viên
CREATE FUNCTION fn_searchEmployee(@option nvarchar(50), @key nvarchar(50))
RETURNS  @Result TABLE (
        MaNV CHAR(10),
        HoNV NVARCHAR(10),
        TenNV NVARCHAR(20),
        NgaySinh DATE,
        GioiTinh NVARCHAR(3),
        SoDT CHAR(10),
        DiaChi NVARCHAR(50),
        Email VARCHAR(30),
        CCCD CHAR(12),
        MaChucVu CHAR(10)
    )
	AS 
BEGIN

    IF @option = 'employee ID'
    BEGIN
        INSERT INTO @Result
        SELECT * FROM [dbo].[vw_XemThongTinNhanVien] WHERE MaNV = @key
    END
    ELSE IF @option = 'employee name'
    BEGIN
        INSERT INTO @Result
        SELECT * FROM [dbo].[vw_XemThongTinNhanVien] WHERE TenNV = @key
    END
    ELSE IF @option = 'job ID'
    BEGIN
        INSERT INTO @Result
        SELECT * FROM [dbo].[vw_XemThongTinNhanVien] WHERE MaChucVu = @key
    END

    RETURN
END
go

drop function fn_searchEmployee
select * from [dbo].[NhanVien]
select * from [dbo].[vw_XemThongTinNhanVien]
select * from  dbo.fn_searchEmployee('job ID', 'CV002')
go

-----------------------------------------------------------------------------------------------
--tìm kiếm nhân viên trong form quản lí ca trực
CREATE FUNCTION fn_SearchEployeeIDOrShiftID (@empID nvarchar(50), @shiftID char(20))
RETURNS @Result TABLE (
		MaNV CHAR(10),
        HoNV NVARCHAR(10),
        TenNV NVARCHAR(20),
		Ngay Date ,
		MaCa CHAR(10),
		GioBatDau TIME ,
		GioKetThuc TIME
)
AS
BEGIN	
	INSERT INTO @Result 
		SELECT nv.MaNV, nv.HoNV, nv.TenNV, ct.Ngay, c.*  FROM ChiTietCaTruc ct JOIN Ca c
				ON ct.MaCa = c.MaCa
				JOIN NhanVien nv
				ON nv.MaNV = ct.MaNV
				WHERE nv.MaNV = @empID AND c.MaCa = @shiftID
	RETURN
END
GO
select * from Ca
EXEC [dbo].[fn_SearchEployeeIDOrShiftID]('NV001', 'CV001')
select * from  [dbo].[fn_SearchEployeeIDOrShiftID]('NV001', '')
GO
-----------------------------------------------------------------------------------------------
--func tìm kiếm theo size
CREATE OR ALTER FUNCTION fn_SearchSize (@SizeName nvarchar(50))
RETURNS @Result TABLE (
		MaSP CHAR(10),
		TenSP NVARCHAR(30) NOT NULL,
		MaLoaiSP CHAR(10) NOT NUll ,
		Size nvarchar(50)
		)
AS
BEGIN	
	INSERT INTO @Result 
		SELECT sp.MaSP,sp.TenSP,sp.MaLoaiSP,kc.TenKichCo FROM SanPham sp JOIN  ChiTietKichCo ct
				ON ct.MaSP = sp.MaSP
				join KichCo kc
				On kc.MaKichCo = ct.MaKichCo
				WHERE kc.TenKichCo  LIKE '%' + @SizeName + '%' 
	RETURN
END
GO
 SELECT * FROM dbo.fn_SearchSize(N'Lớ')
 SELECT * FROM ChiTietKichCo
 SELECT * FROM SanPham
 SELECT * FROM KichCo

 GO

 -----------------------------------------------------------------------------------------------
 --FUNCT tìm kiếm theo tên sản phẩm
 CREATE OR ALTER FUNCTION fn_SearchProductName (@Name nvarchar(50))
RETURNS @Result TABLE (
    MaSP CHAR(10),
    TenSP NVARCHAR(30) NOT NULL,
    MaLoaiSP CHAR(10) NOT NULL,
    HinhAnh NVARCHAR(MAX),
    Size nvarchar(50),
	DONGIA MONEY
)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT sp.*, kc.TenKichCo,ct.DonGia FROM SanPham sp 
    JOIN ChiTietKichCo ct ON ct.MaSP = sp.MaSP
    JOIN KichCo kc ON kc.MaKichCo = ct.MaKichCo
    WHERE sp.TenSP LIKE '%' + @Name + '%' 
    RETURN
END
GO
SELECT * FROM dbo.fn_SearchProductName(N'co')
GO
-----------------------------------------------------------------------------------------------
--func tìm kiếm theo loại sản phẩm
 CREATE OR ALTER FUNCTION fn_SearchProductType (@TypeName nvarchar(50))
RETURNS @Result TABLE (
    MaSP CHAR(10),
    TenSP NVARCHAR(30) NOT NULL,
    MaLoaiSP CHAR(10) NOT NULL,
    HinhAnh NVARCHAR(MAX),
	TenLoaiSP NVARCHAR(30) NOT NULL,
    Size nvarchar(50),
	DONGIA MONEY
)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT sp.*,lsp.TenLoaiSP , kc.TenKichCo,ct.DonGia FROM SanPham sp 
    JOIN ChiTietKichCo ct ON ct.MaSP = sp.MaSP
    JOIN KichCo kc ON kc.MaKichCo = ct.MaKichCo
	JOIN LoaiSanPham lsp ON sp.MaLoaiSP = lsp.MaLoaiSP
    WHERE lsp.TenLoaiSP LIKE '%' + @TypeName + '%' 
    RETURN
END
GO
select * from LoaiSanPham
SELECT * FROM dbo.fn_SearchProductType(N'ăn')
-----------------------------------------------------------------------------------------------
--FUNC tìm kiếm theo giá sản phẩm
GO
CREATE OR ALTER FUNCTION fn_SearchProductPrice (@Min MONEY ,@Max MONEY)
RETURNS @Result TABLE (
	MaSP CHAR(10),
    TenSP NVARCHAR(30) NOT NULL,
    MaLoaiSP CHAR(10) NOT NULL,
    HinhAnh NVARCHAR(MAX),
    Size nvarchar(50),
	DONGIA MONEY
)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT sp.*, kc.TenKichCo,ct.DonGia FROM SanPham sp 
    JOIN ChiTietKichCo ct ON ct.MaSP = sp.MaSP
    JOIN KichCo kc ON kc.MaKichCo = ct.MaKichCo
    WHERE ct.DonGia BETWEEN @MIN AND @MAX
    RETURN
END
GO

SELECT * FROM dbo.fn_SearchProductPrice(35000,100000000)

-----------------------------------------------------------------------------------------------
-----FUNC tìm kiếm theo tên và giá sản phẩm
GO
CREATE OR ALTER FUNCTION fn_SearchProductPriceAndName (@Min MONEY ,@Max MONEY,@Name nvarchar(50))
RETURNS @Result TABLE (
   MaSP CHAR(10),
    TenSP NVARCHAR(30) NOT NULL,
    MaLoaiSP CHAR(10) NOT NULL,
    HinhAnh NVARCHAR(MAX),
    Size nvarchar(50),
	DONGIA MONEY
)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT sp.*, kc.TenKichCo,ct.DonGia FROM SanPham sp 
    JOIN ChiTietKichCo ct ON ct.MaSP = sp.MaSP
    JOIN KichCo kc ON kc.MaKichCo = ct.MaKichCo
    WHERE ct.DonGia BETWEEN @MIN AND @MAX AND sp.TenSP LIKE '%' + @Name + '%' 
    RETURN
END
GO
SELECT * FROM dbo.fn_SearchProductPriceAndName(35000,100000000,N'Nh')
-----------------------------------------------------------------------------------------------
--FUNC tìm kiếm theo tên khách hàng
GO
CREATE OR ALTER FUNCTION fn_SearchCustomerName (@Name nvarchar(50))
RETURNS @Result TABLE (
	MaKH CHAR(10),
	TenKH NVARCHAR(30) NOT NULL,
	SoDT CHAR(10) not null
)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT *FROM KhachHang
    WHERE KhachHang.TenKH like '%' + @NAME +'%'
    RETURN
END
GO
select * from dbo.fn_SearchCustomerName(N'Na')

-----------------------------------------------------------------------------------------------
--FUNC tìm kiếm theo tên nhà cung cấp
GO
CREATE OR ALTER FUNCTION fn_SearchNameProvider (@Name nvarchar(50))
RETURNS @Result TABLE (
	MaNCC CHAR(10),
	TenNCC NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	SoDT varCHAR(10) NOT NULL ,
	TenNL NVARCHAR(30) NOT NULL,
	SoLuong INT,
	DonGia MONEY,
	TongTien MONEY
)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT ncc.*,nl.TenNL,ct.SoLuong,ct.DonGia,Ct.SoLuong* ct.DonGia as tongtien FROM NhaCungCap ncc join PhieuNhap pn
	ON ncc.MaNCC =pn.MaNCC join ChiTietPN ct
	ON ct.MaPhieu = pn.MaPhieu Join NguyenLieu nl
	ON ct.MaNL =nl.MaNL
	WHERE ncc.TenNCC like '%' +@Name +'%'
	RETURN 
END
GO
SELECT * FROM dbo.fn_SearchNameProvider(N'Thực phẩm')
-----------------------------------------------------------------------------------------------
--tìm kiếm giá theo nhà cung cấp
GO
CREATE OR ALTER FUNCTION fn_SearchPriceProvider (@Min MONEY,@Max MONEY)
RETURNS @Result TABLE (
	MaNCC CHAR(10),
	TenNCC NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	SoDT varCHAR(10) NOT NULL ,
	TenNL NVARCHAR(30) NOT NULL,
	SoLuong INT,
	DonGia MONEY,
	TongTien MONEY

)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT ncc.*,nl.TenNL,ct.SoLuong,ct.DonGia,Ct.SoLuong* ct.DonGia as tongtien FROM NhaCungCap ncc join PhieuNhap pn
	ON ncc.MaNCC =pn.MaNCC join ChiTietPN ct
	ON ct.MaPhieu = pn.MaPhieu Join NguyenLieu nl
	ON ct.MaNL =nl.MaNL
	WHERE  Ct.SoLuong* ct.DonGia BETWEEN @MIN AND @MAX
	RETURN 
END
GO
SELECT * FROM dbo.fn_SearchPriceProvider(15000,100000000000)
-----------------------------------------------------------------------------------------------
--FUNCT tìm kiếm theo giá và tên nhà cung cấp
GO
CREATE OR ALTER FUNCTION fn_SearchPriceAndNameProvider (@Min MONEY,@Max MONEY,@Name nvarchar(50))
RETURNS @Result TABLE (
	  MaNCC CHAR(10),
	  TenNCC NVARCHAR(50) NOT NULL,
	  DiaChi NVARCHAR(50) NOT NULL,
	  SoDT varCHAR(10) NOT NULL ,
	  TenNL NVARCHAR(30) NOT NULL,
	  SoLuong INT,
	  DonGia MONEY,
	  TongTien MONEY

)
AS
BEGIN   
    INSERT INTO @Result 
    SELECT ncc.*,nl.TenNL,ct.SoLuong,ct.DonGia,Ct.SoLuong* ct.DonGia as tongtien FROM NhaCungCap ncc join PhieuNhap pn
	ON ncc.MaNCC =pn.MaNCC join ChiTietPN ct
	ON ct.MaPhieu = pn.MaPhieu Join NguyenLieu nl
	ON ct.MaNL =nl.MaNL
	WHERE  Ct.SoLuong* ct.DonGia BETWEEN @MIN AND @MAX and ncc.TenNCC like '%' +@Name +'%'
	RETURN 
END
GO
-----------------------------------------------------------------------------------------------
 --funct tìm kiếm hóa đơn theo ngày
CREATE OR ALTER FUNCTION fn_SearchOrderOfDate (@Min varchar(20), @Max varchar(20))
RETURNS @Result TABLE (
    MaHD CHAR(10),
    NgayGioDat DATETIME NOT NULL,
    MaNV CHAR(10),
    MaKH CHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    TriGia MONEY NOT NULL,
    MaKichCo CHAR(10) NOT NULL,
    TenSP NVARCHAR(30)
)
AS
BEGIN   
    DECLARE @MinDate DATETIME
    DECLARE @MaxDate DATETIME

    -- Chuyển đổi ngày/tháng/năm từ chuỗi sang kiểu DATETIME
    SET @MinDate = CONVERT(DATETIME, @Min, 103)
    SET @MaxDate = CONVERT(DATETIME, @Max, 103)

    INSERT INTO @Result 
    SELECT hd.MaHD, hd.NgayGioDat, hd.MaNV, hd.MaKH, ct.SoLuong, ct.TriGia, ct.MaKichCo, sp.TenSP
    FROM HoaDonBanHang hd 
    JOIN ChiTietHD ct ON hd.MaHD = ct.MaHD 
	JOIN SanPham sp ON sp.MaSP = ct.MaSP
    WHERE hd.NgayGioDat BETWEEN @MinDate AND @MaxDate

    RETURN;
END
GO
select * from HoaDonBanHang
SELECT * FROM dbo.fn_SearchOrderOfDate('01/01/2015', '01/01/2017')

