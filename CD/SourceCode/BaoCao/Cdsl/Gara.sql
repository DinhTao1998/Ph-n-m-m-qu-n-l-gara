USE MASTER
CREATE DATABASE Gara
USE Gara

CREATE TABLE XE
(
	MaXe 		CHAR(5) PRIMARY KEY,
	BienSo		VARCHAR(10),
	MaHieuXe	CHAR(3) FOREIGN KEY REFERENCES HieuXe(MaHieuXe),
	TenChuXe	NVARCHAR(50),
	DiaChi		NVARCHAR(100),
	DienThoai	VARCHAR(11),
	Email		VARCHAR(50),
	NgayTiepNhan smalldatetime,
	TienNo		int
)

CREATE TABLE HIEUXE
(
	MaHieuXe 	CHAR(3) PRIMARY KEY,
	TenHieuXe	nvarchar(10),
	QuocGia		nvarchar(50)
)

CREATE TABLE VTPT
(
	MaVTPT 	CHAR(5) PRIMARY KEY,
	TenVTPT	nvarchar(20),
	DonGia	int,
	SoLuongTon int
)

CREATE TABLE TIENCONG
(
	MaTienCong 	CHAR(5) PRIMARY KEY,
	TenTienCong	nvarchar(50),
	SoTienCong	int
)

CREATE TABLE PHIEUSUACHUA
(
	MaPhieuSC 	CHAR(5) PRIMARY KEY,
	MaXe		Char(5) FOREIGN KEY REFERENCES XE(MaXe),
	NgaySuaChua smalldatetime,
	TongPhiSuaChua int,
	SoTienThu	int,
	ConLai		int
)

CREATE TABLE CT_PHIEUSUACHUA
(
	MaCT		char(5)	PRIMARY KEY,
	MaPhieuSC	char(5) FOREIGN KEY REFERENCES PHIEUSUACHUA(MaPhieuSC),
	NoiDung		nvarchar(50),
	MaTienCong	char(5) FOREIGN KEY REFERENCES TIENCONG(MaTienCong),
	SoLan		int,
	TongTienCong	int,
	ChiPhiVTPT		int,
	TongChiPhi		int
)

CREATE TABLE CT_SuDungVTPT
(
	MaCT	char(5) FOREIGN KEY REFERENCES CT_PHIEUSUACHUA(MaCT),
	MaVTPT	char(5) FOREIGN KEY REFERENCES VTPT(MaVTPT),
	SoLuong int,
	DonGia	int,
	ThanhTien	int,
	CONSTRAINT PK_CT_SuDungVTPT PRIMARY KEY (MaCT, MaVTPT)
)

CREATE TABLE PHIEUTHU
(
	MaPhieuThu	char(5)	PRIMARY KEY,
	MaXe		char(5) FOREIGN KEY REFERENCES XE(MaXe),
	NgayThuTien smalldatetime,
	SoTienThu	int
)

CREATE TABLE PHIEUNHAP
(
	MaPhieuNhap		char(5) primary key,
	NgayNhap		smalldatetime,
	TongTienNhap	int
)

CREATE TABLE CT_PHIEUNHAP
(
	MaPhieuNhap	char(5) FOREIGN KEY REFERENCES PHIEUNHAP(MaPhieuNhap),
	MaVTPT		char(5)	FOREIGN KEY REFERENCES VTPT(MaVTPT),
	DonGia		int,
	SoLuong		int,
	ThanhTien	int
	CONSTRAINT PK_CT_PHIEUNHAP PRIMARY KEY (MaPhieuNhap, MaVTPT)
)

CREATE TABLE BC_DOANHSO
(
	MaBCDS		char(20) PRIMARY KEY,
	Thang		int,
	Nam			int,
	TongDoanhThu	int,
)

CREATE TABLE CT_BC_DOANHSO
(
	MaCTBC		char(20) PRIMARY KEY,
	MaBCDS		char(20) FOREIGN KEY REFERENCES BC_DOANHSO(MaBCDS),
	Thang		int,
	Nam			int,
	MaHieuXe	char(3) FOREIGN KEY REFERENCES HIEUXE(MaHieuXe),
	SoLuotSua	int,
	ThanhTien	int,
	TiLe		float,
)

