USE [nhvanxol_api]
GO
/****** Object:  Table [dbo].[tblAdvertMangas]    Script Date: 16/01/2017 17:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAdvertMangas](
	[IdAdvertManga] [int] IDENTITY(1,1) NOT NULL,
	[NameAdvertManga] [nvarchar](500) NULL,
	[DesAdvertManga] [nvarchar](4000) NULL,
	[NameAuthorAdvertManga] [nvarchar](500) NULL,
	[StatusAdvertManga] [int] NULL,
	[StatusChapAdvertManga] [int] NULL,
	[CountChapAdvertManga] [int] NULL,
	[TypeAdvertManga] [int] NULL,
	[ImgAdvertManga] [nvarchar](4000) NULL,
 CONSTRAINT [PK_dbo.tblAdvertMangas] PRIMARY KEY CLUSTERED 
(
	[IdAdvertManga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChapterMangas]    Script Date: 16/01/2017 17:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChapterMangas](
	[IdChapterManga] [int] IDENTITY(1,1) NOT NULL,
	[NameChapterManga] [nvarchar](500) NULL,
	[StatusChapterManga] [int] NULL,
	[IdAdvertManga] [int] NULL,
 CONSTRAINT [PK_tblChapterMangas] PRIMARY KEY CLUSTERED 
(
	[IdChapterManga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblImgMangas]    Script Date: 16/01/2017 17:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblImgMangas](
	[IdImgManga] [int] IDENTITY(1,1) NOT NULL,
	[ImgManga] [nvarchar](max) NULL,
	[IdChapterManga] [int] NULL,
	[IdAdvertManga] [int] NULL,
 CONSTRAINT [PK_tblImgMangas] PRIMARY KEY CLUSTERED 
(
	[IdImgManga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTypeMangas]    Script Date: 16/01/2017 17:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTypeMangas](
	[IdTypeManga] [int] IDENTITY(1,1) NOT NULL,
	[NameTypeManga] [nvarchar](500) NULL,
	[StatusTypeManga] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tblTypeMangas] PRIMARY KEY CLUSTERED 
(
	[IdTypeManga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
