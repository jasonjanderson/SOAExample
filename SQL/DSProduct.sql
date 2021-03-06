USE [master]
GO
/****** Object:  Database [DSProduct]    Script Date: 9/15/2013 5:51:52 PM ******/
CREATE DATABASE [DSProduct]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DSProduct', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DSProduct.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DSProduct_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DSProduct_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DSProduct] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DSProduct].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DSProduct] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DSProduct] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DSProduct] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DSProduct] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DSProduct] SET ARITHABORT OFF 
GO
ALTER DATABASE [DSProduct] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DSProduct] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DSProduct] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DSProduct] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DSProduct] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DSProduct] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DSProduct] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DSProduct] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DSProduct] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DSProduct] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DSProduct] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DSProduct] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DSProduct] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DSProduct] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DSProduct] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DSProduct] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DSProduct] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DSProduct] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DSProduct] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DSProduct] SET  MULTI_USER 
GO
ALTER DATABASE [DSProduct] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DSProduct] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DSProduct] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DSProduct] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DSProduct]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 9/15/2013 5:51:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductNumber] [varchar](50) NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductImage]    Script Date: 9/15/2013 5:51:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductImage](
	[ProductID] [int] NOT NULL,
	[Sequence] [int] NOT NULL,
	[Image] [varchar](max) NOT NULL,
 CONSTRAINT [PK_ProductImages] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[Sequence] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [ProductNumber], [Name], [Description], [Price], [Quantity]) VALUES (1, N'ddf232', N'Flower', N'It''s a flower, dude', 19.0000, 300)
INSERT [dbo].[Product] ([ID], [ProductNumber], [Name], [Description], [Price], [Quantity]) VALUES (2, N'12345', N'Hammer', N'Hammer time', 1.5000, 20)
INSERT [dbo].[Product] ([ID], [ProductNumber], [Name], [Description], [Price], [Quantity]) VALUES (3, N'NAST32', N'Wrench', N'Wrench', 12.5000, 80)
INSERT [dbo].[Product] ([ID], [ProductNumber], [Name], [Description], [Price], [Quantity]) VALUES (4, N'UDN43332', N'Drill', N'Drills holes in stuff', 42.5000, 1)
INSERT [dbo].[Product] ([ID], [ProductNumber], [Name], [Description], [Price], [Quantity]) VALUES (5, N'OZG883', N'Kettle', N'Boils water', 30.2000, 5)
INSERT [dbo].[Product] ([ID], [ProductNumber], [Name], [Description], [Price], [Quantity]) VALUES (6, N'99823', N'Speaker', N'Plays sound', 10.0100, 9)
INSERT [dbo].[Product] ([ID], [ProductNumber], [Name], [Description], [Price], [Quantity]) VALUES (7, N'2232', N'Glass', N'Holds water', 5.0100, 400)
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[ProductImage]  WITH CHECK ADD  CONSTRAINT [FK_ProductImage_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[ProductImage] CHECK CONSTRAINT [FK_ProductImage_Product]
GO
USE [master]
GO
ALTER DATABASE [DSProduct] SET  READ_WRITE 
GO
