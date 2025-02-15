create database crud_csharp;

create table colaborador(
	codigo_colaborador int(11) null primary key,
	nome_colaborador varchar(50) null,
	sobrenome_colaborador varchar(50) null,
	cpf_colaborador varchar(50) null
);