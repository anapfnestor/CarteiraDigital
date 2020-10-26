CREATE DATABASE carteiraDigital
GO

USE carteiraDigital
GO


--create table TipoDocumento
--(
--	intCodDocumento int primary key identity(1,1),
--	strNomeDocumento varchar(20)
--)

--GO

--insert into TipoDocumento (strNomeDocumento)
--values ('CPF'), ('Passaporte');

--GO


create table Paises
(
	intCodPais int primary key identity(1,1),
	strNomePais varchar(60)
)

go
create table IdadeMinPorNacionalidade
(
	intCodIdadeNac int primary key identity(1,1),
	intCodNacionalidade int,
	intIdadeMin int,
	CONSTRAINT fk_IdadeMinPorNacionalidade_Paises foreign key (intCodNacionalidade) references Paises (intCodPais)

)

GO

insert into Paises (strNomePais)
values ('Brasil')

go

insert into IdadeMinPorNacionalidade (intCodNacionalidade,intIdadeMin)
values (scope_identity(), 18)

go

insert into Paises (strNomePais)
values('Estados Unidos')

go

create table Pessoa
(
	intCodPessoa int primary key identity(1,1),
	strNome varchar(60),
	strSobrenome varchar(60),
	dtDataNacimento datetime,
	strDocumento varchar(15) not null,
	intCodNacionalidade int,
	CONSTRAINT fk_NacionalidadePessoa foreign key (intCodNacionalidade) references Paises (intCodPais)
)

GO

create table Usuario
(
	intCodUsuario int primary key identity(1,1),
	intCodPessoa int,
	strUsuario varchar(60),
	strSenha varchar(40),
	CONSTRAINT fk_usuarioCliente foreign key (intCodPessoa) references Pessoa (intCodPessoa)
)


go

insert into IdadeMinPorNacionalidade (intCodNacionalidade,intIdadeMin)
values (scope_identity(), 21)

go

create table posicaoCarteira
(
	intCodSaldo int primary key identity(1,1),
	decValor decimal(19,2)
)

GO

create table PessoaPosicaoCarteira
(
	intCodPesPosCar int primary key identity(1,1),
	intCodSaldo int,
	intCodPessoa int,
	CONSTRAINT fk_PessoaPosicaoCarteira_Pessoa foreign key (intCodPessoa) references Pessoa (intCodPessoa),
	CONSTRAINT fk_PessoaPosicaoCarteira_Saldo foreign key (intCodSaldo) references posicaoCarteira (intCodSaldo)
)

GO

create table Extrato
(
	intCodExtrato int primary key identity(1,1),
	strDescricao varchar(200),
	strTipoTransacao varchar(1),
	decValor decimal(19,2)
)

GO

create table PessoaExtrato
(
	intCodPesExt int primary key identity(1,1),
	intCodPessoa int,
	intCodExtrato int,
	CONSTRAINT fk_PessoaExtrato_Pessoa foreign key (intCodPessoa) references Pessoa (intCodPessoa),
	CONSTRAINT fk_PessoaExtrato_Extrato foreign key (intCodExtrato) references Extrato (intCodExtrato)
)

GO



go