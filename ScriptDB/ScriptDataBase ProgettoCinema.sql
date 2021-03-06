USE [master]
GO
/****** Object:  Database [ProgettoCinema]    Script Date: 11/19/2020 3:37:50 PM ******/
CREATE DATABASE [ProgettoCinema]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProgettoCinema', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProgettoCinema.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProgettoCinema_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProgettoCinema_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProgettoCinema] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProgettoCinema].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProgettoCinema] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProgettoCinema] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProgettoCinema] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProgettoCinema] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProgettoCinema] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProgettoCinema] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProgettoCinema] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProgettoCinema] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProgettoCinema] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProgettoCinema] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProgettoCinema] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProgettoCinema] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProgettoCinema] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProgettoCinema] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProgettoCinema] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProgettoCinema] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProgettoCinema] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProgettoCinema] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProgettoCinema] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProgettoCinema] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProgettoCinema] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProgettoCinema] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProgettoCinema] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProgettoCinema] SET  MULTI_USER 
GO
ALTER DATABASE [ProgettoCinema] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProgettoCinema] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProgettoCinema] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProgettoCinema] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProgettoCinema] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProgettoCinema] SET QUERY_STORE = OFF
GO
USE [ProgettoCinema]
GO
/****** Object:  Table [dbo].[Biglietti]    Script Date: 11/19/2020 3:37:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biglietti](
	[IdBiglietto] [varchar](50) NOT NULL,
	[NPosto] [int] NOT NULL,
	[PrezzoBiglietto] [decimal](2, 2) NOT NULL,
 CONSTRAINT [PK_Biglietti] PRIMARY KEY CLUSTERED 
(
	[IdBiglietto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cinema]    Script Date: 11/19/2020 3:37:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cinema](
	[IdCinema] [varchar](50) NOT NULL,
	[NomeCinema] [nvarchar](100) NOT NULL,
	[IdSala] [varchar](50) NOT NULL,
	[IdFilm] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cinema] PRIMARY KEY CLUSTERED 
(
	[IdCinema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 11/19/2020 3:37:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[IdFilm] [varchar](50) NOT NULL,
	[Titolo] [nvarchar](100) NOT NULL,
	[Autore] [varchar](70) NOT NULL,
	[Produttore] [varchar](70) NOT NULL,
	[Genere] [varchar](50) NOT NULL,
	[Durata] [datetime] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[IdFilm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleCinematografice]    Script Date: 11/19/2020 3:37:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleCinematografice](
	[IdSala] [varchar](50) NOT NULL,
	[NomeSala] [varchar](10) NOT NULL,
	[NumeroPosti] [int] NOT NULL,
	[IdSpettatore] [varchar](50) NULL,
	[IdFilm] [nchar](10) NULL,
 CONSTRAINT [PK_SalaCinematografica] PRIMARY KEY CLUSTERED 
(
	[IdSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Spettatori]    Script Date: 11/19/2020 3:37:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Spettatori](
	[IdSpettatore] [varchar](50) NOT NULL,
	[NomeSpettatore] [varchar](70) NOT NULL,
	[CognomeSpettatore] [varchar](70) NOT NULL,
	[DataNascita] [datetime] NOT NULL,
	[IdBiglietto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Spettatore] PRIMARY KEY CLUSTERED 
(
	[IdSpettatore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Film] ([IdFilm], [Titolo], [Autore], [Produttore], [Genere], [Durata]) VALUES (N'0', N'Prova', N'Prova', N'Prova', N'Prova', CAST(N'2001-01-01T01:30:25.000' AS DateTime))
GO
INSERT [dbo].[Spettatori] ([IdSpettatore], [NomeSpettatore], [CognomeSpettatore], [DataNascita], [IdBiglietto]) VALUES (N'1000', N'Pier', N'Fontana', CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'3000')
GO
USE [master]
GO
ALTER DATABASE [ProgettoCinema] SET  READ_WRITE 
GO
