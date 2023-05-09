DROP TABLE usuario;


create table usuario
(
id_usuario int primary key identity,
login_usuario varchar(40) not null,
senha_usuario char(20) not null,
nome_usuario text not null,
registro_usuario int UNIQUE not null,
setor_usuario varchar(40) not null
)

insert into usuario
(login_usuario, senha_usuario, nome_usuario, registro_usuario, setor_usuario)
values('ali','ali','ali', '123','TI')

select * from usuario

DROP TABLE produto;

create table produto
(
id int primary key identity,
nome varchar(100)  not null,
descricao varchar(100),
validade varchar(12) not null,
setor varchar(40) not null,
qtdmin varchar(20) not null,
qtdmax varchar(20) not null,
qtdatual varchar(20) not null,
emailfor varchar(40) not null,
emailcom varchar(40) not null,
data DATETIME NOT NULL DEFAULT(CONVERT(varchar(10), GETDATE(), 103))
)

insert into produto
(nome, descricao, validade, setor, qtdmin, qtdmax,qtdatual, emailfor, emailcom)
values('teste','teste','teste', 'teste','teste','teste','teste','teste','teste')

select * from  usuario