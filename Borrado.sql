delete from [dbo].[acfCRSt_Caracteristicas];

delete from [dbo].[acfUBEt_UbicacionElectrica];

delete from [dbo].[acfCMVp_Cabecera_Movimiento];

delete from [dbo].[acfMVAt_MovimientoActivo];

delete from [dbo].[acfACFp_Activo_Fijo];

insert into [dbo].[acfACFp_Activo_Fijo] (ACFid, AMBID, UBEID,V_T087U_ANLUE) values ('0','0','0','0');

insert into [dbo].[acfUBEt_UbicacionElectrica] ([KOSTL],[VNRid], [UBEid], [ACFid]) values ('0','0','0','0')
 
