USE [master]
GO
/****** Object:  Database [DBEstacionamiento]    Script Date: 15/11/2024 18:00:11 ******/
CREATE DATABASE [DBEstacionamiento]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBEstacionamiento', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBEstacionamiento.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBEstacionamiento_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBEstacionamiento_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBEstacionamiento] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBEstacionamiento].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBEstacionamiento] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBEstacionamiento] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBEstacionamiento] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET RECOVERY FULL 
GO
ALTER DATABASE [DBEstacionamiento] SET  MULTI_USER 
GO
ALTER DATABASE [DBEstacionamiento] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBEstacionamiento] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBEstacionamiento] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBEstacionamiento] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBEstacionamiento] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBEstacionamiento] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBEstacionamiento', N'ON'
GO
ALTER DATABASE [DBEstacionamiento] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBEstacionamiento] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBEstacionamiento]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [uniqueidentifier] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[dni] [int] NULL,
	[fecha_nacimiento] [date] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[idRol] [int] NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[dni] [int] NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[email] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[idIngreso] [uniqueidentifier] NOT NULL,
	[idMetodoPago] [int] NOT NULL,
	[monto_total] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingreso](
	[idIngreso] [uniqueidentifier] NOT NULL,
	[idVehiculo] [uniqueidentifier] NOT NULL,
	[idCliente] [uniqueidentifier] NULL,
	[FechaHorario_Ingreso] [datetime] NOT NULL,
	[FechaHorario_Salida] [datetime] NULL,
	[idTipoTarifa] [int] NOT NULL,
	[estado] [varchar](20) NULL,
 CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED 
(
	[idIngreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetodoPago]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodoPago](
	[idMetodoPago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MetodoPago] PRIMARY KEY CLUSTERED 
(
	[idMetodoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL,
	[idMetodoPago] [int] NOT NULL,
	[monto_total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Pago] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTarifa]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTarifa](
	[idTipoTarifa] [int] IDENTITY(1,1) NOT NULL,
	[monto_por_hora] [decimal](18, 0) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoTarifa] PRIMARY KEY CLUSTERED 
(
	[idTipoTarifa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] NOT NULL,
	[clave] [varchar](250) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[tokenRestablecimiento] [varchar](50) NULL,
	[fechaRestablecimiento] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 15/11/2024 18:00:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[idVehiculo] [uniqueidentifier] NOT NULL,
	[patente] [varchar](15) NOT NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[idVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'e4d03bdd-f072-437c-9723-10236f85e206', N'9bf016a2-5363-474b-a3ba-0d70a9bc9231', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-13T17:11:40.257' AS DateTime), CAST(N'2024-11-13T17:11:47.463' AS DateTime), 1, NULL)
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'8fe7323b-2c2a-4a1f-9631-2d0822a92dfd', N'1a16bc74-b6f4-47a7-aa92-c241b6e25d4b', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-11T16:22:35.470' AS DateTime), CAST(N'2024-11-13T10:43:52.373' AS DateTime), 2, NULL)
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'c4016692-6196-4edb-a934-53354ee65f63', N'6678768b-47d6-43f1-aad8-ff8d94c3a497', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-11T13:58:19.350' AS DateTime), CAST(N'2024-11-13T10:46:45.240' AS DateTime), 1, NULL)
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'aedaf4a9-6f92-40b2-8410-677d46b6c041', N'6678768b-47d6-43f1-aad8-ff8d94c3a497', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-13T23:20:45.680' AS DateTime), CAST(N'2024-11-13T23:20:51.810' AS DateTime), 1, NULL)
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'bddfd1f4-d53b-45cb-8184-7334edce7a9c', N'6678768b-47d6-43f1-aad8-ff8d94c3a497', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-14T12:42:09.630' AS DateTime), NULL, 1, NULL)
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'e04bece4-7c35-49f3-8c1c-9032a0c194fc', N'6678768b-47d6-43f1-aad8-ff8d94c3a497', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-13T16:58:38.880' AS DateTime), CAST(N'2024-11-13T16:59:15.340' AS DateTime), 1, NULL)
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'a8cae32d-0531-4a50-aaeb-cddf8742e757', N'6347f92a-5829-45c4-9116-227b6dd147c4', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-14T16:18:14.367' AS DateTime), NULL, 1, NULL)
INSERT [dbo].[Ingreso] ([idIngreso], [idVehiculo], [idCliente], [FechaHorario_Ingreso], [FechaHorario_Salida], [idTipoTarifa], [estado]) VALUES (N'ede3926a-45a8-44f4-b457-e29cd1fc8708', N'6678768b-47d6-43f1-aad8-ff8d94c3a497', N'00000000-0000-0000-0000-000000000000', CAST(N'2024-11-13T17:05:10.420' AS DateTime), CAST(N'2024-11-13T18:03:29.890' AS DateTime), 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[MetodoPago] ON 

INSERT [dbo].[MetodoPago] ([idMetodoPago], [descripcion]) VALUES (1, N'Efectivo')
INSERT [dbo].[MetodoPago] ([idMetodoPago], [descripcion]) VALUES (2, N'Mercado Pago')
SET IDENTITY_INSERT [dbo].[MetodoPago] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoTarifa] ON 

INSERT [dbo].[TipoTarifa] ([idTipoTarifa], [monto_por_hora], [descripcion]) VALUES (1, CAST(12502 AS Decimal(18, 0)), N'Automovil')
INSERT [dbo].[TipoTarifa] ([idTipoTarifa], [monto_por_hora], [descripcion]) VALUES (2, CAST(3500 AS Decimal(18, 0)), N'Moto')
SET IDENTITY_INSERT [dbo].[TipoTarifa] OFF
GO
INSERT [dbo].[Vehiculo] ([idVehiculo], [patente], [marca], [modelo]) VALUES (N'9bf016a2-5363-474b-a3ba-0d70a9bc9231', N'ASDDAS123', NULL, NULL)
INSERT [dbo].[Vehiculo] ([idVehiculo], [patente], [marca], [modelo]) VALUES (N'6347f92a-5829-45c4-9116-227b6dd147c4', N'IIH532', NULL, NULL)
INSERT [dbo].[Vehiculo] ([idVehiculo], [patente], [marca], [modelo]) VALUES (N'b26fd971-7b57-4c57-a7e2-41b523da1e16', N'asd123', NULL, NULL)
INSERT [dbo].[Vehiculo] ([idVehiculo], [patente], [marca], [modelo]) VALUES (N'19e1e05c-194e-4aa4-8b37-4463e515b52d', N'', NULL, NULL)
INSERT [dbo].[Vehiculo] ([idVehiculo], [patente], [marca], [modelo]) VALUES (N'1a16bc74-b6f4-47a7-aa92-c241b6e25d4b', N'ASDD1234', NULL, NULL)
INSERT [dbo].[Vehiculo] ([idVehiculo], [patente], [marca], [modelo]) VALUES (N'6678768b-47d6-43f1-aad8-ff8d94c3a497', N'ASD123', NULL, NULL)
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Rol]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
USE [master]
GO
ALTER DATABASE [DBEstacionamiento] SET  READ_WRITE 
GO
