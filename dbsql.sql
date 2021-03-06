USE [master]
GO
/****** Object:  Database [MovieBooking]    Script Date: 02/08/2021 16:35:32 ******/
CREATE DATABASE [MovieBooking] ON  PRIMARY 
( NAME = N'MovieBooking', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER1\MSSQL\DATA\MovieBooking.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MovieBooking_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER1\MSSQL\DATA\MovieBooking_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MovieBooking] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieBooking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieBooking] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MovieBooking] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MovieBooking] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MovieBooking] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MovieBooking] SET ARITHABORT OFF
GO
ALTER DATABASE [MovieBooking] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [MovieBooking] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MovieBooking] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MovieBooking] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MovieBooking] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MovieBooking] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MovieBooking] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MovieBooking] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MovieBooking] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MovieBooking] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MovieBooking] SET  DISABLE_BROKER
GO
ALTER DATABASE [MovieBooking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MovieBooking] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MovieBooking] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MovieBooking] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MovieBooking] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MovieBooking] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MovieBooking] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MovieBooking] SET  READ_WRITE
GO
ALTER DATABASE [MovieBooking] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MovieBooking] SET  MULTI_USER
GO
ALTER DATABASE [MovieBooking] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MovieBooking] SET DB_CHAINING OFF
GO
USE [MovieBooking]
GO
/****** Object:  Table [dbo].[pay]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pay](
	[Id] [int] NULL,
	[m_name] [varchar](40) NULL,
	[no_tick] [int] NULL,
	[amnt] [int] NULL,
	[p_type] [varchar](40) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[orderfood]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[orderfood](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[uid] [int] NULL,
	[foodtype] [varchar](50) NULL,
	[f_name] [varchar](50) NULL,
	[price] [money] NULL,
	[qty] [int] NULL,
	[totalamt] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[movies]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[movies](
	[Id] [int] NULL,
	[city] [varchar](30) NULL,
	[locat] [varchar](40) NULL,
	[m_name] [varchar](50) NULL,
	[time] [varchar](30) NULL,
	[no_tick] [int] NULL,
	[s_type] [varchar](30) NULL,
	[s_no] [int] NULL,
	[amnt] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[moviebooking]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[moviebooking](
	[bid] [int] IDENTITY(1,1) NOT NULL,
	[uid] [int] NULL,
	[uname] [varchar](40) NULL,
	[moviename] [varchar](40) NULL,
	[seattype] [varchar](40) NULL,
	[seatnum] [int] NULL,
	[Qty] [int] NULL,
	[Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[bid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[movie]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[movie](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [varchar](50) NULL,
	[Language] [varchar](50) NULL,
	[Pprice] [money] NULL,
	[Gprice] [money] NULL,
	[Sprice] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[food]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[food](
	[FoodId] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](50) NULL,
	[Ftype] [varchar](50) NULL,
	[Qty] [int] NULL,
	[price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[FoodId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FeedBack]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FeedBack](
	[FeedBackId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[UserName] [varchar](50) NULL,
	[FeedBack] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[FeedBackId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](40) NULL,
	[mobile] [varchar](20) NULL,
	[email] [varchar](40) NULL,
	[pass] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bookmovie]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bookmovie](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NULL,
	[MovieName] [varchar](20) NULL,
	[CustId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Admintable]    Script Date: 02/08/2021 16:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admintable](
	[AdminName] [varchar](20) NULL,
	[Password] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__pay__Id__2E1BDC42]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[pay] ADD  DEFAULT (NULL) FOR [Id]
GO
/****** Object:  Default [DF__pay__m_name__2F10007B]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[pay] ADD  DEFAULT (NULL) FOR [m_name]
GO
/****** Object:  Default [DF__pay__no_tick__300424B4]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[pay] ADD  DEFAULT (NULL) FOR [no_tick]
GO
/****** Object:  Default [DF__pay__amnt__30F848ED]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[pay] ADD  DEFAULT (NULL) FOR [amnt]
GO
/****** Object:  Default [DF__pay__p_type__31EC6D26]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[pay] ADD  DEFAULT (NULL) FOR [p_type]
GO
/****** Object:  Default [DF__orderfood__uid__29572725]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[orderfood] ADD  DEFAULT (NULL) FOR [uid]
GO
/****** Object:  Default [DF__orderfood__foodt__2A4B4B5E]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[orderfood] ADD  DEFAULT (NULL) FOR [foodtype]
GO
/****** Object:  Default [DF__orderfood__f_nam__2B3F6F97]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[orderfood] ADD  DEFAULT (NULL) FOR [f_name]
GO
/****** Object:  Default [DF__orderfood__qty__2C3393D0]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[orderfood] ADD  DEFAULT (NULL) FOR [qty]
GO
/****** Object:  Default [DF__movies__Id__1CF15040]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [Id]
GO
/****** Object:  Default [DF__movies__city__1DE57479]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [city]
GO
/****** Object:  Default [DF__movies__locat__1ED998B2]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [locat]
GO
/****** Object:  Default [DF__movies__m_name__1FCDBCEB]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [m_name]
GO
/****** Object:  Default [DF__movies__time__20C1E124]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [time]
GO
/****** Object:  Default [DF__movies__no_tick__21B6055D]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [no_tick]
GO
/****** Object:  Default [DF__movies__s_type__22AA2996]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [s_type]
GO
/****** Object:  Default [DF__movies__s_no__239E4DCF]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [s_no]
GO
/****** Object:  Default [DF__movies__amnt__24927208]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movies] ADD  DEFAULT (NULL) FOR [amnt]
GO
/****** Object:  Default [DF__moviebookin__uid__173876EA]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[moviebooking] ADD  DEFAULT (NULL) FOR [uid]
GO
/****** Object:  Default [DF__moviebook__uname__182C9B23]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[moviebooking] ADD  DEFAULT (NULL) FOR [uname]
GO
/****** Object:  Default [DF__moviebook__movie__1920BF5C]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[moviebooking] ADD  DEFAULT (NULL) FOR [moviename]
GO
/****** Object:  Default [DF__moviebook__seatt__1A14E395]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[moviebooking] ADD  DEFAULT (NULL) FOR [seattype]
GO
/****** Object:  Default [DF__moviebook__seatn__1B0907CE]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[moviebooking] ADD  DEFAULT (NULL) FOR [seatnum]
GO
/****** Object:  Default [DF__movie__MovieName__0EA330E9]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movie] ADD  DEFAULT (NULL) FOR [MovieName]
GO
/****** Object:  Default [DF__movie__Language__0F975522]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movie] ADD  DEFAULT (NULL) FOR [Language]
GO
/****** Object:  Default [DF__movie__Pprice__108B795B]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movie] ADD  DEFAULT (NULL) FOR [Pprice]
GO
/****** Object:  Default [DF__movie__Gprice__117F9D94]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movie] ADD  DEFAULT (NULL) FOR [Gprice]
GO
/****** Object:  Default [DF__movie__Sprice__1273C1CD]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[movie] ADD  DEFAULT (NULL) FOR [Sprice]
GO
/****** Object:  Default [DF__food__Fname__07F6335A]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[food] ADD  DEFAULT (NULL) FOR [Fname]
GO
/****** Object:  Default [DF__food__Ftype__08EA5793]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[food] ADD  DEFAULT (NULL) FOR [Ftype]
GO
/****** Object:  Default [DF__food__Qty__09DE7BCC]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[food] ADD  DEFAULT (NULL) FOR [Qty]
GO
/****** Object:  Default [DF__user1__name__36B12243]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (NULL) FOR [name]
GO
/****** Object:  Default [DF__user1__mobile__37A5467C]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (NULL) FOR [mobile]
GO
/****** Object:  Default [DF__user1__email__38996AB5]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (NULL) FOR [email]
GO
/****** Object:  Default [DF__user1__pass__398D8EEE]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (NULL) FOR [pass]
GO
/****** Object:  Default [DF__bookmovie__Movie__014935CB]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[bookmovie] ADD  DEFAULT (NULL) FOR [MovieId]
GO
/****** Object:  Default [DF__bookmovie__Movie__023D5A04]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[bookmovie] ADD  DEFAULT (NULL) FOR [MovieName]
GO
/****** Object:  Default [DF__bookmovie__CustI__03317E3D]    Script Date: 02/08/2021 16:35:33 ******/
ALTER TABLE [dbo].[bookmovie] ADD  DEFAULT (NULL) FOR [CustId]
GO