CREATE TABLE BC_TONVTPT
(
	MaBCT		char(20) PRIMARY KEY,
	Thang		int,
	Nam			int,
)

CREATE TABLE CT_BC_VTPT
(
	MaCTBC		char(20) PRIMARY KEY,
	MaBCT		char(20) FOREIGN KEY REFERENCES BC_TONVTPT(MaBCT),
	MaVTPT		char(5)	FOREIGN KEY REFERENCES VTPT(MaVTPT),
	TonDau		int,
	PhatSinh	int,
	TonCuoi		int
)

Set dateformat dmy

-- Them bcds
CREATE PROCEDURE THEMBCDS 
	@MABC CHAR(20),
	@THANG INT,
	@NAM INT
AS
BEGIN
	SET NOCOUNT ON;
	IF(EXISTS(SELECT MaBCDS FROM BC_DOANHSO WHERE MaBCDS = @MABC))
	BEGIN
		SELECT ERROR = 1
	END
	ELSE 
	BEGIN
		INSERT INTO BC_DOANHSO (MaBCDS, Thang, Nam, TongDoanhThu) VALUES (@MABC, @THANG, @NAM, 0)
		SELECT ERROR = 0
	END
END

-- Th�m chi tiet bcds
CREATE PROCEDURE THEMCT_BCDS 
	@MACTBC CHAR(20),
	@MABCDS CHAR(20),
	@MAHIEUXE CHAR(3)
AS
BEGIN
	SET NOCOUNT ON;
	IF(EXISTS(SELECT MaBCDS FROM BC_DOANHSO WHERE MaBCDS = @MABCDS))
	BEGIN
		INSERT INTO CT_BC_DOANHSO(MaCTBC, MaBCDS, MaHieuXe, SoLuotSua, ThanhTien, TiLe) VALUES (@MACTBC, @MABCDS, @MAHIEUXE, 0, 0, 0)
		SELECT ERROR = 0
	END
	ELSE
	BEGIN
		SELECT ERROR = 1
	END
END

-- Cap nhat so luot sua cua ct bcds
CREATE PROCEDURE CAPNHATCT_BCDS 
	@MABCDS CHAR(20),
	@MACTBC CHAR(20)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @SOLUOTSUA INT
	SET @SOLUOTSUA = (SELECT SoLuotSua FROM CT_BC_DOANHSO WHERE MaBCDS = @MABCDS AND MaCTBC = @MACTBC) + 1
	UPDATE CT_BC_DOANHSO SET SoLuotSua = @SOLUOTSUA WHERE MaBCDS = @MABCDS AND MaCTBC = @MACTBC
END

-- Cap nhat doanh thu bc thang, cap nhat thanh tien va ti le cua hieu xe
CREATE PROCEDURE CAPNHATDOANHTHU
	@MABCDS CHAR(20),
	@MACTBC CHAR(20),
	@SOTIEN INT
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @DOANHSO INT
	DECLARE @THANHTIEN INT
	DECLARE @TILE FLOAT

	SET @DOANHSO = (SELECT TongDoanhThu FROM BC_DOANHSO WHERE MaBCDS = @MABCDS) + @SOTIEN
	SET @THANHTIEN = (SELECT ThanhTien FROM CT_BC_DOANHSO WHERE MaCTBC = @MACTBC AND MaBCDS = @MABCDS) + @SOTIEN
	SET @TILE = @THANHTIEN / @DOANHSO 

	UPDATE BC_DOANHSO SET TongDoanhThu = @DOANHSO WHERE MaBCDS = @MABCDS
	UPDATE CT_BC_DOANHSO SET ThanhTien = @THANHTIEN, TiLe = @TILE WHERE MaCTBC = @MACTBC AND MaBCDS = @MABCDS
END

