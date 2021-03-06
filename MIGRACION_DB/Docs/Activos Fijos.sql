USE [ActivosFijosP]
GO
/****** Object:  Table [dbo].[acfACFp_Activo_Fijo]    Script Date: 11/04/2017 11:17:15  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfACFp_Activo_Fijo](
	[ACFid] [int] NOT NULL,
	[BUKRS] [char](4) NULL,
	[SEGMENT] [char](10) NULL,
	[ANLKL] [char](8) NULL,
	[PERNR] [char](8) NULL,
	[CSTid] [char](4) NULL,
	[MVMid] [char](2) NULL,
	[ACFfmovimiento] [datetime] NULL,
	[VNRid] [char](7) NULL,
	[ACFdescripcion] [char](254) NULL,
	[ACFfincorporacion] [datetime] NULL,
	[ACFfcapitalizacion] [datetime] NULL,
	[ACFvutiltribanio] [int] NULL,
	[ACFvutiltribdia] [int] NULL,
	[ACFvalortrib] [decimal](18, 2) NULL,
	[ACFvutilniifanio] [int] NULL,
	[ACFvutilniifdia] [int] NULL,
	[ACFvalorniif] [decimal](18, 2) NULL,
	[ACFdepacutrib] [char](18) NULL,
	[ACFdepacuniif] [decimal](18, 2) NULL,
	[ACFobra] [char](10) NULL,
	[ACFord41] [char](4) NULL,
	[ACFord42] [char](4) NULL,
	[ACFord43] [char](4) NULL,
	[ACFord44] [char](4) NULL,
	[ACFanlue] [char](12) NULL,
	[ACFfactortrib] [decimal](18, 6) NULL,
	[ACFfactorniif] [decimal](18, 6) NULL,
	[ACFcuenta] [char](18) NULL,
	[ACFcuentadep] [char](18) NULL,
	[CMPid] [char](15) NULL,
	[ACFobservacion] [varchar](250) NULL,
	[LIFNR] [char](15) NULL,
	[ACFnotaingreso] [char](18) NULL,
	[ACFfechanotaingreso] [char](18) NULL,
	[ACFordencompra] [char](18) NULL,
	[ACFfechaordencompra] [datetime] NULL,
	[BLART] [char](2) NULL,
	[ACFcomprobante] [char](18) NULL,
	[KOSTL] [char](10) NULL,
	[AMBid] [int] NULL,
	[UBEid] [int] NOT NULL,
	[ACFfechacomprobante] [datetime] NULL,
	[V_T087U_ANLUE] [char](12) NOT NULL,
 CONSTRAINT [XPKacfACFp_Activo_Fijo] PRIMARY KEY CLUSTERED 
(
	[ACFid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfACTt_Actividad]    Script Date: 11/04/2017 11:17:15  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfACTt_Actividad](
	[ACTid] [char](2) NOT NULL,
	[ACTactividad] [varchar](60) NULL,
 CONSTRAINT [XPKacfACTt_Actividad] PRIMARY KEY CLUSTERED 
(
	[ACTid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfAMBt_Ambiente]    Script Date: 11/04/2017 11:17:15  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfAMBt_Ambiente](
	[LOCid] [int] NULL,
	[AMBid] [int] NOT NULL,
	[AMBambiente] [varchar](100) NULL,
 CONSTRAINT [XPKacfAMBt_Ambiente] PRIMARY KEY CLUSTERED 
(
	[AMBid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfCMPt_Componente]    Script Date: 11/04/2017 11:17:15  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfCMPt_Componente](
	[CMPid] [char](15) NOT NULL,
	[CMPcomponente] [varchar](100) NULL,
	[CMPusoestimado] [decimal](18, 2) NULL,
	[CMPconservacion] [decimal](18, 2) NULL,
	[CMPobsolecencia] [decimal](18, 2) NULL,
	[CMPlimitelegal] [decimal](18, 2) NULL,
	[CMPtotalfactores] [decimal](18, 2) NULL,
	[CMPfactorusoestimado] [decimal](18, 2) NULL,
	[CMPvutilanio] [int] NULL,
	[CMPvutildia] [int] NULL,
 CONSTRAINT [XPKacfCMPt_componente] PRIMARY KEY CLUSTERED 
(
	[CMPid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfCRSt_Caracteristicas]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfCRSt_Caracteristicas](
	[ACFid] [int] NOT NULL,
	[MARid] [int] NULL,
	[ESTid] [int] NULL,
	[CRSserie] [varchar](30) NULL,
	[CRSmodelo] [varchar](35) NULL,
	[CRScolor] [varchar](35) NULL,
	[MATid] [int] NULL,
	[CRStipo] [char](1) NULL,
	[UNMid] [int] NULL,
	[CRScantidad] [decimal](18, 2) NULL,
	[CRSvehplaca] [varchar](15) NULL,
	[CRSvehexpediente] [varchar](15) NULL,
	[CRSvehinscripcion] [datetime] NULL,
	[CRSvehclase] [varchar](35) NULL,
	[CRSvehcombustible] [varchar](35) NULL,
	[CRSvehejes] [int] NULL,
	[CRSvehpasajeros] [int] NULL,
	[CRSvehasientos] [int] NULL,
	[CRSvehpesoseco] [decimal](18, 2) NULL,
	[CRSvehcargautil] [decimal](18, 2) NULL,
	[CRSaltura] [decimal](18, 2) NULL,
	[CRSancho] [decimal](18, 2) NULL,
	[CRSvelocidad] [varchar](20) NULL,
	[CRSresolucion] [varchar](20) NULL,
	[CRScapacidad] [varchar](20) NULL,
	[CRSpotencia] [varchar](20) NULL,
	[CRSvnominal] [varchar](20) NULL,
	[CRSventrada] [varchar](20) NULL,
	[CRSvsalida] [varchar](20) NULL,
	[CRSfrecuencia] [varchar](20) NULL,
	[CRStemperatura] [varchar](20) NULL,
	[CRSprocesador] [varchar](100) NULL,
	[CRSpuertos] [varchar](100) NULL,
	[CRSutmx] [decimal](18, 2) NULL,
	[CRSutmy] [decimal](18, 2) NULL,
	[CRSesfuerzopunta] [varchar](20) NULL,
	[CRScajaderivadora] [varchar](20) NULL,
	[CRSalquilacable] [char](1) NULL,
	[CRScentropoblado] [varchar](60) NULL,
	[CRSurbanizacion] [varchar](60) NULL,
	[CRScalle] [varchar](60) NULL,
	[CRSlote] [varchar](10) NULL,
	[CRSnumeropredio] [varchar](20) NULL,
	[CRSdepartamento] [varchar](10) NULL,
	[CRSinterior] [varchar](10) NULL,
	[CRScarretera] [varchar](50) NULL,
	[CRSkilometro] [decimal](18, 2) NULL,
	[CRSnombrepredio] [varchar](60) NULL,
	[CRSpisospredio] [int] NULL,
	[CRSpartidapredio] [varchar](15) NULL,
	[CRStomopredio] [varchar](15) NULL,
	[CRSfolioinipredio] [varchar](10) NULL,
	[CRSfoliofinpredio] [varchar](10) NULL,
	[CRSasientopredio] [varchar](15) NULL,
	[CRSfinscpredio] [datetime] NULL,
	[CRSficharegistral] [varchar](20) NULL,
	[CRSareaconstruida] [decimal](18, 2) NULL,
	[CRSperimetro] [decimal](18, 2) NULL,
	[CRSusopredio] [varchar](60) NULL,
	[CRSvalorautovaluo] [decimal](18, 2) NULL,
	[CRScodigoluz] [varchar](20) NULL,
	[CRScodigoagua] [varchar](20) NULL,
	[CRSfadqpredio] [datetime] NULL,
	[CRSobservacion] [varchar](254) NULL,
 CONSTRAINT [XPKacfCRSt_Caracteristicas] PRIMARY KEY CLUSTERED 
(
	[ACFid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfCSTt_Costo]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfCSTt_Costo](
	[CSTid] [char](4) NOT NULL,
	[CSTdescripcion] [char](35) NULL,
	[CSTdetalle] [char](70) NULL,
	[CSTabreviado] [char](15) NULL,
	[ACTid] [char](2) NOT NULL,
	[CSTid_costo] [char](2) NULL,
 CONSTRAINT [XPKacfCSTt_Costo] PRIMARY KEY CLUSTERED 
(
	[CSTid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfDDFt_detalledediferido]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfDDFt_detalledediferido](
	[ACFcuenta] [char](18) NULL,
	[INVZU] [char](100) NULL,
	[TXT50] [char](100) NULL,
	[ACFvalorniif] [decimal](12, 2) NULL,
	[ACFdepniif] [decimal](12, 2) NULL,
	[ACFPPENiif] [decimal](12, 2) NULL,
	[ACFvalortrib] [decimal](12, 2) NULL,
	[ACFDepTrib] [decimal](12, 2) NULL,
	[ACFpplir] [decimal](12, 2) NULL,
	[ACFdeducible] [decimal](12, 2) NULL,
	[ACFimponible] [decimal](12, 2) NULL,
	[ACFirda] [decimal](12, 2) NULL,
	[ACFirdp] [decimal](12, 2) NULL,
	[ACFculdep] [decimal](12, 2) NULL,
	[ACFrecper1] [decimal](12, 2) NULL,
	[ACFrecper2] [decimal](12, 2) NULL,
	[ACFrecper3] [decimal](12, 2) NULL,
	[ACFrecper4] [decimal](12, 2) NULL,
	[ACFtotales] [decimal](12, 2) NULL,
	[ACFirdaA] [decimal](12, 2) NULL,
	[ACFirdpA] [decimal](12, 2) NULL,
	[ACFirdaF] [decimal](12, 2) NULL,
	[ACFirdpF] [decimal](12, 2) NULL,
	[PDFcodigo] [int] NOT NULL,
 CONSTRAINT [XPKacfDDFt_detalledediferido] PRIMARY KEY CLUSTERED 
(
	[PDFcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfDRTt_detallereparotributario]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfDRTt_detallereparotributario](
	[RTRcodigo] [int] NOT NULL,
	[ACFcuenta] [char](18) NULL,
	[INVZU] [char](100) NULL,
	[TXT50] [char](100) NULL,
	[ACFfactorniif] [decimal](12, 2) NULL,
	[ACFvutilniif] [decimal](12, 2) NULL,
	[ACFfactorTrib] [decimal](12, 2) NULL,
	[ACFvutiltrib] [decimal](12, 2) NULL,
	[ACFvalorniif] [decimal](12, 2) NULL,
	[ACFdepAcuniif] [decimal](12, 2) NULL,
	[ACFNiifNeto] [decimal](12, 2) NULL,
	[ACFDepNiifPer] [decimal](12, 2) NULL,
	[ACFvalortrib] [decimal](12, 2) NULL,
	[ACFdepacutrib] [decimal](12, 2) NULL,
	[ACFlirneto] [decimal](12, 2) NULL,
	[ACFdeptlirper] [decimal](12, 2) NULL,
	[ACFadiciones] [decimal](12, 2) NULL,
	[ACFdeducciones] [decimal](12, 2) NULL,
	[ACFneto] [decimal](12, 2) NULL,
 CONSTRAINT [XPKacfDRTt_detallereparotributario] PRIMARY KEY CLUSTERED 
(
	[RTRcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfEDIt_edificaciondetalle]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfEDIt_edificaciondetalle](
	[ACFid] [int] NULL,
	[EDIzona] [char](18) NULL,
	[EDIdescripicion] [char](100) NULL,
	[EDIfactorasignado] [decimal](12, 2) NULL,
	[ACFValorIR] [decimal](12, 2) NULL,
	[ACFTC] [decimal](12, 2) NULL,
	[ACFCRC] [decimal](12, 2) NULL,
	[ACFDEPCRC] [decimal](12, 2) NULL,
	[ACFNETOCRC] [decimal](12, 2) NULL,
	[ACFvalorniif] [decimal](12, 2) NULL,
	[ACFdepacuniif] [decimal](12, 2) NULL,
	[ACFNETOPCGA] [decimal](12, 2) NULL,
	[ACFDIFCosto] [decimal](12, 2) NULL,
	[ACFINCCosto] [decimal](12, 2) NULL,
	[ACFDISCosto] [decimal](12, 2) NULL,
	[ACFDIFDEP] [decimal](12, 2) NULL,
	[ACFINCDep] [decimal](12, 2) NULL,
	[ACFDISDep] [decimal](12, 2) NULL,
	[ACFDIFNeta] [decimal](12, 2) NULL,
	[ACFSumDifDed] [decimal](12, 2) NULL,
	[ACFSumDifGra] [decimal](12, 2) NULL,
	[ACFSumACTDif] [decimal](12, 2) NULL,
	[ACFSumPasDif] [decimal](12, 2) NULL,
	[ACFcuenta] [char](18) NULL,
	[LOClocal] [char](18) NULL,
	[RVAcodigo] [char](18) NOT NULL,
 CONSTRAINT [XPKacfEDIt_edificaciondetalle] PRIMARY KEY CLUSTERED 
(
	[RVAcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfESTt_Estado]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfESTt_Estado](
	[ESTid] [int] NOT NULL,
	[ESTestado] [varchar](20) NULL,
 CONSTRAINT [XPKacfESTt_Estado] PRIMARY KEY CLUSTERED 
(
	[ESTid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfICRt_Inventariocaracteristicas]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfICRt_Inventariocaracteristicas](
	[MARid] [int] NOT NULL,
	[ESTid] [int] NOT NULL,
	[CRSserie] [varchar](30) NULL,
	[CRSmodelo] [varchar](35) NULL,
	[CRScolor] [varchar](35) NULL,
	[MATid] [int] NOT NULL,
	[CRStipo] [char](1) NULL,
	[UNMid] [int] NOT NULL,
	[CRScantidad] [decimal](18, 2) NULL,
	[CRSvehplaca] [varchar](15) NULL,
	[CRSvehexpediente] [varchar](15) NULL,
	[CRSvehinscripcion] [datetime] NULL,
	[CRSvehclase] [varchar](35) NULL,
	[CRSvehcombustible] [varchar](35) NULL,
	[CRSvehejes] [int] NULL,
	[CRSvehpasajeros] [int] NULL,
	[CRSvehasientos] [int] NULL,
	[CRSvehpesoseco] [decimal](18, 2) NULL,
	[CRSvehcargautil] [decimal](18, 2) NULL,
	[CRSaltura] [decimal](18, 2) NULL,
	[CRSancho] [decimal](18, 2) NULL,
	[CRSvelocidad] [varchar](20) NULL,
	[CRSresolucion] [varchar](20) NULL,
	[CRScapacidad] [varchar](20) NULL,
	[CRSpotencia] [varchar](20) NULL,
	[CRSvnominal] [varchar](20) NULL,
	[CRSventrada] [varchar](20) NULL,
	[CRSvsalida] [varchar](20) NULL,
	[CRSfrecuencia] [varchar](20) NULL,
	[CRStemperatura] [varchar](20) NULL,
	[CRSprocesador] [varchar](100) NULL,
	[CRSpuertos] [varchar](100) NULL,
	[CRSutmx] [decimal](18, 2) NULL,
	[CRSutmy] [decimal](18, 2) NULL,
	[CRSesfuerzopunta] [varchar](20) NULL,
	[CRScajaderivadora] [varchar](20) NULL,
	[CRSalquilacable] [char](1) NULL,
	[CRScentropoblado] [varchar](60) NULL,
	[CRSurbanizacion] [varchar](60) NULL,
	[CRScalle] [varchar](60) NULL,
	[CRSlote] [varchar](10) NULL,
	[CRSnumeropredio] [varchar](20) NULL,
	[CRSdepartamento] [varchar](10) NULL,
	[CRSinterior] [varchar](10) NULL,
	[CRScarretera] [varchar](50) NULL,
	[CRSkilometro] [decimal](18, 2) NULL,
	[CRSnombrepredio] [varchar](60) NULL,
	[CRSpisospredio] [int] NULL,
	[CRSpartidapredio] [varchar](15) NULL,
	[CRStomopredio] [varchar](15) NULL,
	[CRSfolioinipredio] [varchar](10) NULL,
	[CRSfoliofinpredio] [varchar](10) NULL,
	[CRSasientopredio] [varchar](15) NULL,
	[CRSfinscpredio] [datetime] NULL,
	[CRSficharegistral] [varchar](20) NULL,
	[CRSareaconstruida] [decimal](18, 2) NULL,
	[CRSperimetro] [decimal](18, 2) NULL,
	[CRSusopredio] [varchar](60) NULL,
	[CRSvalorautovaluo] [decimal](18, 2) NULL,
	[CRScodigoluz] [varchar](20) NULL,
	[CRScodigoagua] [varchar](20) NULL,
	[CRSfadqpredio] [datetime] NULL,
	[CRSobservacion] [varchar](254) NULL,
	[INVid] [int] NOT NULL,
	[ACFid] [int] NOT NULL,
 CONSTRAINT [XPKacfICRt_Inventariocaracteristicas] PRIMARY KEY CLUSTERED 
(
	[INVid] ASC,
	[ACFid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfINBt_Inventariobienes]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfINBt_Inventariobienes](
	[INVid] [int] NOT NULL,
	[ACFid] [int] NOT NULL,
	[ACFactivo] [varchar](100) NULL,
	[BUKRS] [char](4) NOT NULL,
	[SEGMENT] [char](10) NOT NULL,
	[KOSTL] [char](10) NOT NULL,
	[ANLKL] [char](8) NOT NULL,
	[PERNR] [char](8) NOT NULL,
	[ACTid] [char](2) NOT NULL,
	[CSTid] [char](4) NOT NULL,
	[VNRid] [char](20) NOT NULL,
	[ACFfincorporacion] [datetime] NULL,
	[ACFfcapitalizacion] [datetime] NULL,
	[ACFvutiltribanio] [int] NULL,
	[ACFvutiltribdia] [int] NULL,
	[ACFvalortrib] [decimal](18, 2) NULL,
	[ACFfactortrib] [decimal](18, 6) NULL,
	[ACFdepacutrib] [decimal](18, 2) NULL,
	[ACfvutilniifanio] [int] NULL,
	[ACFvutilniifdia] [int] NULL,
	[ACFvalorniif] [decimal](18, 2) NULL,
	[ACFfactorniif] [decimal](18, 6) NULL,
	[ACFdepacuniif] [decimal](18, 2) NULL,
	[ACFobra] [char](10) NULL,
	[ACFord41] [char](4) NULL,
	[ACFord42] [char](4) NULL,
	[ACFord43] [char](4) NULL,
	[ACFord44] [char](4) NULL,
	[ACFanlue] [char](12) NULL,
	[ACFcuenta] [char](18) NULL,
	[ACFcuentadep] [char](18) NULL,
	[LIFNR] [char](15) NOT NULL,
	[BLART] [char](2) NOT NULL,
	[ACFcomprobante] [char](18) NULL,
	[ACFnotaingreso] [char](18) NULL,
	[ACFfechanotaingreso] [datetime] NULL,
	[ACFordencompra] [char](18) NULL,
	[ACFobservacion] [varchar](254) NULL,
	[AMBid] [int] NOT NULL,
	[UBEid] [int] NOT NULL,
	[ACFfechacomprobante] [datetime] NULL,
	[ACFfechaordencompra] [datetime] NULL,
 CONSTRAINT [XPKacfINBt_Inventariobienes] PRIMARY KEY CLUSTERED 
(
	[INVid] ASC,
	[ACFid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfINVp_Inventario]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfINVp_Inventario](
	[INVid] [int] NOT NULL,
	[INVdetalle] [varchar](100) NULL,
	[INVinicio] [datetime] NULL,
	[INVcierre] [datetime] NULL,
	[INVactivo] [bit] NULL,
 CONSTRAINT [XPKacfINVt_Inventario] PRIMARY KEY CLUSTERED 
(
	[INVid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfLOCt_Local]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfLOCt_Local](
	[LOCid] [int] NOT NULL,
	[LOClocal] [varchar](100) NULL,
	[LOCdireccion] [varchar](100) NULL,
	[SEGMENT] [char](10) NULL,
 CONSTRAINT [XPKacfLOCt_Local] PRIMARY KEY CLUSTERED 
(
	[LOCid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfMARt_Marca]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfMARt_Marca](
	[MARid] [int] NOT NULL,
	[MARmarca] [varchar](60) NULL,
 CONSTRAINT [XPKacfMARt_Marca] PRIMARY KEY CLUSTERED 
(
	[MARid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfMATt_Material]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfMATt_Material](
	[MATid] [int] NOT NULL,
	[MATmaterial] [char](60) NULL,
	[MATabreviado] [char](10) NULL,
 CONSTRAINT [XPKacfMATt_Material] PRIMARY KEY CLUSTERED 
(
	[MATid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfMEQt_maquinariaequipo]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfMEQt_maquinariaequipo](
	[MEQvnrtot] [decimal](12, 2) NULL,
	[MEQcantidad] [decimal](12, 2) NULL,
	[MEQaccffecinc] [decimal](12, 2) NULL,
	[MEQabreviatura] [char](18) NULL,
	[MEQopiniontecnica] [char](18) NULL,
	[MEQctacontable] [decimal](12, 2) NULL,
	[MEQniif] [decimal](12, 2) NULL,
	[MEQvrident] [decimal](12, 2) NULL,
	[MEQprovdes] [decimal](12, 2) NULL,
	[MEQcostorepcor] [decimal](12, 2) NULL,
	[MEQfactorinst] [decimal](12, 2) NULL,
	[MEQvalorresi] [decimal](12, 2) NULL,
	[MEQedadact] [decimal](12, 2) NULL,
	[MEQdeptas] [decimal](12, 2) NULL,
	[MEQvalorref] [decimal](12, 2) NULL,
	[MEQvalref2] [decimal](12, 2) NULL,
	[MEQvsm] [decimal](12, 2) NULL,
	[MEQestado] [decimal](12, 2) NULL,
	[MEQvidautil] [decimal](12, 2) NULL,
	[MEQvidautmax] [decimal](12, 2) NULL,
	[MEQedadtec] [decimal](12, 2) NULL,
	[MEQdepreciacion] [decimal](12, 2) NULL,
	[MEQdep2012] [decimal](12, 2) NULL,
	[MEQcostocorr] [decimal](12, 2) NULL,
	[MEQvaloractivo] [decimal](12, 2) NULL,
	[MEQdepre] [decimal](12, 2) NULL,
	[MEQtasair] [decimal](12, 2) NULL,
	[MEQimpdife] [decimal](12, 2) NULL,
	[MEQdifneta] [decimal](12, 2) NULL,
	[MEQvalorneto] [decimal](12, 2) NULL,
	[MEQvalact] [decimal](12, 2) NULL,
	[MEQcostotcorr] [decimal](12, 2) NULL,
	[MEQdepacuniif] [decimal](12, 2) NULL,
	[MEQcrcnet] [decimal](12, 2) NULL,
	[MEQvalnet] [decimal](12, 2) NULL,
	[MEQdiferenneta] [decimal](12, 2) NULL,
	[MEQvalornetolib] [decimal](12, 2) NULL,
	[MEQdepacumtrib] [decimal](12, 2) NULL,
	[MEQcostohistorico] [decimal](12, 2) NULL,
	[RVAcodigo] [char](18) NOT NULL,
 CONSTRAINT [XPKacfMEQt_maquinariaequipo] PRIMARY KEY CLUSTERED 
(
	[RVAcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfMVAt_MovimientoActivo]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfMVAt_MovimientoActivo](
	[MVAid] [int] NOT NULL,
	[ACFid] [int] NOT NULL,
	[ACFactivo] [varchar](254) NULL,
	[BUKRS] [char](4) NOT NULL,
	[SEGMENT] [char](10) NOT NULL,
	[KOSTL] [char](10) NULL,
	[ANLKL] [char](8) NULL,
	[PERNR] [char](8) NOT NULL,
	[CSTid] [char](4) NOT NULL,
	[TMVid] [char](2) NOT NULL,
	[MVMid] [char](2) NOT NULL,
	[ACFfmovimiento] [datetime] NULL,
	[VNRid] [char](20) NOT NULL,
	[ACFfincorporacion] [datetime] NULL,
	[ACFfcapitalizacion] [datetime] NULL,
	[ACFvutiltribanio] [int] NULL,
	[ACFvutiltribdia] [int] NULL,
	[ACFvalortrib] [decimal](18, 2) NULL,
	[ACFfactortrib] [decimal](18, 6) NULL,
	[ACFdepacutrib] [decimal](18, 2) NULL,
	[ACFvutilniifanio] [int] NULL,
	[ACFvutilniifdia] [int] NULL,
	[ACFvalorniif] [decimal](18, 2) NULL,
	[ACFfactorniif] [decimal](18, 6) NULL,
	[ACFdepacuniif] [decimal](18, 2) NULL,
	[ACFobra] [char](10) NULL,
	[ACFord41] [char](4) NULL,
	[ACFord42] [char](4) NULL,
	[ACFord43] [char](4) NULL,
	[ACFord44] [char](4) NULL,
	[ACFanlue] [char](12) NULL,
	[ACFcuenta] [char](18) NULL,
	[ACFcuentadep] [char](18) NULL,
	[ACFcomprobante] [char](18) NULL,
	[ACFnotaingreso] [char](18) NULL,
	[ACFfechanotaingreso] [datetime] NULL,
	[ACFordencompra] [char](18) NULL,
	[ACFfechaordencompra] [datetime] NULL,
	[ACFobservacion] [char](254) NULL,
	[LIFNR] [char](15) NOT NULL,
	[BLART] [char](2) NOT NULL,
	[AMBid] [int] NOT NULL,
	[CMPid] [char](15) NOT NULL,
	[UBEid] [int] NOT NULL,
 CONSTRAINT [XPKacfMVAt_MovimientoActivo] PRIMARY KEY CLUSTERED 
(
	[MVAid] ASC,
	[ACFid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfMVMt_MotivoMovimiento]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfMVMt_MotivoMovimiento](
	[TMVid] [char](2) NOT NULL,
	[MVMid] [char](2) NOT NULL,
	[MVMmotivomovimiento] [char](60) NULL,
	[MVMjustificacion] [char](1) NULL,
 CONSTRAINT [XPKacfMVMt_MotivoMovimiento] PRIMARY KEY CLUSTERED 
(
	[MVMid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfPDFt_procesodiferido]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfPDFt_procesodiferido](
	[PDFcodigo] [int] NOT NULL,
	[PDFperiodo] [char](18) NULL,
	[PDFfecha] [datetime] NULL,
	[PDFreponsable] [char](100) NULL,
	[PDFestado] [bit] NULL,
 CONSTRAINT [XPKacfPDIt_procesodiferido] PRIMARY KEY CLUSTERED 
(
	[PDFcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfRTRt_Reparotributario]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfRTRt_Reparotributario](
	[RTRperiodo] [char](6) NULL,
	[RTRfecha] [datetime] NULL,
	[RTRresponsable] [char](50) NULL,
	[RTRestado] [bit] NULL,
	[RTRcodigo] [int] NOT NULL,
 CONSTRAINT [XPKacfRTRt_Reparotributario] PRIMARY KEY CLUSTERED 
(
	[RTRcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfRVAt_registrovaluacion]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfRVAt_registrovaluacion](
	[RVAcodigo] [char](18) NOT NULL,
	[RVAperiodo] [char](18) NULL,
	[RVAfecha] [char](18) NULL,
	[RVAresponsable] [char](18) NULL,
	[RVRestado] [char](18) NULL,
 CONSTRAINT [XPKacf_RVAt_registrovaluacion] PRIMARY KEY CLUSTERED 
(
	[RVAcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfSELt_SistemaElectrico]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfSELt_SistemaElectrico](
	[SELid] [char](6) NOT NULL,
	[SELsistemaelectrico] [varchar](25) NULL,
	[SEGMENT] [char](10) NULL,
 CONSTRAINT [XPKacfSELt_SistemaElectrico] PRIMARY KEY CLUSTERED 
(
	[SELid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfSPNt_Supranumero]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfSPNt_Supranumero](
	[V_T087U_ANLUE] [char](12) NOT NULL,
	[V_T087U_ANLUE_TXT] [char](100) NULL,
 CONSTRAINT [XPKacfSPNt_Supranumero] PRIMARY KEY CLUSTERED 
(
	[V_T087U_ANLUE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfTMVt_TipoMovimiento]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfTMVt_TipoMovimiento](
	[TMVid] [char](2) NOT NULL,
	[TMVtipomovimiento] [char](60) NULL,
 CONSTRAINT [XPKacfTMVt_TipoMovimiento] PRIMARY KEY CLUSTERED 
(
	[TMVid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfTRNt_terrenodetalle]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfTRNt_terrenodetalle](
	[CRSnombrepredio] [char](18) NULL,
	[CRScentropoblado] [char](18) NULL,
	[CRSdepartamento] [char](18) NULL,
	[CRSinterior] [char](18) NULL,
	[CRScarretera] [char](18) NULL,
	[CRSkilometro] [char](18) NULL,
	[ACFArea] [char](18) NULL,
	[ACFvalor] [char](18) NULL,
	[ACFtc] [char](18) NULL,
	[ACFvalorSoles] [char](18) NULL,
	[ACFValorDolar] [char](18) NULL,
	[ACFValorAnt0] [char](18) NULL,
	[ACFVutilniff] [char](18) NULL,
	[ACFNetopcga] [char](18) NULL,
	[ACFvalorATri] [char](18) NULL,
	[ACFid] [char](18) NULL,
	[ACFdiferencia] [char](18) NULL,
	[ACFDifTemDedu] [char](18) NULL,
	[ACFDifTemGrav] [char](18) NULL,
	[ACFTasaIR] [char](18) NULL,
	[ACFSaldoDeducible] [char](18) NULL,
	[ACFSaldoGravable] [char](18) NULL,
	[RVAcodigo] [char](18) NOT NULL,
 CONSTRAINT [XPKacfTR] PRIMARY KEY CLUSTERED 
(
	[RVAcodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfUBEt_UbicacionElectrica]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfUBEt_UbicacionElectrica](
	[UBEcodigogis] [bigint] NULL,
	[UBEobra] [char](10) NULL,
	[KOSTL] [char](10) NOT NULL,
	[VNRid] [char](20) NOT NULL,
	[SELid] [char](6) NULL,
	[UBEset] [bigint] NULL,
	[UBEsetetq] [varchar](30) NULL,
	[UBEalimentador] [bigint] NULL,
	[UBEalimentadoretq] [varchar](10) NULL,
	[UBEsed] [bigint] NULL,
	[UBEsedetq] [varchar](10) NULL,
	[UBEcircuito] [bigint] NULL,
	[UBEcircuitoetq] [varchar](10) NULL,
	[UBEpuntoi] [bigint] NULL,
	[UBEpuntoietq] [varchar](10) NULL,
	[UBEpuntof] [bigint] NULL,
	[UBEpuntofetq] [varchar](10) NULL,
	[UBEid] [int] NOT NULL,
	[ACFid] [int] NULL,
 CONSTRAINT [XPKacfUBEt_UbicacionElectrica] PRIMARY KEY CLUSTERED 
(
	[UBEid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfUNMt_Unimed]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfUNMt_Unimed](
	[UNMid] [int] IDENTITY (1, 1) NOT NULL,
	[UNMunidad] [char](3) NULL,
	[UNMdetalle] [char](20) NULL,
 CONSTRAINT [XPKacfUNMt_Unimed] PRIMARY KEY CLUSTERED 
(
	[UNMid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[acfVNRt_VNR]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acfVNRt_VNR](
	[VNRid] [char](20) NOT NULL,
	[VNRvnr] [char](150) NULL,
	[VNRcuenta] [char](20) NULL,
	[VNRcuentadep] [char](20) NULL,
 CONSTRAINT [XPKacfVNRt_VNR] PRIMARY KEY CLUSTERED 
(
	[VNRid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdiCAFpClaseDeActivoFijo]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdiCAFpClaseDeActivoFijo](
	[ANLKL] [char](8) NOT NULL,
	[TXK50] [char](50) NULL,
 CONSTRAINT [XPKbdiCAFpClaseDeActivoFijo] PRIMARY KEY CLUSTERED 
(
	[ANLKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdiCDDpClasesDeDocumento]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdiCDDpClasesDeDocumento](
	[BLART] [char](2) NOT NULL,
	[LTEXT] [char](100) NULL,
	[DETdoctipo] [char](2) NULL,
 CONSTRAINT [XPKbdiCDDpClasesDeDocumento] PRIMARY KEY CLUSTERED 
(
	[BLART] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdiPRVpProveedor]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdiPRVpProveedor](
	[LIFNR] [char](15) NOT NULL,
	[Name1] [char](100) NULL,
	[Stras] [char](100) NULL,
	[STCD1] [char](16) NULL,
 CONSTRAINT [XPKbdiPRVpProveedor] PRIMARY KEY CLUSTERED 
(
	[LIFNR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdiSEGpSegmento]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdiSEGpSegmento](
	[SEGMENT] [char](10) NOT NULL,
	[NAME] [char](50) NULL,
	[id_zona] [varchar](1) NULL,
 CONSTRAINT [XPKbdiSEGpSegmento] PRIMARY KEY CLUSTERED 
(
	[SEGMENT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdiSOCpSociedades]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdiSOCpSociedades](
	[BUKRS] [char](4) NOT NULL,
	[BUTXT] [char](80) NULL,
 CONSTRAINT [XPKbdiSOCpSociedades] PRIMARY KEY CLUSTERED 
(
	[BUKRS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdiXCCpExtraccionSAP_CentroCosto]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdiXCCpExtraccionSAP_CentroCosto](
	[KOSTL] [char](10) NOT NULL,
	[KTEXT] [char](20) NULL,
	[KLTXT] [char](40) NULL,
	[MCDS3] [char](20) NULL,
 CONSTRAINT [XPKbdiXCCpExtraccionSAP_CentroCosto] PRIMARY KEY CLUSTERED 
(
	[KOSTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdiXPEpExtraccionSAP_Personal]    Script Date: 11/04/2017 11:17:16  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdiXPEpExtraccionSAP_Personal](
	[PERNR] [char](8) NOT NULL,
	[Nachn] [char](40) NULL,
	[Name2] [char](40) NULL,
	[Vorna] [char](40) NULL,
	[DNI] [char](30) NULL,
	[WERKS] [char](4) NULL,
	[Persg] [char](1) NULL,
	[KOSTL] [char](10) NOT NULL,
 CONSTRAINT [XPKbdiXPEpExtraccionSAP_Personal] PRIMARY KEY CLUSTERED 
(
	[PERNR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([AMBid])
REFERENCES [dbo].[acfAMBt_Ambiente] ([AMBid])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([ANLKL])
REFERENCES [dbo].[bdiCAFpClaseDeActivoFijo] ([ANLKL])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([BLART])
REFERENCES [dbo].[bdiCDDpClasesDeDocumento] ([BLART])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([BUKRS])
REFERENCES [dbo].[bdiSOCpSociedades] ([BUKRS])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([CMPid])
REFERENCES [dbo].[acfCMPt_Componente] ([CMPid])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([CSTid])
REFERENCES [dbo].[acfCSTt_Costo] ([CSTid])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([KOSTL])
REFERENCES [dbo].[bdiXCCpExtraccionSAP_CentroCosto] ([KOSTL])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([LIFNR])
REFERENCES [dbo].[bdiPRVpProveedor] ([LIFNR])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([MVMid])
REFERENCES [dbo].[acfMVMt_MotivoMovimiento] ([MVMid])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([PERNR])
REFERENCES [dbo].[bdiXPEpExtraccionSAP_Personal] ([PERNR])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([SEGMENT])
REFERENCES [dbo].[bdiSEGpSegmento] ([SEGMENT])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD FOREIGN KEY([VNRid])
REFERENCES [dbo].[acfVNRt_VNR] ([VNRid])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD  CONSTRAINT [R_62] FOREIGN KEY([UBEid])
REFERENCES [dbo].[acfUBEt_UbicacionElectrica] ([UBEid])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo] CHECK CONSTRAINT [R_62]
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo]  WITH CHECK ADD  CONSTRAINT [R_82] FOREIGN KEY([V_T087U_ANLUE])
REFERENCES [dbo].[acfSPNt_Supranumero] ([V_T087U_ANLUE])
GO
ALTER TABLE [dbo].[acfACFp_Activo_Fijo] CHECK CONSTRAINT [R_82]
GO
ALTER TABLE [dbo].[acfAMBt_Ambiente]  WITH CHECK ADD FOREIGN KEY([LOCid])
REFERENCES [dbo].[acfLOCt_Local] ([LOCid])
GO
ALTER TABLE [dbo].[acfCRSt_Caracteristicas]  WITH CHECK ADD FOREIGN KEY([ACFid])
REFERENCES [dbo].[acfACFp_Activo_Fijo] ([ACFid])
GO
ALTER TABLE [dbo].[acfCRSt_Caracteristicas]  WITH CHECK ADD FOREIGN KEY([ESTid])
REFERENCES [dbo].[acfESTt_Estado] ([ESTid])
GO
ALTER TABLE [dbo].[acfCRSt_Caracteristicas]  WITH CHECK ADD FOREIGN KEY([MARid])
REFERENCES [dbo].[acfMARt_Marca] ([MARid])
GO
ALTER TABLE [dbo].[acfCRSt_Caracteristicas]  WITH CHECK ADD FOREIGN KEY([MATid])
REFERENCES [dbo].[acfMATt_Material] ([MATid])
GO
ALTER TABLE [dbo].[acfCRSt_Caracteristicas]  WITH CHECK ADD FOREIGN KEY([UNMid])
REFERENCES [dbo].[acfUNMt_Unimed] ([UNMid])
GO
ALTER TABLE [dbo].[acfCSTt_Costo]  WITH CHECK ADD FOREIGN KEY([ACTid])
REFERENCES [dbo].[acfACTt_Actividad] ([ACTid])
GO
ALTER TABLE [dbo].[acfDDFt_detalledediferido]  WITH CHECK ADD FOREIGN KEY([PDFcodigo])
REFERENCES [dbo].[acfPDFt_procesodiferido] ([PDFcodigo])
GO
ALTER TABLE [dbo].[acfDRTt_detallereparotributario]  WITH CHECK ADD FOREIGN KEY([RTRcodigo])
REFERENCES [dbo].[acfRTRt_Reparotributario] ([RTRcodigo])
GO
ALTER TABLE [dbo].[acfEDIt_edificaciondetalle]  WITH CHECK ADD FOREIGN KEY([RVAcodigo])
REFERENCES [dbo].[acfRVAt_registrovaluacion] ([RVAcodigo])
GO
ALTER TABLE [dbo].[acfEDIt_edificaciondetalle]  WITH CHECK ADD  CONSTRAINT [R_90] FOREIGN KEY([ACFid])
REFERENCES [dbo].[acfACFp_Activo_Fijo] ([ACFid])
GO
ALTER TABLE [dbo].[acfEDIt_edificaciondetalle] CHECK CONSTRAINT [R_90]
GO
ALTER TABLE [dbo].[acfICRt_Inventariocaracteristicas]  WITH CHECK ADD FOREIGN KEY([MARid])
REFERENCES [dbo].[acfMARt_Marca] ([MARid])
GO
ALTER TABLE [dbo].[acfICRt_Inventariocaracteristicas]  WITH CHECK ADD FOREIGN KEY([MATid])
REFERENCES [dbo].[acfMATt_Material] ([MATid])
GO
ALTER TABLE [dbo].[acfICRt_Inventariocaracteristicas]  WITH CHECK ADD FOREIGN KEY([UNMid])
REFERENCES [dbo].[acfUNMt_Unimed] ([UNMid])
GO
ALTER TABLE [dbo].[acfICRt_Inventariocaracteristicas]  WITH CHECK ADD FOREIGN KEY([INVid], [ACFid])
REFERENCES [dbo].[acfINBt_Inventariobienes] ([INVid], [ACFid])
GO
ALTER TABLE [dbo].[acfICRt_Inventariocaracteristicas]  WITH CHECK ADD  CONSTRAINT [R_79] FOREIGN KEY([ESTid])
REFERENCES [dbo].[acfESTt_Estado] ([ESTid])
GO
ALTER TABLE [dbo].[acfICRt_Inventariocaracteristicas] CHECK CONSTRAINT [R_79]
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([ACFid])
REFERENCES [dbo].[acfACFp_Activo_Fijo] ([ACFid])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([ACTid])
REFERENCES [dbo].[acfACTt_Actividad] ([ACTid])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([AMBid])
REFERENCES [dbo].[acfAMBt_Ambiente] ([AMBid])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([ANLKL])
REFERENCES [dbo].[bdiCAFpClaseDeActivoFijo] ([ANLKL])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([BLART])
REFERENCES [dbo].[bdiCDDpClasesDeDocumento] ([BLART])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([BUKRS])
REFERENCES [dbo].[bdiSOCpSociedades] ([BUKRS])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([CSTid])
REFERENCES [dbo].[acfCSTt_Costo] ([CSTid])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([INVid])
REFERENCES [dbo].[acfINVp_Inventario] ([INVid])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([KOSTL])
REFERENCES [dbo].[bdiXCCpExtraccionSAP_CentroCosto] ([KOSTL])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([LIFNR])
REFERENCES [dbo].[bdiPRVpProveedor] ([LIFNR])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([PERNR])
REFERENCES [dbo].[bdiXPEpExtraccionSAP_Personal] ([PERNR])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([SEGMENT])
REFERENCES [dbo].[bdiSEGpSegmento] ([SEGMENT])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([UBEid])
REFERENCES [dbo].[acfUBEt_UbicacionElectrica] ([UBEid])
GO
ALTER TABLE [dbo].[acfINBt_Inventariobienes]  WITH CHECK ADD FOREIGN KEY([VNRid])
REFERENCES [dbo].[acfVNRt_VNR] ([VNRid])
GO
ALTER TABLE [dbo].[acfLOCt_Local]  WITH CHECK ADD FOREIGN KEY([SEGMENT])
REFERENCES [dbo].[bdiSEGpSegmento] ([SEGMENT])
GO
ALTER TABLE [dbo].[acfMEQt_maquinariaequipo]  WITH CHECK ADD FOREIGN KEY([RVAcodigo])
REFERENCES [dbo].[acfRVAt_registrovaluacion] ([RVAcodigo])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([ACFid])
REFERENCES [dbo].[acfACFp_Activo_Fijo] ([ACFid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([AMBid])
REFERENCES [dbo].[acfAMBt_Ambiente] ([AMBid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([ANLKL])
REFERENCES [dbo].[bdiCAFpClaseDeActivoFijo] ([ANLKL])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([BLART])
REFERENCES [dbo].[bdiCDDpClasesDeDocumento] ([BLART])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([BUKRS])
REFERENCES [dbo].[bdiSOCpSociedades] ([BUKRS])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([CSTid])
REFERENCES [dbo].[acfCSTt_Costo] ([CSTid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([KOSTL])
REFERENCES [dbo].[bdiXCCpExtraccionSAP_CentroCosto] ([KOSTL])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([LIFNR])
REFERENCES [dbo].[bdiPRVpProveedor] ([LIFNR])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([MVMid])
REFERENCES [dbo].[acfMVMt_MotivoMovimiento] ([MVMid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([PERNR])
REFERENCES [dbo].[bdiXPEpExtraccionSAP_Personal] ([PERNR])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([SEGMENT])
REFERENCES [dbo].[bdiSEGpSegmento] ([SEGMENT])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([TMVid])
REFERENCES [dbo].[acfTMVt_TipoMovimiento] ([TMVid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([UBEid])
REFERENCES [dbo].[acfUBEt_UbicacionElectrica] ([UBEid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD FOREIGN KEY([VNRid])
REFERENCES [dbo].[acfVNRt_VNR] ([VNRid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo]  WITH CHECK ADD  CONSTRAINT [R_52] FOREIGN KEY([CMPid])
REFERENCES [dbo].[acfCMPt_Componente] ([CMPid])
GO
ALTER TABLE [dbo].[acfMVAt_MovimientoActivo] CHECK CONSTRAINT [R_52]
GO
ALTER TABLE [dbo].[acfMVMt_MotivoMovimiento]  WITH CHECK ADD FOREIGN KEY([TMVid])
REFERENCES [dbo].[acfTMVt_TipoMovimiento] ([TMVid])
GO
ALTER TABLE [dbo].[acfSELt_SistemaElectrico]  WITH CHECK ADD FOREIGN KEY([SEGMENT])
REFERENCES [dbo].[bdiSEGpSegmento] ([SEGMENT])
GO
ALTER TABLE [dbo].[acfTRNt_terrenodetalle]  WITH CHECK ADD FOREIGN KEY([RVAcodigo])
REFERENCES [dbo].[acfRVAt_registrovaluacion] ([RVAcodigo])
GO
ALTER TABLE [dbo].[acfUBEt_UbicacionElectrica]  WITH CHECK ADD FOREIGN KEY([KOSTL])
REFERENCES [dbo].[bdiXCCpExtraccionSAP_CentroCosto] ([KOSTL])
GO
ALTER TABLE [dbo].[acfUBEt_UbicacionElectrica]  WITH CHECK ADD FOREIGN KEY([SELid])
REFERENCES [dbo].[acfSELt_SistemaElectrico] ([SELid])
GO
ALTER TABLE [dbo].[acfUBEt_UbicacionElectrica]  WITH CHECK ADD FOREIGN KEY([VNRid])
REFERENCES [dbo].[acfVNRt_VNR] ([VNRid])
GO
ALTER TABLE [dbo].[acfUBEt_UbicacionElectrica]  WITH CHECK ADD  CONSTRAINT [R_85] FOREIGN KEY([ACFid])
REFERENCES [dbo].[acfACFp_Activo_Fijo] ([ACFid])
GO
ALTER TABLE [dbo].[acfUBEt_UbicacionElectrica] CHECK CONSTRAINT [R_85]
GO
