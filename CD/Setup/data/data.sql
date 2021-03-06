USE [master]
GO
/****** Object:  Database [Gara]    Script Date: 6/25/2018 1:00:01 PM ******/
CREATE DATABASE [Gara]
 CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'Gara', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Gara.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'Gara_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Gara_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gara] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gara].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gara] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gara] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gara] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gara] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gara] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gara] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gara] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Gara] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gara] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gara] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gara] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gara] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gara] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gara] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gara] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gara] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gara] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gara] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gara] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gara] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gara] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gara] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gara] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gara] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gara] SET  MULTI_USER 
GO
ALTER DATABASE [Gara] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gara] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gara] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gara] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Gara]
GO
/****** Object:  StoredProcedure [dbo].[LietKeTienCong]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LietKeTienCong]
as
begin
     select * from TIENCONG
end



GO
/****** Object:  StoredProcedure [dbo].[PhieuThu_Insert]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PhieuThu_Insert](
	@MaXe int,
	@NgayThuTien smalldatetime,
	@SoTienThu int
)
as
begin
	insert into PhieuThu(MaXe, NgayThuTien, SoTienThu)
	values (@MaXe, @NgayThuTien, @SoTienThu)
	update Xe
	set TienNo = TienNo - @SoTienThu
	where MaXe = @MaXe
end


GO
/****** Object:  StoredProcedure [dbo].[PhieuThu_Update]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PhieuThu_Update](
	@MaXe int,
	@NgayThuTien smalldatetime,
	@SoTienThu int,
	@MaPhieuThu int
)
as
begin
	update PHIEUTHU 
	set MaXe=@MaXe, NgayThuTien =@NgayThuTien, SoTienThu= @SoTienThu
	where MaPhieuThu = @MaPhieuThu
end


GO
/****** Object:  StoredProcedure [dbo].[SuaTienCong]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SuaTienCong]
@MaTienCong int,
@TenTienCong nvarchar(20),
@TienCong int
as
begin
update TIENCONG
set TenTienCong = @TenTienCong, TienCong = @TienCong
where @MaTienCong = MaTienCong
end



GO
/****** Object:  StoredProcedure [dbo].[ThemCT_PhieuNhap]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemCT_PhieuNhap]
@NgayNhap smalldatetime,
@TongTienNhap int,
@MaVTPT int,
@DonGia int,
@SoLuong int,
@ThanhTien int
as
begin
     declare @MaPhieuNhap int;
	 select @MaPhieuNhap = MaPhieuNhap
	 from PHIEUNHAP
	 where NgayNhap = @NgayNhap and TongTienNhap = TongTienNhap
	 insert into CT_PHIEUNHAP values(@MaPhieuNhap,@MaVTPT,@DonGia,@SoLuong,@ThanhTien)
	 update VTPT
	 set SoLuongTon = SoLuongTon +@SoLuong
	 where MaVTPT =@MaVTPT
end


GO
/****** Object:  StoredProcedure [dbo].[ThemCT_PhieuSC]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create procedure [dbo].[ThemCT_PhieuSC]
@MaXe int,
@NgaySuaChua Smalldatetime,
@TongPhiSuaChua int,
@SoTienThu int,
@ConLai int,
@NoiDung nvarchar(50),
@MaTienCong int,
@Dongia int,
@SoLan int,
@TongTienCong int,
@ChiPhiVTPT int,
@TongChiPhi int
as
begin
     begin
	      declare @MaPhieuSC int
		  select @MaPhieuSC = MaPhieuSC
		  from PHIEUSUACHUA
		  where @MaXe =MaXe and @NgaySuaChua = NgaySuaChua and @TongPhiSuaChua =TongPhiSuaChua and
		        @SoTienThu = SoTienThu  and @ConLai = ConLai
		  insert into CT_PHIEUSUACHUA(MaPhieuSC,NoiDung,MaTienCong,DonGia,SoLan,TongTienCong,ChiPhiVTPT,TongChiPhi)
		  values(@MaPhieuSC,@NoiDung,@MaTienCong,@Dongia,@SoLan,@TongTienCong,@ChiPhiVTPT,@TongChiPhi)
	 end
end



GO
/****** Object:  StoredProcedure [dbo].[ThemCT_SuDungVTPT]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemCT_SuDungVTPT]
@MaXe int,
@NgaySuaChua smalldatetime,
@TongPhiSuaChua int,
@NoiDung nvarchar(50),
@MaTienCong int,
@TongTienCong int,
@ChiPhiVTPT int,
@TongChiPhi int,
@MaVTPT int,
@DonGia int,
@SoLuong int,
@ThanhTien int
as
begin
     declare @MaCT int;
	 select @MaCT = MaCT 
	 from PHIEUSUACHUA PSC , CT_PHIEUSUACHUA CT
	 where PSC.MaPhieuSC = CT.MaPhieuSC and MaXe = @MaXe and NgaySuaChua =@NgaySuaChua and NoiDung =@NoiDung
	       and TongPhiSuaChua =@TongPhiSuaChua and MaTienCong = @MaTienCong and TongTienCong = @TongTienCong
		   and ChiPhiVTPT = @ChiPhiVTPT and TongChiPhi = @TongChiPhi
	insert into CT_SUDUNGVTPT(MaCT,MaVTPT,DonGia,SoLuong,ThanhTien) values(@MaCT,@MaVTPT,@DonGia,@SoLuong,@ThanhTien)
	update VTPT set SoLuongTon = SoLuongTon - @SoLuong
	            where MaVTPT = @MaVTPT
end


GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemPhieuNhap]
@NgayNhap smalldatetime,
@TongTienNhap int
as
begin
     insert into PHIEUNHAP(NgayNhap,TongTienNhap) values(@NgayNhap,@TongTienNhap)
end



GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuSuaChua]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ThemPhieuSuaChua]
@MaXe int,
@NgaySuaChua smalldatetime,
@TongPhiSuaChua int,
@SoTienThu int,
@ConLai int
as
begin
     begin
          insert into PHIEUSUACHUA(MaXe,NgaySuaChua,TongPhiSuaChua,SoTienThu,ConLai) 
		  values (@MaXe,@NgaySuaChua,@TongPhiSuaChua,@SoTienThu,@ConLai)
		  update Xe set TienNo =TienNo + @ConLai
		            where MaXe =@MaXe
	 end 
end



GO
/****** Object:  StoredProcedure [dbo].[ThemTienCong]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThemTienCong]
@TenTienCong nvarchar(20),
@TienCong int
as
begin
insert into TIENCONG(TenTienCong,TienCong) values(@TenTienCong,@TienCong)
end



GO
/****** Object:  StoredProcedure [dbo].[Xe_Insert]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Xe_Insert](
	@BienSo varchar(10),
	@MaHieuXe int,
	@TenChuXe nvarchar(50),
	@DiaChi nvarchar(100),
	@DienThoai varchar(11),
	@Email nvarchar(50),
	@NgayTiepNhan smalldatetime,
	@TienNo int,
	@MaXe int
)
as
begin
	insert into XE (MaXe,BienSo,MaHieuXe,TenChuXe,DiaChi,DienThoai,Email,NgayTiepNhan, TienNo)
	values (@MaXe,@BienSo, @MaHieuXe, @TenChuXe,@DiaChi,@DienThoai,@Email,@NgayTiepNhan, @TienNo)
end


GO
/****** Object:  StoredProcedure [dbo].[Xe_SelectAll]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Xe_SelectAll]
as
begin
	select * from XE
end


GO
/****** Object:  StoredProcedure [dbo].[Xe_Update]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Xe_Update](
	@BienSo varchar(10),
	@MaHieuXe int,
	@TenChuXe nvarchar(50),
	@DiaChi nvarchar(100),
	@DienThoai varchar(11),
	@Email nvarchar(50),
	@NgayTiepNhan smalldatetime,
	@TienNo int,
	@MaXe int
)
as
begin
	update XE 
	set BienSo = @BienSo,MaHieuXe = @MaHieuXe, TenChuXe = @TenChuXe,DiaChi=@DiaChi,DienThoai=@DienThoai,Email=@Email,NgayTiepNhan=@NgayTiepNhan, TienNo=@TienNo 
	where MaXe = @MaXe
end


GO
/****** Object:  UserDefinedFunction [dbo].[A]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[A](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END



GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END



GO
/****** Object:  UserDefinedFunction [dbo].[GetUnsignString]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END


GO
/****** Object:  Table [dbo].[BAOCAOTON]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTON](
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[MaVTPT] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
 CONSTRAINT [PK_BAOCAOTON] PRIMARY KEY CLUSTERED 
(
	[Thang] ASC,
	[Nam] ASC,
	[MaVTPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
	[MaManHinhChinh] [int] NOT NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[MaPhieuNhap] [int] NOT NULL,
	[MaVTPT] [int] NOT NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaVTPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUSUACHUA]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUSUACHUA](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuSC] [int] NOT NULL,
	[NoiDung] [nvarchar](50) NULL,
	[MaTienCong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLan] [int] NOT NULL,
	[TongTienCong] [int] NOT NULL,
	[ChiPhiVTPT] [int] NULL,
	[TongChiPhi] [int] NOT NULL,
 CONSTRAINT [PK_CT_PHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_SUDUNGVTPT]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_SUDUNGVTPT](
	[MaCT_SD] [int] IDENTITY(1,1) NOT NULL,
	[MaCT] [int] NOT NULL,
	[MaVTPT] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_CT_SUDUNGVTPT] PRIMARY KEY CLUSTERED 
(
	[MaCT_SD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HIEUXE]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIEUXE](
	[MaHieuXe] [int] IDENTITY(1,1) NOT NULL,
	[TenHieuXe] [nvarchar](20) NOT NULL,
	[QuocGia] [nvarchar](20) NULL,
 CONSTRAINT [PK_HIEUXE] PRIMARY KEY CLUSTERED 
(
	[MaHieuXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[TenHienThi] [nvarchar](50) NULL,
	[MaChucVu] [int] NOT NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [smalldatetime] NOT NULL,
	[TongTienNhap] [money] NOT NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUSUACHUA]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUSUACHUA](
	[MaPhieuSC] [int] IDENTITY(1,1) NOT NULL,
	[MaXe] [int] NOT NULL,
	[NgaySuaChua] [smalldatetime] NULL,
	[TongPhiSuaChua] [int] NOT NULL,
	[SoTienThu] [int] NULL,
	[ConLai] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTHU]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHU](
	[MaPhieuThu] [int] IDENTITY(1,1) NOT NULL,
	[MaXe] [int] NOT NULL,
	[NgayThuTien] [smalldatetime] NOT NULL,
	[SoTienThu] [money] NULL,
 CONSTRAINT [PK_PHIEUTHU] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[MaThamSo] [int] IDENTITY(1,1) NOT NULL,
	[TenThamSo] [nvarchar](20) NOT NULL,
	[GiaTri] [nchar](10) NOT NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIENCONG]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIENCONG](
	[MaTienCong] [int] IDENTITY(1,1) NOT NULL,
	[TenTienCong] [nvarchar](50) NULL,
	[TienCong] [int] NULL,
 CONSTRAINT [PK_TIEN] PRIMARY KEY CLUSTERED 
(
	[MaTienCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VTPT]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VTPT](
	[MaVTPT] [int] IDENTITY(1,1) NOT NULL,
	[TenVTPT] [nvarchar](20) NULL,
	[DonGia] [int] NOT NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_VT] PRIMARY KEY CLUSTERED 
(
	[MaVTPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XE]    Script Date: 6/25/2018 1:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XE](
	[MaXe] [int] IDENTITY(1,1) NOT NULL,
	[BienSo] [char](9) NOT NULL,
	[MaHieuXe] [int] NOT NULL,
	[TenChuXe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](11) NULL,
	[Email] [varchar](100) NULL,
	[NgayTiepNhan] [smalldatetime] NOT NULL,
	[TienNo] [int] NULL,
 CONSTRAINT [PK_X] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CHUCVU] ON 

INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [MaManHinhChinh]) VALUES (1, N'Giám đốc', 1)
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [MaManHinhChinh]) VALUES (2, N'Nhân viên sửa chữa', 2)
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [MaManHinhChinh]) VALUES (3, N'Nhân viên tiếp tân', 3)
SET IDENTITY_INSERT [dbo].[CHUCVU] OFF
SET IDENTITY_INSERT [dbo].[CT_PHIEUSUACHUA] ON 

INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (1, 1, N'1', 4, 120000, 2, 240000, 0, 240000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (2, 2, N'4', 10, 123000, 1, 123000, 700000, 823000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (3, 3, N'1', 11, 11000, 3, 33000, 400000, 433000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (4, 4, N'2', 13, 254000, 1, 254000, 770000, 1024000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (5, 5, N'2', 16, 52000, 3, 156000, 0, 156000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (6, 6, N'2', 4, 120000, 1, 120000, 0, 120000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (7, 7, N'4', 6, 234000, 3, 702000, 220000, 922000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (8, 8, N'3', 9, 34000, 1, 34000, 2100000, 2134000)
INSERT [dbo].[CT_PHIEUSUACHUA] ([MaCT], [MaPhieuSC], [NoiDung], [MaTienCong], [DonGia], [SoLan], [TongTienCong], [ChiPhiVTPT], [TongChiPhi]) VALUES (9, 9, N'4', 4, 120000, 1, 120000, 1100000, 1220000)
SET IDENTITY_INSERT [dbo].[CT_PHIEUSUACHUA] OFF
SET IDENTITY_INSERT [dbo].[CT_SUDUNGVTPT] ON 

INSERT [dbo].[CT_SUDUNGVTPT] ([MaCT_SD], [MaCT], [MaVTPT], [DonGia], [SoLuong], [ThanhTien]) VALUES (1, 2, 51, 350000, 2, 700000)
INSERT [dbo].[CT_SUDUNGVTPT] ([MaCT_SD], [MaCT], [MaVTPT], [DonGia], [SoLuong], [ThanhTien]) VALUES (2, 3, 77, 100000, 4, 400000)
INSERT [dbo].[CT_SUDUNGVTPT] ([MaCT_SD], [MaCT], [MaVTPT], [DonGia], [SoLuong], [ThanhTien]) VALUES (3, 4, 97, 770000, 1, 770000)
INSERT [dbo].[CT_SUDUNGVTPT] ([MaCT_SD], [MaCT], [MaVTPT], [DonGia], [SoLuong], [ThanhTien]) VALUES (4, 7, 28, 220000, 1, 220000)
INSERT [dbo].[CT_SUDUNGVTPT] ([MaCT_SD], [MaCT], [MaVTPT], [DonGia], [SoLuong], [ThanhTien]) VALUES (5, 8, 53, 700000, 3, 2100000)
INSERT [dbo].[CT_SUDUNGVTPT] ([MaCT_SD], [MaCT], [MaVTPT], [DonGia], [SoLuong], [ThanhTien]) VALUES (6, 9, 35, 1100000, 1, 1100000)
SET IDENTITY_INSERT [dbo].[CT_SUDUNGVTPT] OFF
SET IDENTITY_INSERT [dbo].[HIEUXE] ON 

INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (1, N'Toyota', N'Nhật Bản')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (2, N'Honda', N'Nhật Bản')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (3, N'Yamaha', NULL)
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (4, N'Phú Toàn', N'Việt Nam')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (5, N'Suzuki', N'Nhật Bản')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (6, N'BMW', N'Mỹ')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (7, N'Mecerdes-Benz', N'Mỹ')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (8, N'FORD', N'Pháp')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (9, N'Audi', N'Đức')
INSERT [dbo].[HIEUXE] ([MaHieuXe], [TenHieuXe], [QuocGia]) VALUES (10, N'NISSAN', N'Nhật Bản')
SET IDENTITY_INSERT [dbo].[HIEUXE] OFF
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [TenHienThi], [MaChucVu]) VALUES (N'uit', N'1', N'UIT', 1)
SET IDENTITY_INSERT [dbo].[PHIEUSUACHUA] ON 

INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (1, 1, CAST(0xA90A0000 AS SmallDateTime), 240000, 240000, 0)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (2, 1, CAST(0xA90A0000 AS SmallDateTime), 823000, 823000, 0)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (3, 1, CAST(0xA90A0000 AS SmallDateTime), 433000, 433000, 0)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (4, 2, CAST(0xA90A0000 AS SmallDateTime), 1024000, 1024000, 0)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (5, 2, CAST(0xA90A0000 AS SmallDateTime), 156000, 156000, 0)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (6, 2, CAST(0xA90A0000 AS SmallDateTime), 120000, 0, 120000)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (7, 2, CAST(0xA90A0000 AS SmallDateTime), 922000, 922000, 0)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (8, 2, CAST(0xA90A0000 AS SmallDateTime), 2134000, 2134000, 0)
INSERT [dbo].[PHIEUSUACHUA] ([MaPhieuSC], [MaXe], [NgaySuaChua], [TongPhiSuaChua], [SoTienThu], [ConLai]) VALUES (9, 2, CAST(0xA90A0000 AS SmallDateTime), 1220000, 1220000, 0)
SET IDENTITY_INSERT [dbo].[PHIEUSUACHUA] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTHU] ON 

INSERT [dbo].[PHIEUTHU] ([MaPhieuThu], [MaXe], [NgayThuTien], [SoTienThu]) VALUES (7, 2, CAST(0xA9070000 AS SmallDateTime), 500000.0000)
INSERT [dbo].[PHIEUTHU] ([MaPhieuThu], [MaXe], [NgayThuTien], [SoTienThu]) VALUES (8, 2, CAST(0xA90A0000 AS SmallDateTime), 1000000.0000)
INSERT [dbo].[PHIEUTHU] ([MaPhieuThu], [MaXe], [NgayThuTien], [SoTienThu]) VALUES (9, 2, CAST(0xA90A0000 AS SmallDateTime), 300000.0000)
INSERT [dbo].[PHIEUTHU] ([MaPhieuThu], [MaXe], [NgayThuTien], [SoTienThu]) VALUES (10, 2, CAST(0xA90A0000 AS SmallDateTime), 3000000.0000)
INSERT [dbo].[PHIEUTHU] ([MaPhieuThu], [MaXe], [NgayThuTien], [SoTienThu]) VALUES (11, 2, CAST(0xA9070000 AS SmallDateTime), 400000.0000)
SET IDENTITY_INSERT [dbo].[PHIEUTHU] OFF
SET IDENTITY_INSERT [dbo].[THAMSO] ON 

INSERT [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (1, N'SoXeToiDa', N'30        ')
SET IDENTITY_INSERT [dbo].[THAMSO] OFF
SET IDENTITY_INSERT [dbo].[TIENCONG] ON 

INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (1, N'Thay phụ kiện xylanh', 124000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (2, N'Vệ sinh xylanh', 234000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (3, N'Lắp xylanh phanh', 78000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (4, N'Xả khí xylanh ', 120000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (5, N'Xả không khí', 45000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (6, N'Thay má phanh', 234000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (7, N'Tháo càng phanh đĩa', 456000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (8, N'Tháo lốp ', 45000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (9, N'Ấn píttông', 34000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (10, N'Thay cao su', 123000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (11, N'Tháo bán trục', 11000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (12, N'Xả dầu hộp số', 30000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (13, N'Tách đầu thanh nối', 254000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (14, N'Tháo rời bán trục', 456000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (15, N'Lắp bánh xe', 200000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (16, N'Thay ATF', 52000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (17, N'Thay ốc mới', 125000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (18, N'Thay nhớt', 56000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (19, N'Lắp pittong', 120000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (20, N'Lắp quạt điện', 125000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (21, N'Tháo Mâm ép', 56000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (22, N'Lắp bố thắng', 520000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (23, N'Tháo cao su chân', 152000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (24, N'Lắp lọc gió', 87000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (25, N'Tháo lọc gió', 65000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (26, N'Lắp lọc nhiên liệu', 89000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (27, N'Lắp láp dọc', 90000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (28, N'Lắp búp sen', 43000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (29, N'Tháo Phuộc trước', 324000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (30, N'Thay máy phát điện', 56000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (31, N'Lắp nulong', 56000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (32, N'Bôi trơn', 76000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (33, N'làm sạch', 84000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (34, N'chẩn đoán', 124000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (35, N'nối trượt ', 432000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (36, N'nối cho đầu khẩu', 21000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (37, N'thay thế bulông', 213000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (38, N'thay thế đai ốc', 123000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (39, N'cân lực ', 111000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (40, N'bảo vệ bugi', 234000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (41, N'Tháo hàm chỉnh', 66000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (42, N'Lắp hàm chỉnh', 75000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (43, N'Tháo đập bóng', 89000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (44, N'Thay hộp den', 97000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (45, N'Thay lọc gió', 567000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (46, N'Lắp càng xe', 870000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (47, N'Lắp giàn lạh', 90000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (48, N'Lắp giàn nóng', 76000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (49, N'Thay giàn nóng', 124000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (50, N'Thay Lazang', 65000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (51, N'Thay gương chiếu', 567000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (52, N'Thay két nước', 344000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (53, N'Thay bố li', 233000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (54, N'Thay đầu cơ', 355000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (55, N'Thay ruột cầu', 123000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (56, N'Lắp camera', 0)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (57, N'Lắp cao su đệm', 122000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (58, N'Lắp cao su gối', 255000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (59, N'Thay phuộc nhún', 155000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (60, N'Thay bầu hơi', 145000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (61, N'Thay bóp tay lái', 165000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (62, N'Thay cabin tổng', 254000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (63, N'Thay vỏ cánh cửa', 351000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (64, N'Thay gò má', 360000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (65, N'Lắp ốp kính trụ', 23000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (66, N'Lắp ba đờ xông', 76000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (67, N'Tháo cao su ắc', 23000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (68, N'Thay tambua', 456000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (69, N'Thay láp dọc', 450000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (70, N'Tháo visai', 80000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (71, N'Tháo trục khuỷa', 90000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (72, N'Lắp trục cam', 100000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (73, N'Thay bơn nhớt', 110000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (74, N'Thay bơm nước', 120000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (75, N'Lắp banh chuyền', 150000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (76, N'Tháo bạc đạn', 160000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (77, N'Thay hộp số', 77000)
INSERT [dbo].[TIENCONG] ([MaTienCong], [TenTienCong], [TienCong]) VALUES (78, N'Tháo dây lừa', 99000)
SET IDENTITY_INSERT [dbo].[TIENCONG] OFF
SET IDENTITY_INSERT [dbo].[VTPT] ON 

INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (1, N'Phuộc sau', 750000, 12)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (2, N'Mâm ép', 120000, 14)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (3, N'Bố ly hợp', 850000, 41)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (4, N'Bố thắng trước', 670000, 31)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (5, N'Bố thắng sau', 1250000, 11)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (6, N'Cao su chân máy', 1020000, 10)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (7, N'Rotuyn lái', 890000, 16)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (8, N'Lốc lạnh', 2600000, 81)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (9, N'Lốc lạnh Denso', 1250000, 61)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (10, N'Lốc lạnh tháo xe', 320000, 21)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (11, N'Quạt dàn lạnh', 560000, 31)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (12, N'Dàn lạnh', 420000, 13)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (13, N'Dàn lạnh sau', 410000, 23)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (14, N'Dàn nóng', 680000, 19)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (15, N'Dàn nóng innovau', 1250000, 32)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (16, N'Van tiết lưu', 1370000, 8)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (17, N'Máy phát điện', 760000, 9)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (18, N'Đồng hồ taplo', 4560000, 72)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (19, N'Đồng hồ taplo innova', 3240000, 62)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (20, N'Cảm biến ABS1', 540000, 19)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (21, N'Cảm biến ABS2', 1350000, 17)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (22, N'Cảm biến ABS3', 1390000, 30)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (23, N'Đèn lái', 660000, 20)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (24, N'Đèn cản', 4560000, 40)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (25, N'Đèn pha', 7890000, 13)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (26, N'Cản trước', 3210000, 50)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (27, N'Cửa xe', 6660000, 52)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (28, N'Kính chiếu hậu ', 220000, 65)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (29, N'Tappi cửa xe', 960000, 67)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (30, N'Kính chắn gió', 510000, 68)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (31, N'Kính lưng', 750000, 69)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (32, N'Két nước xe', 750000, 41)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (33, N' Mặt galang', 320000, 12)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (34, N' Mặt galang1', 1110000, 1)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (35, N'Đuôi cá', 1100000, 12)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (36, N'Sét gạt mưa', 2310000, 21)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (37, N'Lọc gió động cơ', 750000, 11)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (38, N'Lọc gió', 780000, 10)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (39, N'Lọc nhiên liệu', 550000, 18)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (40, N'Láp ngang cầu sau', 450000, 15)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (41, N'Láp dọc đồng bộ', 1150000, 17)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (42, N'Búp sen thắng', 3680000, 13)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (43, N'Rotuyn lái', 4210000, 10)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (44, N'Bộ khởi động', 750000, 9)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (45, N'Máy nén', 1370000, 7)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (46, N'Cảm biến Oxy', 690000, 6)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (47, N'Bơm nhiên liệu', 920000, 14)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (48, N'Hệ thống định vị ', 910000, 16)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (49, N'Máy hoàn nhiệt', 750000, 17)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (50, N'nạp chất ', 7350000, 41)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (51, N'càng chữ A', 350000, 10)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (52, N'ao su gối nhíp', 680000, 9)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (53, N'cao su ắc nhíp', 700000, 28)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (54, N'cao su đệm', 400000, 13)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (55, N' phuộc nhún', 750000, 19)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (56, N'bầu hơi', 300000, 12)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (57, N'bót tay lái', 600000, 12)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (58, N'dí trước', 1750000, 13)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (59, N'bơm trợ lực', 2750000, 14)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (60, N'cabin tổng thành', 7500000, 34)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (61, N'vỏ cánh cửa', 4100000, 12)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (62, N' nắp ca bô', 4520000, 45)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (63, N'gò má', 2350000, 45)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (64, N'ốp trụ ', 1250000, 67)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (65, N'kính', 1230000, 123)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (66, N'ruột cầu', 210000, 134)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (67, N'bộ vi sai', 0, 13)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (68, N' láp ngang', 450000, 45)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (69, N'láp dọc', 440000, 56)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (70, N'moay-ơ', 430000, 23)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (71, N'am bua', 460000, 11)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (72, N'bố ly hợp1', 630000, 18)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (73, N'bố ly hợp2', 330000, 34)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (74, N'bố ly hợp3', 320000, 44)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (75, N'mâm ép1', 120000, 45)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (76, N'mâm ép2', 110000, 55)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (77, N'bạc đạn bi tê', 100000, 61)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (78, N'dây lừa số', 210000, 9)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (79, N'dây số', 350000, 35)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (80, N'thước tầng dưới', 450000, 23)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (81, N'thước tầng trên', 660000, 32)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (82, N'pít-tông', 130000, 35)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (83, N'séc-măng', 420000, 52)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (84, N' trục khuỷu', 440000, 42)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (85, N' trục cam', 520000, 44)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (86, N'nắp quy-lát', 0, 74)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (87, N'ạc thanh truyền1', 1300000, 35)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (88, N'bạc trục khủy1', 0, 12)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (89, N'Bầu Trợ Lực Phanh', 1110000, 32)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (90, N'Bánh Răng Số 5', 1020000, 56)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (91, N'Bộ Hơi', 1230000, 10)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (92, N'Bộ Piston Kia', 0, 50)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (93, N'Bơm Cao Áp', 350000, 51)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (94, N'Bugi', 4520000, 21)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (95, N'Con Đội Cò Mổ', 4520000, 30)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (96, N'Dây Cam Bonggo 3', 1230000, 20)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (97, N'Dây Điện Kim Phun', 770000, 9)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (98, N'Mặt Máy', 890000, 77)
INSERT [dbo].[VTPT] ([MaVTPT], [TenVTPT], [DonGia], [SoLuongTon]) VALUES (99, N'Máy Đề', 80000, 32)
GO
SET IDENTITY_INSERT [dbo].[VTPT] OFF
SET IDENTITY_INSERT [dbo].[XE] ON 

INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (1, N'99-H77062', 5, N'Hoàng Tú Minh', N'51/4 – Đường Hà Huy Giáp – Khu phố 1 – P. Thạnh Xuân – Q.12 ', N'908256478', N'bachdang@gmail.com', CAST(0xA7100000 AS SmallDateTime), 13262000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (2, N'99-H77063', 5, N'Hoàng Tú Anh', N'307 Lê Đại Hành P13 Quận 11 TP HCM', N'938776266', N'tuankha.nina@gmail.com', CAST(0xA7310000 AS SmallDateTime), 3720000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (3, N'99-H77064', 10, N'Hoàng Anh Tú', N'583 Đường Rừng Sác Bình Khánh Huyện Cần Giờ', N'917325476', N'tuan808.nina@gmail.com', CAST(0xA83C0000 AS SmallDateTime), 3100000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (4, N'99-H77065', 10, N'Hoàng Anh Minh', N'610 Kinh Dương Vương, P. An Lạc, Quận Bình Tân, TP HCM', N'8246108', N'tuankha780.nina@gmail.com', CAST(0xA83C0000 AS SmallDateTime), 3200000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (5, N'99-H77066', 2, N'Hoàng Tú Anh Minh', N'69 Phan Đình Phùng- P.17 – Quận Phú nhuận', N'8631738', N'tuankha906.nina@gmail.com', CAST(0xA83C0000 AS SmallDateTime), 3300000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (6, N'99-H77067', 2, N'Nguyễn An Khuong Linh', N'16/1L Nguyễn Ảnh Thủ ấp Hưng Lân, Bà Điểm – Huyện Hóc Môn', N'916783565', N'tuankha31ql.nina@gmail.com', CAST(0xA6F00000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (7, N'99-H77068', 2, N'Nguyễn Khuong An', N'1519 Nguyễn Cửu Phú – ấp 1 – Tân Kiên – Huyện Bình Chánh', N'938435756', N'hoangkha.nina@gmail.com', CAST(0xA6F00000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (8, N'88-H77070', 1, N'Nguyễn An Xuong', N'312 Lý Thường Kiệt, P.14- Quận 10 TP HCM', N'8654763', N'phanngu.nina@gmail.com', CAST(0xA6F00000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (9, N'88-H77066', 2, N'Nguyễn An Khuong Linh', N'Đại học Nông Lâm – Khu phố 8 – Linh Trung Quận Thủ Đức', N'8768904', N'tuankha.nina@gmail.com', CAST(0xA6F00000 AS SmallDateTime), 3000000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (10, N'88-H77066', 6, N'Phạm Tuấn Anh', N'816 tỉnh lộ 43 – P.Bình Chiểu – Quận Thủ Đức', N'927345678', N'phanngu123.nina@gmail.com', CAST(0xA76A0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (11, N'88-H77066', 7, N'Đặng Văn Bi', N'441 Hoàng Văn Thụ.P04 Quận Tân Bình', N'927345678', N'phanngu789.nina@gmail.com', CAST(0xA76A0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (12, N'88-H77066', 8, N'Công Hoàng Phượng', N'878A Lê Đức Thọ – P.15 – Quận Gò Vấp', N'987567390', N'phanngu111.nina@gmail.com', CAST(0xA6F20000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (13, N'43C1-C109', 9, N'Trần Kiều ÂN', N'Số 1434 Đường Tỉnh Lộ 7, Ấp Chợ Cũ , Xã An Nhơn Tây, Huyện Củ Chi', N'997047382', N'phanngu567.nina@gmail.com', CAST(0xA6F20000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (14, N'43C1-C100', 10, N'Văn Đức Long', N'Tỉnh lộ 8 – Ấp 1A – Xã Tân Thạnh Tây – Huyện Củ Chi', N'913758498', N'phanngu321.nina@gmail.com', CAST(0xA7130000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (15, N'43C1-C105', 3, N'Hoàng Thi Hoa', N'338 Lê Văn Quới, Phường Bình Hưng Hòa A, Q Bình Tân, TP HCM', N'629493995', N'phanngu000.nina@gmail.com', CAST(0xA7CD0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (16, N'43C1-C101', 2, N'Nguyễn Quốc Hùng', N'1A73/2 Tỉnh Lộ 10 – Ấp 1 – Xã Tân Kiên – Huyện Bình Chánh', N'629493996', N'thjensonbds@gmail.com', CAST(0xA7110000 AS SmallDateTime), 5650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (17, N'29-K56789', 1, N'Phạm Tuấn Anh', N'6/9 Huỳnh Tấn Phát – KP 7 – TT Nhà bè – Huyện Nhà Bè', N'629493992', N'thjensonbd123s@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 5650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (18, N'99-H77061', 10, N'Phạm Đức Huy', N' 1B/ L1 Tô ký – P. Trung Mỹ Tây – Quận 12', N'629493921', N'thjensonbds3451@gmail.com', CAST(0xA7130000 AS SmallDateTime), 550000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (19, N'3932-6678', 8, N'Huỳnh Tấn Phát', N'322 Tùng Thiện Vương P.13 Quận 8, Hồ Chí Minh', N'906178078', N'thjensonbds3312@gmail.com', CAST(0xA7A90000 AS SmallDateTime), 650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (20, N'4321-6408', 7, N'Nông Văn Thu', N'162A Nguyễn Thị Định, P An Phú, Quận 2', N'906178077', N'tuan808.nina@gmail.com', CAST(0xA8060000 AS SmallDateTime), 3100000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (21, N'6678-6408', 5, N'Dương Khắc Linh', N'167 Nơ Trang Long – P.12 – Quận Bình Thạnh', N'906178079', N'tuankha780.nina@gmail.com', CAST(0xA7180000 AS SmallDateTime), 3200000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (22, N'3932-6678', 5, N'Đặng Huyền Trân', N'86H Nguyễn Ảnh Thủ – P. Hiệp thành – Quận 12', N'839101215', N'tuankha906.nina@gmail.com', CAST(0x99210000 AS SmallDateTime), 3300000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (23, N'4321-6408', 10, N'Phùng Khánh Linh', N'294A Đường 3/2 P.12 Quận 10', N'839101216', N'tuankha31ql.nina@gmail.com', CAST(0x99210000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (24, N'6678-6408', 5, N'Nguyễn Hoàng Công H?u', N'S8-1 Sky garden 1, Nguyễn Văn Linh, Phường Tân Phong, Quận 7', N'839101217', N'hoangkha.nina@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (25, N'3932-6678', 8, N'Nguyễn Hoàng Hậu', N'956 Huỳnh Tấn Phát – P. Tân Phú – Quận 7', N'839101218', N'phanngu.nina@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (26, N'4321-6408', 5, N'Nguyễn Công Hậu', N'315 Nguyễn Sơn – P.Phú Thạnh – Quận Tân Phú', N'839101219', N'tuankha.nina@gmail.com', CAST(0xA7130000 AS SmallDateTime), 3000000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (27, N'6678-6408', 8, N'Nguyễn Hoàng Công', N' 231 Lê Trọng Tấn – P.Sơn Kỳ – Quận Tân Phú', N'839101210', N'phanngu123.nina@gmail.com', CAST(0xA7A90000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (28, N'3932-6678', 5, N'Nguyễn Hậu', N'178 Hòa Bình -P. Hiệp Tân – Quận Tân Phú', N'839101211', N'phanngu789.nina@gmail.com', CAST(0xA7CD0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (29, N'4321-6408', 8, N'Nguyễn Hoàng Công Vinh', N'939 Kha Vạn Cân – P. Linh tây – Quận Thủ Đức', N'839101212', N'phanngu111.nina@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (30, N'6678-6408', 1, N'Nguyễn Hoàng Hoa', N'31/3 Lý Thường Kiệt – Thị trấn Hóc Môn – Huyện Hóc Môn', N'839101214', N'phanngu567.nina@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (31, N'3932-6678', 6, N'Phạm Ngọc Anh Thu', N'493 Lạc Long Quân – P.5 – Quận 1', N'839101265', N'phanngu321.nina@gmail.com', CAST(0xA7130000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (32, N'4321-6408', 5, N'Phạm Anh Thu', N'31 Đỗ Xuân Hợp – P. Phước Long B – Quận 9', N'629493997', N'phanngu000.nina@gmail.com', CAST(0xA7CD0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (33, N'6678-6408', 3, N'Phạm Ngọc Thu', N'644 Cách Mạng Tháng 8 – P. 11 – Quận 3', N'629493998', N'thjensonbds@gmail.com', CAST(0xA7110000 AS SmallDateTime), 5650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (34, N'81A-04445', 7, N'Phạm Ngọc Anh', N'76C Quốc Lộ 13 – P.26 – Quận Bình Thạnh', N'629493999', N'thjensonbd123s@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 5650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (35, N'81A-04445', 5, N'Phạm Ngọc Thu Anh ', N' 940 Tỉnh lộ 10 – P. Tân Tạo – Quận Bình Tân', N'977794014', N'thjensonbds3451@gmail.com', CAST(0xA7110000 AS SmallDateTime), 550000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (36, N'81A-04445', 1, N'Phạm Ngọc Anh', N'214- 216 Hồng Bàng – P.15 Quận 5', N'977794015', N'thjensonbds3312@gmail.com', CAST(0xA72E0000 AS SmallDateTime), 650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (37, N'81A-03367', 1, N'Lâm Lê Tuấn Kiệt', N'385 Tôn Đản – P.15 – Quận 4', N'977794016', N'thuyhang4452@netco.com.vn', CAST(0xA7130000 AS SmallDateTime), 1150000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (38, N'81A-04449', 5, N'Lâm Tuấn Kiệt', N'190 Lê Hồng Phong – P.4 – Quận 5', N'2838227755', N'tuan808.nina@gmail.com', CAST(0xA7180000 AS SmallDateTime), 3100000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (39, N'81A-04445', 6, N'Lâm Lê Kiệt', N'156 Trần Não P.Bình An Quận 2', N'2542216565', N'tuankha780.nina@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3200000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (40, N'81A-04445', 1, N'Lâm Lê Tuấn', N'174 Trần Quang Khải – P. Tân Định – Quận 1', N'2542216516', N'tuankha906.nina@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 3300000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (41, N'81A-04445', 2, N'Lê Tuấn Kiệt', N'141B Phan Đăng Lưu – P.2 – Phú Nhuận', N'2542216514', N'tuankha31ql.nina@gmail.com', CAST(0xA7130000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (42, N'81A-04445', 1, N'Lê Kiệt Tuấn ', N'15 Phan Văn Trị – P.7 – Quận Gò Vấp', N'2542216517', N'hoangkha.nina@gmail.com', CAST(0xA7CD0000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (43, N'81A-04445', 5, N'Lâm Lê Tuấn Hà', N'15 Quang Trung – P.10 – Quận Gò vấp', N'2542216518', N'phanngu.nina@gmail.com', CAST(0x99210000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (44, N'77B-04445', 7, N'Lâm Lê Hùng Kiệt', N'58 Nguyễn Văn Đậu – P.6 – Quận Bình Thạnh', N'906178078', N'tuankha.nina@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3000000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (45, N'77B-04440', 10, N'Lâm Hùng Tuấtn ', N'427 Nguyễn Thị Thập – P.Tân Phong – Q7', N'906178077', N'phanngu123.nina@gmail.com', CAST(0xA7A70000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (46, N'77B-04446', 1, N'Trần Lê Mai Hoàng', N'258 Lê Văn Việt – P. Tăng Nhơn Phú B – Quận 9', N'906178079', N'phanngu789.nina@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (47, N'77B-04447', 6, N'Hoàng Văn Thụ', N'258 Lê Văn Việt – P. Tăng Nhơn Phú B – Quận 9', N'906178074', N'phanngu111.nina@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (48, N'77B-04448', 10, N'Lê Mai Hoa', N'368 Phạm Hùng P.5 Quận 8', N'906178075', N'phanngu567.nina@gmail.com', CAST(0xA72E0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (49, N'77B-04449', 5, N'Huỳnh Huy Hà', N'286 Cộng Hoà – P.13 – Quận Tân Bình', N'906178076', N'phanngu321.nina@gmail.com', CAST(0xA7130000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (50, N'77B5-0215', 5, N'Lương Văn Huy', N'166C-D-E Trần Hưng Đạo P.Nguyễn Cư Trinh Quận 1', N'906178055', N'phanngu000.nina@gmail.com', CAST(0xA7CD0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (51, N'77B5-0216', 10, N'Phùng Huyền Trâm', N'Số 964/19 Đường Hương Lộ 2, Khu phố 10, Phường Bình Trị Đông A, Quận Bình Tân', N'90617866', N'thjensonbds@gmail.com', CAST(0xA7110000 AS SmallDateTime), 5650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (52, N'77B5-0214', 10, N'Phạm Khắc Hiếu', N'Số 03 Nguyễn Oanh, Phường 10, Quận Gò Vấp, TP Hồ Chí Minh', N'906178033', N'thjensonbd123s@gmail.com', CAST(0xA6F20000 AS SmallDateTime), 5650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (53, N'77B5-2215', 2, N'Lâm Tấn Phụng', N'Thửa Số 91, Tờ Bản Đồ Số 34, ấp Bàu Trăn, Xã Nhuận Đức, Huyện Củ Chi', N'906178014', N'thjensonbds3451@gmail.com', CAST(0xA8050000 AS SmallDateTime), 550000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (54, N'77B5-7856', 2, N'Võ Xuân Trường', N'Lô Q80, 84 Đường 16, Khu Tiểu Thủ Công Nghiệp, ấp 1, Xã Tân Nhựt, Huyện Bình Chánh', N'906178077', N'thjensonbds3312@gmail.com', CAST(0xA7CD0000 AS SmallDateTime), 650000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (55, N'66B5-0215', 8, N'Võ Văn Phùng', N'48 Lũy Bán Bích, Phường Tân Thới Hoà, Quận Tân phú, TP Hồ Chí Minh', N'906178079', N'thuyhang4452@netco.com.vn', CAST(0xA7110000 AS SmallDateTime), 110000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (56, N'77B5-5241', 10, N'Châu Thị Lợi', N' 54, 56 Tân Hưng, Phường 12, Quận 5, TP Hồ Chí Minh', N'906178074', N'tuan808.nina@gmail.com', CAST(0xA6F20000 AS SmallDateTime), 3100000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (57, N'77B5-8863', 2, N'Châu Hoàng Phong', N'6/24 Cư xá Lữ Gia, Đường số 3, Phường 15, Quận 11, TP Hồ Chí Minh', N'906178075', N'thaotran938@gmail.com', CAST(0xA7180000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (58, N'88B5-0215', 10, N'Trần Thị Linh', N'739 Lê Hồng Phong, Phường 12, Quận 10, TP Hồ Chí Minh', N'906178076', N'thaotran444@gmail.com', CAST(0xA76C0000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (59, N'77A7-0215', 10, N'Đặng Thị Thi', N'B3/41C Liên ấp 2, 6, Xã Vĩnh Lộc A, Huyện Bình Chánh, TP Hồ Chí Minh', N'906178055', N'thaotran91945@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (60, N'45C1-8765', 10, N'Trần Hoài An', N' TK28/23 Nguyễn Cảnh Chân, Phường Cầu Kho, Quận 1, TP Hồ Chí Minh', N'90617866', N'thaotran938@gmail.com', CAST(0xA6F20000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (61, N'46C1-8765', 5, N'Trần Ngọc Diễm', N'Số 10 Đường HT22, phường Hiệp Thành, Quận 12, TP Hồ Chí Minh', N'927345678', N'thaotran444@gmail.com', CAST(0xA7180000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (62, N'47C1-8765', 5, N'Phan Văn Huy', N'160 Phong Phú, Phường 12, Quận 8, TP Hồ Chí Minh', N'987567390', N'thaotran91945@gmail.com', CAST(0xA76C0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (63, N'48C1-8765', 2, N'Phan Tấn Phát', N'64 Bùi Viện, Phường Phạm Ngũ Lão, Quận 1, TP Hồ Chí Minh', N'997047382', N'thaotran938@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (64, N'49C1-8765', 3, N'Nguyễn Thị Thanh Hà', N' 804/6 Nguyễn Duy Trinh, Phường Phú Hữu, Quận 9, TP Hồ Chí Minh', N'913758498', N'thaotran444@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (65, N'50C1-8765', 10, N'Nguyễn Thị Thanh Hoa', N'116 đường Chuyên dùng 9, khu phố 3, Phường Phú Mỹ, Quận 7, TP Hồ Chí Minh', N'918590387', N'thaotran91945@gmail.com', CAST(0xA7180000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (66, N'55C1-8765', 10, N'Nguyễn Hoàn Thanh', N'628/54/46 Hậu Giang, Phường 12, Quận 6, TP Hồ Chí Minh', N'906178033', N'thaotran938@gmail.com', CAST(0xA76C0000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (67, N'66C1-8765', 8, N'Nguyễn Thị Hiền Thục', N'410B/32 Hậu Giang, Phường 12, Quận 6, TP Hồ Chí Minh', N'906178033', N'thaotran444@gmail.com', CAST(0xA7AA0000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (68, N'89C1-8765', 10, N'Nguyễn Thị  Hậu', N' 66 đường số 74, khu phố 2, Phường 10, Quận 6, TP Hồ Chí Minh', N'906178033', N'thaotran91945@gmail.com', CAST(0xA6F50000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (69, N'72C1-8765', 5, N'Nguyễn Thanh Tâm', N'130 Nguyễn Quý Anh, Phường Tân Sơn Nhì, Quận Tân phú, TP Hồ Chí Minh', N'906178033', N'thaotran938@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (70, N'63C1-8765', 5, N'Nguyễn Thục Trinh', N' 754/13/63 đường Tân Kỳ Tân Quý, Khu phố 14, Phường Bình Hưng Hòa, Quận Bình Tân', N'906178033', N'thaotran444@gmail.com', CAST(0xA72D0000 AS SmallDateTime), 3500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (71, N'45C1-8765', 10, N'Nguyễn Hiền', N' 8A/3B2 Thái Văn Lung, Phường Bến Nghé, Quận 1, TP Hồ Chí Minh', N'906178033', N'thaotran91945@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (72, N'82C1-8765', 5, N'Trần Lê Thanh Ph?ng', N'8A/3B2 Thái Văn Lung, Phường Bến Nghé, Quận 1, TP Hồ Chí Minh', N'906178033', N'thaotran938@gmail.com', CAST(0xA7180000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (73, N'46C1-8765', 10, N'Trần Thanh Ph?ng', N' 60/6B ấp Tây Lân, Xã Bà Điểm, Huyện Hóc Môn, TP Hồ Chí Min', N'906178033', N'thaotran938@gmail.com', CAST(0xA76C0000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (74, N'47C1-8765', 5, N'Trần Lê Ph?ng', N' 69/5B Lê Thị Hà, ấp Chánh 1, Xã Tân Xuân, Huyện Hóc Môn, TP Hồ Chí Minh', N'989131003', N'thaotran938@gmail.com', CAST(0xA7110000 AS SmallDateTime), 3400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (75, N'48C1-8765', 3, N'Trần Lê Thanh ', N'158 Nguyễn ảnh Thủ, ấp Đông 1, Xã Thới Tam Thôn, Huyện Hóc Môn, TP Hồ Chí Minh', N'989131006', N' gocanh.nds@gmail.com ', CAST(0xA6F20000 AS SmallDateTime), 4400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (76, N'49C1-8765', 5, N'Lê Thanh Phong', N' 83, 83A Đường Miếu Gò Xoài, Khu phố 11, Phường Bình Hưng Hòa A, Quận Bình Tân', N'931313511', N' tancanh.nds@gmail.com ', CAST(0xA7180000 AS SmallDateTime), 5400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (77, N'50C1-8765', 8, N'Lê Phong Thanh ', N'Lô Số 10, Khu H, Đường D1, Khu Công Nghiệp An Hạ, Xã Phạm Văn Hai, Huyện Bình Chánh', N'931313512', N' tangoc.nds@gmail.com ', CAST(0xA76C0000 AS SmallDateTime), 8400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (78, N'55C1-8765', 10, N'Trần Phong Lê Thanh ', N'249/9 đường Đông Hưng Thuận, Phường Tân Hưng Thuận, Quận 12', N'931313513', N' tanganh.nds@gmail.com ', CAST(0xA7110000 AS SmallDateTime), 9400000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (79, N'66C1-8765', 6, N'Trần Thanh Lê Phong', N'Số 294, 296 Nguyễn ảnh Thủ, phường Hiệp Thành, Quận 12, TP Hồ Chí Minh', N'931313514', N' tangocanh.nl@gmail.com ', CAST(0xA6F20000 AS SmallDateTime), 1200000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (80, N'89C1-8765', 10, N'Nguyễn An Xuong', N' Số nhà 16, đường số 5, Khu dân cư Him Lam, Xã Bình Hưng, Huyện Bình Chánh', N'931313515', N' tangocanh.nd@gmail.com ', CAST(0xA7110000 AS SmallDateTime), 7900000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (81, N'72C1-8765', 5, N'Nguyễn An Khuong Linh', N'162P Trường Chinh, Phường 12, Quận Tân Bình, TP Hồ Chí Minh', N'931313516', N' tangocanhnds@gmail.com ', CAST(0xA72E0000 AS SmallDateTime), 3600000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (82, N'63C1-8765', 5, N'Phạm Tuấn Anh', N'Số 294, 296 Nguyễn ảnh Thủ, phường Hiệp Thành, Quận 12, TP Hồ Chí Minh', N'931313510', N'tvd.trandoco@gmail.com', CAST(0xA7130000 AS SmallDateTime), 900000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (83, N'45C1-8765', 10, N'Đặng Văn Bi', N'Số nhà 16, đường số 5, Khu dân cư Him Lam, Xã Bình Hưng, Huyện Bình Chánh,', N'931313526', N'tvd.trandoco@gmail.com', CAST(0xA7180000 AS SmallDateTime), 800000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (84, N'82C1-8765', 10, N'Công Hoàng Phượng', N'162P Trường Chinh, Phường 12, Quận Tân Bình, TP Hồ Chí Minh', N'931313546', N'anhd456t@fsw.vn', CAST(0xA7110000 AS SmallDateTime), 7500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (85, N'B166-6251', 2, N'Trần Kiều ÂN', N'Tầng 2, Tòa Nhà Hado Airport Building, số 2 Hồng Hà, Phường 2, Quận Tân Bình', N'931313556', N'anhd123t@fsw.vn', CAST(0xA72D0000 AS SmallDateTime), 6500000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (86, N'B167-6251', 2, N'Văn Đức Long', N'64 Tân Thới Nhất 14, phường Tân Thới Nhất, Quận 12, TP Hồ Chí Minh', N'931313566', N'anhdt45@fsw.vn', CAST(0xA7130000 AS SmallDateTime), 2200000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (87, N'B168-6251', 2, N'Hoàng Thi Hoa', N'Tòa Nhà Hado Airport Building, số 2 Hồng Hà, Phường 2, Quận Tân Bình', N'931313576', N'Haita@dmlsaigon.com', CAST(0xA7180000 AS SmallDateTime), 210000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (88, N'B169-6251', 10, N'Nguyễn Quốc Hùng', N'64 Tân Thới Nhất 14, phường Tân Thới Nhất, Quận 12, TP Hồ Chí Minh', N'931313816', N'Hai123@dmlsaigon.com', CAST(0xA8030000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (89, N'B170-6251', 2, N'Phạm Tuấn Anh', N'Số 34 Đường 44 KDC Bình Phú, Phường 10, Quận 6, TP Hồ Chí Minh', N'989131001', N'Hta35@dmlsaigon.com', CAST(0xA8220000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (90, N'B171-6251', 10, N'Phạm Đức Huy', N'20 Nguyễn Đăng Giai, Phường Thảo Điền, Quận 2, TP Hồ Chí Minh', N'989131002', N'Hait54@dmlsaigon.com', CAST(0xA80A0000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (91, N'B172-6251', 10, N'Huỳnh Tấn Phát', N'Crescent Mall, 101 Tôn Dật Tiên, Phường Tân Phú, Quận 7, TP Hồ Chí Minh', N'989131003', N'a4ta@dmlsaigon.com', CAST(0xA7E70000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (92, N'B173-6251', 10, N'Nông Văn Thu', N'Số 357/30M Đường Nguyễn Oanh, Phường 15, Quận Gò Vấp, TP Hồ Chí Minh', N'989131006', N'ita456@dmlsaigon.com', CAST(0xA7C60000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (93, N'B175-6251', 5, N'Dương Khắc Linh', N'C11/11A, Quốc Lộ 1A, Khu phố 3, Thị Trấn Tân Túc, Huyện Bình Chánh, TP Hồ Chí Minh', N'8823451', N'Haijn@dmlsaigon.com', CAST(0xA7A70000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (94, N'B176-6251', 2, N'Đặng Huyền Trân', N'87/3 Nguyễn Chí Thanh, Phường 16, Quận 11, TP Hồ Chí Minh', N'908256478', N'Haijn@dmlsaigon.com', CAST(0xA7900000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (95, N'B167-7698', 2, N'Phùng Khánh Linh', N'177/16/10 Liên Khu 4, 5 Khu Phố 5, Phường Bình Hưng Hòa B, Quận Bình Tân,', N'938776266', N'hoagn@dmlsaigon.com', CAST(0xA7130000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (96, N'B166-7698', 3, N'Nguyễn Hoàng Công H?u', N' 4B đường 157, ấp 6A, Xã Bình Mỹ, Huyện Củ Chi, TP Hồ Chí Minh', N'917325476', N'ngocnguyen@dmlsaigon.com', CAST(0xA72D0000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (97, N'B168-7698', 1, N'Nguyễn Hoàng Hà', N'263 Phạm Hữu Lầu, ấp 4, Xã Phước Kiển, Huyện Nhà Bè, TP Hồ Chí Minh', N'8246108', N'baria@dmlsaigon.com', CAST(0xA6F20000 AS SmallDateTime), 850000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (98, N'B169-7698', 1, N'Nguyễn Công Hà', N'283 Kênh Tân Hóa, Phường Hoà Thạnh, Quận Tân phú, TP Hồ Chí Minh', N'8631738', N'Hai123@dmlsaigon.com', CAST(0xA7180000 AS SmallDateTime), 860000)
INSERT [dbo].[XE] ([MaXe], [BienSo], [MaHieuXe], [TenChuXe], [DiaChi], [DienThoai], [Email], [NgayTiepNhan], [TienNo]) VALUES (99, N'B177-7698', 8, N'Nguyễn Hoàng Công', N'290/40/5 Đường HT13, Khu Phố 7, phường Hiệp Thành, Quận 12, TP Hồ Chí Minh', N'916783565', N'Hta35@dmlsaigon.com', CAST(0xA76C0000 AS SmallDateTime), 70000)
GO
SET IDENTITY_INSERT [dbo].[XE] OFF
ALTER TABLE [dbo].[XE] ADD  CONSTRAINT [DF_X_TienNo]  DEFAULT ((0)) FOR [TienNo]
GO
ALTER TABLE [dbo].[BAOCAOTON]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOTON_VTPT] FOREIGN KEY([MaVTPT])
REFERENCES [dbo].[VTPT] ([MaVTPT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BAOCAOTON] CHECK CONSTRAINT [FK_BAOCAOTON_VTPT]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_VTPT] FOREIGN KEY([MaVTPT])
REFERENCES [dbo].[VTPT] ([MaVTPT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_VTPT]
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUSUACHUA_PHIEUSUACHUA] FOREIGN KEY([MaPhieuSC])
REFERENCES [dbo].[PHIEUSUACHUA] ([MaPhieuSC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA] CHECK CONSTRAINT [FK_CT_PHIEUSUACHUA_PHIEUSUACHUA]
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUSUACHUA_TIENCONG] FOREIGN KEY([MaTienCong])
REFERENCES [dbo].[TIENCONG] ([MaTienCong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA] CHECK CONSTRAINT [FK_CT_PHIEUSUACHUA_TIENCONG]
GO
ALTER TABLE [dbo].[CT_SUDUNGVTPT]  WITH CHECK ADD  CONSTRAINT [FK_CT_SUDUNGVTPT_CT_PHIEUSUACHUA] FOREIGN KEY([MaCT])
REFERENCES [dbo].[CT_PHIEUSUACHUA] ([MaCT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_SUDUNGVTPT] CHECK CONSTRAINT [FK_CT_SUDUNGVTPT_CT_PHIEUSUACHUA]
GO
ALTER TABLE [dbo].[CT_SUDUNGVTPT]  WITH CHECK ADD  CONSTRAINT [FK_CT_SUDUNGVTPT_VTPT] FOREIGN KEY([MaVTPT])
REFERENCES [dbo].[VTPT] ([MaVTPT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_SUDUNGVTPT] CHECK CONSTRAINT [FK_CT_SUDUNGVTPT_VTPT]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_CHUCVU] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_CHUCVU]
GO
ALTER TABLE [dbo].[PHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUSUACHUA_XE] FOREIGN KEY([MaXe])
REFERENCES [dbo].[XE] ([MaXe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUSUACHUA] CHECK CONSTRAINT [FK_PHIEUSUACHUA_XE]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_XE] FOREIGN KEY([MaXe])
REFERENCES [dbo].[XE] ([MaXe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_XE]
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD  CONSTRAINT [FK_XE_HIEUXE] FOREIGN KEY([MaHieuXe])
REFERENCES [dbo].[HIEUXE] ([MaHieuXe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[XE] CHECK CONSTRAINT [FK_XE_HIEUXE]
GO
USE [master]
GO
ALTER DATABASE [Gara] SET  READ_WRITE 
GO
