create table java
(
    professor varchar(20) null
)

create table net
(
    professor varchar(20) null
)

insert into net 
values ('Fabrício'),('Ricardo'),('Alexandre')

insert into java 

values ('Fabrício'),('Lucas'),('Deivison')
------------

create table log 

(

    id integer not null primary key identity,

   acao varchar(10) not null,

   descricao varchar(100),

    quando datetime not null	
)

------------

create trigger primeiratrigger
on java
AFTER DELETE
as 
BEGIN
    insert into log values ('Exclusão', 
            'Um professor de Java foi excluido', 
            GETDATE())
END

 

------------

 

create trigger segundatrigger
on java
after insert
as 
begin
    insert into log values ('Inserção', 
        'Add prof java', GETDATE());
    PRINT('Dados Inseridos');
end
------------
create trigger terceiratrigger
on java
after insert
as 
begin
    declare @contagem int
    select @contagem = (select count(professor) from java)

 

    PRINT('Quantidade de professores: ' + 
            CONVERT(varchar(10), @contagem));

 

    IF @contagem < 3
        begin
            insert into log values ('Inserção', 
                    'Add prof java', GETDATE());
            print('Inserido com sucesso');
        end
    ELSE
        begin
            ROLLBACK;
            insert into log values ('Inserção', 
                    'Tentativa de inserção mal sucedida!', GETDATE());
            RAISERROR('INVALIDO', 14, 1);
            RETURN;
        end
end
------------
drop trigger quartatrigger

create trigger quartatrigger

on java

after update

as

begin

    declare @anterior varchar(20)

    declare @novo varchar(20)

 

    select @anterior = (select deleted.professor from deleted)

    select @novo = (select inserted.professor from inserted)

 

    IF(ROWCOUNT_BIG() = 0)

        return;

 

    IF @anterior= @novo

    begin

        raiserror('SEM ALTERAÇÕES', 14, 1);

        rollback transaction;

        insert into log values ('Atualização', 

            'Tentativa de update mal sucedida!', GETDATE());

    end

    ELSE

    begin

        insert into log values ('upd', 

            'Alteração do prof, ' + @anterior + 

            ' para ' + @novo, GETDATE());

    end

end
------------
 

select * from java

 

select * from log

 

update java set professor = 'Fabrício' 

where professor = 'Lucas'
