create database login;
-- comando para criar o banco de dados 
use login;
-- comando para acessar um banco no servidor

create table usuario
	(
		nome varchar(60) not null,
		cpf char(11) not null primary key,
		login varchar(30) not null unique,
		senha int not null
		);
        
 /* qualquer manutenção em uma tabela existente deve
 ser feita por meio de alteração de tabela*/
 
 -- excluir a chave primaria da coluna cpf
 alter table usuario drop primary key;
 
 -- incluir uma chave do tipo unique no cpf
 alter table usuario add constraint uqcpf unique (cpf);
 
 -- alterar tabela criando uma coluna nova com a chave primaria
 alter table usuario add idUsuario int auto_increment primary key;
 
 -- COMANDO INSERT INTO para inserir valores (DML)
 insert into usuario (nome, cpf, login, senha)
 values("MARIA LEOPOLDINA", "12345678900", "maria@123", 123456); 
 
 select nome, cpf, login, senha, idUsuario from usuario;
 select nome from usuario;
 select * from usuario;
 
 insert into usuario (nome, cpf, login, senha)
 values("JOÃO DE BARRO", "12345678910", "joao@123", 12); 
 
 -- criando nova tabela
 create	table registraAcesso (
	dataAcesso date not null,
    horario time not null,
	idAcesso int auto_increment not null primary key
 );
 
 
 -- RELACIONAMENTO ENTRE USUARIO 1 - REGISTRAACESSO N
alter table registraAcesso add cpf char(11);
alter table registraAcesso modify cpf char(11) not null;
alter table registraAcesso add constraint fkRegUsuario foreign key(cpf) references usuario(cpf);
 
create table conta(
	foto varchar(30),
	statusConta bit not null,
	perfil char(100),
	cpf char(11) not null primary key,
	constraint fkUsuarioConta foreign key(cpf) references usuario(cpf)
);

alter table conta modify statusConta bit not null;
alter table conta add cpf char(11) not null primary key;
alter table conta add constraint fkUserConta foreign key(cpf) references usuario(cpf);
 
drop table conta;
desc conta;
 