-- Cap nhat lai ti le cua hieu xe trong chi tiet bcds
CREATE PROCEDURE CAPNHATTILE 
	@MACTBC CHAR(20),
	@MABC CHAR(20)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @THANHTIEN INT
	DECLARE @TONGDOANHTHU INT
	DECLARE @TILE FLOAT

	SET @THANHTIEN = (SELECT ThanhTien FROM CT_BC_DOANHSO WHERE MaCTBC = @MACTBC AND MaBCDS = @MABC)
	SET @TONGDOANHTHU = (SELECT TongDoanhThu FROM BC_DOANHSO WHERE MaBCDS = @MABC)
	SET @TILE =  @THANHTIEN / @TONGDOANHTHU

	UPDATE CT_BC_DOANHSO SET TiLe = @TILE WHERE MaCTBC = @MACTBC AND MaBCDS = @MABC
END


-- Lay bcds theo thang
CREATE PROCEDURE GETBAOCAODOANHSO 
	@THANG INT,
	@NAM INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MaBCDS FROM BC_DOANHSO WHERE Thang = @THANG AND Nam = @NAM
END


-- Lay ma ct bcds
CREATE PROCEDURE GETCT_BAOCAODOANHSO
	@MABC CHAR(20),
	@MAHIEUXE CHAR(3)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MaCTBC FROM CT_BC_DOANHSO WHERE MaBCDS = @MABC AND MaHieuXe = @MAHIEUXE
END


-- Lay danh sach cac ma hieu xe
CREATE PROCEDURE GETLISTMAHIEUXE
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MaHieuXe FROM HIEUXE
END


-- Lay ma bc ton VTPT
CREATE PROCEDURE GETMABAOCAOTON
	@THANG INT,
	@NAM INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MaBCT FROM BC_TONVTPT WHERE Thang = @THANG AND Nam = @NAM
END


-- Them bc ton VTPT
CREATE PROCEDURE THEMBAOCAOTON
	@MABCT CHAR(20),
	@THANG INT,
	@NAM INT
AS
BEGIN
	SET NOCOUNT ON;
	IF(EXISTS(SELECT MaBCT FROM BC_TONVTPT WHERE MaBCT = @MABCT))
	BEGIN
		SELECT ERROR = 1
	END
	ELSE
	BEGIN
		INSERT INTO BC_TONVTPT VALUES(@MABCT,@THANG,@NAM)
		SELECT ERROR = 0
	END 
END


-- Lay ma ct bc ton VTPT
CREATE PROCEDURE GETMACTBCT
	@MABCT CHAR(20),
	@MAPT CHAR(5)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MaCTBC FROM CT_BC_VTPT WHERE MaBCT = @MABCT AND MaVTPT = @MAPT
END


-- Them ct bc ton VTPT
CREATE PROCEDURE THEMCT_BCT
	@MACTBCT CHAR(20),
	@MABC CHAR(20),
	@MAPT CHAR(5),
	@TONDAU INT,
	@PHATSINH INT,
	@TONCUOI INT
AS
BEGIN
	SET NOCOUNT ON;
	IF(EXISTS(SELECT MaCTBC FROM CT_BC_VTPT WHERE MaCTBC = @MACTBCT))
	BEGIN
		SELECT ERROR = 1
	END
	ELSE
	BEGIN
		INSERT INTO CT_BC_VTPT VALUES(@MACTBCT,@MABC,@MAPT,@TONDAU,@PHATSINH,@TONCUOI)
		SELECT ERROR = 0
	END 
END


-- Cap nhat phat sinh
CREATE PROCEDURE CAPNHATPHATSINH
	@MACTBCT CHAR(20),
	@SL INT
AS
BEGIN
	SET NOCOUNT ON;
	IF(EXISTS(SELECT MaCTBC FROM CT_BC_VTPT WHERE MaCTBC = @MACTBCT))
	BEGIN
		declare @PHATSINH int, @TONCUOI INT
		set @PHATSINH = (select PhatSinh from CT_BC_VTPT where MaCTBC = @MACTBCT)
		set @PHATSINH = @PHATSINH + @SL
		SET @TONCUOI = (SELECT TonCuoi FROM CT_BC_VTPT WHERE MaCTBC = @MACTBCT)
		SET @TONCUOI = @TONCUOI + @SL
		UPDATE CT_BC_VTPT SET PhatSinh = @PHATSINH, TonCuoi = @TONCUOI WHERE  MaCTBC = @MACTBCT
		SELECT ERROR = 0
	END
	ELSE
	BEGIN
		SELECT ERROR = 1
	END	
END


