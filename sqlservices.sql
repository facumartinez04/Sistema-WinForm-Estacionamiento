USE [master]
GO
/****** Object:  Database [ServicesPP]    Script Date: 22/11/2024 08:15:54 ******/
CREATE DATABASE [ServicesPP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ServicesPP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ServicesPP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ServicesPP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ServicesPP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ServicesPP] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ServicesPP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ServicesPP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ServicesPP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ServicesPP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ServicesPP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ServicesPP] SET ARITHABORT OFF 
GO
ALTER DATABASE [ServicesPP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ServicesPP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ServicesPP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ServicesPP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ServicesPP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ServicesPP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ServicesPP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ServicesPP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ServicesPP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ServicesPP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ServicesPP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ServicesPP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ServicesPP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ServicesPP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ServicesPP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ServicesPP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ServicesPP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ServicesPP] SET RECOVERY FULL 
GO
ALTER DATABASE [ServicesPP] SET  MULTI_USER 
GO
ALTER DATABASE [ServicesPP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ServicesPP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ServicesPP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ServicesPP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ServicesPP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ServicesPP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ServicesPP', N'ON'
GO
ALTER DATABASE [ServicesPP] SET QUERY_STORE = ON
GO
ALTER DATABASE [ServicesPP] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ServicesPP]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[id_bitacora] [uniqueidentifier] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[accion] [varchar](200) NOT NULL,
	[detalles] [varchar](300) NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[id_bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia](
	[IdFamilia] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Familia__751F80CFAEC6D605] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia_Familia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia_Familia](
	[IdFamilia] [uniqueidentifier] NOT NULL,
	[IdFamiliaHijo] [uniqueidentifier] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Familia___ABFCC67EA96FECF5] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdFamiliaHijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia_Patente]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia_Patente](
	[IdFamilia] [uniqueidentifier] NOT NULL,
	[IdPatente] [uniqueidentifier] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__FamiliaE__166FEEA61367E606] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente](
	[IdPatente] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[DataKey] [varchar](1000) NULL,
	[TipoAcceso] [int] NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Patente__9F4EF95C34290DD0] PRIMARY KEY CLUSTERED 
