create database dbSaresp_2024;
use dbSaresp_2024;
create table ProfessorAplicador
(
IdProfessor int primary key auto_increment, 
Nome varchar(50) not null,
CPF bigint not null,
RG int not null, 
Telefone bigint not null, 
Nascimento date not null
);

create table aluno 
(
idAluno int primary key auto_increment,
Nome Varchar(50) not null, 
Email varchar(150) not null, 
Telefone bigint not null,
Serie varchar(10) not null,
Turma varchar(10) not null,
Nascimento date not null
)


