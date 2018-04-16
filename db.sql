USE [master]
GO

/****** Object:  Database [DBCustomerTest]    Script Date: 4/16/2018 4:14:46 PM ******/
CREATE DATABASE [DBCustomerTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBCustomerTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DBCustomerTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBCustomerTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DBCustomerTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [DBCustomerTest] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBCustomerTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DBCustomerTest] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DBCustomerTest] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DBCustomerTest] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DBCustomerTest] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DBCustomerTest] SET ARITHABORT OFF 
GO

ALTER DATABASE [DBCustomerTest] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DBCustomerTest] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DBCustomerTest] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DBCustomerTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DBCustomerTest] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DBCustomerTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DBCustomerTest] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DBCustomerTest] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DBCustomerTest] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DBCustomerTest] SET  DISABLE_BROKER 
GO

ALTER DATABASE [DBCustomerTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DBCustomerTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DBCustomerTest] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DBCustomerTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DBCustomerTest] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DBCustomerTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [DBCustomerTest] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DBCustomerTest] SET RECOVERY FULL 
GO

ALTER DATABASE [DBCustomerTest] SET  MULTI_USER 
GO

ALTER DATABASE [DBCustomerTest] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DBCustomerTest] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DBCustomerTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DBCustomerTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [DBCustomerTest] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DBCustomerTest] SET QUERY_STORE = OFF
GO

USE [DBCustomerTest]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [DBCustomerTest] SET  READ_WRITE 
GO


