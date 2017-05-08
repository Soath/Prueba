USE [ActivosFijos]
GO
/****** Object:  StoredProcedure [dbo].[usp_S_AjusteVidaUtil]    Script Date: 07/05/2017 4:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_U_AjusteVidaUtil]
@iACFid as int OUTPUT
, @iACFvutilniifanio int OUTPUT
, @iACFvutilniifdia int OUTPUT
, @iACFvutiltribanio int OUTPUT
, @iACFvutiltribdia int OUTPUT

as
UPDATE [dbo].[acfACFp_Activo_Fijo]
SET
[ACFvutilniifanio] = @iACFvutilniifanio
,[ACFvutilniifdia] = @iACFvutilniifdia
,[ACFvutiltribanio] = @iACFvutiltribanio
,[ACFvutiltribdia] = @iACFvutiltribdia
WHERE 
[ACFid] = @iACFid
select
@iACFid = [ACFid]
,@iACFvutilniifanio = [ACFvutilniifanio]
,@iACFvutilniifdia = [ACFvutilniifdia]
,@iACFvutiltribanio = [ACFvutiltribanio]
,@iACFvutiltribdia = [ACFvutiltribdia]
FROM [dbo].[acfACFp_Activo_Fijo]
WHERE 
[ACFid] = @iACFid
