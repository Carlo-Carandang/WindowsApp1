USE [InClass]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 2017-10-11 12:01:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/** IDENTITY(1,1) NOT NULL  makes it auto increment primary key */

CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,  
	[firstName] [varchar](max) NULL,
	[lastName] [varchar](max) NULL,
	[streetNo] [varchar](max) NULL,
	[city] [varchar](max) NULL,
	[province] [varchar](max) NULL,
	[country] [varchar](max) NULL,
	[postalCode] [varchar](max) NULL,
	[phoneNo] [varchar](max) NULL,
	[email] [varchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
