CREATE DATABASE myfinance;
use myfinance;

create table planoconta(
id int identity (1,1) not null,
descricao varchar(50) not null,
tipo char(1) not null,
primary key(id)
);

select * from planoconta;

create table transacao(
id int identity (1,1) not null,
date datetime not null,
valor decimal(9,2),
historico text,
planocontaid int not null,
primary key(id),
foreign key(planocontaid) references planoconta(id)
);

select * from transacao;

insert into planoconta (descricao, tipo)
values ('Combustível', 'D');
insert into transacao (date, valor, historico, planocontaid)
values ('20230215 07:00', 10.5, 'Americanas', 3);

select * 
from transacao t 
inner join planoconta p on t.planocontaid = p.id  
where p.tipo = 'D' and t.date between '20230101' and '20230131'
select * from transacao where valor > 200;
select sum(valor) from transacao;
select sum(valor)