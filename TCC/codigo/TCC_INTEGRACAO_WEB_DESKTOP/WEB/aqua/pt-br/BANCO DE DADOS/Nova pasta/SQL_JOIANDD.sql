CREATE DATABASE joiandd;
GO
USE [joiandd]
GO
/****** Object:  Table [dbo].[titulo_usuario]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[titulo_usuario](
	[COD_TIT] [int] IDENTITY(1,1) NOT NULL,
	[DESC_TIT] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_TIT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sexo]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sexo](
	[COD_SEX] [int] IDENTITY(1,1) NOT NULL,
	[DESC_SEX] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_SEX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[COD_CTG] [int] IDENTITY(1,1) NOT NULL,
	[TIT_CTG] [char](20) NOT NULL,
	[FLAG_MEN] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CTG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[assunto_contato]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[assunto_contato](
	[COD_ASSUNTO] [int] IDENTITY(1,1) NOT NULL,
	[DESC_ASSUNTO] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_ASSUNTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estados]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estados](
	[COD_ESTADO] [int] IDENTITY(1,1) NOT NULL,
	[DESC_ESTADO] [varchar](30) NOT NULL,
	[SIGL_ESTADO] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_ESTADO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[enquete]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[enquete](
	[COD_ENQ] [int] IDENTITY(1,1) NOT NULL,
	[TIT_ENQ] [char](50) NOT NULL,
	[DT_ENQ] [date] NOT NULL,
	[ITN1_ENQ] [char](20) NULL,
	[ITN2_ENQ] [char](20) NULL,
	[ITN3_ENQ] [char](20) NULL,
	[ITN4_ENQ] [char](20) NULL,
	[PCT_ITN1_ENQ] [int] NULL,
	[PCT_ITN2_ENQ] [int] NULL,
	[PCT_ITN3_ENQ] [int] NULL,
	[PCT_ITN4_ENQ] [int] NULL,
	[FLAG_ENQ_FIN] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_ENQ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[destaque]    Script Date: 11/04/2011 16:42:32 ******/
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
	[DT_DEST] [date] NOT NULL,
	[HR_DEST] [time](7) NOT NULL,
	[FLAG_IMG_DEST] [tinyint] NOT NULL,
	[FLAG_VID_DEST] [tinyint] NOT NULL,
	[FLAG_ANLS_DEST] [tinyint] NOT NULL,
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
PRIMARY KEY CLUSTERED 
(
	[COD_DEST] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[publicidade_top]    Script Date: 11/04/2011 16:42:32 ******/
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
	[DT_PUB] [date] NOT NULL,
	[VLR_PUB] [int] NOT NULL,
	[LINK_PUB] [char](100) NULL,
	[PATH_IMG_PUB] [char](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_PUB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[publicidade_lateral]    Script Date: 11/04/2011 16:42:32 ******/
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
	[DT_PUB] [date] NOT NULL,
	[VLR_PUB] [int] NOT NULL,
	[LINK_PUB] [char](100) NULL,
	[PATH_IMG_PUB] [char](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_PUB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[noticias]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[noticias](
	[COD_NOT] [int] IDENTITY(1,1) NOT NULL,
	[TIT_NOT] [char](50) NULL,
	[TXT_NOT] [varchar](500) NULL,
	[LINK_NOT] [varchar](100) NULL,
	[DT_NOT] [date] NULL,
	[HR_NOT] [time](7) NULL,
	[PATH_IMG_INI_NOT] [varchar](100) NULL,
	[PATH_IMG1_NOT] [varchar](100) NULL,
	[PATH_IMG2_NOT] [varchar](100) NULL,
	[PATH_IMG3_NOT] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_NOT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itens_ctg]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[itens_ctg](
	[COD_ITN_CTG] [int] IDENTITY(1,1) NOT NULL,
	[TIT_ITN_CTG] [varchar](30) NOT NULL,
	[PATH_IMG1_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG2_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG3_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG4_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG5_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG6_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG7_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG8_DESC_INT_CTG] [char](100) NULL,
	[PATH_IMG9_DESC_INT_CTG] [char](100) NULL,
	[LINK_DOWN_INT_CTG] [varchar](100) NULL,
	[SIS_OP_INT_CTG] [char](20) NULL,
	[PROC_INT_CTG] [char](20) NULL,
	[RAM_INT_CTG] [char](20) NULL,
	[HD_INT_CTG] [char](20) NULL,
	[PL_VD_INT_CTG] [char](20) NULL,
	[PL_RD_INT_CTG] [char](20) NULL,
	[LINK1_VD_INT_CTG] [varchar](100) NULL,
	[LINK2_VD_INT_CTG] [varchar](100) NULL,
	[LINK3_VD_INT_CTG] [varchar](100) NULL,
	[DT_INT_CTG] [date] NULL,
	[FLAG_INT_CTG] [tinyint] NULL,
	[TXT_ITN_CTG] [varchar](2000) NULL,
	[COD_CTG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_ITN_CTG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contato]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contato](
	[COD_CONT] [int] IDENTITY(1,1) NOT NULL,
	[NOME_CONT] [char](30) NOT NULL,
	[EMAIL_CONT] [char](25) NOT NULL,
	[MSG_CONT] [varchar](500) NOT NULL,
	[DATA_CONT] [date] NULL,
	[HORA_CONT] [time](7) NULL,
	[COD_ASSUNTO_CONT] [int] NULL,
	[LIDO_CONT] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CONT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cidades]    Script Date: 11/04/2011 16:42:32 ******/
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
PRIMARY KEY CLUSTERED 
(
	[COD_CIDADE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[COD_USU] [int] IDENTITY(1,1) NOT NULL,
	[NOM_USU] [char](10) NOT NULL,
	[SOBRE_USU] [char](20) NULL,
	[EMAIL_USU] [char](30) NULL,
	[LOG_USU] [char](12) NOT NULL,
	[SEN_USU] [char](32) NULL,
	[DT_NASC_USU] [date] NULL,
	[DT_CADS_USU] [date] NULL,
	[FT_USU] [varchar](255) NULL,
	[DESC_USU] [varchar](140) NULL,
	[PTS_USU] [int] NULL,
	[FLAG_RNSC] [tinyint] NULL,
	[FLAG_EMAIL_VIS] [tinyint] NULL,
	[FLAG_DTNASC_VIS] [tinyint] NULL,
	[COD_TIT_USU] [int] NULL,
	[COD_SEX] [int] NULL,
	[COD_CIDADE] [int] NULL,
	[COD_ESTADO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_USU] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[artigo]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[artigo](
	[COD_ART] [int] IDENTITY(1,1) NOT NULL,
	[TIT_ART] [char](100) NOT NULL,
	[TXT_ART] [varchar](500) NOT NULL,
	[LINK_ART] [varchar](100) NOT NULL,
	[DT_POST_ART] [date] NOT NULL,
	[HR_POST_ART] [time](7) NOT NULL,
	[PTS_ART] [int] NOT NULL,
	[PLV_CHV_ART1] [char](10) NOT NULL,
	[PLV_CHV_ART2] [char](10) NOT NULL,
	[PLV_CHV_ART3] [char](10) NOT NULL,
	[FLAG_ART_AP] [tinyint] NOT NULL,
	[COD_USU] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_ART] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[comentario_noticia]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comentario_noticia](
	[COD_CMT] [int] IDENTITY(1,1) NOT NULL,
	[TXT_CMT] [varchar](140) NOT NULL,
	[DT_CMT] [date] NOT NULL,
	[COD_USU] [int] NOT NULL,
	[COD_NOT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CMT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[comentario_destaque]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comentario_destaque](
	[COD_CMT] [int] IDENTITY(1,1) NOT NULL,
	[TXT_CMT] [varchar](140) NOT NULL,
	[DT_CMT] [date] NOT NULL,
	[COD_USU] [int] NOT NULL,
	[COD_DEST] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CMT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ranking_usuario]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ranking_usuario](
	[COD_RNK] [int] IDENTITY(1,1) NOT NULL,
	[COD_USU] [int] NOT NULL,
	[PTS_USU] [int] NOT NULL,
	[DT_RNK] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_RNK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinalizacao_noticia]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinalizacao_noticia](
	[COD_SIN] [int] IDENTITY(1,1) NOT NULL,
	[COD_NOT] [int] NOT NULL,
	[COD_USU_SINALIZADO] [int] NOT NULL,
	[COD_USU_SINALIZAR] [int] NOT NULL,
	[COD_CMT] [int] NOT NULL,
	[COD_MTV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_SIN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinalizacao_destaque]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinalizacao_destaque](
	[COD_SIN] [int] IDENTITY(1,1) NOT NULL,
	[COD_DEST] [int] NOT NULL,
	[COD_USU_SINALIZADO] [int] NOT NULL,
	[COD_USU_SINALIZAR] [int] NOT NULL,
	[COD_CMT] [int] NOT NULL,
	[COD_MTV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_SIN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinalizacao_artigo]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinalizacao_artigo](
	[COD_SIN] [int] IDENTITY(1,1) NOT NULL,
	[COD_ART] [int] NOT NULL,
	[COD_USU_SINALIZADO] [int] NOT NULL,
	[COD_USU_SINALIZAR] [int] NOT NULL,
	[COD_CMT] [int] NOT NULL,
	[COD_MTV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_SIN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[curtir_artigo]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[curtir_artigo](
	[COD_CUR] [int] IDENTITY(1,1) NOT NULL,
	[COD_ART] [int] NOT NULL,
	[COD_USU] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CUR] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comentario_artigo]    Script Date: 11/04/2011 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comentario_artigo](
	[COD_CMT] [int] IDENTITY(1,1) NOT NULL,
	[TXT_CMT] [varchar](140) NOT NULL,
	[DT_CMT] [date] NOT NULL,
	[COD_USU] [int] NOT NULL,
	[COD_ART] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CMT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__assunto_c__DESC___44FF419A]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[assunto_contato] ADD  DEFAULT (NULL) FOR [DESC_ASSUNTO]
GO
/****** Object:  Default [DF__cidades__DESC_CI__09DE7BCC]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[cidades] ADD  DEFAULT (NULL) FOR [DESC_CIDADE]
GO
/****** Object:  Default [DF__cidades__COD_EST__0AD2A005]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[cidades] ADD  DEFAULT (NULL) FOR [COD_ESTADO]
GO
/****** Object:  Default [DF__contato__DATA_CO__55009F39]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[contato] ADD  DEFAULT (NULL) FOR [DATA_CONT]
GO
/****** Object:  Default [DF__contato__HORA_CO__55F4C372]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[contato] ADD  DEFAULT (NULL) FOR [HORA_CONT]
GO
/****** Object:  Default [DF__contato__COD_ASS__56E8E7AB]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[contato] ADD  DEFAULT (NULL) FOR [COD_ASSUNTO_CONT]
GO
/****** Object:  Default [DF__contato__LIDO_CO__57DD0BE4]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[contato] ADD  DEFAULT (NULL) FOR [LIDO_CONT]
GO
/****** Object:  Default [DF__destaque__TXT_DE__339FAB6E]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [TXT_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__3493CFA7]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG1_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__3587F3E0]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG2_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__367C1819]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG3_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__37703C52]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG4_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__3864608B]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG5_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__395884C4]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG6_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__3A4CA8FD]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG7_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__3B40CD36]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG8_DEST]
GO
/****** Object:  Default [DF__destaque__PATH_I__3C34F16F]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [PATH_IMG9_DEST]
GO
/****** Object:  Default [DF__destaque__LINK1___3D2915A8]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [LINK1_VID_DEST]
GO
/****** Object:  Default [DF__destaque__LINK2___3E1D39E1]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [LINK2_VID_DEST]
GO
/****** Object:  Default [DF__destaque__LINK3___3F115E1A]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [LINK3_VID_DEST]
GO
/****** Object:  Default [DF__destaque__LINK4___40058253]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[destaque] ADD  DEFAULT (NULL) FOR [LINK4_VID_DEST]
GO
/****** Object:  Default [DF__enquete__ITN1_EN__6FE99F9F]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [ITN1_ENQ]
GO
/****** Object:  Default [DF__enquete__ITN2_EN__70DDC3D8]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [ITN2_ENQ]
GO
/****** Object:  Default [DF__enquete__ITN3_EN__71D1E811]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [ITN3_ENQ]
GO
/****** Object:  Default [DF__enquete__ITN4_EN__72C60C4A]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [ITN4_ENQ]
GO
/****** Object:  Default [DF__enquete__PCT_ITN__73BA3083]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [PCT_ITN1_ENQ]
GO
/****** Object:  Default [DF__enquete__PCT_ITN__74AE54BC]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [PCT_ITN2_ENQ]
GO
/****** Object:  Default [DF__enquete__PCT_ITN__75A278F5]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [PCT_ITN3_ENQ]
GO
/****** Object:  Default [DF__enquete__PCT_ITN__76969D2E]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [PCT_ITN4_ENQ]
GO
/****** Object:  Default [DF__enquete__FLAG_EN__778AC167]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[enquete] ADD  DEFAULT (NULL) FOR [FLAG_ENQ_FIN]
GO
/****** Object:  Default [DF__itens_ctg__PATH___7C4F7684]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG1_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___7D439ABD]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG2_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___7E37BEF6]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG3_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___7F2BE32F]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG4_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___00200768]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG5_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___01142BA1]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG6_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___02084FDA]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG7_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___02FC7413]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG8_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PATH___03F0984C]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [PATH_IMG9_DESC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__LINK___04E4BC85]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [LINK_DOWN_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__SIS_O__05D8E0BE]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [SIS_OP_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PROC___06CD04F7]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [PROC_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__RAM_I__07C12930]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [RAM_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__HD_IN__08B54D69]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [HD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PL_VD__09A971A2]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [PL_VD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__PL_RD__0A9D95DB]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT ('indisponível') FOR [PL_RD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__LINK1__0B91BA14]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [LINK1_VD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__LINK2__0C85DE4D]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [LINK2_VD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__LINK3__0D7A0286]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [LINK3_VD_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__DT_IN__0E6E26BF]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [DT_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__FLAG___0F624AF8]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [FLAG_INT_CTG]
GO
/****** Object:  Default [DF__itens_ctg__TXT_I__10566F31]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [TXT_ITN_CTG]
GO
/****** Object:  Default [DF__itens_ctg__COD_C__114A936A]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg] ADD  DEFAULT (NULL) FOR [COD_CTG]
GO
/****** Object:  Default [DF__noticias__TIT_NO__17036CC0]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [TIT_NOT]
GO
/****** Object:  Default [DF__noticias__TXT_NO__17F790F9]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [TXT_NOT]
GO
/****** Object:  Default [DF__noticias__LINK_N__18EBB532]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [LINK_NOT]
GO
/****** Object:  Default [DF__noticias__DT_NOT__19DFD96B]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [DT_NOT]
GO
/****** Object:  Default [DF__noticias__HR_NOT__1AD3FDA4]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [HR_NOT]
GO
/****** Object:  Default [DF__noticias__PATH_I__1BC821DD]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [PATH_IMG_INI_NOT]
GO
/****** Object:  Default [DF__noticias__PATH_I__1CBC4616]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [PATH_IMG1_NOT]
GO
/****** Object:  Default [DF__noticias__PATH_I__1DB06A4F]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [PATH_IMG2_NOT]
GO
/****** Object:  Default [DF__noticias__PATH_I__1EA48E88]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[noticias] ADD  DEFAULT (NULL) FOR [PATH_IMG3_NOT]
GO
/****** Object:  Default [DF__publicida__LINK___236943A5]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[publicidade_lateral] ADD  DEFAULT (NULL) FOR [LINK_PUB]
GO
/****** Object:  Default [DF__publicida__PATH___245D67DE]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[publicidade_lateral] ADD  DEFAULT (NULL) FOR [PATH_IMG_PUB]
GO
/****** Object:  Default [DF__publicida__LINK___29221CFB]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[publicidade_top] ADD  DEFAULT (NULL) FOR [LINK_PUB]
GO
/****** Object:  Default [DF__publicida__PATH___2A164134]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[publicidade_top] ADD  DEFAULT (NULL) FOR [PATH_IMG_PUB]
GO
/****** Object:  Default [DF__sexo__DESC_SEX__014935CB]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sexo] ADD  DEFAULT (NULL) FOR [DESC_SEX]
GO
/****** Object:  Default [DF__usuario__SOBRE_U__2A4B4B5E]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [SOBRE_USU]
GO
/****** Object:  Default [DF__usuario__EMAIL_U__2B3F6F97]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [EMAIL_USU]
GO
/****** Object:  Default [DF__usuario__SEN_USU__2C3393D0]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [SEN_USU]
GO
/****** Object:  Default [DF__usuario__DT_NASC__2D27B809]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [DT_NASC_USU]
GO
/****** Object:  Default [DF__usuario__DT_CADS__2E1BDC42]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [DT_CADS_USU]
GO
/****** Object:  Default [DF__usuario__FT_USU__2F10007B]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [FT_USU]
GO
/****** Object:  Default [DF__usuario__DESC_US__300424B4]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [DESC_USU]
GO
/****** Object:  Default [DF__usuario__PTS_USU__30F848ED]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ('0') FOR [PTS_USU]
GO
/****** Object:  Default [DF__usuario__FLAG_RN__31EC6D26]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ('0') FOR [FLAG_RNSC]
GO
/****** Object:  Default [DF__usuario__FLAG_EM__32E0915F]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ('1') FOR [FLAG_EMAIL_VIS]
GO
/****** Object:  Default [DF__usuario__FLAG_DT__33D4B598]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ('1') FOR [FLAG_DTNASC_VIS]
GO
/****** Object:  Default [DF__usuario__COD_TIT__34C8D9D1]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ('1') FOR [COD_TIT_USU]
GO
/****** Object:  Default [DF__usuario__COD_SEX__35BCFE0A]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ('1') FOR [COD_SEX]
GO
/****** Object:  Default [DF__usuario__COD_CID__36B12243]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [COD_CIDADE]
GO
/****** Object:  Default [DF__usuario__COD_EST__37A5467C]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (NULL) FOR [COD_ESTADO]
GO
/****** Object:  ForeignKey [FK_COD_USU_ART]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_ART] FOREIGN KEY([COD_USU])
REFERENCES [dbo].[usuario] ([COD_USU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[artigo] CHECK CONSTRAINT [FK_COD_USU_ART]
GO
/****** Object:  ForeignKey [FK_COD_ESTADO]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[cidades]  WITH CHECK ADD  CONSTRAINT [FK_COD_ESTADO] FOREIGN KEY([COD_ESTADO])
REFERENCES [dbo].[estados] ([COD_ESTADO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cidades] CHECK CONSTRAINT [FK_COD_ESTADO]
GO
/****** Object:  ForeignKey [FK_COD_ART_CMT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[comentario_artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_ART_CMT] FOREIGN KEY([COD_ART])
REFERENCES [dbo].[artigo] ([COD_ART])
GO
ALTER TABLE [dbo].[comentario_artigo] CHECK CONSTRAINT [FK_COD_ART_CMT]
GO
/****** Object:  ForeignKey [FK_COD_USU_CMT_ART]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[comentario_artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_CMT_ART] FOREIGN KEY([COD_USU])
REFERENCES [dbo].[usuario] ([COD_USU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comentario_artigo] CHECK CONSTRAINT [FK_COD_USU_CMT_ART]
GO
/****** Object:  ForeignKey [FK_COD_DEST_CMT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[comentario_destaque]  WITH CHECK ADD  CONSTRAINT [FK_COD_DEST_CMT] FOREIGN KEY([COD_DEST])
REFERENCES [dbo].[destaque] ([COD_DEST])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comentario_destaque] CHECK CONSTRAINT [FK_COD_DEST_CMT]
GO
/****** Object:  ForeignKey [FK_COD_USU_CMT_DEST]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[comentario_destaque]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_CMT_DEST] FOREIGN KEY([COD_USU])
REFERENCES [dbo].[usuario] ([COD_USU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comentario_destaque] CHECK CONSTRAINT [FK_COD_USU_CMT_DEST]
GO
/****** Object:  ForeignKey [FK_COD_NOT_CMT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[comentario_noticia]  WITH CHECK ADD  CONSTRAINT [FK_COD_NOT_CMT] FOREIGN KEY([COD_NOT])
REFERENCES [dbo].[noticias] ([COD_NOT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comentario_noticia] CHECK CONSTRAINT [FK_COD_NOT_CMT]
GO
/****** Object:  ForeignKey [FK_COD_USU_CMT_NOT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[comentario_noticia]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_CMT_NOT] FOREIGN KEY([COD_USU])
REFERENCES [dbo].[usuario] ([COD_USU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comentario_noticia] CHECK CONSTRAINT [FK_COD_USU_CMT_NOT]
GO
/****** Object:  ForeignKey [FK_COD_ASSUNTO_CONT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[contato]  WITH CHECK ADD  CONSTRAINT [FK_COD_ASSUNTO_CONT] FOREIGN KEY([COD_ASSUNTO_CONT])
REFERENCES [dbo].[assunto_contato] ([COD_ASSUNTO])
GO
ALTER TABLE [dbo].[contato] CHECK CONSTRAINT [FK_COD_ASSUNTO_CONT]
GO
/****** Object:  ForeignKey [FK_COD_ART_CUR]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[curtir_artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_ART_CUR] FOREIGN KEY([COD_ART])
REFERENCES [dbo].[artigo] ([COD_ART])
GO
ALTER TABLE [dbo].[curtir_artigo] CHECK CONSTRAINT [FK_COD_ART_CUR]
GO
/****** Object:  ForeignKey [FK_COD_USU_CUR]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[curtir_artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_CUR] FOREIGN KEY([COD_USU])
REFERENCES [dbo].[usuario] ([COD_USU])
GO
ALTER TABLE [dbo].[curtir_artigo] CHECK CONSTRAINT [FK_COD_USU_CUR]
GO
/****** Object:  ForeignKey [FK_COD_CTG]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[itens_ctg]  WITH CHECK ADD  CONSTRAINT [FK_COD_CTG] FOREIGN KEY([COD_CTG])
REFERENCES [dbo].[categoria] ([COD_CTG])
GO
ALTER TABLE [dbo].[itens_ctg] CHECK CONSTRAINT [FK_COD_CTG]
GO
/****** Object:  ForeignKey [FKF_COD_USU_RNK]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[ranking_usuario]  WITH CHECK ADD  CONSTRAINT [FKF_COD_USU_RNK] FOREIGN KEY([COD_USU])
REFERENCES [dbo].[usuario] ([COD_USU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ranking_usuario] CHECK CONSTRAINT [FKF_COD_USU_RNK]
GO
/****** Object:  ForeignKey [FK_COD_SN_CMT_ART]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_SN_CMT_ART] FOREIGN KEY([COD_CMT])
REFERENCES [dbo].[comentario_noticia] ([COD_CMT])
GO
ALTER TABLE [dbo].[sinalizacao_artigo] CHECK CONSTRAINT [FK_COD_SN_CMT_ART]
GO
/****** Object:  ForeignKey [FK_COD_USU_SINALIZADO_ART]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_SINALIZADO_ART] FOREIGN KEY([COD_USU_SINALIZADO])
REFERENCES [dbo].[usuario] ([COD_USU])
GO
ALTER TABLE [dbo].[sinalizacao_artigo] CHECK CONSTRAINT [FK_COD_USU_SINALIZADO_ART]
GO
/****** Object:  ForeignKey [FK_COD_USU_SINALIZAR_ART]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_artigo]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_SINALIZAR_ART] FOREIGN KEY([COD_USU_SINALIZAR])
REFERENCES [dbo].[usuario] ([COD_USU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sinalizacao_artigo] CHECK CONSTRAINT [FK_COD_USU_SINALIZAR_ART]
GO
/****** Object:  ForeignKey [FK_COD_SN_CMT_DEST]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_destaque]  WITH CHECK ADD  CONSTRAINT [FK_COD_SN_CMT_DEST] FOREIGN KEY([COD_CMT])
REFERENCES [dbo].[comentario_destaque] ([COD_CMT])
GO
ALTER TABLE [dbo].[sinalizacao_destaque] CHECK CONSTRAINT [FK_COD_SN_CMT_DEST]
GO
/****** Object:  ForeignKey [FK_COD_USU_SINALIZADO_DEST]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_destaque]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_SINALIZADO_DEST] FOREIGN KEY([COD_USU_SINALIZADO])
REFERENCES [dbo].[usuario] ([COD_USU])
GO
ALTER TABLE [dbo].[sinalizacao_destaque] CHECK CONSTRAINT [FK_COD_USU_SINALIZADO_DEST]
GO
/****** Object:  ForeignKey [FK_COD_USU_SINALIZAR_DEST]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_destaque]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_SINALIZAR_DEST] FOREIGN KEY([COD_USU_SINALIZAR])
REFERENCES [dbo].[usuario] ([COD_USU])
GO
ALTER TABLE [dbo].[sinalizacao_destaque] CHECK CONSTRAINT [FK_COD_USU_SINALIZAR_DEST]
GO
/****** Object:  ForeignKey [FK_COD_SN_CMT_NOT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_noticia]  WITH CHECK ADD  CONSTRAINT [FK_COD_SN_CMT_NOT] FOREIGN KEY([COD_CMT])
REFERENCES [dbo].[comentario_noticia] ([COD_CMT])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sinalizacao_noticia] CHECK CONSTRAINT [FK_COD_SN_CMT_NOT]
GO
/****** Object:  ForeignKey [FK_COD_USU_SINALIZADO_NOT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_noticia]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_SINALIZADO_NOT] FOREIGN KEY([COD_USU_SINALIZADO])
REFERENCES [dbo].[usuario] ([COD_USU])
GO
ALTER TABLE [dbo].[sinalizacao_noticia] CHECK CONSTRAINT [FK_COD_USU_SINALIZADO_NOT]
GO
/****** Object:  ForeignKey [FK_COD_USU_SINALIZAR_NOT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[sinalizacao_noticia]  WITH CHECK ADD  CONSTRAINT [FK_COD_USU_SINALIZAR_NOT] FOREIGN KEY([COD_USU_SINALIZAR])
REFERENCES [dbo].[usuario] ([COD_USU])
GO
ALTER TABLE [dbo].[sinalizacao_noticia] CHECK CONSTRAINT [FK_COD_USU_SINALIZAR_NOT]
GO
/****** Object:  ForeignKey [FK_COD_CIDADE]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_COD_CIDADE] FOREIGN KEY([COD_CIDADE])
REFERENCES [dbo].[cidades] ([COD_CIDADE])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_COD_CIDADE]
GO
/****** Object:  ForeignKey [FK_COD_ESTADO_USU]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_COD_ESTADO_USU] FOREIGN KEY([COD_ESTADO])
REFERENCES [dbo].[estados] ([COD_ESTADO])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_COD_ESTADO_USU]
GO
/****** Object:  ForeignKey [FK_COD_SEX]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_COD_SEX] FOREIGN KEY([COD_SEX])
REFERENCES [dbo].[sexo] ([COD_SEX])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_COD_SEX]
GO
/****** Object:  ForeignKey [FK_COD_TIT]    Script Date: 11/04/2011 16:42:32 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_COD_TIT] FOREIGN KEY([COD_TIT_USU])
REFERENCES [dbo].[titulo_usuario] ([COD_TIT])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_COD_TIT]
GO
