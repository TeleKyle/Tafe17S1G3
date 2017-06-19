USE [master]
GO

/****** Object:  Database [Payables]    Script Date: 16-Jun-17 9:03:21 PM ******/
CREATE DATABASE [Payables]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Payables', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Payables.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Payables_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Payables_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Payables] SET COMPATIBILITY_LEVEL = 90
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Payables].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Payables] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Payables] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Payables] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Payables] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Payables] SET ARITHABORT OFF 
GO

ALTER DATABASE [Payables] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Payables] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Payables] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Payables] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Payables] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Payables] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Payables] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Payables] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Payables] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Payables] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Payables] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Payables] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Payables] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Payables] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Payables] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Payables] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Payables] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Payables] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Payables] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Payables] SET  MULTI_USER 
GO

ALTER DATABASE [Payables] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Payables] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Payables] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Payables] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Payables] SET  READ_WRITE 
GO

