create table ACFValuacion
(
VNR_ID varchar(20) not null primary key
,VNR_descripcion varchar(130) null
,VNR_ubicacion varchar(50) null 
,VNR_valor decimal(18,2) null default 0
);


create table ACFValorResidual
(
VNR char(4) primary key not null
,DESCRIPCIÓN varchar(130)
,UNID_MEDIDA char(4)
,PREC_UNITARIO decimal(18,2) null default 0
,FACT_VARIACIÓN decimal(18,2) null default 0
,PREC_UNIT_FINAL decimal(18,2) null default 0
);

create table ACFValorResidualNiff
(
NIIF int not null primary key
,PREC_UNIT_TASACION decimal(18,2) null default 0
,VAL_RESIDUAL decimal(18,2) null default 0
);

create table ACFVR_IDENT
(
VRI varchar(20) null
,NIIF int null default 0
);

create table ACFCODNIIF_SistELECTRICO
(
CTA_CONTABLE varchar(10) not null 
,TODO  varchar(7) not null
,TOMASIRI varchar(10)
,YARADA varchar(10)
,TARATA varchar(10)
,TACNA varchar(10)
,MOQU varchar(10)
,POU varchar(10)
,ICHUÑA varchar(10)
,ILO varchar(10)
primary key(CTA_CONTABLE,TODO)
);

create table ACFBAJATENSION
(
CTA_CONTABLE varchar(10) not null 
,VNR varchar(20) not null 
,VNR_DECRIPCION varchar(200) null 
primary key (CTA_CONTABLE,VNR)
);

create table ACFMEDIATENSION
(
CTA_CONTABLE varchar(10) not null 
,VNR varchar(20) not null 
,VNR_DECRIPCION varchar(200) null 
primary key (CTA_CONTABLE,VNR)
);

create table ACFVIDAUTILTASADA
(
campo1 int null
,campo2 decimal(18,2) null default 0
,campo3 int null
,campo4 varchar(130) null
,Vida_Util int null
);

create table ACFFACTTRANSFORMADORES
(
ESTADO char(8) not null primary key
,PONDERACIÓN decimal(18,2) null default 0
,FACTOR_INDISPONIBILIDAD decimal(18,2) null default 0
,FACTOR_PLANTA decimal(18,2) null default 0
,LIMITE_LEGAL decimal(18,2) null default 0
,FACTOR_CORROSIÓN int null
,FACTOR_TOTAL decimal(18,2) null default 0
);