(
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [uniqueidentifier] NOT NULL,
	[UserName] [varchar](1000) NULL,
	[Password] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Usuario__5B65BF97B1F8060E] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Familia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Familia](
	[IdUsuario] [uniqueidentifier] NOT NULL,
	[IdFamilia] [uniqueidentifier] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Usuario___BC34479BE7F15ED7] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Patente]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Patente](
	[IdUsuario] [uniqueidentifier] NOT NULL,
	[IdPatente] [uniqueidentifier] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_Usuario_Patente] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'7acab003-cc81-49fe-aa0f-030db922fe94', N'facumarti06', CAST(N'2024-11-21T23:00:55.933' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'40271c90-73c7-42c6-9f19-058ef04353ab', N'facumarti06', CAST(N'2024-11-21T23:12:20.140' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'9e7d0728-f21a-4a65-8873-0db7ea99c898', N'facumarti06', CAST(N'2024-11-21T23:15:14.043' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'c4dc8f77-639b-4c45-8031-0de741c5cfe8', N'facumarti06', CAST(N'2024-11-22T08:04:41.880' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'363996a8-f806-48d7-8634-1923b23a8c82', N'facumarti06', CAST(N'2024-11-17T23:05:53.517' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'd5d6b9e4-0cd8-41ef-a090-19ebfc766f71', N'facumarti06', CAST(N'2024-11-17T22:03:39.477' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'54a7ad88-42d8-4a87-8a48-1b2c8987d140', N'facumarti06', CAST(N'2024-11-21T23:25:44.690' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'18ed4123-4423-49ff-9ede-1b7745da721b', N'facumarti06', CAST(N'2024-11-17T23:58:55.433' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'd57c6e25-81d5-4881-b8e3-1ddcb36b7ace', N'facumarti06', CAST(N'2024-11-17T22:10:20.073' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'e99be764-b981-4a64-8048-249509f54c8d', N'facumarti06', CAST(N'2024-11-18T00:08:49.207' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'3c6d7fc8-4092-44c2-bb8a-25b19c8c6644', N'facumarti06', CAST(N'2024-11-17T23:43:26.727' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'de0670ca-bf3e-4fcf-8d3b-27d5439a53f7', N'facumarti06', CAST(N'2024-11-21T23:03:01.503' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'6ae4f6f0-6c6d-4f77-bd3a-27ebd7cb8a31', N'facumarti06', CAST(N'2024-11-17T23:07:47.533' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'af702d6c-9799-4204-9030-2f54cb7bf470', N'facumarti06', CAST(N'2024-11-18T00:33:25.960' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'18532f8f-d634-4dba-9873-30132f546275', N'facumarti06', CAST(N'2024-11-21T23:15:28.080' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'd6baa71c-8220-48fc-83da-344efef047c0', N'facumarti06', CAST(N'2024-11-17T23:56:40.583' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8bb4f298-49fe-4cdc-86f9-346b19de13c3', N'facumarti06', CAST(N'2024-11-18T00:18:08.507' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'7053c352-acd2-4244-b451-38680d40e419', N'facumarti06', CAST(N'2024-11-17T23:26:11.757' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'83864d31-db9b-4a9a-84fe-3f05dba24d18', N'facumarti06', CAST(N'2024-11-17T23:46:57.537' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'abcb4211-b07b-481b-b9df-41788b75c401', N'facumarti06', CAST(N'2024-11-17T22:16:22.547' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'651ef362-4f78-43b0-b739-42554e6cd901', N'facumarti06', CAST(N'2024-11-18T00:07:28.133' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8c298b83-7950-4600-90f8-4268706a4628', N'facumarti06', CAST(N'2024-11-21T22:35:00.907' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'375e0a69-4289-4715-894c-43b366f6b27e', N'facumarti06', CAST(N'2024-11-17T21:47:01.123' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'f5fdb736-a4da-43c3-b17f-45bdc664e35c', N'facumarti06', CAST(N'2024-11-17T22:17:00.853' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'0642cc6e-8deb-4dab-802e-47c0e2ecabbc', N'facumarti06', CAST(N'2024-11-17T23:30:03.160' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'fc5a4ab1-27bf-4258-9ed7-50c93c7af0bf', N'facumarti06', CAST(N'2024-11-17T23:54:23.583' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'63514a70-2747-4517-8346-52d23f9a9209', N'facumarti06', CAST(N'2024-11-21T22:34:33.317' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'2c3c0dd3-468b-4ea4-bd2d-54f0aaa4350f', N'facumarti06', CAST(N'2024-11-18T00:09:26.750' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'abf377b8-61c1-4390-b321-567efbae419e', N'facumarti06', CAST(N'2024-11-21T22:36:03.507' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'4652a48a-3437-4696-968d-580a23543f87', N'facumarti06', CAST(N'2024-11-17T22:14:14.933' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'30a15ac9-ac86-464c-bb63-588cb2f16030', N'facumarti06', CAST(N'2024-11-17T23:49:20.843' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'2d63d247-324a-40b6-be21-5b8ad2924b22', N'facumarti06', CAST(N'2024-11-17T23:52:57.867' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'adae7559-c79d-48b7-b131-5c25f511fe82', N'facumarti06', CAST(N'2024-11-17T23:48:53.537' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'1dec6406-8228-40cc-9355-6015b624e781', N'facumarti06', CAST(N'2024-11-18T00:00:52.410' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8248133e-a76a-4916-acb0-654813b2bce9', N'facumarti06', CAST(N'2024-11-17T23:38:30.663' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'0676a566-8a5f-47d7-a030-68cefdfe23c9', N'facumarti06', CAST(N'2024-11-18T00:33:56.960' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'54dcd84b-cf0a-4e37-9a50-6a1f8eb5743a', N'facumarti06', CAST(N'2024-11-21T23:21:30.277' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'9845151f-6fd8-4952-bd0c-6de5a6550609', N'facumarti06', CAST(N'2024-11-17T22:04:55.053' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'a01afb0c-f027-4ce2-827e-701fff12e8fb', N'facumarti06', CAST(N'2024-11-17T23:02:00.050' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'd3c137b4-9512-4c08-a9d6-73fb09a596fd', N'facumarti06', CAST(N'2024-11-18T00:10:10.157' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'98c9c485-60ff-4176-b1ab-7503d0f75767', N'facumarti06', CAST(N'2024-11-17T22:12:20.900' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8bf3737f-fb64-432e-be3f-7883dd8e8bf9', N'facumarti06', CAST(N'2024-11-22T08:09:34.823' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'1279b146-8dc0-490a-aa9e-78c897f35820', N'facumarti06', CAST(N'2024-11-22T08:08:53.083' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'3a36954d-4bfd-45cc-9258-7e2a6edd69ad', N'facumarti06', CAST(N'2024-11-17T23:33:34.873' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8fdd61a5-f93a-4cd3-b362-893a4c33f5a3', N'facumarti06', CAST(N'2024-11-17T23:03:23.397' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'd0bceb6f-ee14-4363-9a74-8be5f1a9fc87', N'facumarti06', CAST(N'2024-11-17T22:01:52.663' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8a9c850c-eb60-4627-91d3-8ec7f94c9d8a', N'facumarti06', CAST(N'2024-11-21T23:01:26.937' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'6be8e4f1-f777-4175-8170-91772149057b', N'facumarti06', CAST(N'2024-11-17T22:16:15.717' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'64ee1465-810c-4ce5-99df-929da4144d9a', N'facumarti06', CAST(N'2024-11-17T23:39:16.577' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'c70029bc-b404-40d5-8a18-93c29b8e8fde', N'facumarti06', CAST(N'2024-11-21T23:18:28.287' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'6603ebf8-03e2-4b40-a2b1-9442fccf93d1', N'facumarti06', CAST(N'2024-11-21T23:23:27.960' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'07925162-34de-448f-bfd3-a03718a2d49d', N'facumarti06', CAST(N'2024-11-21T23:11:27.027' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8829467a-cd78-4c21-9ec0-a158363d5e28', N'facumarti06', CAST(N'2024-11-17T23:28:31.397' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'116112bd-3367-4154-ac98-a4d9cd0f299f', N'facumarti06', CAST(N'2024-11-18T00:32:47.467' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'36d7d829-8897-45bf-a352-a9729f19f581', N'facumarti06', CAST(N'2024-11-17T23:04:40.800' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'0f29e9df-3f64-4514-8a53-a9d1ef077b47', N'facumarti06', CAST(N'2024-11-21T23:12:42.877' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'7e6a5e04-d644-4a97-915d-acf49ab82753', N'facumarti06', CAST(N'2024-11-17T23:01:40.777' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'ac2d8e6b-341b-4a31-8bff-b13eec80488d', N'facumarti06', CAST(N'2024-11-18T00:03:27.277' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'164fc949-ead0-4c2b-a95e-b24b87910944', N'facumarti06', CAST(N'2024-11-21T23:25:03.233' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'e29e512d-9d9a-423e-a333-b3e235d02c12', N'facumarti06', CAST(N'2024-11-17T23:10:55.710' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'17f0accf-3fca-4693-9a1c-b5e743bb56f3', N'facumarti06', CAST(N'2024-11-17T23:42:06.393' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'c6b6e46f-1c0c-4b52-b802-b7bd3a0cce86', N'facumarti06', CAST(N'2024-11-18T00:41:56.403' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'0a03496a-6ae6-429d-9ed7-bc0af5b66124', N'facumarti06', CAST(N'2024-11-21T23:21:54.433' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'ac8e6798-db8e-4d43-b027-bc120df93e4b', N'facumarti06', CAST(N'2024-11-18T00:36:13.643' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'b1cbd2ca-ac1a-4dd5-b0a8-bcdaa4fd246c', N'facumarti06', CAST(N'2024-11-22T08:10:24.290' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'586f1237-e28d-4a6f-97af-bfbed64b7894', N'facumarti06', CAST(N'2024-11-21T23:04:17.470' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'854f9b42-ed78-4fbe-b686-c5b198781851', N'facumarti06', CAST(N'2024-11-17T23:31:10.727' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'56aa89ca-6ce2-4835-bd2c-cb4a88bbcd1d', N'facumarti06', CAST(N'2024-11-18T00:02:14.943' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'ae8d8ffd-d865-4dba-ae34-cfb8d5ace8ef', N'facumarti06', CAST(N'2024-11-17T23:35:58.510' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'e1bd2ef8-fc5b-4b4c-8176-d3ae6a5725c2', N'facumarti06', CAST(N'2024-11-21T23:17:43.873' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'9d77bf94-62b1-42c5-884b-d534a1d15939', N'facumarti06', CAST(N'2024-11-18T00:05:35.500' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'cc1731a5-a365-47df-b335-d634121aab53', N'facumarti06', CAST(N'2024-11-17T12:23:14.263' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'04a54f3e-f5b5-4f1c-b319-dda7e1cef626', N'facumarti06', CAST(N'2024-11-17T23:50:55.963' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'7a9068d9-3f6f-4573-86a8-e350491465e8', N'facumarti06', CAST(N'2024-11-17T23:39:41.257' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'f8f0b15e-81cb-44f6-aff5-e463aafd088d', N'facumarti06', CAST(N'2024-11-17T23:52:24.950' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'1560583a-9017-4540-b376-e6d8c5634c4d', N'facumarti06', CAST(N'2024-11-21T23:26:20.443' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'fe4d89b1-e049-44ca-9f3a-e7e0a880462e', N'facumarti06', CAST(N'2024-11-22T08:07:09.837' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'82c62c24-1f75-4e44-a0b1-f08174b1ec5c', N'facumarti06', CAST(N'2024-11-18T00:06:47.103' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'8fab8f04-96d4-40f4-88b2-f256c723ff0f', N'facumarti06', CAST(N'2024-11-17T22:05:30.493' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'84a66be6-d738-49a3-8368-f25ebd645345', N'facumarti06', CAST(N'2024-11-21T23:22:37.383' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'aaf00fa5-1c13-49e1-9edc-f45e76158ed5', N'facumarti06', CAST(N'2024-11-17T23:51:23.523' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'4e36e00a-563d-4e90-ab38-f4dc652a668d', N'facumarti06', CAST(N'2024-11-17T23:45:50.063' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'17e68938-45ff-49bb-ace1-f6bd2f85957a', N'facumarti06', CAST(N'2024-11-17T23:54:57.437' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'a8834f78-8230-4816-b2e6-fa054f5d65d8', N'facumarti06', CAST(N'2024-11-18T00:33:06.847' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'bcd62993-49c8-4c5f-b4b9-fb408af1f9f7', N'facumarti06', CAST(N'2024-11-17T23:25:06.137' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [usuario], [fecha], [accion], [detalles]) VALUES (N'2f3c7f3e-284b-41d2-833b-fb9cc31e4d64', N'facumarti06', CAST(N'2024-11-17T23:04:06.000' AS DateTime), N'El usuario facumarti06 inicio session', NULL)
GO
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'9a818c81-ba52-490c-a4c3-97f30a5db69c', N'Administrador')
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'5c6fad1a-891f-416a-a490-be42c162621d', N'Empleado')
GO
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [DataKey], [TipoAcceso]) VALUES (N'e425f724-d59f-4677-8d8f-394f66a98057', N'Menu de Facturacion', N'mnuFacturacion', 0)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [DataKey], [TipoAcceso]) VALUES (N'72228b7d-6af9-40fe-b128-b64c1d0e8df9', N'Menu de Historial', N'mnuHistorial', 0)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [DataKey], [TipoAcceso]) VALUES (N'50d4c35d-983f-4208-b736-bbf84f1673c6', N'Menu de Tarifas', N'mnuTarifas', 0)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [DataKey], [TipoAcceso]) VALUES (N'eabf9fb3-910a-488d-8a0d-c0878709e862', N'Menu de MetodosPago', N'mnuMetodosPago', 0)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [DataKey], [TipoAcceso]) VALUES (N'0f1be2a7-3d6a-49b5-ad36-c348254b2270', N'Menu de Salidas', N'mnuSalidas', 0)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [DataKey], [TipoAcceso]) VALUES (N'311f5bcc-dbdf-40d7-8ab6-df9f5e9f44b8', N'Menu de Administracion', N'mnuAdmin', 0)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [DataKey], [TipoAcceso]) VALUES (N'76b3c591-e085-4714-9697-f1fcc2880316', N'Menu de Ingresos', N'mnuIngresos', 0)
GO
INSERT [dbo].[Usuario] ([IdUsuario], [UserName], [Password]) VALUES (N'e6078174-3816-430a-962c-6c378c8e4c33', N'mahada01', N'67408264d511e4aa9ea5736565f7d7a0')
INSERT [dbo].[Usuario] ([IdUsuario], [UserName], [Password]) VALUES (N'3ff06f6e-495c-44c7-922d-fad77018a738', N'facumarti06', N'67408264d511e4aa9ea5736565f7d7a0')
GO
INSERT [dbo].[Usuario_Familia] ([IdUsuario], [IdFamilia]) VALUES (N'e6078174-3816-430a-962c-6c378c8e4c33', N'5c6fad1a-891f-416a-a490-be42c162621d')
INSERT [dbo].[Usuario_Familia] ([IdUsuario], [IdFamilia]) VALUES (N'3ff06f6e-495c-44c7-922d-fad77018a738', N'9a818c81-ba52-490c-a4c3-97f30a5db69c')
GO
INSERT [dbo].[Usuario_Patente] ([IdUsuario], [IdPatente]) VALUES (N'e6078174-3816-430a-962c-6c378c8e4c33', N'e425f724-d59f-4677-8d8f-394f66a98057')
INSERT [dbo].[Usuario_Patente] ([IdUsuario], [IdPatente]) VALUES (N'e6078174-3816-430a-962c-6c378c8e4c33', N'72228b7d-6af9-40fe-b128-b64c1d0e8df9')
INSERT [dbo].[Usuario_Patente] ([IdUsuario], [IdPatente]) VALUES (N'e6078174-3816-430a-962c-6c378c8e4c33', N'0f1be2a7-3d6a-49b5-ad36-c348254b2270')
INSERT [dbo].[Usuario_Patente] ([IdUsuario], [IdPatente]) VALUES (N'e6078174-3816-430a-962c-6c378c8e4c33', N'76b3c591-e085-4714-9697-f1fcc2880316')
INSERT [dbo].[Usuario_Patente] ([IdUsuario], [IdPatente]) VALUES (N'3ff06f6e-495c-44c7-922d-fad77018a738', N'e425f724-d59f-4677-8d8f-394f66a98057')
INSERT [dbo].[Usuario_Patente] ([IdUsuario], [IdPatente]) VALUES (N'3ff06f6e-495c-44c7-922d-fad77018a738', N'72228b7d-6af9-40fe-b128-b64c1d0e8df9')
INSERT [dbo].[Usuario_Patente] ([IdUsuario], [IdPatente]) VALUES (N'3ff06f6e-495c-44c7-922d-fad77018a738', N'50d4c35d-983f-4208-b736-bbf84f1673c6')
GO
ALTER TABLE [dbo].[Familia_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Familia_A__Famil__37A5467C] FOREIGN KEY([IdFamiliaHijo])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Familia] CHECK CONSTRAINT [FK__Familia_A__Famil__37A5467C]
GO
ALTER TABLE [dbo].[Familia_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Familia_F__IdFam__656C112C] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Familia] CHECK CONSTRAINT [FK__Familia_F__IdFam__656C112C]
GO
ALTER TABLE [dbo].[Familia_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Patente_Familia] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Patente] CHECK CONSTRAINT [FK_Familia_Patente_Familia]
GO
ALTER TABLE [dbo].[Familia_Patente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaElement_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[Familia_Patente] CHECK CONSTRAINT [FK_FamiliaElement_Patente]
GO
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario_F__IdUsu__693CA210] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK__Usuario_F__IdUsu__693CA210]
GO
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario_P__Famil__35BCFE0A] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK__Usuario_P__Famil__35BCFE0A]
GO
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Patente]
GO
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaDelete]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaDelete] (
	@IdFamilia uniqueidentifier,
	@IdFamiliaHijo uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Familia_Familia]
WHERE
	[IdFamilia] = @IdFamilia
	AND [IdFamiliaHijo] = @IdFamiliaHijo


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaDeleteByIdFamilia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaDeleteByIdFamilia] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Familia_Familia]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaDeleteByIdFamiliaHijo]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaDeleteByIdFamiliaHijo] (
	@IdFamiliaHijo uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Familia_Familia]
WHERE
	[IdFamiliaHijo] = @IdFamiliaHijo


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaInsert]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaInsert] (
	@IdFamilia uniqueidentifier,
	@IdFamiliaHijo uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

INSERT INTO [Familia_Familia] (
	[IdFamilia],
	[IdFamiliaHijo]
) VALUES (
	@IdFamilia,
	@IdFamiliaHijo
)


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaSelect]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaSelect] (
	@IdFamilia uniqueidentifier,
	@IdFamiliaHijo uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdFamiliaHijo]
FROM
	[Familia_Familia]
WHERE
	[IdFamilia] = @IdFamilia
	AND [IdFamiliaHijo] = @IdFamiliaHijo


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaSelectAll]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaSelectAll]

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdFamiliaHijo]
FROM
	[Familia_Familia]


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaSelectByIdFamilia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaSelectByIdFamilia] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdFamiliaHijo]
FROM
	[Familia_Familia]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_FamiliaSelectByIdFamiliaHijo]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_FamiliaSelectByIdFamiliaHijo] (
	@IdFamiliaHijo uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdFamiliaHijo]
FROM
	[Familia_Familia]
WHERE
	[IdFamiliaHijo] = @IdFamiliaHijo


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteDelete]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteDelete] (
	@IdFamilia uniqueidentifier,
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Familia_Patente]
WHERE
	[IdFamilia] = @IdFamilia
	AND [IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteDeleteByIdFamilia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteDeleteByIdFamilia] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Familia_Patente]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteDeleteByIdPatente]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteDeleteByIdPatente] (
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Familia_Patente]
WHERE
	[IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteInsert]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteInsert] (
	@IdFamilia uniqueidentifier,
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

INSERT INTO [Familia_Patente] (
	[IdFamilia],
	[IdPatente]
) VALUES (
	@IdFamilia,
	@IdPatente
)


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteSelect]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteSelect] (
	@IdFamilia uniqueidentifier,
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdPatente]
FROM
	[Familia_Patente]
