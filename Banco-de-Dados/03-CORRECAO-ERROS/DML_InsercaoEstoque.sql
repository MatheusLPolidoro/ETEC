delete from produtoperecivel;
delete from produtoestocavel;

--  inserção de dados produtoestocavel----
insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('refrigerante', 'lata', 350, 1.20, 2.79, 12, 'ml', 'fanta');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('refrigerante', 'lata', 350, 1.50, 2.99, 5, 'ml', 'coca-cola');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('refrigerante', 'grf', 2, 3.89, 4.99, 15, 'l', 'sukita');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('cerveja', 'lata', 269, 1.39, 3, 48, 'ml', 'itaipava');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('cerveja', 'lata', 350, 189, 4, 36, 'ml', 'skol');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('cerveja', 'grf', 600, 5, 12, 24, 'ml', 'heineken');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('cerveja', 'grf', 600, 6, 12, 24, 'ml', 'budweiser');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('sucrilhos', 'und', 1, 15, 24.90, 16, 'kg', 'Kelloggs');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('grão de bico', 'und',  500.00, 1.30, 6.52, 10, 'gr', 'yoki');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('drops', 'pct', 50, 0.75, 2.25, 20, 'gr', 'halls');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('drops', 'pct', 50, 0.55, 1.95, 10, 'gr', 'mentos');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
values ('chiclete', 'pct', 10, 1.75, 3, 50, 'gr', 'trident');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('pó para gelatina', 'pct', 30, 0.75, 1.45, 32, 'gr', 'Bretzke');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('óleo de soja', 'pct', 900, 7.80, 9.79, 19, 'ml', 'soya');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('óleo de soja', 'und', 900, 8.00, 9.99, 19, 'ml', 'liza');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('óleo de soja', 'und', 900, 7.60, 9.59, 14, 'ml', 'cocamar');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('extrato de tomate', 'und', 300, 2.20, 3.47, 26, 'gr', 'quero');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('extrato de tomate', 'und', 850, 8.75, 10.99, 8, 'gr', 'elefante');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('arroz integral', 'pct', 1, 3.20, 4.39, 17, 'kg', 'camil');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('arroz integral', 'pct', 1, 3.09, 4.09, 12, 'kg', 'solito');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('açúcar', 'pct', 1, 3.55, 4.99, 7, 'kg', 'união');

insert into produtoestocavel(NomeProd, TipoUnid, PesoUnid, ValorCompra, ValorVenda, QtdadeEstoque, UndMedida, Marca)
value ('café', 'pct', 250, 5.75, 6.99, 9, 'gr', 'pilão');


-- inserção de dados tabela produto perecivel --
insert into produtoperecivel (produtoestocavel_CodProd, DtValidade) values ('1', '2022-04-15');
insert into produtoperecivel (produtoestocavel_CodProd, DtValidade) values ('2', '2022-04-15');
insert into produtoperecivel (produtoestocavel_CodProd, DtValidade) values ('3','2022-04-16');
insert into produtoperecivel (produtoestocavel_CodProd, DtValidade) values ('4','2022-04-16');
insert into produtoperecivel (produtoestocavel_CodProd, DtValidade) values ('5','2022-04-14');
insert into produtoperecivel (produtoestocavel_CodProd, DtValidade) values ('6','2022-04-14');
insert into produtoperecivel (produtoestocavel_CodProd, DtValidade) values ('7','2022-04-14');

select * from produtoestocavel;
select * from produtoperecivel;