USE [ActivosFijos]
GO

CREATE TABLE [dbo].[acfCMPt_ComponenteBase](
	[CMPidComponente] [char](15) NOT NULL,
	[CMPdescripcion] [varchar](100) NULL,
	[CMPnivel] [int] NULL,
 CONSTRAINT [PK_acfCMPt_ComponenteBase] PRIMARY KEY CLUSTERED 
(
	[CMPidComponente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
