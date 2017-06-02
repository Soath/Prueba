-- detalle Diferido
ALTER TABLE [dbo].[acfDDFt_detalledediferido] DROP  CONSTRAINT [XPKacfDDFt_detalledediferido];

ALTER TABLE [dbo].[acfDDFt_detalledediferido] ADD CONSTRAINT [XPKacfDDFt_detalledediferido] PRIMARY KEY
 ([PDFcodigo] , [INVZU] )

alter table [dbo].[acfDDFt_detalledediferido]
alter column [INVZU] char(100) not null;


-- Detalle Reparo Tributario
ALTER TABLE [dbo].[acfDRTt_detallereparotributario] DROP  CONSTRAINT [XPKacfDRTt_detallereparotributario];

ALTER TABLE [dbo].[acfDRTt_detallereparotributario] ADD CONSTRAINT [XPKacfDRTt_detallereparotributario] PRIMARY KEY
 ([RTRcodigo] , [INVZU] )

alter table [dbo].[acfDRTt_detallereparotributario]
alter column [INVZU] char(100) not null;