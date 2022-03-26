/*	
	Banco de dados II
	Modelo de Negócio: Oficina Mecânica
	Professora: Ângela Silva
	Aluno: Matheus Polidoro
	DDL - Data Definition Linguage
*/

-- criação do banco se ele não existe
CREATE DATABASE IF NOT EXISTS oficinaMecanica;

-- comando para utilizar um banco do servidor
use oficinaMecanica;

-- apagar todas as tabelas se elas existirem
SET FOREIGN_KEY_CHECKS = 0;

drop table if exists mecanico;
drop table if exists cliente;
drop table if exists veiculo;
drop table if exists veiculoPesado;
drop table if exists revisa;

-- criação das tabelas
create table if not exists mecanico(
nome varchar(50) not null,
endereco varchar(100) not null,
celular char(9),
cpf char(11) not null unique,
crea char(5) not null primary key
);

create table if not exists cliente(
nome varchar(30) not null,
endereco varchar(100) not null,
telefone char(11),
cnh char(11) not null primary key
);

-- relacionamento de veiculo e veiculo pesado 1 : 1
-- tabela generalista
create table if not exists veiculo(
placa char(7) not null primary key,
ano char(4),
ranavan char(9) not null unique,
modelo varchar(30), 
marca varchar(30),
cnh char(11) not null,
constraint fkCnh foreign key (cnh)
references cliente (cnh)
);

-- tabela especialista
create table if not exists veiculoPesado(
comprimentoMetro decimal(4, 2) not null,
eixo int not null,
tonelada decimal(5, 2) not null,
placa char(7) not null unique,
constraint fkPlaca foreign key (placa)
references veiculo (placa)
);

create table if not exists revisa(
idRevisao int auto_increment not null primary key,
dataRevisao datetime not null,
valor decimal not null,
relatorio varchar(100),
placa char(7) not null,
crea char(5) not null,    
index (dataRevisao)
);

alter table revisa add constraint fkPlacaRevisa foreign key (placa) references veiculo (placa);
alter table revisa add constraint fkCrea foreign key(crea) references mecanico (crea);