WHERE
	[IdFamilia] = @IdFamilia
	AND [IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteSelectAll]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteSelectAll]

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdPatente]
FROM
	[Familia_Patente]


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteSelectByIdFamilia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteSelectByIdFamilia] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdPatente]
FROM
	[Familia_Patente]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Familia_PatenteSelectByIdPatente]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Familia_PatenteSelectByIdPatente] (
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[IdPatente]
FROM
	[Familia_Patente]
WHERE
	[IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[FamiliaDelete]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FamiliaDelete] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Familia]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[FamiliaInsert]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FamiliaInsert] (
	@IdFamilia uniqueidentifier,
	@Nombre varchar(1000)
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

INSERT INTO [Familia] (
	[IdFamilia],
	[Nombre]
) VALUES (
	@IdFamilia,
	@Nombre
)


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[FamiliaSelect]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FamiliaSelect] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[Nombre]
FROM
	[Familia]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[FamiliaSelectAll]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FamiliaSelectAll]

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdFamilia],
	[Nombre]
FROM
	[Familia]


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[FamiliaUpdate]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FamiliaUpdate] (
	@IdFamilia uniqueidentifier,
	@Nombre varchar(1000)
	
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

UPDATE
	[Familia]
SET
	[Nombre] = @Nombre
WHERE
	 [IdFamilia] = @IdFamilia

IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[PatenteDelete]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PatenteDelete] (
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Patente]
WHERE
	[IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[PatenteInsert]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PatenteInsert] (
	@IdPatente uniqueidentifier,
	@Nombre varchar(1000),
	@DataKey varchar(1000),
	@TipoAcceso int
	
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

INSERT INTO [Patente] (
	[IdPatente],
	[Nombre],
	[DataKey],
	[TipoAcceso]
) VALUES (
	@IdPatente,
	@Nombre,
	@DataKey,
	@TipoAcceso
)


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[PatenteSelect]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PatenteSelect] (
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdPatente],
	[Nombre],
	[DataKey],
	[TipoAcceso]
