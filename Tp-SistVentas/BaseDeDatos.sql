USE [Producto]
GO
/****** Object:  Table [dbo].[AccesorioBD]    Script Date: 11/29/2020 1:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccesorioBD](
	[AID] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Material] [nvarchar](50) NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_AccesorioBD] PRIMARY KEY CLUSTERED 
(
	[AID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrendaBD]    Script Date: 11/29/2020 1:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrendaBD](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_PrendaBD] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccesorioBD] ON 

INSERT [dbo].[AccesorioBD] ([AID], [Tipo], [Material], [Marca], [Precio], [Cantidad]) VALUES (1, N'Collar', N'Plata', N'Viceroy', 2000, 12)
INSERT [dbo].[AccesorioBD] ([AID], [Tipo], [Material], [Marca], [Precio], [Cantidad]) VALUES (2, N'Reloj', N'Oro', N'Rolex', 6800, 4)
INSERT [dbo].[AccesorioBD] ([AID], [Tipo], [Material], [Marca], [Precio], [Cantidad]) VALUES (3, N'Pulsera', N'Acero', N'Soai', 1700, 8)
SET IDENTITY_INSERT [dbo].[AccesorioBD] OFF
GO
SET IDENTITY_INSERT [dbo].[PrendaBD] ON 

INSERT [dbo].[PrendaBD] ([PID], [Tipo], [Marca], [Precio], [Cantidad]) VALUES (1, N'Remera', N'Nike', 1800, 6)
INSERT [dbo].[PrendaBD] ([PID], [Tipo], [Marca], [Precio], [Cantidad]) VALUES (2, N'Zapato', N'Adidas', 6200, 4)
INSERT [dbo].[PrendaBD] ([PID], [Tipo], [Marca], [Precio], [Cantidad]) VALUES (3, N'Pantalon', N'Puma', 1900, 8)
INSERT [dbo].[PrendaBD] ([PID], [Tipo], [Marca], [Precio], [Cantidad]) VALUES (4, N'Pantalon', N'Puma', 1900, 2)
INSERT [dbo].[PrendaBD] ([PID], [Tipo], [Marca], [Precio], [Cantidad]) VALUES (5, N'Remera', N'Puma', 1600, 5)
INSERT [dbo].[PrendaBD] ([PID], [Tipo], [Marca], [Precio], [Cantidad]) VALUES (6, N'Pantalon', N'Adidas', 1670, 2)
INSERT [dbo].[PrendaBD] ([PID], [Tipo], [Marca], [Precio], [Cantidad]) VALUES (7, N'Zapato', N'Gucci', 5793, 25)
SET IDENTITY_INSERT [dbo].[PrendaBD] OFF
GO
