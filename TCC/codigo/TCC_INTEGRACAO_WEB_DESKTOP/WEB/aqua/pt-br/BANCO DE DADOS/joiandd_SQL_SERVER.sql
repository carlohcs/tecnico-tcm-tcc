USE [joiandd]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[COD_CTG] [int] IDENTITY(1,1) NOT NULL,
	[TIT_CTG] [nvarchar](20) NOT NULL,
	[FLAG_MEN] [smallint] NOT NULL,
 CONSTRAINT [categoria_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_CTG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assunto_contato]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assunto_contato](
	[COD_ASSUNTO] [int] IDENTITY(1,1) NOT NULL,
	[DESC_ASSUNTO] [nvarchar](10) NULL,
 CONSTRAINT [assunto_contato_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_ASSUNTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estados]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estados](
	[COD_ESTADO] [int] IDENTITY(1,1) NOT NULL,
	[DESC_ESTADO] [varchar](30) NOT NULL,
	[SIGL_ESTADO] [nvarchar](2) NOT NULL,
 CONSTRAINT [estados_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_ESTADO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[enquete]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[enquete](
	[COD_ENQ] [int] IDENTITY(1,1) NOT NULL,
	[TIT_ENQ] [nvarchar](50) NOT NULL,
	[DT_ENQ] [datetime] NOT NULL,
	[ITN1_ENQ] [nvarchar](20) NULL,
	[ITN2_ENQ] [nvarchar](20) NULL,
	[ITN3_ENQ] [nvarchar](20) NULL,
	[ITN4_ENQ] [nvarchar](20) NULL,
	[PCT_ITN1_ENQ] [int] NULL,
	[PCT_ITN2_ENQ] [int] NULL,
	[PCT_ITN3_ENQ] [int] NULL,
	[PCT_ITN4_ENQ] [int] NULL,
	[FLAG_ENQ_FIN] [smallint] NULL,
 CONSTRAINT [enquete_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_ENQ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[destaque]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[destaque](
	[COD_DEST] [int] IDENTITY(1,1) NOT NULL,
	[TIT_DEST] [varchar](24) NOT NULL,
	[TXT_DEST] [varchar](500) NULL,
	[LINK_DEST] [varchar](100) NOT NULL,
	[DT_DEST] [datetime] NOT NULL,
	[HR_DEST] [datetime] NOT NULL,
	[FLAG_IMG_DEST] [smallint] NOT NULL,
	[FLAG_VID_DEST] [smallint] NOT NULL,
	[FLAG_ANLS_DEST] [smallint] NOT NULL,
	[PATH_IMG_INI_DEST] [varchar](100) NOT NULL,
	[PATH_IMG1_DEST] [varchar](100) NULL,
	[PATH_IMG2_DEST] [varchar](100) NULL,
	[PATH_IMG3_DEST] [varchar](100) NULL,
	[PATH_IMG4_DEST] [varchar](100) NULL,
	[PATH_IMG5_DEST] [varchar](100) NULL,
	[PATH_IMG6_DEST] [varchar](100) NULL,
	[PATH_IMG7_DEST] [varchar](100) NULL,
	[PATH_IMG8_DEST] [varchar](100) NULL,
	[PATH_IMG9_DEST] [varchar](100) NULL,
	[LINK1_VID_DEST] [varchar](100) NULL,
	[LINK2_VID_DEST] [varchar](100) NULL,
	[LINK3_VID_DEST] [varchar](100) NULL,
	[LINK4_VID_DEST] [varchar](100) NULL,
 CONSTRAINT [destaque_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_DEST] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[titulo_usuario]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[titulo_usuario](
	[COD_TIT] [int] IDENTITY(1,1) NOT NULL,
	[DESC_TIT] [nvarchar](15) NOT NULL,
 CONSTRAINT [titulo_usuario_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_TIT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sexo]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sexo](
	[COD_SEX] [int] IDENTITY(1,1) NOT NULL,
	[DESC_SEX] [nvarchar](10) NULL,
 CONSTRAINT [sexo_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_SEX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[publicidade_top]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[publicidade_top](
	[COD_PUB] [int] IDENTITY(1,1) NOT NULL,
	[TIT_PUB] [varchar](30) NOT NULL,
	[EMP_PUB] [varchar](30) NOT NULL,
	[DT_PUB] [datetime] NOT NULL,
	[VLR_PUB] [int] NOT NULL,
	[LINK_PUB] [nvarchar](100) NULL,
	[PATH_IMG_PUB] [nvarchar](100) NULL,
 CONSTRAINT [publicidade_top_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_PUB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[publicidade_lateral]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[publicidade_lateral](
	[COD_PUB] [int] IDENTITY(1,1) NOT NULL,
	[TIT_PUB] [varchar](30) NOT NULL,
	[EMP_PUB] [varchar](30) NOT NULL,
	[DT_PUB] [datetime] NOT NULL,
	[VLR_PUB] [int] NOT NULL,
	[LINK_PUB] [nvarchar](100) NULL,
	[PATH_IMG_PUB] [nvarchar](100) NULL,
 CONSTRAINT [publicidade_lateral_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_PUB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[noticias]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[noticias](
	[COD_NOT] [int] IDENTITY(1,1) NOT NULL,
	[TIT_NOT] [nvarchar](50) NULL,
	[TXT_NOT] [varchar](500) NULL,
	[LINK_NOT] [varchar](100) NULL,
	[DT_NOT] [datetime] NULL,
	[HR_NOT] [datetime] NULL,
	[PATH_IMG_INI_NOT] [varchar](100) NULL,
	[PATH_IMG1_NOT] [varchar](100) NULL,
	[PATH_IMG2_NOT] [varchar](100) NULL,
	[PATH_IMG3_NOT] [varchar](100) NULL,
 CONSTRAINT [noticias_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_NOT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itens_ctg]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[itens_ctg](
	[COD_ITN_CTG] [int] IDENTITY(1,1) NOT NULL,
	[TIT_ITN_CTG] [varchar](30) NOT NULL,
	[PATH_IMG1_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG2_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG3_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG4_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG5_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG6_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG7_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG8_DESC_INT_CTG] [nvarchar](100) NULL,
	[PATH_IMG9_DESC_INT_CTG] [nvarchar](100) NULL,
	[LINK_DOWN_INT_CTG] [varchar](100) NULL,
	[SIS_OP_INT_CTG] [nvarchar](20) NULL,
	[PROC_INT_CTG] [nvarchar](20) NULL,
	[RAM_INT_CTG] [nvarchar](20) NULL,
	[HD_INT_CTG] [nvarchar](20) NULL,
	[PL_VD_INT_CTG] [nvarchar](20) NULL,
	[PL_RD_INT_CTG] [nvarchar](20) NULL,
	[LINK1_VD_INT_CTG] [varchar](100) NULL,
	[LINK2_VD_INT_CTG] [varchar](100) NULL,
	[LINK3_VD_INT_CTG] [varchar](100) NULL,
	[DT_INT_CTG] [datetime] NULL,
	[FLAG_INT_CTG] [smallint] NULL,
	[TXT_ITN_CTG] [varchar](2000) NULL,
	[COD_CTG] [int] NULL,
 CONSTRAINT [itens_ctg_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_ITN_CTG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contato]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contato](
	[COD_CONT] [int] IDENTITY(1,1) NOT NULL,
	[NOME_CONT] [nvarchar](30) NOT NULL,
	[EMAIL_CONT] [nvarchar](25) NOT NULL,
	[MSG_CONT] [varchar](500) NOT NULL,
	[DATA_CONT] [datetime] NULL,
	[HORA_CONT] [datetime] NULL,
	[COD_ASSUNTO_CONT] [int] NULL,
	[LIDO_CONT] [smallint] NULL,
 CONSTRAINT [contato_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_CONT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cidades]    Script Date: 11/04/2011 11:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cidades](
	[COD_CIDADE] [int] IDENTITY(1,1) NOT NULL,
	[DESC_CIDADE] [varchar](30) NULL,
	[COD_ESTADO] [int] NULL,
 CONSTRAINT [cidades_PRIMARY] PRIMARY KEY NONCLUSTERED 
(
	[COD_CIDADE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__itens_ctg__LINK___21B6055D]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [LINK_DOWN_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__SIS_O__22AA2996]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [SIS_OP_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PROC___239E4DCF]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [PROC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__RAM_I__24927208]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [RAM_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__HD_IN__25869641]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [HD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PL_VD__267ABA7A]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [PL_VD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PL_RD__276EDEB3]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [PL_RD_INT_CTG]
GO
/****** Object:  ForeignKey [FK_COD_ESTADO]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[cidades]  WITH NOCHECK ADD  CONSTRAINT [FK_COD_ESTADO] FOREIGN KEY([COD_ESTADO])
REFERENCES [dbo].[estados] ([COD_ESTADO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cidades] NOCHECK CONSTRAINT [FK_COD_ESTADO]
GO
/****** Object:  ForeignKey [FK_COD_ASSUNTO_CONT]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[contato]  WITH NOCHECK ADD  CONSTRAINT [FK_COD_ASSUNTO_CONT] FOREIGN KEY([COD_ASSUNTO_CONT])
REFERENCES [dbo].[assunto_contato] ([COD_ASSUNTO])
GO
ALTER TABLE [dbo].[contato] NOCHECK CONSTRAINT [FK_COD_ASSUNTO_CONT]
GO
/****** Object:  ForeignKey [FK_COD_CTG]    Script Date: 11/04/2011 11:23:02 ******/
ALTER TABLE [dbo].[itens_ctg]  WITH NOCHECK ADD  CONSTRAINT [FK_COD_CTG] FOREIGN KEY([COD_CTG])
REFERENCES [dbo].[categoria] ([COD_CTG])
GO
ALTER TABLE [dbo].[itens_ctg] NOCHECK CONSTRAINT [FK_COD_CTG]
GO