FROM
	[Patente]
WHERE
	[IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[PatenteSelectAll]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PatenteSelectAll]

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdPatente],
	[Nombre],
	[DataKey],
	[TipoAcceso]
FROM
	[Patente]


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[PatenteUpdate]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PatenteUpdate] (
	@IdPatente uniqueidentifier,
	@Nombre varchar(1000),
	@DataKey varchar(1000),
	@TipoAcceso int
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

UPDATE
	[Patente]
SET
	[Nombre] = @Nombre,
	[DataKey] = @DataKey,
	[TipoAcceso] = @TipoAcceso
WHERE
	 [IdPatente] = @IdPatente

IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaDelete]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaDelete] (
	@IdUsuario uniqueidentifier,
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Usuario_Familia]
WHERE
	[IdUsuario] = @IdUsuario
	AND [IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaDeleteByIdFamilia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaDeleteByIdFamilia] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Usuario_Familia]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaDeleteByIdUsuario]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaDeleteByIdUsuario] (
	@IdUsuario uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Usuario_Familia]
WHERE
	[IdUsuario] = @IdUsuario


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaInsert]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaInsert] (
	@IdUsuario uniqueidentifier,
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

INSERT INTO [Usuario_Familia] (
	[IdUsuario],
	[IdFamilia]
) VALUES (
	@IdUsuario,
	@IdFamilia
)


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaSelect]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaSelect] (
	@IdUsuario uniqueidentifier,
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdFamilia]
FROM
	[Usuario_Familia]
