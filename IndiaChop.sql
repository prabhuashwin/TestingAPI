USE [master]
GO
/****** Object:  Database [IndianChopstix]    Script Date: 2016-08-20 15:18:47 ******/
CREATE DATABASE [IndianChopstix]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IndianChopstix', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\IndianChopstix.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IndianChopstix_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\IndianChopstix_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IndianChopstix] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IndianChopstix].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IndianChopstix] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IndianChopstix] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IndianChopstix] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IndianChopstix] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IndianChopstix] SET ARITHABORT OFF 
GO
ALTER DATABASE [IndianChopstix] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IndianChopstix] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [IndianChopstix] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IndianChopstix] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IndianChopstix] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IndianChopstix] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IndianChopstix] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IndianChopstix] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IndianChopstix] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IndianChopstix] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IndianChopstix] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IndianChopstix] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IndianChopstix] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IndianChopstix] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IndianChopstix] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IndianChopstix] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IndianChopstix] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IndianChopstix] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IndianChopstix] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IndianChopstix] SET  MULTI_USER 
GO
ALTER DATABASE [IndianChopstix] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IndianChopstix] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IndianChopstix] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IndianChopstix] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [IndianChopstix]
GO
/****** Object:  Table [dbo].[UserInformation]    Script Date: 2016-08-20 15:18:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInformation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmailId] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[APNSToken] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[UserType] [int] NULL,
 CONSTRAINT [PK_UserInformation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[UserInformation] ON 

INSERT [dbo].[UserInformation] ([Id], [EmailId], [Password], [APNSToken], [Name], [PhoneNumber], [City], [CreatedDateTime], [UserType]) VALUES (1, N'abc@abc.com', N'test@123', NULL, N'NewUser', N'9741416655', N'Bangalore', NULL, 1)
INSERT [dbo].[UserInformation] ([Id], [EmailId], [Password], [APNSToken], [Name], [PhoneNumber], [City], [CreatedDateTime], [UserType]) VALUES (2, N'test@123.com', NULL, N'c39c90479a8aa55d10aee648649b9c4099ec5fc06efa616979fbf84093d3c5e5', N'First User', N'9741416655', N'Mysore', NULL, NULL)
SET IDENTITY_INSERT [dbo].[UserInformation] OFF
USE [master]
GO
ALTER DATABASE [IndianChopstix] SET  READ_WRITE 
GO
