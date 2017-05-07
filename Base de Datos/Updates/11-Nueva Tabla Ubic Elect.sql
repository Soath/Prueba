
create table acfGIS_UbicacionElectrica(
UBEid int primary key
,UBEcodigogis bigint
,ACFid int
,SELid bigint
,UBEset bigint
,UBEsetetq varchar(30)
,UBEalimentador bigint
,UBEalimetiquetadoretq varchar(10)
,UBEsed bigint
,UBEsedetq varchar(10)
,UBcircuito bigint
,UBEcircuitoetq varchar(10)
,UBEtipoPuntoi bigint
,UBEpuntoi bigint
,UBEpuntoietq varchar(10)
,UBEtipoPuntof bigint
,UBEpuntof bigint
,UBEpuntofetq varchar(10)
,UBEobra char(10)
,KOSTL char(10)
,VNRid char(7)
)
