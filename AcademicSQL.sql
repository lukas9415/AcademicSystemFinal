USE [master]
GO
/****** Object:  Database [academic]    Script Date: 2020-12-09 00:35:00 ******/
CREATE DATABASE [academic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'academic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\academic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'academic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\academic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [academic] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [academic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [academic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [academic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [academic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [academic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [academic] SET ARITHABORT OFF 
GO
ALTER DATABASE [academic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [academic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [academic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [academic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [academic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [academic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [academic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [academic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [academic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [academic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [academic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [academic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [academic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [academic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [academic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [academic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [academic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [academic] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [academic] SET  MULTI_USER 
GO
ALTER DATABASE [academic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [academic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [academic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [academic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [academic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [academic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [academic] SET QUERY_STORE = OFF
GO
USE [academic]
GO
/****** Object:  Table [dbo].[grade]    Script Date: 2020-12-09 00:35:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subject_id] [int] NOT NULL,
	[student_id] [int] NOT NULL,
	[grade] [int] NOT NULL,
	[group_id] [int] NOT NULL,
 CONSTRAINT [PK_grade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[groups]    Script Date: 2020-12-09 00:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groups](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_groups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 2020-12-09 00:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[group_id] [int] NOT NULL,
	[teacher_id] [int] NOT NULL,
 CONSTRAINT [PK_subject] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 2020-12-09 00:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](20) NOT NULL,
	[surname] [nvarchar](20) NOT NULL,
	[birthdate] [date] NOT NULL,
	[username] [nvarchar](40) NOT NULL,
	[password] [nvarchar](40) NOT NULL,
	[type] [nvarchar](20) NOT NULL,
	[group_id] [int] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[grade] ON 

INSERT [dbo].[grade] ([id], [subject_id], [student_id], [grade], [group_id]) VALUES (1, 1, 2, 8, 3)
SET IDENTITY_INSERT [dbo].[grade] OFF
GO
SET IDENTITY_INSERT [dbo].[groups] ON 

INSERT [dbo].[groups] ([id], [name]) VALUES (1, N'PI19A')
INSERT [dbo].[groups] ([id], [name]) VALUES (2, N'PI19B')
INSERT [dbo].[groups] ([id], [name]) VALUES (3, N'PI19D')
INSERT [dbo].[groups] ([id], [name]) VALUES (4, N'EI18')
SET IDENTITY_INSERT [dbo].[groups] OFF
GO
SET IDENTITY_INSERT [dbo].[subject] ON 

INSERT [dbo].[subject] ([id], [name], [group_id], [teacher_id]) VALUES (1, N'Duomenų Bazių Projektavimas', 3, 4)
SET IDENTITY_INSERT [dbo].[subject] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [name], [surname], [birthdate], [username], [password], [type], [group_id]) VALUES (1, N'Administrator', N'Administrator', CAST(N'2000-05-18' AS Date), N'admin', N'admin', N'Admin', NULL)
INSERT [dbo].[user] ([id], [name], [surname], [birthdate], [username], [password], [type], [group_id]) VALUES (2, N'Lukas', N'Liutkevicius', CAST(N'2000-05-18' AS Date), N'lukas9415', N'123456', N'Student', 3)
INSERT [dbo].[user] ([id], [name], [surname], [birthdate], [username], [password], [type], [group_id]) VALUES (4, N'Jonas', N'Jonauskas', CAST(N'1989-02-12' AS Date), N'jonas.jonauskas', N'123456', N'Teacher', NULL)
INSERT [dbo].[user] ([id], [name], [surname], [birthdate], [username], [password], [type], [group_id]) VALUES (23, N'Test', N'Testamovic', CAST(N'2000-12-08' AS Date), N'test.testamovic', N'testamovic', N'Student', 1)
INSERT [dbo].[user] ([id], [name], [surname], [birthdate], [username], [password], [type], [group_id]) VALUES (26, N'SAnia', N'Sedejas', CAST(N'2000-12-08' AS Date), N'sania.sedejas', N'sedejas', N'Student', 3)
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[grade]  WITH CHECK ADD  CONSTRAINT [FK_grade_groups] FOREIGN KEY([group_id])
REFERENCES [dbo].[groups] ([id])
GO
ALTER TABLE [dbo].[grade] CHECK CONSTRAINT [FK_grade_groups]
GO
ALTER TABLE [dbo].[grade]  WITH CHECK ADD  CONSTRAINT [FK_grade_subject] FOREIGN KEY([subject_id])
REFERENCES [dbo].[subject] ([id])
GO
ALTER TABLE [dbo].[grade] CHECK CONSTRAINT [FK_grade_subject]
GO
ALTER TABLE [dbo].[grade]  WITH CHECK ADD  CONSTRAINT [FK_grade_user] FOREIGN KEY([student_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[grade] CHECK CONSTRAINT [FK_grade_user]
GO
ALTER TABLE [dbo].[subject]  WITH CHECK ADD  CONSTRAINT [FK_subject_subject] FOREIGN KEY([group_id])
REFERENCES [dbo].[groups] ([id])
GO
ALTER TABLE [dbo].[subject] CHECK CONSTRAINT [FK_subject_subject]
GO
ALTER TABLE [dbo].[subject]  WITH CHECK ADD  CONSTRAINT [FK_subject_user] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[subject] CHECK CONSTRAINT [FK_subject_user]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_groups] FOREIGN KEY([group_id])
REFERENCES [dbo].[groups] ([id])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_groups]
GO
USE [master]
GO
ALTER DATABASE [academic] SET  READ_WRITE 
GO
