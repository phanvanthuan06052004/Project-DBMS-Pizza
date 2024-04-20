create database tessttttt

use tessttttt

drop table KhachHang
CREATE TABLE KhachHang
(
  MaKH CHAR(10),
  TenKH NVARCHAR(30) NOT NULL,
  SoDT CHAR(10) not null,
  CONSTRAINT Pk_KhachHang_MaKH PRIMARY KEY (MaKH),
  --CONSTRAINT Ck_KhachHang_SoDT CHECK (LEN(SoDT) = 10 AND SoDT NOT LIKE '%[^0-9]%')
);

CREATE TRIGGER tg_autoKHID ON KhachHang
AFTER INSERT AS
BEGIN
	DECLARE @maxId int, @new varchar(10)
	SELECT @maxId = ISNULL(MAX(RIGHT(MaKhachHang,4)),0) +1
	FROM KhachHang
	SELECT @new = 'KH' + RIGHT('0000' + CAST(@maxId as varchar(4)), 4)
	from KhachHang
	UPDATE KhachHang SET MaKH = @new

go
ALTER TABLE KhachHang ADD CONSTRAINT CK_TaoMaTuTangKH DEFAULT dbo.ftGet_next_customer_id() FOR MaKH;


select * from KhachHang
INSERT INTO KhachHang (TenKH, SoDT)
VALUES 
(N'Nguyễn Văn Phát', '0123456799')
(N'Trần Thị Dung', '0987654321')
(N'Lê Văn Nam', '0369852147'),
(N'Phạm Thị Nghĩa', '0541236987'),
(N'Huỳnh Văn Kiệt', '0321456987')