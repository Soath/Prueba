use ActivosFijos;
go

delete from [dbo].[acfCRSt_Caracteristicas];

delete from [dbo].[acfUBEt_UbicacionElectrica];

delete from [dbo].[acfCMVp_Cabecera_Movimiento];

delete from [dbo].[acfINVp_Inventario];

delete from [dbo].[acfINBt_Inventariobienes];

delete from [dbo].[acfICRt_Inventariocaracteristicas];

delete from [dbo].[acfMVAt_MovimientoActivo];

delete from [dbo].[acfACFp_Activo_Fijo];



insert into [dbo].[acfACFp_Activo_Fijo] (ACFid, AMBID, UBEID,V_T087U_ANLUE) values ('0','0','0','0');

insert into [dbo].[acfUBEt_UbicacionElectrica] ([KOSTL],[VNRid], [UBEid], [ACFid]) values ('0','0','0','0')
 
 delete from [dbo].[acfPDFt_procesodiferido];

 delete from [dbo].[acfDDFt_detalledediferido];

 delete from [dbo].[acfRTRt_Reparotributario];

 delete from [dbo].[acfDRTt_detallereparotributario];
