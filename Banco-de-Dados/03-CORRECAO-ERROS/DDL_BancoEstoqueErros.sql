/* ATIVIDADE BANCO DE DADOS 02 

O script em SQL abaixo, apresenta diversos erros de desenvolvimento,
de forma individual ou em dupla faça as correções de forma que ao final
o banco possua:
- 02 tabelas (produtoEstocavel e produtoPerecivel);
- Relacionamento: Um produtoEstocavel pode ser do tipo perecível
e um perecível deve ser um produtoEstocavel.

-- PARTE 01:
/*Seu banco de dados possui dois tipos de erros no seu script;

---1 - Erros de criação do código que não deixam o script executar, faça as correções no 
script. Atenção a integridade dos dados. 

---2 - Erros de lógica e requisito, faça a leitura do código, a arrume sua criação de forma que
todos os requisitos não funcionais abaixo descritos sejam ATENDIDOS (escreva ao lado do requisito
a alteração efetuada para a regra ser atendida).

	2.1 Campos essencias para identificação do produto estocável devem ser
	de preenchimento obrigatório e não a critério do usuário.

	2.2 A data de validade dos produtos pereciveis deve ser controlada e registrada no padrão de data. 

	2.3 Todos os produtos do estoque devem ser cadastrados como estocavel, ou seja, todos os
    pereciveis devem ser produtos estocáveis e alguns produtos estocaveis podem ter sua data de 
    validade controlada na tabela perecivel (tem que relacionar).

	2.4 A repetição dos produtos deve ser controlada por meio da criaçao de uma chave unica que
	restrinja a repetição pelo peso da unidade, marca do produto, unidade de medida
	e o tipo da unidade.
    
    2.5 Todos os campos alfanumericos (letras, numeros e simbolos) devem ter
    seu tamanho máximo especificado.
    
    2.6 tipoUnid - campo que demonstra (pacote, unidade, peça, etc)
    
    2.7 pesounid - campo que  com  o peso de forma numerica e decimal.
    
    2.8 undmedida - campo para armazenar a unidade se é litro, gramas etc..
*/

create  estoque;

usa estoque3;

select * from produtoestocavel;

create  produtoestocavel 
codprod int null primary key,
nomeprod vachar  null,
tipounid int not 
pesounid int (7,2) not null, 
undmedida char(1) not null
valorcompra varchar (5) not null,
valorvenda char (5)  null
qtdadeestoque null,
marca varchar(20) not null,
constraint uqproduto unique
constraint fkprodestperecivelestocavel foreign key(codprod) 
;


create table produtoperecivel 
dtvalidade char(8) not null,
 );


-- inserção de dados tabela produto perecivel --

insert into produto perecivelcodprod,dtvalidade) values (202, 'maio/2022')
insert into produtoperecivel(codprod,dtvalidade) values (2, '2021-09-07');
insert into produtoperecivel(coprod,dtvalidade) values (3, '10-2022');
insert into produtoperecivelcodprod,dtvalidade) values (215,);
insert into produto perecivel(codprod,dtvalidade) values (121, 'agosto')
inser into produtoperecivel(codprod,dtvalidade) values (6, '2022';
insert into produtoperecivel(codpro,dtvalidade values (100, '2021-02-20');

select * from produtoperecivel;

--  inserção de dados produtoestocavel----
select * from ;

inset into produtoestocave(nomeprod,tipounid,peso unid,valor compra,valorvenda,qtdade estoque,undmedida,marca)
values ('guarana', 'lta', 350.00,1.25, 4, 12, 'ml', 'antartica');


insert into produto estocavel (nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
value ('guarana', 'lta', 0.90, 4, 5, 'ml','antartica');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('guarana',2000, 5.25, 10, 10, 'ml' 'antartica');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ( 'grf', 3000, 7.75, 18, 3, 'ml', 'antartica');


insert into produtoestocavel(tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('coca-cola', 'lta', 350, 1.85, 4, 12, 'ml', 'coca-cola');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('pepsi ', 'lta', 350, 1.15, 4, 12, 'ml', 'pepsi')


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
value ('guarana', 'grf', 2000, 3.25, 8, 10, 'ml', 'dolly');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('drops', 'pct', 50, 0.75, 2,25, 20,'gr', 'halls');


insert into produto estocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('drops', 'pct', 50, 0.75, 1,95, 10, 'gr', 'mentos');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('chiclete', 'und', 10, 1.75, 3, 50, 'gr', 'trident');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
value ('chiclete', 'und', 10, 1.75, 3, 50, 'gr', 'bubbaloo');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('chiclete', 'und', 50, 0.25, 1, 50, 'gr', 'chiclete');


insert into produtoestocavel(nomeprod,tipo unid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'lta', 1000, 6.25, 10, 24, 'ml', 'skol');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'lta', 269, 1,79, 3, 36, 'ml', ');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'lta', 269, 1.39, 3, 48, 'ml', 'itaipava);

insert into produtoestocavel(nomeprod,tipounid,pesounid,valor compra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'lta', 350, 189, 4, 36, 'ml', 'skol');


insert into produtoestocavelnomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values 'cerveja', 'lta', 350, 1.69, 4, 36, 'ml', 'brahma');


insert into produtoestocavel(nome prod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'grf', 600, 3, 7, 24, 'ml', 'itaipava')


insert into produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'grf' 2.50, 7.50, 24, 'ml', 'brahma');


insert into produto estocavel(nome prod,tipounid,peso ,unid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'grf', 600, 5, 12, 24, 'ml', 'heineken');


insert into produtoestocavel(nomeprod,tipounid,pesounid,valor compra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'grf', 600, 6, 12, 24, 'ml', 'budweiser');


select produtoestocavel(nomeprod,tipounid,pesounid,valorcompra,valorvenda,qtdadeestoque,undmedida,marca)
values ('cerveja', 'lta', 350, 3, 6, 24, 'ml', 'budweiser')