WHERE
	[IdUsuario] = @IdUsuario
	AND [IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaSelectAll]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaSelectAll]

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdFamilia]
FROM
	[Usuario_Familia]


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaSelectByIdFamilia]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaSelectByIdFamilia] (
	@IdFamilia uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdFamilia]
FROM
	[Usuario_Familia]
WHERE
	[IdFamilia] = @IdFamilia


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_FamiliaSelectByIdUsuario]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_FamiliaSelectByIdUsuario] (
	@IdUsuario uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdFamilia]
FROM
	[Usuario_Familia]
WHERE
	[IdUsuario] = @IdUsuario


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteDelete]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteDelete] (
	@IdUsuario uniqueidentifier,
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Usuario_Patente]
WHERE
	[IdUsuario] = @IdUsuario
	AND [IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteDeleteByIdPatente]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteDeleteByIdPatente] (
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Usuario_Patente]
WHERE
	[IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteDeleteByIdUsuario]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteDeleteByIdUsuario] (
	@IdUsuario uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Usuario_Patente]
WHERE
	[IdUsuario] = @IdUsuario


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteInsert]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteInsert] (
	@IdUsuario uniqueidentifier,
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

INSERT INTO [Usuario_Patente] (
	[IdUsuario],
	[IdPatente]
) VALUES (
	@IdUsuario,
	@IdPatente
)


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteSelect]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteSelect] (
	@IdUsuario uniqueidentifier,
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdPatente]
FROM
	[Usuario_Patente]
