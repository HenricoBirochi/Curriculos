create table Curriculos(
	curriculoId int identity primary key,
	nome varchar(30) not null,
	CPF varchar(15) not null,
	endereco varchar(50) not null,
	telefone varchar(30) not null,
	email varchar(50) not null,
	pretensaoSalarial decimal(18,2) not null,
	cargoPretendido varchar(50) not null,
	formacao1 varchar(50) not null,
	formacao2 varchar(50),
	formacao3 varchar(50),
	formacao4 varchar(50),
	formacao5 varchar(50),
	experiencia1 varchar(50),
	experiencia2 varchar(50),
	experiencia3 varchar(50),
	idioma1 varchar(20) not null,
	idioma2 varchar(20),
	idioma3 varchar(20),
)