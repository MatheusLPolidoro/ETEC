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

drop database if exists estoque;

create database if not exists estoque;

use estoque;

create table if not exists produtoestocavel (
CodProd int auto_increment  key,
NomeProd varchar(40) not null,
TipoUnid char(5) not null, 
PesoUnid decimal (7, 2) not null, 
ValorCompra decimal (5, 2) not null,
ValorVenda decimal (5, 2) not null,
QtdadeEstoque int not null,
UndMedida char(2) not null,
Marca varchar(20) not null,
constraint Restricao unique (PesoUnid, TipoUnid, Marca , UndMedida) 
)engine = 'InnoDB';

create table if not exists produtoperecivel (
DtValidade date not null,
produtoestocavel_CodProd int not null unique,
constraint fkprodestperecivelestocavel foreign key(produtoestocavel_CodProd)
references produtoestocavel (CodProd) 
)engine = 'InnoDB';
