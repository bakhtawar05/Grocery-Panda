USE [master]
GO
/****** Object:  Database [Grocery]    Script Date: 12/5/2018 12:49:38 PM ******/
CREATE DATABASE [Grocery]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Grocery', FILENAME = N'D:\Program Files\MSSQL12.SQLEXPRESS\MSSQL\DATA\Grocery.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Grocery_log', FILENAME = N'D:\Program Files\MSSQL12.SQLEXPRESS\MSSQL\DATA\Grocery_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Grocery] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Grocery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Grocery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Grocery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Grocery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Grocery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Grocery] SET ARITHABORT OFF 
GO
ALTER DATABASE [Grocery] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Grocery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Grocery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Grocery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Grocery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Grocery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Grocery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Grocery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Grocery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Grocery] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Grocery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Grocery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Grocery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Grocery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Grocery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Grocery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Grocery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Grocery] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Grocery] SET  MULTI_USER 
GO
ALTER DATABASE [Grocery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Grocery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Grocery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Grocery] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Grocery] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Grocery]
GO
/****** Object:  Table [dbo].[adminbd]    Script Date: 12/5/2018 12:49:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adminbd](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NULL,
	[password] [nchar](50) NULL,
	[contact] [int] NULL,
	[address] [nchar](50) NULL,
	[storeName] [nchar](50) NULL,
 CONSTRAINT [PK_adminbd] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/5/2018 12:49:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nchar](250) NULL,
	[CustomerName] [nchar](250) NULL,
	[Pasword] [nchar](250) NULL,
	[Phone_] [int] NULL,
	[city] [nchar](250) NULL,
	[address] [nchar](250) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Image]    Script Date: 12/5/2018 12:49:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Image](
	[ImageId] [nchar](10) NOT NULL,
	[ImagePath] [varchar](max) NULL,
	[Title] [varchar](50) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/5/2018 12:49:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[quantity] [int] NULL,
	[price] [int] NULL,
	[image] [varchar](max) NULL,
	[category] [varchar](100) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [Grocery] SET  READ_WRITE 
GO
