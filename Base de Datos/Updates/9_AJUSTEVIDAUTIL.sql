create procedure usp_S_AjusteVidaUtil
@ACFID as int
as
select
[ACFid]
,[ACFdescripcion]
,[ACFvutilniifanio]
,[ACFvutilniifdia]
,null as [VidaUtilNiffanioMOD]
,null as [VidaUtilNiffdiaMOD]
,[ACFvutiltribanio]
,[ACFvutiltribdia]
,null as [VUtilTribAnioMOD]
,null as [VUtilTribDiaMOD]
,[ACFdepacutrib]
,[ACFdepacuniif]
,[CMPid]
FROM [dbo].[acfACFp_Activo_Fijo]
WHERE ACFid = @ACFID
