go
create table Usuario(
    IdUsuario       integer           identity,
	Nome            nvarchar(50)      not null,
	Login           nvarchar(50)      not null  unique,
	Email           nvarchar(50)      not null,
	Senha           nvarchar(50)      not null,
	primary Key(IdUsuario))

go
create table Contato(
    IdContato       integer            identity,
	NomeContato     nvarchar(50)       not null,
	EmailContato    nvarchar(50)       not null,
	Telefone        nvarchar(50)       not null,
	IdUsuario       integer            not null  unique,
	primary Key(IdContato)) 

go
alter table Contato add constraint FKContatoUsuario
foreign key (IdUsuario) references Usuario(IdUsuario)

go
create table Compromisso(
    IdCompromisso        integer          identity,
	Titulo               nvarchar(50)     not null,
	Descricao            nvarchar(max)    not null,  
	Data                 datetime         not null,
	IdUsuario            integer          not null  unique,
	primary key(IdCompromisso))

go
alter table Compromisso add constraint FKCompromissoUsuario
foreign key (IdUsuario) references Usuario(IdUsuario)

	