alter table [dbo].[acfINBt_Inventariobienes]

alter column [UBEid] int null


Alter table [dbo].[acfINBt_Inventariobienes] 
Add default '0' for [ACFvutiltribanio] 

EXECUTE sp_rename 'Sales.SalesTerritory.TerritoryID', 'TerrID', 'COLUMN';