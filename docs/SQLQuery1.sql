CREATE DATABASE myfinance;
use myfinance;

create table planoconta(
id int identity (1,1) not null,
descricao varchar(50) not null,
tipo char(1) not null,
primary key(id)
);

create table transacao(
id int identity (1,1) not null,
date datetime not null,
valor decimal(9,2),
historico text,
planocontaid int not null,
primary key(id),
foreign key(planocontaid) references planoconta(id)
);

-- insert into planoconta (descricao, tipo)
-- values ('Combustível', 'D');
-- insert into transacao (date, valor, historico, planocontaid)
-- values ('20230215 07:00', 10.5, 'Americanas', 3);
