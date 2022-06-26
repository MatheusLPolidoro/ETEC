use venda;
/* toda vez que iniciar uma nova query, deve ativar 
o banco que prentende trabalhar, por meio do comando use*/
-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
SET SQL_SAFE_UPDATES=0;
-- comando para retirar as restrições de insert, update e delete da estrutura do banco

-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-- comando delete permite excluir todos os registros para fins de testes
delete from vendaitem;
delete from venda;
delete from cliente;
delete from produto;
-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

-- comando select permite consultar a situação atual da tabelselect * from cliente;
select * from produto;
select * from venda;
select * from vendaitem;

-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-- inserção de dados tabela Cliente
alter table cliente modify column cep char(8);
insert into cliente (nomeCliente, cpf, tipoLogradouro, nomeRua, numeroResidencial, bairro, cidade, uf, cep)
values ('João Antonio do Prado', 12345678987, 'Alameda', 'Verão', 35, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Maria da Silva', 22345678987, 'Rua', 'Inverno', 35, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Carlos Alberto', 33345678987, 'Rua', 'Verão', 135, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Mario dos Santos', 44345678987, '', 'Verão', 1035, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Eufrasino Silva', 55345678987, 'Alameda', 'Verão', 935, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Euripedes Silva', 55345672987, 'Alameda', 'Verão', 835, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Juventina Silva', 77345678987, 'Alameda', 'Verão',305, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Irinacio dos Santos', 88345678987, 'Alameda', 'Verão',352, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Gualberto Ruan', 99345678987, 'Alameda', 'Verão',350, 'centro', 'Franco da Rocha', 'sp', '07600030'),
       ('Matildo Peregrino', 55345378987, 'Alameda', 'Verão',315, 'centro', 'Franco da Rocha', 'sp', '07600030');

-- 05 erros
/* 
 1) nome da coluna errado: nResidencial → numeroResidencial
 2) colocar aspas simples no final do valor 'Maria da Silva'
 3) remover aspas do final do valor 22345678987
 4) colocar o 'e' no nome da tabela 'cliente'
 5) Duplicidade da chave primaria cpf para Eufrasino Silva e Matildo Peregrino número 55345678987
 6) erro extra - tamanho da coluna cep menor que o tamanho dos dados colocadas
 
*/
-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-- inserção de dados tabela Produto       

describe produto;
insert into produto (nomeProduto, valor, quantidade, categoria, genero, tipo, marca)
value ('camiseta gola V', 59.9, 100, 'camiseta', 'f', 'manga curta', 'hering'),
	   ('camisa polo', 89.9, 50, 'camiseta', 'f', 'manga curta', 'levis'),
	   ('calça skin', 159.9, 10, 'calça', 'f', 'skin', 'jeans lavado'), 
	   ('short preto', 109.9, 80, 'short', 'm', 'desfiado', 'jeans lavado'),
	   ('short branco', 129.9, 70, 'short', 'f', 'desfiado', 'jeans lavado'),
       ('short jeans', 129.9, 70, 'short', 'f', 'desfiado', 'jeans lavado'),
	   ('blusa moletom', 139.9, 100, 'Moletom', 'f', 'fechado', 'moletinho'),
	   ('blusa moletom', 179.9, 50, 'moletom', 'u', 'aberto', 'moletinho'),
	   ('calça sarja', 89.9, 100, 'camiseta', 'f', 'manga curta', 'hering'),
       ('legging', 99.9, 120, 'legging', 'f', 'cintura alta', 'castelo'),
       ('calça', 99.9, 100, 'camiseta', 'f', 'manga curta', 'hering');
-- 05 erros
/*
1) aspas no meio do valor 'camiseta gola V' e aspas no final do valor 'camiseta gola V' duplicadas
2) valor com ',' ao invez de '.' no campo com valor de 159,9
3) falta virgula no final da linha ('calça sarja', 89.9, 100, 'camiseta', 'feminino', 'manga curta', 'hering'),
4) tamanho dos valores da coluna genero maiores que o temanho definido na DDL
5) produtos com nomes iguais não respeitando a constraint da tabela
*/
-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-- inserção de dados tabela Venda

insert into venda (codCliente, dataHora)
values (1, '2022/10/05 13:35'),
	(1, '2022/10/08 16:35'),
    (1, '2022/10/08 16:35'),
    (2, '2022/01/10 12:35'),
    (3, '2022/10/10 12:35'),
    (4, '2022/2/13 11:35'),
    (4, '2022/1/12 15:35'),
    (5, '2022/10/10 14:35'),
    (6, '2022/5/10 8:35'),
    (6, '2022/1/10 12:35'),
    (7, '2022/1/12 12:35'),
    (7, '2022/10/10 12:35'),
    (7, '2022/3/10 9:35'),
    (8, '2022/8/20 12:35'),
    (9, '2022/8/10 11:35'),
    (10, '2022/10/02 11:35'),
    (10, '2022/02/02 13:35');
-- 07 erros
/*
1) faltando aspas no começo
2) faltando Virgula entre o primeiro valor e o segundo
3) caracter ';' no lugar de ','
4) integridade referencial não respeitada na coluna codCliente
5) data com formação incorreta '20220110'
6) não localizado
7) não localizado
*/    
-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-- inserção de dados tabela VendaItem

insert into vendaitem (codVenda, codProduto, quantidadeVendida, valorUnit)
values 
	(1,  8, 2, 89.9),
	(1, 10, 3, 99.9),
    (2, 2, 4, 59.9),
    (3,  6, 2, 129.9),
    (4,  4, 1, 159.9),
    (5,  3, 2, 89.9),
    (6, 45, 4, 89.9),
    (6,  7, 1, 139.9),
    (7, 9, 2, 99.9),
    (7, 11, 2, 99.9),
    (7,  3, 1, 89.9),
    (7, 10, 2, 99.9),
    (8,  3, 2, 89.9);
-- 05 erros
/*
1) integridade referencial não respeitado na coluna codCliente
2) nome da coluna 'quantidadeVendida' incorreto
3) valor 159,9 com ',' ao invés de '.'
4) unique constraint duplicada codVenda = 7, codProduto = 11
5) não localizado
*/















