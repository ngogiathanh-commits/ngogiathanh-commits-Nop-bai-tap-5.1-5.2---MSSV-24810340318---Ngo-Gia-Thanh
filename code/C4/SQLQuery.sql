USE ql_sinhvien;
go

CREATE TABLE SinhVien (
    MaSV VARCHAR(20) PRIMARY KEY,
    HoTen VARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh VARCHAR(10),
    Lop VARCHAR(50),
    DiemTB DECIMAL(4,2)
);

INSERT INTO SinhVien VALUES 
('SV001', 'Nguyễn Văn An', '2003-05-15', 'Nam', 'CNTT K18', 8.50),
('SV002', 'Trần Thị Bình', '2003-08-20', 'Nữ', 'CNTT K18', 9.20),
('SV003', 'Lê Hoàng Cường', '2002-11-10', 'Nam', 'Kế Toán K18', 7.40);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TaiKhoan')
BEGIN
    CREATE TABLE TaiKhoan (
        TenDangNhap NVARCHAR(50) PRIMARY KEY,
        MatKhau NVARCHAR(50) NOT NULL
    );
END
GO

INSERT INTO TaiKhoan (TenDangNhap, MatKhau)
VALUES (N'admin', N'123456');

SELECT * FROM SinhVien;
SELECT * FROM TaiKhoan;