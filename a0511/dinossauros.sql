create table dinossauros (
    dinossauros_id integer not null primary key identity,
    dinossauros_nome varchar(150) not null,
    dinossauros_grupo varchar(50) not null,
    dinossauros_toneladas integer not null,
    dinossauros_ano_descoberta integer not null,
    dinossauros_descobridor varchar(50) not null,
    dinossauros_era varchar(50) not null,
    dinossauros_pais varchar(50) not null
)
create table eras (
    eras_nome varchar(50) not null,
    eras_ano_inicio integer not null,
    eras_ano_fim integer not null,
    eras_fk_dinossauros integer not null,
    foreign key (eras_fk_dinossauros) references dinossauros(dinossauros_id)
)
create table grupo (
    grupo_nome varchar(50) not null,
    grupo_fk_dinossauros integer not null,
    foreign key (grupo_fk_dinossauros) references dinossauros(dinossauros_id)
)