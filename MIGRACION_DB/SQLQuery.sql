select
[ACFcodigo_gis] as [UBEcodigogis],
[PRYid_proyecto] as [UBEobra],
[SAPKOSTL] as [KOSTL],
[ACFcodigo_vnr] as [VNRid],
[ACFid_sistelec] as [SELid], 
[ACFid_set] as [UBEset],
null as [UBEsetetq],
[ACFid_alimentador] as [UBEalimentador],
null as [UBEalimentadoretq],
[ACFid_sed] as [UBEsed],
null as [UBEsedetq],
[ACFid_circuito] as [UBEcircuito],
null as [UBEcircuitoetq],
[ACFpunto_inicio] as [UBEpuntoi],
null as [UBEpuntoietq],
[ACFpunto_fin] as [UBEpuntof],
null as [UBEpuntofetq],
identity(int,1,1) as [UBEid],
null as [ACFid]
into #temp
from [dbo].[acfACFp_Activo_Fijo]

select top 1000 * from #temp


select distinct [VNRid] from #temp

drop table #temp


--   SELECT
--   identity(int,1,1) as id,
--   [LOCid],[AMBid],[AMBambiente]
--   null as namecampo,
--   into #temp
--   FROM [dbo].[acfAMBt_Ambiente]
--   select * from #temp