WHERE
	[IdUsuario] = @IdUsuario
	AND [IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteSelectAll]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteSelectAll]

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdPatente]
FROM
	[Usuario_Patente]


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteSelectByIdPatente]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteSelectByIdPatente] (
	@IdPatente uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdPatente]
FROM
	[Usuario_Patente]
WHERE
	[IdPatente] = @IdPatente


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[Usuario_PatenteSelectByIdUsuario]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_PatenteSelectByIdUsuario] (
	@IdUsuario uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[IdPatente]
FROM
	[Usuario_Patente]
WHERE
	[IdUsuario] = @IdUsuario


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[UsuarioDelete]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsuarioDelete] (
	@IdUsuario uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

DELETE FROM
	[Usuario]
WHERE
	[IdUsuario] = @IdUsuario


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[UsuarioInsert]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsuarioInsert] (
	@IdUsuario uniqueidentifier,
	@UserName varchar(1000),
	@Password varchar(1000)
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

INSERT INTO [Usuario] (
	[IdUsuario],
	[UserName],
	[Password]
) VALUES (
	@IdUsuario,
	@UserName,
	@Password
)


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[UsuarioSelect]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsuarioSelect] (
	@IdUsuario uniqueidentifier
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[UserName],
	[Password]
FROM
	[Usuario]
WHERE
	[IdUsuario] = @IdUsuario


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[UsuarioSelectAll]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsuarioSelectAll]

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

SELECT
	[IdUsuario],
	[UserName],
	[Password]
FROM
	[Usuario]


IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
/****** Object:  StoredProcedure [dbo].[UsuarioUpdate]    Script Date: 22/11/2024 08:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsuarioUpdate] (
	@IdUsuario uniqueidentifier,
	@UserName varchar(1000),
	@Password varchar(1000)
)

AS

SET NOCOUNT ON

DECLARE @DBID INT, @DBNAME NVARCHAR(128);
SET @DBID = DB_ID();
SET @DBNAME = DB_NAME();

UPDATE
	[Usuario]
SET
	[UserName] = @UserName,
	[Password] = @Password
WHERE
	 [IdUsuario] = @IdUsuario

IF (@@ERROR <> 0)
	RAISERROR
		(N'El ID de la base de datos actual es: %d, con el nombre: %s.', 10, 1, @DBID, @DBNAME);


GO
USE [master]
GO
ALTER DATABASE [ServicesPP] SET  READ_WRITE 
GO
