drop database if exists venda;
-- comando para criação do banco de dados
create database venda;

-- conexão no banco de dados criados
use venda;

-- criação da tabela produto
create table Produto (
valor decimal(7,2) not null,
quantidade int not null,
nomeProduto varchar(50) not null unique,
codProduto int auto_increment not null primary key);

select * from produto;

-- criação da tabela cliente
create table Cliente (
nomeCliente varchar(60) not null,
cpf char(11) not null unique,
endereco varchar(100) null,
codCliente int auto_increment not null primary key
);
select * from cliente;

-- criação da tabela venda - oriunda do relacionamento entre Cliente e Produto
create table venda (
codVenda int auto_increment not null primary key,
codCliente int not null,
codProduto int not null,
constraint fkClienteVenda foreign key (codCliente) references Cliente (codCliente),
constraint fkProdutoVenda foreign key (codProduto) references Produto (codProduto)
);
select * from venda;