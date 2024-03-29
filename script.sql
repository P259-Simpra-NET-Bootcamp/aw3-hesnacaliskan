USE [SimpraHw3Db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27.05.2023 19:31:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 27.05.2023 19:31:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Order] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 27.05.2023 19:31:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Url] [nvarchar](max) NOT NULL,
	[Tag] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230526183422_mig_1', N'6.0.16')
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Order]) VALUES (1, CAST(N'2023-05-26T22:08:12.6853338' AS DateTime2), N'Hesna', CAST(N'2023-05-26T22:08:12.6847270' AS DateTime2), N'Hesna', N'Mobilya', 1)
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Order]) VALUES (4, CAST(N'2023-05-26T22:09:01.4457847' AS DateTime2), N'Hesna', CAST(N'2023-05-26T22:09:01.4457844' AS DateTime2), N'Hesna', N'Küçük Ev Aletleri', 2)
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Order]) VALUES (5, CAST(N'2023-05-26T21:41:00.8527280' AS DateTime2), N'Hüda', CAST(N'2023-05-26T21:41:00.8532851' AS DateTime2), N'Hüda', N'Büyük Ev Aletleri', 3)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [CategoryId], [Name], [Url], [Tag]) VALUES (1, NULL, N'Hesna', NULL, N'Hesna', 1, N'Kitaplık', N'https://www.ikea.com.tr/urun/billy-oxberg-beyaz-80x30x202-cm-cam-kapakli-kitaplik-69017828', N'kitaplık')
INSERT [dbo].[Product] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [CategoryId], [Name], [Url], [Tag]) VALUES (2, NULL, N'Hesna', NULL, N'Hesna', 1, N'Çalışma Masası', N'https://www.ikea.com.tr/urun/trotten-beyaz-160x80-cm-yuksekligi-ayarlanabilen-calisma-masasi-79429602', N'masa')
INSERT [dbo].[Product] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [CategoryId], [Name], [Url], [Tag]) VALUES (3, CAST(N'2023-05-26T21:51:29.9921946' AS DateTime2), N'Hüda', CAST(N'2023-05-26T21:51:29.9927523' AS DateTime2), N'Hüda', 5, N'Çamaşır Makinesi', N'https://www.mediamarkt.com.tr/tr/product/_bosch-wga142x1tr-c-enerji-s%C4%B1n%C4%B1f%C4%B1-9kg-13-program-say%C4%B1s%C4%B1-1200-%C3%A7ama%C5%9F%C4%B1r-makinesi-1214251.html', N'çamaşır makinesi')
INSERT [dbo].[Product] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [CategoryId], [Name], [Url], [Tag]) VALUES (4, CAST(N'2023-05-26T22:11:28.5830121' AS DateTime2), N'Seha', CAST(N'2023-05-26T22:11:28.5830099' AS DateTime2), N'Seha', 5, N'Buzdolabı', N'https://www.mediamarkt.com.tr/tr/product/_altus-alk-471-x-e-enerji-s%C4%B1n%C4%B1f%C4%B1-514l-alttan-donduruculu-buzdolab%C4%B1-beyaz-1214701.html', N'buzdolabı')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category_CategoryId]
GO
