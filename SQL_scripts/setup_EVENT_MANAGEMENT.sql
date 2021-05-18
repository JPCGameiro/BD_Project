/*	
** script to instaciate Database for bd project
**
** Pedro Abreu & João Gameiro
 */
 use p2g5

 go

 
-- schema
if not exists (select * from sys.schemas where name='EM') -- EM -> EVENT_MANAGEMENT
begin
  exec('create schema EM;')
end

go

-- types
if not exists( select * from sys.types where name = 'id')
begin
	create type id from CHAR(20)
end

if not exists( select * from sys.types where name = 'name')
begin
	create type name from varchar(150)
end

if not exists( select * from sys.types where name = 'cc')
begin
	create type cc from char(12)
end

if not exists( select * from sys.types where name = 'email')
begin
	create type email from varchar(100)
end

if not exists( select * from sys.types where name = 'telefone')
begin
	create type telefone from char(12)
end

go 
--tables
create table EM.PROMOTOR(
numCC				cc				not null,
nome				name,
email				email,			--unique?
telefone			telefone
primary key (numCC)
)


create table EM.STAGEMANAGER(
numCC				cc				not null,
nome				name,
email				email,			--unique?
telefone			telefone,
primary key(numCC)
)


create table EM.EVENTO(
id					id				not null,
nome				name			not null,
numdias				int									check (numdias > 0),
dataini				date			not null,
datafim				date,
numbilhetes			int,
cc_promotor			cc,
dataproposta		date,
cc_stageManager		cc,
primary key (id),
foreign key (cc_promotor) references EM.PROMOTOR(numCC) on delete set null on update cascade,
foreign key (cc_stageManager) references EM.STAGEMANAGER(numCC) on delete set null on update cascade,
check (dataproposta < dataini), -- se ao introduzir uma destas for null, a check rebenta?
check (dataini < datafim)
)


create table EM.BANDA(
id					id				not null,
nome				name			not null,
telefone			telefone,
email				email,
numElem				int,
genero				varchar(200)
primary key(id)
)

create table EM.SOUNDCHECK(
id					id				not null,
duracao				time,
datatimeini			datetime,
primary key(id)
)

create table EM.CONCERTO(
id					id				not null,
datatimeini			datetime		not null,
duracao				time,
id_banda			id,
id_evento			id,
id_soundcheck		id,
primary key(id),
foreign key (id_banda) references EM.BANDA(id) on delete set null on update cascade,
foreign key(id_evento) references EM.EVENTO(id) on delete set null on update cascade,
foreign key(id_soundcheck) references EM.SOUNDCHECK(id) on delete set null on update cascade,
) -- como check/ver que datatime inicio concerto é dps datetime inicio do evento?

go




