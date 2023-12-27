create procedure teste5 (@nome as Varchar(50))
as
insert into descobridor values (@nome)
 
exec teste5 'Fabrício'
exec teste5 @nome='Isaque'