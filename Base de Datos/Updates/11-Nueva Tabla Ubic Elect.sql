
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
,Zona char(8)
,VNRid char(20)
,CodNiff char(30)
,ValAct int
,VidUtilTrib int
,VidUtilFinan int
,UBEestado char(1)
-- ,FOREIGN KEY (KOSTL) REFERENCES bdiXCCpExtraccionSAP_CentroCosto(KOSTL)
-- ,FOREIGN KEY (VNRid) REFERENCES acfVNRt_VNR(VNRid)
)