-- Cap nhat ton cuoi
CREATE PROCEDURE CAPNHATTONCUOI
	@MACTBC CHAR(20),
	@SL INT
AS
BEGIN
	SET NOCOUNT ON;
	IF(EXISTS(SELECT MaCTBC FROM CT_BC_VTPT WHERE MaCTBC = @MACTBC))
	BEGIN
		DECLARE @TONCUOI INT
		SET @TONCUOI = (SELECT TonCuoi FROM CT_BC_VTPT WHERE MaCTBC = @MACTBC)
		SET @TONCUOI = @TONCUOI - @SL
		UPDATE CT_BC_VTPT SET TonCuoi = @TONCUOI WHERE  MaCTBC = @MACTBC
		SELECT ERROR = 0
	END
	ELSE
	BEGIN
		SELECT ERROR = 1
	END
END


-- Lay danh sach VTPT
CREATE PROCEDURE GETLISTPHUTUNG
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *FROM VTPT 
END


-- Lay so luong VTPT
CREATE PROCEDURE GETSLPHUTUNG
	@MAVTPT NVARCHAR(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT SoLuongTon FROM VTPT WHERE MaVTPT = @MAVTPT 
END


-- Lay ma hieu xe cua 1 xe
CREATE PROCEDURE GETMAHIEUXE
	@MAXE CHAR(5)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MaHieuXe FROM XE WHERE MaXe = @MAXE
END


-- Them phieu sua chua
CREATE PROCEDURE THEMPSC
	@MAPSC CHAR(5),
	@MAXE CHAR(5),
	@NGAYSC SMALLDATETIME
AS
BEGIN
	SET NOCOUNT ON;
	IF(EXISTS(SELECT MaPhieuSC FROM PHIEUSUACHUA WHERE MaPhieuSC = @MAPSC))
	BEGIN
		SELECT ERROR = 1
	END
	ELSE 
	BEGIN
		INSERT INTO PHIEUSUACHUA(MaPhieuSC, MaXe, NgaySuaChua, TongPhiSuaChua, SoTienThu, ConLai) VALUES (@MAPSC, @MAXE, @NGAYSC, 0, 0, 0)
		SELECT ERROR = 0
	END
END

CREATE PROCEDURE GETCTBCTFORREPORT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT bct.Thang, bct.Nam, bct.MaBCT, ct.MaCTBC, TenVTPT, TonDau, PhatSinh, TonCuoi
	FROM CT_BC_VTPT ct, BC_TONVTPT bct, VTPT pt
	WHERE ct.MaBCT = bct.MaBCT AND ct.MaVTPT = pt.MaVTPT
END

CREATE PROCEDURE LOAD_DGV_BCVTPT
	@THANG	INT,
	@NAM	INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TenVTPT, TonDau, PhatSinh, TonCuoi
	FROM CT_BC_VTPT ct, BC_TONVTPT bct, VTPT pt
	WHERE ct.MaBCT = bct.MaBCT AND ct.MaVTPT = pt.MaVTPT AND Thang = @THANG AND Nam = @NAM
END

CREATE PROCEDURE LOAD_DGV_BCDS
	@THANG	INT,
	@NAM	INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TenHieuXe, SoLuotSua, ThanhTien, TiLe
	FROM BC_DOANHSO bc, CT_BC_DOANHSO ct, HIEUXE h
	WHERE ct.MaBCDS = bc.MaBCDS AND ct.MaHieuXe = h.MaHieuXe AND bc.Thang = @THANG AND bc.Nam = @NAM
END

CREATE PROCEDURE LOAD_TDT_BCDS
	@THANG	INT,
	@NAM	INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TongDoanhThu
	FROM BC_DOANHSO
	WHERE Thang = @THANG AND Nam = @NAM
END

insert into BC_DOANHSO values ('001',6,2018,100000)
insert into HIEUXE values ('tyt','toyota','jp')
insert into CT_BC_DOANHSO values ('CT001','001',6,2018,'tyt',2,50000,0.5)
insert into VTPT values ('PO','po xe',100000,3)
insert into BC_TONVTPT values ('001',6,2018)
insert into CT_BC_VTPT values ('CT001','001','PO',1,2,3)






