--------------------FUNCTION-------------------
select * from NhanVien
--các optitnon:Ma NV, tên NV, mã CV,
go
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

drop function fn_searchEmployee
select * from [dbo].[NhanVien]
select * from [dbo].[vw_XemThongTinNhanVien]select * from  dbo.fn_searchEmployee('job ID', 'CV002')go-------------tìm kiếm nhân viên trong form quản lí ca trựcCREATE FUNCTION fn_SearchEployeeIDOrShiftID (@empID nvarchar(50), @shiftID char(20))RETURNS @Result TABLE (		MaNV CHAR(10),
        HoNV NVARCHAR(10),
        TenNV NVARCHAR(20),
		Ngay Date ,
		MaCa CHAR(10),
		GioBatDau TIME ,
		GioKetThuc TIME)ASBEGIN		INSERT INTO @Result 		SELECT nv.MaNV, nv.HoNV, nv.TenNV, ct.Ngay, c.*  FROM ChiTietCaTruc ct JOIN Ca c				ON ct.MaCa = c.MaCa				JOIN NhanVien nv				ON nv.MaNV = ct.MaNV				WHERE nv.MaNV = @empID AND c.MaCa = @shiftID	RETURNENDselect * from CaEXEC [dbo].[fn_SearchEployeeIDOrShiftID]('NV001', 'CV001')select * from  [dbo].[fn_SearchEployeeIDOrShiftID]('NV001', '')