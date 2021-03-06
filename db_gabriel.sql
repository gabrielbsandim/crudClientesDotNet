USE [master]
GO
/****** Object:  Database [db_gabriel]    Script Date: 15/03/2020 18:01:03 ******/
CREATE DATABASE [db_gabriel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_gabriel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\db_gabriel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_gabriel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\db_gabriel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_gabriel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_gabriel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_gabriel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_gabriel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_gabriel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_gabriel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_gabriel] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_gabriel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_gabriel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_gabriel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_gabriel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_gabriel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_gabriel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_gabriel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_gabriel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_gabriel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_gabriel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_gabriel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_gabriel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_gabriel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_gabriel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_gabriel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_gabriel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_gabriel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_gabriel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_gabriel] SET  MULTI_USER 
GO
ALTER DATABASE [db_gabriel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_gabriel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_gabriel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_gabriel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_gabriel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_gabriel] SET QUERY_STORE = OFF
GO
USE [db_gabriel]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/03/2020 18:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](80) NOT NULL,
	[Telefone] [nvarchar](20) NOT NULL,
	[Endereco] [nvarchar](150) NULL,
	[Cep] [nvarchar](10) NULL,
	[Sexo] [nvarchar](10) NOT NULL,
	[Idade] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ClienteId], [Nome], [Telefone], [Endereco], [Cep], [Sexo], [Idade]) VALUES (1, N'Teste', N'943368900', N'Av. São Paulo, 1100', N'08790150', N'Masculino', 21)
INSERT [dbo].[Clientes] ([ClienteId], [Nome], [Telefone], [Endereco], [Cep], [Sexo], [Idade]) VALUES (3, N'Gabriel Bastos', N'943368900', N'Rua João Caetano dos Santos, 125', N'08830500', N'Masculino', 21)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
USE [master]
GO
ALTER DATABASE [db_gabriel] SET  READ_WRITE 
GO
