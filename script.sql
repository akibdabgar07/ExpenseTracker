USE [master]
GO
/****** Object:  Database [ExpenseTracker]    Script Date: 10-01-2023 23:01:23 ******/
CREATE DATABASE [ExpenseTracker]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExpenseTracker', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ExpenseTracker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ExpenseTracker_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ExpenseTracker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ExpenseTracker] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExpenseTracker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExpenseTracker] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExpenseTracker] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExpenseTracker] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExpenseTracker] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExpenseTracker] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExpenseTracker] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ExpenseTracker] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExpenseTracker] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExpenseTracker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExpenseTracker] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExpenseTracker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExpenseTracker] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExpenseTracker] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExpenseTracker] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExpenseTracker] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ExpenseTracker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExpenseTracker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExpenseTracker] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExpenseTracker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExpenseTracker] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExpenseTracker] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ExpenseTracker] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExpenseTracker] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ExpenseTracker] SET  MULTI_USER 
GO
ALTER DATABASE [ExpenseTracker] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExpenseTracker] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExpenseTracker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExpenseTracker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ExpenseTracker] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ExpenseTracker] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ExpenseTracker] SET QUERY_STORE = OFF
GO
USE [ExpenseTracker]
GO
/****** Object:  Table [dbo].[Adding_Categories]    Script Date: 10-01-2023 23:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adding_Categories](
	[Category] [varchar](50) NOT NULL,
	[Category_Expense_Limit] [bigint] NOT NULL,
 CONSTRAINT [PK_Adding_Categories] PRIMARY KEY CLUSTERED 
(
	[Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adding_Expenses]    Script Date: 10-01-2023 23:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adding_Expenses](
	[E_Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Date_Time] [datetime] NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Amount] [bigint] NOT NULL,
 CONSTRAINT [PK_Adding_Expenses] PRIMARY KEY CLUSTERED 
(
	[E_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expense_Limit]    Script Date: 10-01-2023 23:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense_Limit](
	[Total_Expense_Limit] [bigint] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Adding_Categories] ([Category], [Category_Expense_Limit]) VALUES (N'Bank Fees', 2000)
INSERT [dbo].[Adding_Categories] ([Category], [Category_Expense_Limit]) VALUES (N'Clothing', 7050)
INSERT [dbo].[Adding_Categories] ([Category], [Category_Expense_Limit]) VALUES (N'Education Training', 15000)
INSERT [dbo].[Adding_Categories] ([Category], [Category_Expense_Limit]) VALUES (N'electronics', 11000)
INSERT [dbo].[Adding_Categories] ([Category], [Category_Expense_Limit]) VALUES (N'food', 6000)
INSERT [dbo].[Adding_Categories] ([Category], [Category_Expense_Limit]) VALUES (N'travel', 4000)
GO
SET IDENTITY_INSERT [dbo].[Adding_Expenses] ON 

INSERT [dbo].[Adding_Expenses] ([E_Id], [Title], [Description], [Date_Time], [Category], [Amount]) VALUES (12, N'Aloo Tikki', N'delicious', CAST(N'2023-01-08T10:09:47.117' AS DateTime), N'food', 1500)
INSERT [dbo].[Adding_Expenses] ([E_Id], [Title], [Description], [Date_Time], [Category], [Amount]) VALUES (13, N'LED TV', N'samsungled tv', CAST(N'2023-01-08T10:12:30.353' AS DateTime), N'electronics', 8000)
INSERT [dbo].[Adding_Expenses] ([E_Id], [Title], [Description], [Date_Time], [Category], [Amount]) VALUES (16, N'Chhole Bhature	', N'full dishes', CAST(N'2023-01-10T11:30:03.293' AS DateTime), N'food', 500)
INSERT [dbo].[Adding_Expenses] ([E_Id], [Title], [Description], [Date_Time], [Category], [Amount]) VALUES (19, N'Atm Withdrawal bank fees', N'transaction', CAST(N'2023-01-10T20:49:24.050' AS DateTime), N'Bank Fees', 500)
SET IDENTITY_INSERT [dbo].[Adding_Expenses] OFF
GO
INSERT [dbo].[Expense_Limit] ([Total_Expense_Limit]) VALUES (50000)
GO
ALTER TABLE [dbo].[Adding_Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Adding_Expenses_Adding_Categories] FOREIGN KEY([Category])
REFERENCES [dbo].[Adding_Categories] ([Category])
GO
ALTER TABLE [dbo].[Adding_Expenses] CHECK CONSTRAINT [FK_Adding_Expenses_Adding_Categories]
GO
USE [master]
GO
ALTER DATABASE [ExpenseTracker] SET  READ_WRITE 
GO
