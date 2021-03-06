USE [master]
GO
/****** Object:  Database [DailyTaskDiary]    Script Date: 09.12.2019 00:38:20 ******/
CREATE DATABASE [DailyTaskDiary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DailyTaskDiary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.RADEKSQL\MSSQL\DATA\DailyTaskDiary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DailyTaskDiary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.RADEKSQL\MSSQL\DATA\DailyTaskDiary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DailyTaskDiary] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DailyTaskDiary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DailyTaskDiary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET ARITHABORT OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DailyTaskDiary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DailyTaskDiary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DailyTaskDiary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DailyTaskDiary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET RECOVERY FULL 
GO
ALTER DATABASE [DailyTaskDiary] SET  MULTI_USER 
GO
ALTER DATABASE [DailyTaskDiary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DailyTaskDiary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DailyTaskDiary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DailyTaskDiary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DailyTaskDiary] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DailyTaskDiary', N'ON'
GO
ALTER DATABASE [DailyTaskDiary] SET QUERY_STORE = OFF
GO
USE [DailyTaskDiary]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 09.12.2019 00:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[Descr] [text] NULL,
	[Importance] [nvarchar](45) NULL,
	[Date] [date] NULL,
	[UserID] [int] NULL,
	[IsDone] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09.12.2019 00:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Password] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tasks] ON 

INSERT [dbo].[Tasks] ([TaskID], [Descr], [Importance], [Date], [UserID], [IsDone]) VALUES (2, N'Kredek', N'Bardzo ważne ', CAST(N'2019-12-08' AS Date), 1, 1)
INSERT [dbo].[Tasks] ([TaskID], [Descr], [Importance], [Date], [UserID], [IsDone]) VALUES (3, N'Poscielic lozko', N'Średnio ważne', CAST(N'2019-12-06' AS Date), 1, 0)
INSERT [dbo].[Tasks] ([TaskID], [Descr], [Importance], [Date], [UserID], [IsDone]) VALUES (7, N'Nauka', N'Bardzo ważne ', CAST(N'2019-12-08' AS Date), 2, 0)
INSERT [dbo].[Tasks] ([TaskID], [Descr], [Importance], [Date], [UserID], [IsDone]) VALUES (8, N'Nauka', N'Ważne', CAST(N'2019-12-08' AS Date), 1, 0)
INSERT [dbo].[Tasks] ([TaskID], [Descr], [Importance], [Date], [UserID], [IsDone]) VALUES (9, N'Posprzatac', N'Ważne', CAST(N'2019-12-08' AS Date), 1, 0)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Name], [Password]) VALUES (1, N'Radek', N'Kredek2019')
INSERT [dbo].[Users] ([UserID], [Name], [Password]) VALUES (2, N'default', N'aaa')
INSERT [dbo].[Users] ([UserID], [Name], [Password]) VALUES (3, N'Test', N'tester')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
USE [master]
GO
ALTER DATABASE [DailyTaskDiary] SET  READ_WRITE 
GO
