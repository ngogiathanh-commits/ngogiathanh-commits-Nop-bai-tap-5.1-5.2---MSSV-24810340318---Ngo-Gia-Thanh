USE ql_sinhvien;
go

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DangKyHocVien')
BEGIN
    CREATE TABLE DangKyHocVien (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        HoTen NVARCHAR(100) NOT NULL,
        SoDienThoai VARCHAR(20),
        NgaySinh DATE,
        GioiTinh NVARCHAR(10),
        KhoaHoc NVARCHAR(100),
        NgayDangKy DATETIME DEFAULT GETDATE()
    );
END
GO