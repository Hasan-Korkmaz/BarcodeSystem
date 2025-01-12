USE [master]
GO
/****** Object:  Database [BarcodeSystem]    Script Date: 31.08.2019 20:52:38 ******/
CREATE DATABASE [BarcodeSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BarcodeSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BarcodeSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BarcodeSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BarcodeSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BarcodeSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BarcodeSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BarcodeSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BarcodeSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BarcodeSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BarcodeSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BarcodeSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [BarcodeSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BarcodeSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BarcodeSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BarcodeSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BarcodeSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BarcodeSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BarcodeSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BarcodeSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BarcodeSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BarcodeSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BarcodeSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BarcodeSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BarcodeSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BarcodeSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BarcodeSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BarcodeSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BarcodeSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BarcodeSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BarcodeSystem] SET  MULTI_USER 
GO
ALTER DATABASE [BarcodeSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BarcodeSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BarcodeSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BarcodeSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BarcodeSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BarcodeSystem] SET QUERY_STORE = OFF
GO
USE [BarcodeSystem]
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
USE [BarcodeSystem]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](150) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerProcces]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerProcces](
	[CustomerProccesID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ProccesType] [int] NOT NULL,
	[ProccesPrice] [decimal](18, 2) NOT NULL,
	[ProccesDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_CustomerProcces] PRIMARY KEY CLUSTERED 
(
	[CustomerProccesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[CustomerSurname] [nvarchar](50) NULL,
	[CustomerAddress] [nvarchar](400) NULL,
	[CustomerTelephone] [nvarchar](15) NULL,
	[CustomerOccupotion] [nvarchar](150) NULL,
	[CustomerDetails] [nvarchar](400) NULL,
	[CustomerRegistrationDate] [date] NULL,
	[isActive] [bit] NULL,
	[CustomerReference] [int] NULL,
	[CustomerAccount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationProduct]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationProduct](
	[OperationID] [int] IDENTITY(1,1) NOT NULL,
	[SaleProduct] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[ProductPrice] [decimal](18, 2) NOT NULL,
	[ProductDiscount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_OperationProduct] PRIMARY KEY CLUSTERED 
(
	[OperationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[PaymentMethodID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentMethodName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[PaymentMethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProccesList]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProccesList](
	[ProccesID] [int] IDENTITY(1,1) NOT NULL,
	[ProccesType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProccesList] PRIMARY KEY CLUSTERED 
(
	[ProccesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductBarcode] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](150) NULL,
	[ProductCategorie] [int] NULL,
	[ProductSalePrice] [decimal](18, 2) NULL,
	[ProductDescription] [nvarchar](400) NULL,
	[isActive] [bit] NULL,
	[ProductPiece] [bigint] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefCustomer]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefCustomer](
	[RefCustomerID] [int] NOT NULL,
	[RefCustomerName] [nvarchar](150) NULL,
	[RefCustomerSurname] [nvarchar](150) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_RefCustomer] PRIMARY KEY CLUSTERED 
(
	[RefCustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[SaleDate] [smalldatetime] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[CustomerID] [int] NULL,
	[TotalDiscount] [decimal](18, 2) NULL,
	[PaymentMethodSale] [int] NOT NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 31.08.2019 20:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Piece] [int] NOT NULL,
	[StockEntryDate] [date] NULL,
	[ProductManufacturer] [nvarchar](150) NULL,
	[PurchasePrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerProcces]  WITH CHECK ADD  CONSTRAINT [FK_CustomerProcces_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[CustomerProcces] CHECK CONSTRAINT [FK_CustomerProcces_Customers]
GO
ALTER TABLE [dbo].[CustomerProcces]  WITH CHECK ADD  CONSTRAINT [FK_CustomerProcces_ProccesList] FOREIGN KEY([ProccesType])
REFERENCES [dbo].[ProccesList] ([ProccesID])
GO
ALTER TABLE [dbo].[CustomerProcces] CHECK CONSTRAINT [FK_CustomerProcces_ProccesList]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_RefCustomer] FOREIGN KEY([CustomerReference])
REFERENCES [dbo].[RefCustomer] ([RefCustomerID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_RefCustomer]
GO
ALTER TABLE [dbo].[OperationProduct]  WITH CHECK ADD  CONSTRAINT [FK_OperationProduct_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OperationProduct] CHECK CONSTRAINT [FK_OperationProduct_Products]
GO
ALTER TABLE [dbo].[OperationProduct]  WITH CHECK ADD  CONSTRAINT [FK_OperationProduct_Sale] FOREIGN KEY([SaleProduct])
REFERENCES [dbo].[Sale] ([SaleID])
GO
ALTER TABLE [dbo].[OperationProduct] CHECK CONSTRAINT [FK_OperationProduct_Sale]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([ProductCategorie])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Customers1] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Customers1]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_PaymentMethod] FOREIGN KEY([PaymentMethodSale])
REFERENCES [dbo].[PaymentMethod] ([PaymentMethodID])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_PaymentMethod]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Products]
GO
USE [master]
GO
ALTER DATABASE [BarcodeSystem] SET  READ_WRITE 
GO
