/*	
	Banco de dados II
	Modelo de Negócio: Oficina Mecânica
	Professora: Ângela Silva
	Aluno: Matheus Polidoro
	DML - Data Manipulation Linguage
*/

use oficinamecanica;

insert into cliente (nome, endereco, telefone, cnh) values ('Matheus', 'Rua x', '1123456789','123');
insert into cliente (nome, endereco, telefone, cnh) values ('ingrid', 'Rua x', '1123456789','456');

insert into veiculo (placa, ano, renavan, modelo, marca, cnh) values ("edm112", "2010", "553", "PALIO", "FIANT", "123");
insert into veiculo (placa, ano, renavan, modelo, marca, cnh) values ("btf112", "2019", "453", "caminhao", "scania", "456");
insert into veiculopesado (comprimentoMetro, eixo, tonelada, placa) values (8.50, 2, 25, "btf112");

select * from cliente;
select * from veiculo;
select * from veiculopesado;
