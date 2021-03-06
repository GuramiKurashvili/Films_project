USE [master]
GO
/****** Object:  Database [Films_db]    Script Date: 21-Jan-19 19:34:29 ******/
CREATE DATABASE [Films_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Films_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Films_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Films_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Films_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Films_db] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Films_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Films_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Films_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Films_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Films_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Films_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [Films_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Films_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Films_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Films_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Films_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Films_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Films_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Films_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Films_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Films_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Films_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Films_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Films_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Films_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Films_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Films_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Films_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Films_db] SET RECOVERY FULL 
GO
ALTER DATABASE [Films_db] SET  MULTI_USER 
GO
ALTER DATABASE [Films_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Films_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Films_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Films_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Films_db] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Films_db', N'ON'
GO
ALTER DATABASE [Films_db] SET QUERY_STORE = OFF
GO
USE [Films_db]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 21-Jan-19 19:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[Text] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Films]    Script Date: 21-Jan-19 19:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Films](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Mark] [nvarchar](50) NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 21-Jan-19 19:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Admin] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Feedbacks] ON 

INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (1, 1, N'sssss', NULL)
INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (2, 1, N'ssssss', NULL)
INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (3, 1, N'sdasdadsa', NULL)
INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (4, 1, N'cccc', NULL)
INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (5, 1, N'ccccc', NULL)
INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (6, 1, N'cccccccccccccccccccccccc', NULL)
INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (7, 1, N'ccccccccccc', N'cc')
INSERT [dbo].[Feedbacks] ([ID], [UserID], [Text], [UserName]) VALUES (8, 1, N'ccccccasfasfasfsafasfsaf', N'cc')
SET IDENTITY_INSERT [dbo].[Feedbacks] OFF
SET IDENTITY_INSERT [dbo].[Films] ON 

INSERT [dbo].[Films] ([ID], [Name], [Mark], [Genre]) VALUES (1, N'Interstelar', N'9.6', N'Science')
INSERT [dbo].[Films] ([ID], [Name], [Mark], [Genre]) VALUES (2, N'Father of soldier', N'10', N'drama')
INSERT [dbo].[Films] ([ID], [Name], [Mark], [Genre]) VALUES (12, N'Avatar', N'9.4', N'Sciency-fantasy')
INSERT [dbo].[Films] ([ID], [Name], [Mark], [Genre]) VALUES (13, N'Hollywood jobs', N'8.3', N'drama')
INSERT [dbo].[Films] ([ID], [Name], [Mark], [Genre]) VALUES (14, N'127 hours', N'9.0', N'Adventure')
INSERT [dbo].[Films] ([ID], [Name], [Mark], [Genre]) VALUES (15, N'Best offer', N'9.3', N'Melodrama')
SET IDENTITY_INSERT [dbo].[Films] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Name], [Password], [Admin]) VALUES (1, N'root', N'1234', 1)
INSERT [dbo].[Users] ([ID], [Name], [Password], [Admin]) VALUES (2, N'cc', N'cc', NULL)
INSERT [dbo].[Users] ([ID], [Name], [Password], [Admin]) VALUES (3, N'ccc', N'ccc', NULL)
INSERT [dbo].[Users] ([ID], [Name], [Password], [Admin]) VALUES (4, N'cccc', N'cc', NULL)
INSERT [dbo].[Users] ([ID], [Name], [Password], [Admin]) VALUES (5, N'1111', N'111', NULL)
INSERT [dbo].[Users] ([ID], [Name], [Password], [Admin]) VALUES (6, N'zzzz', N'zzz', NULL)
INSERT [dbo].[Users] ([ID], [Name], [Password], [Admin]) VALUES (7, N'', N'', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Admin]  DEFAULT ((0)) FOR [Admin]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_Feedbacks_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_Feedbacks_Users]
GO
USE [master]
GO
ALTER DATABASE [Films_db] SET  READ_WRITE 
GO
